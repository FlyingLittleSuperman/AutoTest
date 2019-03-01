using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SeleniumConfig.CommonClass;

namespace SeleniumConfig.SeleniumSchema
{
    public partial class FrmJAVASeleniumOutPut : DevComponents.DotNetBar.Office2007Form
    {
        public FrmJAVASeleniumOutPut()
        {
            InitializeComponent();
        }

        private void FrmJAVASeleniumOutPut_Load(object sender, EventArgs e)
        {
            ExecuteProcess();
        }

        // 2.定义委托事件  
        public event DelReadStdOutput ReadStdOutput;
        public event DelReadErrOutput ReadErrOutput;


        private void ExecuteProcess()
        {

            //3.将相应函数注册到委托事件中  
            ReadStdOutput += new DelReadStdOutput(ReadStdOutputAction);
            ReadErrOutput += new DelReadErrOutput(ReadErrOutputAction);

            Process CmdProcess = new Process();
            CmdProcess.StartInfo.FileName = "cmd.exe";      // 命令  
            String path = AppDomain.CurrentDomain.BaseDirectory;
            String diskName = path.Substring(0, 1);
            String jarFilePath = path + @"\SeleniumJAVA\Selenium.jar";
            //CmdProcess.StartInfo.Arguments = "java -jar " + jarFilePath;      // 参数  

            CmdProcess.StartInfo.CreateNoWindow = true;         // 不创建新窗口  
            CmdProcess.StartInfo.UseShellExecute = false;
            CmdProcess.StartInfo.RedirectStandardInput = true;  // 重定向输入  
            CmdProcess.StartInfo.RedirectStandardOutput = true; // 重定向标准输出  
            CmdProcess.StartInfo.RedirectStandardError = true;  // 重定向错误输出  

            CmdProcess.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            CmdProcess.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);

            CmdProcess.EnableRaisingEvents = true;                      // 启用Exited事件  
            CmdProcess.Exited += new EventHandler(CmdProcess_Exited);   // 注册进程结束事件  

            CmdProcess.Start();
            CmdProcess.StandardInput.WriteLine("java -jar " + jarFilePath +" C#");
            CmdProcess.BeginOutputReadLine();
            CmdProcess.BeginErrorReadLine();
            Application.DoEvents();
        }

        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                Application.DoEvents();
                // 4. 异步调用，需要invoke  
                try
                {
                    this.Invoke(ReadStdOutput, new object[] { e.Data });
                }
                catch (Exception er)
                {
                    Logger.Log.Error(er.ToString());
                }
               
            }
        }

        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                this.Invoke(ReadErrOutput, new object[] { e.Data });
            }
        }

        private void ReadStdOutputAction(string result)
        {
            Logger.Log.Info(result);
            txtLog.SelectionColor = Color.Black;
            txtLog.AppendText(result+"\r\n\r\n");
            //txtLog.AppendText("=============================================================================================================================================\r\n");
            txtLog.ScrollToCaret();
            //Logger.Log.Info(result + "\r\n");
        }

        private void ReadErrOutputAction(string result)
        {
            Logger.Log.Warn(result);
            txtLog.SelectionColor = Color.Red;
            txtLog.AppendText(result + "\r\n\r\n");
            //txtLog.AppendText("=============================================================================================================================================\r\n");
            txtLog.ScrollToCaret();
            //Logger.Log.Info(result + "\r\n");
        }

        private void CmdProcess_Exited(object sender, EventArgs e)
        {
            Application.DoEvents();
            // 执行结束后触发  
        }  
    }
}
