using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.AdvTree;
using Newtonsoft.Json;
using SeleniumConfig.CommonClass;
using SeleniumConfig.ProInfo.Entity;

namespace SeleniumConfig.ProInfo
{
    public class ProTree
    {
        /// <summary>
        /// 获取流程配置包信息
        /// </summary>
        /// <param name="parentNode"></param>
        /// <param name="parentId"></param>
        public static void CreateProPackage(Node parentNode,String parentId)
        {
            String url = StaticValue.ServicePath.PackagePath;
            url += "?parentId=" + parentId;
            String userName = StaticValue.ServicePath.UserName;
            String passWord = StaticValue.ServicePath.PassWord;
            String result = RestUserLoginService.Get(url, "", userName, passWord);
            List<PropackageEntity> propackages = JsonConvert.DeserializeObject<List<PropackageEntity>>(result);
            foreach (PropackageEntity propackage in propackages)
            {
                Node nodeChild = new Node();
                nodeChild.Name = "PROPACKAGE_" + propackage.Id;
                nodeChild.Text = propackage.Caption;
                nodeChild.Tag = propackage;
                nodeChild.Image =Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"\icon\package.png");
                parentNode.Nodes.Add(nodeChild);
                if (nodeChild.Level <= 1)
                {
                    nodeChild.Expanded = true;
                }
                CreateProPackage(nodeChild,propackage.Id);
            }
        }

        /// <summary>
        /// 获取流程信息
        /// </summary>
        /// <param name="nodeParent"></param>
        /// <param name="parentId"></param>
        public static void CreateProDef(Node nodeParent, String parentId)
        {
            CreateProDef(nodeParent, parentId, false);
        }
        /// <summary>
        /// 获取流程信息，是否启用勾选框
        /// </summary>
        /// <param name="nodeParent"></param>
        /// <param name="parentId"></param>
        public static void CreateProDef(Node nodeParent, String parentId,Boolean isCheck)
        {
            String url = StaticValue.ServicePath.ProdefPath;
            url += "?category=" + parentId + "&size=100&latest=true&order=desc";
            String userName = StaticValue.ServicePath.UserName;
            String passWord = StaticValue.ServicePath.PassWord;
            String result = RestUserLoginService.Post(url, "{}", userName, passWord);
            ProdefDataEntity prodefData = JsonConvert.DeserializeObject<ProdefDataEntity>(result);
            foreach (var prodef in prodefData.Data)
            {
                Node nodeChild =  new Node();
                nodeChild.Name = "PRODEF_" + prodef.Id;
                nodeChild.Text = prodef.Name;
                nodeChild.Tag = prodef;
                nodeChild.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icon\page_go.png");
                nodeParent.Nodes.Add(nodeChild);
                nodeParent.Expanded = true;
                if (isCheck)
                {
                    nodeChild.CheckBoxVisible = true;
                    nodeParent.CheckBoxVisible = true;
                }
            }
        }

        /// <summary>
        /// 获取环节信息
        /// </summary>
        /// <param name="prodefIds"></param>
        /// <returns></returns>
        public static ActdefDataEntity GetActdefInfo(String[] prodefIds)
        {
            String url = StaticValue.ServicePath.ActdefPath;
            String userName = StaticValue.ServicePath.UserName;
            String passWord = StaticValue.ServicePath.PassWord;
            var tempEntity = new { processDefKeys = prodefIds };
            string jsonData = JsonConvert.SerializeObject(tempEntity);
            String restult = RestUserLoginService.Post(url, jsonData, userName, passWord);
            ActdefDataEntity prodefData = JsonConvert.DeserializeObject<ActdefDataEntity[]>(restult)[0];
            return prodefData;
        }

        /// <summary>
        /// 加载环节信息
        /// </summary>
        /// <param name="nodeParent"></param>
        /// <param name="parentId"></param>
        public static void CreateActdef(Node nodeParent, String parentId)
        {
            ActdefDataEntity prodefData = GetActdefInfo(new string[] {parentId});
            foreach (var actdef in prodefData.ListTaskInfor)
            {
                Node nodeChild=new Node();
                nodeChild.Name = "ACTDEF_" + actdef.Task_id;
                nodeChild.Text = actdef.Task_name;
                nodeChild.Tag = actdef;
                nodeChild.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icon\book.png");
                nodeParent.Nodes.Add(nodeChild);
                nodeParent.Expanded = true;

            }

        }
    }
}
