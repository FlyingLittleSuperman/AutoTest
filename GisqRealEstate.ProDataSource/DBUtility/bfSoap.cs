using System;
using System.Xml;
using System.Web;
using System.Data;
using System.Net;
using System.Text;
using System.IO;
using System.Configuration;
using System.Web.Security;
using System.Web.Services;
using System.Security.Cryptography;
using System.Security;
namespace GisqRealEstate.ProDataSource
{
	/// <summary>
	/// bfSoap 的摘要说明。
	/// </summary>
	public class bfSoap
	{
        protected static string DatabaseTypeString = ConfigurationSettings.AppSettings["DatabaseType"];

        

        public bfSoap()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public string HasPermission( string strUserID, string strPrivilegeCode)
        {
            string strSql = " select SZZ from T_XTSZ where SZ_DM = 'LoginWebServiceUrl' ";
            string strWebServiceUrl = "";
            strWebServiceUrl = DbHelperAll.Query(strSql).Tables[0].Rows[0][0].ToString();//WebServiceUrl设置地址
            WebReference.FrameworkService wrf = new WebReference.FrameworkService();
            wrf.Url = strWebServiceUrl;
            string strBool = wrf.HasPermission( strUserID, strPrivilegeCode);
            return strBool;
        }
        public string HasPermission(GisqLandProDataSource objDataSource,string strUserID, string strPrivilegeCode)
        {
            string strSql = " select SZZ from T_XTSZ where SZ_DM = 'LoginWebServiceUrl' ";
            string strWebServiceUrl = "";
            strWebServiceUrl = objDataSource.ExecuteDataTable(strSql).Rows[0][0].ToString();//WebServiceUrl设置地址
            WebReference.FrameworkService wrf = new WebReference.FrameworkService();
            wrf.Url = strWebServiceUrl;
            string strBool = wrf.HasPermission(strUserID, strPrivilegeCode);
            return strBool;
        }
        public XmlDocument GetDeparmentInfo(string strUserID)
        {
            string strSql = " select SZZ from T_XTSZ where SZ_DM = 'LoginWebServiceUrl' ";
            string strWebServiceUrl = "";
            strWebServiceUrl = DbHelperAll.Query(strSql).Tables[0].Rows[0][0].ToString();//WebServiceUrl设置地址
            WebReference.FrameworkService wrf = new WebReference.FrameworkService();
            wrf.Url = strWebServiceUrl;
            string strDepartmentInfo = wrf.GetDepartmentInfo(strUserID);
            XmlDocument objXml = new XmlDocument();
            objXml.LoadXml(strDepartmentInfo);
            return objXml;
            //return strDepartmentInfo;
        }
	}
}
