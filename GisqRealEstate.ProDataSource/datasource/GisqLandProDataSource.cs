using System;
using System.Data;
using System.Xml;
using System.Text;

namespace GisqRealEstate.ProDataSource
{
	
	/// <summary>
	/// �������Ӷ�����
	/// </summary>
	public abstract class GisqLandProDataSource : IDisposable 
	{        
		#region IDisposable ��Ա
		public virtual void Dispose(bool disposing)
		{
			if(!disposing)
				return;
			
			if(this.Connection != null)			
				this.Connection.Close();
		}

		public void Dispose()
		{
			// TODO:  ��� GisqSdeDataSource.Dispose ʵ��
			this.Dispose(true);
			GC.SuppressFinalize(true);
		}
		#endregion		
		/// <summary>
		/// �õ����ݿ��������Ϣ
		/// </summary>
		public abstract IDbConnection Connection
		{
			get;
		}
		/// <summary>
		/// �����������Ӳ���
		/// </summary>
		public abstract IDbTransaction Transaction
		{
			get;			
		}
        
        public abstract  ConnectionState State
        {
            get;
        }
        /// <summary>
        /// ���ݿ���������
        /// </summary>
        public abstract DataSourceType DbType
        {
            get;
        }
        /// <summary>
        /// �������ݿ�Ĳ�ͬ������sql����н�ȡ�ַ����ĺ���
        /// </summary>
        public abstract string SubString
        {
            get;
        }

        /// <summary>
        /// �������ݿ�Ĳ�ͬ������SQL����з������ڸ�ʽ�ַ���
        /// </summary>
        public abstract string ToDate(string strDate);

        /// <summary>
        /// �������ݿ�Ĳ�ͬ������SQL����з������ڸ�ʽ�ַ�������INSERT,UPDATE��ʹ��
        /// </summary>
        /// <param name="strDate">�����ַ���</param>
        /// <param name="IsLongFormat">�Ƿ��ǳ���ʽ</param>
        /// <returns></returns>
        public abstract string ToDate(string strDate, bool IsLongFormat);

        /// <summary>
        /// ��ȡ���ݿ�ʱ���ֶεĶ����ڸ�ʽ����,��SELECT�����ʹ��
        /// </summary>
        /// <param name="strColName">�ֶ�����</param>
        /// <returns></returns>
        public abstract string FormtDateSql(string strColName);
        /// <summary>
        /// ��ȡ���ݿ�ʱ���ֶεĶ����ڸ�ʽ����,��SELECT�����ʹ��
        /// </summary>
        /// <param name="strColName">�ֶ�����</param>
        /// <param name="strAnotherName">�ֶα���</param>
        /// <returns></returns>
        public abstract string FormtDateSql(string strColName, string strAnotherName);
        /// <summary>
        /// ��ȡ���ݿ�ʱ���ֶεĶ����ڸ�ʽ����,��SELECT�����ʹ��
        /// </summary>
        /// <param name="strColName">�ֶ�����</param>
        /// <param name="strAnotherName">�ֶα���</param>
        /// <param name="IsLongFormat">�Ƿ��ǳ����ڸ�ʽ</param>
        /// <returns></returns>
        public abstract string FormtDateSql(string strColName, string strAnotherName, bool IsLongFormat);

        public abstract string GetEnumNameByValue(string strDicName,string strValue);

        /// <summary>
        /// SQL����еļӺ����ӷ���,sqlserverΪ��+����oracleΪ��||��
        /// </summary>
        public abstract string Plus
        {
            get;
        }

        /// <summary>
        /// �������ݿ�Ĳ�ͬ������sql����н�ȡ�ַ����ĺ���
        /// </summary>
        public abstract string Dbo
        {
            get;
        }

        /// <summary>
        /// �������ݿ�Ĳ�ͬ������sql����ֵ�жϵĺ���
        /// </summary>
        public abstract string IsNull
        {
            get;
        }

		public abstract void Open();		

		public abstract void Close();

		public abstract void BeginTransaction();

		public abstract void CommitTransaction();

		public abstract void RollBackTransaction();	

		public abstract DataSourceType instDataSourceType();
        #region ExecuteBlobNonQuery
        /// <summary>
        /// ִ��Sql��䣬��������Ӱ�������
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public abstract int ExecuteBlobNonQuery(string commandText,byte[] b);
        #endregion
		#region ExecuteNonQuery
		/// <summary>
        /// ִ��Sql��䣬��������Ӱ�������
		/// </summary>
		/// <param name="commandText"></param>
		/// <returns></returns>
		public abstract int ExecuteNonQuery(string commandText);
		#endregion
		#region ExecuteReader
		/// <summary>
		/// ִ���������һ�����ͻ���IDataReader
		/// </summary>
		/// <param name="commandText"></param>
		/// <returns></returns>
		public abstract IDataReader  ExecuteReader(string commandText);
		#endregion
		#region ExecuteScalar
		/// <summary>
		/// ִ���������һ��ֵ
		/// </summary>
		/// <param name="commandText"></param>
		/// <returns></returns>
		public abstract  object ExecuteScalar(string commandText);
		#endregion

        #region ExecuteDataSet
        /// <summary>
        /// ִ���������һ��DataSet
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public abstract DataSet ExecuteDataSet(string commandText);
        #endregion

        #region ExecuteDataTable
        /// <summary>
        /// ִ���������һ��DataTable
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public abstract DataTable ExecuteDataTable(string commandText);
        #endregion

        #region GetServerTime
        public abstract  DateTime GetServerTime();
		#endregion

		#region GetNewID
        public abstract long GetNewID(string SeqName);
        public abstract long GetNewID(string SeqName, int Count);
		#endregion

        #region GetPagingSql
        /// <summary>
        /// ��ȡSqlServer��ҳ��sql���
        /// </summary>
        /// <param name="strQuerySql"></param>
        /// <param name="lngPageIndex"></param>
        /// <param name="lngPageSize"></param>
        /// <param name="strKeyId">sqlserver��ҳ����</param>
        /// <param name="strOrderSql">sqlserver��ҳ����</param>
        /// <returns></returns>
        public virtual string GetPagingSql(string strQuerySql, long lngPageIndex, long lngPageSize, string strKeyId, string strOrderSql)
        {
            return "";
        }

        /// <summary>
        /// ��ȡOracle��ҳ��sql���
        /// </summary>
        /// <param name="strQuerySql"></param>
        /// <param name="lngPageIndex"></param>
        /// <param name="lngPageSize"></param>
        /// <returns></returns>
        public virtual string GetPagingSql(string strQuerySql, long lngPageIndex, long lngPageSize)
        {
            return "";
        }
        #endregion

        #region GetSysDic
        /// <summary>
        /// ����������ȡ�����ֵ伯��
        /// </summary>
        /// <param name="strFldLetterName"></param>
        /// <param name="strParentEnumValue"></param>
        /// <param name="intLevel">1--��һ��ö�ٻ�����֪��ö��ֵ�ĵ�ǰ����2--����ö�٣�3--���һ��ö��</param>
        /// <returns></returns>
        public DataTable GetSysDic(string strFldLetterName, string strParentEnumValue, int intLevel)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" SELECT B.ENUM_NAME,B.ENUM_VALUE FROM T_FIELD_ENUM B WHERE ");
            sbSql.Append(" EXISTS (SELECT 1 FROM T_FIELD_EXPLAIN A WHERE A.FLD_EXP_ID=B.FLD_EXP_ID");
            sbSql.AppendFormat(" AND upper(A.FLD_LETTER_NAME) = upper('{0}')) ", strFldLetterName);

            strFldLetterName = strFldLetterName.ToUpper();
            switch (intLevel)
            {
                case 1://��һ��ö�ٻ�����֪��ö��ֵ�ĵ�ǰ��
                    if (strParentEnumValue.Length > 0)
                    {
                        sbSql.Append(" AND B.ENUM_LEVEL = ");
                        sbSql.Append(" (SELECT DISTINCT B.ENUM_LEVEL FROM T_FIELD_EXPLAIN A,T_FIELD_ENUM B WHERE A.FLD_EXP_ID=B.FLD_EXP_ID ");
                        sbSql.AppendFormat(" AND A.FLD_LETTER_NAME = '{0}' AND B.ENUM_VALUE = '{1}') ", strFldLetterName, strParentEnumValue);
                    }
                    else
                    {
                        sbSql.Append(" AND B.ENUM_LEVEL = 1 ");
                    }
                    break;
                case 2://ȡ������ö��
                    break;
                case 3://���һ��ö��
                    sbSql.Append(" AND B.ENUM_LEVEL = (SELECT MAX(C.ENUM_LEVEL) FROM T_FIELD_ENUM C WHERE C.FLD_EXP_ID=B.FLD_EXP_ID) ");
                    break;
            }
            if (strParentEnumValue.Length > 0)
                sbSql.AppendFormat(" AND B.PARENT_ENUM_VALUE = '{0}' ", strParentEnumValue);

            sbSql.Append(" ORDER BY B.USE_FREQUENCY DESC, B.ENUM_ORDER");

            return ExecuteDataTable(sbSql.ToString());
        }
        #endregion

        #region GetSysSetting
        /// <summary>
        /// ���ݴ����ȡϵͳ���õ�ֵ
        /// </summary>
        /// <param name="strCode"></param>
        /// <returns></returns>
        public string GetSysSetting(string strCode)
        {
            string strSql = "SELECT SZZ FROM T_XTSZ WHERE UPPER(SZ_DM) = '" + strCode.ToUpper() + "'";
            DataTable dt = ExecuteDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString().Trim();
            }
            else
            {
                return "";
            }
        }
        #endregion

        #region GetSysSetting
        /// <summary>
        /// ���ݴ����ȡϵͳ���õ�ֵ
        /// </summary>
        /// <param name="strCode"></param>
        /// <returns></returns>
        public string GetFrameConfig(string strEnumName)
        {
            string strSql = "SELECT ENUM_VALUE FROM FRAMEWORK.BT_FIELD_ENUM A WHERE UPPER(A.ENUM_NAME) = '" + strEnumName.ToUpper() + "'";
            DataTable dt = ExecuteDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString().Trim();
            }
            else
            {
                return "";
            }
        }
        #endregion

        #region GetBGBB
        /// <summary>
        /// ��ȡ��ǰ��Ŀ�ı���汾
        /// </summary>
        /// <param name="strProjectId">��ǰ��Ŀ�ı���</param>
        /// <param name="blnGetNewIfNotExists">���û���Ƿ���Ҫ�����汾</param>
        /// <returns>���ر���汾</returns>
        public long GetBGBB(string strProjectId, bool blnGetNewIfNotExists)
        {
            long lngBgbb = 0;
            try
            {
                string strSql = "select BG_BB from T_BGBB where PROJECT_ID = '" + strProjectId + "'";
                DataTable dt = ExecuteDataTable(strSql);
                if (dt.Rows.Count > 0)
                {
                    return DataVerify.VerifyLong(dt.Rows[0][0]);
                }
                else
                {
                    if (blnGetNewIfNotExists)
                    {
                        lngBgbb = GetNewID("Seq_BG_BB");
                        if (lngBgbb > 0)
                        {
                            string strGetDbTime = "";
                            switch (DbType)
                            {
                                case DataSourceType.DB_Oracle:
                                    strGetDbTime = "current_date";
                                    break;
                                case DataSourceType.DB_SqlServer:
                                    strGetDbTime = "getdate()";
                                    break;
                            }
                            strSql = "Insert into T_BGBB (BG_BB,BG_RQ,PROJECT_ID) " +
                                     " values (" + lngBgbb + "," + strGetDbTime + ",'" + strProjectId + "')";
                            ExecuteNonQuery(strSql);
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lngBgbb;
        }
        #endregion

        #region GetEnumValue
        /// <summary>
        /// ͨ��ö�����ƻ�ȡö��ֵ
        /// </summary>
        /// <param name="strFldLetterName"></param>
        /// <param name="strEnumName"></param>
        /// <returns></returns>
        public string GetEnumValueByName(string strFldLetterName, string strEnumName)
        {
            string strSql = "select a.ENUM_VALUE from T_FIELD_ENUM a,T_FIELD_EXPLAIN b "
                + " where a.FLD_EXP_ID=b.FLD_EXP_ID and a.ENUM_NAME='" + strEnumName + "' "
                + " and Upper(b.FLD_LETTER_NAME) = '" + strFldLetterName.ToUpper() + "'";

            DataTable dt = ExecuteDataTable(strSql);
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString().Trim();
            else
                return "";
        }
        #endregion

        #region ��ȡ�ڵر�������ַ���
        /// <summary>
        /// ����ZDID��ѯ����ȡ�ڵر�������ַ���
        /// </summary>
        /// <param name="lngZdId">ZDID</param>
        /// <param name="blnHistory">�Ƿ�����ʷ�ڵ�</param>
        /// <returns></returns>
        public string GetZDBH(long lngZdId, bool blnHistory)
        {
            return GetZDBH(lngZdId, blnHistory, false);
        }

        /// <summary>
        /// ����ZDID��ѯ����ȡ�ڵر�������ַ���(���з��ڵش���)
        /// </summary>
        /// <param name="lngZdId">ZDID</param>
        /// <param name="blnHistory">�Ƿ�����ʷ�ڵ�</param>
        /// <param name="strFZDDM">���ڵش���</param>
        /// <returns></returns>
        public string GetZDBH(long lngZdId, bool blnHistory, string strFZDDM)
        {
            if (strFZDDM != "")
                return GetZDBH(lngZdId, blnHistory, false) + "(" + strFZDDM + ")";
            else
                return GetZDBH(lngZdId, blnHistory, false);
        }

        /// <summary>
        /// ����ZDID��ѯ����ȡ�ڵر�������ַ������Ƿ���Ҫ��ʽ����
        /// </summary>
        /// <param name="lngZdId">ZDID</param>
        /// <param name="blnHistory">�Ƿ�����ʷ�ڵ�</param>
        /// <param name="blnNeedFormat">�Ƿ����ϵͳ���ã����ڵر�Ÿ����ֽ���λ����ʽ��</param>
        /// <returns></returns>
        public string GetZDBH(long lngZdId, bool blnHistory, bool blnNeedFormat)
        {
            //20130917���ǵ����ڵر�����������ѯ��Ҫ�������
            string strUserNewZdBm = GetSysSetting("NewZdBm");
            string strSql = "";
            if (strUserNewZdBm == "1")
            {
                if (blnHistory)
                    strSql = string.Format("SELECT DJQDM,ZD_SYQLX,ZD_TZM ,DJQZH FROM T_LSZD WHERE ZD_ID={0} AND ZD_SYQLX IS NOT NULL AND ZD_TZM IS NOT NULL AND DJQDM IS NOT NULL", lngZdId);
                else
                    strSql = string.Format("SELECT DJQDM,ZD_SYQLX,ZD_TZM ,DJQZH FROM T_ZD WHERE ZD_ID={0} AND ZD_SYQLX IS NOT NULL AND ZD_TZM IS NOT NULL AND DJQDM IS NOT NULL", lngZdId);

                DataTable dtXbm = ExecuteDataTable(strSql);
                if (dtXbm.Rows.Count > 0)
                {
                    string strDjqDm = dtXbm.Rows[0]["DJQDM"].ToString();
                    string strZdSyqLx = dtXbm.Rows[0]["ZD_SYQLX"].ToString();
                    string strZdTzm = dtXbm.Rows[0]["ZD_TZM"].ToString();
                    string strDjqZh = dtXbm.Rows[0]["DJQZH"].ToString();
                    string strZdTyBm = strDjqDm + strZdSyqLx + strZdTzm + strDjqZh.PadLeft(5, '0');
                    return strZdTyBm;
                }
            }
           
            if (blnHistory)
                strSql = "SELECT SZ_JF,ZD_ZH,ZD_FH FROM T_LSZD WHERE ZD_ID = " + lngZdId;
            else
                strSql = "SELECT SZ_JF,ZD_ZH,ZD_FH FROM T_ZD WHERE ZD_ID = " + lngZdId;
           
            DataTable dt = ExecuteDataTable(strSql);
            if (dt.Rows.Count == 0) return "";

            return GetZDBH(dt.Rows[0]["SZ_JF"].ToString(), dt.Rows[0]["ZD_ZH"].ToString(), dt.Rows[0]["ZD_FH"].ToString(), blnNeedFormat);
        }
        /// <summary>
        /// �����ṩ����Ϣ��ȡ�ڵر�ŵ������ַ���
        /// </summary>
        /// <param name="strSzJf">���ڽַ�</param>
        /// <param name="strZdZh">�ڵ�����</param>
        /// <param name="strZdFh">�ڵ�֧��</param>
        /// <returns></returns>
        public string GetZDBH(string strSzJf, string strZdZh, string strZdFh)
        {
            return GetZDBH(strSzJf, strZdZh, strZdFh, false);
        }
        /// <summary>
        /// �����ṩ����Ϣ��ȡ�ڵر�ŵ������ַ������Ƿ���Ҫ��ʽ����
        /// </summary>
        /// <param name="strSzJf">���ڽַ�</param>
        /// <param name="strZdZh">�ڵ�����</param>
        /// <param name="strZdFh">�ڵ�֧��</param>
        /// <param name="blnNeedFormat">�Ƿ����ϵͳ���ã����ڵر�Ÿ����ֽ���λ����ʽ��</param>
        /// <returns></returns>
        public string GetZDBH(string strSzJf, string strZdZh, string strZdFh, bool blnNeedFormat)
        {
            StringBuilder sbZdbh = new StringBuilder();

            string strJd = strSzJf.Substring(6, 3);
            string strJf = strSzJf.Substring(9);
            if (blnNeedFormat)
            {
                strJd = strJd.PadLeft(DataVerify.VerifyInt(GetSysSetting("CountJD")), '0');
                strJf = strJf.PadLeft(DataVerify.VerifyInt(GetSysSetting("CountJF")), '0');
                strZdZh = strZdZh.PadLeft(DataVerify.VerifyInt(GetSysSetting("CountZDZH")), '0');
                if (strZdFh.Length > 0 && strZdFh != "0")
                {
                    strZdFh = strZdFh.PadLeft(DataVerify.VerifyInt(GetSysSetting("CountZDFH")), '0');
                }
            }

            if (GetSysSetting("NEEDCOUNTYCODE") == "1") sbZdbh.Append(strSzJf.Substring(4, 2)).Append("-");
            sbZdbh.Append(strJd).Append("-").Append(strJf).Append("-").Append(strZdZh);
            if (strZdFh.Length > 0 && strZdFh != "0")
            {
                sbZdbh.Append("-").Append(strZdFh);
            }
            return sbZdbh.ToString();
        }

        #endregion

        #region ͨ����ѯ���������Ϣ����DataTable ������
        /// <summary>
        /// ExecuteDataTable�������أ�ֻ��Ҫ��������Ͳ�ѯ����
        /// </summary>
        /// <param name="strTableName"></param>
        /// <param name="strQueryConfig"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string strTableName, string strQueryConfig)
        {
            try
            {
                string strSql = string.Format("SELECT * FROM {0} WHERE {1} ", strTableName, strQueryConfig);
                DataTable dt = ExecuteDataTable(strSql);
                return dt;
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        #endregion

        #region �ڵؼ�����ط���
        /// <summary>
        /// ϵͳ�Ƿ����ڵؼ���״̬
        /// </summary>
        /// <returns></returns>
        public bool IsTerraEncrypt()
        {
            string strSpecial = GetSysSetting("Special").Trim();
            bool IsSpecialExist = strSpecial.Length == 0 ? false : true;
            string strSql = "select count(1) from sys.User_Tab_Columns where table_name = 'T_ZD' and COLUMN_NAME = 'ZD_MM'";
            bool IsFieldExist = DataVerify.VerifyBool(ExecuteDataTable(strSql).Rows[0][0]);
            strSql = "SELECT count(1) FROM sys.USER_OBJECTS WHERE OBJECT_TYPE='FUNCTION' AND OBJECT_NAME='GETMD5'";
            bool IsFunctionExist = DataVerify.VerifyBool(ExecuteDataTable(strSql).Rows[0][0]);

            if (!IsSpecialExist && !IsFieldExist && !IsFunctionExist) return false;
            
            return true;
        }
        
        /// <summary>
        /// ��������
        /// </summary>
        public string SpecialString
        {
            get { return DESEncrypt.Decrypt(GetSysSetting("Special").Trim(), "x", true); }
        }

        /// <summary>
        /// ����zdid��ȡ����ֵ
        /// </summary>
        /// <param name="lngZdId"></param>
        /// <param name="strSpecial"></param>
        /// <returns></returns>
        public string GetZdMm(long lngZdId)
        {
            string strZdId = lngZdId.ToString();
            string strSpecial = SpecialString;
            string strSql = string.Format("SELECT GETMD5('{0}{1}') FROM DUAL", strZdId, strSpecial);
            string strZdmm = ExecuteDataTable(strSql).Rows[0][0].ToString();
            //���ܸ��ӻ�
            string strPre = DESEncrypt.Encrypt(strZdmm + "@auto@GisqLandSystem.net@auto", "-_-", true);
            strZdmm = DESEncrypt.Encrypt(strZdmm, "$_$", true);
            strZdmm = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(string.Format("{0}{1}", strPre, strZdmm)));
            strZdmm = DESEncrypt.Encrypt(strZdmm, "^_^", true);
            strZdmm = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(strZdmm));
            return strZdmm;
        }

        /// <summary>
        /// �ж��ڵ������Ƿ����������������׳�����
        /// </summary>
        /// <param name="lngZdId"></param>
        /// <param name="blnIsHis"></param>
        /// <returns></returns>
        public bool IsPassTerraEncrypt(string strZdId, string strZdMm)
        {
            try
            {
                string strSpecial = SpecialString;
                string strDecode = strZdMm;
                strDecode = System.Text.Encoding.Default.GetString(Convert.FromBase64String(strDecode));
                strDecode = DESEncrypt.Decrypt(strDecode, "^_^", true);
                strDecode = System.Text.Encoding.Default.GetString(Convert.FromBase64String(strDecode));
                string strSql = string.Format("SELECT GETMD5('{0}{1}') FROM DUAL", strZdId, strSpecial);
                string strTemp = ExecuteDataTable(strSql).Rows[0][0].ToString();
                string strEncode = DESEncrypt.Encrypt(strTemp, "$_$", true); //��md5����ֵ�����ٴμ���
                int pos = strDecode.LastIndexOf(strEncode);
                bool bln = (pos > -1) && ((pos + strEncode.Length) == strDecode.Length) && (strDecode.IndexOf(DESEncrypt.Encrypt(strTemp, "-_-", true)) == 0);
                //if (!bln) throw new Exception("�Բ��𣬻�ȡ���ڵ����ݴ����쳣������ϵϵͳ����Ա��");
                return bln;
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        #endregion

        public string Length
        {
            get
            {
                if (DbType == DataSourceType.DB_SqlServer)
                    return "LEN";
                if (DbType == DataSourceType.DB_Oracle)
                    return "LENGTH";
                return "";
            }
        }

        public DataTable CombineTheSameDatatable(DataTable dt1, DataTable dt2)
        {

            if (dt1.Rows.Count == 0 && dt2.Rows.Count == 0)
            {
                return new DataTable();
            }

            if (dt1.Rows.Count == 0)
            {
                return dt2;
            }

            if (dt2.Rows.Count == 0)
            {
                return dt1;
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt1.Copy());
            ds.Merge(dt2.Copy());
            return ds.Tables[0];
        }

        public bool IsZdMmWightWithZdqlrId(string strZdqlrId)
        {
            try
            {
                string strSql = string.Format(@"SELECT A.ZD_ID FROM T_ZDQLR A WHERE A.ZDQLR_ID='{0}' 
UNION ALL SELECT A.ZD_ID FROM T_LSZDQLR A WHERE A.ZDQLR_ID='{0}'", strZdqlrId);
                DataTable dt = ExecuteDataTable(strSql);
                if (dt.Rows.Count == 0) return true;
                return IsZdMmWright(dt.Rows[0]["ZD_ID"].ToString());

            }
            catch (Exception er)
            {
                throw er;
            }
        }
        public bool IsZdMmWright(string strZdId)
        {
            if (IsTerraEncrypt())
            {
                string strSql = string.Format(@"SELECT A.ZD_MM,A.SZ_JF,A.DJQDM,A.ZD_SYQLX,A.ZD_TZM,A.DJQZH,A.ZD_ZH,A.ZD_FH FROM T_ZD A 
WHERE ZD_ID='{0}' UNION ALL SELECT A.ZD_MM,A.SZ_JF,A.DJQDM,A.ZD_SYQLX,A.ZD_TZM,A.DJQZH,A.ZD_ZH,A.ZD_FH FROM V_LSZD A WHERE A.ZD_ID='{0}'", strZdId);
                DataTable dt = ExecuteDataTable(strSql);
                if (dt.Rows.Count > 0)
                {
                    string strZdMM = dt.Rows[0]["ZD_MM"].ToString();
                    bool isWright = false;
                    try
                    {
                       isWright = IsPassTerraEncrypt(strZdId, strZdMM);
                    }
                    catch (Exception er)
                    {
                        isWright = false;
                    }

                    if (!isWright)
                    {
                        string strDjqDm = dt.Rows[0]["DJQDM"].ToString();
                        string strZdSyqLx = dt.Rows[0]["ZD_SYQLX"].ToString();
                        string strZdTzm = dt.Rows[0]["ZD_TZM"].ToString();
                        string strDjqZh = dt.Rows[0]["DJQZH"].ToString();
                        string strSzJf = dt.Rows[0]["SZ_JF"].ToString();
                        string strZdZh = dt.Rows[0]["ZD_ZH"].ToString();
                        string strZdFh = dt.Rows[0]["ZD_FH"].ToString();
                        string strZdBh = "";
                        if (!string.IsNullOrEmpty(strDjqDm) && !string.IsNullOrEmpty(strZdSyqLx) && !string.IsNullOrEmpty(strZdTzm))
                        {
                            strZdBh = "�ڵ�ͳһ����:" + strDjqDm + strZdSyqLx + strZdTzm + strDjqZh.PadLeft(5, '0');
                            if(!string.IsNullOrEmpty(strSzJf) && !string.IsNullOrEmpty(strZdZh))
                                strZdBh += ",�ڵر��:" + strSzJf + "-" + strZdZh + (string.IsNullOrEmpty(strZdFh) ? "" : ("-" + strZdFh));
                        }
                        else
                        {
                            strZdBh = "�ڵر�ţ�" + strSzJf + "-" + strZdZh + (string.IsNullOrEmpty(strZdFh) ? "" : ("-" + strZdFh));
                        }
                        string strMsg = string.Format("�Բ��𣬻�ȡ���ڵ����ݴ����쳣������ϵϵͳ����Ա��(�ڵ����룺{0},{1})",strZdId,strZdBh);
                        throw new Exception(strMsg);
                    }
                }
                return true;
            }
            return true;
        }
    }
}
