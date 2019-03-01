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

	public class Fld_TDSYQ
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YSDM="YSDM";
		public const string ZDDM="ZDDM";
		public const string BDCDYH="BDCDYH";
		public const string YWH="YWH";
		public const string QLLX="QLLX";
		public const string DJLX="DJLX";
		public const string DJYY="DJYY";
		public const string MJDW="MJDW";
		public const string NYDMJ="NYDMJ";
		public const string GDMJ="GDMJ";
		public const string LDMJ="LDMJ";
		public const string CDMJ="CDMJ";
		public const string QTNYDMJ="QTNYDMJ";
		public const string JSYDMJ="JSYDMJ";
		public const string WLYDMJ="WLYDMJ";
		public const string BDCQZH="BDCQZH";
		public const string DJJG="DJJG";
		public const string DBR="DBR";
		public const string DJSJ="DJSJ";
		public const string FJ="FJ";
		public const string QSZT="QSZT";
		public const string ZXYWH="ZXYWH";
		public const string ZXSJ="ZXSJ";
		public const string ZXDBR="ZXDBR";
		public const string ZXYY="ZXYY";
		public const string ZXFJ="ZXFJ";
		public const string SHBSM="SHBSM";
		public const string ZXSHBSM="ZXSHBSM";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string DYBSM="DYBSM";
		public const string BZ_LAND_ID="BZ_LAND_ID";
		public const string BZ_GARDENPLOT="BZ_GARDENPLOT";
		public const string BZ_DENIZENLAND="BZ_DENIZENLAND";
		public const string BZ_OTHERBUILDLAND="BZ_OTHERBUILDLAND";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsTDSYQ:IEntity
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
		private string m_YSDM;
		private string m_ZDDM;
		private string m_BDCDYH;
		private string m_YWH;
		private string m_QLLX;
		private string m_DJLX;
		private string m_DJYY;
		private string m_MJDW;
		private double m_NYDMJ;
		private double m_GDMJ;
		private double m_LDMJ;
		private double m_CDMJ;
		private double m_QTNYDMJ;
		private double m_JSYDMJ;
		private double m_WLYDMJ;
		private string m_BDCQZH;
		private string m_DJJG;
		private string m_DBR;
		private DateTime m_DJSJ;
		private string m_FJ;
		private string m_QSZT;
		private string m_ZXYWH;
		private DateTime m_ZXSJ;
		private string m_ZXDBR;
		private string m_ZXYY;
		private string m_ZXFJ;
		private long m_SHBSM;
		private long m_ZXSHBSM;
		private string m_YXTBM;
		private string m_YXTBSM;
		private long m_QXDM;
		private long m_REV_;
		private DateTime m_GXSJ;
		private string m_BZ;
		private string m_DYBSM;
		private string m_BZ_LAND_ID;
		private string m_BZ_GARDENPLOT;
		private string m_BZ_DENIZENLAND;
		private string m_BZ_OTHERBUILDLAND;
		private long m_BG_BB;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public string YSDM
		{
			get{ return m_YSDM; }
			set{ m_YSDM = value; }
		}
		public string ZDDM
		{
			get{ return m_ZDDM; }
			set{ m_ZDDM = value; }
		}
		public string BDCDYH
		{
			get{ return m_BDCDYH; }
			set{ m_BDCDYH = value; }
		}
		public string YWH
		{
			get{ return m_YWH; }
			set{ m_YWH = value; }
		}
		public string QLLX
		{
			get{ return m_QLLX; }
			set{ m_QLLX = value; }
		}
		public string DJLX
		{
			get{ return m_DJLX; }
			set{ m_DJLX = value; }
		}
		public string DJYY
		{
			get{ return m_DJYY; }
			set{ m_DJYY = value; }
		}
		public string MJDW
		{
			get{ return m_MJDW; }
			set{ m_MJDW = value; }
		}
		public double NYDMJ
		{
			get{ return m_NYDMJ; }
			set{ m_NYDMJ = value; }
		}
		public double GDMJ
		{
			get{ return m_GDMJ; }
			set{ m_GDMJ = value; }
		}
		public double LDMJ
		{
			get{ return m_LDMJ; }
			set{ m_LDMJ = value; }
		}
		public double CDMJ
		{
			get{ return m_CDMJ; }
			set{ m_CDMJ = value; }
		}
		public double QTNYDMJ
		{
			get{ return m_QTNYDMJ; }
			set{ m_QTNYDMJ = value; }
		}
		public double JSYDMJ
		{
			get{ return m_JSYDMJ; }
			set{ m_JSYDMJ = value; }
		}
		public double WLYDMJ
		{
			get{ return m_WLYDMJ; }
			set{ m_WLYDMJ = value; }
		}
		public string BDCQZH
		{
			get{ return m_BDCQZH; }
			set{ m_BDCQZH = value; }
		}
		public string DJJG
		{
			get{ return m_DJJG; }
			set{ m_DJJG = value; }
		}
		public string DBR
		{
			get{ return m_DBR; }
			set{ m_DBR = value; }
		}
		public DateTime DJSJ
		{
			get{ return m_DJSJ; }
			set{ m_DJSJ = value; }
		}
		public string FJ
		{
			get{ return m_FJ; }
			set{ m_FJ = value; }
		}
		public string QSZT
		{
			get{ return m_QSZT; }
			set{ m_QSZT = value; }
		}
		public string ZXYWH
		{
			get{ return m_ZXYWH; }
			set{ m_ZXYWH = value; }
		}
		public DateTime ZXSJ
		{
			get{ return m_ZXSJ; }
			set{ m_ZXSJ = value; }
		}
		public string ZXDBR
		{
			get{ return m_ZXDBR; }
			set{ m_ZXDBR = value; }
		}
		public string ZXYY
		{
			get{ return m_ZXYY; }
			set{ m_ZXYY = value; }
		}
		public string ZXFJ
		{
			get{ return m_ZXFJ; }
			set{ m_ZXFJ = value; }
		}
		public long SHBSM
		{
			get{ return m_SHBSM; }
			set{ m_SHBSM = value; }
		}
		public long ZXSHBSM
		{
			get{ return m_ZXSHBSM; }
			set{ m_ZXSHBSM = value; }
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
		public string DYBSM
		{
			get{ return m_DYBSM; }
			set{ m_DYBSM = value; }
		}
		public string BZ_LAND_ID
		{
			get{ return m_BZ_LAND_ID; }
			set{ m_BZ_LAND_ID = value; }
		}
		public string BZ_GARDENPLOT
		{
			get{ return m_BZ_GARDENPLOT; }
			set{ m_BZ_GARDENPLOT = value; }
		}
		public string BZ_DENIZENLAND
		{
			get{ return m_BZ_DENIZENLAND; }
			set{ m_BZ_DENIZENLAND = value; }
		}
		public string BZ_OTHERBUILDLAND
		{
			get{ return m_BZ_OTHERBUILDLAND; }
			set{ m_BZ_OTHERBUILDLAND = value; }
		}
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

		#endregion
		public bool IsEquals(clsTDSYQ obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YSDM != obj.YSDM) bolResult = false;
			if (this.ZDDM != obj.ZDDM) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.QLLX != obj.QLLX) bolResult = false;
			if (this.DJLX != obj.DJLX) bolResult = false;
			if (this.DJYY != obj.DJYY) bolResult = false;
			if (this.MJDW != obj.MJDW) bolResult = false;
			if (this.NYDMJ != obj.NYDMJ) bolResult = false;
			if (this.GDMJ != obj.GDMJ) bolResult = false;
			if (this.LDMJ != obj.LDMJ) bolResult = false;
			if (this.CDMJ != obj.CDMJ) bolResult = false;
			if (this.QTNYDMJ != obj.QTNYDMJ) bolResult = false;
			if (this.JSYDMJ != obj.JSYDMJ) bolResult = false;
			if (this.WLYDMJ != obj.WLYDMJ) bolResult = false;
			if (this.BDCQZH != obj.BDCQZH) bolResult = false;
			if (this.DJJG != obj.DJJG) bolResult = false;
			if (this.DBR != obj.DBR) bolResult = false;
			if (this.DJSJ != obj.DJSJ) bolResult = false;
			if (this.FJ != obj.FJ) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.ZXYWH != obj.ZXYWH) bolResult = false;
			if (this.ZXSJ != obj.ZXSJ) bolResult = false;
			if (this.ZXDBR != obj.ZXDBR) bolResult = false;
			if (this.ZXYY != obj.ZXYY) bolResult = false;
			if (this.ZXFJ != obj.ZXFJ) bolResult = false;
			if (this.SHBSM != obj.SHBSM) bolResult = false;
			if (this.ZXSHBSM != obj.ZXSHBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.DYBSM != obj.DYBSM) bolResult = false;
			if (this.BZ_LAND_ID != obj.BZ_LAND_ID) bolResult = false;
			if (this.BZ_GARDENPLOT != obj.BZ_GARDENPLOT) bolResult = false;
			if (this.BZ_DENIZENLAND != obj.BZ_DENIZENLAND) bolResult = false;
			if (this.BZ_OTHERBUILDLAND != obj.BZ_OTHERBUILDLAND) bolResult = false;
			return bolResult;
		}

		public void Colne(clsTDSYQ obj)
		{
			this.BSM=obj.BSM;
			this.YSDM=obj.YSDM;
			this.ZDDM=obj.ZDDM;
			this.BDCDYH=obj.BDCDYH;
			this.YWH=obj.YWH;
			this.QLLX=obj.QLLX;
			this.DJLX=obj.DJLX;
			this.DJYY=obj.DJYY;
			this.MJDW=obj.MJDW;
			this.NYDMJ=obj.NYDMJ;
			this.GDMJ=obj.GDMJ;
			this.LDMJ=obj.LDMJ;
			this.CDMJ=obj.CDMJ;
			this.QTNYDMJ=obj.QTNYDMJ;
			this.JSYDMJ=obj.JSYDMJ;
			this.WLYDMJ=obj.WLYDMJ;
			this.BDCQZH=obj.BDCQZH;
			this.DJJG=obj.DJJG;
			this.DBR=obj.DBR;
			this.DJSJ=obj.DJSJ;
			this.FJ=obj.FJ;
			this.QSZT=obj.QSZT;
			this.ZXYWH=obj.ZXYWH;
			this.ZXSJ=obj.ZXSJ;
			this.ZXDBR=obj.ZXDBR;
			this.ZXYY=obj.ZXYY;
			this.ZXFJ=obj.ZXFJ;
			this.SHBSM=obj.SHBSM;
			this.ZXSHBSM=obj.ZXSHBSM;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.DYBSM=obj.DYBSM;
			this.BZ_LAND_ID=obj.BZ_LAND_ID;
			this.BZ_GARDENPLOT=obj.BZ_GARDENPLOT;
			this.BZ_DENIZENLAND=obj.BZ_DENIZENLAND;
			this.BZ_OTHERBUILDLAND=obj.BZ_OTHERBUILDLAND;
		}

	}

	public class clsTDSYQSet:EntityBaseSet
	{
		public clsTDSYQSet()
		{
			m_TableName="BDCDJ.TDSYQ";
			m_HisTableName="BDCDJ.TDSYQ_LS";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsTDSYQSet";
		}
		public static clsTDSYQSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsTDSYQSet clsSet = new clsTDSYQSet(); //(clsTDSYQSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsTDSYQSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsTDSYQ obj = (clsTDSYQ)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YSDM")) datarow["YSDM"] = obj.YSDM;
				if(datarow.Table.Columns.Contains("ZDDM")) datarow["ZDDM"] = obj.ZDDM;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("QLLX")) datarow["QLLX"] = obj.QLLX;
				if(datarow.Table.Columns.Contains("DJLX")) datarow["DJLX"] = obj.DJLX;
				if(datarow.Table.Columns.Contains("DJYY")) datarow["DJYY"] = obj.DJYY;
				if(datarow.Table.Columns.Contains("MJDW")) datarow["MJDW"] = obj.MJDW;
				if(datarow.Table.Columns.Contains("NYDMJ")) datarow["NYDMJ"] = obj.NYDMJ;
				if(datarow.Table.Columns.Contains("GDMJ")) datarow["GDMJ"] = obj.GDMJ;
				if(datarow.Table.Columns.Contains("LDMJ")) datarow["LDMJ"] = obj.LDMJ;
				if(datarow.Table.Columns.Contains("CDMJ")) datarow["CDMJ"] = obj.CDMJ;
				if(datarow.Table.Columns.Contains("QTNYDMJ")) datarow["QTNYDMJ"] = obj.QTNYDMJ;
				if(datarow.Table.Columns.Contains("JSYDMJ")) datarow["JSYDMJ"] = obj.JSYDMJ;
				if(datarow.Table.Columns.Contains("WLYDMJ")) datarow["WLYDMJ"] = obj.WLYDMJ;
				if(datarow.Table.Columns.Contains("BDCQZH")) datarow["BDCQZH"] = obj.BDCQZH;
				if(datarow.Table.Columns.Contains("DJJG")) datarow["DJJG"] = obj.DJJG;
				if(datarow.Table.Columns.Contains("DBR")) datarow["DBR"] = obj.DBR;
				if (obj.DJSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("DJSJ")) datarow["DJSJ"] = obj.DJSJ;
				}
				if(datarow.Table.Columns.Contains("FJ")) datarow["FJ"] = obj.FJ;
				if(datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
				if(datarow.Table.Columns.Contains("ZXYWH")) datarow["ZXYWH"] = obj.ZXYWH;
				if (obj.ZXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("ZXSJ")) datarow["ZXSJ"] = obj.ZXSJ;
				}
				if(datarow.Table.Columns.Contains("ZXDBR")) datarow["ZXDBR"] = obj.ZXDBR;
				if(datarow.Table.Columns.Contains("ZXYY")) datarow["ZXYY"] = obj.ZXYY;
				if(datarow.Table.Columns.Contains("ZXFJ")) datarow["ZXFJ"] = obj.ZXFJ;
				if(datarow.Table.Columns.Contains("SHBSM")) datarow["SHBSM"] = obj.SHBSM;
				if(datarow.Table.Columns.Contains("ZXSHBSM")) datarow["ZXSHBSM"] = obj.ZXSHBSM;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("DYBSM")) datarow["DYBSM"] = obj.DYBSM;
				if(datarow.Table.Columns.Contains("BZ_LAND_ID")) datarow["BZ_LAND_ID"] = obj.BZ_LAND_ID;
				if(datarow.Table.Columns.Contains("BZ_GARDENPLOT")) datarow["BZ_GARDENPLOT"] = obj.BZ_GARDENPLOT;
				if(datarow.Table.Columns.Contains("BZ_DENIZENLAND")) datarow["BZ_DENIZENLAND"] = obj.BZ_DENIZENLAND;
				if(datarow.Table.Columns.Contains("BZ_OTHERBUILDLAND")) datarow["BZ_OTHERBUILDLAND"] = obj.BZ_OTHERBUILDLAND;
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
			clsTDSYQ obj = null;
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
					obj = new clsTDSYQ();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YSDM")
								if (pRow.Table.Columns.Contains("YSDM") && pRow["YSDM"] != DBNull.Value) { obj.YSDM = Convert.ToString(pRow["YSDM"]); }
							if(strFldName.ToUpper()=="ZDDM")
								if (pRow.Table.Columns.Contains("ZDDM") && pRow["ZDDM"] != DBNull.Value) { obj.ZDDM = Convert.ToString(pRow["ZDDM"]); }
							if(strFldName.ToUpper()=="BDCDYH")
								if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="QLLX")
								if (pRow.Table.Columns.Contains("QLLX") && pRow["QLLX"] != DBNull.Value) { obj.QLLX = Convert.ToString(pRow["QLLX"]); }
							if(strFldName.ToUpper()=="DJLX")
								if (pRow.Table.Columns.Contains("DJLX") && pRow["DJLX"] != DBNull.Value) { obj.DJLX = Convert.ToString(pRow["DJLX"]); }
							if(strFldName.ToUpper()=="DJYY")
								if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
							if(strFldName.ToUpper()=="MJDW")
								if (pRow.Table.Columns.Contains("MJDW") && pRow["MJDW"] != DBNull.Value) { obj.MJDW = Convert.ToString(pRow["MJDW"]); }
							if(strFldName.ToUpper()=="NYDMJ")
								if (pRow.Table.Columns.Contains("NYDMJ") && pRow["NYDMJ"] != DBNull.Value) { obj.NYDMJ = Convert.ToDouble(pRow["NYDMJ"]); }
							if(strFldName.ToUpper()=="GDMJ")
								if (pRow.Table.Columns.Contains("GDMJ") && pRow["GDMJ"] != DBNull.Value) { obj.GDMJ = Convert.ToDouble(pRow["GDMJ"]); }
							if(strFldName.ToUpper()=="LDMJ")
								if (pRow.Table.Columns.Contains("LDMJ") && pRow["LDMJ"] != DBNull.Value) { obj.LDMJ = Convert.ToDouble(pRow["LDMJ"]); }
							if(strFldName.ToUpper()=="CDMJ")
								if (pRow.Table.Columns.Contains("CDMJ") && pRow["CDMJ"] != DBNull.Value) { obj.CDMJ = Convert.ToDouble(pRow["CDMJ"]); }
							if(strFldName.ToUpper()=="QTNYDMJ")
								if (pRow.Table.Columns.Contains("QTNYDMJ") && pRow["QTNYDMJ"] != DBNull.Value) { obj.QTNYDMJ = Convert.ToDouble(pRow["QTNYDMJ"]); }
							if(strFldName.ToUpper()=="JSYDMJ")
								if (pRow.Table.Columns.Contains("JSYDMJ") && pRow["JSYDMJ"] != DBNull.Value) { obj.JSYDMJ = Convert.ToDouble(pRow["JSYDMJ"]); }
							if(strFldName.ToUpper()=="WLYDMJ")
								if (pRow.Table.Columns.Contains("WLYDMJ") && pRow["WLYDMJ"] != DBNull.Value) { obj.WLYDMJ = Convert.ToDouble(pRow["WLYDMJ"]); }
							if(strFldName.ToUpper()=="BDCQZH")
								if (pRow.Table.Columns.Contains("BDCQZH") && pRow["BDCQZH"] != DBNull.Value) { obj.BDCQZH = Convert.ToString(pRow["BDCQZH"]); }
							if(strFldName.ToUpper()=="DJJG")
								if (pRow.Table.Columns.Contains("DJJG") && pRow["DJJG"] != DBNull.Value) { obj.DJJG = Convert.ToString(pRow["DJJG"]); }
							if(strFldName.ToUpper()=="DBR")
								if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
							if(strFldName.ToUpper()=="DJSJ")
								if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
							if(strFldName.ToUpper()=="FJ")
								if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
							if(strFldName.ToUpper()=="QSZT")
								if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
							if(strFldName.ToUpper()=="ZXYWH")
								if (pRow.Table.Columns.Contains("ZXYWH") && pRow["ZXYWH"] != DBNull.Value) { obj.ZXYWH = Convert.ToString(pRow["ZXYWH"]); }
							if(strFldName.ToUpper()=="ZXSJ")
								if (pRow.Table.Columns.Contains("ZXSJ") && pRow["ZXSJ"] != DBNull.Value) { obj.ZXSJ = Convert.ToDateTime(pRow["ZXSJ"]); }
							if(strFldName.ToUpper()=="ZXDBR")
								if (pRow.Table.Columns.Contains("ZXDBR") && pRow["ZXDBR"] != DBNull.Value) { obj.ZXDBR = Convert.ToString(pRow["ZXDBR"]); }
							if(strFldName.ToUpper()=="ZXYY")
								if (pRow.Table.Columns.Contains("ZXYY") && pRow["ZXYY"] != DBNull.Value) { obj.ZXYY = Convert.ToString(pRow["ZXYY"]); }
							if(strFldName.ToUpper()=="ZXFJ")
								if (pRow.Table.Columns.Contains("ZXFJ") && pRow["ZXFJ"] != DBNull.Value) { obj.ZXFJ = Convert.ToString(pRow["ZXFJ"]); }
							if(strFldName.ToUpper()=="SHBSM")
								if (pRow.Table.Columns.Contains("SHBSM") && pRow["SHBSM"] != DBNull.Value) { obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]); }
							if(strFldName.ToUpper()=="ZXSHBSM")
								if (pRow.Table.Columns.Contains("ZXSHBSM") && pRow["ZXSHBSM"] != DBNull.Value) { obj.ZXSHBSM = Convert.ToInt64(pRow["ZXSHBSM"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="DYBSM")
								if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToString(pRow["DYBSM"]); }
							if(strFldName.ToUpper()=="BZ_LAND_ID")
								if (pRow.Table.Columns.Contains("BZ_LAND_ID") && pRow["BZ_LAND_ID"] != DBNull.Value) { obj.BZ_LAND_ID = Convert.ToString(pRow["BZ_LAND_ID"]); }
							if(strFldName.ToUpper()=="BZ_GARDENPLOT")
								if (pRow.Table.Columns.Contains("BZ_GARDENPLOT") && pRow["BZ_GARDENPLOT"] != DBNull.Value) { obj.BZ_GARDENPLOT = Convert.ToString(pRow["BZ_GARDENPLOT"]); }
							if(strFldName.ToUpper()=="BZ_DENIZENLAND")
								if (pRow.Table.Columns.Contains("BZ_DENIZENLAND") && pRow["BZ_DENIZENLAND"] != DBNull.Value) { obj.BZ_DENIZENLAND = Convert.ToString(pRow["BZ_DENIZENLAND"]); }
							if(strFldName.ToUpper()=="BZ_OTHERBUILDLAND")
								if (pRow.Table.Columns.Contains("BZ_OTHERBUILDLAND") && pRow["BZ_OTHERBUILDLAND"] != DBNull.Value) { obj.BZ_OTHERBUILDLAND = Convert.ToString(pRow["BZ_OTHERBUILDLAND"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YSDM") && pRow["YSDM"] != DBNull.Value) { obj.YSDM = Convert.ToString(pRow["YSDM"]); }
						if (pRow.Table.Columns.Contains("ZDDM") && pRow["ZDDM"] != DBNull.Value) { obj.ZDDM = Convert.ToString(pRow["ZDDM"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("QLLX") && pRow["QLLX"] != DBNull.Value) { obj.QLLX = Convert.ToString(pRow["QLLX"]); }
						if (pRow.Table.Columns.Contains("DJLX") && pRow["DJLX"] != DBNull.Value) { obj.DJLX = Convert.ToString(pRow["DJLX"]); }
						if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
						if (pRow.Table.Columns.Contains("MJDW") && pRow["MJDW"] != DBNull.Value) { obj.MJDW = Convert.ToString(pRow["MJDW"]); }
						if (pRow.Table.Columns.Contains("NYDMJ") && pRow["NYDMJ"] != DBNull.Value) { obj.NYDMJ = Convert.ToDouble(pRow["NYDMJ"]); }
						if (pRow.Table.Columns.Contains("GDMJ") && pRow["GDMJ"] != DBNull.Value) { obj.GDMJ = Convert.ToDouble(pRow["GDMJ"]); }
						if (pRow.Table.Columns.Contains("LDMJ") && pRow["LDMJ"] != DBNull.Value) { obj.LDMJ = Convert.ToDouble(pRow["LDMJ"]); }
						if (pRow.Table.Columns.Contains("CDMJ") && pRow["CDMJ"] != DBNull.Value) { obj.CDMJ = Convert.ToDouble(pRow["CDMJ"]); }
						if (pRow.Table.Columns.Contains("QTNYDMJ") && pRow["QTNYDMJ"] != DBNull.Value) { obj.QTNYDMJ = Convert.ToDouble(pRow["QTNYDMJ"]); }
						if (pRow.Table.Columns.Contains("JSYDMJ") && pRow["JSYDMJ"] != DBNull.Value) { obj.JSYDMJ = Convert.ToDouble(pRow["JSYDMJ"]); }
						if (pRow.Table.Columns.Contains("WLYDMJ") && pRow["WLYDMJ"] != DBNull.Value) { obj.WLYDMJ = Convert.ToDouble(pRow["WLYDMJ"]); }
						if (pRow.Table.Columns.Contains("BDCQZH") && pRow["BDCQZH"] != DBNull.Value) { obj.BDCQZH = Convert.ToString(pRow["BDCQZH"]); }
						if (pRow.Table.Columns.Contains("DJJG") && pRow["DJJG"] != DBNull.Value) { obj.DJJG = Convert.ToString(pRow["DJJG"]); }
						if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
						if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
						if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
						if (pRow.Table.Columns.Contains("ZXYWH") && pRow["ZXYWH"] != DBNull.Value) { obj.ZXYWH = Convert.ToString(pRow["ZXYWH"]); }
						if (pRow.Table.Columns.Contains("ZXSJ") && pRow["ZXSJ"] != DBNull.Value) { obj.ZXSJ = Convert.ToDateTime(pRow["ZXSJ"]); }
						if (pRow.Table.Columns.Contains("ZXDBR") && pRow["ZXDBR"] != DBNull.Value) { obj.ZXDBR = Convert.ToString(pRow["ZXDBR"]); }
						if (pRow.Table.Columns.Contains("ZXYY") && pRow["ZXYY"] != DBNull.Value) { obj.ZXYY = Convert.ToString(pRow["ZXYY"]); }
						if (pRow.Table.Columns.Contains("ZXFJ") && pRow["ZXFJ"] != DBNull.Value) { obj.ZXFJ = Convert.ToString(pRow["ZXFJ"]); }
						if (pRow.Table.Columns.Contains("SHBSM") && pRow["SHBSM"] != DBNull.Value) { obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]); }
						if (pRow.Table.Columns.Contains("ZXSHBSM") && pRow["ZXSHBSM"] != DBNull.Value) { obj.ZXSHBSM = Convert.ToInt64(pRow["ZXSHBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToString(pRow["DYBSM"]); }
						if (pRow.Table.Columns.Contains("BZ_LAND_ID") && pRow["BZ_LAND_ID"] != DBNull.Value) { obj.BZ_LAND_ID = Convert.ToString(pRow["BZ_LAND_ID"]); }
						if (pRow.Table.Columns.Contains("BZ_GARDENPLOT") && pRow["BZ_GARDENPLOT"] != DBNull.Value) { obj.BZ_GARDENPLOT = Convert.ToString(pRow["BZ_GARDENPLOT"]); }
						if (pRow.Table.Columns.Contains("BZ_DENIZENLAND") && pRow["BZ_DENIZENLAND"] != DBNull.Value) { obj.BZ_DENIZENLAND = Convert.ToString(pRow["BZ_DENIZENLAND"]); }
						if (pRow.Table.Columns.Contains("BZ_OTHERBUILDLAND") && pRow["BZ_OTHERBUILDLAND"] != DBNull.Value) { obj.BZ_OTHERBUILDLAND = Convert.ToString(pRow["BZ_OTHERBUILDLAND"]); }
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
