using System;
using System.Data;
using System.Xml;
using System.Text;

namespace GisqRealEstate.ProDataSource
{
	
	/// <summary>
	/// 数据连接对象类
	/// </summary>
	public abstract class GisqLandProDataSource : IDisposable 
	{        
		#region IDisposable 成员
		public virtual void Dispose(bool disposing)
		{
			if(!disposing)
				return;
			
			if(this.Connection != null)			
				this.Connection.Close();
		}

		public void Dispose()
		{
			// TODO:  添加 GisqSdeDataSource.Dispose 实现
			this.Dispose(true);
			GC.SuppressFinalize(true);
		}
		#endregion		
		/// <summary>
		/// 得到数据库的连接信息
		/// </summary>
		public abstract IDbConnection Connection
		{
			get;
		}
		/// <summary>
		/// 公开事务连接操作
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
        /// 数据库类型属性
        /// </summary>
        public abstract DataSourceType DbType
        {
            get;
        }
        /// <summary>
        /// 根据数据库的不同，返回sql语句中截取字符串的函数
        /// </summary>
        public abstract string SubString
        {
            get;
        }

        /// <summary>
        /// 根据数据库的不同，返回SQL语句中返回日期格式字符串
        /// </summary>
        public abstract string ToDate(string strDate);

        /// <summary>
        /// 根据数据库的不同，返回SQL语句中返回日期格式字符串，在INSERT,UPDATE中使用
        /// </summary>
        /// <param name="strDate">日期字符串</param>
        /// <param name="IsLongFormat">是否是长格式</param>
        /// <returns></returns>
        public abstract string ToDate(string strDate, bool IsLongFormat);

        /// <summary>
        /// 获取数据库时间字段的短日期格式内容,在SELECT语句中使用
        /// </summary>
        /// <param name="strColName">字段名称</param>
        /// <returns></returns>
        public abstract string FormtDateSql(string strColName);
        /// <summary>
        /// 获取数据库时间字段的短日期格式内容,在SELECT语句中使用
        /// </summary>
        /// <param name="strColName">字段名称</param>
        /// <param name="strAnotherName">字段别名</param>
        /// <returns></returns>
        public abstract string FormtDateSql(string strColName, string strAnotherName);
        /// <summary>
        /// 获取数据库时间字段的短日期格式内容,在SELECT语句中使用
        /// </summary>
        /// <param name="strColName">字段名称</param>
        /// <param name="strAnotherName">字段别名</param>
        /// <param name="IsLongFormat">是否是长日期格式</param>
        /// <returns></returns>
        public abstract string FormtDateSql(string strColName, string strAnotherName, bool IsLongFormat);

        public abstract string GetEnumNameByValue(string strDicName,string strValue);

        /// <summary>
        /// SQL语句中的加号连接符号,sqlserver为“+”，oracle为“||”
        /// </summary>
        public abstract string Plus
        {
            get;
        }

        /// <summary>
        /// 根据数据库的不同，返回sql语句中截取字符串的函数
        /// </summary>
        public abstract string Dbo
        {
            get;
        }

        /// <summary>
        /// 根据数据库的不同，返回sql语句空值判断的函数
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
        /// 执行Sql语句，并返回受影响的行数
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public abstract int ExecuteBlobNonQuery(string commandText,byte[] b);
        #endregion
		#region ExecuteNonQuery
		/// <summary>
        /// 执行Sql语句，并返回受影响的行数
		/// </summary>
		/// <param name="commandText"></param>
		/// <returns></returns>
		public abstract int ExecuteNonQuery(string commandText);
		#endregion
		#region ExecuteReader
		/// <summary>
		/// 执行命令，返回一个类型化的IDataReader
		/// </summary>
		/// <param name="commandText"></param>
		/// <returns></returns>
		public abstract IDataReader  ExecuteReader(string commandText);
		#endregion
		#region ExecuteScalar
		/// <summary>
		/// 执行命令，返回一个值
		/// </summary>
		/// <param name="commandText"></param>
		/// <returns></returns>
		public abstract  object ExecuteScalar(string commandText);
		#endregion

        #region ExecuteDataSet
        /// <summary>
        /// 执行命令，返回一个DataSet
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public abstract DataSet ExecuteDataSet(string commandText);
        #endregion

        #region ExecuteDataTable
        /// <summary>
        /// 执行命令，返回一个DataTable
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
        /// 获取SqlServer分页的sql语句
        /// </summary>
        /// <param name="strQuerySql"></param>
        /// <param name="lngPageIndex"></param>
        /// <param name="lngPageSize"></param>
        /// <param name="strKeyId">sqlserver分页必需</param>
        /// <param name="strOrderSql">sqlserver分页必需</param>
        /// <returns></returns>
        public virtual string GetPagingSql(string strQuerySql, long lngPageIndex, long lngPageSize, string strKeyId, string strOrderSql)
        {
            return "";
        }

        /// <summary>
        /// 获取Oracle分页的sql语句
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
        /// 根据条件获取数据字典集合
        /// </summary>
        /// <param name="strFldLetterName"></param>
        /// <param name="strParentEnumValue"></param>
        /// <param name="intLevel">1--第一级枚举或者已知父枚举值的当前级；2--所有枚举；3--最后一级枚举</param>
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
                case 1://第一级枚举或者已知父枚举值的当前级
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
                case 2://取得所有枚举
                    break;
                case 3://最后一级枚举
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
        /// 根据代码获取系统设置的值
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
        /// 根据代码获取系统设置的值
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
        /// 获取当前项目的变更版本
        /// </summary>
        /// <param name="strProjectId">当前项目的编码</param>
        /// <param name="blnGetNewIfNotExists">如果没有是否需要创建版本</param>
        /// <returns>返回变更版本</returns>
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
        /// 通过枚举名称获取枚举值
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

        #region 获取宗地编号连接字符串
        /// <summary>
        /// 根据ZDID查询并获取宗地编号连接字符串
        /// </summary>
        /// <param name="lngZdId">ZDID</param>
        /// <param name="blnHistory">是否是历史宗地</param>
        /// <returns></returns>
        public string GetZDBH(long lngZdId, bool blnHistory)
        {
            return GetZDBH(lngZdId, blnHistory, false);
        }

        /// <summary>
        /// 根据ZDID查询并获取宗地编号连接字符串(带有分宗地代码)
        /// </summary>
        /// <param name="lngZdId">ZDID</param>
        /// <param name="blnHistory">是否是历史宗地</param>
        /// <param name="strFZDDM">分宗地代码</param>
        /// <returns></returns>
        public string GetZDBH(long lngZdId, bool blnHistory, string strFZDDM)
        {
            if (strFZDDM != "")
                return GetZDBH(lngZdId, blnHistory, false) + "(" + strFZDDM + ")";
            else
                return GetZDBH(lngZdId, blnHistory, false);
        }

        /// <summary>
        /// 根据ZDID查询并获取宗地编号连接字符串（是否需要格式化）
        /// </summary>
        /// <param name="lngZdId">ZDID</param>
        /// <param name="blnHistory">是否是历史宗地</param>
        /// <param name="blnNeedFormat">是否根据系统设置，将宗地编号各部分进行位数格式化</param>
        /// <returns></returns>
        public string GetZDBH(long lngZdId, bool blnHistory, bool blnNeedFormat)
        {
            //20130917考虑到新宗地编码的情况，查询需要考虑情况
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
        /// 根据提供的信息获取宗地编号的连接字符串
        /// </summary>
        /// <param name="strSzJf">所在街坊</param>
        /// <param name="strZdZh">宗地主号</param>
        /// <param name="strZdFh">宗地支号</param>
        /// <returns></returns>
        public string GetZDBH(string strSzJf, string strZdZh, string strZdFh)
        {
            return GetZDBH(strSzJf, strZdZh, strZdFh, false);
        }
        /// <summary>
        /// 根据提供的信息获取宗地编号的连接字符串（是否需要格式化）
        /// </summary>
        /// <param name="strSzJf">所在街坊</param>
        /// <param name="strZdZh">宗地主号</param>
        /// <param name="strZdFh">宗地支号</param>
        /// <param name="blnNeedFormat">是否根据系统设置，将宗地编号各部分进行位数格式化</param>
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

        #region 通过查询条件或得信息返回DataTable 倪明奇
        /// <summary>
        /// ExecuteDataTable方法重载，只需要传入表名和查询条件
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

        #region 宗地加密相关方法
        /// <summary>
        /// 系统是否处于宗地加密状态
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
        /// 加密算子
        /// </summary>
        public string SpecialString
        {
            get { return DESEncrypt.Decrypt(GetSysSetting("Special").Trim(), "x", true); }
        }

        /// <summary>
        /// 根据zdid获取加密值
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
            //加密复杂化
            string strPre = DESEncrypt.Encrypt(strZdmm + "@auto@GisqLandSystem.net@auto", "-_-", true);
            strZdmm = DESEncrypt.Encrypt(strZdmm, "$_$", true);
            strZdmm = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(string.Format("{0}{1}", strPre, strZdmm)));
            strZdmm = DESEncrypt.Encrypt(strZdmm, "^_^", true);
            strZdmm = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(strZdmm));
            return strZdmm;
        }

        /// <summary>
        /// 判断宗地数据是否正常，不正常则抛出错误
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
                string strEncode = DESEncrypt.Encrypt(strTemp, "$_$", true); //对md5加密值进行再次加密
                int pos = strDecode.LastIndexOf(strEncode);
                bool bln = (pos > -1) && ((pos + strEncode.Length) == strDecode.Length) && (strDecode.IndexOf(DESEncrypt.Encrypt(strTemp, "-_-", true)) == 0);
                //if (!bln) throw new Exception("对不起，获取的宗地数据存在异常，请联系系统管理员！");
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
                            strZdBh = "宗地统一编码:" + strDjqDm + strZdSyqLx + strZdTzm + strDjqZh.PadLeft(5, '0');
                            if(!string.IsNullOrEmpty(strSzJf) && !string.IsNullOrEmpty(strZdZh))
                                strZdBh += ",宗地编号:" + strSzJf + "-" + strZdZh + (string.IsNullOrEmpty(strZdFh) ? "" : ("-" + strZdFh));
                        }
                        else
                        {
                            strZdBh = "宗地编号：" + strSzJf + "-" + strZdZh + (string.IsNullOrEmpty(strZdFh) ? "" : ("-" + strZdFh));
                        }
                        string strMsg = string.Format("对不起，获取的宗地数据存在异常，请联系系统管理员！(宗地内码：{0},{1})",strZdId,strZdBh);
                        throw new Exception(strMsg);
                    }
                }
                return true;
            }
            return true;
        }
    }
}
