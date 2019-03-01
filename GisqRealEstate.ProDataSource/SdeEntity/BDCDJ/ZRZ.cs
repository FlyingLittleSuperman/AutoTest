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

	public class Fld_ZRZ
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string ZRZH="ZRZH";
		public const string XMMC="XMMC";
		public const string JZWMC="JZWMC";
		public const string JGRQ="JGRQ";
		public const string JZWGD="JZWGD";
		public const string ZZDMJ="ZZDMJ";
		public const string ZYDMJ="ZYDMJ";
		public const string YCJZMJ="YCJZMJ";
		public const string SCJZMJ="SCJZMJ";
		public const string ZCS="ZCS";
		public const string DSCS="DSCS";
		public const string DXCS="DXCS";
		public const string DXSD="DXSD";
		public const string GHYT="GHYT";
		public const string YXTGHYTMC="YXTGHYTMC";
		public const string FWYT="FWYT";
		public const string YXTFWYTMC="YXTFWYTMC";
		public const string FWJG="FWJG";
		public const string ZTS="ZTS";
		public const string JZWJBYT="JZWJBYT";
		public const string BZ="BZ";
		public const string XQMC="XQMC";
		public const string ZL="ZL";
		public const string ZXDZBX="ZXDZBX";
		public const string ZXDZBY="ZXDZBY";
		public const string TFH="TFH";
		public const string QH="QH";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string DCBSM="DCBSM";
		public const string QXDM="QXDM";
		public const string BZ_BUILDID="BZ_BUILDID";
		public const string BZ_PROJECT_ID="BZ_PROJECT_ID";
		public const string REV_="REV_";
		public const string DCYWH="DCYWH";
		public const string BDCDYH="BDCDYH";
		public const string ZDDM="ZDDM";
		public const string ZDSHIYQBSM="ZDSHIYQBSM";
		public const string DCZDSHIYQBSM="DCZDSHIYQBSM";
		public const string GXSJ="GXSJ";
		public const string BZ_SURVEYNO="BZ_SURVEYNO";
		public const string YXTBSM1="YXTBSM1";
		public const string BZ_FCFHTID="BZ_FCFHTID";
		public const string BZ_ZRZCODE="BZ_ZRZCODE";
		public const string BZ_LPMID="BZ_LPMID";
		public const string BZ_QSZT="BZ_QSZT";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsZRZ:IEntity
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
		private string m_ZRZH;
		private string m_XMMC;
		private string m_JZWMC;
		private DateTime m_JGRQ;
		private double m_JZWGD;
		private double m_ZZDMJ;
		private double m_ZYDMJ;
		private double m_YCJZMJ;
		private double m_SCJZMJ;
		private long m_ZCS;
		private long m_DSCS;
		private long m_DXCS;
		private double m_DXSD;
		private string m_GHYT;
		private string m_YXTGHYTMC;
		private string m_FWYT;
		private string m_YXTFWYTMC;
		private string m_FWJG;
		private long m_ZTS;
		private string m_JZWJBYT;
		private string m_BZ;
		private string m_XQMC;
		private string m_ZL;
		private double m_ZXDZBX;
		private double m_ZXDZBY;
		private string m_TFH;
		private string m_QH;
		private string m_YXTBM;
		private string m_YXTBSM;
		private long m_DCBSM;
		private long m_QXDM;
		private long m_REV_;
		private string m_DCYWH;
		private string m_BDCDYH;
		private string m_ZDDM;
		private long m_ZDSHIYQBSM;
		private long m_DCZDSHIYQBSM;
		private DateTime m_GXSJ;
		private long m_BG_BB;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public string ZRZH
		{
			get{ return m_ZRZH; }
			set{ m_ZRZH = value; }
		}
		public string XMMC
		{
			get{ return m_XMMC; }
			set{ m_XMMC = value; }
		}
		public string JZWMC
		{
			get{ return m_JZWMC; }
			set{ m_JZWMC = value; }
		}
		public DateTime JGRQ
		{
			get{ return m_JGRQ; }
			set{ m_JGRQ = value; }
		}
		public double JZWGD
		{
			get{ return m_JZWGD; }
			set{ m_JZWGD = value; }
		}
		public double ZZDMJ
		{
			get{ return m_ZZDMJ; }
			set{ m_ZZDMJ = value; }
		}
		public double ZYDMJ
		{
			get{ return m_ZYDMJ; }
			set{ m_ZYDMJ = value; }
		}
		public double YCJZMJ
		{
			get{ return m_YCJZMJ; }
			set{ m_YCJZMJ = value; }
		}
		public double SCJZMJ
		{
			get{ return m_SCJZMJ; }
			set{ m_SCJZMJ = value; }
		}
		public long ZCS
		{
			get{ return m_ZCS; }
			set{ m_ZCS = value; }
		}
		public long DSCS
		{
			get{ return m_DSCS; }
			set{ m_DSCS = value; }
		}
		public long DXCS
		{
			get{ return m_DXCS; }
			set{ m_DXCS = value; }
		}
		public double DXSD
		{
			get{ return m_DXSD; }
			set{ m_DXSD = value; }
		}
		public string GHYT
		{
			get{ return m_GHYT; }
			set{ m_GHYT = value; }
		}
		public string YXTGHYTMC
		{
			get{ return m_YXTGHYTMC; }
			set{ m_YXTGHYTMC = value; }
		}
		public string FWYT
		{
			get{ return m_FWYT; }
			set{ m_FWYT = value; }
		}
		public string YXTFWYTMC
		{
			get{ return m_YXTFWYTMC; }
			set{ m_YXTFWYTMC = value; }
		}
		public string FWJG
		{
			get{ return m_FWJG; }
			set{ m_FWJG = value; }
		}
		public long ZTS
		{
			get{ return m_ZTS; }
			set{ m_ZTS = value; }
		}
		public string JZWJBYT
		{
			get{ return m_JZWJBYT; }
			set{ m_JZWJBYT = value; }
		}
		public string BZ
		{
			get{ return m_BZ; }
			set{ m_BZ = value; }
		}
		public string XQMC
		{
			get{ return m_XQMC; }
			set{ m_XQMC = value; }
		}
		public string ZL
		{
			get{ return m_ZL; }
			set{ m_ZL = value; }
		}
		public double ZXDZBX
		{
			get{ return m_ZXDZBX; }
			set{ m_ZXDZBX = value; }
		}
		public double ZXDZBY
		{
			get{ return m_ZXDZBY; }
			set{ m_ZXDZBY = value; }
		}
		public string TFH
		{
			get{ return m_TFH; }
			set{ m_TFH = value; }
		}
		public string QH
		{
			get{ return m_QH; }
			set{ m_QH = value; }
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
		public string BDCDYH
		{
			get{ return m_BDCDYH; }
			set{ m_BDCDYH = value; }
		}
		public string ZDDM
		{
			get{ return m_ZDDM; }
			set{ m_ZDDM = value; }
		}
		public long ZDSHIYQBSM
		{
			get{ return m_ZDSHIYQBSM; }
			set{ m_ZDSHIYQBSM = value; }
		}
		public long DCZDSHIYQBSM
		{
			get{ return m_DCZDSHIYQBSM; }
			set{ m_DCZDSHIYQBSM = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

		#endregion
		public bool IsEquals(clsZRZ obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.ZRZH != obj.ZRZH) bolResult = false;
			if (this.XMMC != obj.XMMC) bolResult = false;
			if (this.JZWMC != obj.JZWMC) bolResult = false;
			if (this.JGRQ != obj.JGRQ) bolResult = false;
			if (this.JZWGD != obj.JZWGD) bolResult = false;
			if (this.ZZDMJ != obj.ZZDMJ) bolResult = false;
			if (this.ZYDMJ != obj.ZYDMJ) bolResult = false;
			if (this.YCJZMJ != obj.YCJZMJ) bolResult = false;
			if (this.SCJZMJ != obj.SCJZMJ) bolResult = false;
			if (this.ZCS != obj.ZCS) bolResult = false;
			if (this.DSCS != obj.DSCS) bolResult = false;
			if (this.DXCS != obj.DXCS) bolResult = false;
			if (this.DXSD != obj.DXSD) bolResult = false;
			if (this.GHYT != obj.GHYT) bolResult = false;
			if (this.YXTGHYTMC != obj.YXTGHYTMC) bolResult = false;
			if (this.FWYT != obj.FWYT) bolResult = false;
			if (this.YXTFWYTMC != obj.YXTFWYTMC) bolResult = false;
			if (this.FWJG != obj.FWJG) bolResult = false;
			if (this.ZTS != obj.ZTS) bolResult = false;
			if (this.JZWJBYT != obj.JZWJBYT) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.XQMC != obj.XQMC) bolResult = false;
			if (this.ZL != obj.ZL) bolResult = false;
			if (this.ZXDZBX != obj.ZXDZBX) bolResult = false;
			if (this.ZXDZBY != obj.ZXDZBY) bolResult = false;
			if (this.TFH != obj.TFH) bolResult = false;
			if (this.QH != obj.QH) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.DCBSM != obj.DCBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.DCYWH != obj.DCYWH) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.ZDDM != obj.ZDDM) bolResult = false;
			if (this.ZDSHIYQBSM != obj.ZDSHIYQBSM) bolResult = false;
			if (this.DCZDSHIYQBSM != obj.DCZDSHIYQBSM) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsZRZ obj)
		{
			this.BSM=obj.BSM;
			this.ZRZH=obj.ZRZH;
			this.XMMC=obj.XMMC;
			this.JZWMC=obj.JZWMC;
			this.JGRQ=obj.JGRQ;
			this.JZWGD=obj.JZWGD;
			this.ZZDMJ=obj.ZZDMJ;
			this.ZYDMJ=obj.ZYDMJ;
			this.YCJZMJ=obj.YCJZMJ;
			this.SCJZMJ=obj.SCJZMJ;
			this.ZCS=obj.ZCS;
			this.DSCS=obj.DSCS;
			this.DXCS=obj.DXCS;
			this.DXSD=obj.DXSD;
			this.GHYT=obj.GHYT;
			this.YXTGHYTMC=obj.YXTGHYTMC;
			this.FWYT=obj.FWYT;
			this.YXTFWYTMC=obj.YXTFWYTMC;
			this.FWJG=obj.FWJG;
			this.ZTS=obj.ZTS;
			this.JZWJBYT=obj.JZWJBYT;
			this.BZ=obj.BZ;
			this.XQMC=obj.XQMC;
			this.ZL=obj.ZL;
			this.ZXDZBX=obj.ZXDZBX;
			this.ZXDZBY=obj.ZXDZBY;
			this.TFH=obj.TFH;
			this.QH=obj.QH;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.DCBSM=obj.DCBSM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.DCYWH=obj.DCYWH;
			this.BDCDYH=obj.BDCDYH;
			this.ZDDM=obj.ZDDM;
			this.ZDSHIYQBSM=obj.ZDSHIYQBSM;
			this.DCZDSHIYQBSM=obj.DCZDSHIYQBSM;
			this.GXSJ=obj.GXSJ;
		}

	}

	public class clsZRZSet:EntityBaseSet
	{
		public clsZRZSet()
		{
			m_TableName="BDCDJ.ZRZ";
			m_HisTableName="BDCDJ.ZRZ_LS";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsZRZSet";
		}
		public static clsZRZSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsZRZSet clsSet = new clsZRZSet(); //(clsZRZSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsZRZSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsZRZ obj = (clsZRZ)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("ZRZH")) datarow["ZRZH"] = obj.ZRZH;
				if(datarow.Table.Columns.Contains("XMMC")) datarow["XMMC"] = obj.XMMC;
				if(datarow.Table.Columns.Contains("JZWMC")) datarow["JZWMC"] = obj.JZWMC;
				if (obj.JGRQ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("JGRQ")) datarow["JGRQ"] = obj.JGRQ;
				}
				if(datarow.Table.Columns.Contains("JZWGD")) datarow["JZWGD"] = obj.JZWGD;
				if(datarow.Table.Columns.Contains("ZZDMJ")) datarow["ZZDMJ"] = obj.ZZDMJ;
				if(datarow.Table.Columns.Contains("ZYDMJ")) datarow["ZYDMJ"] = obj.ZYDMJ;
				if(datarow.Table.Columns.Contains("YCJZMJ")) datarow["YCJZMJ"] = obj.YCJZMJ;
				if(datarow.Table.Columns.Contains("SCJZMJ")) datarow["SCJZMJ"] = obj.SCJZMJ;
				if(datarow.Table.Columns.Contains("ZCS")) datarow["ZCS"] = obj.ZCS;
				if(datarow.Table.Columns.Contains("DSCS")) datarow["DSCS"] = obj.DSCS;
				if(datarow.Table.Columns.Contains("DXCS")) datarow["DXCS"] = obj.DXCS;
				if(datarow.Table.Columns.Contains("DXSD")) datarow["DXSD"] = obj.DXSD;
				if(datarow.Table.Columns.Contains("GHYT")) datarow["GHYT"] = obj.GHYT;
				if(datarow.Table.Columns.Contains("YXTGHYTMC")) datarow["YXTGHYTMC"] = obj.YXTGHYTMC;
				if(datarow.Table.Columns.Contains("FWYT")) datarow["FWYT"] = obj.FWYT;
				if(datarow.Table.Columns.Contains("YXTFWYTMC")) datarow["YXTFWYTMC"] = obj.YXTFWYTMC;
				if(datarow.Table.Columns.Contains("FWJG")) datarow["FWJG"] = obj.FWJG;
				if(datarow.Table.Columns.Contains("ZTS")) datarow["ZTS"] = obj.ZTS;
				if(datarow.Table.Columns.Contains("JZWJBYT")) datarow["JZWJBYT"] = obj.JZWJBYT;
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("XQMC")) datarow["XQMC"] = obj.XQMC;
				if(datarow.Table.Columns.Contains("ZL")) datarow["ZL"] = obj.ZL;
				if(datarow.Table.Columns.Contains("ZXDZBX")) datarow["ZXDZBX"] = obj.ZXDZBX;
				if(datarow.Table.Columns.Contains("ZXDZBY")) datarow["ZXDZBY"] = obj.ZXDZBY;
				if(datarow.Table.Columns.Contains("TFH")) datarow["TFH"] = obj.TFH;
				if(datarow.Table.Columns.Contains("QH")) datarow["QH"] = obj.QH;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("DCBSM")) datarow["DCBSM"] = obj.DCBSM;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("DCYWH")) datarow["DCYWH"] = obj.DCYWH;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("ZDDM")) datarow["ZDDM"] = obj.ZDDM;
				if(datarow.Table.Columns.Contains("ZDSHIYQBSM")) datarow["ZDSHIYQBSM"] = obj.ZDSHIYQBSM;
				if(datarow.Table.Columns.Contains("DCZDSHIYQBSM")) datarow["DCZDSHIYQBSM"] = obj.DCZDSHIYQBSM;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
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
			clsZRZ obj = null;
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
					obj = new clsZRZ();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="ZRZH")
								if (pRow.Table.Columns.Contains("ZRZH") && pRow["ZRZH"] != DBNull.Value) { obj.ZRZH = Convert.ToString(pRow["ZRZH"]); }
							if(strFldName.ToUpper()=="XMMC")
								if (pRow.Table.Columns.Contains("XMMC") && pRow["XMMC"] != DBNull.Value) { obj.XMMC = Convert.ToString(pRow["XMMC"]); }
							if(strFldName.ToUpper()=="JZWMC")
								if (pRow.Table.Columns.Contains("JZWMC") && pRow["JZWMC"] != DBNull.Value) { obj.JZWMC = Convert.ToString(pRow["JZWMC"]); }
							if(strFldName.ToUpper()=="JGRQ")
								if (pRow.Table.Columns.Contains("JGRQ") && pRow["JGRQ"] != DBNull.Value) { obj.JGRQ = Convert.ToDateTime(pRow["JGRQ"]); }
							if(strFldName.ToUpper()=="JZWGD")
								if (pRow.Table.Columns.Contains("JZWGD") && pRow["JZWGD"] != DBNull.Value) { obj.JZWGD = Convert.ToDouble(pRow["JZWGD"]); }
							if(strFldName.ToUpper()=="ZZDMJ")
								if (pRow.Table.Columns.Contains("ZZDMJ") && pRow["ZZDMJ"] != DBNull.Value) { obj.ZZDMJ = Convert.ToDouble(pRow["ZZDMJ"]); }
							if(strFldName.ToUpper()=="ZYDMJ")
								if (pRow.Table.Columns.Contains("ZYDMJ") && pRow["ZYDMJ"] != DBNull.Value) { obj.ZYDMJ = Convert.ToDouble(pRow["ZYDMJ"]); }
							if(strFldName.ToUpper()=="YCJZMJ")
								if (pRow.Table.Columns.Contains("YCJZMJ") && pRow["YCJZMJ"] != DBNull.Value) { obj.YCJZMJ = Convert.ToDouble(pRow["YCJZMJ"]); }
							if(strFldName.ToUpper()=="SCJZMJ")
								if (pRow.Table.Columns.Contains("SCJZMJ") && pRow["SCJZMJ"] != DBNull.Value) { obj.SCJZMJ = Convert.ToDouble(pRow["SCJZMJ"]); }
							if(strFldName.ToUpper()=="ZCS")
								if (pRow.Table.Columns.Contains("ZCS") && pRow["ZCS"] != DBNull.Value) { obj.ZCS = Convert.ToInt64(pRow["ZCS"]); }
							if(strFldName.ToUpper()=="DSCS")
								if (pRow.Table.Columns.Contains("DSCS") && pRow["DSCS"] != DBNull.Value) { obj.DSCS = Convert.ToInt64(pRow["DSCS"]); }
							if(strFldName.ToUpper()=="DXCS")
								if (pRow.Table.Columns.Contains("DXCS") && pRow["DXCS"] != DBNull.Value) { obj.DXCS = Convert.ToInt64(pRow["DXCS"]); }
							if(strFldName.ToUpper()=="DXSD")
								if (pRow.Table.Columns.Contains("DXSD") && pRow["DXSD"] != DBNull.Value) { obj.DXSD = Convert.ToDouble(pRow["DXSD"]); }
							if(strFldName.ToUpper()=="GHYT")
								if (pRow.Table.Columns.Contains("GHYT") && pRow["GHYT"] != DBNull.Value) { obj.GHYT = Convert.ToString(pRow["GHYT"]); }
							if(strFldName.ToUpper()=="YXTGHYTMC")
								if (pRow.Table.Columns.Contains("YXTGHYTMC") && pRow["YXTGHYTMC"] != DBNull.Value) { obj.YXTGHYTMC = Convert.ToString(pRow["YXTGHYTMC"]); }
							if(strFldName.ToUpper()=="FWYT")
								if (pRow.Table.Columns.Contains("FWYT") && pRow["FWYT"] != DBNull.Value) { obj.FWYT = Convert.ToString(pRow["FWYT"]); }
							if(strFldName.ToUpper()=="YXTFWYTMC")
								if (pRow.Table.Columns.Contains("YXTFWYTMC") && pRow["YXTFWYTMC"] != DBNull.Value) { obj.YXTFWYTMC = Convert.ToString(pRow["YXTFWYTMC"]); }
							if(strFldName.ToUpper()=="FWJG")
								if (pRow.Table.Columns.Contains("FWJG") && pRow["FWJG"] != DBNull.Value) { obj.FWJG = Convert.ToString(pRow["FWJG"]); }
							if(strFldName.ToUpper()=="ZTS")
								if (pRow.Table.Columns.Contains("ZTS") && pRow["ZTS"] != DBNull.Value) { obj.ZTS = Convert.ToInt64(pRow["ZTS"]); }
							if(strFldName.ToUpper()=="JZWJBYT")
								if (pRow.Table.Columns.Contains("JZWJBYT") && pRow["JZWJBYT"] != DBNull.Value) { obj.JZWJBYT = Convert.ToString(pRow["JZWJBYT"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="XQMC")
								if (pRow.Table.Columns.Contains("XQMC") && pRow["XQMC"] != DBNull.Value) { obj.XQMC = Convert.ToString(pRow["XQMC"]); }
							if(strFldName.ToUpper()=="ZL")
								if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
							if(strFldName.ToUpper()=="ZXDZBX")
								if (pRow.Table.Columns.Contains("ZXDZBX") && pRow["ZXDZBX"] != DBNull.Value) { obj.ZXDZBX = Convert.ToDouble(pRow["ZXDZBX"]); }
							if(strFldName.ToUpper()=="ZXDZBY")
								if (pRow.Table.Columns.Contains("ZXDZBY") && pRow["ZXDZBY"] != DBNull.Value) { obj.ZXDZBY = Convert.ToDouble(pRow["ZXDZBY"]); }
							if(strFldName.ToUpper()=="TFH")
								if (pRow.Table.Columns.Contains("TFH") && pRow["TFH"] != DBNull.Value) { obj.TFH = Convert.ToString(pRow["TFH"]); }
							if(strFldName.ToUpper()=="QH")
								if (pRow.Table.Columns.Contains("QH") && pRow["QH"] != DBNull.Value) { obj.QH = Convert.ToString(pRow["QH"]); }
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
							if(strFldName.ToUpper()=="BDCDYH")
								if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
							if(strFldName.ToUpper()=="ZDDM")
								if (pRow.Table.Columns.Contains("ZDDM") && pRow["ZDDM"] != DBNull.Value) { obj.ZDDM = Convert.ToString(pRow["ZDDM"]); }
							if(strFldName.ToUpper()=="ZDSHIYQBSM")
								if (pRow.Table.Columns.Contains("ZDSHIYQBSM") && pRow["ZDSHIYQBSM"] != DBNull.Value) { obj.ZDSHIYQBSM = Convert.ToInt64(pRow["ZDSHIYQBSM"]); }
							if(strFldName.ToUpper()=="DCZDSHIYQBSM")
								if (pRow.Table.Columns.Contains("DCZDSHIYQBSM") && pRow["DCZDSHIYQBSM"] != DBNull.Value) { obj.DCZDSHIYQBSM = Convert.ToInt64(pRow["DCZDSHIYQBSM"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("ZRZH") && pRow["ZRZH"] != DBNull.Value) { obj.ZRZH = Convert.ToString(pRow["ZRZH"]); }
						if (pRow.Table.Columns.Contains("XMMC") && pRow["XMMC"] != DBNull.Value) { obj.XMMC = Convert.ToString(pRow["XMMC"]); }
						if (pRow.Table.Columns.Contains("JZWMC") && pRow["JZWMC"] != DBNull.Value) { obj.JZWMC = Convert.ToString(pRow["JZWMC"]); }
						if (pRow.Table.Columns.Contains("JGRQ") && pRow["JGRQ"] != DBNull.Value) { obj.JGRQ = Convert.ToDateTime(pRow["JGRQ"]); }
						if (pRow.Table.Columns.Contains("JZWGD") && pRow["JZWGD"] != DBNull.Value) { obj.JZWGD = Convert.ToDouble(pRow["JZWGD"]); }
						if (pRow.Table.Columns.Contains("ZZDMJ") && pRow["ZZDMJ"] != DBNull.Value) { obj.ZZDMJ = Convert.ToDouble(pRow["ZZDMJ"]); }
						if (pRow.Table.Columns.Contains("ZYDMJ") && pRow["ZYDMJ"] != DBNull.Value) { obj.ZYDMJ = Convert.ToDouble(pRow["ZYDMJ"]); }
						if (pRow.Table.Columns.Contains("YCJZMJ") && pRow["YCJZMJ"] != DBNull.Value) { obj.YCJZMJ = Convert.ToDouble(pRow["YCJZMJ"]); }
						if (pRow.Table.Columns.Contains("SCJZMJ") && pRow["SCJZMJ"] != DBNull.Value) { obj.SCJZMJ = Convert.ToDouble(pRow["SCJZMJ"]); }
						if (pRow.Table.Columns.Contains("ZCS") && pRow["ZCS"] != DBNull.Value) { obj.ZCS = Convert.ToInt64(pRow["ZCS"]); }
						if (pRow.Table.Columns.Contains("DSCS") && pRow["DSCS"] != DBNull.Value) { obj.DSCS = Convert.ToInt64(pRow["DSCS"]); }
						if (pRow.Table.Columns.Contains("DXCS") && pRow["DXCS"] != DBNull.Value) { obj.DXCS = Convert.ToInt64(pRow["DXCS"]); }
						if (pRow.Table.Columns.Contains("DXSD") && pRow["DXSD"] != DBNull.Value) { obj.DXSD = Convert.ToDouble(pRow["DXSD"]); }
						if (pRow.Table.Columns.Contains("GHYT") && pRow["GHYT"] != DBNull.Value) { obj.GHYT = Convert.ToString(pRow["GHYT"]); }
						if (pRow.Table.Columns.Contains("YXTGHYTMC") && pRow["YXTGHYTMC"] != DBNull.Value) { obj.YXTGHYTMC = Convert.ToString(pRow["YXTGHYTMC"]); }
						if (pRow.Table.Columns.Contains("FWYT") && pRow["FWYT"] != DBNull.Value) { obj.FWYT = Convert.ToString(pRow["FWYT"]); }
						if (pRow.Table.Columns.Contains("YXTFWYTMC") && pRow["YXTFWYTMC"] != DBNull.Value) { obj.YXTFWYTMC = Convert.ToString(pRow["YXTFWYTMC"]); }
						if (pRow.Table.Columns.Contains("FWJG") && pRow["FWJG"] != DBNull.Value) { obj.FWJG = Convert.ToString(pRow["FWJG"]); }
						if (pRow.Table.Columns.Contains("ZTS") && pRow["ZTS"] != DBNull.Value) { obj.ZTS = Convert.ToInt64(pRow["ZTS"]); }
						if (pRow.Table.Columns.Contains("JZWJBYT") && pRow["JZWJBYT"] != DBNull.Value) { obj.JZWJBYT = Convert.ToString(pRow["JZWJBYT"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("XQMC") && pRow["XQMC"] != DBNull.Value) { obj.XQMC = Convert.ToString(pRow["XQMC"]); }
						if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
						if (pRow.Table.Columns.Contains("ZXDZBX") && pRow["ZXDZBX"] != DBNull.Value) { obj.ZXDZBX = Convert.ToDouble(pRow["ZXDZBX"]); }
						if (pRow.Table.Columns.Contains("ZXDZBY") && pRow["ZXDZBY"] != DBNull.Value) { obj.ZXDZBY = Convert.ToDouble(pRow["ZXDZBY"]); }
						if (pRow.Table.Columns.Contains("TFH") && pRow["TFH"] != DBNull.Value) { obj.TFH = Convert.ToString(pRow["TFH"]); }
						if (pRow.Table.Columns.Contains("QH") && pRow["QH"] != DBNull.Value) { obj.QH = Convert.ToString(pRow["QH"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("DCBSM") && pRow["DCBSM"] != DBNull.Value) { obj.DCBSM = Convert.ToInt64(pRow["DCBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
					
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("DCYWH") && pRow["DCYWH"] != DBNull.Value) { obj.DCYWH = Convert.ToString(pRow["DCYWH"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("ZDDM") && pRow["ZDDM"] != DBNull.Value) { obj.ZDDM = Convert.ToString(pRow["ZDDM"]); }
						if (pRow.Table.Columns.Contains("ZDSHIYQBSM") && pRow["ZDSHIYQBSM"] != DBNull.Value) { obj.ZDSHIYQBSM = Convert.ToInt64(pRow["ZDSHIYQBSM"]); }
						if (pRow.Table.Columns.Contains("DCZDSHIYQBSM") && pRow["DCZDSHIYQBSM"] != DBNull.Value) { obj.DCZDSHIYQBSM = Convert.ToInt64(pRow["DCZDSHIYQBSM"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }

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
