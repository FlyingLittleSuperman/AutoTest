using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevComponents.AdvTree;
using Newtonsoft.Json;
using SeleniumConfig.Bizdef.Entity;
using SeleniumConfig.CommonClass;

namespace SeleniumConfig.Bizdef
{
    public class BizdefTree
    {
        /// <summary>
        /// 创建业务定制树
        /// </summary>
        /// <param name="tree"></param>
        public static void CreateBizdef(AdvTree tree)
        {
            String url = StaticValue.ServicePath.BizdefPath;
            url += "?parentGuid=&recursive=1";
            String userName = StaticValue.ServicePath.UserName;
            String passWord = StaticValue.ServicePath.PassWord;
            String result = RestUserLoginService.Get(url, "", userName, passWord);

            List<BizdefPackageEntity> bidefPackageList = JsonConvert.DeserializeObject<List<BizdefPackageEntity>>(result);
  
            foreach (var bizdefPackage in bidefPackageList)
            {
                Node nodePackage = new Node();
                nodePackage.Name = "PACKAGE_" + bizdefPackage.Id;
                nodePackage.Text = bizdefPackage.Name;
                nodePackage.Tag = bizdefPackage;
                nodePackage.Image=Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"\icon\package.png");
                nodePackage.Expanded = true;

                nodePackage.Nodes.Add(CreateDataCategortyNode());//窗口收件材料

                List<Entity.BizdefEntity> lstBizdef = new List<Entity.BizdefEntity>(bizdefPackage.Items);
                lstBizdef = lstBizdef.OrderBy(t => t.Name).ToList();
                foreach (var bizdef in lstBizdef)
                {
                    Node nodeGroup =new Node();
                    nodeGroup.Name = "BIZDEF_"+bizdef.Id;
                    nodeGroup.Text = bizdef.Name;
                    nodeGroup.Tag = bizdef;
                    nodeGroup.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icon\application_form.png");
                    nodePackage.Nodes.Add(nodeGroup);
                }

               
                tree.Nodes.Add(nodePackage);
            }


            
        }

        private static Node CreateDataCategortyNode()
        {
            String nodeName = "窗口资料收取";

            Node nodeParent=new Node();
            nodeParent.Name = Guid.NewGuid().ToString();
            nodeParent.Text = "附件材料";
            nodeParent.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icon\application_form.png");
            nodeParent.Expanded = true;

            Node nodeDataCategory=new Node();
            nodeDataCategory.Name = "FORMS_" + Guid.NewGuid().ToString();
            nodeDataCategory.Text = nodeName;
            nodeDataCategory.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icon\book.png");
            BizdefFormEntity form=new BizdefFormEntity();
            form.Id = Guid.NewGuid().ToString();
            form.BdfrGuid = Guid.NewGuid().ToString();
            form.DisplayText = nodeName;
            form.LinkUrl = StaticValue.ServicePath.DataCategoryPath;
            nodeDataCategory.Tag = form;
            nodeParent.Nodes.Add(nodeDataCategory);
            return nodeParent;
        }

        /// <summary>
        /// 创建表单树
        /// </summary>
        /// <param name="nodeParent"></param>
        /// <param name="parentId"></param>
        public static void CreateBizdefForm(Node nodeParent, String parentId)
        {
            String url = StaticValue.ServicePath.BizdefFormPath;
            url += "?bizDefGuid=" + parentId + "&parentGuid=&recursive=true";
            String userName = StaticValue.ServicePath.UserName;
            String passWord = StaticValue.ServicePath.PassWord;
            String result = RestUserLoginService.Get(url, "", userName, passWord);
            List<BizdefFormDataEntity> bizdefFormDataList = JsonConvert.DeserializeObject<List<BizdefFormDataEntity>>(result);
            foreach (BizdefFormDataEntity bizdefFormData in bizdefFormDataList)
            {
                Node nodeChildPackage =new Node();
                nodeChildPackage.Name = "FORMBACKAGE_" + bizdefFormData.Id;
                nodeChildPackage.Text = bizdefFormData.DisplayText;
                nodeChildPackage.Tag = bizdefFormData;
                nodeChildPackage.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icon\application_form.png");
                nodeParent.Nodes.Add(nodeChildPackage);
                nodeParent.Expanded = true;
                List<BizdefFormEntity> bizdefFormList = bizdefFormData.Items;
                bizdefFormList = bizdefFormList.OrderBy(o => o.DisplayText).ToList();
                foreach (var bizdefForm in bizdefFormList)
                {
                    Node nodeChild = new Node();
                    nodeChild.Name = "FORMS_" + bizdefForm.BdfrGuid;
                    nodeChild.Text = bizdefForm.DisplayText;
                    nodeChild.Tag = bizdefForm;
                    nodeChild.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icon\book.png");
                    nodeChildPackage.Nodes.Add(nodeChild);
                    nodeChildPackage.Expanded = false;
                }

            }
        }
    }
}
