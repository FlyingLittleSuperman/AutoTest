using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar.Controls;
using SeleniumConfig.CommonClass;
using SeleniumConfig.CreateAction.Entity;
using SeleniumConfig.DeparmentUser.Entity;
using SeleniumConfig.ProInfo.Entity;

namespace SeleniumConfig.CreateAction
{
    public class CreateActionUtil
    {
        /// <summary>
        /// 增加iframe节点
        /// </summary>
        /// <param name="iframe"></param>
        /// <param name="actdef"></param>
        /// <param name="prodef"></param>
        public static void AddIframeToXML( IFrameEntity iframe,ActdefEntity actdef,ProdefEntity prodef,String secondPackageId,String childProdefId)
        {
            String path = CreateActionCommon.GetXmlPath(prodef.Key,childProdefId);
            XmlNode nodeActdef = null;
            XmlDocument doc = GetActdefNode(actdef, prodef, out nodeActdef, path, secondPackageId);
            XmlNode nodeIframe = nodeActdef.SelectSingleNode("iframe");
            if (nodeIframe == null)
            {
                nodeIframe=doc.CreateElement("iframe") as XmlNode;
                nodeActdef.AppendChild(nodeIframe);
            }

            XmlNode nodeTempIframe = nodeIframe.SelectSingleNode("iframeChild[@ID='" + iframe.Id + "']");
            if (nodeTempIframe != null)
            {
                nodeTempIframe.ParentNode.RemoveChild(nodeTempIframe);
            }

            XmlElement elementTempIframe = doc.CreateElement("iframeChild");
            elementTempIframe.SetAttribute("ID", iframe.Id);
            elementTempIframe.SetAttribute("Name", iframe.Name);
            elementTempIframe.SetAttribute("URL", iframe.UrlPath);
            nodeIframe.AppendChild(elementTempIframe);

            doc.Save(path);

        }

        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="departmentUser"></param>
        /// <param name="actdef"></param>
        /// <param name="prodef"></param>
        /*public static void AddUserToXML(DepartmentUser departmentUser,Department department, Actdef actdef, Prodef prodef)
        {
            String path = CreateActionCommon.GetXmlPath(prodef.Key);
            XmlNode nodeActdef = null;
            XmlDocument doc = GetActdefNode(actdef, prodef, out nodeActdef, path);


            XmlNode nodeUser = nodeActdef.SelectSingleNode("user");
            if (nodeUser == null)
            {
                nodeUser = doc.CreateElement("user") as XmlNode;
                nodeActdef.AppendChild(nodeUser);
            }

            XmlElement elementUser =  nodeUser as XmlElement;
            elementUser.SetAttribute("ID", departmentUser.Id);
            elementUser.SetAttribute("Name", departmentUser.Name);
            elementUser.SetAttribute("ParentID", department.Id);
            nodeActdef.AppendChild(elementUser);

            doc.Save(path);

        }*/

        /// <summary>
        /// 添加操作元素
        /// </summary>
        public static void AddElementToXML(String iframeId,LocationElementEntity locationElement,String prodefKey,String actdefId,DataGridView dgv,String childProdefId)
        {
            String path = CreateActionCommon.GetXmlPath(prodefKey,childProdefId);
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode nodeIframeChild = doc.SelectSingleNode("//Actdef[@ID='" + actdefId + "']/iframe/iframeChild[@ID='" + iframeId + "']");
            if(nodeIframeChild==null)
                throw new Exception("请先选择要操作的Iframe");

            XmlNode nodeElement = nodeIframeChild.SelectSingleNode("LocationElement[@ID='" + locationElement.Id + "']");
            if (nodeElement == null)
            {
                nodeElement = doc.CreateElement("LocationElement");
                nodeIframeChild.AppendChild(nodeElement);
            }

            XmlElement elementLocation = nodeElement as XmlElement;
            elementLocation.SetAttribute("ID", locationElement.Id);
            elementLocation.SetAttribute("LocationType", locationElement.LocationType); //定位方式
            elementLocation.SetAttribute("Path", locationElement.LocationPath); //定位路径
            elementLocation.SetAttribute("OperateType", locationElement.OperateType); //操作类型
            elementLocation.SetAttribute("Order", locationElement.Order); //顺序
            elementLocation.SetAttribute("DefaultValue", locationElement.LocationDefaultValue);
            if (!string.IsNullOrEmpty(locationElement.SqlSchemaId))
            {
                elementLocation.SetAttribute("SqlSchemaId", locationElement.SqlSchemaId); //SQL方案内码
            }
            else
            {
                elementLocation.SetAttribute("SqlSchemaId", ""); //SQL方案内码
            }
            elementLocation.SetAttribute("Introduce", locationElement.Introduce); //备注说明
            elementLocation.SetAttribute("IsRandom", locationElement.IsRanddom.ToString());
            elementLocation.SetAttribute("WaitSecond", locationElement.WaitSecond.ToString());//操作等待时间
            List<XmlNode> listAllNode = nodeIframeChild.SelectNodes("LocationElement").ToList<XmlNode>();
            listAllNode = listAllNode.OrderBy(p => TypeConvert.ToConvert<object, long>(p.Attributes["Order"].Value, false)).ToList();
            foreach (XmlNode nodeDelete in nodeIframeChild.ChildNodes)
            {
                nodeDelete.ParentNode.RemoveChild(nodeDelete);
            }
            foreach (XmlNode nodeTemp in listAllNode)
            {
                nodeIframeChild.AppendChild(nodeTemp);
            }
            doc.Save(path);

            ReadLocationElement(doc, iframeId,actdefId, locationElement.Id, dgv);
        }

        /// <summary>
        /// 调整操作顺序
        /// </summary>
        /// <param name="dataGridViewRowList"></param>
        /// <param name="prodefKey"></param>
        /// <param name="childProdefId"></param>
        /// <param name="actdefId"></param>
        /// <param name="iframeId"></param>
        public static void UpdateElementOrder(List<DataGridViewRow> dataGridViewRowList,String prodefKey,
            String childProdefId,String actdefId,String iframeId)
        {
            String path = CreateActionCommon.GetXmlPath(prodefKey, childProdefId);
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode nodeIframeChild = doc.SelectSingleNode("//Actdef[@ID='" + actdefId + "']/iframe/iframeChild[@ID='" + iframeId + "']");
            if (nodeIframeChild == null)
                throw new Exception("请先选择要操作的Iframe");

            dataGridViewRowList.ForEach(p =>
            {
                String id = p.Cells["LocationID"].Value.ToString();
                XmlElement element= (XmlElement)nodeIframeChild.SelectSingleNode("LocationElement[@ID='" + id + "']");
                element.SetAttribute("Order", p.Cells["Order"].Value.ToString());
            });


            List<XmlNode> listAllNode = nodeIframeChild.SelectNodes("LocationElement").ToList<XmlNode>();
            listAllNode = listAllNode.OrderBy(p => TypeConvert.ToConvert<object, long>(p.Attributes["Order"].Value, false)).ToList();
            foreach (XmlNode nodeDelete in nodeIframeChild.ChildNodes)
            {
                nodeDelete.ParentNode.RemoveChild(nodeDelete);
            }
            foreach (XmlNode nodeTemp in listAllNode)
            {
                nodeIframeChild.AppendChild(nodeTemp);
            }
            doc.Save(path);
        }
        /// <summary>
        /// 添加子页面操作元素
        /// </summary>
        public static void AddChildElementToXML(String iframeId,String childIframeId, 
            LocationElementEntity locationElement, String prodefKey,String actdefId, DataGridView dgv,String childProdefId)
        {
            String path = CreateActionCommon.GetXmlPath(prodefKey, childProdefId);
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode nodeIframeChild = doc.SelectSingleNode("//Actdef[@ID='" + actdefId + "']/iframe/iframeChild[@ID='" + iframeId + "']");
            if (nodeIframeChild == null)
                throw new Exception("请先选择要操作的Iframe");

            XmlNode nodeElement = nodeIframeChild.SelectSingleNode("LocationElement[@ID='" + childIframeId + "']");
            if (nodeElement == null)
            {
                nodeElement = doc.CreateElement("LocationElement");
                nodeIframeChild.AppendChild(nodeElement);
            }

            XmlNode nodeChildElement =
                nodeElement.SelectSingleNode("ChildLocationElement[@ID='" + locationElement.Id + "']");
            if (nodeChildElement == null)
            {
                nodeChildElement = doc.CreateElement("ChildLocationElement");
                nodeElement.AppendChild(nodeChildElement);
            }



            XmlElement element = nodeChildElement as XmlElement;
            element.SetAttribute("ID", locationElement.Id);
            element.SetAttribute("LocationType", locationElement.LocationType); //定位方式
            element.SetAttribute("Path", locationElement.LocationPath); //定位路径
            element.SetAttribute("OperateType", locationElement.OperateType); //操作类型
            element.SetAttribute("Order", locationElement.Order); //顺序
            element.SetAttribute("DefaultValue", locationElement.LocationDefaultValue); //顺序
            if (!string.IsNullOrEmpty(locationElement.SqlSchemaId))
            {
                element.SetAttribute("SqlSchemaId", locationElement.SqlSchemaId);
            }
            else
            {
                element.SetAttribute("SqlSchemaId", "");
            }
            element.SetAttribute("Introduce", locationElement.Introduce); //备注说明
            element.SetAttribute("IsRandom", locationElement.IsRanddom.ToString()); //是否加随机数
            element.SetAttribute("WaitSecond", locationElement.WaitSecond.ToString()); //是否加随机数
            List<XmlNode> listAllNode = nodeElement.SelectNodes("ChildLocationElement").ToList<XmlNode>();
            listAllNode = listAllNode.OrderBy(p => TypeConvert.ToConvert<object, long>(p.Attributes["Order"].Value, false)).ToList();
            foreach (XmlNode nodeDelete in nodeElement.ChildNodes)
            {
                nodeDelete.ParentNode.RemoveChild(nodeDelete);
            }
            foreach (XmlNode nodeTemp in listAllNode)
            {
                nodeElement.AppendChild(nodeTemp);
            }
            doc.Save(path);
            ReadChildLocationElement(doc, iframeId, childIframeId,locationElement.Id, dgv);
        }


        /// <summary>
        /// 调整子Iframe操作顺序
        /// </summary>
        /// <param name="dataGridViewRowList"></param>
        /// <param name="prodefKey"></param>
        /// <param name="childProdefId"></param>
        /// <param name="actdefId"></param>
        /// <param name="iframeId"></param>
        public static void UpdateChildElementOrder(List<DataGridViewRow> dataGridViewRowList, String prodefKey,
            String childProdefId, String actdefId, String iframeId,String locationElementId)
        {
            String path = CreateActionCommon.GetXmlPath(prodefKey, childProdefId);
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode nodeLocationElement= doc.SelectSingleNode("//Actdef[@ID='" + actdefId + "']/" +
                                                           "iframe/iframeChild[@ID='" + iframeId + "']/LocationElement[@ID='"+locationElementId+"']");

            dataGridViewRowList.ForEach(p =>
            {
                String id = p.Cells["ChildLocationID"].Value.ToString();
                XmlElement element = (XmlElement)nodeLocationElement.SelectSingleNode("ChildLocationElement[@ID='" + id + "']");
                element.SetAttribute("Order", p.Cells["ChildOrder"].Value.ToString());
            });

            List<XmlNode> listAllNode = nodeLocationElement.SelectNodes("ChildLocationElement").ToList<XmlNode>();
            listAllNode = listAllNode.OrderBy(p => TypeConvert.ToConvert<object, long>(p.Attributes["Order"].Value, false)).ToList();
            foreach (XmlNode nodeDelete in nodeLocationElement.ChildNodes)
            {
                nodeDelete.ParentNode.RemoveChild(nodeDelete);
            }
            foreach (XmlNode nodeTemp in listAllNode)
            {
                nodeLocationElement.AppendChild(nodeTemp);
            }

            doc.Save(path);
        }


        /// <summary>
        /// 添加环节信息
        /// </summary>
        /// <param name="actdef"></param>
        /// <param name="prodef"></param>
        /// <param name="nodeActdef"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        private static XmlDocument GetActdefNode(ActdefEntity actdef, ProdefEntity prodef, 
            out XmlNode nodeActdef, String path,String secondPackageId)
        {
           
            XmlDocument doc = new XmlDocument();
            if (File.Exists(path))
                doc.Load(path);
            XmlNode nodeRoot = doc.SelectSingleNode("Element");
            if (nodeRoot == null)
            {
                XmlDeclaration declar = doc.CreateXmlDeclaration("1.0", "utf-8", "yes");
                doc.AppendChild(declar);
                nodeRoot = doc.CreateElement("Element") as XmlNode;
                doc.AppendChild(nodeRoot);
            }

            XmlNode nodeProdef = nodeRoot.SelectSingleNode("Prodef[@ID='" + prodef.Key + "']");
            if (nodeProdef == null)
            {
                XmlElement elementProdef = doc.CreateElement("Prodef");
                elementProdef.SetAttribute("ID", prodef.Key);
                elementProdef.SetAttribute("Name", prodef.Name);
                elementProdef.SetAttribute("PackageID", secondPackageId);
                nodeProdef = elementProdef as XmlElement;
                nodeRoot.AppendChild(nodeProdef);

            }

            nodeActdef = nodeProdef.SelectSingleNode("Actdef[@ID='" + actdef.Task_id + "']");
            if (nodeActdef == null)
            {
                XmlElement elementActdef = doc.CreateElement("Actdef");
                elementActdef.SetAttribute("ID", actdef.Task_id);
                elementActdef.SetAttribute("Name", actdef.Task_name);
                nodeActdef = elementActdef as XmlElement;
                nodeProdef.AppendChild(nodeActdef);
            }
            return doc;
        }

        /// <summary>
        /// 读取所有iframe信息
        /// </summary>
        /// <param name="prodefId"></param>
        /// <param name="actdefId"></param>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public static DataTable ReadIframe(String prodefId,String actdefId,DataGridView dgv,String childProdefId)
        {
            String path = CreateActionCommon.GetXmlPath(prodefId, childProdefId);
            XmlDocument doc = new XmlDocument();
            if (File.Exists(path))
                doc.Load(path);
            return ReadIframe(actdefId,doc, dgv);
        }

        /// <summary>
        /// 读取环节用户信息
        /// </summary>
        /// <param name="prodefId"></param>
        /// <param name="actdefId"></param>
        /// <param name="txtUser"></param>
      /*  public static void ReadUser(String prodefId, String actdefId, TextBoxX txtUser)
        {
            String path = CreateActionCommon.GetXmlPath(prodefId);
            XmlDocument doc = new XmlDocument();
            if (File.Exists(path))
                doc.Load(path);
            XmlNode nodeUser = doc.SelectSingleNode("//Actdef[@ID='" + actdefId + "']/user");
            if (nodeUser != null)
            {
                txtUser.Tag = nodeUser.Attributes["ID"].Value;
                txtUser.Text = nodeUser.Attributes["Name"].Value;
                txtUser.AccessibleDescription = nodeUser.Attributes["ParentID"].Value;
            }
            else
            {
                txtUser.Tag = "";
                txtUser.Text = "";
                txtUser.AccessibleDescription = "";
                
            }
        }*/

        private static DataTable ReadIframe(String actdefId,XmlDocument document, DataGridView dgv)
        {
            XmlNode nodeIfame = document.SelectSingleNode("//Actdef[@ID='" + actdefId + "']/iframe");
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("iframeName");
            dt.Columns.Add("iframeUrl");
            if (nodeIfame != null)
            {

                foreach (XmlNode xmlNode in nodeIfame.ChildNodes)
                {
                    DataRow dr = dt.NewRow();
                    dr["ID"] = xmlNode.Attributes["ID"].Value;
                    dr["iframeName"] = xmlNode.Attributes["Name"].Value;
                    dr["iframeUrl"] = xmlNode.Attributes["URL"].Value;
                    dt.Rows.Add(dr);
                }
            }
            dgv.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dgv.Rows[0].Selected = false;
                dgv.CurrentCell = null;
            }
            return dt;
        }

        /// <summary>
        /// 删除指定的iframe信息
        /// </summary>
        /// <param name="prodefId"></param>
        /// <param name="actdefId"></param>
        /// <param name="iframeId"></param>
        public static void DeleteIframe(String prodefId, String actdefId,String iframeId,bool IsDeleteAll,DataGridView dgv,String childProdefId)
        {
            String path = CreateActionCommon.GetXmlPath(prodefId, childProdefId);
            XmlDocument doc = new XmlDocument();
            if (File.Exists(path))
                doc.Load(path);
            if (IsDeleteAll)
            {
                XmlNode nodeIfame = doc.SelectSingleNode("//Actdef[@ID='" + actdefId + "']/iframe");
                if (nodeIfame != null)
                {
                    nodeIfame.RemoveAll();
                }
            }
            else
            {
                XmlNode nodeIfame = doc.SelectSingleNode("//Actdef[@ID='" + actdefId + "']/iframe/iframeChild[@ID='" + iframeId + "']");
                if (nodeIfame != null)
                {
                    nodeIfame.ParentNode.RemoveChild(nodeIfame);
                }
            }

            doc.Save(path);
            ReadIframe(actdefId,doc, dgv);

        }

        /// <summary>
        /// 读取指定的Iframe元素信息
        /// </summary>
        /// <param name="iframeId"></param>
        /// <param name="prodefId"></param>
        /// <param name="selectId"></param>
        /// <param name="dgv"></param>
        public static void ReadLocationElement(String iframeId, String prodefId,String actdefId,String selectId
            ,DataGridView dgv,String childProdefId)
        {

            String path = CreateActionCommon.GetXmlPath(prodefId, childProdefId);
            XmlDocument doc = new XmlDocument();
            if (File.Exists(path))
                doc.Load(path);

            ReadLocationElement(doc, iframeId,actdefId, selectId, dgv);
        }

        public static void ReadLocationElement(XmlDocument doc, String iframeId, String actdefId,String selectId
            , DataGridView dgv)
        {
            XmlNode nodeLocationElement = doc.SelectSingleNode("//Actdef[@ID='" + actdefId + "']/iframe/iframeChild[@ID='" + iframeId + "']");
          
            DataTable dt = new DataTable();
            dt.Columns.Add("LocationID");
            dt.Columns.Add("LocationType");
            dt.Columns.Add("LocationPath");
            dt.Columns.Add("OperateType");
            dt.Columns.Add("DefaultValue");
            dt.Columns.Add("Order");
            dt.Columns.Add("Introduce");
            dt.Columns.Add("IsRandom");
            dt.Columns.Add("WaitSecond");
            dt.Columns.Add("LocationSqlSchemaId");
            if (nodeLocationElement != null && nodeLocationElement.HasChildNodes)
            {
                foreach (XmlNode node in nodeLocationElement.ChildNodes)
                {
                    DataRow dr = dt.NewRow();
                    if (node.Attributes != null)
                    {
                        dr["LocationID"] = node.Attributes["ID"].Value;
                        dr["LocationType"] = node.Attributes["LocationType"].Value;
                        String operateType = node.Attributes["OperateType"].Value;
                        switch (operateType)
                        {
                            case "CLICK":
                                operateType = "点击";
                                break;
                            case "SENDKEYS":
                                operateType = "赋值";
                                break;
                            case "FR":
                                operateType = "帆软表单";
                                break;
                            case "CIRCLESENDKEYS":
                                operateType = "循环赋值";
                                break;
                            case "IFRAME":
                                operateType = "弹出Iframe";
                                break;
                            case "QT":
                                operateType = "其他";
                                break;
                        }

                        dr["OperateType"] = operateType;
                        dr["LocationPath"] = node.Attributes["Path"].Value;
                        dr["DefaultValue"] = node.Attributes["DefaultValue"].Value;
                        dr["Order"] = node.Attributes["Order"].Value;
                        dr["Introduce"] = node.Attributes["Introduce"] == null ? "" : node.Attributes["Introduce"].Value;
                        dr["IsRandom"] = node.Attributes["IsRandom"] == null ? "" : node.Attributes["IsRandom"].Value;
                        dr["WaitSecond"] = node.Attributes["WaitSecond"] == null
                            ? "0"
                            : node.Attributes["WaitSecond"].Value;
                        dr["LocationSqlSchemaId"] =
                            node.Attributes["SqlSchemaId"] == null ? "" : node.Attributes["SqlSchemaId"].Value;
                        dt.Rows.Add(dr);
                    }
                }
            }

            dgv.DataSource = dt;
            if (String.IsNullOrEmpty(selectId))
            {
                if (dt.Rows.Count > 0)
                {
                    dgv.Rows[0].Selected = false;
                    dgv.CurrentCell = null;
                }
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    //默认选中行
                    List<DataGridViewRow> dataGridViewRowList
                        = dgv.Rows.ToList<DataGridViewRow>();
                    DataGridViewRow dgvSelectRow =
                        dataGridViewRowList.Where(o => o.Cells["LocationID"].Value.ToString().Equals(selectId))
                            .FirstOrDefault();
                    if (dgvSelectRow != null)
                    {
                        dgvSelectRow.Selected = true;
                        dgv.CurrentCell = dgvSelectRow.Cells[0];
                    }
                }
               
            }
        }



        /// <summary>
        /// 读取子Iframe元素信息
        /// </summary>
        /// <param name="iframeId"></param>
        /// <param name="childIframeId"></param>
        /// <param name="prodefId"></param>
        /// <param name="selectId"></param>
        /// <param name="dgv"></param>
        public static void ReadChildLocationElement(String iframeId,String childIframeId, String prodefId, 
            String selectId
           , DataGridView dgv,String childProdefId)
        {
            String path = CreateActionCommon.GetXmlPath(prodefId,childProdefId);
            XmlDocument doc = new XmlDocument();
            if (File.Exists(path))
                doc.Load(path);
            ReadChildLocationElement(doc, iframeId, childIframeId,selectId, dgv);
        }

        /// <summary>
        /// 读取子iframe元素信息
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="iframeId"></param>
        /// <param name="childIframeId"></param>
        /// <param name="selectId"></param>
        /// <param name="dgv"></param>
        public static void ReadChildLocationElement(XmlDocument doc, String iframeId,String childIframeId, String selectId
            , DataGridView dgv)
        {
            XmlNode nodeLocationElement = doc.SelectSingleNode("//LocationElement[@ID='" + childIframeId + "']");
            DataTable dt = new DataTable();
            dt.Columns.Add("ChildLocationID");
            dt.Columns.Add("ChildLocationType");
            dt.Columns.Add("ChildLocationPath");
            dt.Columns.Add("ChildOperateType");
            dt.Columns.Add("ChildDefaultValue");
            dt.Columns.Add("ChildOrder");
            dt.Columns.Add("ChildIntroduce");
            dt.Columns.Add("ChildIsRandom");
            dt.Columns.Add("ChildWaitSecond");
            dt.Columns.Add("ChildLocationSqlSchemaId");

            if (nodeLocationElement != null && nodeLocationElement.HasChildNodes)
            {
                foreach (XmlNode node in nodeLocationElement.ChildNodes)
                {
                    DataRow dr = dt.NewRow();
                    if (node.Attributes != null)
                    {
                        dr["ChildLocationID"] = node.Attributes["ID"].Value;
                        dr["ChildLocationType"] = node.Attributes["LocationType"].Value;
                        String operateType = node.Attributes["OperateType"].Value;
                        switch (operateType)
                        {
                            case "CLICK":
                                operateType = "点击";
                                break;
                            case "SENDKEYS":
                                operateType = "赋值";
                                break;
                            case "FR":
                                operateType = "帆软表单";
                                break;
                            case "CIRCLESENDKEYS":
                                operateType = "循环赋值";
                                break;
                            case "IFRAME":
                                operateType = "弹出Iframe";
                                break;
                            case "QT":
                                operateType = "其他";
                                break;
                        }

                        dr["ChildOperateType"] = operateType;
                        dr["ChildLocationPath"] = node.Attributes["Path"].Value;
                        dr["ChildDefaultValue"] = node.Attributes["DefaultValue"].Value;
                        dr["ChildOrder"] = node.Attributes["Order"].Value;
                        dr["ChildIntroduce"] = node.Attributes["Introduce"] == null
                            ? ""
                            : node.Attributes["Introduce"].Value;
                        dr["ChildIsRandom"] = node.Attributes["IsRandom"] == null
                            ? ""
                            : node.Attributes["IsRandom"].Value;
                        dr["ChildWaitSecond"] = node.Attributes["WaitSecond"] == null
                            ? "0"
                            : node.Attributes["WaitSecond"].Value;
                        dr["ChildLocationSqlSchemaId"] = node.Attributes["SqlSchemaId"] == null
                            ? ""
                            : node.Attributes["SqlSchemaId"].Value;
                        dt.Rows.Add(dr);
                    }
                }
            }

            dgv.DataSource = dt;
            if (String.IsNullOrEmpty(selectId))
            {
                if (dt.Rows.Count > 0)
                {
                    dgv.Rows[0].Selected = false;
                    dgv.CurrentCell = null;
                }
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    //默认选中行
                    List<DataGridViewRow> dataGridViewRowList
                        = dgv.Rows.ToList<DataGridViewRow>();
                    DataGridViewRow dgvSelectRow =
                        dataGridViewRowList
                            .FirstOrDefault(o => o.Cells["ChildLocationID"].Value.ToString().Equals(selectId));
                    if (dgvSelectRow != null)
                    {
                        dgvSelectRow.Selected = true;
                        dgv.CurrentCell = dgvSelectRow.Cells[0];
                    }
                }
             
            }
        }

        /// <summary>
        /// 删除页面操作元素
        /// </summary>
        /// <param name="prodefId"></param>
        /// <param name="actdefId"></param>
        /// <param name="iframeId"></param>
        /// <param name="locationElementId"></param>
        public static void DeleteLocationElement(String prodefId,String actdefId,
            String iframeId,String locationElementId,DataGridView dgv,String childProdefId)
        {
            String path = CreateActionCommon.GetXmlPath(prodefId,childProdefId);
            XmlDocument doc = new XmlDocument();
            if (File.Exists(path))
                doc.Load(path);

            XmlNode node = doc.SelectSingleNode("//Actdef[@ID='"+actdefId+"']/iframe/iframeChild[@ID='"+iframeId+"']/LocationElement[@ID='"+locationElementId+"']");
            if (node != null)
            {
                node.ParentNode.RemoveChild(node);
            }

            doc.Save(path);
            ReadLocationElement(doc, iframeId, actdefId, "", dgv);
        }

        /// <summary>
        /// 删除子iframe元素 信息
        /// </summary>
        /// <param name="prodefId"></param>
        /// <param name="actdefId"></param>
        /// <param name="iframeId"></param>
        /// <param name="locationElementId"></param>
        /// <param name="childLocationElementId"></param>
        /// <param name="dgv"></param>
        /// <param name="childProdefId"></param>
        public static void DeleteChildLocationElement(String prodefId, String actdefId, String iframeId,
            String locationElementId
            , String childLocationElementId, DataGridView dgv,String childProdefId)
        {
            String path = CreateActionCommon.GetXmlPath(prodefId,childProdefId);
            XmlDocument doc = new XmlDocument();
            if (File.Exists(path))
                doc.Load(path);

            XmlNode node = doc.SelectSingleNode("//Actdef[@ID='" + actdefId + "']/iframe/" +
                                                "iframeChild[@ID='" + iframeId + "']/" +
                                                "LocationElement[@ID='" + locationElementId + "']/ChildLocationElement[@ID='"+childLocationElementId+"']");
            if (node != null)
            {
                node.ParentNode.RemoveChild(node);
            }
            doc.Save(path);
            ReadChildLocationElement(doc,iframeId,locationElementId,"",dgv);
        }
    }
}
