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

	public class Fld_JSYDSYQ
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YSDM="YSDM";
		public const string YWH="YWH";
		public const string QLLX="QLLX";
		public const string DJLX="DJLX";
		public const string DJYY="DJYY";
		public const string SYQMJ="SYQMJ";
		public const string SYQQSSJ="SYQQSSJ";
		public const string SYQJSSJ="SYQJSSJ";
		public const string QDJG="QDJG";
		public const string BDCQZH="BDCQZH";
		public const string DJJG="DJJG";
		public const string DBR="DBR";
		public const string DJSJ="DJSJ";
		public const string FJ="FJ";
		public const string QSZT="QSZT";
		public const string MJDW="MJDW";
		public const string ZXYWH="ZXYWH";
		public const string ZXSJ="ZXSJ";
		public const string ZXDBR="ZXDBR";
		public const string ZXYY="ZXYY";
		public const string ZXFJ="ZXFJ";
		public const string SHBSM="SHBSM";
		public const string ZXSHBSM="ZXSHBSM";
		public const string SJGJZT="SJGJZT";
		public const string SFCD="SFCD";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string DYTDMJ="DYTDMJ";
		public const string FTTDMJ="FTTDMJ";
		public const string GYTDMJ="GYTDMJ";
		public const string JZMJ="JZMJ";
		public const string BZ_BD_DJ="BZ_BD_DJ";
		public const string BZ_ADD1="BZ_ADD1";
		public const string BZ_TDSY_QX="BZ_TDSY_QX";
		public const string QLXZ="QLXZ";
		public const string BZ_JZ_LX="BZ_JZ_LX";
		public const string BZ_JZW_QS="BZ_JZW_QS";
		public const string BZ_QYSM="BZ_QYSM";
		public const string QLRZDBH="QLRZDBH";
		public const string BZ_QS_LYZM="BZ_QS_LYZM";
		public const string QLRZL="QLRZL";
		public const string BZ_SJ_BZ="BZ_SJ_BZ";
		public const string BZ_LR_RY="BZ_LR_RY";
		public const string BZ_FZD_DM="BZ_FZD_DM";
		public const string BZ_ZDQLRGHKH="BZ_ZDQLRGHKH";
		public const string SJYT="SJYT";
		public const string PZYT="PZYT";
		public const string SJYTMC="SJYTMC";
		public const string PZYTMC="PZYTMC";
		public const string BZ_FW_SYQR="BZ_FW_SYQR";
		public const string BZ_FW_CQZH="BZ_FW_CQZH";
		public const string BZ_YQLRID="BZ_YQLRID";
		public const string BZ_YZDID="BZ_YZDID";
		public const string BZ_YZDQLRID="BZ_YZDQLRID";
		public const string BZ_YZDH="BZ_YZDH";
		public const string DJLX_MJBAK="DJLX_MJBAK";
		public const string YXTBSM_NUMBER="YXTBSM_NUMBER";
		public const string QLXZ_MJBAK="QLXZ_MJBAK";
		public const string BZ_GXSJ="BZ_GXSJ";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string QLXZMC="QLXZMC";
		public const string BZ_DJNR="BZ_DJNR";
		public const string BZ_DJLXMC="BZ_DJLXMC";
		public const string BZ_ZDID="BZ_ZDID";
		public const string TDSYQX="TDSYQX";
		public const string DYBSM="DYBSM";
		public const string BZ_ZDTYBM="BZ_ZDTYBM";
		public const string BZ_FCZH="BZ_FCZH";
		public const string BZ_N_LAND_ID="BZ_N_LAND_ID";
		public const string BZ_LAND_ID="BZ_LAND_ID";
		public const string BZ_FWZL="BZ_FWZL";
		public const string BZ_ZDBSM="BZ_ZDBSM";
		public const string BZ_BLDW="BZ_BLDW";
		public const string BZ_CONTRACT_SIGNING_DATE="BZ_CONTRACT_SIGNING_DATE";
		public const string BZ_LAND_AREA="BZ_LAND_AREA";
		public const string BZ_REG_NO="BZ_REG_NO";
		public const string BZ_POUNDAGE="BZ_POUNDAGE";
		public const string BZ_DATA_SOURCE="BZ_DATA_SOURCE";
		public const string BZ_AUDIT_RESULTS="BZ_AUDIT_RESULTS";
		public const string BZ_AUDIT_RESULTS_DATE="BZ_AUDIT_RESULTS_DATE";
		public const string BZ_AUDIT_PERSON="BZ_AUDIT_PERSON";
		public const string BZ_SHARE_LAND_CARD_NO="BZ_SHARE_LAND_CARD_NO";
		public const string BZ_FEE="BZ_FEE";
		public const string BZ_N_LAND_LOCATED="BZ_N_LAND_LOCATED";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsJSYDSYQ:IEntity
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
		private string m_YWH;
		private string m_QLLX;
		private string m_DJLX;
		private string m_DJYY;
		private double m_SYQMJ;
		private DateTime m_SYQQSSJ;
		private DateTime m_SYQJSSJ;
		private double m_QDJG;
		private string m_BDCQZH;
		private string m_DJJG;
		private string m_DBR;
		private DateTime m_DJSJ;
		private string m_FJ;
		private string m_QSZT;
		private string m_MJDW;
		private string m_ZXYWH;
		private DateTime m_ZXSJ;
		private string m_ZXDBR;
		private string m_ZXYY;
		private string m_ZXFJ;
		private long m_SHBSM;
		private long m_ZXSHBSM;
		private int m_SJGJZT;
		private int m_SFCD;
		private string m_YXTBM;
		private string m_YXTBSM;
		private long m_QXDM;
		private long m_REV_;
		private double m_DYTDMJ;
		private double m_FTTDMJ;
		private double m_GYTDMJ;
		private double m_JZMJ;
        private string m_QLRZL;

		private string m_QLXZ;





		private string m_SJYT;
		private string m_PZYT;
		private string m_SJYTMC;
		private string m_PZYTMC;
		private DateTime m_GXSJ;
		private string m_BZ;
		private string m_QLXZMC;
		private string m_TDSYQX;
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
		public double SYQMJ
		{
			get{ return m_SYQMJ; }
			set{ m_SYQMJ = value; }
		}
		public DateTime SYQQSSJ
		{
			get{ return m_SYQQSSJ; }
			set{ m_SYQQSSJ = value; }
		}
		public DateTime SYQJSSJ
		{
			get{ return m_SYQJSSJ; }
			set{ m_SYQJSSJ = value; }
		}
		public double QDJG
		{
			get{ return m_QDJG; }
			set{ m_QDJG = value; }
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
		public string MJDW
		{
			get{ return m_MJDW; }
			set{ m_MJDW = value; }
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
		public int SJGJZT
		{
			get{ return m_SJGJZT; }
			set{ m_SJGJZT = value; }
		}
		public int SFCD
		{
			get{ return m_SFCD; }
			set{ m_SFCD = value; }
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
		public double DYTDMJ
		{
			get{ return m_DYTDMJ; }
			set{ m_DYTDMJ = value; }
		}
		public double FTTDMJ
		{
			get{ return m_FTTDMJ; }
			set{ m_FTTDMJ = value; }
		}
		public double GYTDMJ
		{
			get{ return m_GYTDMJ; }
			set{ m_GYTDMJ = value; }
		}
		public double JZMJ
		{
			get{ return m_JZMJ; }
			set{ m_JZMJ = value; }
		}
		public string QLXZ
		{
			get{ return m_QLXZ; }
			set{ m_QLXZ = value; }
		}
		public string QLRZL
		{
			get{ return m_QLRZL; }
			set{ m_QLRZL = value; }
		}
		
		public string SJYT
		{
			get{ return m_SJYT; }
			set{ m_SJYT = value; }
		}
		public string PZYT
		{
			get{ return m_PZYT; }
			set{ m_PZYT = value; }
		}
		public string SJYTMC
		{
			get{ return m_SJYTMC; }
			set{ m_SJYTMC = value; }
		}
		public string PZYTMC
		{
			get{ return m_PZYTMC; }
			set{ m_PZYTMC = value; }
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
		public string QLXZMC
		{
			get{ return m_QLXZMC; }
			set{ m_QLXZMC = value; }
		}
		
		public string TDSYQX
		{
			get{ return m_TDSYQX; }
			set{ m_TDSYQX = value; }
		}
		
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

		#endregion
		public bool IsEquals(clsJSYDSYQ obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YSDM != obj.YSDM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.QLLX != obj.QLLX) bolResult = false;
			if (this.DJLX != obj.DJLX) bolResult = false;
			if (this.DJYY != obj.DJYY) bolResult = false;
			if (this.SYQMJ != obj.SYQMJ) bolResult = false;
			if (this.SYQQSSJ != obj.SYQQSSJ) bolResult = false;
			if (this.SYQJSSJ != obj.SYQJSSJ) bolResult = false;
			if (this.QDJG != obj.QDJG) bolResult = false;
			if (this.BDCQZH != obj.BDCQZH) bolResult = false;
			if (this.DJJG != obj.DJJG) bolResult = false;
			if (this.DBR != obj.DBR) bolResult = false;
			if (this.DJSJ != obj.DJSJ) bolResult = false;
			if (this.FJ != obj.FJ) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.MJDW != obj.MJDW) bolResult = false;
			if (this.ZXYWH != obj.ZXYWH) bolResult = false;
			if (this.ZXSJ != obj.ZXSJ) bolResult = false;
			if (this.ZXDBR != obj.ZXDBR) bolResult = false;
			if (this.ZXYY != obj.ZXYY) bolResult = false;
			if (this.ZXFJ != obj.ZXFJ) bolResult = false;
			if (this.SHBSM != obj.SHBSM) bolResult = false;
			if (this.ZXSHBSM != obj.ZXSHBSM) bolResult = false;
			if (this.SJGJZT != obj.SJGJZT) bolResult = false;
			if (this.SFCD != obj.SFCD) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.DYTDMJ != obj.DYTDMJ) bolResult = false;
			if (this.FTTDMJ != obj.FTTDMJ) bolResult = false;
			if (this.GYTDMJ != obj.GYTDMJ) bolResult = false;
			if (this.JZMJ != obj.JZMJ) bolResult = false;
			if (this.QLXZ != obj.QLXZ) bolResult = false;
	
			if (this.QLRZL != obj.QLRZL) bolResult = false;
			
			if (this.SJYT != obj.SJYT) bolResult = false;
			if (this.PZYT != obj.PZYT) bolResult = false;
			if (this.SJYTMC != obj.SJYTMC) bolResult = false;
			if (this.PZYTMC != obj.PZYTMC) bolResult = false;
			
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.QLXZMC != obj.QLXZMC) bolResult = false;
			
			if (this.TDSYQX != obj.TDSYQX) bolResult = false;
		
			return bolResult;
		}

		public void Colne(clsJSYDSYQ obj)
		{
			this.BSM=obj.BSM;
			this.YSDM=obj.YSDM;
			this.YWH=obj.YWH;
			this.QLLX=obj.QLLX;
			this.DJLX=obj.DJLX;
			this.DJYY=obj.DJYY;
			this.SYQMJ=obj.SYQMJ;
			this.SYQQSSJ=obj.SYQQSSJ;
			this.SYQJSSJ=obj.SYQJSSJ;
			this.QDJG=obj.QDJG;
			this.BDCQZH=obj.BDCQZH;
			this.DJJG=obj.DJJG;
			this.DBR=obj.DBR;
			this.DJSJ=obj.DJSJ;
			this.FJ=obj.FJ;
			this.QSZT=obj.QSZT;
			this.MJDW=obj.MJDW;
			this.ZXYWH=obj.ZXYWH;
			this.ZXSJ=obj.ZXSJ;
			this.ZXDBR=obj.ZXDBR;
			this.ZXYY=obj.ZXYY;
			this.ZXFJ=obj.ZXFJ;
			this.SHBSM=obj.SHBSM;
			this.ZXSHBSM=obj.ZXSHBSM;
			this.SJGJZT=obj.SJGJZT;
			this.SFCD=obj.SFCD;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.DYTDMJ=obj.DYTDMJ;
			this.FTTDMJ=obj.FTTDMJ;
			this.GYTDMJ=obj.GYTDMJ;
			this.JZMJ=obj.JZMJ;
			this.QLXZ=obj.QLXZ;
			this.QLRZL=obj.QLRZL;
			this.SJYT=obj.SJYT;
			this.PZYT=obj.PZYT;
			this.SJYTMC=obj.SJYTMC;
			this.PZYTMC=obj.PZYTMC;
		
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.QLXZMC=obj.QLXZMC;
		
			this.TDSYQX=obj.TDSYQX;
		
		}

	}

	public class clsJSYDSYQSet:EntityBaseSet
	{
		public clsJSYDSYQSet()
		{
			m_TableName="BDCDJ.JSYDSYQ";
			m_HisTableName="BDCDJ.JSYDSYQ_LS";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsJSYDSYQSet";
		}
		public static clsJSYDSYQSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsJSYDSYQSet clsSet = new clsJSYDSYQSet(); //(clsJSYDSYQSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsJSYDSYQSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsJSYDSYQ obj = (clsJSYDSYQ)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YSDM")) datarow["YSDM"] = obj.YSDM;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("QLLX")) datarow["QLLX"] = obj.QLLX;
				if(datarow.Table.Columns.Contains("DJLX")) datarow["DJLX"] = obj.DJLX;
				if(datarow.Table.Columns.Contains("DJYY")) datarow["DJYY"] = obj.DJYY;
				if(datarow.Table.Columns.Contains("SYQMJ")) datarow["SYQMJ"] = obj.SYQMJ;
				if (obj.SYQQSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("SYQQSSJ")) datarow["SYQQSSJ"] = obj.SYQQSSJ;
				}
				if (obj.SYQJSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("SYQJSSJ")) datarow["SYQJSSJ"] = obj.SYQJSSJ;
				}
				if(datarow.Table.Columns.Contains("QDJG")) datarow["QDJG"] = obj.QDJG;
				if(datarow.Table.Columns.Contains("BDCQZH")) datarow["BDCQZH"] = obj.BDCQZH;
				if(datarow.Table.Columns.Contains("DJJG")) datarow["DJJG"] = obj.DJJG;
				if(datarow.Table.Columns.Contains("DBR")) datarow["DBR"] = obj.DBR;
				if (obj.DJSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("DJSJ")) datarow["DJSJ"] = obj.DJSJ;
				}
				if(datarow.Table.Columns.Contains("FJ")) datarow["FJ"] = obj.FJ;
				if(datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
				if(datarow.Table.Columns.Contains("MJDW")) datarow["MJDW"] = obj.MJDW;
				if(datarow.Table.Columns.Contains("ZXYWH")) datarow["ZXYWH"] = obj.ZXYWH;
				if (obj.ZXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("ZXSJ")) datarow["ZXSJ"] = obj.ZXSJ;
                }
                else
                {
                    if (datarow.Table.Columns.Contains("ZXSJ")) datarow["ZXSJ"] = DBNull.Value;
                }
				if(datarow.Table.Columns.Contains("ZXDBR")) datarow["ZXDBR"] = obj.ZXDBR;
				if(datarow.Table.Columns.Contains("ZXYY")) datarow["ZXYY"] = obj.ZXYY;
				if(datarow.Table.Columns.Contains("ZXFJ")) datarow["ZXFJ"] = obj.ZXFJ;
				if(datarow.Table.Columns.Contains("SHBSM")) datarow["SHBSM"] = obj.SHBSM;
				if(datarow.Table.Columns.Contains("ZXSHBSM")) datarow["ZXSHBSM"] = obj.ZXSHBSM;
				if(datarow.Table.Columns.Contains("SJGJZT")) datarow["SJGJZT"] = obj.SJGJZT;
				if(datarow.Table.Columns.Contains("SFCD")) datarow["SFCD"] = obj.SFCD;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("DYTDMJ")) datarow["DYTDMJ"] = obj.DYTDMJ;
				if(datarow.Table.Columns.Contains("FTTDMJ")) datarow["FTTDMJ"] = obj.FTTDMJ;
				if(datarow.Table.Columns.Contains("GYTDMJ")) datarow["GYTDMJ"] = obj.GYTDMJ;
				if(datarow.Table.Columns.Contains("JZMJ")) datarow["JZMJ"] = obj.JZMJ;
				if(datarow.Table.Columns.Contains("QLXZ")) datarow["QLXZ"] = obj.QLXZ;
				if(datarow.Table.Columns.Contains("SJYT")) datarow["SJYT"] = obj.SJYT;
				if(datarow.Table.Columns.Contains("PZYT")) datarow["PZYT"] = obj.PZYT;
				if(datarow.Table.Columns.Contains("SJYTMC")) datarow["SJYTMC"] = obj.SJYTMC;
				if(datarow.Table.Columns.Contains("PZYTMC")) datarow["PZYTMC"] = obj.PZYTMC;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("QLXZMC")) datarow["QLXZMC"] = obj.QLXZMC;
				if(datarow.Table.Columns.Contains("TDSYQX")) datarow["TDSYQX"] = obj.TDSYQX;
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
			clsJSYDSYQ obj = null;
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
					obj = new clsJSYDSYQ();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YSDM")
								if (pRow.Table.Columns.Contains("YSDM") && pRow["YSDM"] != DBNull.Value) { obj.YSDM = Convert.ToString(pRow["YSDM"]); }
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="QLLX")
								if (pRow.Table.Columns.Contains("QLLX") && pRow["QLLX"] != DBNull.Value) { obj.QLLX = Convert.ToString(pRow["QLLX"]); }
							if(strFldName.ToUpper()=="DJLX")
								if (pRow.Table.Columns.Contains("DJLX") && pRow["DJLX"] != DBNull.Value) { obj.DJLX = Convert.ToString(pRow["DJLX"]); }
							if(strFldName.ToUpper()=="DJYY")
								if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
							if(strFldName.ToUpper()=="SYQMJ")
								if (pRow.Table.Columns.Contains("SYQMJ") && pRow["SYQMJ"] != DBNull.Value) { obj.SYQMJ = Convert.ToDouble(pRow["SYQMJ"]); }
							if(strFldName.ToUpper()=="SYQQSSJ")
								if (pRow.Table.Columns.Contains("SYQQSSJ") && pRow["SYQQSSJ"] != DBNull.Value) { obj.SYQQSSJ = Convert.ToDateTime(pRow["SYQQSSJ"]); }
							if(strFldName.ToUpper()=="SYQJSSJ")
								if (pRow.Table.Columns.Contains("SYQJSSJ") && pRow["SYQJSSJ"] != DBNull.Value) { obj.SYQJSSJ = Convert.ToDateTime(pRow["SYQJSSJ"]); }
							if(strFldName.ToUpper()=="QDJG")
								if (pRow.Table.Columns.Contains("QDJG") && pRow["QDJG"] != DBNull.Value) { obj.QDJG = Convert.ToDouble(pRow["QDJG"]); }
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
							if(strFldName.ToUpper()=="MJDW")
								if (pRow.Table.Columns.Contains("MJDW") && pRow["MJDW"] != DBNull.Value) { obj.MJDW = Convert.ToString(pRow["MJDW"]); }
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
							if(strFldName.ToUpper()=="SJGJZT")
								if (pRow.Table.Columns.Contains("SJGJZT") && pRow["SJGJZT"] != DBNull.Value) { obj.SJGJZT = Convert.ToInt16(pRow["SJGJZT"]); }
							if(strFldName.ToUpper()=="SFCD")
								if (pRow.Table.Columns.Contains("SFCD") && pRow["SFCD"] != DBNull.Value) { obj.SFCD = Convert.ToInt16(pRow["SFCD"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="DYTDMJ")
								if (pRow.Table.Columns.Contains("DYTDMJ") && pRow["DYTDMJ"] != DBNull.Value) { obj.DYTDMJ = Convert.ToDouble(pRow["DYTDMJ"]); }
							if(strFldName.ToUpper()=="FTTDMJ")
								if (pRow.Table.Columns.Contains("FTTDMJ") && pRow["FTTDMJ"] != DBNull.Value) { obj.FTTDMJ = Convert.ToDouble(pRow["FTTDMJ"]); }
							if(strFldName.ToUpper()=="GYTDMJ")
								if (pRow.Table.Columns.Contains("GYTDMJ") && pRow["GYTDMJ"] != DBNull.Value) { obj.GYTDMJ = Convert.ToDouble(pRow["GYTDMJ"]); }
							if(strFldName.ToUpper()=="JZMJ")
								if (pRow.Table.Columns.Contains("JZMJ") && pRow["JZMJ"] != DBNull.Value) { obj.JZMJ = Convert.ToDouble(pRow["JZMJ"]); }
							if(strFldName.ToUpper()=="QLXZ")
								if (pRow.Table.Columns.Contains("QLXZ") && pRow["QLXZ"] != DBNull.Value) { obj.QLXZ = Convert.ToString(pRow["QLXZ"]); }
							
							if(strFldName.ToUpper()=="QLRZL")
								if (pRow.Table.Columns.Contains("QLRZL") && pRow["QLRZL"] != DBNull.Value) { obj.QLRZL = Convert.ToString(pRow["QLRZL"]); }
							
							if(strFldName.ToUpper()=="SJYT")
								if (pRow.Table.Columns.Contains("SJYT") && pRow["SJYT"] != DBNull.Value) { obj.SJYT = Convert.ToString(pRow["SJYT"]); }
							if(strFldName.ToUpper()=="PZYT")
								if (pRow.Table.Columns.Contains("PZYT") && pRow["PZYT"] != DBNull.Value) { obj.PZYT = Convert.ToString(pRow["PZYT"]); }
							if(strFldName.ToUpper()=="SJYTMC")
								if (pRow.Table.Columns.Contains("SJYTMC") && pRow["SJYTMC"] != DBNull.Value) { obj.SJYTMC = Convert.ToString(pRow["SJYTMC"]); }
							if(strFldName.ToUpper()=="PZYTMC")
								if (pRow.Table.Columns.Contains("PZYTMC") && pRow["PZYTMC"] != DBNull.Value) { obj.PZYTMC = Convert.ToString(pRow["PZYTMC"]); }
							
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="QLXZMC")
								if (pRow.Table.Columns.Contains("QLXZMC") && pRow["QLXZMC"] != DBNull.Value) { obj.QLXZMC = Convert.ToString(pRow["QLXZMC"]); }

						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YSDM") && pRow["YSDM"] != DBNull.Value) { obj.YSDM = Convert.ToString(pRow["YSDM"]); }
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("QLLX") && pRow["QLLX"] != DBNull.Value) { obj.QLLX = Convert.ToString(pRow["QLLX"]); }
						if (pRow.Table.Columns.Contains("DJLX") && pRow["DJLX"] != DBNull.Value) { obj.DJLX = Convert.ToString(pRow["DJLX"]); }
						if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
						if (pRow.Table.Columns.Contains("SYQMJ") && pRow["SYQMJ"] != DBNull.Value) { obj.SYQMJ = Convert.ToDouble(pRow["SYQMJ"]); }
						if (pRow.Table.Columns.Contains("SYQQSSJ") && pRow["SYQQSSJ"] != DBNull.Value) { obj.SYQQSSJ = Convert.ToDateTime(pRow["SYQQSSJ"]); }
						if (pRow.Table.Columns.Contains("SYQJSSJ") && pRow["SYQJSSJ"] != DBNull.Value) { obj.SYQJSSJ = Convert.ToDateTime(pRow["SYQJSSJ"]); }
						if (pRow.Table.Columns.Contains("QDJG") && pRow["QDJG"] != DBNull.Value) { obj.QDJG = Convert.ToDouble(pRow["QDJG"]); }
						if (pRow.Table.Columns.Contains("BDCQZH") && pRow["BDCQZH"] != DBNull.Value) { obj.BDCQZH = Convert.ToString(pRow["BDCQZH"]); }
						if (pRow.Table.Columns.Contains("DJJG") && pRow["DJJG"] != DBNull.Value) { obj.DJJG = Convert.ToString(pRow["DJJG"]); }
						if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
						if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
						if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
						if (pRow.Table.Columns.Contains("MJDW") && pRow["MJDW"] != DBNull.Value) { obj.MJDW = Convert.ToString(pRow["MJDW"]); }
						if (pRow.Table.Columns.Contains("ZXYWH") && pRow["ZXYWH"] != DBNull.Value) { obj.ZXYWH = Convert.ToString(pRow["ZXYWH"]); }
						if (pRow.Table.Columns.Contains("ZXSJ") && pRow["ZXSJ"] != DBNull.Value) { obj.ZXSJ = Convert.ToDateTime(pRow["ZXSJ"]); }
						if (pRow.Table.Columns.Contains("ZXDBR") && pRow["ZXDBR"] != DBNull.Value) { obj.ZXDBR = Convert.ToString(pRow["ZXDBR"]); }
						if (pRow.Table.Columns.Contains("ZXYY") && pRow["ZXYY"] != DBNull.Value) { obj.ZXYY = Convert.ToString(pRow["ZXYY"]); }
						if (pRow.Table.Columns.Contains("ZXFJ") && pRow["ZXFJ"] != DBNull.Value) { obj.ZXFJ = Convert.ToString(pRow["ZXFJ"]); }
						if (pRow.Table.Columns.Contains("SHBSM") && pRow["SHBSM"] != DBNull.Value) { obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]); }
						if (pRow.Table.Columns.Contains("ZXSHBSM") && pRow["ZXSHBSM"] != DBNull.Value) { obj.ZXSHBSM = Convert.ToInt64(pRow["ZXSHBSM"]); }
						if (pRow.Table.Columns.Contains("SJGJZT") && pRow["SJGJZT"] != DBNull.Value) { obj.SJGJZT = Convert.ToInt16(pRow["SJGJZT"]); }
						if (pRow.Table.Columns.Contains("SFCD") && pRow["SFCD"] != DBNull.Value) { obj.SFCD = Convert.ToInt16(pRow["SFCD"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("DYTDMJ") && pRow["DYTDMJ"] != DBNull.Value) { obj.DYTDMJ = Convert.ToDouble(pRow["DYTDMJ"]); }
						if (pRow.Table.Columns.Contains("FTTDMJ") && pRow["FTTDMJ"] != DBNull.Value) { obj.FTTDMJ = Convert.ToDouble(pRow["FTTDMJ"]); }
						if (pRow.Table.Columns.Contains("GYTDMJ") && pRow["GYTDMJ"] != DBNull.Value) { obj.GYTDMJ = Convert.ToDouble(pRow["GYTDMJ"]); }
						if (pRow.Table.Columns.Contains("JZMJ") && pRow["JZMJ"] != DBNull.Value) { obj.JZMJ = Convert.ToDouble(pRow["JZMJ"]); }
						if (pRow.Table.Columns.Contains("QLXZ") && pRow["QLXZ"] != DBNull.Value) { obj.QLXZ = Convert.ToString(pRow["QLXZ"]); }
					
						if (pRow.Table.Columns.Contains("QLRZL") && pRow["QLRZL"] != DBNull.Value) { obj.QLRZL = Convert.ToString(pRow["QLRZL"]); }
					
						if (pRow.Table.Columns.Contains("SJYT") && pRow["SJYT"] != DBNull.Value) { obj.SJYT = Convert.ToString(pRow["SJYT"]); }
						if (pRow.Table.Columns.Contains("PZYT") && pRow["PZYT"] != DBNull.Value) { obj.PZYT = Convert.ToString(pRow["PZYT"]); }
						if (pRow.Table.Columns.Contains("SJYTMC") && pRow["SJYTMC"] != DBNull.Value) { obj.SJYTMC = Convert.ToString(pRow["SJYTMC"]); }
						if (pRow.Table.Columns.Contains("PZYTMC") && pRow["PZYTMC"] != DBNull.Value) { obj.PZYTMC = Convert.ToString(pRow["PZYTMC"]); }
						
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("QLXZMC") && pRow["QLXZMC"] != DBNull.Value) { obj.QLXZMC = Convert.ToString(pRow["QLXZMC"]); }
					
						if (pRow.Table.Columns.Contains("TDSYQX") && pRow["TDSYQX"] != DBNull.Value) { obj.TDSYQX = Convert.ToString(pRow["TDSYQX"]); }
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
