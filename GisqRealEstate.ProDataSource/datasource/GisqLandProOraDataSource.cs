using System;
using System.Data;
using System.Data.OracleClient;
using System.Xml;
using System.Text;

namespace GisqRealEstate.ProDataSource
{
    public class GisqLandProOraDataSource : GisqLandProDataSource
    {
        private OracleConnection _connection;
        private OracleTransaction _transaction;
        /// <summary>
        /// �Ƿ���������ı�־2009-09-14
        /// </summary>
        private bool _beginTransaction;

        public GisqLandProOraDataSource(string connectionString)
        {
            this._connection = new OracleConnection(connectionString);
            this._transaction = null;
            this._beginTransaction = false;
        }

        /// <summary>
        /// �õ����ݿ��������Ϣ
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
        /// �����������Ӳ���
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
        /// ���ݿ���������
        /// </summary>
        public override DataSourceType DbType
        {
            get { return DataSourceType.DB_Oracle; }
        }
        /// <summary>
        /// �������ݿ�Ĳ�ͬ������sql����н�ȡ�ַ����ĺ���
        /// </summary>
        public override string SubString
        {
            get { return "substr"; }
        }

        public override string ToDate(string strDate)
        {
            return "to_date('" + strDate + "','yyyy-mm-dd')";
        }

        public override string ToDate(string strDate, bool IsLongFormat)
        {
            if (IsLongFormat)
                return "to_date('" + strDate + "','yyyy-mm-dd hh24:mi:ss')";
            else
                return ToDate(strDate);

        }
        /// <summary>
        /// ��ȡ���ݿ�ʱ���ֶεĶ����ڸ�ʽ����,��SELECT�����ʹ��
        /// </summary>
        /// <param name="strColName">�ֶ�����</param>
        /// <returns></returns>
        public override string FormtDateSql(string strColName)
        {
            return FormtDateSql(strColName, strColName);
        }
        /// <summary>
        /// ��ȡ���ݿ�ʱ���ֶεĶ����ڸ�ʽ����,��SELECT�����ʹ��
        /// </summary>
        /// <param name="strColName">�ֶ�����</param>
        /// <param name="strAnotherName">�ֶα���</param>
        /// <returns></returns>
        public override string FormtDateSql(string strColName, string strAnotherName)
        {
            return FormtDateSql(strColName, strAnotherName, false);
        }
        /// <summary>
        /// ��ȡ���ݿ�ʱ���ֶεĶ����ڸ�ʽ����,��SELECT�����ʹ��
        /// </summary>
        /// <param name="strColName">�ֶ�����</param>
        /// <param name="strAnotherName">�ֶα���</param>
        /// <param name="IsLongFormat">�Ƿ��ǳ����ڸ�ʽ</param>
        /// <returns></returns>
        public override string FormtDateSql(string strColName, string strAnotherName, bool IsLongFormat)
        {
            if (IsLongFormat)
            {
                return "case to_char(" + strColName + ",'yyyy') when '1899' then '' when '' then '' else  to_char(" + strColName + ",'yyyy-mm-dd hh24:mi:ss') end as " + strAnotherName + " ";
            }
            else
            {
                return "case to_char(" + strColName + ",'yyyy') when '1899' then '' when '' then '' else  to_char(" + strColName + ",'yyyy-mm-dd') end as " + strAnotherName + " ";

            }
        }

        public override string GetEnumNameByValue(string strDicName, string strValue)
        {
            string strSql = "select getenumname('" + strDicName + "','" + strValue + "') FROM dual ";

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
        /// SQL����еļӺ����ӷ���,sqlserverΪ��+����oracleΪ��||��
        /// </summary>
        public override string Plus
        {
            get { return " || "; }
        }
        /// <summary>
        /// �������ݿ�Ĳ�ͬ������sql�����DBOǰ׺
        /// </summary>
        public override string Dbo
        {
            get { return ""; }
        }

        /// <summary>
        /// �������ݿ�Ĳ�ͬ������sql����ֵ�жϵĺ���
        /// </summary>
        public override string IsNull
        {
            get { return "nvl"; }
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
            return DataSourceType.DB_Oracle;
        }
        #region ExecuteNonQuery
        /// <summary>
        /// ִ��Sql��䣬��������Ӱ�������
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public override int ExecuteNonQuery(string commandText)
        {
            try
            {
                OracleCommand command = new OracleCommand(commandText, this.Connection as OracleConnection, this._transaction);
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
        /// ִ���������һ�����ͻ���IDataReader
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public override IDataReader ExecuteReader(string commandText)
        {

            OracleCommand command = new OracleCommand(commandText, this.Connection as OracleConnection, this._transaction);
            return command.ExecuteReader();

        }
        #endregion
        #region ExecuteScalar
        /// <summary>
        /// ִ���������һ��ֵ
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public override object ExecuteScalar(string commandText)
        {

            OracleCommand command = new OracleCommand(commandText, this.Connection as OracleConnection, this._transaction);
            return command.ExecuteOracleScalar();

        }
        #endregion

        #region ExecuteDataSet
        /// <summary>
        /// ִ���������һ��DataSet
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public override DataSet ExecuteDataSet(string commandText)
        {

            DataSet ds = new DataSet();
            OracleCommand command = new OracleCommand(commandText, this.Connection as OracleConnection, this._transaction);
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            adapter.Fill(ds, "ds");

            return ds;

        }
        #endregion

        #region ExecuteDataTable
        /// <summary>
        /// ִ���������һ��DataTable
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
            OracleDataReader objRead = null;

            string strQuerySql = "";

            strQuerySql = "SELECT SYSDATE FROM DUAL";

            try
            {
                objRead = (OracleDataReader)ExecuteReader(strQuerySql);
            }
            catch (OracleException ex)
            {
                if (objRead != null)
                {
                    objRead.Close();
                }
                throw new Exception("GetServerTimeʧ��!", ex);
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
            SeqName = SeqName.Replace("-", "#");
            if (Count == 1)
            {
                long intNewid = 0;
                string strCreateSql = "";
                string strQuerySql = "";
                OracleDataReader objRead = null;

                strQuerySql = "Select TO_NUMBER(" + SeqName + ".NEXTVAL) From dual";

                //right:
                try
                {

                    objRead = (OracleDataReader)ExecuteReader(strQuerySql);
                }
                catch (OracleException ex)
                {
                    if (objRead != null)
                    {
                        objRead.Close();
                    }
                    if (ex.ErrorCode == -2146232008) //-2147217900 2009-01-08�޸�
                    {
                        strCreateSql = "CREATE SEQUENCE " + SeqName + " INCREMENT BY 1 START WITH 2 MINVALUE 1 NOCYCLE NOCACHE NOORDER";

                        ExecuteNonQuery(strCreateSql);

                        return 1;
                        //goto right;
                    }
                    else
                    {
                        throw new Exception("GetNewIDʧ��!", ex);
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
            else
            {
                long iNextId = GetNewID(SeqName);
                try
                {
                    string strSql = null;
                    strSql = string.Format("drop sequence {0}", SeqName);
                    ExecuteNonQuery(strSql);
                }
                catch { }
                try
                {
                    StringBuilder sbSql = new StringBuilder();
                    sbSql.AppendFormat("  CREATE SEQUENCE {0}", SeqName);
                    sbSql.Append("  MINVALUE 1");
                    sbSql.Append("  MAXVALUE 999999999999999999999999999");
                    sbSql.AppendFormat("  START WITH {0}", iNextId + Count - 1);//iNextId������һ���ˣ�����Ҫ��1
                    sbSql.Append("  INCREMENT BY 1");
                    sbSql.Append("  NOCACHE");
                    ExecuteNonQuery(sbSql.ToString());
                }
                catch { }
                return iNextId;
            }
        }
        #endregion

        #region GetPagingSql
        /// <summary>
        /// ��ȡoracle��ҳ��sql���
        /// </summary>
        /// <param name="strQuerySql"></param>
        /// <param name="lngPageIndex"></param>
        /// <param name="lngPageSize"></param>
        /// <param name="strKeyId"></param>
        /// <returns></returns>
        public override string GetPagingSql(string strQuerySql, long lngPageIndex, long lngPageSize)
        {
            if (lngPageIndex < 1) lngPageIndex = 1;
            long lngPageLowerBound = (lngPageIndex - 1) * lngPageSize;
            long lngPageUpperBound = lngPageLowerBound + lngPageSize;

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("SELECT * FROM ( SELECT T.* , ROWNUM R FROM  ");
            sbSql.AppendFormat("( {0} ) T WHERE ROWNUM <= {1} ) T1  ", strQuerySql, lngPageUpperBound);
            sbSql.AppendFormat("WHERE T1.R > {0}", lngPageLowerBound);

            return sbSql.ToString();
        }
        #endregion
        #region ExecuteBlobNonQuery
        /// <summary>
        /// ִ��Sql��䣬��������Ӱ�������
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public override int ExecuteBlobNonQuery(string commandText, byte[] b)
        {
            try
            {
                OracleCommand command = new OracleCommand(commandText, this.Connection as OracleConnection, this._transaction);
                command.Parameters.Add(":imagedate", OracleType.Blob);    //�Բ�������ʽд�����ݿ�
                command.Parameters[0].Value = b;
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
