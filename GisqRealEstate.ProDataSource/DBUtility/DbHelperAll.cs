using System;
using System.Collections.Generic;
using System.Collections;

using System.Text;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Configuration;

namespace GisqRealEstate.ProDataSource
{
    public class DbHelperAll
    {
        public static string connectionString = PubConstant.ConnectionString;

        #region  执行简单SQL语句

        public static void InitDataBaseType()
        {
            if (GisqLandProDataSourceFactory.databaseType == 0 || connectionString == "" || GisqRealEstate.ProDataSource.GisqLandProDataSourceFactory.connectionString == "")
            {
                GisqRealEstate.ProDataSource.GisqLandProDataSourceFactory.databaseType 
                    = (GisqRealEstate.ProDataSource.DataSourceType)int.Parse(GisqRealEstate.ProDataSource.ConfigHelper.GetConfigString("DataBaseType"));
                GisqRealEstate.ProDataSource.GisqLandProDataSourceFactory.connectionString = PubConstant.ConnectionString;
            }
            else
            {
                
                return;
            }
        }

        /// <summary>
        /// 获取数据库类型
        /// </summary>
        /// <returns></returns>
        public static DataSourceType GetDataBaseType()
        {
            if (GisqLandProDataSourceFactory.databaseType == 0 || connectionString == "" ||  GisqRealEstate.ProDataSource.GisqLandProDataSourceFactory.connectionString == "")
            {
                 GisqRealEstate.ProDataSource.GisqLandProDataSourceFactory.databaseType
                    = (GisqRealEstate.ProDataSource.DataSourceType)int.Parse(GisqRealEstate.ProDataSource.ConfigHelper.GetConfigString("DataBaseType"));
                 GisqRealEstate.ProDataSource.GisqLandProDataSourceFactory.connectionString = PubConstant.ConnectionString; 
                InitConn();
            }
            return GisqLandProDataSourceFactory.databaseType;
        }

        public static void InitConn()
        {
            InitDataBaseType();
            switch (GisqLandProDataSourceFactory.databaseType)
            {
                case DataSourceType.DB_Oracle:
                    DbHelperOra.objConn = new OracleConnection(connectionString);
                    break;
                case DataSourceType.DB_SqlServer:
                    DbHelperSQL.objConn = new SqlConnection(connectionString);
                    break;
            }
            return;
        }

        public static void ConnOpen()
        {
            switch (GisqLandProDataSourceFactory.databaseType)
            {
                case DataSourceType.DB_Oracle:
                    if (DbHelperOra.objConn != null && DbHelperOra.objConn.State != ConnectionState.Open)
                        DbHelperOra.objConn.Open();
                    break;
                case DataSourceType.DB_SqlServer:
                    if (DbHelperSQL.objConn != null && DbHelperSQL.objConn.State != ConnectionState.Open)
                        DbHelperSQL.objConn.Open();
                    break;
            }
        }
        public static void ConnClose()
        {
            switch (GisqLandProDataSourceFactory.databaseType)
            {
                case DataSourceType.DB_Oracle:
                    if (DbHelperOra.objConn != null && DbHelperOra.objConn.State != ConnectionState.Closed)
                        DbHelperOra.objConn.Close();
                    break;
                case DataSourceType.DB_SqlServer:
                    if (DbHelperSQL.objConn != null && DbHelperSQL.objConn.State != ConnectionState.Closed)
                        DbHelperSQL.objConn.Close();
                    break;
            }
        }

        public static int ExecuteSql(string SQLString)
        {
            int reval = 0;
            try
            {
                //InitConn();
                //ConnOpen();
                InitDataBaseType();
                switch (GisqLandProDataSourceFactory.databaseType)
                {
                    case DataSourceType.DB_Oracle:
                        reval = DbHelperOra.ExecuteSql(SQLString);
                        break;
                    case DataSourceType.DB_SqlServer:
                        reval = DbHelperSQL.ExecuteSql(SQLString);
                        break;
                    case DataSourceType.DB_Odbc:
                        reval = DbHelperOleDb.ExecuteSql(SQLString);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ConnClose();
            }

            return reval;
        }

        public static void ExecuteSqlTran(ArrayList SQLStringList)
        {
            try
            {
                //InitConn();
                //ConnOpen();
                InitDataBaseType();
                switch (GisqLandProDataSourceFactory.databaseType)
                {
                    case DataSourceType.DB_Oracle:
                        DbHelperOra.ExecuteSqlTran(SQLStringList);
                        break;
                    case DataSourceType.DB_SqlServer:
                        DbHelperSQL.ExecuteSqlTran(SQLStringList);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ConnClose();
            }

        }

        /// <summary>
		/// 向数据库里插入图像格式的字段(和上面情况类似的另一种实例)
		/// </summary>
		/// <param name="strSQL">SQL语句</param>
		/// <param name="fs">图像字节,数据库的字段类型为image的情况</param>
		/// <returns>影响的记录数</returns>
        public static int ExecuteSqlInsertImg(string strSQL, byte[] fs)
        {
            InitDataBaseType();
            int reval = 0;
            switch (GisqLandProDataSourceFactory.databaseType)
            {
                case DataSourceType.DB_Oracle:
                    reval = DbHelperOra.ExecuteSqlInsertImg(strSQL, fs);
                    break;
                case DataSourceType.DB_SqlServer:
                    reval = DbHelperSQL.ExecuteSqlInsertImg(strSQL, fs);
                    break;
            }
            return reval;
        }

        public static DataSet Query(string SQLString)
        {
            InitDataBaseType();

            DataSet ds = new DataSet();
            switch (GisqLandProDataSourceFactory.databaseType)
            {
                case DataSourceType.DB_Oracle:
                    ds = DbHelperOra.Query(SQLString);
                    break;
                case DataSourceType.DB_SqlServer:
                    ds = DbHelperSQL.Query(SQLString);
                    break;
                case DataSourceType.DB_Odbc:
                    ds = DbHelperOleDb.Query(SQLString);
                    break;
            }
            return ds;
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <returns>DataSet</returns>
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            InitDataBaseType();
            DataSet ds = new DataSet();
            switch (GisqLandProDataSourceFactory.databaseType)
            {
                case DataSourceType.DB_Oracle:
                    ds = DbHelperOra.RunProcedure(storedProcName, parameters, tableName);
                    break;
                case DataSourceType.DB_SqlServer:
                    ds = DbHelperSQL.RunProcedure(storedProcName, parameters, tableName);
                    break;
            }
            return ds;
        }

        public static DataSet QueryFromCatch(string SQLString, ref string CacheKey)
        {
            InitDataBaseType();
            DataSet ds = new DataSet();

            object objType = DataCache.GetCache(CacheKey);//从缓存读取
            if (CacheKey == "" || objType == null)
            {
                try
                {
                    CacheKey = Guid.NewGuid().ToString();
                    ds = DbHelperAll.Query(SQLString);
                    DataCache.SetCache(CacheKey, ds);//将查询的结果集放入缓存
                }
                catch(Exception ee)
                {
                    throw ee;
                }
            }
            return ds;
        }
        #endregion
    }
}
