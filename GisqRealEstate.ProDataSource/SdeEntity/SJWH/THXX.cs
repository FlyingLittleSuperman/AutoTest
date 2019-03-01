using System;
using System.Data;

using GisqRealEstate.ProDataSource;

/*
==================================================
杭州网新超图地理信息技术有限公司
版权所有，未经授权不得进行复制、修改、传播、反向工程。
模块名称：
文件名称：
模块说明：
修改记录：
修改/创建者：ASSASSIN | 修改时间（2016/11/15) | 说明(包括原因及涉及内容） |
==================================================
*/
namespace GisqRealEstate.ProDataSource
{

	public class Fld_THXX
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string DQRWBH="DQRWBH";
		public const string TJRWBH="TJRWBH";
		public const string THR="THR";
		public const string THYJ="THYJ";
		public const string THSJ="THSJ";
		public const string JSR="JSR";
		public const string JSSJ="JSSJ";
		public const string XGYJ="XGYJ";
		public const string GXSJ="GXSJ";
		#endregion
	}

	public class clsTHXX:IEntity
	{
		private long m_PrimaryKeyValue = 0;
		private EnumEditState m_enuEditState = EnumEditState.esNoEdit;

		#region IEntity 成员
		public long PrimaryKeyValue 
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public EnumEditState EditState
		{
			get{ return m_enuEditState; }
			set{ m_enuEditState = value; }
		}
		#endregion

		#region 属性
		private string m_DQRWBH;
		private string m_TJRWBH;
		private string m_THR;
		private DateTime m_THYJ;
		private string m_THSJ;
		private string m_JSR;
		private DateTime m_JSSJ;
		private string m_XGYJ;
		private DateTime m_GXSJ;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public string DQRWBH
		{
			get{ return m_DQRWBH; }
			set{ m_DQRWBH = value; }
		}
		public string TJRWBH
		{
			get{ return m_TJRWBH; }
			set{ m_TJRWBH = value; }
		}
		public string THR
		{
			get{ return m_THR; }
			set{ m_THR = value; }
		}
		public DateTime THYJ
		{
			get{ return m_THYJ; }
			set{ m_THYJ = value; }
		}
		public string THSJ
		{
			get{ return m_THSJ; }
			set{ m_THSJ = value; }
		}
		public string JSR
		{
			get{ return m_JSR; }
			set{ m_JSR = value; }
		}
		public DateTime JSSJ
		{
			get{ return m_JSSJ; }
			set{ m_JSSJ = value; }
		}
		public string XGYJ
		{
			get{ return m_XGYJ; }
			set{ m_XGYJ = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}

		#endregion
		public bool IsEquals(clsTHXX obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.DQRWBH != obj.DQRWBH) bolResult = false;
			if (this.TJRWBH != obj.TJRWBH) bolResult = false;
			if (this.THR != obj.THR) bolResult = false;
			if (this.THYJ != obj.THYJ) bolResult = false;
			if (this.THSJ != obj.THSJ) bolResult = false;
			if (this.JSR != obj.JSR) bolResult = false;
			if (this.JSSJ != obj.JSSJ) bolResult = false;
			if (this.XGYJ != obj.XGYJ) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsTHXX obj)
		{
			this.BSM=obj.BSM;
			this.DQRWBH=obj.DQRWBH;
			this.TJRWBH=obj.TJRWBH;
			this.THR=obj.THR;
			this.THYJ=obj.THYJ;
			this.THSJ=obj.THSJ;
			this.JSR=obj.JSR;
			this.JSSJ=obj.JSSJ;
			this.XGYJ=obj.XGYJ;
			this.GXSJ=obj.GXSJ;
		}

	}

	public class clsTHXXSet:EntityBaseSet
	{
		public clsTHXXSet()
		{
			m_TableName="THXX";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
            m_SequenceName = "BDCDJ.SEQ_BSM";
			m_ClsName="clsTHXXSet";
		}
		public static clsTHXXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsTHXXSet clsSet = new clsTHXXSet(); //(clsTHXXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsTHXXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsTHXX obj = (clsTHXX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("DQRWBH")) datarow["DQRWBH"] = obj.DQRWBH;
				if(datarow.Table.Columns.Contains("TJRWBH")) datarow["TJRWBH"] = obj.TJRWBH;
				if(datarow.Table.Columns.Contains("THR")) datarow["THR"] = obj.THR;
				if (obj.THYJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("THYJ")) datarow["THYJ"] = obj.THYJ;
				}
				if(datarow.Table.Columns.Contains("THSJ")) datarow["THSJ"] = obj.THSJ;
				if(datarow.Table.Columns.Contains("JSR")) datarow["JSR"] = obj.JSR;
				if (obj.JSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("JSSJ")) datarow["JSSJ"] = obj.JSSJ;
				}
				if(datarow.Table.Columns.Contains("XGYJ")) datarow["XGYJ"] = obj.XGYJ;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}
		}
		protected override bool GetFieldsValue(DataTable datatable,string strFld)
		{
			DataRowCollection datarows = datatable.Rows;
			clsTHXX obj = null;
			long iKey = 0;
			DataRow pRow = null;
			string[] strFldsplit=null;
			try
			{
				RemoveAll();
				for (int i = 0; i < datarows.Count; i++)
				{
					pRow = datarows[i];
					if (pRow.Table.Columns.Contains("BSM") && pRow["BSM"] == DBNull.Value) { continue; }
					try
					{
						iKey = Convert.ToInt64(pRow["BSM"]);
					}
					catch  { continue; }  
					obj = new clsTHXX();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="DQRWBH")
								if (pRow.Table.Columns.Contains("DQRWBH") && pRow["DQRWBH"] != DBNull.Value) { obj.DQRWBH = Convert.ToString(pRow["DQRWBH"]); }
							if(strFldName.ToUpper()=="TJRWBH")
								if (pRow.Table.Columns.Contains("TJRWBH") && pRow["TJRWBH"] != DBNull.Value) { obj.TJRWBH = Convert.ToString(pRow["TJRWBH"]); }
							if(strFldName.ToUpper()=="THR")
								if (pRow.Table.Columns.Contains("THR") && pRow["THR"] != DBNull.Value) { obj.THR = Convert.ToString(pRow["THR"]); }
							if(strFldName.ToUpper()=="THYJ")
								if (pRow.Table.Columns.Contains("THYJ") && pRow["THYJ"] != DBNull.Value) { obj.THYJ = Convert.ToDateTime(pRow["THYJ"]); }
							if(strFldName.ToUpper()=="THSJ")
								if (pRow.Table.Columns.Contains("THSJ") && pRow["THSJ"] != DBNull.Value) { obj.THSJ = Convert.ToString(pRow["THSJ"]); }
							if(strFldName.ToUpper()=="JSR")
								if (pRow.Table.Columns.Contains("JSR") && pRow["JSR"] != DBNull.Value) { obj.JSR = Convert.ToString(pRow["JSR"]); }
							if(strFldName.ToUpper()=="JSSJ")
								if (pRow.Table.Columns.Contains("JSSJ") && pRow["JSSJ"] != DBNull.Value) { obj.JSSJ = Convert.ToDateTime(pRow["JSSJ"]); }
							if(strFldName.ToUpper()=="XGYJ")
								if (pRow.Table.Columns.Contains("XGYJ") && pRow["XGYJ"] != DBNull.Value) { obj.XGYJ = Convert.ToString(pRow["XGYJ"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("DQRWBH") && pRow["DQRWBH"] != DBNull.Value) { obj.DQRWBH = Convert.ToString(pRow["DQRWBH"]); }
						if (pRow.Table.Columns.Contains("TJRWBH") && pRow["TJRWBH"] != DBNull.Value) { obj.TJRWBH = Convert.ToString(pRow["TJRWBH"]); }
						if (pRow.Table.Columns.Contains("THR") && pRow["THR"] != DBNull.Value) { obj.THR = Convert.ToString(pRow["THR"]); }
						if (pRow.Table.Columns.Contains("THYJ") && pRow["THYJ"] != DBNull.Value) { obj.THYJ = Convert.ToDateTime(pRow["THYJ"]); }
						if (pRow.Table.Columns.Contains("THSJ") && pRow["THSJ"] != DBNull.Value) { obj.THSJ = Convert.ToString(pRow["THSJ"]); }
						if (pRow.Table.Columns.Contains("JSR") && pRow["JSR"] != DBNull.Value) { obj.JSR = Convert.ToString(pRow["JSR"]); }
						if (pRow.Table.Columns.Contains("JSSJ") && pRow["JSSJ"] != DBNull.Value) { obj.JSSJ = Convert.ToDateTime(pRow["JSSJ"]); }
						if (pRow.Table.Columns.Contains("XGYJ") && pRow["XGYJ"] != DBNull.Value) { obj.XGYJ = Convert.ToString(pRow["XGYJ"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
					}
					Add(obj);
				}
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex);
			}
		}

	}
}
