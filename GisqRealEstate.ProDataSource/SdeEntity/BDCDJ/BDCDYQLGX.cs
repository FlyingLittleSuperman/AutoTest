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
修改/创建者：ASSASSIN | 修改时间（2016/11/16) | 说明(包括原因及涉及内容） |
==================================================
*/
namespace GisqRealEstate.ProDataSource
{

	public class Fld_BDCDYQLGX
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string ZDZHBSM="ZDZHBSM";
		public const string ZDZHBM="ZDZHBM";
		public const string DZWDYBSM="DZWDYBSM";
		public const string DZWDYBM="DZWDYBM";
		public const string BDCDYH="BDCDYH";
		public const string ZDZHQLBSM="ZDZHQLBSM";
		public const string ZDZHQLBM="ZDZHQLBM";
		public const string DZWQLBSM="DZWQLBSM";
		public const string DZWQLBM="DZWQLBM";
		public const string JLSJ="JLSJ";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string ZRZBSM="ZRZBSM";
		public const string YXTBM="YXTBM";
		#endregion
	}

	public class clsBDCDYQLGX:IEntity
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
		private string m_YWH;
		private long m_ZDZHBSM;
		private string m_ZDZHBM;
		private long m_DZWDYBSM;
		private string m_DZWDYBM;
		private string m_BDCDYH;
		private long m_ZDZHQLBSM;
		private string m_ZDZHQLBM;
		private long m_DZWQLBSM;
		private string m_DZWQLBM;
		private DateTime m_JLSJ;
		private DateTime m_GXSJ;
		private string m_BZ;
		private long m_QXDM;
		private long m_REV_;
		private long m_ZRZBSM;
		private string m_YXTBM;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public string YWH
		{
			get{ return m_YWH; }
			set{ m_YWH = value; }
		}
		public long ZDZHBSM
		{
			get{ return m_ZDZHBSM; }
			set{ m_ZDZHBSM = value; }
		}
		public string ZDZHBM
		{
			get{ return m_ZDZHBM; }
			set{ m_ZDZHBM = value; }
		}
		public long DZWDYBSM
		{
			get{ return m_DZWDYBSM; }
			set{ m_DZWDYBSM = value; }
		}
		public string DZWDYBM
		{
			get{ return m_DZWDYBM; }
			set{ m_DZWDYBM = value; }
		}
		public string BDCDYH
		{
			get{ return m_BDCDYH; }
			set{ m_BDCDYH = value; }
		}
		public long ZDZHQLBSM
		{
			get{ return m_ZDZHQLBSM; }
			set{ m_ZDZHQLBSM = value; }
		}
		public string ZDZHQLBM
		{
			get{ return m_ZDZHQLBM; }
			set{ m_ZDZHQLBM = value; }
		}
		public long DZWQLBSM
		{
			get{ return m_DZWQLBSM; }
			set{ m_DZWQLBSM = value; }
		}
		public string DZWQLBM
		{
			get{ return m_DZWQLBM; }
			set{ m_DZWQLBM = value; }
		}
		public DateTime JLSJ
		{
			get{ return m_JLSJ; }
			set{ m_JLSJ = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		public string BZ
		{
			get{ return m_BZ; }
			set{ m_BZ = value; }
		}
		public long QXDM
		{
			get{ return m_QXDM; }
			set{ m_QXDM = value; }
		}
		public long REV_
		{
			get{ return m_REV_; }
			set{ m_REV_ = value; }
		}
		public long ZRZBSM
		{
			get{ return m_ZRZBSM; }
			set{ m_ZRZBSM = value; }
		}
		public string YXTBM
		{
			get{ return m_YXTBM; }
			set{ m_YXTBM = value; }
		}

		#endregion
		public bool IsEquals(clsBDCDYQLGX obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.ZDZHBSM != obj.ZDZHBSM) bolResult = false;
			if (this.ZDZHBM != obj.ZDZHBM) bolResult = false;
			if (this.DZWDYBSM != obj.DZWDYBSM) bolResult = false;
			if (this.DZWDYBM != obj.DZWDYBM) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.ZDZHQLBSM != obj.ZDZHQLBSM) bolResult = false;
			if (this.ZDZHQLBM != obj.ZDZHQLBM) bolResult = false;
			if (this.DZWQLBSM != obj.DZWQLBSM) bolResult = false;
			if (this.DZWQLBM != obj.DZWQLBM) bolResult = false;
			if (this.JLSJ != obj.JLSJ) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.ZRZBSM != obj.ZRZBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			return bolResult;
		}

		public void Colne(clsBDCDYQLGX obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.ZDZHBSM=obj.ZDZHBSM;
			this.ZDZHBM=obj.ZDZHBM;
			this.DZWDYBSM=obj.DZWDYBSM;
			this.DZWDYBM=obj.DZWDYBM;
			this.BDCDYH=obj.BDCDYH;
			this.ZDZHQLBSM=obj.ZDZHQLBSM;
			this.ZDZHQLBM=obj.ZDZHQLBM;
			this.DZWQLBSM=obj.DZWQLBSM;
			this.DZWQLBM=obj.DZWQLBM;
			this.JLSJ=obj.JLSJ;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.ZRZBSM=obj.ZRZBSM;
			this.YXTBM=obj.YXTBM;
		}

	}

	public class clsBDCDYQLGXSet:EntityBaseSet
	{
		public clsBDCDYQLGXSet()
		{
			m_TableName="BDCDJ.BDCDYQLGX";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsBDCDYQLGXSet";
		}
		public static clsBDCDYQLGXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsBDCDYQLGXSet clsSet = new clsBDCDYQLGXSet(); //(clsBDCDYQLGXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsBDCDYQLGXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsBDCDYQLGX obj = (clsBDCDYQLGX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("ZDZHBSM")) datarow["ZDZHBSM"] = obj.ZDZHBSM;
				if(datarow.Table.Columns.Contains("ZDZHBM")) datarow["ZDZHBM"] = obj.ZDZHBM;
				if(datarow.Table.Columns.Contains("DZWDYBSM")) datarow["DZWDYBSM"] = obj.DZWDYBSM;
				if(datarow.Table.Columns.Contains("DZWDYBM")) datarow["DZWDYBM"] = obj.DZWDYBM;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("ZDZHQLBSM")) datarow["ZDZHQLBSM"] = obj.ZDZHQLBSM;
				if(datarow.Table.Columns.Contains("ZDZHQLBM")) datarow["ZDZHQLBM"] = obj.ZDZHQLBM;
				if(datarow.Table.Columns.Contains("DZWQLBSM")) datarow["DZWQLBSM"] = obj.DZWQLBSM;
				if(datarow.Table.Columns.Contains("DZWQLBM")) datarow["DZWQLBM"] = obj.DZWQLBM;
				if (obj.JLSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("JLSJ")) datarow["JLSJ"] = obj.JLSJ;
				}
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("ZRZBSM")) datarow["ZRZBSM"] = obj.ZRZBSM;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
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
			clsBDCDYQLGX obj = null;
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
					obj = new clsBDCDYQLGX();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="ZDZHBSM")
								if (pRow.Table.Columns.Contains("ZDZHBSM") && pRow["ZDZHBSM"] != DBNull.Value) { obj.ZDZHBSM = Convert.ToInt64(pRow["ZDZHBSM"]); }
							if(strFldName.ToUpper()=="ZDZHBM")
								if (pRow.Table.Columns.Contains("ZDZHBM") && pRow["ZDZHBM"] != DBNull.Value) { obj.ZDZHBM = Convert.ToString(pRow["ZDZHBM"]); }
							if(strFldName.ToUpper()=="DZWDYBSM")
								if (pRow.Table.Columns.Contains("DZWDYBSM") && pRow["DZWDYBSM"] != DBNull.Value) { obj.DZWDYBSM = Convert.ToInt64(pRow["DZWDYBSM"]); }
							if(strFldName.ToUpper()=="DZWDYBM")
								if (pRow.Table.Columns.Contains("DZWDYBM") && pRow["DZWDYBM"] != DBNull.Value) { obj.DZWDYBM = Convert.ToString(pRow["DZWDYBM"]); }
							if(strFldName.ToUpper()=="BDCDYH")
								if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
							if(strFldName.ToUpper()=="ZDZHQLBSM")
								if (pRow.Table.Columns.Contains("ZDZHQLBSM") && pRow["ZDZHQLBSM"] != DBNull.Value) { obj.ZDZHQLBSM = Convert.ToInt64(pRow["ZDZHQLBSM"]); }
							if(strFldName.ToUpper()=="ZDZHQLBM")
								if (pRow.Table.Columns.Contains("ZDZHQLBM") && pRow["ZDZHQLBM"] != DBNull.Value) { obj.ZDZHQLBM = Convert.ToString(pRow["ZDZHQLBM"]); }
							if(strFldName.ToUpper()=="DZWQLBSM")
								if (pRow.Table.Columns.Contains("DZWQLBSM") && pRow["DZWQLBSM"] != DBNull.Value) { obj.DZWQLBSM = Convert.ToInt64(pRow["DZWQLBSM"]); }
							if(strFldName.ToUpper()=="DZWQLBM")
								if (pRow.Table.Columns.Contains("DZWQLBM") && pRow["DZWQLBM"] != DBNull.Value) { obj.DZWQLBM = Convert.ToString(pRow["DZWQLBM"]); }
							if(strFldName.ToUpper()=="JLSJ")
								if (pRow.Table.Columns.Contains("JLSJ") && pRow["JLSJ"] != DBNull.Value) { obj.JLSJ = Convert.ToDateTime(pRow["JLSJ"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="ZRZBSM")
								if (pRow.Table.Columns.Contains("ZRZBSM") && pRow["ZRZBSM"] != DBNull.Value) { obj.ZRZBSM = Convert.ToInt64(pRow["ZRZBSM"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("ZDZHBSM") && pRow["ZDZHBSM"] != DBNull.Value) { obj.ZDZHBSM = Convert.ToInt64(pRow["ZDZHBSM"]); }
						if (pRow.Table.Columns.Contains("ZDZHBM") && pRow["ZDZHBM"] != DBNull.Value) { obj.ZDZHBM = Convert.ToString(pRow["ZDZHBM"]); }
						if (pRow.Table.Columns.Contains("DZWDYBSM") && pRow["DZWDYBSM"] != DBNull.Value) { obj.DZWDYBSM = Convert.ToInt64(pRow["DZWDYBSM"]); }
						if (pRow.Table.Columns.Contains("DZWDYBM") && pRow["DZWDYBM"] != DBNull.Value) { obj.DZWDYBM = Convert.ToString(pRow["DZWDYBM"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("ZDZHQLBSM") && pRow["ZDZHQLBSM"] != DBNull.Value) { obj.ZDZHQLBSM = Convert.ToInt64(pRow["ZDZHQLBSM"]); }
						if (pRow.Table.Columns.Contains("ZDZHQLBM") && pRow["ZDZHQLBM"] != DBNull.Value) { obj.ZDZHQLBM = Convert.ToString(pRow["ZDZHQLBM"]); }
						if (pRow.Table.Columns.Contains("DZWQLBSM") && pRow["DZWQLBSM"] != DBNull.Value) { obj.DZWQLBSM = Convert.ToInt64(pRow["DZWQLBSM"]); }
						if (pRow.Table.Columns.Contains("DZWQLBM") && pRow["DZWQLBM"] != DBNull.Value) { obj.DZWQLBM = Convert.ToString(pRow["DZWQLBM"]); }
						if (pRow.Table.Columns.Contains("JLSJ") && pRow["JLSJ"] != DBNull.Value) { obj.JLSJ = Convert.ToDateTime(pRow["JLSJ"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("ZRZBSM") && pRow["ZRZBSM"] != DBNull.Value) { obj.ZRZBSM = Convert.ToInt64(pRow["ZRZBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
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
