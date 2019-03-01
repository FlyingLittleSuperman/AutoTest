using System;
using System.Data;
using System.Data.OleDb;
using System.Xml;
using System.Text;


namespace GisqRealEstate.ProDataSource
{
		/// <summary>
	/// �������Ӷ�����
	/// </summary>
	public class GisqLandProOleDataSource : GisqLandProDataSource
	{
		private OleDbConnection	_connection;
		private OleDbTransaction _transaction;
        /// <summary>
        /// �Ƿ���������ı�־2009-09-14
        /// </summary>
        private bool _beginTransaction;

		public GisqLandProOleDataSource(string connectionString)
		{
			this._connection	= new  OleDbConnection(connectionString);
			this._transaction   = null;
            this._beginTransaction = false;
		}

		/// <summary>
		/// �õ����ݿ��������Ϣ
		/// </summary>
		public override IDbConnection  Connection
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
            get { return DataSourceType.DB_Odbc; }
        }
        /// <summary>
        /// �������ݿ�Ĳ�ͬ������sql����н�ȡ�ַ����ĺ���
        /// </summary>
        public override string SubString
        {
            get { return ""; }
        }
        /// <summary>
        /// �������ݿ�Ĳ�ͬ������sql�����DBOǰ׺
        /// </summary>
        public override string Dbo
        {
            get { return ""; }
        }
        public override string ToDate(string strDate)
        {
            return "#" + strDate + "#";
        }
        public override string ToDate(string strDate, bool IsLongFormat)
        {
            return "#" + strDate + "#";
        }
        public override string FormtDateSql(string strColName)
        {
            return strColName;
        }
        public override string FormtDateSql(string strColName, string strAnotherName)
        {
            return strColName;
        }
        public override string FormtDateSql(string strColName, string strAnotherName, bool IsLongFormat)
        {
            return strColName;
        }

        public override string GetEnumNameByValue(string strDicName, string strValue)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("      SELECT A.ENUM_NAME FROM T_FIELD_ENUM A");
            sbSql.Append("      INNER JOIN T_FIELD_EXPLAIN B ON A.FLD_EXP_ID=B.FLD_EXP_ID");
            sbSql.AppendFormat("      WHERE UCASE(B.FLD_LETTER_NAME) = '{0}' AND A.ENUM_VALUE = '{1}'", strDicName, strValue);
            DataTable dt = ExecuteDataTable(sbSql.ToString());
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["ENUM_NAME"].ToString();
            }
            return "";
        }


        /// <summary>
        /// SQL����еļӺ����ӷ���,sqlserverΪ��+����oracleΪ��||��
        /// </summary>
        public override string Plus
        {
            get { return " + "; }
        }
        /// <summary>
        /// �������ݿ�Ĳ�ͬ������sql����ֵ�жϵĺ���
        /// </summary>
        public override string IsNull
        {
            get { return ""; }
        }

		public override  void Open()
		{
			if(this._connection.State != ConnectionState.Open)
				this._connection.Open();

		}

		public override  void Close()
		{
			if(this._connection.State == ConnectionState.Open)
				this._connection.Close();			
		}

		public override void BeginTransaction()
		{
			this._transaction = this._connection.BeginTransaction();
            this._beginTransaction = true;
		}

		public override  void CommitTransaction()
		{
            if (this._beginTransaction)
            {
                this._transaction.Commit();
                this._beginTransaction = false;
            }
		}

		public override  void RollBackTransaction()
		{
            if (this._beginTransaction)
            {
                this._transaction.Rollback();
                this._beginTransaction = false;
            }
		}

		public override DataSourceType instDataSourceType() 
		{
			return DataSourceType.DB_Odbc;
		}
		#region ExecuteNonQuery
		/// <summary>
        /// ִ��Sql��䣬��������Ӱ�������
		/// </summary>
		/// <param name="commandText"></param>
		/// <returns></returns>
		public override int ExecuteNonQuery(string commandText)
		{

            OleDbCommand command = new OleDbCommand(commandText, this.Connection as OleDbConnection, this._transaction);
            return command.ExecuteNonQuery();
            
		}
		#endregion
		#region ExecuteReader
		/// <summary>
		/// ִ���������һ�����ͻ���IDataReader
		/// </summary>
		/// <param name="commandText"></param>
		/// <returns></returns>
		public override IDataReader  ExecuteReader(string commandText)
		{

            OleDbCommand command = new OleDbCommand(commandText, this.Connection as OleDbConnection, this._transaction);
            return command.ExecuteReader();
            
		}
		#endregion
		#region ExecuteScalar
		/// <summary>
		/// ִ���������һ��ֵ
		/// </summary>
		/// <param name="commandText"></param>
		/// <returns></returns>
		public override  object ExecuteScalar(string commandText)
		{

            OleDbCommand command = new OleDbCommand(commandText, this.Connection as OleDbConnection, this._transaction);
            return command.ExecuteScalar();
           
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
            OleDbCommand command = new OleDbCommand(commandText, this.Connection as OleDbConnection, this._transaction);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
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
            return ExecuteDataSet(commandText).Tables[0];
        }
        #endregion

		#region GetServerTime
		public override  DateTime GetServerTime()
		{
			DateTime dtnServerTime;
			dtnServerTime=(DateTime)DateTime.Now;
			return dtnServerTime;
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
			return 0;
			
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
            OleDbCommand command = new OleDbCommand(commandText, this.Connection as OleDbConnection, this._transaction);
            command.Parameters.AddWithValue(":imagedate", b);
            return command.ExecuteNonQuery();
        }
        #endregion
	}
}
