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

	public class Fld_ZH
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string ZHDM="ZHDM";
		public const string BDCDYH="BDCDYH";
		public const string YSDM="YSDM";
		public const string ZHTZM="ZHTZM";
		public const string XMMC="XMMC";
		public const string XMXZ="XMXZ";
		public const string YHZMJ="YHZMJ";
		public const string ZHMJ="ZHMJ";
		public const string DB="DB";
		public const string ZHAX="ZHAX";
		public const string YHLXA="YHLXA";
		public const string YHLXB="YHLXB";
		public const string YHWZSM="YHWZSM";
		public const string HDMC="HDMC";
		public const string HDDM="HDDM";
		public const string YDFW="YDFW";
		public const string YDMJ="YDMJ";
		public const string HDWZ="HDWZ";
		public const string HDYT="HDYT";
		public const string ZHT="ZHT";
		public const string ZT="ZT";
		public const string MJDW="MJDW";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string DCBSM="DCBSM";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string DCYWH="DCYWH";
		public const string YWH="YWH";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string TXBZ="TXBZ";
		public const string QLXZ="QLXZ";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsZH:IEntity
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
		private string m_ZHDM;
		private string m_BDCDYH;
		private string m_YSDM;
		private string m_ZHTZM;
		private string m_XMMC;
		private string m_XMXZ;
		private double m_YHZMJ;
		private double m_ZHMJ;
		private string m_DB;
		private double m_ZHAX;
		private string m_YHLXA;
		private string m_YHLXB;
		private string m_YHWZSM;
		private string m_HDMC;
		private string m_HDDM;
		private string m_YDFW;
		private double m_YDMJ;
		private string m_HDWZ;
		private string m_HDYT;
		private string m_ZHT;
		private string m_ZT;
		private string m_MJDW;
		private string m_YXTBM;
		private string m_YXTBSM;
		private long m_DCBSM;
		private long m_QXDM;
		private long m_REV_;
		private string m_DCYWH;
		private string m_YWH;
		private DateTime m_GXSJ;
		private string m_BZ;
		private int m_TXBZ;
		private string m_QLXZ;
		private long m_BG_BB;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public string ZHDM
		{
			get{ return m_ZHDM; }
			set{ m_ZHDM = value; }
		}
		public string BDCDYH
		{
			get{ return m_BDCDYH; }
			set{ m_BDCDYH = value; }
		}
		public string YSDM
		{
			get{ return m_YSDM; }
			set{ m_YSDM = value; }
		}
		public string ZHTZM
		{
			get{ return m_ZHTZM; }
			set{ m_ZHTZM = value; }
		}
		public string XMMC
		{
			get{ return m_XMMC; }
			set{ m_XMMC = value; }
		}
		public string XMXZ
		{
			get{ return m_XMXZ; }
			set{ m_XMXZ = value; }
		}
		public double YHZMJ
		{
			get{ return m_YHZMJ; }
			set{ m_YHZMJ = value; }
		}
		public double ZHMJ
		{
			get{ return m_ZHMJ; }
			set{ m_ZHMJ = value; }
		}
		public string DB
		{
			get{ return m_DB; }
			set{ m_DB = value; }
		}
		public double ZHAX
		{
			get{ return m_ZHAX; }
			set{ m_ZHAX = value; }
		}
		public string YHLXA
		{
			get{ return m_YHLXA; }
			set{ m_YHLXA = value; }
		}
		public string YHLXB
		{
			get{ return m_YHLXB; }
			set{ m_YHLXB = value; }
		}
		public string YHWZSM
		{
			get{ return m_YHWZSM; }
			set{ m_YHWZSM = value; }
		}
		public string HDMC
		{
			get{ return m_HDMC; }
			set{ m_HDMC = value; }
		}
		public string HDDM
		{
			get{ return m_HDDM; }
			set{ m_HDDM = value; }
		}
		public string YDFW
		{
			get{ return m_YDFW; }
			set{ m_YDFW = value; }
		}
		public double YDMJ
		{
			get{ return m_YDMJ; }
			set{ m_YDMJ = value; }
		}
		public string HDWZ
		{
			get{ return m_HDWZ; }
			set{ m_HDWZ = value; }
		}
		public string HDYT
		{
			get{ return m_HDYT; }
			set{ m_HDYT = value; }
		}
		public string ZHT
		{
			get{ return m_ZHT; }
			set{ m_ZHT = value; }
		}
		public string ZT
		{
			get{ return m_ZT; }
			set{ m_ZT = value; }
		}
		public string MJDW
		{
			get{ return m_MJDW; }
			set{ m_MJDW = value; }
		}
		public string YXTBM
		{
			get{ return m_YXTBM; }
			set{ m_YXTBM = value; }
		}
		public string YXTBSM
		{
			get{ return m_YXTBSM; }
			set{ m_YXTBSM = value; }
		}
		public long DCBSM
		{
			get{ return m_DCBSM; }
			set{ m_DCBSM = value; }
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
		public string DCYWH
		{
			get{ return m_DCYWH; }
			set{ m_DCYWH = value; }
		}
		public string YWH
		{
			get{ return m_YWH; }
			set{ m_YWH = value; }
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
		public int TXBZ
		{
			get{ return m_TXBZ; }
			set{ m_TXBZ = value; }
		}
		public string QLXZ
		{
			get{ return m_QLXZ; }
			set{ m_QLXZ = value; }
		}
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

		#endregion
		public bool IsEquals(clsZH obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.ZHDM != obj.ZHDM) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.YSDM != obj.YSDM) bolResult = false;
			if (this.ZHTZM != obj.ZHTZM) bolResult = false;
			if (this.XMMC != obj.XMMC) bolResult = false;
			if (this.XMXZ != obj.XMXZ) bolResult = false;
			if (this.YHZMJ != obj.YHZMJ) bolResult = false;
			if (this.ZHMJ != obj.ZHMJ) bolResult = false;
			if (this.DB != obj.DB) bolResult = false;
			if (this.ZHAX != obj.ZHAX) bolResult = false;
			if (this.YHLXA != obj.YHLXA) bolResult = false;
			if (this.YHLXB != obj.YHLXB) bolResult = false;
			if (this.YHWZSM != obj.YHWZSM) bolResult = false;
			if (this.HDMC != obj.HDMC) bolResult = false;
			if (this.HDDM != obj.HDDM) bolResult = false;
			if (this.YDFW != obj.YDFW) bolResult = false;
			if (this.YDMJ != obj.YDMJ) bolResult = false;
			if (this.HDWZ != obj.HDWZ) bolResult = false;
			if (this.HDYT != obj.HDYT) bolResult = false;
			if (this.ZHT != obj.ZHT) bolResult = false;
			if (this.ZT != obj.ZT) bolResult = false;
			if (this.MJDW != obj.MJDW) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.DCBSM != obj.DCBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.DCYWH != obj.DCYWH) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.TXBZ != obj.TXBZ) bolResult = false;
			if (this.QLXZ != obj.QLXZ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsZH obj)
		{
			this.BSM=obj.BSM;
			this.ZHDM=obj.ZHDM;
			this.BDCDYH=obj.BDCDYH;
			this.YSDM=obj.YSDM;
			this.ZHTZM=obj.ZHTZM;
			this.XMMC=obj.XMMC;
			this.XMXZ=obj.XMXZ;
			this.YHZMJ=obj.YHZMJ;
			this.ZHMJ=obj.ZHMJ;
			this.DB=obj.DB;
			this.ZHAX=obj.ZHAX;
			this.YHLXA=obj.YHLXA;
			this.YHLXB=obj.YHLXB;
			this.YHWZSM=obj.YHWZSM;
			this.HDMC=obj.HDMC;
			this.HDDM=obj.HDDM;
			this.YDFW=obj.YDFW;
			this.YDMJ=obj.YDMJ;
			this.HDWZ=obj.HDWZ;
			this.HDYT=obj.HDYT;
			this.ZHT=obj.ZHT;
			this.ZT=obj.ZT;
			this.MJDW=obj.MJDW;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.DCBSM=obj.DCBSM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.DCYWH=obj.DCYWH;
			this.YWH=obj.YWH;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.TXBZ=obj.TXBZ;
			this.QLXZ=obj.QLXZ;
		}

	}

	public class clsZHSet:EntityBaseSet
	{
		public clsZHSet()
		{
			m_TableName="BDCDJ.ZH";
			m_HisTableName="BDCDJ.ZH_LS";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsZHSet";
		}
		public static clsZHSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsZHSet clsSet = new clsZHSet(); //(clsZHSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsZHSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsZH obj = (clsZH)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("ZHDM")) datarow["ZHDM"] = obj.ZHDM;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("YSDM")) datarow["YSDM"] = obj.YSDM;
				if(datarow.Table.Columns.Contains("ZHTZM")) datarow["ZHTZM"] = obj.ZHTZM;
				if(datarow.Table.Columns.Contains("XMMC")) datarow["XMMC"] = obj.XMMC;
				if(datarow.Table.Columns.Contains("XMXZ")) datarow["XMXZ"] = obj.XMXZ;
				if(datarow.Table.Columns.Contains("YHZMJ")) datarow["YHZMJ"] = obj.YHZMJ;
				if(datarow.Table.Columns.Contains("ZHMJ")) datarow["ZHMJ"] = obj.ZHMJ;
				if(datarow.Table.Columns.Contains("DB")) datarow["DB"] = obj.DB;
				if(datarow.Table.Columns.Contains("ZHAX")) datarow["ZHAX"] = obj.ZHAX;
				if(datarow.Table.Columns.Contains("YHLXA")) datarow["YHLXA"] = obj.YHLXA;
				if(datarow.Table.Columns.Contains("YHLXB")) datarow["YHLXB"] = obj.YHLXB;
				if(datarow.Table.Columns.Contains("YHWZSM")) datarow["YHWZSM"] = obj.YHWZSM;
				if(datarow.Table.Columns.Contains("HDMC")) datarow["HDMC"] = obj.HDMC;
				if(datarow.Table.Columns.Contains("HDDM")) datarow["HDDM"] = obj.HDDM;
				if(datarow.Table.Columns.Contains("YDFW")) datarow["YDFW"] = obj.YDFW;
				if(datarow.Table.Columns.Contains("YDMJ")) datarow["YDMJ"] = obj.YDMJ;
				if(datarow.Table.Columns.Contains("HDWZ")) datarow["HDWZ"] = obj.HDWZ;
				if(datarow.Table.Columns.Contains("HDYT")) datarow["HDYT"] = obj.HDYT;
				if(datarow.Table.Columns.Contains("ZHT")) datarow["ZHT"] = obj.ZHT;
				if(datarow.Table.Columns.Contains("ZT")) datarow["ZT"] = obj.ZT;
				if(datarow.Table.Columns.Contains("MJDW")) datarow["MJDW"] = obj.MJDW;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("DCBSM")) datarow["DCBSM"] = obj.DCBSM;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("DCYWH")) datarow["DCYWH"] = obj.DCYWH;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("TXBZ")) datarow["TXBZ"] = obj.TXBZ;
				if(datarow.Table.Columns.Contains("QLXZ")) datarow["QLXZ"] = obj.QLXZ;
				if (m_HisTable==true && m_HisTableName!="")
				{
					if(datarow.Table.Columns.Contains("BG_BB")) datarow["BG_BB"]=obj.BG_BB;
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
			clsZH obj = null;
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
					obj = new clsZH();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="ZHDM")
								if (pRow.Table.Columns.Contains("ZHDM") && pRow["ZHDM"] != DBNull.Value) { obj.ZHDM = Convert.ToString(pRow["ZHDM"]); }
							if(strFldName.ToUpper()=="BDCDYH")
								if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
							if(strFldName.ToUpper()=="YSDM")
								if (pRow.Table.Columns.Contains("YSDM") && pRow["YSDM"] != DBNull.Value) { obj.YSDM = Convert.ToString(pRow["YSDM"]); }
							if(strFldName.ToUpper()=="ZHTZM")
								if (pRow.Table.Columns.Contains("ZHTZM") && pRow["ZHTZM"] != DBNull.Value) { obj.ZHTZM = Convert.ToString(pRow["ZHTZM"]); }
							if(strFldName.ToUpper()=="XMMC")
								if (pRow.Table.Columns.Contains("XMMC") && pRow["XMMC"] != DBNull.Value) { obj.XMMC = Convert.ToString(pRow["XMMC"]); }
							if(strFldName.ToUpper()=="XMXZ")
								if (pRow.Table.Columns.Contains("XMXZ") && pRow["XMXZ"] != DBNull.Value) { obj.XMXZ = Convert.ToString(pRow["XMXZ"]); }
							if(strFldName.ToUpper()=="YHZMJ")
								if (pRow.Table.Columns.Contains("YHZMJ") && pRow["YHZMJ"] != DBNull.Value) { obj.YHZMJ = Convert.ToDouble(pRow["YHZMJ"]); }
							if(strFldName.ToUpper()=="ZHMJ")
								if (pRow.Table.Columns.Contains("ZHMJ") && pRow["ZHMJ"] != DBNull.Value) { obj.ZHMJ = Convert.ToDouble(pRow["ZHMJ"]); }
							if(strFldName.ToUpper()=="DB")
								if (pRow.Table.Columns.Contains("DB") && pRow["DB"] != DBNull.Value) { obj.DB = Convert.ToString(pRow["DB"]); }
							if(strFldName.ToUpper()=="ZHAX")
								if (pRow.Table.Columns.Contains("ZHAX") && pRow["ZHAX"] != DBNull.Value) { obj.ZHAX = Convert.ToDouble(pRow["ZHAX"]); }
							if(strFldName.ToUpper()=="YHLXA")
								if (pRow.Table.Columns.Contains("YHLXA") && pRow["YHLXA"] != DBNull.Value) { obj.YHLXA = Convert.ToString(pRow["YHLXA"]); }
							if(strFldName.ToUpper()=="YHLXB")
								if (pRow.Table.Columns.Contains("YHLXB") && pRow["YHLXB"] != DBNull.Value) { obj.YHLXB = Convert.ToString(pRow["YHLXB"]); }
							if(strFldName.ToUpper()=="YHWZSM")
								if (pRow.Table.Columns.Contains("YHWZSM") && pRow["YHWZSM"] != DBNull.Value) { obj.YHWZSM = Convert.ToString(pRow["YHWZSM"]); }
							if(strFldName.ToUpper()=="HDMC")
								if (pRow.Table.Columns.Contains("HDMC") && pRow["HDMC"] != DBNull.Value) { obj.HDMC = Convert.ToString(pRow["HDMC"]); }
							if(strFldName.ToUpper()=="HDDM")
								if (pRow.Table.Columns.Contains("HDDM") && pRow["HDDM"] != DBNull.Value) { obj.HDDM = Convert.ToString(pRow["HDDM"]); }
							if(strFldName.ToUpper()=="YDFW")
								if (pRow.Table.Columns.Contains("YDFW") && pRow["YDFW"] != DBNull.Value) { obj.YDFW = Convert.ToString(pRow["YDFW"]); }
							if(strFldName.ToUpper()=="YDMJ")
								if (pRow.Table.Columns.Contains("YDMJ") && pRow["YDMJ"] != DBNull.Value) { obj.YDMJ = Convert.ToDouble(pRow["YDMJ"]); }
							if(strFldName.ToUpper()=="HDWZ")
								if (pRow.Table.Columns.Contains("HDWZ") && pRow["HDWZ"] != DBNull.Value) { obj.HDWZ = Convert.ToString(pRow["HDWZ"]); }
							if(strFldName.ToUpper()=="HDYT")
								if (pRow.Table.Columns.Contains("HDYT") && pRow["HDYT"] != DBNull.Value) { obj.HDYT = Convert.ToString(pRow["HDYT"]); }
							if(strFldName.ToUpper()=="ZHT")
								if (pRow.Table.Columns.Contains("ZHT") && pRow["ZHT"] != DBNull.Value) { obj.ZHT = Convert.ToString(pRow["ZHT"]); }
							if(strFldName.ToUpper()=="ZT")
								if (pRow.Table.Columns.Contains("ZT") && pRow["ZT"] != DBNull.Value) { obj.ZT = Convert.ToString(pRow["ZT"]); }
							if(strFldName.ToUpper()=="MJDW")
								if (pRow.Table.Columns.Contains("MJDW") && pRow["MJDW"] != DBNull.Value) { obj.MJDW = Convert.ToString(pRow["MJDW"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
							if(strFldName.ToUpper()=="DCBSM")
								if (pRow.Table.Columns.Contains("DCBSM") && pRow["DCBSM"] != DBNull.Value) { obj.DCBSM = Convert.ToInt64(pRow["DCBSM"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="DCYWH")
								if (pRow.Table.Columns.Contains("DCYWH") && pRow["DCYWH"] != DBNull.Value) { obj.DCYWH = Convert.ToString(pRow["DCYWH"]); }
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="TXBZ")
								if (pRow.Table.Columns.Contains("TXBZ") && pRow["TXBZ"] != DBNull.Value) { obj.TXBZ = Convert.ToInt16(pRow["TXBZ"]); }
							if(strFldName.ToUpper()=="QLXZ")
								if (pRow.Table.Columns.Contains("QLXZ") && pRow["QLXZ"] != DBNull.Value) { obj.QLXZ = Convert.ToString(pRow["QLXZ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("ZHDM") && pRow["ZHDM"] != DBNull.Value) { obj.ZHDM = Convert.ToString(pRow["ZHDM"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("YSDM") && pRow["YSDM"] != DBNull.Value) { obj.YSDM = Convert.ToString(pRow["YSDM"]); }
						if (pRow.Table.Columns.Contains("ZHTZM") && pRow["ZHTZM"] != DBNull.Value) { obj.ZHTZM = Convert.ToString(pRow["ZHTZM"]); }
						if (pRow.Table.Columns.Contains("XMMC") && pRow["XMMC"] != DBNull.Value) { obj.XMMC = Convert.ToString(pRow["XMMC"]); }
						if (pRow.Table.Columns.Contains("XMXZ") && pRow["XMXZ"] != DBNull.Value) { obj.XMXZ = Convert.ToString(pRow["XMXZ"]); }
						if (pRow.Table.Columns.Contains("YHZMJ") && pRow["YHZMJ"] != DBNull.Value) { obj.YHZMJ = Convert.ToDouble(pRow["YHZMJ"]); }
						if (pRow.Table.Columns.Contains("ZHMJ") && pRow["ZHMJ"] != DBNull.Value) { obj.ZHMJ = Convert.ToDouble(pRow["ZHMJ"]); }
						if (pRow.Table.Columns.Contains("DB") && pRow["DB"] != DBNull.Value) { obj.DB = Convert.ToString(pRow["DB"]); }
						if (pRow.Table.Columns.Contains("ZHAX") && pRow["ZHAX"] != DBNull.Value) { obj.ZHAX = Convert.ToDouble(pRow["ZHAX"]); }
						if (pRow.Table.Columns.Contains("YHLXA") && pRow["YHLXA"] != DBNull.Value) { obj.YHLXA = Convert.ToString(pRow["YHLXA"]); }
						if (pRow.Table.Columns.Contains("YHLXB") && pRow["YHLXB"] != DBNull.Value) { obj.YHLXB = Convert.ToString(pRow["YHLXB"]); }
						if (pRow.Table.Columns.Contains("YHWZSM") && pRow["YHWZSM"] != DBNull.Value) { obj.YHWZSM = Convert.ToString(pRow["YHWZSM"]); }
						if (pRow.Table.Columns.Contains("HDMC") && pRow["HDMC"] != DBNull.Value) { obj.HDMC = Convert.ToString(pRow["HDMC"]); }
						if (pRow.Table.Columns.Contains("HDDM") && pRow["HDDM"] != DBNull.Value) { obj.HDDM = Convert.ToString(pRow["HDDM"]); }
						if (pRow.Table.Columns.Contains("YDFW") && pRow["YDFW"] != DBNull.Value) { obj.YDFW = Convert.ToString(pRow["YDFW"]); }
						if (pRow.Table.Columns.Contains("YDMJ") && pRow["YDMJ"] != DBNull.Value) { obj.YDMJ = Convert.ToDouble(pRow["YDMJ"]); }
						if (pRow.Table.Columns.Contains("HDWZ") && pRow["HDWZ"] != DBNull.Value) { obj.HDWZ = Convert.ToString(pRow["HDWZ"]); }
						if (pRow.Table.Columns.Contains("HDYT") && pRow["HDYT"] != DBNull.Value) { obj.HDYT = Convert.ToString(pRow["HDYT"]); }
						if (pRow.Table.Columns.Contains("ZHT") && pRow["ZHT"] != DBNull.Value) { obj.ZHT = Convert.ToString(pRow["ZHT"]); }
						if (pRow.Table.Columns.Contains("ZT") && pRow["ZT"] != DBNull.Value) { obj.ZT = Convert.ToString(pRow["ZT"]); }
						if (pRow.Table.Columns.Contains("MJDW") && pRow["MJDW"] != DBNull.Value) { obj.MJDW = Convert.ToString(pRow["MJDW"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("DCBSM") && pRow["DCBSM"] != DBNull.Value) { obj.DCBSM = Convert.ToInt64(pRow["DCBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("DCYWH") && pRow["DCYWH"] != DBNull.Value) { obj.DCYWH = Convert.ToString(pRow["DCYWH"]); }
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("TXBZ") && pRow["TXBZ"] != DBNull.Value) { obj.TXBZ = Convert.ToInt16(pRow["TXBZ"]); }
						if (pRow.Table.Columns.Contains("QLXZ") && pRow["QLXZ"] != DBNull.Value) { obj.QLXZ = Convert.ToString(pRow["QLXZ"]); }
					}
					if (m_HisTable==true && m_HisTableName!="")
					{
						if (pRow.Table.Columns.Contains("BG_BB") && pRow["BG_BB"] != DBNull.Value) { obj.BG_BB =  Convert.ToInt64(pRow["BG_BB"]); }
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
