using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Data;

namespace GisqRealEstate.ProDataSource
{
	/// <summary>
	/// clsDataSde 的摘要说明。
	/// </summary>
	public class clsDataSde
	{
		public clsDataSde()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

        /// <summary>
        /// 静态方法获取数据库时间
        /// </summary>
        /// <returns></returns>
        public static string GetServerTime()
        {
            string strReturn = "";
            try
            {
                string strSql = "";
                switch (GisqLandProDataSourceFactory.databaseType)
                {
                    case DataSourceType.DB_Oracle:
                        strSql = "SELECT TO_CHAR(SYSDATE, 'YYYY-MM-DD HH:MI:SS') FROM DUAL";
                        strReturn = DbHelperOra.Query(strSql).Tables[0].Rows[0][0].ToString();
                        break;
                    case DataSourceType.DB_SqlServer:
                        strSql = "select getdate()";
                        strReturn = DbHelperSQL.Query(strSql).Tables[0].Rows[0][0].ToString();
                        break;
                    default:
                        return DateTime.Now.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return strReturn;
        }
		
        /// <summary>
        /// 静态方法获取最大值
        /// </summary>
        /// <param name="strIDName"></param>
        /// <returns></returns>
		public static string GetNextID( string strIDName)
		{
            string strCreateSql = "";
            string strReturn="";
            try
            {
                switch (GisqLandProDataSourceFactory.databaseType)
                {
                    case DataSourceType.DB_Oracle:
                        string strSql = "Select TO_NUMBER(" + strIDName + ".NEXTVAL) From dual";
                        strReturn = DbHelperOra.Query(strSql).Tables[0].Rows[0][0].ToString();
                        break;
                    case DataSourceType.DB_SqlServer:
                        SqlConnection conn = new SqlConnection(DbHelperSQL.connectionString);
                        SqlCommand cmd = new SqlCommand("gqsp_GetNextID", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@IDName", SqlDbType.NVarChar, 50).Value = strIDName;
                        cmd.Parameters.Add("@GetIDNum", SqlDbType.Int, 4).Value = 1;

                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        conn.Close();
                        strReturn = dt.Rows[0][0].ToString();
                        break;
                    default:
                        strReturn = DbHelperOra.Query("Select TO_NUMBER(" + strIDName + ".NEXTVAL) From dual").Tables[0].Rows[0][0].ToString();
                        break;
                }
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == -2146232060)
                {
                    strCreateSql = "Insert into T_LANDMAX (IDName,NextVal) Values ('" + strIDName + "',2)";
                    DbHelperSQL.ExecuteSql(strCreateSql);
                    return "1";
                }
                else
                {
                    throw new Exception("GetNewID失败!", ex);
                }
            }
            catch (OracleException ex)
            {

                if (ex.ErrorCode == -2146232008)
                {
                    strCreateSql = "CREATE SEQUENCE " + strIDName + " INCREMENT BY 1 START WITH 2 MINVALUE 1 NOCYCLE NOCACHE NOORDER";
                    DbHelperOra.ExecuteSql(strCreateSql);
                    return "1";
                }
                else
                {
                    throw new Exception("GetNewID失败!", ex);
                }
            }
            catch (Exception ex)
            { 
                
            }
            return strReturn;
		}

		public static string GetSysType()
		{
			return ConfigurationSettings.AppSettings["SystemType"].ToString();
		}

		public static string GetDbType()
		{
			return ConfigurationSettings.AppSettings["DatabaseType"].ToString();
		}

        /// <summary>
        /// 根据UserId和权限代码判断该用户是否拥有该权限
        /// </summary>
        /// <param name="lngUserId"></param>
        /// <param name="strPrivilegeCode"></param>
        /// <returns>bool</returns>
        public static bool HasPermission( long lngUserId, string strPrivilegeCode )
        {
            
            return true;
        }

        //根据系统设置项代码获取设置值
        public static string GetSysOperation(string strCode)
        {
            DataTable dt = new DataTable();
            string strSql = "select SZZ from T_XTSZ where SZ_DM = '" + strCode + "'";
            switch (GetDbType())
            {
                case "2":
                    dt = DbHelperOra.Query(strSql).Tables[0];
                    break;
                case "1":
                    dt = DbHelperSQL.Query(strSql).Tables[0];
                    break;
            }
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return "";
            }

        }

        public static string GetEnumValueByName(string strFLD_LETTER_NAME, string strENUM_NAME)
        {
            string strSql = "select a.ENUM_VALUE from T_FIELD_ENUM a,T_FIELD_EXPLAIN b "
                + " where a.FLD_EXP_ID=b.FLD_EXP_ID and a.ENUM_NAME='" + strENUM_NAME + "' "
                + " and Upper(b.FLD_LETTER_NAME) = '" + strFLD_LETTER_NAME.ToUpper() + "'";

            System.Data.DataTable dt = DbHelperAll.Query(strSql).Tables[0];
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();
            else
                return "";
        }
    }
}
