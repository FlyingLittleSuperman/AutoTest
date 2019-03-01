using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevComponents.AdvTree;
using Newtonsoft.Json;
using SeleniumConfig.CommonClass;
using SeleniumConfig.DeparmentUser.Entity;
using SeleniumConfig.ProInfo;

namespace SeleniumConfig.DeparmentUser
{
    public class DepartmentTree
    {
        public static Node nodeSelect = null;
        public static void CreateDepartment(AdvTree tree,Node nodeParent, String departmentSelectValue,String userSelectValue)
        {
            String url = StaticValue.ServicePath.DepartmentPath;
            String userName = StaticValue.ServicePath.UserName;
            String passWord = StaticValue.ServicePath.PassWord;
            String result = RestUserLoginService.Get(url, "", userName, passWord);
            List<DepartmentEntity> departmentList = JsonConvert.DeserializeObject<List<DepartmentEntity>>(result);

            List<DepartmentEntity> firstNodeDepartment
                = departmentList.Where(o => String.IsNullOrEmpty(o.Pid)).ToList();
            LoadAllDepartment(departmentList, firstNodeDepartment, nodeParent, departmentSelectValue,userSelectValue);
            tree.Nodes.Add(nodeParent);
            tree.SelectNode(nodeSelect,eTreeAction.Mouse);
        }

        /// <summary>
        /// 递归加载部门信息
        /// </summary>
        /// <param name="allDepartment"></param>
        /// <param name="parnetDepartmentList"></param>
        /// <param name="nodeParent"></param>
        private static void LoadAllDepartment(List<DepartmentEntity> allDepartment, List<DepartmentEntity> parnetDepartmentList,
            Node nodeParent, String departmentSelectValue,String userSelectValue)
        {
            foreach (DepartmentEntity department in parnetDepartmentList)
            {
                Node nodeChild=new Node();
                nodeChild.Name = "DEPARTMENT_"+department.Id;
                nodeChild.Text = department.Name;
                nodeChild.Tag = department;
                nodeChild.Image =Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"\icon\folder.png");
                if (nodeChild.Level <= 1)
                {
                    nodeChild.Expanded = true;
                }
                if (department.Id.Equals(departmentSelectValue))
                {
                    CreateDepartmentUser(nodeChild, department.Id, userSelectValue);
                }
                nodeParent.Nodes.Add(nodeChild);
                List<DepartmentEntity> childDeparment
                    = allDepartment.Where(o =>o.Pid!=null &&  o.Pid.Equals(department.Id)).ToList();
                if (childDeparment.Count > 0)
                {
                    LoadAllDepartment(allDepartment, childDeparment, nodeChild, departmentSelectValue, userSelectValue);
                }
            }
        }

        /// <summary>
        /// 创建部门用户信息
        /// </summary>
        /// <param name="nodeParent"></param>
        /// <param name="parentId"></param>
        public static void CreateDepartmentUser(Node nodeParent,String parentId,String userSelectValue)
        {
            String url = StaticValue.ServicePath.DeparmentUserPath;
            url += "?departmentid=" + parentId;
            String userName = StaticValue.ServicePath.UserName;
            String passWord = StaticValue.ServicePath.PassWord;
            String result = RestUserLoginService.Get(url, "", userName, passWord);
            List<DepartmentUserEntity> departmentUserList = JsonConvert.DeserializeObject<List<DepartmentUserEntity>>(result);
            foreach (DepartmentUserEntity departmentUser in departmentUserList)
            {
                Node nodeChild = new Node();
                nodeChild.Name = "DEPARTMENTUSER_"+departmentUser.Id;
                nodeChild.Text = departmentUser.Name;
                nodeChild.Tag = departmentUser;
                nodeChild.Expanded = true;
                if (departmentUser.Id.Equals(userSelectValue))
                {
                    nodeSelect = nodeChild;
                }
                nodeChild.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\icon\user.png");
                nodeParent.Nodes.Add(nodeChild);
            }
        }
    }
}
