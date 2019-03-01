using System;

using System.Web;
using System.Web.UI.WebControls;
using System.Data;
using System.Reflection;
using System.IO;
using System.Text;

namespace GisqRealEstate.ProDataSource
{
	/// <summary>
	/// DataTableToExcel 的摘要说明。
	/// </summary>
	public class DataTableToExcel
	{
		public DataTableToExcel()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		/// <summary>
		/// 将DataTable中的数据导出到指定的Excel文件中
		/// </summary>
		/// <param name=page>Web页面对象</param>
		/// <param name=tab>包含被导出数据的DataTable对象</param>
		/// <param name=FileName>Excel文件的名称</param>
		public static void Export(System.Web.UI.Page page,System.Data.DataTable tab,string FileName)
		{
			System.Web.HttpResponse httpResponse = page.Response;
			System.Web.UI.WebControls.DataGrid dataGrid=new System.Web.UI.WebControls.DataGrid();
			dataGrid.DataSource=tab.DefaultView;
			
			dataGrid.DataBind();
			httpResponse.AppendHeader("Content-Disposition","attachment;filename="+HttpUtility.UrlEncode(FileName,System.Text.Encoding.UTF8)); //filename=*.xls;
			
			httpResponse.ContentEncoding=System.Text.Encoding.GetEncoding("GB2312");
			httpResponse.ContentType ="application/ms-excel";
			System.IO.StringWriter tw = new System.IO.StringWriter() ;
			System.Web.UI.HtmlTextWriter hw = new System.Web.UI.HtmlTextWriter (tw);
			dataGrid.RenderControl(hw);
   
			string filePath = page.Server.MapPath(FileName);
			if( File.Exists(filePath))
			{
				File.Delete( filePath);
			}
			System.IO.StreamWriter sw = System.IO.File.CreateText(filePath);
			sw.Write(tw.ToString());
			sw.Close();
			DownFile(httpResponse,FileName,filePath);

			httpResponse.End();
		}
		private static bool DownFile(System.Web.HttpResponse Response,string fileName,string fullPath)
		{
			try
			{
				Response.ContentType = "application/octet-stream";
    
				Response.AppendHeader("Content-Disposition","attachment;filename=" +HttpUtility.UrlEncode(fileName,System.Text.Encoding.UTF8) + ";charset=GB2312"); 
				System.IO.FileStream fs= System.IO.File.OpenRead(fullPath);
				long fLen=fs.Length;
				int size=102400;//每100K同时下载数据 
				byte[] readData = new byte[size];//指定缓冲区的大小 
				if(size>fLen)size=Convert.ToInt32(fLen);
				long fPos=0;
				bool isEnd=false;
				while (!isEnd) 
				{ 
					if((fPos+size)>fLen)
					{
						size=Convert.ToInt32(fLen-fPos);
						readData = new byte[size];
						isEnd=true;
					}
					fs.Read(readData, 0, size);//读入一个压缩块 
					Response.BinaryWrite(readData);
					fPos+=size;
				} 
				fs.Close(); 
				//System.IO.File.Delete(fullPath);
				return true;
			}
			catch
			{
				return false;
			}
		}


//		/// <summary>
//		/// 传入DataTable，路径。写excel文件函数
//		/// </summary>
//		/// <param name="ds">DataTable对象</param>
//		/// <param name="strurl">文件要保留路径</param>
//		/// <returns>文件所在位置的字符串</returns>
//		public static string DataTableToExcelXls(System.Data.DataTable ds,string strurl) 
//		{ 
//			try
//			{
//				Random rd=new Random(int.Parse(DateTime.Now.ToString("MMddhhmmss")));
//				string strFileName =DateTime.Now.ToString("yyyyMMdd")+DateTime.Now.Hour+DateTime.Now.Minute+DateTime.Now.Second+rd.Next(999999).ToString()+ ".XLS";
//      
//				Excel.Application excel = new Excel.ApplicationClass();
//				Excel.WorkbookClass oWB;
//				Excel.Worksheet oSheet;
//				oWB = (Excel.WorkbookClass)(excel.Workbooks.Add(true));
//				oSheet = (Excel.Worksheet)oWB.ActiveSheet;
//				object my_object=Missing.Value;
//
//				for (int i = 0; i < ds.Columns.Count; i++) 
//				{
//					oSheet.Cells[1,i+1] =ds.Columns[i].ToString() ;
//				}
//				DataRow dr;
//				int count=ds.Rows.Count+2;
//				int I,J;
//				for(I = 2;I< count;I++)
//				{    
//					dr=ds.Rows[I-2];   
//					for(J = 1;J<(ds.Columns.Count +1) ;J++)
//					{
//						oSheet.Cells[I,J] = dr[J-1].ToString().Trim() ;   
//					}   
//				}
//				oSheet.Name=ds.TableName;
//				string path=HttpContext.Current.Server.MapPath(strurl) + "\\" + strFileName;  
//				oWB.SaveAs(path,my_object,"","",true,false,Excel.XlSaveAsAccessMode.xlNoChange,1,false,my_object,my_object);
//   
//				oWB.Close(false,null,null);
//				excel.Workbooks.Close();   
//				excel.Quit();
//
//				System.Runtime.InteropServices.Marshal.ReleaseComObject (excel);
//				System.Runtime.InteropServices.Marshal.ReleaseComObject (oWB);
//				System.Runtime.InteropServices.Marshal.ReleaseComObject (oSheet);
//
//				oSheet = null;
//				oWB= null;
//				excel = null;
//				GC.Collect();
//				GC.WaitForPendingFinalizers();
//				return path;
//			}
//			catch(Exception ee)
//			{
//				return ee.Message;
//			}  
//		}
	}
}
