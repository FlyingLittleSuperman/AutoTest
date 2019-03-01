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

	public class Fld_BDCDYZT
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string DYBSM="DYBSM";
		public const string DYBM="DYBM";
		public const string BDCDYH="BDCDYH";
		public const string CFZT="CFZT";
		public const string DYZT="DYZT";
		public const string YGZT="YGZT";
		public const string XZZT="XZZT";
		public const string QSZT="QSZT";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string YXTBSM="YXTBSM";
		public const string QLBSM="QLBSM";
		public const string QLBM="QLBM";
		public const string ZDZHBSM="ZDZHBSM";
		public const string ZDZHBM="ZDZHBM";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string YXTBM="YXTBM";
		public const string BZ_ZD_ID="BZ_ZD_ID";
		public const string HROOMID="HROOMID";
		public const string BZ_ZDTYBM="BZ_ZDTYBM";
		public const string FWCODE="FWCODE";
		public const string FWID="FWID";
		public const string CLFZT="CLFZT";
		public const string SPFZT="SPFZT";
		#endregion
	}

	public class clsBDCDYZT:IEntity
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
		private long m_DYBSM;
		private string m_DYBM;
		private string m_BDCDYH;
		private long m_CFZT;
		private long m_DYZT;
		private long m_YGZT;
		private string m_XZZT;
		private long m_QSZT;
		private long m_QXDM;
		private long m_REV_;
		private string m_YXTBSM;
		private long m_QLBSM;
		private string m_QLBM;
		private long m_ZDZHBSM;
		private string m_ZDZHBM;
		private DateTime m_GXSJ;
		private string m_BZ;
		private string m_YXTBM;
		private long m_BZ_ZD_ID;
		private long m_HROOMID;
		private string m_BZ_ZDTYBM;
		private long m_FWCODE;
		private long m_FWID;
		private long m_CLFZT;
		private long m_SPFZT;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public long DYBSM
		{
			get{ return m_DYBSM; }
			set{ m_DYBSM = value; }
		}
		public string DYBM
		{
			get{ return m_DYBM; }
			set{ m_DYBM = value; }
		}
		public string BDCDYH
		{
			get{ return m_BDCDYH; }
			set{ m_BDCDYH = value; }
		}
		public long CFZT
		{
			get{ return m_CFZT; }
			set{ m_CFZT = value; }
		}
		public long DYZT
		{
			get{ return m_DYZT; }
			set{ m_DYZT = value; }
		}
		public long YGZT
		{
			get{ return m_YGZT; }
			set{ m_YGZT = value; }
		}
		public string XZZT
		{
			get{ return m_XZZT; }
			set{ m_XZZT = value; }
		}
		public long QSZT
		{
			get{ return m_QSZT; }
			set{ m_QSZT = value; }
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
		public string YXTBSM
		{
			get{ return m_YXTBSM; }
			set{ m_YXTBSM = value; }
		}
		public long QLBSM
		{
			get{ return m_QLBSM; }
			set{ m_QLBSM = value; }
		}
		public string QLBM
		{
			get{ return m_QLBM; }
			set{ m_QLBM = value; }
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
		public string YXTBM
		{
			get{ return m_YXTBM; }
			set{ m_YXTBM = value; }
		}
		public long BZ_ZD_ID
		{
			get{ return m_BZ_ZD_ID; }
			set{ m_BZ_ZD_ID = value; }
		}
		public long HROOMID
		{
			get{ return m_HROOMID; }
			set{ m_HROOMID = value; }
		}
		public string BZ_ZDTYBM
		{
			get{ return m_BZ_ZDTYBM; }
			set{ m_BZ_ZDTYBM = value; }
		}
		public long FWCODE
		{
			get{ return m_FWCODE; }
			set{ m_FWCODE = value; }
		}
		public long FWID
		{
			get{ return m_FWID; }
			set{ m_FWID = value; }
		}
		public long CLFZT
		{
			get{ return m_CLFZT; }
			set{ m_CLFZT = value; }
		}
		public long SPFZT
		{
			get{ return m_SPFZT; }
			set{ m_SPFZT = value; }
		}

		#endregion
		public bool IsEquals(clsBDCDYZT obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.DYBSM != obj.DYBSM) bolResult = false;
			if (this.DYBM != obj.DYBM) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.CFZT != obj.CFZT) bolResult = false;
			if (this.DYZT != obj.DYZT) bolResult = false;
			if (this.YGZT != obj.YGZT) bolResult = false;
			if (this.XZZT != obj.XZZT) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.QLBSM != obj.QLBSM) bolResult = false;
			if (this.QLBM != obj.QLBM) bolResult = false;
			if (this.ZDZHBSM != obj.ZDZHBSM) bolResult = false;
			if (this.ZDZHBM != obj.ZDZHBM) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.BZ_ZD_ID != obj.BZ_ZD_ID) bolResult = false;
			if (this.HROOMID != obj.HROOMID) bolResult = false;
			if (this.BZ_ZDTYBM != obj.BZ_ZDTYBM) bolResult = false;
			if (this.FWCODE != obj.FWCODE) bolResult = false;
			if (this.FWID != obj.FWID) bolResult = false;
			if (this.CLFZT != obj.CLFZT) bolResult = false;
			if (this.SPFZT != obj.SPFZT) bolResult = false;
			return bolResult;
		}

		public void Colne(clsBDCDYZT obj)
		{
			this.BSM=obj.BSM;
			this.DYBSM=obj.DYBSM;
			this.DYBM=obj.DYBM;
			this.BDCDYH=obj.BDCDYH;
			this.CFZT=obj.CFZT;
			this.DYZT=obj.DYZT;
			this.YGZT=obj.YGZT;
			this.XZZT=obj.XZZT;
			this.QSZT=obj.QSZT;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.YXTBSM=obj.YXTBSM;
			this.QLBSM=obj.QLBSM;
			this.QLBM=obj.QLBM;
			this.ZDZHBSM=obj.ZDZHBSM;
			this.ZDZHBM=obj.ZDZHBM;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.YXTBM=obj.YXTBM;
			this.BZ_ZD_ID=obj.BZ_ZD_ID;
			this.HROOMID=obj.HROOMID;
			this.BZ_ZDTYBM=obj.BZ_ZDTYBM;
			this.FWCODE=obj.FWCODE;
			this.FWID=obj.FWID;
			this.CLFZT=obj.CLFZT;
			this.SPFZT=obj.SPFZT;
		}

	}

	public class clsBDCDYZTSet:EntityBaseSet
	{
		public clsBDCDYZTSet()
		{
			m_TableName="BDCDJ.BDCDYZT";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsBDCDYZTSet";
		}
		public static clsBDCDYZTSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsBDCDYZTSet clsSet = new clsBDCDYZTSet(); //(clsBDCDYZTSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsBDCDYZTSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsBDCDYZT obj = (clsBDCDYZT)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("DYBSM")) datarow["DYBSM"] = obj.DYBSM;
				if(datarow.Table.Columns.Contains("DYBM")) datarow["DYBM"] = obj.DYBM;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("CFZT")) datarow["CFZT"] = obj.CFZT;
				if(datarow.Table.Columns.Contains("DYZT")) datarow["DYZT"] = obj.DYZT;
				if(datarow.Table.Columns.Contains("YGZT")) datarow["YGZT"] = obj.YGZT;
				if(datarow.Table.Columns.Contains("XZZT")) datarow["XZZT"] = obj.XZZT;
				if(datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("QLBSM")) datarow["QLBSM"] = obj.QLBSM;
				if(datarow.Table.Columns.Contains("QLBM")) datarow["QLBM"] = obj.QLBM;
				if(datarow.Table.Columns.Contains("ZDZHBSM")) datarow["ZDZHBSM"] = obj.ZDZHBSM;
				if(datarow.Table.Columns.Contains("ZDZHBM")) datarow["ZDZHBM"] = obj.ZDZHBM;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("BZ_ZD_ID")) datarow["BZ_ZD_ID"] = obj.BZ_ZD_ID;
				if(datarow.Table.Columns.Contains("HROOMID")) datarow["HROOMID"] = obj.HROOMID;
				if(datarow.Table.Columns.Contains("BZ_ZDTYBM")) datarow["BZ_ZDTYBM"] = obj.BZ_ZDTYBM;
				if(datarow.Table.Columns.Contains("FWCODE")) datarow["FWCODE"] = obj.FWCODE;
				if(datarow.Table.Columns.Contains("FWID")) datarow["FWID"] = obj.FWID;
				if(datarow.Table.Columns.Contains("CLFZT")) datarow["CLFZT"] = obj.CLFZT;
				if(datarow.Table.Columns.Contains("SPFZT")) datarow["SPFZT"] = obj.SPFZT;
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
			clsBDCDYZT obj = null;
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
					obj = new clsBDCDYZT();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="DYBSM")
								if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
							if(strFldName.ToUpper()=="DYBM")
								if (pRow.Table.Columns.Contains("DYBM") && pRow["DYBM"] != DBNull.Value) { obj.DYBM = Convert.ToString(pRow["DYBM"]); }
							if(strFldName.ToUpper()=="BDCDYH")
								if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
							if(strFldName.ToUpper()=="CFZT")
								if (pRow.Table.Columns.Contains("CFZT") && pRow["CFZT"] != DBNull.Value) { obj.CFZT = Convert.ToInt64(pRow["CFZT"]); }
							if(strFldName.ToUpper()=="DYZT")
								if (pRow.Table.Columns.Contains("DYZT") && pRow["DYZT"] != DBNull.Value) { obj.DYZT = Convert.ToInt64(pRow["DYZT"]); }
							if(strFldName.ToUpper()=="YGZT")
								if (pRow.Table.Columns.Contains("YGZT") && pRow["YGZT"] != DBNull.Value) { obj.YGZT = Convert.ToInt64(pRow["YGZT"]); }
							if(strFldName.ToUpper()=="XZZT")
								if (pRow.Table.Columns.Contains("XZZT") && pRow["XZZT"] != DBNull.Value) { obj.XZZT = Convert.ToString(pRow["XZZT"]); }
							if(strFldName.ToUpper()=="QSZT")
								if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToInt64(pRow["QSZT"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
							if(strFldName.ToUpper()=="QLBSM")
								if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
							if(strFldName.ToUpper()=="QLBM")
								if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
							if(strFldName.ToUpper()=="ZDZHBSM")
								if (pRow.Table.Columns.Contains("ZDZHBSM") && pRow["ZDZHBSM"] != DBNull.Value) { obj.ZDZHBSM = Convert.ToInt64(pRow["ZDZHBSM"]); }
							if(strFldName.ToUpper()=="ZDZHBM")
								if (pRow.Table.Columns.Contains("ZDZHBM") && pRow["ZDZHBM"] != DBNull.Value) { obj.ZDZHBM = Convert.ToString(pRow["ZDZHBM"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="BZ_ZD_ID")
								if (pRow.Table.Columns.Contains("BZ_ZD_ID") && pRow["BZ_ZD_ID"] != DBNull.Value) { obj.BZ_ZD_ID = Convert.ToInt64(pRow["BZ_ZD_ID"]); }
							if(strFldName.ToUpper()=="HROOMID")
								if (pRow.Table.Columns.Contains("HROOMID") && pRow["HROOMID"] != DBNull.Value) { obj.HROOMID = Convert.ToInt64(pRow["HROOMID"]); }
							if(strFldName.ToUpper()=="BZ_ZDTYBM")
								if (pRow.Table.Columns.Contains("BZ_ZDTYBM") && pRow["BZ_ZDTYBM"] != DBNull.Value) { obj.BZ_ZDTYBM = Convert.ToString(pRow["BZ_ZDTYBM"]); }
							if(strFldName.ToUpper()=="FWCODE")
								if (pRow.Table.Columns.Contains("FWCODE") && pRow["FWCODE"] != DBNull.Value) { obj.FWCODE = Convert.ToInt64(pRow["FWCODE"]); }
							if(strFldName.ToUpper()=="FWID")
								if (pRow.Table.Columns.Contains("FWID") && pRow["FWID"] != DBNull.Value) { obj.FWID = Convert.ToInt64(pRow["FWID"]); }
							if(strFldName.ToUpper()=="CLFZT")
								if (pRow.Table.Columns.Contains("CLFZT") && pRow["CLFZT"] != DBNull.Value) { obj.CLFZT = Convert.ToInt64(pRow["CLFZT"]); }
							if(strFldName.ToUpper()=="SPFZT")
								if (pRow.Table.Columns.Contains("SPFZT") && pRow["SPFZT"] != DBNull.Value) { obj.SPFZT = Convert.ToInt64(pRow["SPFZT"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
						if (pRow.Table.Columns.Contains("DYBM") && pRow["DYBM"] != DBNull.Value) { obj.DYBM = Convert.ToString(pRow["DYBM"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("CFZT") && pRow["CFZT"] != DBNull.Value) { obj.CFZT = Convert.ToInt64(pRow["CFZT"]); }
						if (pRow.Table.Columns.Contains("DYZT") && pRow["DYZT"] != DBNull.Value) { obj.DYZT = Convert.ToInt64(pRow["DYZT"]); }
						if (pRow.Table.Columns.Contains("YGZT") && pRow["YGZT"] != DBNull.Value) { obj.YGZT = Convert.ToInt64(pRow["YGZT"]); }
						if (pRow.Table.Columns.Contains("XZZT") && pRow["XZZT"] != DBNull.Value) { obj.XZZT = Convert.ToString(pRow["XZZT"]); }
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToInt64(pRow["QSZT"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
						if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
						if (pRow.Table.Columns.Contains("ZDZHBSM") && pRow["ZDZHBSM"] != DBNull.Value) { obj.ZDZHBSM = Convert.ToInt64(pRow["ZDZHBSM"]); }
						if (pRow.Table.Columns.Contains("ZDZHBM") && pRow["ZDZHBM"] != DBNull.Value) { obj.ZDZHBM = Convert.ToString(pRow["ZDZHBM"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("BZ_ZD_ID") && pRow["BZ_ZD_ID"] != DBNull.Value) { obj.BZ_ZD_ID = Convert.ToInt64(pRow["BZ_ZD_ID"]); }
						if (pRow.Table.Columns.Contains("HROOMID") && pRow["HROOMID"] != DBNull.Value) { obj.HROOMID = Convert.ToInt64(pRow["HROOMID"]); }
						if (pRow.Table.Columns.Contains("BZ_ZDTYBM") && pRow["BZ_ZDTYBM"] != DBNull.Value) { obj.BZ_ZDTYBM = Convert.ToString(pRow["BZ_ZDTYBM"]); }
						if (pRow.Table.Columns.Contains("FWCODE") && pRow["FWCODE"] != DBNull.Value) { obj.FWCODE = Convert.ToInt64(pRow["FWCODE"]); }
						if (pRow.Table.Columns.Contains("FWID") && pRow["FWID"] != DBNull.Value) { obj.FWID = Convert.ToInt64(pRow["FWID"]); }
						if (pRow.Table.Columns.Contains("CLFZT") && pRow["CLFZT"] != DBNull.Value) { obj.CLFZT = Convert.ToInt64(pRow["CLFZT"]); }
						if (pRow.Table.Columns.Contains("SPFZT") && pRow["SPFZT"] != DBNull.Value) { obj.SPFZT = Convert.ToInt64(pRow["SPFZT"]); }
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
