using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Text;

namespace GisqRealEstate.ProDataSource
{
    public class GisqLandProSqlDataSource : GisqLandProDataSource
    {
        private SqlConnection _connection;
        private SqlTransaction _transaction;
        /// <summary>
        /// 是否启动事务的标志2009-09-14
        /// </summary>
        private bool _beginTransaction;

        public GisqLandProSqlDataSource(string connectionString)
        {
            this._connection = new SqlConnection(connectionString);
            this._transaction = null;
            this._beginTransaction = false;
        }

        /// <summary>
        /// 得到数据库的连接信息
        /// </summary>
        public override IDbConnection Connection
        {
            get
            {
                if (this._connection.State != ConnectionState.Open)
                {
                    this._connection.Open();
                }
                return this._connection;
            }
        }

        /// <summary>
        /// 公开事务连接操作
        /// </summary>
        public override IDbTransaction Transaction
        {
            get
            {
                return this._transaction;
            }
        }

        public override ConnectionState State
        {
            get
            {
                return this._connection.State;
            }
        }

        /// <summary>
        /// 数据库类型属性
        /// </summary>
        public override DataSourceType DbType
        {
            get { return DataSourceType.DB_SqlServer; }
        }
        /// <summary>
        /// 根据数据库的不同，返回sql语句中截取字符串的函数
        /// </summary>
        public override string SubString
        {
            get { return "substring"; }
        }

        /// <summary>
        /// SQLSERVER返回本身
        /// </summary>
        /// <param name="strDate"></param>
        /// <returns></returns>
        public override string ToDate(string strDate)
        {
            return " CONVERT(varchar, '" + strDate + "', 23) ";
        }

        public override string ToDate(string strDate, bool IsLongFormat)
        {
            return "'" + strDate + "'";
        }

        /// <summary>
        /// 获取数据库时间字段的短日期格式内容,在SELECT语句中使用
        /// </summary>
        /// <param name="strColName">字段名称</param>
        /// <returns></returns>
        public override string FormtDateSql(string strColName)
        {
            return FormtDateSql(strColName, strColName);
        }
        /// <summary>
        /// 获取数据库时间字段的短日期格式内容,在SELECT语句中使用
        /// </summary>
        /// <param name="strColName">字段名称</param>
        /// <param name="strAnotherName">字段别名</param>
        /// <returns></returns>
        public override string FormtDateSql(string strColName, string strAnotherName)
        {
            return FormtDateSql(strColName, strAnotherName, false);
        }
        /// <summary>
        /// 获取数据库时间字段的短日期格式内容,在SELECT语句中使用
        /// </summary>
        /// <param name="strColName">字段名称</param>
        /// <param name="strAnotherName">字段别名</param>
        /// <param name="IsLongFormat">是否是长日期格式</param>
        /// <returns></returns>
        public override string FormtDateSql(string strColName, string strAnotherName, bool IsLongFormat)
        {
            if (IsLongFormat)
            {
                return " case year(" + strColName + ") when '1899' then '' when '' then '' else CONVERT(varchar, " + strColName + ", 120) end as " + strAnotherName + " ";
            }
            else
            {
                return " case year(" + strColName + ") when '1899' then '' when '' then '' else CONVERT(varchar, " + strColName + ", 23) end as " + strAnotherName + " ";
            }
        }

        public override string GetEnumNameByValue(string strDicName, string strValue)
        {
            string strSql = "select dbo.getenumname('" + strDicName + "','" + strValue + "') ";

            DataTable dt = ExecuteDataTable(strSql);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// SQL语句中的加号连接符号,sqlserver为“+”，oracle为“||”
        /// </summary>
        public override string Plus
        {
            get { return " + "; }
        }
        /// <summary>
        /// 根据数据库的不同，返回sql语句中DBO前缀
        /// </summary>
        public override string Dbo
        {
            get { return "dbo."; }
        }

        /// <summary>
        /// 根据数据库的不同，返回sql语句空值判断的函数
        /// </summary>
        public override string IsNull
        {
            get { return "isnull"; }
        }

        public override void Open()
        {
            if (this._connection.State != ConnectionState.Open)
                this._connection.Open();

        }

        public override void Close()
        {
            if (this._connection.State == ConnectionState.Open)
                this._connection.Close();
        }

        public override void BeginTransaction()
        {
            this._transaction = this._connection.BeginTransaction();
            this._beginTransaction = true;
        }

        public override void CommitTransaction()
        {
            if (this._beginTransaction)
            {
                this._transaction.Commit();
                this._beginTransaction = false;
            }
        }

        public override void RollBackTransaction()
        {
            if (this._beginTransaction)
            {
                this._transaction.Rollback();
                this._beginTransaction = false;
            }
        }

        public override DataSourceType instDataSourceType()
        {
            return DataSourceType.DB_SqlServer;
        }
        #region ExecuteNonQuery
        /// <summary>
        /// 执行Sql语句，并返回受影响的行数
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public override int ExecuteNonQuery(string commandText)
        {
            try
            {
                SqlCommand command = new SqlCommand(commandText, this.Connection as SqlConnection, this._transaction);
                return command.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                throw new Exception(string.Format("{0},{1}", x.Message, commandText));
            }

        }
        #endregion
        #region ExecuteReader
        /// <summary>
        /// 执行命令，返回一个类型化的IDataReader
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public override IDataReader ExecuteReader(string commandText)
        {

            SqlCommand command = new SqlCommand(commandText, this.Connection as SqlConnection, this._transaction);
            return command.ExecuteReader();

        }
        #endregion
        #region ExecuteScalar
        /// <summary>
        /// 执行命令，返回一个值
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public override object ExecuteScalar(string commandText)
        {

            SqlCommand command = new SqlCommand(commandText, this.Connection as SqlConnection, this._transaction);
            return command.ExecuteScalar();

        }
        #endregion

        #region ExecuteDataSet
        /// <summary>
        /// 执行命令，返回一个DataSet
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public override DataSet ExecuteDataSet(string commandText)
        {
            DataSet ds = new DataSet();
            SqlCommand command = new SqlCommand(commandText, this.Connection as SqlConnection, this._transaction);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(ds, "ds");

            return ds;
        }
        #endregion

        #region ExecuteDataTable
        /// <summary>
        /// 执行命令，返回一个DataTable
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public override DataTable ExecuteDataTable(string commandText)
        {
            try
            {
                return ExecuteDataSet(commandText).Tables[0];
            }
            catch (Exception x)
            {
                throw new Exception(string.Format("{0},{1}", x.Message, commandText));
            }
        }
        #endregion

        #region GetServerTime
        public override DateTime GetServerTime()
        {
            DateTime DtmServerdate = DateTime.Now;
            SqlDataReader objRead = null;
            string strQuerySql = "";

            strQuerySql = "select CONVERT( datetime, getdate(),121)";

            try
            {
                objRead = (SqlDataReader)ExecuteReader(strQuerySql);
            }
            catch (SqlException ex)
            {
                if (objRead != null)
                {
                    objRead.Close();
                }
                throw new Exception("GetServerTime失败!", ex);
            }
            objRead.Read();
            DtmServerdate = objRead.GetDateTime(0);

            if (objRead != null)
            {
                objRead.Close();
            }
            return DtmServerdate;
        }
        #endregion

        #region GetNewID
        public override long GetNewID(string SeqName)
        {
            long intNewid = GetNewID(SeqName, 1);
            return intNewid;
        }
        public override long GetNewID(string SeqName, int Count)
        {
            long intNewid = 0;
            string strCreateSql = "";
            string strQuerySql = "";
            SqlDataReader objRead = null;

            strQuerySql = "dbo.gqsp_GetNextID '" + SeqName + "' ," + Count + "";//声明存储过程名

            //right:
            try
            {

                objRead = (SqlDataReader)ExecuteReader(strQuerySql);
            }
            catch (SqlException ex)
            {
                if (objRead != null)
                {
                    objRead.Close();
                }
                if (ex.ErrorCode == -2146232060)//-2147217900
                {

                    strCreateSql = "Insert into T_LANDMAX (IDName,NextVal) Values ('" + SeqName + "',2)";

                    ExecuteNonQuery(strCreateSql);

                    return 1;
                    //goto right;
                }
                else
                {
                    throw new Exception("GetNewID失败!", ex);
                }

            }

            objRead.Read();
            intNewid = Convert.ToInt64(objRead.GetValue(0));

            if (objRead != null)
            {
                objRead.Close();
            }
            return intNewid;
        }
        #endregion

        #region GetPagingSql
        /// <summary>
        /// 获取sqlserver分页的sql语句
        /// </summary>
        /// <param name="strQuerySql"></param>
        /// <param name="lngPageIndex"></param>
        /// <param name="lngPageSize"></param>
        /// <param name="strKeyId">sqlserver分页必需</param>
        /// <param name="strOrderSql">sqlserver分页必需</param>
        /// <returns></returns>
        public override string GetPagingSql(string strQuerySql, long lngPageIndex, long lngPageSize, string strKeyId, string strOrderSql)
        {
            if (lngPageIndex < 1) lngPageIndex = 1;
            StringBuilder sbSql = new StringBuilder();
            sbSql.AppendFormat("SELECT TOP {0} * FROM ( {1} ) T ", lngPageSize, strQuerySql);
            if (lngPageIndex > 1)
            {
                long lngPageLowerBound = (lngPageIndex - 1) * lngPageSize;
                //sbSql.AppendFormat("WHERE T.{0} NOT IN ", strKeyId);
                //sbSql.AppendFormat("(SELECT TOP {0} {1} FROM ( {2} ) T1 {3}) ", lngPageLowerBound, strKeyId, strQuerySql, strOrderSql);

                sbSql.Append("WHERE NOT EXISTS (SELECT 1 FROM ");
                sbSql.AppendFormat("(SELECT TOP {0} {1} FROM ( {2} ) T1 {3}) T2 WHERE T.{1} = T2.{1})", lngPageLowerBound, strKeyId, strQuerySql, strOrderSql);
            }
            sbSql.Append(strOrderSql);
            return sbSql.ToString();
        }
        #endregion
        #region ExecuteBlobNonQuery
        /// <summary>
        /// 执行Sql语句，并返回受影响的行数
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public override int ExecuteBlobNonQuery(string commandText, byte[] b)
        {
            try
            {
                SqlCommand command = new SqlCommand(commandText, this.Connection as SqlConnection, this._transaction);
                command.Parameters.Add(":imgdata", SqlDbType.Image);    //以参数化形式写入数据库
                command.Parameters[":imgdata"].Value = b;
                return command.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                throw new Exception(string.Format("{0},{1}", x.Message, commandText));
            }

        }
        #endregion
    }
}
