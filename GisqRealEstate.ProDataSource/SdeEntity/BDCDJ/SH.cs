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

	public class Fld_SH
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string QLBM="QLBM";
		public const string QLBSM="QLBSM";
		public const string LCDM="LCDM";
		public const string SHLX="SHLX";
		public const string QLLX="QLLX";
		public const string DJLX="DJLX";
		public const string QLRMC="QLRMC";
		public const string QLRZJZL="QLRZJZL";
		public const string QLRZJH="QLRZJH";
		public const string QLRTXDZ="QLRTXDZ";
		public const string QLRYB="QLRYB";
		public const string QLRFRMC="QLRFRMC";
		public const string QLRFRDH="QLRFRDH";
		public const string QLRDLRMC="QLRDLRMC";
		public const string QLRDLRDH="QLRDLRDH";
		public const string QLRDLJG="QLRDLJG";
		public const string YWRMC="YWRMC";
		public const string YWRZJZL="YWRZJZL";
		public const string YWRZJH="YWRZJH";
		public const string YWRTXDZ="YWRTXDZ";
		public const string YWRYB="YWRYB";
		public const string YWRFRMC="YWRFRMC";
		public const string YWRFRDH="YWRFRDH";
		public const string YWRDLRMC="YWRDLRMC";
		public const string YWRDLRDH="YWRDLRDH";
		public const string YWRDLJG="YWRDLJG";
		public const string BDCDYH="BDCDYH";
		public const string ZL="ZL";
		public const string BDCLX="BDCLX";
		public const string MJ="MJ";
		public const string YT="YT";
		public const string QLXZ="QLXZ";
		public const string GYQK="GYQK";
		public const string SYQX="SYQX";
		public const string FWJG="FWJG";
		public const string SZC="SZC";
		public const string ZCS="ZCS";
		public const string FWFTMJ="FWFTMJ";
		public const string LZ="LZ";
		public const string YHLX="YHLX";
		public const string GZWLX="GZWLX";
		public const string YBDCQZH="YBDCQZH";
		public const string DYFS="DYFS";
		public const string DYSX="DYSX";
		public const string BDBZQSE="BDBZQSE";
		public const string ZWLXQXQSSJ="ZWLXQXQSSJ";
		public const string ZWLXQXJSSJ="ZWLXQXJSSJ";
		public const string ZJJZWDYFW="ZJJZWDYFW";
		public const string LYMD="LYMD";
		public const string LYFF="LYFF";
		public const string LYQXQSSJ="LYQXQSSJ";
		public const string LYQXJSSJ="LYQXJSSJ";
		public const string XYDBDCQZH="XYDBDCQZH";
		public const string SLR="SLR";
		public const string SLSJ="SLSJ";
		public const string SLYJ="SLYJ";
		public const string SLRSGZH="SLRSGZH";
		public const string SLRBSM="SLRBSM";
		public const string CSR="CSR";
		public const string CSRSGZH="CSRSGZH";
		public const string CSRBSM="CSRBSM";
		public const string CSYJ="CSYJ";
		public const string CSSJ="CSSJ";
		public const string FSR="FSR";
		public const string FSRSGZH="FSRSGZH";
		public const string FSRBSM="FSRBSM";
		public const string FSYJ="FSYJ";
		public const string FSSJ="FSSJ";
		public const string HDR="HDR";
		public const string HDRSGZH="HDRSGZH";
		public const string HDRBSM="HDRBSM";
		public const string HDYJ="HDYJ";
		public const string HDSJ="HDSJ";
		public const string DBR="DBR";
		public const string DBRSGZH="DBRSGZH";
		public const string DBRBSM="DBRBSM";
		public const string DBNR="DBNR";
		public const string DBSJ="DBSJ";
		public const string DJYY="DJYY";
		public const string GGR="GGR";
		public const string GGRSGZH="GGRSGZH";
		public const string GGRBSM="GGRBSM";
		public const string GGSJ="GGSJ";
		public const string GGKSSJ="GGKSSJ";
		public const string GGJSSJ="GGJSSJ";
		public const string GGNR="GGNR";
		public const string GGJG="GGJG";
		public const string GDRY="GDRY";
		public const string GDSJ="GDSJ";
		public const string GDRSGZH="GDRSGZH";
		public const string GDRBSM="GDRBSM";
		public const string SBH="SBH";
		public const string BZ="BZ";
		public const string QSZT="QSZT";
		public const string YXTBM="YXTBM";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string BZ_YZDQLRID="BZ_YZDQLRID";
		public const string BZ_ADD1="BZ_ADD1";
		public const string BZ_ZDQLR_ID="BZ_ZDQLR_ID";
		public const string YQLRID="YQLRID";
		public const string BZ_JBSHR="BZ_JBSHR";
		public const string BZ_YQLRID="BZ_YQLRID";
		public const string BZ_DY_ID="BZ_DY_ID";
		public const string DY_ZT="DY_ZT";
		public const string BZ_DY_ZT="BZ_DY_ZT";
		public const string BZ_CF_ID="BZ_CF_ID";
		public const string BZ_GXSJ="BZ_GXSJ";
		public const string YGDJZL="YGDJZL";
		public const string SZCZCS="SZCZCS";
		public const string GXSJ="GXSJ";
		public const string SLRQZBSM="SLRQZBSM";
		public const string CSRQZBSM="CSRQZBSM";
		public const string FSRQZBSM="FSRQZBSM";
		public const string HDRQZBSM="HDRQZBSM";
		public const string DBRQZBSM="DBRQZBSM";
		public const string YXTBSM="YXTBSM";
		public const string FSR1="FSR1";
		public const string FSR2="FSR2";
		public const string QSDCTDMJ="QSDCTDMJ";
		public const string QSDCFTMJ="QSDCFTMJ";
		public const string QSDCDYMJ="QSDCDYMJ";
		public const string QSDCJZMJ="QSDCJZMJ";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsSH:IEntity
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
		private string m_QLBM;
		private long m_QLBSM;
		private string m_LCDM;
		private string m_SHLX;
		private string m_QLLX;
		private string m_DJLX;
		private string m_QLRMC;
		private string m_QLRZJZL;
		private string m_QLRZJH;
		private string m_QLRTXDZ;
		private string m_QLRYB;
		private string m_QLRFRMC;
		private string m_QLRFRDH;
		private string m_QLRDLRMC;
		private string m_QLRDLRDH;
		private string m_QLRDLJG;
		private string m_YWRMC;
		private string m_YWRZJZL;
		private string m_YWRZJH;
		private string m_YWRTXDZ;
		private string m_YWRYB;
		private string m_YWRFRMC;
		private string m_YWRFRDH;
		private string m_YWRDLRMC;
		private string m_YWRDLRDH;
		private string m_YWRDLJG;
		private string m_BDCDYH;
		private string m_ZL;
		private string m_BDCLX;
		private string m_MJ;
		private string m_YT;
		private string m_QLXZ;
		private string m_GYQK;
		private string m_SYQX;
		private string m_FWJG;
		private string m_SZC;
		private string m_ZCS;
		private string m_FWFTMJ;
		private string m_LZ;
		private string m_YHLX;
		private string m_GZWLX;
		private string m_YBDCQZH;
		private string m_DYFS;
		private string m_DYSX;
		private string m_BDBZQSE;
		private DateTime m_ZWLXQXQSSJ;
		private DateTime m_ZWLXQXJSSJ;
		private string m_ZJJZWDYFW;
		private string m_LYMD;
		private string m_LYFF;
		private DateTime m_LYQXQSSJ;
		private DateTime m_LYQXJSSJ;
		private string m_XYDBDCQZH;
		private string m_SLR;
		private DateTime m_SLSJ;
		private string m_SLYJ;
		private string m_SLRSGZH;
		private string m_SLRBSM;
		private string m_CSR;
		private string m_CSRSGZH;
		private string m_CSRBSM;
		private string m_CSYJ;
		private DateTime m_CSSJ;
		private string m_FSR;
		private string m_FSRSGZH;
		private string m_FSRBSM;
		private string m_FSYJ;
		private DateTime m_FSSJ;
		private string m_HDR;
		private string m_HDRSGZH;
		private string m_HDRBSM;
		private string m_HDYJ;
		private DateTime m_HDSJ;
		private string m_DBR;
		private string m_DBRSGZH;
		private string m_DBRBSM;
		private string m_DBNR;
		private DateTime m_DBSJ;
		private string m_DJYY;
		private string m_GGR;
		private string m_GGRSGZH;
		private string m_GGRBSM;
		private DateTime m_GGSJ;
		private DateTime m_GGKSSJ;
		private DateTime m_GGJSSJ;
		private string m_GGNR;
		private string m_GGJG;
		private string m_GDRY;
		private DateTime m_GDSJ;
		private string m_GDRSGZH;
		private string m_GDRBSM;
		private string m_SBH;
		private string m_BZ;
		private string m_QSZT;
		private string m_YXTBM;
		private long m_QXDM;
		private long m_REV_;

		private string m_YGDJZL;
		private string m_SZCZCS;
		private DateTime m_GXSJ;
		private long m_SLRQZBSM;
		private long m_CSRQZBSM;
		private long m_FSRQZBSM;
		private long m_HDRQZBSM;
		private long m_DBRQZBSM;
		private string m_YXTBSM;
		private string m_QSDCTDMJ;
		private string m_QSDCFTMJ;
		private string m_QSDCDYMJ;
		private string m_QSDCJZMJ;
		private long m_BG_BB;

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
		public string QLBM
		{
			get{ return m_QLBM; }
			set{ m_QLBM = value; }
		}
		public long QLBSM
		{
			get{ return m_QLBSM; }
			set{ m_QLBSM = value; }
		}
		public string LCDM
		{
			get{ return m_LCDM; }
			set{ m_LCDM = value; }
		}
		public string SHLX
		{
			get{ return m_SHLX; }
			set{ m_SHLX = value; }
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
		public string QLRMC
		{
			get{ return m_QLRMC; }
			set{ m_QLRMC = value; }
		}
		public string QLRZJZL
		{
			get{ return m_QLRZJZL; }
			set{ m_QLRZJZL = value; }
		}
		public string QLRZJH
		{
			get{ return m_QLRZJH; }
			set{ m_QLRZJH = value; }
		}
		public string QLRTXDZ
		{
			get{ return m_QLRTXDZ; }
			set{ m_QLRTXDZ = value; }
		}
		public string QLRYB
		{
			get{ return m_QLRYB; }
			set{ m_QLRYB = value; }
		}
		public string QLRFRMC
		{
			get{ return m_QLRFRMC; }
			set{ m_QLRFRMC = value; }
		}
		public string QLRFRDH
		{
			get{ return m_QLRFRDH; }
			set{ m_QLRFRDH = value; }
		}
		public string QLRDLRMC
		{
			get{ return m_QLRDLRMC; }
			set{ m_QLRDLRMC = value; }
		}
		public string QLRDLRDH
		{
			get{ return m_QLRDLRDH; }
			set{ m_QLRDLRDH = value; }
		}
		public string QLRDLJG
		{
			get{ return m_QLRDLJG; }
			set{ m_QLRDLJG = value; }
		}
		public string YWRMC
		{
			get{ return m_YWRMC; }
			set{ m_YWRMC = value; }
		}
		public string YWRZJZL
		{
			get{ return m_YWRZJZL; }
			set{ m_YWRZJZL = value; }
		}
		public string YWRZJH
		{
			get{ return m_YWRZJH; }
			set{ m_YWRZJH = value; }
		}
		public string YWRTXDZ
		{
			get{ return m_YWRTXDZ; }
			set{ m_YWRTXDZ = value; }
		}
		public string YWRYB
		{
			get{ return m_YWRYB; }
			set{ m_YWRYB = value; }
		}
		public string YWRFRMC
		{
			get{ return m_YWRFRMC; }
			set{ m_YWRFRMC = value; }
		}
		public string YWRFRDH
		{
			get{ return m_YWRFRDH; }
			set{ m_YWRFRDH = value; }
		}
		public string YWRDLRMC
		{
			get{ return m_YWRDLRMC; }
			set{ m_YWRDLRMC = value; }
		}
		public string YWRDLRDH
		{
			get{ return m_YWRDLRDH; }
			set{ m_YWRDLRDH = value; }
		}
		public string YWRDLJG
		{
			get{ return m_YWRDLJG; }
			set{ m_YWRDLJG = value; }
		}
		public string BDCDYH
		{
			get{ return m_BDCDYH; }
			set{ m_BDCDYH = value; }
		}
		public string ZL
		{
			get{ return m_ZL; }
			set{ m_ZL = value; }
		}
		public string BDCLX
		{
			get{ return m_BDCLX; }
			set{ m_BDCLX = value; }
		}
		public string MJ
		{
			get{ return m_MJ; }
			set{ m_MJ = value; }
		}
		public string YT
		{
			get{ return m_YT; }
			set{ m_YT = value; }
		}
		public string QLXZ
		{
			get{ return m_QLXZ; }
			set{ m_QLXZ = value; }
		}
		public string GYQK
		{
			get{ return m_GYQK; }
			set{ m_GYQK = value; }
		}
		public string SYQX
		{
			get{ return m_SYQX; }
			set{ m_SYQX = value; }
		}
		public string FWJG
		{
			get{ return m_FWJG; }
			set{ m_FWJG = value; }
		}
		public string SZC
		{
			get{ return m_SZC; }
			set{ m_SZC = value; }
		}
		public string ZCS
		{
			get{ return m_ZCS; }
			set{ m_ZCS = value; }
		}
		public string FWFTMJ
		{
			get{ return m_FWFTMJ; }
			set{ m_FWFTMJ = value; }
		}
		public string LZ
		{
			get{ return m_LZ; }
			set{ m_LZ = value; }
		}
		public string YHLX
		{
			get{ return m_YHLX; }
			set{ m_YHLX = value; }
		}
		public string GZWLX
		{
			get{ return m_GZWLX; }
			set{ m_GZWLX = value; }
		}
		public string YBDCQZH
		{
			get{ return m_YBDCQZH; }
			set{ m_YBDCQZH = value; }
		}
		public string DYFS
		{
			get{ return m_DYFS; }
			set{ m_DYFS = value; }
		}
		public string DYSX
		{
			get{ return m_DYSX; }
			set{ m_DYSX = value; }
		}
		public string BDBZQSE
		{
			get{ return m_BDBZQSE; }
			set{ m_BDBZQSE = value; }
		}
		public DateTime ZWLXQXQSSJ
		{
			get{ return m_ZWLXQXQSSJ; }
			set{ m_ZWLXQXQSSJ = value; }
		}
		public DateTime ZWLXQXJSSJ
		{
			get{ return m_ZWLXQXJSSJ; }
			set{ m_ZWLXQXJSSJ = value; }
		}
		public string ZJJZWDYFW
		{
			get{ return m_ZJJZWDYFW; }
			set{ m_ZJJZWDYFW = value; }
		}
		public string LYMD
		{
			get{ return m_LYMD; }
			set{ m_LYMD = value; }
		}
		public string LYFF
		{
			get{ return m_LYFF; }
			set{ m_LYFF = value; }
		}
		public DateTime LYQXQSSJ
		{
			get{ return m_LYQXQSSJ; }
			set{ m_LYQXQSSJ = value; }
		}
		public DateTime LYQXJSSJ
		{
			get{ return m_LYQXJSSJ; }
			set{ m_LYQXJSSJ = value; }
		}
		public string XYDBDCQZH
		{
			get{ return m_XYDBDCQZH; }
			set{ m_XYDBDCQZH = value; }
		}
		public string SLR
		{
			get{ return m_SLR; }
			set{ m_SLR = value; }
		}
		public DateTime SLSJ
		{
			get{ return m_SLSJ; }
			set{ m_SLSJ = value; }
		}
		public string SLYJ
		{
			get{ return m_SLYJ; }
			set{ m_SLYJ = value; }
		}
		public string SLRSGZH
		{
			get{ return m_SLRSGZH; }
			set{ m_SLRSGZH = value; }
		}
		public string SLRBSM
		{
			get{ return m_SLRBSM; }
			set{ m_SLRBSM = value; }
		}
		public string CSR
		{
			get{ return m_CSR; }
			set{ m_CSR = value; }
		}
		public string CSRSGZH
		{
			get{ return m_CSRSGZH; }
			set{ m_CSRSGZH = value; }
		}
		public string CSRBSM
		{
			get{ return m_CSRBSM; }
			set{ m_CSRBSM = value; }
		}
		public string CSYJ
		{
			get{ return m_CSYJ; }
			set{ m_CSYJ = value; }
		}
		public DateTime CSSJ
		{
			get{ return m_CSSJ; }
			set{ m_CSSJ = value; }
		}
		public string FSR
		{
			get{ return m_FSR; }
			set{ m_FSR = value; }
		}
		public string FSRSGZH
		{
			get{ return m_FSRSGZH; }
			set{ m_FSRSGZH = value; }
		}
		public string FSRBSM
		{
			get{ return m_FSRBSM; }
			set{ m_FSRBSM = value; }
		}
		public string FSYJ
		{
			get{ return m_FSYJ; }
			set{ m_FSYJ = value; }
		}
		public DateTime FSSJ
		{
			get{ return m_FSSJ; }
			set{ m_FSSJ = value; }
		}
		public string HDR
		{
			get{ return m_HDR; }
			set{ m_HDR = value; }
		}
		public string HDRSGZH
		{
			get{ return m_HDRSGZH; }
			set{ m_HDRSGZH = value; }
		}
		public string HDRBSM
		{
			get{ return m_HDRBSM; }
			set{ m_HDRBSM = value; }
		}
		public string HDYJ
		{
			get{ return m_HDYJ; }
			set{ m_HDYJ = value; }
		}
		public DateTime HDSJ
		{
			get{ return m_HDSJ; }
			set{ m_HDSJ = value; }
		}
		public string DBR
		{
			get{ return m_DBR; }
			set{ m_DBR = value; }
		}
		public string DBRSGZH
		{
			get{ return m_DBRSGZH; }
			set{ m_DBRSGZH = value; }
		}
		public string DBRBSM
		{
			get{ return m_DBRBSM; }
			set{ m_DBRBSM = value; }
		}
		public string DBNR
		{
			get{ return m_DBNR; }
			set{ m_DBNR = value; }
		}
		public DateTime DBSJ
		{
			get{ return m_DBSJ; }
			set{ m_DBSJ = value; }
		}
		public string DJYY
		{
			get{ return m_DJYY; }
			set{ m_DJYY = value; }
		}
		public string GGR
		{
			get{ return m_GGR; }
			set{ m_GGR = value; }
		}
		public string GGRSGZH
		{
			get{ return m_GGRSGZH; }
			set{ m_GGRSGZH = value; }
		}
		public string GGRBSM
		{
			get{ return m_GGRBSM; }
			set{ m_GGRBSM = value; }
		}
		public DateTime GGSJ
		{
			get{ return m_GGSJ; }
			set{ m_GGSJ = value; }
		}
		public DateTime GGKSSJ
		{
			get{ return m_GGKSSJ; }
			set{ m_GGKSSJ = value; }
		}
		public DateTime GGJSSJ
		{
			get{ return m_GGJSSJ; }
			set{ m_GGJSSJ = value; }
		}
		public string GGNR
		{
			get{ return m_GGNR; }
			set{ m_GGNR = value; }
		}
		public string GGJG
		{
			get{ return m_GGJG; }
			set{ m_GGJG = value; }
		}
		public string GDRY
		{
			get{ return m_GDRY; }
			set{ m_GDRY = value; }
		}
		public DateTime GDSJ
		{
			get{ return m_GDSJ; }
			set{ m_GDSJ = value; }
		}
		public string GDRSGZH
		{
			get{ return m_GDRSGZH; }
			set{ m_GDRSGZH = value; }
		}
		public string GDRBSM
		{
			get{ return m_GDRBSM; }
			set{ m_GDRBSM = value; }
		}
		public string SBH
		{
			get{ return m_SBH; }
			set{ m_SBH = value; }
		}
		public string BZ
		{
			get{ return m_BZ; }
			set{ m_BZ = value; }
		}
		public string QSZT
		{
			get{ return m_QSZT; }
			set{ m_QSZT = value; }
		}
		public string YXTBM
		{
			get{ return m_YXTBM; }
			set{ m_YXTBM = value; }
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
		public string YGDJZL
		{
			get{ return m_YGDJZL; }
			set{ m_YGDJZL = value; }
		}
		public string SZCZCS
		{
			get{ return m_SZCZCS; }
			set{ m_SZCZCS = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		public long SLRQZBSM
		{
			get{ return m_SLRQZBSM; }
			set{ m_SLRQZBSM = value; }
		}
		public long CSRQZBSM
		{
			get{ return m_CSRQZBSM; }
			set{ m_CSRQZBSM = value; }
		}
		public long FSRQZBSM
		{
			get{ return m_FSRQZBSM; }
			set{ m_FSRQZBSM = value; }
		}
		public long HDRQZBSM
		{
			get{ return m_HDRQZBSM; }
			set{ m_HDRQZBSM = value; }
		}
		public long DBRQZBSM
		{
			get{ return m_DBRQZBSM; }
			set{ m_DBRQZBSM = value; }
		}
		public string YXTBSM
		{
			get{ return m_YXTBSM; }
			set{ m_YXTBSM = value; }
		}
		
		public string QSDCTDMJ
		{
			get{ return m_QSDCTDMJ; }
			set{ m_QSDCTDMJ = value; }
		}
		public string QSDCFTMJ
		{
			get{ return m_QSDCFTMJ; }
			set{ m_QSDCFTMJ = value; }
		}
		public string QSDCDYMJ
		{
			get{ return m_QSDCDYMJ; }
			set{ m_QSDCDYMJ = value; }
		}
		public string QSDCJZMJ
		{
			get{ return m_QSDCJZMJ; }
			set{ m_QSDCJZMJ = value; }
		}
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

		#endregion
		public bool IsEquals(clsSH obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.QLBM != obj.QLBM) bolResult = false;
			if (this.QLBSM != obj.QLBSM) bolResult = false;
			if (this.LCDM != obj.LCDM) bolResult = false;
			if (this.SHLX != obj.SHLX) bolResult = false;
			if (this.QLLX != obj.QLLX) bolResult = false;
			if (this.DJLX != obj.DJLX) bolResult = false;
			if (this.QLRMC != obj.QLRMC) bolResult = false;
			if (this.QLRZJZL != obj.QLRZJZL) bolResult = false;
			if (this.QLRZJH != obj.QLRZJH) bolResult = false;
			if (this.QLRTXDZ != obj.QLRTXDZ) bolResult = false;
			if (this.QLRYB != obj.QLRYB) bolResult = false;
			if (this.QLRFRMC != obj.QLRFRMC) bolResult = false;
			if (this.QLRFRDH != obj.QLRFRDH) bolResult = false;
			if (this.QLRDLRMC != obj.QLRDLRMC) bolResult = false;
			if (this.QLRDLRDH != obj.QLRDLRDH) bolResult = false;
			if (this.QLRDLJG != obj.QLRDLJG) bolResult = false;
			if (this.YWRMC != obj.YWRMC) bolResult = false;
			if (this.YWRZJZL != obj.YWRZJZL) bolResult = false;
			if (this.YWRZJH != obj.YWRZJH) bolResult = false;
			if (this.YWRTXDZ != obj.YWRTXDZ) bolResult = false;
			if (this.YWRYB != obj.YWRYB) bolResult = false;
			if (this.YWRFRMC != obj.YWRFRMC) bolResult = false;
			if (this.YWRFRDH != obj.YWRFRDH) bolResult = false;
			if (this.YWRDLRMC != obj.YWRDLRMC) bolResult = false;
			if (this.YWRDLRDH != obj.YWRDLRDH) bolResult = false;
			if (this.YWRDLJG != obj.YWRDLJG) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.ZL != obj.ZL) bolResult = false;
			if (this.BDCLX != obj.BDCLX) bolResult = false;
			if (this.MJ != obj.MJ) bolResult = false;
			if (this.YT != obj.YT) bolResult = false;
			if (this.QLXZ != obj.QLXZ) bolResult = false;
			if (this.GYQK != obj.GYQK) bolResult = false;
			if (this.SYQX != obj.SYQX) bolResult = false;
			if (this.FWJG != obj.FWJG) bolResult = false;
			if (this.SZC != obj.SZC) bolResult = false;
			if (this.ZCS != obj.ZCS) bolResult = false;
			if (this.FWFTMJ != obj.FWFTMJ) bolResult = false;
			if (this.LZ != obj.LZ) bolResult = false;
			if (this.YHLX != obj.YHLX) bolResult = false;
			if (this.GZWLX != obj.GZWLX) bolResult = false;
			if (this.YBDCQZH != obj.YBDCQZH) bolResult = false;
			if (this.DYFS != obj.DYFS) bolResult = false;
			if (this.DYSX != obj.DYSX) bolResult = false;
			if (this.BDBZQSE != obj.BDBZQSE) bolResult = false;
			if (this.ZWLXQXQSSJ != obj.ZWLXQXQSSJ) bolResult = false;
			if (this.ZWLXQXJSSJ != obj.ZWLXQXJSSJ) bolResult = false;
			if (this.ZJJZWDYFW != obj.ZJJZWDYFW) bolResult = false;
			if (this.LYMD != obj.LYMD) bolResult = false;
			if (this.LYFF != obj.LYFF) bolResult = false;
			if (this.LYQXQSSJ != obj.LYQXQSSJ) bolResult = false;
			if (this.LYQXJSSJ != obj.LYQXJSSJ) bolResult = false;
			if (this.XYDBDCQZH != obj.XYDBDCQZH) bolResult = false;
			if (this.SLR != obj.SLR) bolResult = false;
			if (this.SLSJ != obj.SLSJ) bolResult = false;
			if (this.SLYJ != obj.SLYJ) bolResult = false;
			if (this.SLRSGZH != obj.SLRSGZH) bolResult = false;
			if (this.SLRBSM != obj.SLRBSM) bolResult = false;
			if (this.CSR != obj.CSR) bolResult = false;
			if (this.CSRSGZH != obj.CSRSGZH) bolResult = false;
			if (this.CSRBSM != obj.CSRBSM) bolResult = false;
			if (this.CSYJ != obj.CSYJ) bolResult = false;
			if (this.CSSJ != obj.CSSJ) bolResult = false;
			if (this.FSR != obj.FSR) bolResult = false;
			if (this.FSRSGZH != obj.FSRSGZH) bolResult = false;
			if (this.FSRBSM != obj.FSRBSM) bolResult = false;
			if (this.FSYJ != obj.FSYJ) bolResult = false;
			if (this.FSSJ != obj.FSSJ) bolResult = false;
			if (this.HDR != obj.HDR) bolResult = false;
			if (this.HDRSGZH != obj.HDRSGZH) bolResult = false;
			if (this.HDRBSM != obj.HDRBSM) bolResult = false;
			if (this.HDYJ != obj.HDYJ) bolResult = false;
			if (this.HDSJ != obj.HDSJ) bolResult = false;
			if (this.DBR != obj.DBR) bolResult = false;
			if (this.DBRSGZH != obj.DBRSGZH) bolResult = false;
			if (this.DBRBSM != obj.DBRBSM) bolResult = false;
			if (this.DBNR != obj.DBNR) bolResult = false;
			if (this.DBSJ != obj.DBSJ) bolResult = false;
			if (this.DJYY != obj.DJYY) bolResult = false;
			if (this.GGR != obj.GGR) bolResult = false;
			if (this.GGRSGZH != obj.GGRSGZH) bolResult = false;
			if (this.GGRBSM != obj.GGRBSM) bolResult = false;
			if (this.GGSJ != obj.GGSJ) bolResult = false;
			if (this.GGKSSJ != obj.GGKSSJ) bolResult = false;
			if (this.GGJSSJ != obj.GGJSSJ) bolResult = false;
			if (this.GGNR != obj.GGNR) bolResult = false;
			if (this.GGJG != obj.GGJG) bolResult = false;
			if (this.GDRY != obj.GDRY) bolResult = false;
			if (this.GDSJ != obj.GDSJ) bolResult = false;
			if (this.GDRSGZH != obj.GDRSGZH) bolResult = false;
			if (this.GDRBSM != obj.GDRBSM) bolResult = false;
			if (this.SBH != obj.SBH) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
		
			if (this.YGDJZL != obj.YGDJZL) bolResult = false;
			if (this.SZCZCS != obj.SZCZCS) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.SLRQZBSM != obj.SLRQZBSM) bolResult = false;
			if (this.CSRQZBSM != obj.CSRQZBSM) bolResult = false;
			if (this.FSRQZBSM != obj.FSRQZBSM) bolResult = false;
			if (this.HDRQZBSM != obj.HDRQZBSM) bolResult = false;
			if (this.DBRQZBSM != obj.DBRQZBSM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.QSDCTDMJ != obj.QSDCTDMJ) bolResult = false;
			if (this.QSDCFTMJ != obj.QSDCFTMJ) bolResult = false;
			if (this.QSDCDYMJ != obj.QSDCDYMJ) bolResult = false;
			if (this.QSDCJZMJ != obj.QSDCJZMJ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsSH obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.QLBM=obj.QLBM;
			this.QLBSM=obj.QLBSM;
			this.LCDM=obj.LCDM;
			this.SHLX=obj.SHLX;
			this.QLLX=obj.QLLX;
			this.DJLX=obj.DJLX;
			this.QLRMC=obj.QLRMC;
			this.QLRZJZL=obj.QLRZJZL;
			this.QLRZJH=obj.QLRZJH;
			this.QLRTXDZ=obj.QLRTXDZ;
			this.QLRYB=obj.QLRYB;
			this.QLRFRMC=obj.QLRFRMC;
			this.QLRFRDH=obj.QLRFRDH;
			this.QLRDLRMC=obj.QLRDLRMC;
			this.QLRDLRDH=obj.QLRDLRDH;
			this.QLRDLJG=obj.QLRDLJG;
			this.YWRMC=obj.YWRMC;
			this.YWRZJZL=obj.YWRZJZL;
			this.YWRZJH=obj.YWRZJH;
			this.YWRTXDZ=obj.YWRTXDZ;
			this.YWRYB=obj.YWRYB;
			this.YWRFRMC=obj.YWRFRMC;
			this.YWRFRDH=obj.YWRFRDH;
			this.YWRDLRMC=obj.YWRDLRMC;
			this.YWRDLRDH=obj.YWRDLRDH;
			this.YWRDLJG=obj.YWRDLJG;
			this.BDCDYH=obj.BDCDYH;
			this.ZL=obj.ZL;
			this.BDCLX=obj.BDCLX;
			this.MJ=obj.MJ;
			this.YT=obj.YT;
			this.QLXZ=obj.QLXZ;
			this.GYQK=obj.GYQK;
			this.SYQX=obj.SYQX;
			this.FWJG=obj.FWJG;
			this.SZC=obj.SZC;
			this.ZCS=obj.ZCS;
			this.FWFTMJ=obj.FWFTMJ;
			this.LZ=obj.LZ;
			this.YHLX=obj.YHLX;
			this.GZWLX=obj.GZWLX;
			this.YBDCQZH=obj.YBDCQZH;
			this.DYFS=obj.DYFS;
			this.DYSX=obj.DYSX;
			this.BDBZQSE=obj.BDBZQSE;
			this.ZWLXQXQSSJ=obj.ZWLXQXQSSJ;
			this.ZWLXQXJSSJ=obj.ZWLXQXJSSJ;
			this.ZJJZWDYFW=obj.ZJJZWDYFW;
			this.LYMD=obj.LYMD;
			this.LYFF=obj.LYFF;
			this.LYQXQSSJ=obj.LYQXQSSJ;
			this.LYQXJSSJ=obj.LYQXJSSJ;
			this.XYDBDCQZH=obj.XYDBDCQZH;
			this.SLR=obj.SLR;
			this.SLSJ=obj.SLSJ;
			this.SLYJ=obj.SLYJ;
			this.SLRSGZH=obj.SLRSGZH;
			this.SLRBSM=obj.SLRBSM;
			this.CSR=obj.CSR;
			this.CSRSGZH=obj.CSRSGZH;
			this.CSRBSM=obj.CSRBSM;
			this.CSYJ=obj.CSYJ;
			this.CSSJ=obj.CSSJ;
			this.FSR=obj.FSR;
			this.FSRSGZH=obj.FSRSGZH;
			this.FSRBSM=obj.FSRBSM;
			this.FSYJ=obj.FSYJ;
			this.FSSJ=obj.FSSJ;
			this.HDR=obj.HDR;
			this.HDRSGZH=obj.HDRSGZH;
			this.HDRBSM=obj.HDRBSM;
			this.HDYJ=obj.HDYJ;
			this.HDSJ=obj.HDSJ;
			this.DBR=obj.DBR;
			this.DBRSGZH=obj.DBRSGZH;
			this.DBRBSM=obj.DBRBSM;
			this.DBNR=obj.DBNR;
			this.DBSJ=obj.DBSJ;
			this.DJYY=obj.DJYY;
			this.GGR=obj.GGR;
			this.GGRSGZH=obj.GGRSGZH;
			this.GGRBSM=obj.GGRBSM;
			this.GGSJ=obj.GGSJ;
			this.GGKSSJ=obj.GGKSSJ;
			this.GGJSSJ=obj.GGJSSJ;
			this.GGNR=obj.GGNR;
			this.GGJG=obj.GGJG;
			this.GDRY=obj.GDRY;
			this.GDSJ=obj.GDSJ;
			this.GDRSGZH=obj.GDRSGZH;
			this.GDRBSM=obj.GDRBSM;
			this.SBH=obj.SBH;
			this.BZ=obj.BZ;
			this.QSZT=obj.QSZT;
			this.YXTBM=obj.YXTBM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;

			this.YGDJZL=obj.YGDJZL;
			this.SZCZCS=obj.SZCZCS;
			this.GXSJ=obj.GXSJ;
			this.SLRQZBSM=obj.SLRQZBSM;
			this.CSRQZBSM=obj.CSRQZBSM;
			this.FSRQZBSM=obj.FSRQZBSM;
			this.HDRQZBSM=obj.HDRQZBSM;
			this.DBRQZBSM=obj.DBRQZBSM;
			this.YXTBSM=obj.YXTBSM;
			this.QSDCTDMJ=obj.QSDCTDMJ;
			this.QSDCFTMJ=obj.QSDCFTMJ;
			this.QSDCDYMJ=obj.QSDCDYMJ;
			this.QSDCJZMJ=obj.QSDCJZMJ;
		}

	}

	public class clsSHSet:EntityBaseSet
	{
		public clsSHSet()
		{
			m_TableName="BDCDJ.SH";
			m_HisTableName="BDCDJ.SH_LS";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsSHSet";
		}
		public static clsSHSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsSHSet clsSet = new clsSHSet(); //(clsSHSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsSHSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsSH obj = (clsSH)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("QLBM")) datarow["QLBM"] = obj.QLBM;
				if(datarow.Table.Columns.Contains("QLBSM")) datarow["QLBSM"] = obj.QLBSM;
				if(datarow.Table.Columns.Contains("LCDM")) datarow["LCDM"] = obj.LCDM;
				if(datarow.Table.Columns.Contains("SHLX")) datarow["SHLX"] = obj.SHLX;
				if(datarow.Table.Columns.Contains("QLLX")) datarow["QLLX"] = obj.QLLX;
				if(datarow.Table.Columns.Contains("DJLX")) datarow["DJLX"] = obj.DJLX;
				if(datarow.Table.Columns.Contains("QLRMC")) datarow["QLRMC"] = obj.QLRMC;
				if(datarow.Table.Columns.Contains("QLRZJZL")) datarow["QLRZJZL"] = obj.QLRZJZL;
				if(datarow.Table.Columns.Contains("QLRZJH")) datarow["QLRZJH"] = obj.QLRZJH;
				if(datarow.Table.Columns.Contains("QLRTXDZ")) datarow["QLRTXDZ"] = obj.QLRTXDZ;
				if(datarow.Table.Columns.Contains("QLRYB")) datarow["QLRYB"] = obj.QLRYB;
				if(datarow.Table.Columns.Contains("QLRFRMC")) datarow["QLRFRMC"] = obj.QLRFRMC;
				if(datarow.Table.Columns.Contains("QLRFRDH")) datarow["QLRFRDH"] = obj.QLRFRDH;
				if(datarow.Table.Columns.Contains("QLRDLRMC")) datarow["QLRDLRMC"] = obj.QLRDLRMC;
				if(datarow.Table.Columns.Contains("QLRDLRDH")) datarow["QLRDLRDH"] = obj.QLRDLRDH;
				if(datarow.Table.Columns.Contains("QLRDLJG")) datarow["QLRDLJG"] = obj.QLRDLJG;
				if(datarow.Table.Columns.Contains("YWRMC")) datarow["YWRMC"] = obj.YWRMC;
				if(datarow.Table.Columns.Contains("YWRZJZL")) datarow["YWRZJZL"] = obj.YWRZJZL;
				if(datarow.Table.Columns.Contains("YWRZJH")) datarow["YWRZJH"] = obj.YWRZJH;
				if(datarow.Table.Columns.Contains("YWRTXDZ")) datarow["YWRTXDZ"] = obj.YWRTXDZ;
				if(datarow.Table.Columns.Contains("YWRYB")) datarow["YWRYB"] = obj.YWRYB;
				if(datarow.Table.Columns.Contains("YWRFRMC")) datarow["YWRFRMC"] = obj.YWRFRMC;
				if(datarow.Table.Columns.Contains("YWRFRDH")) datarow["YWRFRDH"] = obj.YWRFRDH;
				if(datarow.Table.Columns.Contains("YWRDLRMC")) datarow["YWRDLRMC"] = obj.YWRDLRMC;
				if(datarow.Table.Columns.Contains("YWRDLRDH")) datarow["YWRDLRDH"] = obj.YWRDLRDH;
				if(datarow.Table.Columns.Contains("YWRDLJG")) datarow["YWRDLJG"] = obj.YWRDLJG;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("ZL")) datarow["ZL"] = obj.ZL;
				if(datarow.Table.Columns.Contains("BDCLX")) datarow["BDCLX"] = obj.BDCLX;
				if(datarow.Table.Columns.Contains("MJ")) datarow["MJ"] = obj.MJ;
				if(datarow.Table.Columns.Contains("YT")) datarow["YT"] = obj.YT;
				if(datarow.Table.Columns.Contains("QLXZ")) datarow["QLXZ"] = obj.QLXZ;
				if(datarow.Table.Columns.Contains("GYQK")) datarow["GYQK"] = obj.GYQK;
				if(datarow.Table.Columns.Contains("SYQX")) datarow["SYQX"] = obj.SYQX;
				if(datarow.Table.Columns.Contains("FWJG")) datarow["FWJG"] = obj.FWJG;
				if(datarow.Table.Columns.Contains("SZC")) datarow["SZC"] = obj.SZC;
				if(datarow.Table.Columns.Contains("ZCS")) datarow["ZCS"] = obj.ZCS;
				if(datarow.Table.Columns.Contains("FWFTMJ")) datarow["FWFTMJ"] = obj.FWFTMJ;
				if(datarow.Table.Columns.Contains("LZ")) datarow["LZ"] = obj.LZ;
				if(datarow.Table.Columns.Contains("YHLX")) datarow["YHLX"] = obj.YHLX;
				if(datarow.Table.Columns.Contains("GZWLX")) datarow["GZWLX"] = obj.GZWLX;
				if(datarow.Table.Columns.Contains("YBDCQZH")) datarow["YBDCQZH"] = obj.YBDCQZH;
				if(datarow.Table.Columns.Contains("DYFS")) datarow["DYFS"] = obj.DYFS;
				if(datarow.Table.Columns.Contains("DYSX")) datarow["DYSX"] = obj.DYSX;
				if(datarow.Table.Columns.Contains("BDBZQSE")) datarow["BDBZQSE"] = obj.BDBZQSE;
				if (obj.ZWLXQXQSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("ZWLXQXQSSJ")) datarow["ZWLXQXQSSJ"] = obj.ZWLXQXQSSJ;
				}
				if (obj.ZWLXQXJSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("ZWLXQXJSSJ")) datarow["ZWLXQXJSSJ"] = obj.ZWLXQXJSSJ;
				}
				if(datarow.Table.Columns.Contains("ZJJZWDYFW")) datarow["ZJJZWDYFW"] = obj.ZJJZWDYFW;
				if(datarow.Table.Columns.Contains("LYMD")) datarow["LYMD"] = obj.LYMD;
				if(datarow.Table.Columns.Contains("LYFF")) datarow["LYFF"] = obj.LYFF;
				if (obj.LYQXQSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("LYQXQSSJ")) datarow["LYQXQSSJ"] = obj.LYQXQSSJ;
				}
				if (obj.LYQXJSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("LYQXJSSJ")) datarow["LYQXJSSJ"] = obj.LYQXJSSJ;
				}
				if(datarow.Table.Columns.Contains("XYDBDCQZH")) datarow["XYDBDCQZH"] = obj.XYDBDCQZH;
				if(datarow.Table.Columns.Contains("SLR")) datarow["SLR"] = obj.SLR;
				if (obj.SLSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("SLSJ")) datarow["SLSJ"] = obj.SLSJ;
				}
				if(datarow.Table.Columns.Contains("SLYJ")) datarow["SLYJ"] = obj.SLYJ;
				if(datarow.Table.Columns.Contains("SLRSGZH")) datarow["SLRSGZH"] = obj.SLRSGZH;
				if(datarow.Table.Columns.Contains("SLRBSM")) datarow["SLRBSM"] = obj.SLRBSM;
				if(datarow.Table.Columns.Contains("CSR")) datarow["CSR"] = obj.CSR;
				if(datarow.Table.Columns.Contains("CSRSGZH")) datarow["CSRSGZH"] = obj.CSRSGZH;
				if(datarow.Table.Columns.Contains("CSRBSM")) datarow["CSRBSM"] = obj.CSRBSM;
				if(datarow.Table.Columns.Contains("CSYJ")) datarow["CSYJ"] = obj.CSYJ;
				if (obj.CSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("CSSJ")) datarow["CSSJ"] = obj.CSSJ;
				}
				if(datarow.Table.Columns.Contains("FSR")) datarow["FSR"] = obj.FSR;
				if(datarow.Table.Columns.Contains("FSRSGZH")) datarow["FSRSGZH"] = obj.FSRSGZH;
				if(datarow.Table.Columns.Contains("FSRBSM")) datarow["FSRBSM"] = obj.FSRBSM;
				if(datarow.Table.Columns.Contains("FSYJ")) datarow["FSYJ"] = obj.FSYJ;
				if (obj.FSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("FSSJ")) datarow["FSSJ"] = obj.FSSJ;
				}
				if(datarow.Table.Columns.Contains("HDR")) datarow["HDR"] = obj.HDR;
				if(datarow.Table.Columns.Contains("HDRSGZH")) datarow["HDRSGZH"] = obj.HDRSGZH;
				if(datarow.Table.Columns.Contains("HDRBSM")) datarow["HDRBSM"] = obj.HDRBSM;
				if(datarow.Table.Columns.Contains("HDYJ")) datarow["HDYJ"] = obj.HDYJ;
				if (obj.HDSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("HDSJ")) datarow["HDSJ"] = obj.HDSJ;
				}
				if(datarow.Table.Columns.Contains("DBR")) datarow["DBR"] = obj.DBR;
				if(datarow.Table.Columns.Contains("DBRSGZH")) datarow["DBRSGZH"] = obj.DBRSGZH;
				if(datarow.Table.Columns.Contains("DBRBSM")) datarow["DBRBSM"] = obj.DBRBSM;
				if(datarow.Table.Columns.Contains("DBNR")) datarow["DBNR"] = obj.DBNR;
				if (obj.DBSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("DBSJ")) datarow["DBSJ"] = obj.DBSJ;
				}
				if(datarow.Table.Columns.Contains("DJYY")) datarow["DJYY"] = obj.DJYY;
				if(datarow.Table.Columns.Contains("GGR")) datarow["GGR"] = obj.GGR;
				if(datarow.Table.Columns.Contains("GGRSGZH")) datarow["GGRSGZH"] = obj.GGRSGZH;
				if(datarow.Table.Columns.Contains("GGRBSM")) datarow["GGRBSM"] = obj.GGRBSM;
				if (obj.GGSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GGSJ")) datarow["GGSJ"] = obj.GGSJ;
				}
				if (obj.GGKSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GGKSSJ")) datarow["GGKSSJ"] = obj.GGKSSJ;
				}
				if (obj.GGJSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GGJSSJ")) datarow["GGJSSJ"] = obj.GGJSSJ;
				}
				if(datarow.Table.Columns.Contains("GGNR")) datarow["GGNR"] = obj.GGNR;
				if(datarow.Table.Columns.Contains("GGJG")) datarow["GGJG"] = obj.GGJG;
				if(datarow.Table.Columns.Contains("GDRY")) datarow["GDRY"] = obj.GDRY;
				if (obj.GDSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GDSJ")) datarow["GDSJ"] = obj.GDSJ;
				}
				if(datarow.Table.Columns.Contains("GDRSGZH")) datarow["GDRSGZH"] = obj.GDRSGZH;
				if(datarow.Table.Columns.Contains("GDRBSM")) datarow["GDRBSM"] = obj.GDRBSM;
				if(datarow.Table.Columns.Contains("SBH")) datarow["SBH"] = obj.SBH;
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;

				if(datarow.Table.Columns.Contains("YGDJZL")) datarow["YGDJZL"] = obj.YGDJZL;
				if(datarow.Table.Columns.Contains("SZCZCS")) datarow["SZCZCS"] = obj.SZCZCS;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("SLRQZBSM")) datarow["SLRQZBSM"] = obj.SLRQZBSM;
				if(datarow.Table.Columns.Contains("CSRQZBSM")) datarow["CSRQZBSM"] = obj.CSRQZBSM;
				if(datarow.Table.Columns.Contains("FSRQZBSM")) datarow["FSRQZBSM"] = obj.FSRQZBSM;
				if(datarow.Table.Columns.Contains("HDRQZBSM")) datarow["HDRQZBSM"] = obj.HDRQZBSM;
				if(datarow.Table.Columns.Contains("DBRQZBSM")) datarow["DBRQZBSM"] = obj.DBRQZBSM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("QSDCTDMJ")) datarow["QSDCTDMJ"] = obj.QSDCTDMJ;
				if(datarow.Table.Columns.Contains("QSDCFTMJ")) datarow["QSDCFTMJ"] = obj.QSDCFTMJ;
				if(datarow.Table.Columns.Contains("QSDCDYMJ")) datarow["QSDCDYMJ"] = obj.QSDCDYMJ;
				if(datarow.Table.Columns.Contains("QSDCJZMJ")) datarow["QSDCJZMJ"] = obj.QSDCJZMJ;
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
			clsSH obj = null;
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
					obj = new clsSH();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="QLBM")
								if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
							if(strFldName.ToUpper()=="QLBSM")
								if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
							if(strFldName.ToUpper()=="LCDM")
								if (pRow.Table.Columns.Contains("LCDM") && pRow["LCDM"] != DBNull.Value) { obj.LCDM = Convert.ToString(pRow["LCDM"]); }
							if(strFldName.ToUpper()=="SHLX")
								if (pRow.Table.Columns.Contains("SHLX") && pRow["SHLX"] != DBNull.Value) { obj.SHLX = Convert.ToString(pRow["SHLX"]); }
							if(strFldName.ToUpper()=="QLLX")
								if (pRow.Table.Columns.Contains("QLLX") && pRow["QLLX"] != DBNull.Value) { obj.QLLX = Convert.ToString(pRow["QLLX"]); }
							if(strFldName.ToUpper()=="DJLX")
								if (pRow.Table.Columns.Contains("DJLX") && pRow["DJLX"] != DBNull.Value) { obj.DJLX = Convert.ToString(pRow["DJLX"]); }
							if(strFldName.ToUpper()=="QLRMC")
								if (pRow.Table.Columns.Contains("QLRMC") && pRow["QLRMC"] != DBNull.Value) { obj.QLRMC = Convert.ToString(pRow["QLRMC"]); }
							if(strFldName.ToUpper()=="QLRZJZL")
								if (pRow.Table.Columns.Contains("QLRZJZL") && pRow["QLRZJZL"] != DBNull.Value) { obj.QLRZJZL = Convert.ToString(pRow["QLRZJZL"]); }
							if(strFldName.ToUpper()=="QLRZJH")
								if (pRow.Table.Columns.Contains("QLRZJH") && pRow["QLRZJH"] != DBNull.Value) { obj.QLRZJH = Convert.ToString(pRow["QLRZJH"]); }
							if(strFldName.ToUpper()=="QLRTXDZ")
								if (pRow.Table.Columns.Contains("QLRTXDZ") && pRow["QLRTXDZ"] != DBNull.Value) { obj.QLRTXDZ = Convert.ToString(pRow["QLRTXDZ"]); }
							if(strFldName.ToUpper()=="QLRYB")
								if (pRow.Table.Columns.Contains("QLRYB") && pRow["QLRYB"] != DBNull.Value) { obj.QLRYB = Convert.ToString(pRow["QLRYB"]); }
							if(strFldName.ToUpper()=="QLRFRMC")
								if (pRow.Table.Columns.Contains("QLRFRMC") && pRow["QLRFRMC"] != DBNull.Value) { obj.QLRFRMC = Convert.ToString(pRow["QLRFRMC"]); }
							if(strFldName.ToUpper()=="QLRFRDH")
								if (pRow.Table.Columns.Contains("QLRFRDH") && pRow["QLRFRDH"] != DBNull.Value) { obj.QLRFRDH = Convert.ToString(pRow["QLRFRDH"]); }
							if(strFldName.ToUpper()=="QLRDLRMC")
								if (pRow.Table.Columns.Contains("QLRDLRMC") && pRow["QLRDLRMC"] != DBNull.Value) { obj.QLRDLRMC = Convert.ToString(pRow["QLRDLRMC"]); }
							if(strFldName.ToUpper()=="QLRDLRDH")
								if (pRow.Table.Columns.Contains("QLRDLRDH") && pRow["QLRDLRDH"] != DBNull.Value) { obj.QLRDLRDH = Convert.ToString(pRow["QLRDLRDH"]); }
							if(strFldName.ToUpper()=="QLRDLJG")
								if (pRow.Table.Columns.Contains("QLRDLJG") && pRow["QLRDLJG"] != DBNull.Value) { obj.QLRDLJG = Convert.ToString(pRow["QLRDLJG"]); }
							if(strFldName.ToUpper()=="YWRMC")
								if (pRow.Table.Columns.Contains("YWRMC") && pRow["YWRMC"] != DBNull.Value) { obj.YWRMC = Convert.ToString(pRow["YWRMC"]); }
							if(strFldName.ToUpper()=="YWRZJZL")
								if (pRow.Table.Columns.Contains("YWRZJZL") && pRow["YWRZJZL"] != DBNull.Value) { obj.YWRZJZL = Convert.ToString(pRow["YWRZJZL"]); }
							if(strFldName.ToUpper()=="YWRZJH")
								if (pRow.Table.Columns.Contains("YWRZJH") && pRow["YWRZJH"] != DBNull.Value) { obj.YWRZJH = Convert.ToString(pRow["YWRZJH"]); }
							if(strFldName.ToUpper()=="YWRTXDZ")
								if (pRow.Table.Columns.Contains("YWRTXDZ") && pRow["YWRTXDZ"] != DBNull.Value) { obj.YWRTXDZ = Convert.ToString(pRow["YWRTXDZ"]); }
							if(strFldName.ToUpper()=="YWRYB")
								if (pRow.Table.Columns.Contains("YWRYB") && pRow["YWRYB"] != DBNull.Value) { obj.YWRYB = Convert.ToString(pRow["YWRYB"]); }
							if(strFldName.ToUpper()=="YWRFRMC")
								if (pRow.Table.Columns.Contains("YWRFRMC") && pRow["YWRFRMC"] != DBNull.Value) { obj.YWRFRMC = Convert.ToString(pRow["YWRFRMC"]); }
							if(strFldName.ToUpper()=="YWRFRDH")
								if (pRow.Table.Columns.Contains("YWRFRDH") && pRow["YWRFRDH"] != DBNull.Value) { obj.YWRFRDH = Convert.ToString(pRow["YWRFRDH"]); }
							if(strFldName.ToUpper()=="YWRDLRMC")
								if (pRow.Table.Columns.Contains("YWRDLRMC") && pRow["YWRDLRMC"] != DBNull.Value) { obj.YWRDLRMC = Convert.ToString(pRow["YWRDLRMC"]); }
							if(strFldName.ToUpper()=="YWRDLRDH")
								if (pRow.Table.Columns.Contains("YWRDLRDH") && pRow["YWRDLRDH"] != DBNull.Value) { obj.YWRDLRDH = Convert.ToString(pRow["YWRDLRDH"]); }
							if(strFldName.ToUpper()=="YWRDLJG")
								if (pRow.Table.Columns.Contains("YWRDLJG") && pRow["YWRDLJG"] != DBNull.Value) { obj.YWRDLJG = Convert.ToString(pRow["YWRDLJG"]); }
							if(strFldName.ToUpper()=="BDCDYH")
								if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
							if(strFldName.ToUpper()=="ZL")
								if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
							if(strFldName.ToUpper()=="BDCLX")
								if (pRow.Table.Columns.Contains("BDCLX") && pRow["BDCLX"] != DBNull.Value) { obj.BDCLX = Convert.ToString(pRow["BDCLX"]); }
							if(strFldName.ToUpper()=="MJ")
								if (pRow.Table.Columns.Contains("MJ") && pRow["MJ"] != DBNull.Value) { obj.MJ = Convert.ToString(pRow["MJ"]); }
							if(strFldName.ToUpper()=="YT")
								if (pRow.Table.Columns.Contains("YT") && pRow["YT"] != DBNull.Value) { obj.YT = Convert.ToString(pRow["YT"]); }
							if(strFldName.ToUpper()=="QLXZ")
								if (pRow.Table.Columns.Contains("QLXZ") && pRow["QLXZ"] != DBNull.Value) { obj.QLXZ = Convert.ToString(pRow["QLXZ"]); }
							if(strFldName.ToUpper()=="GYQK")
								if (pRow.Table.Columns.Contains("GYQK") && pRow["GYQK"] != DBNull.Value) { obj.GYQK = Convert.ToString(pRow["GYQK"]); }
							if(strFldName.ToUpper()=="SYQX")
								if (pRow.Table.Columns.Contains("SYQX") && pRow["SYQX"] != DBNull.Value) { obj.SYQX = Convert.ToString(pRow["SYQX"]); }
							if(strFldName.ToUpper()=="FWJG")
								if (pRow.Table.Columns.Contains("FWJG") && pRow["FWJG"] != DBNull.Value) { obj.FWJG = Convert.ToString(pRow["FWJG"]); }
							if(strFldName.ToUpper()=="SZC")
								if (pRow.Table.Columns.Contains("SZC") && pRow["SZC"] != DBNull.Value) { obj.SZC = Convert.ToString(pRow["SZC"]); }
							if(strFldName.ToUpper()=="ZCS")
								if (pRow.Table.Columns.Contains("ZCS") && pRow["ZCS"] != DBNull.Value) { obj.ZCS = Convert.ToString(pRow["ZCS"]); }
							if(strFldName.ToUpper()=="FWFTMJ")
								if (pRow.Table.Columns.Contains("FWFTMJ") && pRow["FWFTMJ"] != DBNull.Value) { obj.FWFTMJ = Convert.ToString(pRow["FWFTMJ"]); }
							if(strFldName.ToUpper()=="LZ")
								if (pRow.Table.Columns.Contains("LZ") && pRow["LZ"] != DBNull.Value) { obj.LZ = Convert.ToString(pRow["LZ"]); }
							if(strFldName.ToUpper()=="YHLX")
								if (pRow.Table.Columns.Contains("YHLX") && pRow["YHLX"] != DBNull.Value) { obj.YHLX = Convert.ToString(pRow["YHLX"]); }
							if(strFldName.ToUpper()=="GZWLX")
								if (pRow.Table.Columns.Contains("GZWLX") && pRow["GZWLX"] != DBNull.Value) { obj.GZWLX = Convert.ToString(pRow["GZWLX"]); }
							if(strFldName.ToUpper()=="YBDCQZH")
								if (pRow.Table.Columns.Contains("YBDCQZH") && pRow["YBDCQZH"] != DBNull.Value) { obj.YBDCQZH = Convert.ToString(pRow["YBDCQZH"]); }
							if(strFldName.ToUpper()=="DYFS")
								if (pRow.Table.Columns.Contains("DYFS") && pRow["DYFS"] != DBNull.Value) { obj.DYFS = Convert.ToString(pRow["DYFS"]); }
							if(strFldName.ToUpper()=="DYSX")
								if (pRow.Table.Columns.Contains("DYSX") && pRow["DYSX"] != DBNull.Value) { obj.DYSX = Convert.ToString(pRow["DYSX"]); }
							if(strFldName.ToUpper()=="BDBZQSE")
								if (pRow.Table.Columns.Contains("BDBZQSE") && pRow["BDBZQSE"] != DBNull.Value) { obj.BDBZQSE = Convert.ToString(pRow["BDBZQSE"]); }
							if(strFldName.ToUpper()=="ZWLXQXQSSJ")
								if (pRow.Table.Columns.Contains("ZWLXQXQSSJ") && pRow["ZWLXQXQSSJ"] != DBNull.Value) { obj.ZWLXQXQSSJ = Convert.ToDateTime(pRow["ZWLXQXQSSJ"]); }
							if(strFldName.ToUpper()=="ZWLXQXJSSJ")
								if (pRow.Table.Columns.Contains("ZWLXQXJSSJ") && pRow["ZWLXQXJSSJ"] != DBNull.Value) { obj.ZWLXQXJSSJ = Convert.ToDateTime(pRow["ZWLXQXJSSJ"]); }
							if(strFldName.ToUpper()=="ZJJZWDYFW")
								if (pRow.Table.Columns.Contains("ZJJZWDYFW") && pRow["ZJJZWDYFW"] != DBNull.Value) { obj.ZJJZWDYFW = Convert.ToString(pRow["ZJJZWDYFW"]); }
							if(strFldName.ToUpper()=="LYMD")
								if (pRow.Table.Columns.Contains("LYMD") && pRow["LYMD"] != DBNull.Value) { obj.LYMD = Convert.ToString(pRow["LYMD"]); }
							if(strFldName.ToUpper()=="LYFF")
								if (pRow.Table.Columns.Contains("LYFF") && pRow["LYFF"] != DBNull.Value) { obj.LYFF = Convert.ToString(pRow["LYFF"]); }
							if(strFldName.ToUpper()=="LYQXQSSJ")
								if (pRow.Table.Columns.Contains("LYQXQSSJ") && pRow["LYQXQSSJ"] != DBNull.Value) { obj.LYQXQSSJ = Convert.ToDateTime(pRow["LYQXQSSJ"]); }
							if(strFldName.ToUpper()=="LYQXJSSJ")
								if (pRow.Table.Columns.Contains("LYQXJSSJ") && pRow["LYQXJSSJ"] != DBNull.Value) { obj.LYQXJSSJ = Convert.ToDateTime(pRow["LYQXJSSJ"]); }
							if(strFldName.ToUpper()=="XYDBDCQZH")
								if (pRow.Table.Columns.Contains("XYDBDCQZH") && pRow["XYDBDCQZH"] != DBNull.Value) { obj.XYDBDCQZH = Convert.ToString(pRow["XYDBDCQZH"]); }
							if(strFldName.ToUpper()=="SLR")
								if (pRow.Table.Columns.Contains("SLR") && pRow["SLR"] != DBNull.Value) { obj.SLR = Convert.ToString(pRow["SLR"]); }
							if(strFldName.ToUpper()=="SLSJ")
								if (pRow.Table.Columns.Contains("SLSJ") && pRow["SLSJ"] != DBNull.Value) { obj.SLSJ = Convert.ToDateTime(pRow["SLSJ"]); }
							if(strFldName.ToUpper()=="SLYJ")
								if (pRow.Table.Columns.Contains("SLYJ") && pRow["SLYJ"] != DBNull.Value) { obj.SLYJ = Convert.ToString(pRow["SLYJ"]); }
							if(strFldName.ToUpper()=="SLRSGZH")
								if (pRow.Table.Columns.Contains("SLRSGZH") && pRow["SLRSGZH"] != DBNull.Value) { obj.SLRSGZH = Convert.ToString(pRow["SLRSGZH"]); }
							if(strFldName.ToUpper()=="SLRBSM")
								if (pRow.Table.Columns.Contains("SLRBSM") && pRow["SLRBSM"] != DBNull.Value) { obj.SLRBSM = Convert.ToString(pRow["SLRBSM"]); }
							if(strFldName.ToUpper()=="CSR")
								if (pRow.Table.Columns.Contains("CSR") && pRow["CSR"] != DBNull.Value) { obj.CSR = Convert.ToString(pRow["CSR"]); }
							if(strFldName.ToUpper()=="CSRSGZH")
								if (pRow.Table.Columns.Contains("CSRSGZH") && pRow["CSRSGZH"] != DBNull.Value) { obj.CSRSGZH = Convert.ToString(pRow["CSRSGZH"]); }
							if(strFldName.ToUpper()=="CSRBSM")
								if (pRow.Table.Columns.Contains("CSRBSM") && pRow["CSRBSM"] != DBNull.Value) { obj.CSRBSM = Convert.ToString(pRow["CSRBSM"]); }
							if(strFldName.ToUpper()=="CSYJ")
								if (pRow.Table.Columns.Contains("CSYJ") && pRow["CSYJ"] != DBNull.Value) { obj.CSYJ = Convert.ToString(pRow["CSYJ"]); }
							if(strFldName.ToUpper()=="CSSJ")
								if (pRow.Table.Columns.Contains("CSSJ") && pRow["CSSJ"] != DBNull.Value) { obj.CSSJ = Convert.ToDateTime(pRow["CSSJ"]); }
							if(strFldName.ToUpper()=="FSR")
								if (pRow.Table.Columns.Contains("FSR") && pRow["FSR"] != DBNull.Value) { obj.FSR = Convert.ToString(pRow["FSR"]); }
							if(strFldName.ToUpper()=="FSRSGZH")
								if (pRow.Table.Columns.Contains("FSRSGZH") && pRow["FSRSGZH"] != DBNull.Value) { obj.FSRSGZH = Convert.ToString(pRow["FSRSGZH"]); }
							if(strFldName.ToUpper()=="FSRBSM")
								if (pRow.Table.Columns.Contains("FSRBSM") && pRow["FSRBSM"] != DBNull.Value) { obj.FSRBSM = Convert.ToString(pRow["FSRBSM"]); }
							if(strFldName.ToUpper()=="FSYJ")
								if (pRow.Table.Columns.Contains("FSYJ") && pRow["FSYJ"] != DBNull.Value) { obj.FSYJ = Convert.ToString(pRow["FSYJ"]); }
							if(strFldName.ToUpper()=="FSSJ")
								if (pRow.Table.Columns.Contains("FSSJ") && pRow["FSSJ"] != DBNull.Value) { obj.FSSJ = Convert.ToDateTime(pRow["FSSJ"]); }
							if(strFldName.ToUpper()=="HDR")
								if (pRow.Table.Columns.Contains("HDR") && pRow["HDR"] != DBNull.Value) { obj.HDR = Convert.ToString(pRow["HDR"]); }
							if(strFldName.ToUpper()=="HDRSGZH")
								if (pRow.Table.Columns.Contains("HDRSGZH") && pRow["HDRSGZH"] != DBNull.Value) { obj.HDRSGZH = Convert.ToString(pRow["HDRSGZH"]); }
							if(strFldName.ToUpper()=="HDRBSM")
								if (pRow.Table.Columns.Contains("HDRBSM") && pRow["HDRBSM"] != DBNull.Value) { obj.HDRBSM = Convert.ToString(pRow["HDRBSM"]); }
							if(strFldName.ToUpper()=="HDYJ")
								if (pRow.Table.Columns.Contains("HDYJ") && pRow["HDYJ"] != DBNull.Value) { obj.HDYJ = Convert.ToString(pRow["HDYJ"]); }
							if(strFldName.ToUpper()=="HDSJ")
								if (pRow.Table.Columns.Contains("HDSJ") && pRow["HDSJ"] != DBNull.Value) { obj.HDSJ = Convert.ToDateTime(pRow["HDSJ"]); }
							if(strFldName.ToUpper()=="DBR")
								if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
							if(strFldName.ToUpper()=="DBRSGZH")
								if (pRow.Table.Columns.Contains("DBRSGZH") && pRow["DBRSGZH"] != DBNull.Value) { obj.DBRSGZH = Convert.ToString(pRow["DBRSGZH"]); }
							if(strFldName.ToUpper()=="DBRBSM")
								if (pRow.Table.Columns.Contains("DBRBSM") && pRow["DBRBSM"] != DBNull.Value) { obj.DBRBSM = Convert.ToString(pRow["DBRBSM"]); }
							if(strFldName.ToUpper()=="DBNR")
								if (pRow.Table.Columns.Contains("DBNR") && pRow["DBNR"] != DBNull.Value) { obj.DBNR = Convert.ToString(pRow["DBNR"]); }
							if(strFldName.ToUpper()=="DBSJ")
								if (pRow.Table.Columns.Contains("DBSJ") && pRow["DBSJ"] != DBNull.Value) { obj.DBSJ = Convert.ToDateTime(pRow["DBSJ"]); }
							if(strFldName.ToUpper()=="DJYY")
								if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
							if(strFldName.ToUpper()=="GGR")
								if (pRow.Table.Columns.Contains("GGR") && pRow["GGR"] != DBNull.Value) { obj.GGR = Convert.ToString(pRow["GGR"]); }
							if(strFldName.ToUpper()=="GGRSGZH")
								if (pRow.Table.Columns.Contains("GGRSGZH") && pRow["GGRSGZH"] != DBNull.Value) { obj.GGRSGZH = Convert.ToString(pRow["GGRSGZH"]); }
							if(strFldName.ToUpper()=="GGRBSM")
								if (pRow.Table.Columns.Contains("GGRBSM") && pRow["GGRBSM"] != DBNull.Value) { obj.GGRBSM = Convert.ToString(pRow["GGRBSM"]); }
							if(strFldName.ToUpper()=="GGSJ")
								if (pRow.Table.Columns.Contains("GGSJ") && pRow["GGSJ"] != DBNull.Value) { obj.GGSJ = Convert.ToDateTime(pRow["GGSJ"]); }
							if(strFldName.ToUpper()=="GGKSSJ")
								if (pRow.Table.Columns.Contains("GGKSSJ") && pRow["GGKSSJ"] != DBNull.Value) { obj.GGKSSJ = Convert.ToDateTime(pRow["GGKSSJ"]); }
							if(strFldName.ToUpper()=="GGJSSJ")
								if (pRow.Table.Columns.Contains("GGJSSJ") && pRow["GGJSSJ"] != DBNull.Value) { obj.GGJSSJ = Convert.ToDateTime(pRow["GGJSSJ"]); }
							if(strFldName.ToUpper()=="GGNR")
								if (pRow.Table.Columns.Contains("GGNR") && pRow["GGNR"] != DBNull.Value) { obj.GGNR = Convert.ToString(pRow["GGNR"]); }
							if(strFldName.ToUpper()=="GGJG")
								if (pRow.Table.Columns.Contains("GGJG") && pRow["GGJG"] != DBNull.Value) { obj.GGJG = Convert.ToString(pRow["GGJG"]); }
							if(strFldName.ToUpper()=="GDRY")
								if (pRow.Table.Columns.Contains("GDRY") && pRow["GDRY"] != DBNull.Value) { obj.GDRY = Convert.ToString(pRow["GDRY"]); }
							if(strFldName.ToUpper()=="GDSJ")
								if (pRow.Table.Columns.Contains("GDSJ") && pRow["GDSJ"] != DBNull.Value) { obj.GDSJ = Convert.ToDateTime(pRow["GDSJ"]); }
							if(strFldName.ToUpper()=="GDRSGZH")
								if (pRow.Table.Columns.Contains("GDRSGZH") && pRow["GDRSGZH"] != DBNull.Value) { obj.GDRSGZH = Convert.ToString(pRow["GDRSGZH"]); }
							if(strFldName.ToUpper()=="GDRBSM")
								if (pRow.Table.Columns.Contains("GDRBSM") && pRow["GDRBSM"] != DBNull.Value) { obj.GDRBSM = Convert.ToString(pRow["GDRBSM"]); }
							if(strFldName.ToUpper()=="SBH")
								if (pRow.Table.Columns.Contains("SBH") && pRow["SBH"] != DBNull.Value) { obj.SBH = Convert.ToString(pRow["SBH"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="QSZT")
								if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							
							if(strFldName.ToUpper()=="YGDJZL")
								if (pRow.Table.Columns.Contains("YGDJZL") && pRow["YGDJZL"] != DBNull.Value) { obj.YGDJZL = Convert.ToString(pRow["YGDJZL"]); }
							if(strFldName.ToUpper()=="SZCZCS")
								if (pRow.Table.Columns.Contains("SZCZCS") && pRow["SZCZCS"] != DBNull.Value) { obj.SZCZCS = Convert.ToString(pRow["SZCZCS"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="SLRQZBSM")
								if (pRow.Table.Columns.Contains("SLRQZBSM") && pRow["SLRQZBSM"] != DBNull.Value) { obj.SLRQZBSM = Convert.ToInt64(pRow["SLRQZBSM"]); }
							if(strFldName.ToUpper()=="CSRQZBSM")
								if (pRow.Table.Columns.Contains("CSRQZBSM") && pRow["CSRQZBSM"] != DBNull.Value) { obj.CSRQZBSM = Convert.ToInt64(pRow["CSRQZBSM"]); }
							if(strFldName.ToUpper()=="FSRQZBSM")
								if (pRow.Table.Columns.Contains("FSRQZBSM") && pRow["FSRQZBSM"] != DBNull.Value) { obj.FSRQZBSM = Convert.ToInt64(pRow["FSRQZBSM"]); }
							if(strFldName.ToUpper()=="HDRQZBSM")
								if (pRow.Table.Columns.Contains("HDRQZBSM") && pRow["HDRQZBSM"] != DBNull.Value) { obj.HDRQZBSM = Convert.ToInt64(pRow["HDRQZBSM"]); }
							if(strFldName.ToUpper()=="DBRQZBSM")
								if (pRow.Table.Columns.Contains("DBRQZBSM") && pRow["DBRQZBSM"] != DBNull.Value) { obj.DBRQZBSM = Convert.ToInt64(pRow["DBRQZBSM"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
							if(strFldName.ToUpper()=="QSDCTDMJ")
								if (pRow.Table.Columns.Contains("QSDCTDMJ") && pRow["QSDCTDMJ"] != DBNull.Value) { obj.QSDCTDMJ = Convert.ToString(pRow["QSDCTDMJ"]); }
							if(strFldName.ToUpper()=="QSDCFTMJ")
								if (pRow.Table.Columns.Contains("QSDCFTMJ") && pRow["QSDCFTMJ"] != DBNull.Value) { obj.QSDCFTMJ = Convert.ToString(pRow["QSDCFTMJ"]); }
							if(strFldName.ToUpper()=="QSDCDYMJ")
								if (pRow.Table.Columns.Contains("QSDCDYMJ") && pRow["QSDCDYMJ"] != DBNull.Value) { obj.QSDCDYMJ = Convert.ToString(pRow["QSDCDYMJ"]); }
							if(strFldName.ToUpper()=="QSDCJZMJ")
								if (pRow.Table.Columns.Contains("QSDCJZMJ") && pRow["QSDCJZMJ"] != DBNull.Value) { obj.QSDCJZMJ = Convert.ToString(pRow["QSDCJZMJ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
						if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
						if (pRow.Table.Columns.Contains("LCDM") && pRow["LCDM"] != DBNull.Value) { obj.LCDM = Convert.ToString(pRow["LCDM"]); }
						if (pRow.Table.Columns.Contains("SHLX") && pRow["SHLX"] != DBNull.Value) { obj.SHLX = Convert.ToString(pRow["SHLX"]); }
						if (pRow.Table.Columns.Contains("QLLX") && pRow["QLLX"] != DBNull.Value) { obj.QLLX = Convert.ToString(pRow["QLLX"]); }
						if (pRow.Table.Columns.Contains("DJLX") && pRow["DJLX"] != DBNull.Value) { obj.DJLX = Convert.ToString(pRow["DJLX"]); }
						if (pRow.Table.Columns.Contains("QLRMC") && pRow["QLRMC"] != DBNull.Value) { obj.QLRMC = Convert.ToString(pRow["QLRMC"]); }
						if (pRow.Table.Columns.Contains("QLRZJZL") && pRow["QLRZJZL"] != DBNull.Value) { obj.QLRZJZL = Convert.ToString(pRow["QLRZJZL"]); }
						if (pRow.Table.Columns.Contains("QLRZJH") && pRow["QLRZJH"] != DBNull.Value) { obj.QLRZJH = Convert.ToString(pRow["QLRZJH"]); }
						if (pRow.Table.Columns.Contains("QLRTXDZ") && pRow["QLRTXDZ"] != DBNull.Value) { obj.QLRTXDZ = Convert.ToString(pRow["QLRTXDZ"]); }
						if (pRow.Table.Columns.Contains("QLRYB") && pRow["QLRYB"] != DBNull.Value) { obj.QLRYB = Convert.ToString(pRow["QLRYB"]); }
						if (pRow.Table.Columns.Contains("QLRFRMC") && pRow["QLRFRMC"] != DBNull.Value) { obj.QLRFRMC = Convert.ToString(pRow["QLRFRMC"]); }
						if (pRow.Table.Columns.Contains("QLRFRDH") && pRow["QLRFRDH"] != DBNull.Value) { obj.QLRFRDH = Convert.ToString(pRow["QLRFRDH"]); }
						if (pRow.Table.Columns.Contains("QLRDLRMC") && pRow["QLRDLRMC"] != DBNull.Value) { obj.QLRDLRMC = Convert.ToString(pRow["QLRDLRMC"]); }
						if (pRow.Table.Columns.Contains("QLRDLRDH") && pRow["QLRDLRDH"] != DBNull.Value) { obj.QLRDLRDH = Convert.ToString(pRow["QLRDLRDH"]); }
						if (pRow.Table.Columns.Contains("QLRDLJG") && pRow["QLRDLJG"] != DBNull.Value) { obj.QLRDLJG = Convert.ToString(pRow["QLRDLJG"]); }
						if (pRow.Table.Columns.Contains("YWRMC") && pRow["YWRMC"] != DBNull.Value) { obj.YWRMC = Convert.ToString(pRow["YWRMC"]); }
						if (pRow.Table.Columns.Contains("YWRZJZL") && pRow["YWRZJZL"] != DBNull.Value) { obj.YWRZJZL = Convert.ToString(pRow["YWRZJZL"]); }
						if (pRow.Table.Columns.Contains("YWRZJH") && pRow["YWRZJH"] != DBNull.Value) { obj.YWRZJH = Convert.ToString(pRow["YWRZJH"]); }
						if (pRow.Table.Columns.Contains("YWRTXDZ") && pRow["YWRTXDZ"] != DBNull.Value) { obj.YWRTXDZ = Convert.ToString(pRow["YWRTXDZ"]); }
						if (pRow.Table.Columns.Contains("YWRYB") && pRow["YWRYB"] != DBNull.Value) { obj.YWRYB = Convert.ToString(pRow["YWRYB"]); }
						if (pRow.Table.Columns.Contains("YWRFRMC") && pRow["YWRFRMC"] != DBNull.Value) { obj.YWRFRMC = Convert.ToString(pRow["YWRFRMC"]); }
						if (pRow.Table.Columns.Contains("YWRFRDH") && pRow["YWRFRDH"] != DBNull.Value) { obj.YWRFRDH = Convert.ToString(pRow["YWRFRDH"]); }
						if (pRow.Table.Columns.Contains("YWRDLRMC") && pRow["YWRDLRMC"] != DBNull.Value) { obj.YWRDLRMC = Convert.ToString(pRow["YWRDLRMC"]); }
						if (pRow.Table.Columns.Contains("YWRDLRDH") && pRow["YWRDLRDH"] != DBNull.Value) { obj.YWRDLRDH = Convert.ToString(pRow["YWRDLRDH"]); }
						if (pRow.Table.Columns.Contains("YWRDLJG") && pRow["YWRDLJG"] != DBNull.Value) { obj.YWRDLJG = Convert.ToString(pRow["YWRDLJG"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
						if (pRow.Table.Columns.Contains("BDCLX") && pRow["BDCLX"] != DBNull.Value) { obj.BDCLX = Convert.ToString(pRow["BDCLX"]); }
						if (pRow.Table.Columns.Contains("MJ") && pRow["MJ"] != DBNull.Value) { obj.MJ = Convert.ToString(pRow["MJ"]); }
						if (pRow.Table.Columns.Contains("YT") && pRow["YT"] != DBNull.Value) { obj.YT = Convert.ToString(pRow["YT"]); }
						if (pRow.Table.Columns.Contains("QLXZ") && pRow["QLXZ"] != DBNull.Value) { obj.QLXZ = Convert.ToString(pRow["QLXZ"]); }
						if (pRow.Table.Columns.Contains("GYQK") && pRow["GYQK"] != DBNull.Value) { obj.GYQK = Convert.ToString(pRow["GYQK"]); }
						if (pRow.Table.Columns.Contains("SYQX") && pRow["SYQX"] != DBNull.Value) { obj.SYQX = Convert.ToString(pRow["SYQX"]); }
						if (pRow.Table.Columns.Contains("FWJG") && pRow["FWJG"] != DBNull.Value) { obj.FWJG = Convert.ToString(pRow["FWJG"]); }
						if (pRow.Table.Columns.Contains("SZC") && pRow["SZC"] != DBNull.Value) { obj.SZC = Convert.ToString(pRow["SZC"]); }
						if (pRow.Table.Columns.Contains("ZCS") && pRow["ZCS"] != DBNull.Value) { obj.ZCS = Convert.ToString(pRow["ZCS"]); }
						if (pRow.Table.Columns.Contains("FWFTMJ") && pRow["FWFTMJ"] != DBNull.Value) { obj.FWFTMJ = Convert.ToString(pRow["FWFTMJ"]); }
						if (pRow.Table.Columns.Contains("LZ") && pRow["LZ"] != DBNull.Value) { obj.LZ = Convert.ToString(pRow["LZ"]); }
						if (pRow.Table.Columns.Contains("YHLX") && pRow["YHLX"] != DBNull.Value) { obj.YHLX = Convert.ToString(pRow["YHLX"]); }
						if (pRow.Table.Columns.Contains("GZWLX") && pRow["GZWLX"] != DBNull.Value) { obj.GZWLX = Convert.ToString(pRow["GZWLX"]); }
						if (pRow.Table.Columns.Contains("YBDCQZH") && pRow["YBDCQZH"] != DBNull.Value) { obj.YBDCQZH = Convert.ToString(pRow["YBDCQZH"]); }
						if (pRow.Table.Columns.Contains("DYFS") && pRow["DYFS"] != DBNull.Value) { obj.DYFS = Convert.ToString(pRow["DYFS"]); }
						if (pRow.Table.Columns.Contains("DYSX") && pRow["DYSX"] != DBNull.Value) { obj.DYSX = Convert.ToString(pRow["DYSX"]); }
						if (pRow.Table.Columns.Contains("BDBZQSE") && pRow["BDBZQSE"] != DBNull.Value) { obj.BDBZQSE = Convert.ToString(pRow["BDBZQSE"]); }
						if (pRow.Table.Columns.Contains("ZWLXQXQSSJ") && pRow["ZWLXQXQSSJ"] != DBNull.Value) { obj.ZWLXQXQSSJ = Convert.ToDateTime(pRow["ZWLXQXQSSJ"]); }
						if (pRow.Table.Columns.Contains("ZWLXQXJSSJ") && pRow["ZWLXQXJSSJ"] != DBNull.Value) { obj.ZWLXQXJSSJ = Convert.ToDateTime(pRow["ZWLXQXJSSJ"]); }
						if (pRow.Table.Columns.Contains("ZJJZWDYFW") && pRow["ZJJZWDYFW"] != DBNull.Value) { obj.ZJJZWDYFW = Convert.ToString(pRow["ZJJZWDYFW"]); }
						if (pRow.Table.Columns.Contains("LYMD") && pRow["LYMD"] != DBNull.Value) { obj.LYMD = Convert.ToString(pRow["LYMD"]); }
						if (pRow.Table.Columns.Contains("LYFF") && pRow["LYFF"] != DBNull.Value) { obj.LYFF = Convert.ToString(pRow["LYFF"]); }
						if (pRow.Table.Columns.Contains("LYQXQSSJ") && pRow["LYQXQSSJ"] != DBNull.Value) { obj.LYQXQSSJ = Convert.ToDateTime(pRow["LYQXQSSJ"]); }
						if (pRow.Table.Columns.Contains("LYQXJSSJ") && pRow["LYQXJSSJ"] != DBNull.Value) { obj.LYQXJSSJ = Convert.ToDateTime(pRow["LYQXJSSJ"]); }
						if (pRow.Table.Columns.Contains("XYDBDCQZH") && pRow["XYDBDCQZH"] != DBNull.Value) { obj.XYDBDCQZH = Convert.ToString(pRow["XYDBDCQZH"]); }
						if (pRow.Table.Columns.Contains("SLR") && pRow["SLR"] != DBNull.Value) { obj.SLR = Convert.ToString(pRow["SLR"]); }
						if (pRow.Table.Columns.Contains("SLSJ") && pRow["SLSJ"] != DBNull.Value) { obj.SLSJ = Convert.ToDateTime(pRow["SLSJ"]); }
						if (pRow.Table.Columns.Contains("SLYJ") && pRow["SLYJ"] != DBNull.Value) { obj.SLYJ = Convert.ToString(pRow["SLYJ"]); }
						if (pRow.Table.Columns.Contains("SLRSGZH") && pRow["SLRSGZH"] != DBNull.Value) { obj.SLRSGZH = Convert.ToString(pRow["SLRSGZH"]); }
						if (pRow.Table.Columns.Contains("SLRBSM") && pRow["SLRBSM"] != DBNull.Value) { obj.SLRBSM = Convert.ToString(pRow["SLRBSM"]); }
						if (pRow.Table.Columns.Contains("CSR") && pRow["CSR"] != DBNull.Value) { obj.CSR = Convert.ToString(pRow["CSR"]); }
						if (pRow.Table.Columns.Contains("CSRSGZH") && pRow["CSRSGZH"] != DBNull.Value) { obj.CSRSGZH = Convert.ToString(pRow["CSRSGZH"]); }
						if (pRow.Table.Columns.Contains("CSRBSM") && pRow["CSRBSM"] != DBNull.Value) { obj.CSRBSM = Convert.ToString(pRow["CSRBSM"]); }
						if (pRow.Table.Columns.Contains("CSYJ") && pRow["CSYJ"] != DBNull.Value) { obj.CSYJ = Convert.ToString(pRow["CSYJ"]); }
						if (pRow.Table.Columns.Contains("CSSJ") && pRow["CSSJ"] != DBNull.Value) { obj.CSSJ = Convert.ToDateTime(pRow["CSSJ"]); }
						if (pRow.Table.Columns.Contains("FSR") && pRow["FSR"] != DBNull.Value) { obj.FSR = Convert.ToString(pRow["FSR"]); }
						if (pRow.Table.Columns.Contains("FSRSGZH") && pRow["FSRSGZH"] != DBNull.Value) { obj.FSRSGZH = Convert.ToString(pRow["FSRSGZH"]); }
						if (pRow.Table.Columns.Contains("FSRBSM") && pRow["FSRBSM"] != DBNull.Value) { obj.FSRBSM = Convert.ToString(pRow["FSRBSM"]); }
						if (pRow.Table.Columns.Contains("FSYJ") && pRow["FSYJ"] != DBNull.Value) { obj.FSYJ = Convert.ToString(pRow["FSYJ"]); }
						if (pRow.Table.Columns.Contains("FSSJ") && pRow["FSSJ"] != DBNull.Value) { obj.FSSJ = Convert.ToDateTime(pRow["FSSJ"]); }
						if (pRow.Table.Columns.Contains("HDR") && pRow["HDR"] != DBNull.Value) { obj.HDR = Convert.ToString(pRow["HDR"]); }
						if (pRow.Table.Columns.Contains("HDRSGZH") && pRow["HDRSGZH"] != DBNull.Value) { obj.HDRSGZH = Convert.ToString(pRow["HDRSGZH"]); }
						if (pRow.Table.Columns.Contains("HDRBSM") && pRow["HDRBSM"] != DBNull.Value) { obj.HDRBSM = Convert.ToString(pRow["HDRBSM"]); }
						if (pRow.Table.Columns.Contains("HDYJ") && pRow["HDYJ"] != DBNull.Value) { obj.HDYJ = Convert.ToString(pRow["HDYJ"]); }
						if (pRow.Table.Columns.Contains("HDSJ") && pRow["HDSJ"] != DBNull.Value) { obj.HDSJ = Convert.ToDateTime(pRow["HDSJ"]); }
						if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
						if (pRow.Table.Columns.Contains("DBRSGZH") && pRow["DBRSGZH"] != DBNull.Value) { obj.DBRSGZH = Convert.ToString(pRow["DBRSGZH"]); }
						if (pRow.Table.Columns.Contains("DBRBSM") && pRow["DBRBSM"] != DBNull.Value) { obj.DBRBSM = Convert.ToString(pRow["DBRBSM"]); }
						if (pRow.Table.Columns.Contains("DBNR") && pRow["DBNR"] != DBNull.Value) { obj.DBNR = Convert.ToString(pRow["DBNR"]); }
						if (pRow.Table.Columns.Contains("DBSJ") && pRow["DBSJ"] != DBNull.Value) { obj.DBSJ = Convert.ToDateTime(pRow["DBSJ"]); }
						if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
						if (pRow.Table.Columns.Contains("GGR") && pRow["GGR"] != DBNull.Value) { obj.GGR = Convert.ToString(pRow["GGR"]); }
						if (pRow.Table.Columns.Contains("GGRSGZH") && pRow["GGRSGZH"] != DBNull.Value) { obj.GGRSGZH = Convert.ToString(pRow["GGRSGZH"]); }
						if (pRow.Table.Columns.Contains("GGRBSM") && pRow["GGRBSM"] != DBNull.Value) { obj.GGRBSM = Convert.ToString(pRow["GGRBSM"]); }
						if (pRow.Table.Columns.Contains("GGSJ") && pRow["GGSJ"] != DBNull.Value) { obj.GGSJ = Convert.ToDateTime(pRow["GGSJ"]); }
						if (pRow.Table.Columns.Contains("GGKSSJ") && pRow["GGKSSJ"] != DBNull.Value) { obj.GGKSSJ = Convert.ToDateTime(pRow["GGKSSJ"]); }
						if (pRow.Table.Columns.Contains("GGJSSJ") && pRow["GGJSSJ"] != DBNull.Value) { obj.GGJSSJ = Convert.ToDateTime(pRow["GGJSSJ"]); }
						if (pRow.Table.Columns.Contains("GGNR") && pRow["GGNR"] != DBNull.Value) { obj.GGNR = Convert.ToString(pRow["GGNR"]); }
						if (pRow.Table.Columns.Contains("GGJG") && pRow["GGJG"] != DBNull.Value) { obj.GGJG = Convert.ToString(pRow["GGJG"]); }
						if (pRow.Table.Columns.Contains("GDRY") && pRow["GDRY"] != DBNull.Value) { obj.GDRY = Convert.ToString(pRow["GDRY"]); }
						if (pRow.Table.Columns.Contains("GDSJ") && pRow["GDSJ"] != DBNull.Value) { obj.GDSJ = Convert.ToDateTime(pRow["GDSJ"]); }
						if (pRow.Table.Columns.Contains("GDRSGZH") && pRow["GDRSGZH"] != DBNull.Value) { obj.GDRSGZH = Convert.ToString(pRow["GDRSGZH"]); }
						if (pRow.Table.Columns.Contains("GDRBSM") && pRow["GDRBSM"] != DBNull.Value) { obj.GDRBSM = Convert.ToString(pRow["GDRBSM"]); }
						if (pRow.Table.Columns.Contains("SBH") && pRow["SBH"] != DBNull.Value) { obj.SBH = Convert.ToString(pRow["SBH"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						
						if (pRow.Table.Columns.Contains("YGDJZL") && pRow["YGDJZL"] != DBNull.Value) { obj.YGDJZL = Convert.ToString(pRow["YGDJZL"]); }
						if (pRow.Table.Columns.Contains("SZCZCS") && pRow["SZCZCS"] != DBNull.Value) { obj.SZCZCS = Convert.ToString(pRow["SZCZCS"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("SLRQZBSM") && pRow["SLRQZBSM"] != DBNull.Value) { obj.SLRQZBSM = Convert.ToInt64(pRow["SLRQZBSM"]); }
						if (pRow.Table.Columns.Contains("CSRQZBSM") && pRow["CSRQZBSM"] != DBNull.Value) { obj.CSRQZBSM = Convert.ToInt64(pRow["CSRQZBSM"]); }
						if (pRow.Table.Columns.Contains("FSRQZBSM") && pRow["FSRQZBSM"] != DBNull.Value) { obj.FSRQZBSM = Convert.ToInt64(pRow["FSRQZBSM"]); }
						if (pRow.Table.Columns.Contains("HDRQZBSM") && pRow["HDRQZBSM"] != DBNull.Value) { obj.HDRQZBSM = Convert.ToInt64(pRow["HDRQZBSM"]); }
						if (pRow.Table.Columns.Contains("DBRQZBSM") && pRow["DBRQZBSM"] != DBNull.Value) { obj.DBRQZBSM = Convert.ToInt64(pRow["DBRQZBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
					
						if (pRow.Table.Columns.Contains("QSDCTDMJ") && pRow["QSDCTDMJ"] != DBNull.Value) { obj.QSDCTDMJ = Convert.ToString(pRow["QSDCTDMJ"]); }
						if (pRow.Table.Columns.Contains("QSDCFTMJ") && pRow["QSDCFTMJ"] != DBNull.Value) { obj.QSDCFTMJ = Convert.ToString(pRow["QSDCFTMJ"]); }
						if (pRow.Table.Columns.Contains("QSDCDYMJ") && pRow["QSDCDYMJ"] != DBNull.Value) { obj.QSDCDYMJ = Convert.ToString(pRow["QSDCDYMJ"]); }
						if (pRow.Table.Columns.Contains("QSDCJZMJ") && pRow["QSDCJZMJ"] != DBNull.Value) { obj.QSDCJZMJ = Convert.ToString(pRow["QSDCJZMJ"]); }
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
