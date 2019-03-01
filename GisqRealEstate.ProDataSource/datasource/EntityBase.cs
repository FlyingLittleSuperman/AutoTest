using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Text.RegularExpressions;

namespace GisqRealEstate.ProDataSource
{
	/// <summary>
	/// ��ʵ�����״̬ö��
	/// </summary>
	public enum EnumEditState
	{
		esNoEdit = 0,
		esAddNew = 1,
		esDelete = 2,
		esUpdate = 3
	}
	/// <summary>
	/// ʵ����Ľӿ�
	/// </summary>
	public interface IEntity
	{
		long PrimaryKeyValue
		{
			get;
			set;
		}

		EnumEditState EditState
		{
			get;
			set;
		}
    }

    #region DataAcceessCls

    //public sealed class DataAcceessCls
    //{
    //    private GisqLandProDataSource DataAcceessSource;

    //    ~DataAcceessCls()
    //    {
    //        this.DataAcceessSource.Close();
    //    }
    //    public DataAcceessCls()
    //    {
    //        this.DataAcceessSource = GisqLandProDataSourceFactory.CreateInstance();
    //    }
    //    public DataAcceessCls(string strConnectionString, DataSourceType databaseType)
    //    {
    //        this.DataAcceessSource = GisqLandProDataSourceFactory.CreateInstance(strConnectionString, databaseType);
    //    }

    //    /// <summary>
    //    /// �����Ӷ���ȷ���������ʹ��    =====���� 2007-11-13====
    //    /// </summary>
    //    /// <param name="strConnectionString"></param>
    //    public DataAcceessCls(string strConnectionString)
    //    {
    //        this.DataAcceessSource = GisqLandProDataSourceFactory.CreateInstance(strConnectionString);
    //    }

        

    //    #region ��άJson����
    //    //*************************************************************************************************
    //    /// <summary>
    //    /// �����ƵĴ���άJson����
    //    /// </summary>
    //    public string GetJsonStr(string commandText)
    //    {
    //        if (commandText == "") { return ""; }
    //        try
    //        {

    //            DataTable datatable = new DataTable();
    //            this.DataAcceessSource.Open();
    //            switch (this.DataAcceessSource.instDataSourceType())
    //            {
    //                case DataSourceType.DB_SqlServer:
    //                    SqlDataAdapter sqlAdapter = new SqlDataAdapter();
    //                    sqlAdapter.SelectCommand = new SqlCommand(commandText, (SqlConnection)this.DataAcceessSource.Connection, (SqlTransaction)this.DataAcceessSource.Transaction);
    //                    sqlAdapter.Fill(datatable);

    //                    break;
    //                case DataSourceType.DB_Oracle:
    //                    OracleDataAdapter oraAdapter = new OracleDataAdapter();
    //                    oraAdapter.SelectCommand = new OracleCommand(commandText, (OracleConnection)this.DataAcceessSource.Connection, (OracleTransaction)this.DataAcceessSource.Transaction);
    //                    oraAdapter.Fill(datatable);

    //                    break;
    //                default:
    //                    OleDbDataAdapter oleAdapter = new OleDbDataAdapter();
    //                    oleAdapter.SelectCommand = new OleDbCommand(commandText, (OleDbConnection)this.DataAcceessSource.Connection, (OleDbTransaction)this.DataAcceessSource.Transaction);
    //                    oleAdapter.Fill(datatable);

    //                    break;
    //            }
    //            if (datatable == null) { return ""; }

    //            StringBuilder jsonString = new StringBuilder();

    //            string temp = "";
    //            string value = "";

    //            //jsonString.Append( "{\"" + dt.TableName.ToLower() + "\":[" );
    //            jsonString.Append("[");

    //            foreach (DataRow dr in datatable.Rows)
    //            {
    //                temp = "";

    //                jsonString.Append("{");

    //                foreach (DataColumn dc in datatable.Columns)
    //                {
    //                    value = dr[dc].ToString();

    //                    if (value.Length < 1)
    //                    {
    //                        value = "";//&nbsp;
    //                    }

    //                    temp += "\"" + dc.ColumnName.ToLower() + "\":\"" + value + "\",";
    //                }

    //                temp = temp.TrimEnd(',');

    //                jsonString.Append(temp + "},");
    //            }

    //            temp = jsonString.ToString();
    //            temp = temp.TrimEnd(',');
    //            return temp + "]";
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception(ex.Message, ex);

    //        }
    //        finally
    //        {
    //            this.DataAcceessSource.Close();
    //        }

    //    }
    //    /// <summary>
    //    /// �������ƵĴ���άJson����
    //    /// </summary>
    //    /// <param name="commandText"></param>
    //    /// <returns></returns>
    //    public string GetJsonStrNoName(string commandText)
    //    {
    //        if (commandText == "") { return ""; }
    //        try
    //        {

    //            DataTable datatable = new DataTable();
    //            this.DataAcceessSource.Open();
    //            switch (this.DataAcceessSource.instDataSourceType())
    //            {
    //                case DataSourceType.DB_SqlServer:
    //                    SqlDataAdapter sqlAdapter = new SqlDataAdapter();
    //                    sqlAdapter.SelectCommand = new SqlCommand(commandText, (SqlConnection)this.DataAcceessSource.Connection, (SqlTransaction)this.DataAcceessSource.Transaction);
    //                    sqlAdapter.Fill(datatable);

    //                    break;
    //                case DataSourceType.DB_Oracle:
    //                    OracleDataAdapter oraAdapter = new OracleDataAdapter();
    //                    oraAdapter.SelectCommand = new OracleCommand(commandText, (OracleConnection)this.DataAcceessSource.Connection, (OracleTransaction)this.DataAcceessSource.Transaction);
    //                    oraAdapter.Fill(datatable);

    //                    break;
    //                default:
    //                    OleDbDataAdapter oleAdapter = new OleDbDataAdapter();
    //                    oleAdapter.SelectCommand = new OleDbCommand(commandText, (OleDbConnection)this.DataAcceessSource.Connection, (OleDbTransaction)this.DataAcceessSource.Transaction);
    //                    oleAdapter.Fill(datatable);

    //                    break;
    //            }
    //            if (datatable == null) { return ""; }
    //            StringBuilder jsonString = new StringBuilder();

    //            string temp = "";
    //            string value = "";
    //            jsonString.Append("[");
    //            foreach (DataRow dr in datatable.Rows)
    //            {
    //                temp = "";

    //                jsonString.Append("[");

    //                foreach (DataColumn dc in datatable.Columns)
    //                {
    //                    value = dr[dc].ToString();

    //                    if (value.Length < 1)
    //                    {
    //                        value = "";
    //                    }

    //                    temp += "\"" + value + "\",";
    //                }

    //                temp = temp.TrimEnd(',');

    //                jsonString.Append(temp + "],");
    //            }

    //            temp = jsonString.ToString();
    //            temp = temp.TrimEnd(',');

    //            return temp + "]";

    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception(ex.Message, ex);

    //        }
    //        finally
    //        {
    //            this.DataAcceessSource.Close();
    //        }

    //    }
    //    #endregion
    //}

    #endregion
    /// <summary>
	/// ��ʵ�弯�ϵĻ���
	/// </summary>
	
	//��ΰ2007-07-03����
	//��������ݲ��б�ʵ�弯�ϵĻ��࣬��Ĳ���
	public  class EntityBaseSet
	{
        public GisqLandProDataSource EntityDataSource;

        //~EntityBaseSet()
        //{
        //    string str="";
        //    str=m_TableName;

        //    this.EntityDataSource.Close();

        //}
        public EntityBaseSet()//ʵ��������ʱ��Ҫ��������Դ����
		{	

		}

		private SortedList m_SortedList = null;
        

		#region �����ֶ�
	
		/// <summary>
		/// ����
		/// </summary>
		protected string m_TableName = "";        
		/// <summary>
		/// ��ʷ����
		/// </summary>
		protected string m_HisTableName = "";        
		/// <summary>
		/// ������
		/// </summary>
		protected string m_PrimaryKeyName = "";       
		/// <summary>
		/// ������
		/// </summary>
		protected string m_SequenceName = "";

        /// <summary>
        /// �������� ���䴴������ʱʹ��
        /// </summary>
        protected string m_ClsName = "";
        
		/// <summary>
		/// ��ʷ���־
		/// </summary>
		protected bool m_HisTable = false;
		public bool HisTable
		{
			get { return this.m_HisTable; }

			set { this.m_HisTable = value; }
		}

        public string SequenceName
        {
            get { return this.m_SequenceName; }

            set { this.m_SequenceName = value; }
        }

		#endregion
        
		#region ��Ա����
		/// <summary>
		/// ����һ�����ü��ϵ��麯��
		/// </summary>
		/// <param name="datarow"></param>
		/// <param name="entity"></param>
		/// <returns></returns>
		protected virtual bool LetFieldsValue(DataRow datarow, IEntity entity) { return false; }
		/// ����һ��ȡ��ĳЩ�ֶμ��ϵ��麯��
		/// </summary>
		/// <param name="dataset"></param>
		/// <returns></returns>
		protected virtual bool GetFieldsValue(DataTable datatable,string strFld) { return false; }

		public long Count
		{
			get
			{ 
				if (m_SortedList == null) { return 0; }
				else { return m_SortedList.Count; }
			}
		}

		public IEntity ItemIndex(int index)
		{
			if (m_SortedList == null || m_SortedList.Count == 0 || index < 0 || index > m_SortedList.Count - 1) { return null; }
			
			IDictionaryEnumerator enumEntry = null;			
			
			try
			{
				enumEntry = m_SortedList.GetEnumerator();
				enumEntry.Reset();
				while (enumEntry.MoveNext() && (index-- > 0)) {}
				return (IEntity)enumEntry.Value;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}
		}

		public IEntity ItemKey(long key)
		{
			if (m_SortedList == null) { return null; }

			try
			{
				return (IEntity)m_SortedList[key.ToString()];
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}
           
		}

		public bool Add(IEntity obj)
		{
			// 
			if (obj == null) { return false; }

            //m_SortedList = null;//������ݶ��󼯺�

			if (m_SortedList == null) { m_SortedList = new SortedList(new MySort()); }

			try
			{
                if (obj.PrimaryKeyValue > 0)
                {
                    if (!Exist(obj))
                        m_SortedList.Add(obj.PrimaryKeyValue.ToString(), obj);
                }
                else
                {
                    m_SortedList.Add("", obj);
                }
                //m_SortedList.Add("", obj);

				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}
        }

        #region �Ƴ�����
        //�ж��Ƿ����
		public bool Exist(IEntity obj)
		{
			bool blnOk = false;
			if (m_SortedList == null)
			{
                m_SortedList = new SortedList(new MySort());
				return false;
			}            
			IDictionaryEnumerator objEnum = m_SortedList.GetEnumerator();
			
			while (objEnum.MoveNext())
			{
				IEntity objTmp = (IEntity)objEnum.Entry.Value;
				if (objTmp.PrimaryKeyValue == obj.PrimaryKeyValue)
				{
					blnOk = true;
					break;
				}
			}
			return blnOk;
		}
		public bool RemoveIndex(int index)
		{
			if (m_SortedList == null || m_SortedList.Count == 0 || index < 0 || index > m_SortedList.Count - 1) { return true; }

			try
			{
				IDictionaryEnumerator enumEntry = m_SortedList.GetEnumerator();
				while (enumEntry.MoveNext() && (index-- > 0)) { }

				if (index == -1) 
				{
					m_SortedList.Remove(enumEntry.Key);
					return true;
				}

				return false;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}

            
		}

		public bool RemoveKey(long key)
		{
			if (m_SortedList == null) { return true; }
			try
			{
				m_SortedList.Remove(key.ToString());
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}
            
		}

		public bool RemoveAll()
		{
            
			if (m_SortedList == null) { return true; }
			try
			{
				m_SortedList = null;
				return true;                
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}

        }
        #endregion

        #region ��ȡ����
        public bool SelectAllFieldsByCondition(string whereClause,string strOrder)
		{
			// TODO:  
            m_SortedList = null;
			string strTableName = m_TableName;
			if (m_HisTable==true && m_HisTableName!="")
				strTableName = m_HisTableName;

			string strSql = "select * from " + strTableName;
			if (whereClause != "") { strSql = strSql + " where " + whereClause; }
			if (strOrder != "") { strSql = strSql + " order by " + strOrder; }


            try
            {
                
                DataTable datatable = new DataTable();
                //this.EntityDataSource.Open();
                switch (this.EntityDataSource.instDataSourceType())
                {
                    case DataSourceType.DB_SqlServer:
                        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                        sqlAdapter.SelectCommand = new SqlCommand(strSql, (SqlConnection)this.EntityDataSource.Connection, (SqlTransaction)this.EntityDataSource.Transaction);
                        sqlAdapter.Fill(datatable);
                        
                        break;
                    case DataSourceType.DB_Oracle:
                        OracleDataAdapter oraAdapter = new OracleDataAdapter();
                        oraAdapter.SelectCommand = new OracleCommand(strSql, (OracleConnection)this.EntityDataSource.Connection, (OracleTransaction)this.EntityDataSource.Transaction);
                        oraAdapter.Fill(datatable);
                       
                        break;
                    default:
                        OleDbDataAdapter oleAdapter = new OleDbDataAdapter();
                        oleAdapter.SelectCommand = new OleDbCommand(strSql, (OleDbConnection)this.EntityDataSource.Connection, (OleDbTransaction)this.EntityDataSource.Transaction);
                        oleAdapter.Fill(datatable);
                        
                        break;
                }

                if (datatable == null) { return false; }
                return GetFieldsValue(datatable, "");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                //this.EntityDataSource.Close();
            }
           
		}
		public bool SelectAllFieldsByCondition(string whereClause)
		{
			return SelectAllFieldsByCondition(whereClause,"");
		}
		public bool SelectAllFieldsByCondition()
		{
			return SelectAllFieldsByCondition("","");
		}

		public bool SelectFieldsByCondition(string strFld, string whereClause,string strOrder)
		{
			// TODO: 
            m_SortedList = null;
			if (strFld==""){return false;}
			string strTableName = m_TableName;
			
			Regex objregex = new Regex(m_PrimaryKeyName.ToUpper()); 
			Match match = objregex.Match(strFld.ToUpper()); 
			if (!match.Success ) 
			{
��				strFld=m_PrimaryKeyName + "," + strFld;
			}

			if (m_HisTable==true && m_HisTableName!="")
			{
				strTableName = m_HisTableName;
				objregex = new Regex("BG_BB".ToString()); 
				match = objregex.Match(strFld.ToUpper());
				if (!match.Success ) 
				{
��					strFld= strFld + ",BG_BB";
				}
				
			}
			string strSql = "select "+ strFld +" from " + strTableName;
			if (whereClause != "") { strSql = strSql + " where " + whereClause; }
			if (strOrder != "") { strSql = strSql + " order by " + strOrder; }

			try
			{
                DataTable datatable = new DataTable();
                //this.EntityDataSource.Open();
                switch (this.EntityDataSource.instDataSourceType())
				{
					case DataSourceType.DB_SqlServer:
						SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                        sqlAdapter.SelectCommand = new SqlCommand(strSql, (SqlConnection)this.EntityDataSource.Connection, (SqlTransaction)this.EntityDataSource.Transaction);
                        sqlAdapter.Fill(datatable);
                        
						break;
					case DataSourceType.DB_Oracle:
						OracleDataAdapter oraAdapter = new OracleDataAdapter();
                        oraAdapter.SelectCommand = new OracleCommand(strSql, (OracleConnection)this.EntityDataSource.Connection, (OracleTransaction)this.EntityDataSource.Transaction);
                        oraAdapter.Fill(datatable);
                        
						break;
					default:
						OleDbDataAdapter oleAdapter = new OleDbDataAdapter();
                        oleAdapter.SelectCommand = new OleDbCommand(strSql, (OleDbConnection)this.EntityDataSource.Connection, (OleDbTransaction)this.EntityDataSource.Transaction);
                        oleAdapter.Fill(datatable);
                        
						break;
				}
                if (datatable == null) { return false; }
                return GetFieldsValue(datatable, strFld);

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}
            finally
            {
                //this.EntityDataSource.Close();
            }
           
		}
		public bool SelectFieldsByCondition(string strFld, string whereClause)
		{
			return SelectFieldsByCondition(strFld,whereClause,"");
		}
		public bool SelectFieldsByCondition(string strFld)
		{
			return SelectFieldsByCondition(strFld,"","");
		}
		public bool SelectFieldsByCondition()
		{
			return SelectAllFieldsByCondition("","");
		}		

		public bool SelectAllFieldsByKey(long lngkey,string strOrder)
		{
			// TODO: 
            m_SortedList = null;

			if (lngkey<0||lngkey==0){return false;}
			string strTableName = m_TableName;
			if (m_HisTable==true && m_HisTableName!="")
				strTableName = m_HisTableName;

			string strSql = "select * from " + strTableName +" where " +m_PrimaryKeyName + "=" + lngkey;
			if (strOrder != "") { strSql = strSql + " order by " + strOrder; }

            try
            {

                DataTable datatable = new DataTable();
                //this.EntityDataSource.Open();
                switch (this.EntityDataSource.instDataSourceType())
                {
                    case DataSourceType.DB_SqlServer:
                        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                        sqlAdapter.SelectCommand = new SqlCommand(strSql, (SqlConnection)this.EntityDataSource.Connection, (SqlTransaction)this.EntityDataSource.Transaction);
                        sqlAdapter.Fill(datatable);
                       
                        break;
                    case DataSourceType.DB_Oracle:
                        OracleDataAdapter oraAdapter = new OracleDataAdapter();
                        oraAdapter.SelectCommand = new OracleCommand(strSql, (OracleConnection)this.EntityDataSource.Connection, (OracleTransaction)this.EntityDataSource.Transaction);
                        oraAdapter.Fill(datatable);
                        
                        break;
                    default:
                        OleDbDataAdapter oleAdapter = new OleDbDataAdapter();
                        oleAdapter.SelectCommand = new OleDbCommand(strSql, (OleDbConnection)this.EntityDataSource.Connection, (OleDbTransaction)this.EntityDataSource.Transaction);
                        oleAdapter.Fill(datatable);
                       
                        break;
                }
                if (datatable == null) { return false; }
                return GetFieldsValue(datatable, "");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);

            }
            finally
            {

                //this.EntityDataSource.Close();
            }
           
		}
		public bool SelectAllFieldsByKey(long lngkey)
		{
			return SelectAllFieldsByKey(lngkey,"");
		}

		public bool SelectFieldsByKey(string strFld,long lngkey,string strOrder)
		{
			// TODO: 
            m_SortedList = null;
			if (strFld==""){return false;}
			if (lngkey<0||lngkey==0){return false;}
			string strTableName = m_TableName;

			Regex objregex = new Regex(m_PrimaryKeyName); 
			Match match = objregex.Match(strFld); 
			if (!match.Success ) 
			{
				strFld=m_PrimaryKeyName + "," + strFld;
			}

			if (m_HisTable==true && m_HisTableName!="")
			{
				strTableName = m_HisTableName;
				objregex = new Regex("BG_BB".ToString()); 
				match = objregex.Match(strFld.ToUpper());
				if (!match.Success ) 
				{
��					strFld= strFld + ",BG_BB";
				}
			}

			string strSql = "select "+ strFld +" from " + strTableName +" where " +m_PrimaryKeyName + "=" + lngkey;
			if (strOrder != "") { strSql = strSql + " order by " + strOrder; }

            try
            {

                DataTable datatable = new DataTable();
                //this.EntityDataSource.Open();
                switch (this.EntityDataSource.instDataSourceType())
                {
                    case DataSourceType.DB_SqlServer:
                        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                        sqlAdapter.SelectCommand = new SqlCommand(strSql, (SqlConnection)this.EntityDataSource.Connection, (SqlTransaction)this.EntityDataSource.Transaction);
                        sqlAdapter.Fill(datatable);
                        
                        break;
                    case DataSourceType.DB_Oracle:
                        OracleDataAdapter oraAdapter = new OracleDataAdapter();
                        oraAdapter.SelectCommand = new OracleCommand(strSql, (OracleConnection)this.EntityDataSource.Connection, (OracleTransaction)this.EntityDataSource.Transaction);
                        oraAdapter.Fill(datatable);
                        
                        break;
                    default:
                        OleDbDataAdapter oleAdapter = new OleDbDataAdapter();
                        oleAdapter.SelectCommand = new OleDbCommand(strSql, (OleDbConnection)this.EntityDataSource.Connection, (OleDbTransaction)this.EntityDataSource.Transaction);
                        oleAdapter.Fill(datatable);
                       
                        break;
                }
                if (datatable == null) { return false; }
                return GetFieldsValue(datatable, strFld);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);

            }
            finally
            {
                //this.EntityDataSource.Close();
            }
           
		}
		public bool SelectFieldsByKey(string strFld,long lngkey)
		{
			return SelectFieldsByKey(strFld,lngkey,"");
		}
		public bool SelectFieldsByKey(long lngkey)
		{
			return SelectAllFieldsByKey(lngkey,"");
        }
        #endregion

        #region ɾ������
        public bool DeleteByCondition(string whereClause)
		{
			// TODO:  
			string strTableName = m_TableName;
			string strSql="";
			if (m_HisTable==true && m_HisTableName!="")
				strTableName = m_HisTableName;
			
			strSql = "delete from " + strTableName;
			if (whereClause != "") { strSql = strSql + " where " + whereClause; }

            try
            {
                this.EntityDataSource.Open();
                this.EntityDataSource.BeginTransaction();
                this.EntityDataSource.ExecuteNonQuery(strSql);
                this.EntityDataSource.CommitTransaction();
                return true;
            }
            catch
            {
                this.EntityDataSource.RollBackTransaction();
                return false;
            }
            finally
            {
                this.EntityDataSource.Close();
            }
		}
		public bool DeleteByKey(long lngkey)
		{
			// TODO: 
			if (lngkey<0||lngkey==0){return false;}
			string strTableName = m_TableName;
			string strSql="";
			if (m_HisTable==true && m_HisTableName!="")
				strTableName = m_HisTableName;			
			
			strSql = "delete from " + strTableName + " where " + m_PrimaryKeyName + " = " + lngkey;

            try
            {
                this.EntityDataSource.Open();
                this.EntityDataSource.BeginTransaction();
                this.EntityDataSource.ExecuteNonQuery(strSql);
                this.EntityDataSource.CommitTransaction();
                return true;
            }
            catch
            {
                this.EntityDataSource.RollBackTransaction();
                return false;
            }
            finally
            {
                this.EntityDataSource.Close();
            }

        }
        #endregion

        #region ���ø�������
        public bool  SetEditState(int index, EnumEditState editstate)
		{
			if (m_SortedList == null || m_SortedList.Count == 0 || index < 0 || index > m_SortedList.Count - 1) { return true; }
			IEntity obj = null;
			try
			{
				IDictionaryEnumerator enumEntry = m_SortedList.GetEnumerator();
				while (enumEntry.MoveNext() && (index-- > 0)) { }

				if (index == -1) 
				{
					obj = (IEntity)enumEntry.Entry.Value;
					obj.EditState = editstate;
					m_SortedList.Remove(enumEntry.Key.ToString());
					Add(obj);
					return true;
				}

				return false;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}
		}

		public bool SetAllEditState(EnumEditState editstate)
		{
			if (m_SortedList == null) { return true; }
			SortedList temSortedList = m_SortedList;
			IEntity obj = null;
			try
			{
                m_SortedList = new SortedList(new MySort());
				IDictionaryEnumerator enumEntry = temSortedList.GetEnumerator();
				while (enumEntry.MoveNext()) 
				{
					obj = (IEntity)enumEntry.Entry.Value;
					obj.EditState = editstate;
					Add(obj);
                   
				}
				temSortedList=null;
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}
        }
        #endregion

        #region ���ݸ���
        public bool Update()
		{
			if (m_SortedList == null || m_SortedList.Count <= 0) { return true; }
			string strTableName = m_TableName;
			if (m_HisTable==true && m_HisTableName!="")
				strTableName = m_HisTableName;

			IDictionaryEnumerator objenumEntry = m_SortedList.GetEnumerator();
			try
			{
                //this.EntityDataSource.Open();
                //this.EntityDataSource.BeginTransaction();
                switch (this.EntityDataSource.instDataSourceType())
				{
					case DataSourceType.DB_SqlServer:
						SqlUpdate(strTableName,objenumEntry);
						break;
					case DataSourceType.DB_Oracle:
						OraUpdate(strTableName,objenumEntry);
						break;
					default:
						OleUpdate(strTableName,objenumEntry);
						break;
				}
                //this.EntityDataSource.CommitTransaction();
				return true;
			}
			catch (Exception ex)
			{
                //this.EntityDataSource.RollBackTransaction();
				throw new Exception(ex.Message, ex);
			}
            finally
            {
                //this.EntityDataSource.Close();
                //m_SortedList = null;//��ն��󼯺�
            }
			
		}
		private bool OraUpdate(string strTableName,IDictionaryEnumerator enumEntry)
		{
			IEntity obj = null;		
			string strSql="";
            int iIndex = -1;
			try
			{
				while (enumEntry.MoveNext())
				{
                    iIndex++;
					DataSet pDst=null;
					DataTable datatable = null;
					DataRowCollection datarows = null;
					DataRow pRow = null;
					OracleDataAdapter pAdapter = new OracleDataAdapter();
                    
					obj = (IEntity)enumEntry.Entry.Value;
					if (obj.EditState == EnumEditState.esUpdate)
					{//ִ�и��²���
						strSql = "select * from " + strTableName + " where " + m_PrimaryKeyName +" =" + obj.PrimaryKeyValue ;

                        pAdapter.SelectCommand = new OracleCommand(strSql, (OracleConnection)this.EntityDataSource.Connection, (OracleTransaction)this.EntityDataSource.Transaction);
                    
						pDst = new DataSet(strTableName);
						pAdapter.Fill(pDst, strTableName);
						datatable = pDst.Tables[strTableName];
						if (datatable == null) { return false; }

						datarows = datatable.Rows;
						if (datarows.Count <= 0) { return false; }

						OracleCommandBuilder CommandBuilder = new OracleCommandBuilder(pAdapter);
						pAdapter.UpdateCommand = CommandBuilder.GetUpdateCommand();

						pRow = datarows[0];
                        //obj = (IEntity)m_SortedList[pRow[m_PrimaryKeyName].ToString()];//��֪��Ϊʲôͨ����ֵ�޷�ȡֵ������Ϊ��
                        obj = (IEntity)m_SortedList.GetByIndex(iIndex);//������˳��ȡֵ�����ֵ�˳���Ƿ�һ�£�
						pRow.BeginEdit();
						if (!LetFieldsValue(pRow, obj)) { return false; }
						pRow.EndEdit();
						
						pAdapter.Update(datatable);
						datatable.AcceptChanges();
										
					}
					else if (obj.EditState == EnumEditState.esDelete)
					{//ִ��ɾ������
                       
						strSql = "delete from " + strTableName + " where " + m_PrimaryKeyName + "=" + obj.PrimaryKeyValue;						
						this.EntityDataSource.ExecuteNonQuery(strSql);
						m_SortedList.Remove(obj.PrimaryKeyValue);
						
					}
					else if (obj.EditState == EnumEditState.esAddNew)
					{//ִ����Ӳ���
						strSql = "select * from " + strTableName + " where 1=0";
						pAdapter.SelectCommand = new OracleCommand(strSql, (OracleConnection)this.EntityDataSource.Connection, (OracleTransaction)this.EntityDataSource.Transaction);

						OracleCommandBuilder objCommandBuilder = new  OracleCommandBuilder(pAdapter);
						pAdapter.InsertCommand = objCommandBuilder.GetInsertCommand();
						
						pDst = new DataSet(strTableName);
						pAdapter.Fill(pDst, strTableName);
						datatable = pDst.Tables[strTableName];
						if (datatable == null) { return false; }
						
						obj = (IEntity)enumEntry.Entry.Value;
						pRow = datatable.NewRow();
						if (!LetFieldsValue(pRow, obj))
						{
							return false;
						}
						else
						{
							datatable.Rows.Add(pRow);
						}	
						pAdapter.Update(datatable);
						datatable.AcceptChanges();
					}
				}
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}
		
		}
		private bool SqlUpdate(string strTableName,IDictionaryEnumerator enumEntry)
		{
			IEntity obj = null;		
			string strSql="";
            int iIndex = -1;
			try
			{
				while (enumEntry.MoveNext())
				{
                    iIndex++;
					DataSet pDst=null;
					DataTable datatable = null;
					DataRowCollection datarows = null;
					DataRow pRow = null;
					SqlDataAdapter pAdapter = new SqlDataAdapter();
                    
					obj = (IEntity)enumEntry.Entry.Value;
					if (obj.EditState == EnumEditState.esUpdate)
					{//ִ�и��²���
						strSql = "select * from " + strTableName + " where " + m_PrimaryKeyName +" =" + obj.PrimaryKeyValue ;

						pAdapter.SelectCommand = new SqlCommand(strSql, (SqlConnection)this.EntityDataSource.Connection, (SqlTransaction)this.EntityDataSource.Transaction);
                    
						pDst = new DataSet(strTableName);
						pAdapter.Fill(pDst, strTableName);
						datatable = pDst.Tables[strTableName];
						if (datatable == null) { return false; }

						datarows = datatable.Rows;
						if (datarows.Count <= 0) { return false; }

						SqlCommandBuilder CommandBuilder = new SqlCommandBuilder(pAdapter);
						pAdapter.UpdateCommand = CommandBuilder.GetUpdateCommand();

						pRow = datarows[0];
                        //obj = (IEntity)m_SortedList[pRow[m_PrimaryKeyName].ToString()];//��֪��Ϊʲôͨ����ֵ�޷�ȡֵ������Ϊ��
                        obj = (IEntity)m_SortedList.GetByIndex(iIndex);//������˳��ȡֵ�����ֵ�˳���Ƿ�һ�£�
						pRow.BeginEdit();
						if (!LetFieldsValue(pRow, obj)) { return false; }
						pRow.EndEdit();
						
						pAdapter.Update(datatable);
						datatable.AcceptChanges();
										
					}
					else if (obj.EditState == EnumEditState.esDelete)
					{//ִ��ɾ������
                       
						strSql = "delete from " + strTableName + " where " + m_PrimaryKeyName + "=" + obj.PrimaryKeyValue;						
						this.EntityDataSource.ExecuteNonQuery(strSql);
						m_SortedList.Remove(obj.PrimaryKeyValue);
						
					}
					else if (obj.EditState == EnumEditState.esAddNew)
					{//ִ����Ӳ���
						strSql = "select * from " + strTableName + " where 1=0";
						pAdapter.SelectCommand = new SqlCommand(strSql, (SqlConnection)this.EntityDataSource.Connection, (SqlTransaction)this.EntityDataSource.Transaction);

						SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(pAdapter);
						pAdapter.InsertCommand = objCommandBuilder.GetInsertCommand();

						pDst = new DataSet(strTableName);
						pAdapter.Fill(pDst, strTableName);
						datatable = pDst.Tables[strTableName];
						if (datatable == null) { return false; }
						
						obj = (IEntity)enumEntry.Entry.Value;
						pRow = datatable.NewRow();
						if (!LetFieldsValue(pRow, obj))
						{
							return false;
						}
						else
						{
							datatable.Rows.Add(pRow);
						}	
						pAdapter.Update(datatable);
						datatable.AcceptChanges();
					}
				}
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}
		}
		private bool OleUpdate(string strTableName,IDictionaryEnumerator enumEntry)
		{
			IEntity obj = null;		
			string strSql="";
			try
			{
				while (enumEntry.MoveNext())
				{
					DataSet pDst =null;
					DataTable datatable = null;
					DataRowCollection datarows = null;
					DataRow pRow = null;
					OleDbDataAdapter pAdapter = new  OleDbDataAdapter();
                    
					obj = (IEntity)enumEntry.Entry.Value;
					if (obj.EditState == EnumEditState.esUpdate)
					{//ִ�и��²���
						strSql = "select * from " + strTableName + " where " + m_PrimaryKeyName +" =" + obj.PrimaryKeyValue ;

						pAdapter.SelectCommand = new OleDbCommand(strSql, (OleDbConnection)this.EntityDataSource.Connection, (OleDbTransaction)this.EntityDataSource.Transaction);
                    
						pDst = new DataSet(strTableName);
						pAdapter.Fill(pDst, strTableName);
						datatable = pDst.Tables[strTableName];
						if (datatable == null) { return false; }

						datarows = datatable.Rows;
						if (datarows.Count <= 0) { return false; }

						OleDbCommandBuilder CommandBuilder = new OleDbCommandBuilder(pAdapter);
						pAdapter.UpdateCommand = CommandBuilder.GetUpdateCommand();

						pRow = datarows[0];
						obj = (IEntity)m_SortedList[pRow[m_PrimaryKeyName].ToString()];
						pRow.BeginEdit();
						if (!LetFieldsValue(pRow, obj)) { return false; }
						pRow.EndEdit();
						
						pAdapter.Update(datatable);
						datatable.AcceptChanges();
										
					}
					else if (obj.EditState == EnumEditState.esDelete)
					{//ִ��ɾ������
                       
						strSql = "delete from " + strTableName + " where " + m_PrimaryKeyName + "=" + obj.PrimaryKeyValue;						
						this.EntityDataSource.ExecuteNonQuery(strSql);
						m_SortedList.Remove(obj.PrimaryKeyValue);
						
					}
					else if (obj.EditState == EnumEditState.esAddNew)
					{//ִ����Ӳ���
						strSql = "select * from " + strTableName + " where 1=0";
						pAdapter.SelectCommand = new OleDbCommand(strSql, (OleDbConnection)this.EntityDataSource.Connection, (OleDbTransaction)this.EntityDataSource.Transaction);

						OleDbCommandBuilder objCommandBuilder = new OleDbCommandBuilder(pAdapter);
						pAdapter.InsertCommand = objCommandBuilder.GetInsertCommand();

						pDst = new DataSet(strTableName);
						pAdapter.Fill(pDst, strTableName);
						datatable = pDst.Tables[strTableName];
						if (datatable == null) { return false; }

						obj = (IEntity)enumEntry.Entry.Value;
						pRow = datatable.NewRow();
						if (!LetFieldsValue(pRow, obj))
						{
							return false;
						}
						else
						{
							datatable.Rows.Add(pRow);
						}	
						pAdapter.Update(datatable);
						datatable.AcceptChanges();
					}
				}
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}

        }
        #endregion

        public DateTime GetServerTime()
        {
            DateTime DtmServerdate = DateTime.Now;
            try
            {

                //this.EntityDataSource.Open();
                DtmServerdate = this.EntityDataSource.GetServerTime();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                //this.EntityDataSource.Close();
            }
            return DtmServerdate;
        }

        #region ��ȡ�������ֵ
        public long GetNewID()
		{
			long intNewid=GetNewID(1);
			return intNewid;
		}
		public long GetNewID(int Count)
		{
			long intNewid=0;			
			string strCreateSql="";
			string strQuerySql="";
			IDataReader  objRead=null;

            //this.EntityDataSource.Open();

			if(this.EntityDataSource.instDataSourceType()==DataSourceType.DB_SqlServer)
				strQuerySql="dbo.gqsp_GetNextID '" + m_SequenceName + "' ,"+ Count +""  ;//�����洢������
			else if(this.EntityDataSource.instDataSourceType()==DataSourceType.DB_Oracle)
				strQuerySql="Select TO_NUMBER(" + m_SequenceName + ".NEXTVAL) From dual";
            try
            {

                if (this.EntityDataSource.instDataSourceType() == DataSourceType.DB_SqlServer)
                    objRead = (SqlDataReader)this.EntityDataSource.ExecuteReader(strQuerySql);
                else if (this.EntityDataSource.instDataSourceType() == DataSourceType.DB_Oracle)
                    objRead = (OracleDataReader)this.EntityDataSource.ExecuteReader(strQuerySql);

            }
            catch (OleDbException ex)
            {
                throw new Exception("GetNewIDʧ��!", ex);
            }
            catch (SqlException ex)
            {
                if (objRead != null)
                {
                    objRead.Close();
                }
                if (ex.ErrorCode ==-2146232060)
                {
                    strCreateSql = "Insert into T_LANDMAX (IDName,NextVal) Values ('" + m_SequenceName + "',2)";
                    this.EntityDataSource.ExecuteNonQuery(strCreateSql);
                    return 1;
                }
                else
                {
                    //this.EntityDataSource.Close();
                    throw new Exception("GetNewIDʧ��!", ex);
                }
            }
            catch (OracleException ex)
            {
                if (objRead != null)
                {
                    objRead.Close();
                }
                if (ex.ErrorCode == -2146232008)
                {
                    strCreateSql = "CREATE SEQUENCE " + m_SequenceName + " INCREMENT BY 1 START WITH 2 MINVALUE 1 NOCYCLE NOCACHE NOORDER";
                    this.EntityDataSource.ExecuteNonQuery(strCreateSql);
                    return 1;
                }
                else
                {
                    //this.EntityDataSource.Close();
                    throw new Exception("GetNewIDʧ��!", ex);
                }
            }
            
		
			objRead.Read();
			intNewid=Convert.ToInt64(objRead.GetValue(0));
			
			if (objRead!=null)
			{
				objRead.Close();
			}
            //this.EntityDataSource.Close();
			return intNewid;
        }
        #endregion

        //��ȡĳ���ֶε����ֵ
        public long GetMaxValue(string strFld)
        {
            string strTableName = m_TableName;
            if (m_HisTable == true && m_HisTableName != "")
                strTableName = m_HisTableName;

            string strSql = "select max(" + strFld + ") from " + strTableName;

            try
            {

                DataTable datatable = new DataTable();
                this.EntityDataSource.Open();
                switch (this.EntityDataSource.instDataSourceType())
                {
                    case DataSourceType.DB_SqlServer:
                        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                        sqlAdapter.SelectCommand = new SqlCommand(strSql, (SqlConnection)this.EntityDataSource.Connection, (SqlTransaction)this.EntityDataSource.Transaction);
                        sqlAdapter.Fill(datatable);

                        break;
                    case DataSourceType.DB_Oracle:
                        OracleDataAdapter oraAdapter = new OracleDataAdapter();
                        oraAdapter.SelectCommand = new OracleCommand(strSql, (OracleConnection)this.EntityDataSource.Connection, (OracleTransaction)this.EntityDataSource.Transaction);
                        oraAdapter.Fill(datatable);

                        break;
                    default:
                        OleDbDataAdapter oleAdapter = new OleDbDataAdapter();
                        oleAdapter.SelectCommand = new OleDbCommand(strSql, (OleDbConnection)this.EntityDataSource.Connection, (OleDbTransaction)this.EntityDataSource.Transaction);
                        oleAdapter.Fill(datatable);

                        break;
                }
                if (datatable == null) { return -1; }
                return (long)datatable.Rows[0][0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);

            }
            finally
            {
                this.EntityDataSource.Close();
            }
        }

        //��������ֵ�жϼ�¼�Ƿ����
        public bool IsExists(long lngkey)
        {
            string strTableName = m_TableName;
            if (m_HisTable == true && m_HisTableName != "")
                strTableName = m_HisTableName;

            string strSql = "select " + m_PrimaryKeyName + " from " + strTableName + " where " + m_PrimaryKeyName + " = " + lngkey.ToString();

            try
            {

                DataTable datatable = new DataTable();
                this.EntityDataSource.Open();
                switch (this.EntityDataSource.instDataSourceType())
                {
                    case DataSourceType.DB_SqlServer:
                        SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                        sqlAdapter.SelectCommand = new SqlCommand(strSql, (SqlConnection)this.EntityDataSource.Connection, (SqlTransaction)this.EntityDataSource.Transaction);
                        sqlAdapter.Fill(datatable);

                        break;
                    case DataSourceType.DB_Oracle:
                        OracleDataAdapter oraAdapter = new OracleDataAdapter();
                        oraAdapter.SelectCommand = new OracleCommand(strSql, (OracleConnection)this.EntityDataSource.Connection, (OracleTransaction)this.EntityDataSource.Transaction);
                        oraAdapter.Fill(datatable);

                        break;
                    default:
                        OleDbDataAdapter oleAdapter = new OleDbDataAdapter();
                        oleAdapter.SelectCommand = new OleDbCommand(strSql, (OleDbConnection)this.EntityDataSource.Connection, (OleDbTransaction)this.EntityDataSource.Transaction);
                        oleAdapter.Fill(datatable);

                        break;
                }
                if (datatable == null || datatable.Rows.Count == 0) 
                { 
                    return false; 
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);

            }
            finally
            {
                this.EntityDataSource.Close();
            }
        }

        //���� 2008-8-13 ����
        //�ӻ����л�ȡʵ�����
        public IEntity GetModelByCache(long lngkey)
        {
            string CacheKey = m_TableName + "_" + lngkey;// ����+����ID ����T_ZD_8
            object objModel = DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                SelectAllFieldsByKey(lngkey);//��������ID��ȡʵ�����
                objModel = (IEntity)this.ItemIndex(0);
                int ModelCache = ConfigHelper.GetConfigInt("ModelCache");
                DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
            }
            return (IEntity)objModel;
        }
        #endregion

        /// <summary>
        /// ʹ��SortedListʱҪʵ��IComparer�ӿڣ���ʹ��SortedList��������������
        /// </summary>
        public class MySort : IComparer
        {
            #region IComparer ��Ա
            public int Compare(object x, object y)
            {
                return -1;
                
                //����
                //int iResult = (int)x - (int)y;
                //if(iResult == 0) iResult = -1;
                //return iResult;

            }
            #endregion
        }

        #region ����������ѯ�����ؼ�¼��
        /// <summary>
        /// ����������ѯ�����ؼ�¼��
        /// </summary>
        /// <param name="strWhereClause"></param>
        /// <returns>���ؼ�¼��</returns>
        public int GetCountByCondition(string strWhereClause)
        {
            string strTableName = m_TableName;
            if (m_HisTable == true && m_HisTableName.Length > 0)
                strTableName = m_HisTableName;

            string strSql = "select 1 from " + strTableName + " where " + strWhereClause;
            try
            {
                //this.EntityDataSource.Open();
                DataTable datatable = EntityDataSource.ExecuteDataTable(strSql);
                return datatable.Rows.Count;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                //this.EntityDataSource.Close();
            }
        }
        #endregion
    }
}
