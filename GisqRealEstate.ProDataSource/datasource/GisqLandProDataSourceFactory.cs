using System;
using System.Data.OleDb;
using System.Data.Odbc;

namespace GisqRealEstate.ProDataSource
{
    /// <summary>
    /// 数据类型枚举
    /// </summary>
    public enum DataSourceType
    {
        DB_SqlServer = 1,
        DB_Oracle = 2,
        DB_Odbc = 3,

    }
    /// <summary>
    /// 数据连接属性
    /// </summary>
    public class DataSite
    {
        public string dataSourceName = "";
        public DataSourceType dataSourceType = 0;
        public string dbName = "";
        public string userID = "";
        public string passWord = "";
    }

    //static class Program
    //{
    //    static void Main()
    //    {
    //        GisqLandProDataSourceFactory.databaseType = (DataSourceType)int.Parse(ConfigHelper.GetConfigString("DataBaseType"));
    //        GisqLandProDataSourceFactory.connectionString = PubConstant.ConnectionString;
    //    }
    //}

    public class GisqLandProDataSourceFactory
    {
        public static string connectionString = "";
        public static DataSourceType databaseType;

        public GisqLandProDataSourceFactory()
        {
            //
            // TODO: 在此处添加构造函数逻辑

        }
        
        #region 实例化数据连接对象

        public static GisqLandProDataSource CreateInstance()
        {
            if (databaseType == 0 || connectionString == "")
            {
                databaseType = (DataSourceType)int.Parse(ConfigHelper.GetConfigString("DataBaseType"));
                connectionString = PubConstant.ConnectionString;
            }
            return GisqLandProDataSourceFactory.CreateInstance(connectionString, databaseType);

        }
        public static GisqLandProDataSource CreateInstance(string connectionString)
        {
            return GisqLandProDataSourceFactory.CreateInstance(connectionString, DataSourceType.DB_Oracle);
        }
        public static GisqLandProDataSource CreateInstance(string connectionString, DataSourceType databaseType)
        {
            GisqLandProDataSource dataSource = null;
            switch (databaseType)
            {
                case DataSourceType.DB_SqlServer:
                    dataSource = new GisqLandProSqlDataSource(connectionString);
                    break;
                case DataSourceType.DB_Oracle:
                    dataSource = new GisqLandProOraDataSource(connectionString);
                    break;
                case DataSourceType.DB_Odbc:
                    dataSource = new GisqLandProOleDataSource(connectionString);
                    break;
                default:
                    dataSource = new GisqLandProSqlDataSource(connectionString);
                    break;
            }

            return dataSource;
        }
        public static GisqLandProDataSource CreateInstance(DataSite site)
        {
            //string conString = "";
            //switch (site.dataSourceType)
            //{
            //    case DataSourceType.DB_SqlServer:
            //        conString = "Data Source=" + site.dataSourceName + ";Initial Catalog=" + site.dbName + ";User ID=" + site.userID + ";Password=" + site.passWord;
            //        break;
            //    case DataSourceType.DB_Oracle:
            //        conString = "Data Source=" + site.dataSourceName + ";User ID=" + site.userID + ";Password=" + site.passWord;
            //        break;
            //    case DataSourceType.DB_Odbc:
            //        conString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=" + site.dataSourceName;
            //        break;
            //    default:
            //        conString = "Data Source=" + site.dataSourceName + ";Initial Catalog=" + site.dbName + ";User ID=" + site.userID + ";Password=" + site.passWord;
            //        break;
            //}
            //connectionString = conString;
            //databaseType = site.dataSourceType;
            //return GisqLandProDataSourceFactory.CreateInstance(conString, site.dataSourceType);

            return CreateInstance(site.dataSourceName, site.dbName, site.userID, site.passWord, site.dataSourceType);

        }
        public static GisqLandProDataSource CreateInstance(string dataSourceName, string catalog, string username, string password, DataSourceType dbType)
        {
            string conString = "";
            switch (dbType)
            {
                case DataSourceType.DB_SqlServer:
                    conString = "Data Source=" + dataSourceName + ";Initial Catalog=" + catalog + ";User ID=" + username + ";Password=" + password;
                    break;
                case DataSourceType.DB_Oracle:
                    conString = "Data Source=" + dataSourceName + ";User ID=" + username + ";Password=" + password;
                    break;
                case DataSourceType.DB_Odbc:
                    if (dataSourceName.IndexOf(".xlsx") != -1)//适合excel2007
                    {
                        conString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + dataSourceName;
                        conString += ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                    }
                    else if (dataSourceName.IndexOf(".xls") != -1)//Extended Properties='Excel 8.0适合excel2000-03,当 IMEX=2 时，可以读取，也可以写入。
                    {
                        conString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSourceName;
                        conString += ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                    }
                    else
                    {
                        conString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSourceName;
                    }
                    break;
                default:
                    conString = "Data Source=" + dataSourceName + ";Initial Catalog=" + catalog + ";User ID=" + username + ";Password=" + password;
                    break;
            }
            connectionString = conString;
            databaseType = dbType;

            return GisqLandProDataSourceFactory.CreateInstance(conString, databaseType);
        }

        /// <summary>
        /// 创建一个新连接
        /// CreateInstance是会把创建时的串与库类型存到静态区中去,这里不会
        /// </summary>
        /// <param name="dataSourceName"></param>
        /// <param name="catalog"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="dbType"></param>
        /// <returns></returns>
        public static GisqLandProDataSource CreateNewInstance(string dataSourceName, string catalog, string username, string password, DataSourceType dbType)
        {
            string strConnStrTmp = connectionString;
            DataSourceType databaseTypeTmp = databaseType;
            GisqLandProDataSource obj = null;
            try
            {
                obj = CreateInstance(dataSourceName, catalog, username, password, dbType);
            }
            catch (Exception x) { throw x; }
            finally
            {
                connectionString = strConnStrTmp;
                databaseType = databaseTypeTmp;
            }

            return obj;
        }


        #endregion
    }

}
