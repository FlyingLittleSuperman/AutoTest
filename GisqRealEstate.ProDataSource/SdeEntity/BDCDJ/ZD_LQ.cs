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

	public class Fld_ZDLQ
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string ZDDM="ZDDM";
		public const string BDCDYH="BDCDYH";
		public const string YSDM="YSDM";
		public const string ZDTZM="ZDTZM";
		public const string ZL="ZL";
		public const string ZDMJ="ZDMJ";
		public const string MJDW="MJDW";
		public const string YT="YT";
		public const string DJ="DJ";
		public const string JG="JG";
		public const string QLLX="QLLX";
		public const string QLXZ="QLXZ";
		public const string QLSDFS="QLSDFS";
		public const string RJL="RJL";
		public const string JZMD="JZMD";
		public const string JZXG="JZXG";
		public const string ZDSZD="ZDSZD";
		public const string ZDSZN="ZDSZN";
		public const string ZDSZX="ZDSZX";
		public const string ZDSZB="ZDSZB";
		public const string ZDT="ZDT";
		public const string TFH="TFH";
		public const string DJH="DJH";
		public const string ZT="ZT";
		public const string YZDBH="YZDBH";
		public const string YTDYT="YTDYT";
		public const string TDSYQR="TDSYQR";
		public const string JZMJ="JZMJ";
		public const string JZWZDMJ="JZWZDMJ";
		public const string SCMJ="SCMJ";
		public const string FZMJ="FZMJ";
		public const string ZYSZ="ZYSZ";
		public const string ZS="ZS";
		public const string LZ="LZ";
		public const string QY="QY";
		public const string ZLND="ZLND";
		public const string LB="LB";
		public const string XB="XB";
		public const string XDM="XDM";
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
		public const string SYQQSSJ="SYQQSSJ";
		public const string SYQJSSJ="SYQJSSJ";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsZDLQ:IEntity
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
		private string m_ZDDM;
		private string m_BDCDYH;
		private string m_YSDM;
		private string m_ZDTZM;
		private string m_ZL;
		private double m_ZDMJ;
		private string m_MJDW;
		private string m_YT;
		private string m_DJ;
		private double m_JG;
		private string m_QLLX;
		private string m_QLXZ;
		private string m_QLSDFS;
		private double m_RJL;
		private double m_JZMD;
		private double m_JZXG;
		private string m_ZDSZD;
		private string m_ZDSZN;
		private string m_ZDSZX;
		private string m_ZDSZB;
		private byte[] m_ZDT;
		private string m_TFH;
		private string m_DJH;
		private string m_ZT;
		private string m_YZDBH;
		private string m_YTDYT;
		private string m_TDSYQR;
		private double m_JZMJ;
		private double m_JZWZDMJ;
		private double m_SCMJ;
		private double m_FZMJ;
		private string m_ZYSZ;
		private long m_ZS;
		private string m_LZ;
		private string m_QY;
		private long m_ZLND;
		private string m_LB;
		private string m_XB;
		private string m_XDM;
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
		private DateTime m_SYQQSSJ;
		private DateTime m_SYQJSSJ;
		private long m_BG_BB;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
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
		public string YSDM
		{
			get{ return m_YSDM; }
			set{ m_YSDM = value; }
		}
		public string ZDTZM
		{
			get{ return m_ZDTZM; }
			set{ m_ZDTZM = value; }
		}
		public string ZL
		{
			get{ return m_ZL; }
			set{ m_ZL = value; }
		}
		public double ZDMJ
		{
			get{ return m_ZDMJ; }
			set{ m_ZDMJ = value; }
		}
		public string MJDW
		{
			get{ return m_MJDW; }
			set{ m_MJDW = value; }
		}
		public string YT
		{
			get{ return m_YT; }
			set{ m_YT = value; }
		}
		public string DJ
		{
			get{ return m_DJ; }
			set{ m_DJ = value; }
		}
		public double JG
		{
			get{ return m_JG; }
			set{ m_JG = value; }
		}
		public string QLLX
		{
			get{ return m_QLLX; }
			set{ m_QLLX = value; }
		}
		public string QLXZ
		{
			get{ return m_QLXZ; }
			set{ m_QLXZ = value; }
		}
		public string QLSDFS
		{
			get{ return m_QLSDFS; }
			set{ m_QLSDFS = value; }
		}
		public double RJL
		{
			get{ return m_RJL; }
			set{ m_RJL = value; }
		}
		public double JZMD
		{
			get{ return m_JZMD; }
			set{ m_JZMD = value; }
		}
		public double JZXG
		{
			get{ return m_JZXG; }
			set{ m_JZXG = value; }
		}
		public string ZDSZD
		{
			get{ return m_ZDSZD; }
			set{ m_ZDSZD = value; }
		}
		public string ZDSZN
		{
			get{ return m_ZDSZN; }
			set{ m_ZDSZN = value; }
		}
		public string ZDSZX
		{
			get{ return m_ZDSZX; }
			set{ m_ZDSZX = value; }
		}
		public string ZDSZB
		{
			get{ return m_ZDSZB; }
			set{ m_ZDSZB = value; }
		}
		public byte[] ZDT
		{
			get{ return m_ZDT; }
			set{ m_ZDT = value; }
		}
		public string TFH
		{
			get{ return m_TFH; }
			set{ m_TFH = value; }
		}
		public string DJH
		{
			get{ return m_DJH; }
			set{ m_DJH = value; }
		}
		public string ZT
		{
			get{ return m_ZT; }
			set{ m_ZT = value; }
		}
		public string YZDBH
		{
			get{ return m_YZDBH; }
			set{ m_YZDBH = value; }
		}
		public string YTDYT
		{
			get{ return m_YTDYT; }
			set{ m_YTDYT = value; }
		}
		public string TDSYQR
		{
			get{ return m_TDSYQR; }
			set{ m_TDSYQR = value; }
		}
		public double JZMJ
		{
			get{ return m_JZMJ; }
			set{ m_JZMJ = value; }
		}
		public double JZWZDMJ
		{
			get{ return m_JZWZDMJ; }
			set{ m_JZWZDMJ = value; }
		}
		public double SCMJ
		{
			get{ return m_SCMJ; }
			set{ m_SCMJ = value; }
		}
		public double FZMJ
		{
			get{ return m_FZMJ; }
			set{ m_FZMJ = value; }
		}
		public string ZYSZ
		{
			get{ return m_ZYSZ; }
			set{ m_ZYSZ = value; }
		}
		public long ZS
		{
			get{ return m_ZS; }
			set{ m_ZS = value; }
		}
		public string LZ
		{
			get{ return m_LZ; }
			set{ m_LZ = value; }
		}
		public string QY
		{
			get{ return m_QY; }
			set{ m_QY = value; }
		}
		public long ZLND
		{
			get{ return m_ZLND; }
			set{ m_ZLND = value; }
		}
		public string LB
		{
			get{ return m_LB; }
			set{ m_LB = value; }
		}
		public string XB
		{
			get{ return m_XB; }
			set{ m_XB = value; }
		}
		public string XDM
		{
			get{ return m_XDM; }
			set{ m_XDM = value; }
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
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

		#endregion
		public bool IsEquals(clsZDLQ obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.ZDDM != obj.ZDDM) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.YSDM != obj.YSDM) bolResult = false;
			if (this.ZDTZM != obj.ZDTZM) bolResult = false;
			if (this.ZL != obj.ZL) bolResult = false;
			if (this.ZDMJ != obj.ZDMJ) bolResult = false;
			if (this.MJDW != obj.MJDW) bolResult = false;
			if (this.YT != obj.YT) bolResult = false;
			if (this.DJ != obj.DJ) bolResult = false;
			if (this.JG != obj.JG) bolResult = false;
			if (this.QLLX != obj.QLLX) bolResult = false;
			if (this.QLXZ != obj.QLXZ) bolResult = false;
			if (this.QLSDFS != obj.QLSDFS) bolResult = false;
			if (this.RJL != obj.RJL) bolResult = false;
			if (this.JZMD != obj.JZMD) bolResult = false;
			if (this.JZXG != obj.JZXG) bolResult = false;
			if (this.ZDSZD != obj.ZDSZD) bolResult = false;
			if (this.ZDSZN != obj.ZDSZN) bolResult = false;
			if (this.ZDSZX != obj.ZDSZX) bolResult = false;
			if (this.ZDSZB != obj.ZDSZB) bolResult = false;
			if (this.ZDT != obj.ZDT) bolResult = false;
			if (this.TFH != obj.TFH) bolResult = false;
			if (this.DJH != obj.DJH) bolResult = false;
			if (this.ZT != obj.ZT) bolResult = false;
			if (this.YZDBH != obj.YZDBH) bolResult = false;
			if (this.YTDYT != obj.YTDYT) bolResult = false;
			if (this.TDSYQR != obj.TDSYQR) bolResult = false;
			if (this.JZMJ != obj.JZMJ) bolResult = false;
			if (this.JZWZDMJ != obj.JZWZDMJ) bolResult = false;
			if (this.SCMJ != obj.SCMJ) bolResult = false;
			if (this.FZMJ != obj.FZMJ) bolResult = false;
			if (this.ZYSZ != obj.ZYSZ) bolResult = false;
			if (this.ZS != obj.ZS) bolResult = false;
			if (this.LZ != obj.LZ) bolResult = false;
			if (this.QY != obj.QY) bolResult = false;
			if (this.ZLND != obj.ZLND) bolResult = false;
			if (this.LB != obj.LB) bolResult = false;
			if (this.XB != obj.XB) bolResult = false;
			if (this.XDM != obj.XDM) bolResult = false;
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
			if (this.SYQQSSJ != obj.SYQQSSJ) bolResult = false;
			if (this.SYQJSSJ != obj.SYQJSSJ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsZDLQ obj)
		{
			this.BSM=obj.BSM;
			this.ZDDM=obj.ZDDM;
			this.BDCDYH=obj.BDCDYH;
			this.YSDM=obj.YSDM;
			this.ZDTZM=obj.ZDTZM;
			this.ZL=obj.ZL;
			this.ZDMJ=obj.ZDMJ;
			this.MJDW=obj.MJDW;
			this.YT=obj.YT;
			this.DJ=obj.DJ;
			this.JG=obj.JG;
			this.QLLX=obj.QLLX;
			this.QLXZ=obj.QLXZ;
			this.QLSDFS=obj.QLSDFS;
			this.RJL=obj.RJL;
			this.JZMD=obj.JZMD;
			this.JZXG=obj.JZXG;
			this.ZDSZD=obj.ZDSZD;
			this.ZDSZN=obj.ZDSZN;
			this.ZDSZX=obj.ZDSZX;
			this.ZDSZB=obj.ZDSZB;
			this.ZDT=obj.ZDT;
			this.TFH=obj.TFH;
			this.DJH=obj.DJH;
			this.ZT=obj.ZT;
			this.YZDBH=obj.YZDBH;
			this.YTDYT=obj.YTDYT;
			this.TDSYQR=obj.TDSYQR;
			this.JZMJ=obj.JZMJ;
			this.JZWZDMJ=obj.JZWZDMJ;
			this.SCMJ=obj.SCMJ;
			this.FZMJ=obj.FZMJ;
			this.ZYSZ=obj.ZYSZ;
			this.ZS=obj.ZS;
			this.LZ=obj.LZ;
			this.QY=obj.QY;
			this.ZLND=obj.ZLND;
			this.LB=obj.LB;
			this.XB=obj.XB;
			this.XDM=obj.XDM;
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
			this.SYQQSSJ=obj.SYQQSSJ;
			this.SYQJSSJ=obj.SYQJSSJ;
		}

	}

	public class clsZDLQSet:EntityBaseSet
	{
		public clsZDLQSet()
		{
			m_TableName="BDCDJ.ZD_LQ";
			m_HisTableName="BDCDJ.ZD_LQ_LS";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsZDLQSet";
		}
		public static clsZDLQSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsZDLQSet clsSet = new clsZDLQSet(); //(clsZDLQSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsZDLQSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsZDLQ obj = (clsZDLQ)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("ZDDM")) datarow["ZDDM"] = obj.ZDDM;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("YSDM")) datarow["YSDM"] = obj.YSDM;
				if(datarow.Table.Columns.Contains("ZDTZM")) datarow["ZDTZM"] = obj.ZDTZM;
				if(datarow.Table.Columns.Contains("ZL")) datarow["ZL"] = obj.ZL;
				if(datarow.Table.Columns.Contains("ZDMJ")) datarow["ZDMJ"] = obj.ZDMJ;
				if(datarow.Table.Columns.Contains("MJDW")) datarow["MJDW"] = obj.MJDW;
				if(datarow.Table.Columns.Contains("YT")) datarow["YT"] = obj.YT;
				if(datarow.Table.Columns.Contains("DJ")) datarow["DJ"] = obj.DJ;
				if(datarow.Table.Columns.Contains("JG")) datarow["JG"] = obj.JG;
				if(datarow.Table.Columns.Contains("QLLX")) datarow["QLLX"] = obj.QLLX;
				if(datarow.Table.Columns.Contains("QLXZ")) datarow["QLXZ"] = obj.QLXZ;
				if(datarow.Table.Columns.Contains("QLSDFS")) datarow["QLSDFS"] = obj.QLSDFS;
				if(datarow.Table.Columns.Contains("RJL")) datarow["RJL"] = obj.RJL;
				if(datarow.Table.Columns.Contains("JZMD")) datarow["JZMD"] = obj.JZMD;
				if(datarow.Table.Columns.Contains("JZXG")) datarow["JZXG"] = obj.JZXG;
				if(datarow.Table.Columns.Contains("ZDSZD")) datarow["ZDSZD"] = obj.ZDSZD;
				if(datarow.Table.Columns.Contains("ZDSZN")) datarow["ZDSZN"] = obj.ZDSZN;
				if(datarow.Table.Columns.Contains("ZDSZX")) datarow["ZDSZX"] = obj.ZDSZX;
				if(datarow.Table.Columns.Contains("ZDSZB")) datarow["ZDSZB"] = obj.ZDSZB;
				if(datarow.Table.Columns.Contains("ZDT")) datarow["ZDT"] = obj.ZDT;
				if(datarow.Table.Columns.Contains("TFH")) datarow["TFH"] = obj.TFH;
				if(datarow.Table.Columns.Contains("DJH")) datarow["DJH"] = obj.DJH;
				if(datarow.Table.Columns.Contains("ZT")) datarow["ZT"] = obj.ZT;
				if(datarow.Table.Columns.Contains("YZDBH")) datarow["YZDBH"] = obj.YZDBH;
				if(datarow.Table.Columns.Contains("YTDYT")) datarow["YTDYT"] = obj.YTDYT;
				if(datarow.Table.Columns.Contains("TDSYQR")) datarow["TDSYQR"] = obj.TDSYQR;
				if(datarow.Table.Columns.Contains("JZMJ")) datarow["JZMJ"] = obj.JZMJ;
				if(datarow.Table.Columns.Contains("JZWZDMJ")) datarow["JZWZDMJ"] = obj.JZWZDMJ;
				if(datarow.Table.Columns.Contains("SCMJ")) datarow["SCMJ"] = obj.SCMJ;
				if(datarow.Table.Columns.Contains("FZMJ")) datarow["FZMJ"] = obj.FZMJ;
				if(datarow.Table.Columns.Contains("ZYSZ")) datarow["ZYSZ"] = obj.ZYSZ;
				if(datarow.Table.Columns.Contains("ZS")) datarow["ZS"] = obj.ZS;
				if(datarow.Table.Columns.Contains("LZ")) datarow["LZ"] = obj.LZ;
				if(datarow.Table.Columns.Contains("QY")) datarow["QY"] = obj.QY;
				if(datarow.Table.Columns.Contains("ZLND")) datarow["ZLND"] = obj.ZLND;
				if(datarow.Table.Columns.Contains("LB")) datarow["LB"] = obj.LB;
				if(datarow.Table.Columns.Contains("XB")) datarow["XB"] = obj.XB;
				if(datarow.Table.Columns.Contains("XDM")) datarow["XDM"] = obj.XDM;
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
				if (obj.SYQQSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("SYQQSSJ")) datarow["SYQQSSJ"] = obj.SYQQSSJ;
				}
				if (obj.SYQJSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("SYQJSSJ")) datarow["SYQJSSJ"] = obj.SYQJSSJ;
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
			clsZDLQ obj = null;
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
					obj = new clsZDLQ();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="ZDDM")
								if (pRow.Table.Columns.Contains("ZDDM") && pRow["ZDDM"] != DBNull.Value) { obj.ZDDM = Convert.ToString(pRow["ZDDM"]); }
							if(strFldName.ToUpper()=="BDCDYH")
								if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
							if(strFldName.ToUpper()=="YSDM")
								if (pRow.Table.Columns.Contains("YSDM") && pRow["YSDM"] != DBNull.Value) { obj.YSDM = Convert.ToString(pRow["YSDM"]); }
							if(strFldName.ToUpper()=="ZDTZM")
								if (pRow.Table.Columns.Contains("ZDTZM") && pRow["ZDTZM"] != DBNull.Value) { obj.ZDTZM = Convert.ToString(pRow["ZDTZM"]); }
							if(strFldName.ToUpper()=="ZL")
								if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
							if(strFldName.ToUpper()=="ZDMJ")
								if (pRow.Table.Columns.Contains("ZDMJ") && pRow["ZDMJ"] != DBNull.Value) { obj.ZDMJ = Convert.ToDouble(pRow["ZDMJ"]); }
							if(strFldName.ToUpper()=="MJDW")
								if (pRow.Table.Columns.Contains("MJDW") && pRow["MJDW"] != DBNull.Value) { obj.MJDW = Convert.ToString(pRow["MJDW"]); }
							if(strFldName.ToUpper()=="YT")
								if (pRow.Table.Columns.Contains("YT") && pRow["YT"] != DBNull.Value) { obj.YT = Convert.ToString(pRow["YT"]); }
							if(strFldName.ToUpper()=="DJ")
								if (pRow.Table.Columns.Contains("DJ") && pRow["DJ"] != DBNull.Value) { obj.DJ = Convert.ToString(pRow["DJ"]); }
							if(strFldName.ToUpper()=="JG")
								if (pRow.Table.Columns.Contains("JG") && pRow["JG"] != DBNull.Value) { obj.JG = Convert.ToDouble(pRow["JG"]); }
							if(strFldName.ToUpper()=="QLLX")
								if (pRow.Table.Columns.Contains("QLLX") && pRow["QLLX"] != DBNull.Value) { obj.QLLX = Convert.ToString(pRow["QLLX"]); }
							if(strFldName.ToUpper()=="QLXZ")
								if (pRow.Table.Columns.Contains("QLXZ") && pRow["QLXZ"] != DBNull.Value) { obj.QLXZ = Convert.ToString(pRow["QLXZ"]); }
							if(strFldName.ToUpper()=="QLSDFS")
								if (pRow.Table.Columns.Contains("QLSDFS") && pRow["QLSDFS"] != DBNull.Value) { obj.QLSDFS = Convert.ToString(pRow["QLSDFS"]); }
							if(strFldName.ToUpper()=="RJL")
								if (pRow.Table.Columns.Contains("RJL") && pRow["RJL"] != DBNull.Value) { obj.RJL = Convert.ToDouble(pRow["RJL"]); }
							if(strFldName.ToUpper()=="JZMD")
								if (pRow.Table.Columns.Contains("JZMD") && pRow["JZMD"] != DBNull.Value) { obj.JZMD = Convert.ToDouble(pRow["JZMD"]); }
							if(strFldName.ToUpper()=="JZXG")
								if (pRow.Table.Columns.Contains("JZXG") && pRow["JZXG"] != DBNull.Value) { obj.JZXG = Convert.ToDouble(pRow["JZXG"]); }
							if(strFldName.ToUpper()=="ZDSZD")
								if (pRow.Table.Columns.Contains("ZDSZD") && pRow["ZDSZD"] != DBNull.Value) { obj.ZDSZD = Convert.ToString(pRow["ZDSZD"]); }
							if(strFldName.ToUpper()=="ZDSZN")
								if (pRow.Table.Columns.Contains("ZDSZN") && pRow["ZDSZN"] != DBNull.Value) { obj.ZDSZN = Convert.ToString(pRow["ZDSZN"]); }
							if(strFldName.ToUpper()=="ZDSZX")
								if (pRow.Table.Columns.Contains("ZDSZX") && pRow["ZDSZX"] != DBNull.Value) { obj.ZDSZX = Convert.ToString(pRow["ZDSZX"]); }
							if(strFldName.ToUpper()=="ZDSZB")
								if (pRow.Table.Columns.Contains("ZDSZB") && pRow["ZDSZB"] != DBNull.Value) { obj.ZDSZB = Convert.ToString(pRow["ZDSZB"]); }
							if(strFldName.ToUpper()=="ZDT")
								if (pRow.Table.Columns.Contains("ZDT") && pRow["ZDT"] != DBNull.Value) { obj.ZDT = (byte[])(pRow["ZDT"]); }
							if(strFldName.ToUpper()=="TFH")
								if (pRow.Table.Columns.Contains("TFH") && pRow["TFH"] != DBNull.Value) { obj.TFH = Convert.ToString(pRow["TFH"]); }
							if(strFldName.ToUpper()=="DJH")
								if (pRow.Table.Columns.Contains("DJH") && pRow["DJH"] != DBNull.Value) { obj.DJH = Convert.ToString(pRow["DJH"]); }
							if(strFldName.ToUpper()=="ZT")
								if (pRow.Table.Columns.Contains("ZT") && pRow["ZT"] != DBNull.Value) { obj.ZT = Convert.ToString(pRow["ZT"]); }
							if(strFldName.ToUpper()=="YZDBH")
								if (pRow.Table.Columns.Contains("YZDBH") && pRow["YZDBH"] != DBNull.Value) { obj.YZDBH = Convert.ToString(pRow["YZDBH"]); }
							if(strFldName.ToUpper()=="YTDYT")
								if (pRow.Table.Columns.Contains("YTDYT") && pRow["YTDYT"] != DBNull.Value) { obj.YTDYT = Convert.ToString(pRow["YTDYT"]); }
							if(strFldName.ToUpper()=="TDSYQR")
								if (pRow.Table.Columns.Contains("TDSYQR") && pRow["TDSYQR"] != DBNull.Value) { obj.TDSYQR = Convert.ToString(pRow["TDSYQR"]); }
							if(strFldName.ToUpper()=="JZMJ")
								if (pRow.Table.Columns.Contains("JZMJ") && pRow["JZMJ"] != DBNull.Value) { obj.JZMJ = Convert.ToDouble(pRow["JZMJ"]); }
							if(strFldName.ToUpper()=="JZWZDMJ")
								if (pRow.Table.Columns.Contains("JZWZDMJ") && pRow["JZWZDMJ"] != DBNull.Value) { obj.JZWZDMJ = Convert.ToDouble(pRow["JZWZDMJ"]); }
							if(strFldName.ToUpper()=="SCMJ")
								if (pRow.Table.Columns.Contains("SCMJ") && pRow["SCMJ"] != DBNull.Value) { obj.SCMJ = Convert.ToDouble(pRow["SCMJ"]); }
							if(strFldName.ToUpper()=="FZMJ")
								if (pRow.Table.Columns.Contains("FZMJ") && pRow["FZMJ"] != DBNull.Value) { obj.FZMJ = Convert.ToDouble(pRow["FZMJ"]); }
							if(strFldName.ToUpper()=="ZYSZ")
								if (pRow.Table.Columns.Contains("ZYSZ") && pRow["ZYSZ"] != DBNull.Value) { obj.ZYSZ = Convert.ToString(pRow["ZYSZ"]); }
							if(strFldName.ToUpper()=="ZS")
								if (pRow.Table.Columns.Contains("ZS") && pRow["ZS"] != DBNull.Value) { obj.ZS = Convert.ToInt64(pRow["ZS"]); }
							if(strFldName.ToUpper()=="LZ")
								if (pRow.Table.Columns.Contains("LZ") && pRow["LZ"] != DBNull.Value) { obj.LZ = Convert.ToString(pRow["LZ"]); }
							if(strFldName.ToUpper()=="QY")
								if (pRow.Table.Columns.Contains("QY") && pRow["QY"] != DBNull.Value) { obj.QY = Convert.ToString(pRow["QY"]); }
							if(strFldName.ToUpper()=="ZLND")
								if (pRow.Table.Columns.Contains("ZLND") && pRow["ZLND"] != DBNull.Value) { obj.ZLND = Convert.ToInt64(pRow["ZLND"]); }
							if(strFldName.ToUpper()=="LB")
								if (pRow.Table.Columns.Contains("LB") && pRow["LB"] != DBNull.Value) { obj.LB = Convert.ToString(pRow["LB"]); }
							if(strFldName.ToUpper()=="XB")
								if (pRow.Table.Columns.Contains("XB") && pRow["XB"] != DBNull.Value) { obj.XB = Convert.ToString(pRow["XB"]); }
							if(strFldName.ToUpper()=="XDM")
								if (pRow.Table.Columns.Contains("XDM") && pRow["XDM"] != DBNull.Value) { obj.XDM = Convert.ToString(pRow["XDM"]); }
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
							if(strFldName.ToUpper()=="SYQQSSJ")
								if (pRow.Table.Columns.Contains("SYQQSSJ") && pRow["SYQQSSJ"] != DBNull.Value) { obj.SYQQSSJ = Convert.ToDateTime(pRow["SYQQSSJ"]); }
							if(strFldName.ToUpper()=="SYQJSSJ")
								if (pRow.Table.Columns.Contains("SYQJSSJ") && pRow["SYQJSSJ"] != DBNull.Value) { obj.SYQJSSJ = Convert.ToDateTime(pRow["SYQJSSJ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("ZDDM") && pRow["ZDDM"] != DBNull.Value) { obj.ZDDM = Convert.ToString(pRow["ZDDM"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("YSDM") && pRow["YSDM"] != DBNull.Value) { obj.YSDM = Convert.ToString(pRow["YSDM"]); }
						if (pRow.Table.Columns.Contains("ZDTZM") && pRow["ZDTZM"] != DBNull.Value) { obj.ZDTZM = Convert.ToString(pRow["ZDTZM"]); }
						if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
						if (pRow.Table.Columns.Contains("ZDMJ") && pRow["ZDMJ"] != DBNull.Value) { obj.ZDMJ = Convert.ToDouble(pRow["ZDMJ"]); }
						if (pRow.Table.Columns.Contains("MJDW") && pRow["MJDW"] != DBNull.Value) { obj.MJDW = Convert.ToString(pRow["MJDW"]); }
						if (pRow.Table.Columns.Contains("YT") && pRow["YT"] != DBNull.Value) { obj.YT = Convert.ToString(pRow["YT"]); }
						if (pRow.Table.Columns.Contains("DJ") && pRow["DJ"] != DBNull.Value) { obj.DJ = Convert.ToString(pRow["DJ"]); }
						if (pRow.Table.Columns.Contains("JG") && pRow["JG"] != DBNull.Value) { obj.JG = Convert.ToDouble(pRow["JG"]); }
						if (pRow.Table.Columns.Contains("QLLX") && pRow["QLLX"] != DBNull.Value) { obj.QLLX = Convert.ToString(pRow["QLLX"]); }
						if (pRow.Table.Columns.Contains("QLXZ") && pRow["QLXZ"] != DBNull.Value) { obj.QLXZ = Convert.ToString(pRow["QLXZ"]); }
						if (pRow.Table.Columns.Contains("QLSDFS") && pRow["QLSDFS"] != DBNull.Value) { obj.QLSDFS = Convert.ToString(pRow["QLSDFS"]); }
						if (pRow.Table.Columns.Contains("RJL") && pRow["RJL"] != DBNull.Value) { obj.RJL = Convert.ToDouble(pRow["RJL"]); }
						if (pRow.Table.Columns.Contains("JZMD") && pRow["JZMD"] != DBNull.Value) { obj.JZMD = Convert.ToDouble(pRow["JZMD"]); }
						if (pRow.Table.Columns.Contains("JZXG") && pRow["JZXG"] != DBNull.Value) { obj.JZXG = Convert.ToDouble(pRow["JZXG"]); }
						if (pRow.Table.Columns.Contains("ZDSZD") && pRow["ZDSZD"] != DBNull.Value) { obj.ZDSZD = Convert.ToString(pRow["ZDSZD"]); }
						if (pRow.Table.Columns.Contains("ZDSZN") && pRow["ZDSZN"] != DBNull.Value) { obj.ZDSZN = Convert.ToString(pRow["ZDSZN"]); }
						if (pRow.Table.Columns.Contains("ZDSZX") && pRow["ZDSZX"] != DBNull.Value) { obj.ZDSZX = Convert.ToString(pRow["ZDSZX"]); }
						if (pRow.Table.Columns.Contains("ZDSZB") && pRow["ZDSZB"] != DBNull.Value) { obj.ZDSZB = Convert.ToString(pRow["ZDSZB"]); }
						if (pRow.Table.Columns.Contains("ZDT") && pRow["ZDT"] != DBNull.Value) { obj.ZDT = (byte[])(pRow["ZDT"]); }
						if (pRow.Table.Columns.Contains("TFH") && pRow["TFH"] != DBNull.Value) { obj.TFH = Convert.ToString(pRow["TFH"]); }
						if (pRow.Table.Columns.Contains("DJH") && pRow["DJH"] != DBNull.Value) { obj.DJH = Convert.ToString(pRow["DJH"]); }
						if (pRow.Table.Columns.Contains("ZT") && pRow["ZT"] != DBNull.Value) { obj.ZT = Convert.ToString(pRow["ZT"]); }
						if (pRow.Table.Columns.Contains("YZDBH") && pRow["YZDBH"] != DBNull.Value) { obj.YZDBH = Convert.ToString(pRow["YZDBH"]); }
						if (pRow.Table.Columns.Contains("YTDYT") && pRow["YTDYT"] != DBNull.Value) { obj.YTDYT = Convert.ToString(pRow["YTDYT"]); }
						if (pRow.Table.Columns.Contains("TDSYQR") && pRow["TDSYQR"] != DBNull.Value) { obj.TDSYQR = Convert.ToString(pRow["TDSYQR"]); }
						if (pRow.Table.Columns.Contains("JZMJ") && pRow["JZMJ"] != DBNull.Value) { obj.JZMJ = Convert.ToDouble(pRow["JZMJ"]); }
						if (pRow.Table.Columns.Contains("JZWZDMJ") && pRow["JZWZDMJ"] != DBNull.Value) { obj.JZWZDMJ = Convert.ToDouble(pRow["JZWZDMJ"]); }
						if (pRow.Table.Columns.Contains("SCMJ") && pRow["SCMJ"] != DBNull.Value) { obj.SCMJ = Convert.ToDouble(pRow["SCMJ"]); }
						if (pRow.Table.Columns.Contains("FZMJ") && pRow["FZMJ"] != DBNull.Value) { obj.FZMJ = Convert.ToDouble(pRow["FZMJ"]); }
						if (pRow.Table.Columns.Contains("ZYSZ") && pRow["ZYSZ"] != DBNull.Value) { obj.ZYSZ = Convert.ToString(pRow["ZYSZ"]); }
						if (pRow.Table.Columns.Contains("ZS") && pRow["ZS"] != DBNull.Value) { obj.ZS = Convert.ToInt64(pRow["ZS"]); }
						if (pRow.Table.Columns.Contains("LZ") && pRow["LZ"] != DBNull.Value) { obj.LZ = Convert.ToString(pRow["LZ"]); }
						if (pRow.Table.Columns.Contains("QY") && pRow["QY"] != DBNull.Value) { obj.QY = Convert.ToString(pRow["QY"]); }
						if (pRow.Table.Columns.Contains("ZLND") && pRow["ZLND"] != DBNull.Value) { obj.ZLND = Convert.ToInt64(pRow["ZLND"]); }
						if (pRow.Table.Columns.Contains("LB") && pRow["LB"] != DBNull.Value) { obj.LB = Convert.ToString(pRow["LB"]); }
						if (pRow.Table.Columns.Contains("XB") && pRow["XB"] != DBNull.Value) { obj.XB = Convert.ToString(pRow["XB"]); }
						if (pRow.Table.Columns.Contains("XDM") && pRow["XDM"] != DBNull.Value) { obj.XDM = Convert.ToString(pRow["XDM"]); }
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
						if (pRow.Table.Columns.Contains("SYQQSSJ") && pRow["SYQQSSJ"] != DBNull.Value) { obj.SYQQSSJ = Convert.ToDateTime(pRow["SYQQSSJ"]); }
						if (pRow.Table.Columns.Contains("SYQJSSJ") && pRow["SYQJSSJ"] != DBNull.Value) { obj.SYQJSSJ = Convert.ToDateTime(pRow["SYQJSSJ"]); }
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
