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

	public class Fld_H
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string ZDSHIYQBSM="ZDSHIYQBSM";
		public const string ZRZBSM="ZRZBSM";
		public const string LJZBSM="LJZBSM";
		public const string CBSM="CBSM";
		public const string FWBM="FWBM";
		public const string ZRZH="ZRZH";
		public const string LJZH="LJZH";
		public const string CH="CH";
		public const string ZL="ZL";
		public const string SJCS="SJCS";
		public const string HH="HH";
		public const string SHBW="SHBW";
		public const string HX="HX";
		public const string HXJG="HXJG";
		public const string FWJG="FWJG";
		public const string FWYT1="FWYT1";
		public const string FWYT2="FWYT2";
		public const string FWYT3="FWYT3";
		public const string YXTFWYTMC1="YXTFWYTMC1";
		public const string YXTFWYTMC2="YXTFWYTMC2";
		public const string YXTFWYTMC3="YXTFWYTMC3";
		public const string GHYT="GHYT";
		public const string YXTGHYTMC="YXTGHYTMC";
		public const string YCJZMJ="YCJZMJ";
		public const string YCTNJZMJ="YCTNJZMJ";
		public const string YCFTJZMJ="YCFTJZMJ";
		public const string YCDXBFJZMJ="YCDXBFJZMJ";
		public const string YCQTJZMJ="YCQTJZMJ";
		public const string YCFTXS="YCFTXS";
		public const string SCJZMJ="SCJZMJ";
		public const string SCTNJZMJ="SCTNJZMJ";
		public const string SCFTJZMJ="SCFTJZMJ";
		public const string SCDXBFJZMJ="SCDXBFJZMJ";
		public const string SCQTJZMJ="SCQTJZMJ";
		public const string SCFTXS="SCFTXS";
		public const string GYTDMJ="GYTDMJ";
		public const string FTTDMJ="FTTDMJ";
		public const string DYTDMJ="DYTDMJ";
		public const string TDSYQMJ="TDSYQMJ";
		public const string FWLX="FWLX";
		public const string YXTFWLXMC="YXTFWLXMC";
		public const string FWXZ="FWXZ";
		public const string YXTFWXZMC="YXTFWXZMC";
		public const string SZC="SZC";
		public const string ZCS="ZCS";
		public const string JGSJ="JGSJ";
		public const string FWJS="FWJS";
		public const string ZDDM="ZDDM";
		public const string BDCDYH="BDCDYH";
		public const string ZTS="ZTS";
		public const string XMMC="XMMC";
		public const string DYH="DYH";
		public const string FJSXH="FJSXH";
		public const string FWLB="FWLB";
		public const string FWDH="FWDH";
		public const string FWLDH="FWLDH";
		public const string FWCB="FWCB";
		public const string JCNF="JCNF";
		public const string CQXZ="CQXZ";
		public const string BZ="BZ";
		public const string ZFBSM="ZFBSM";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string DCBSM="DCBSM";
		public const string KFXMXXBSM="KFXMXXBSM";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string MYCS="MYCS";
		public const string DCYWH="DCYWH";
		public const string TDSYQSSJ="TDSYQSSJ";
		public const string TDSYJSSJ="TDSYJSSJ";
		public const string TDYT="TDYT";
		public const string TDQLXZ="TDQLXZ";
		public const string ZDMJ="ZDMJ";
		public const string BZ_GXSJ="BZ_GXSJ";
		public const string BZ_ZFBDCDYH="BZ_ZFBDCDYH";
		public const string YWH="YWH";
		public const string BZ_ZD_ID="BZ_ZD_ID";
		public const string DCZDSHIYQBSM="DCZDSHIYQBSM";
		public const string FFLB="FFLB";
		public const string GXSJ="GXSJ";
		public const string TDYTMC="TDYTMC";
		public const string YFWJG="YFWJG";
		public const string YFWCB="YFWCB";
		public const string PKBSM="PKBSM";
		public const string YXTQDFS="YXTQDFS";
		public const string HROOMID="HROOMID";
		public const string YXTBSM1="YXTBSM1";
		public const string TDDJ="TDDJ";
		public const string BZ_FWCODE="BZ_FWCODE";
		public const string BZ_FWID="BZ_FWID";
		public const string QSZT="QSZT";
		public const string BZ_ZID="BZ_ZID";
		public const string BZ_FCFHTID="BZ_FCFHTID";
		public const string SFJSMJ="SFJSMJ";
		public const string TDLY="TDLY";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsH:IEntity
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
		private long m_ZDSHIYQBSM;
		private long m_ZRZBSM;
		private long m_LJZBSM;
		private long m_CBSM;
		private string m_FWBM;
		private string m_ZRZH;
		private string m_LJZH;
		private string m_CH;
		private string m_ZL;
		private double m_SJCS;
		private string m_HH;
		private string m_SHBW;
		private string m_HX;
		private string m_HXJG;
		private string m_FWJG;
		private string m_FWYT1;
		private string m_FWYT2;
		private string m_FWYT3;
		private string m_YXTFWYTMC1;
		private string m_YXTFWYTMC2;
		private string m_YXTFWYTMC3;
		private string m_GHYT;
		private string m_YXTGHYTMC;
		private double m_YCJZMJ;
		private double m_YCTNJZMJ;
		private double m_YCFTJZMJ;
		private double m_YCDXBFJZMJ;
		private double m_YCQTJZMJ;
		private double m_YCFTXS;
		private double m_SCJZMJ;
		private double m_SCTNJZMJ;
		private double m_SCFTJZMJ;
		private double m_SCDXBFJZMJ;
		private double m_SCQTJZMJ;
		private double m_SCFTXS;
		private double m_GYTDMJ;
		private double m_FTTDMJ;
		private double m_DYTDMJ;
		private double m_TDSYQMJ;
		private string m_FWLX;
		private string m_YXTFWLXMC;
		private string m_FWXZ;
		private string m_YXTFWXZMC;
		private string m_SZC;
		private long m_ZCS;
		private DateTime m_JGSJ;
		private string m_FWJS;
		private string m_ZDDM;
		private string m_BDCDYH;
		private long m_ZTS;
		private string m_XMMC;
		private string m_DYH;
		private long m_FJSXH;
		private int m_FWLB;
		private string m_FWDH;
		private string m_FWLDH;
		private string m_FWCB;
		private string m_JCNF;
		private string m_CQXZ;
		private string m_BZ;
		private long m_ZFBSM;
		private string m_YXTBM;
		private string m_YXTBSM;
		private long m_DCBSM;
		private long m_KFXMXXBSM;
		private long m_QXDM;
		private long m_REV_;
		private string m_MYCS;
		private string m_DCYWH;
		private DateTime m_TDSYQSSJ;
		private DateTime m_TDSYJSSJ;
		private string m_TDYT;
		private string m_TDQLXZ;
		private double m_ZDMJ;
		private DateTime m_BZ_GXSJ;
		private string m_YWH;
		private long m_DCZDSHIYQBSM;
		private int m_FFLB;
		private DateTime m_GXSJ;
		private string m_TDYTMC;
		private string m_YFWJG;
		private string m_YFWCB;
		private long m_PKBSM;
		private string m_TDDJ;
		private long m_QSZT;
		private int m_SFJSMJ;
		private long m_TDLY;
		private long m_BG_BB;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public long ZDSHIYQBSM
		{
			get{ return m_ZDSHIYQBSM; }
			set{ m_ZDSHIYQBSM = value; }
		}
		public long ZRZBSM
		{
			get{ return m_ZRZBSM; }
			set{ m_ZRZBSM = value; }
		}
		public long LJZBSM
		{
			get{ return m_LJZBSM; }
			set{ m_LJZBSM = value; }
		}
		public long CBSM
		{
			get{ return m_CBSM; }
			set{ m_CBSM = value; }
		}
		public string FWBM
		{
			get{ return m_FWBM; }
			set{ m_FWBM = value; }
		}
		public string ZRZH
		{
			get{ return m_ZRZH; }
			set{ m_ZRZH = value; }
		}
		public string LJZH
		{
			get{ return m_LJZH; }
			set{ m_LJZH = value; }
		}
		public string CH
		{
			get{ return m_CH; }
			set{ m_CH = value; }
		}
		public string ZL
		{
			get{ return m_ZL; }
			set{ m_ZL = value; }
		}
		public double SJCS
		{
			get{ return m_SJCS; }
			set{ m_SJCS = value; }
		}
		public string HH
		{
			get{ return m_HH; }
			set{ m_HH = value; }
		}
		public string SHBW
		{
			get{ return m_SHBW; }
			set{ m_SHBW = value; }
		}
		public string HX
		{
			get{ return m_HX; }
			set{ m_HX = value; }
		}
		public string HXJG
		{
			get{ return m_HXJG; }
			set{ m_HXJG = value; }
		}
		public string FWJG
		{
			get{ return m_FWJG; }
			set{ m_FWJG = value; }
		}
		public string FWYT1
		{
			get{ return m_FWYT1; }
			set{ m_FWYT1 = value; }
		}
		public string FWYT2
		{
			get{ return m_FWYT2; }
			set{ m_FWYT2 = value; }
		}
		public string FWYT3
		{
			get{ return m_FWYT3; }
			set{ m_FWYT3 = value; }
		}
		public string YXTFWYTMC1
		{
			get{ return m_YXTFWYTMC1; }
			set{ m_YXTFWYTMC1 = value; }
		}
		public string YXTFWYTMC2
		{
			get{ return m_YXTFWYTMC2; }
			set{ m_YXTFWYTMC2 = value; }
		}
		public string YXTFWYTMC3
		{
			get{ return m_YXTFWYTMC3; }
			set{ m_YXTFWYTMC3 = value; }
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
		public double YCJZMJ
		{
			get{ return m_YCJZMJ; }
			set{ m_YCJZMJ = value; }
		}
		public double YCTNJZMJ
		{
			get{ return m_YCTNJZMJ; }
			set{ m_YCTNJZMJ = value; }
		}
		public double YCFTJZMJ
		{
			get{ return m_YCFTJZMJ; }
			set{ m_YCFTJZMJ = value; }
		}
		public double YCDXBFJZMJ
		{
			get{ return m_YCDXBFJZMJ; }
			set{ m_YCDXBFJZMJ = value; }
		}
		public double YCQTJZMJ
		{
			get{ return m_YCQTJZMJ; }
			set{ m_YCQTJZMJ = value; }
		}
		public double YCFTXS
		{
			get{ return m_YCFTXS; }
			set{ m_YCFTXS = value; }
		}
		public double SCJZMJ
		{
			get{ return m_SCJZMJ; }
			set{ m_SCJZMJ = value; }
		}
		public double SCTNJZMJ
		{
			get{ return m_SCTNJZMJ; }
			set{ m_SCTNJZMJ = value; }
		}
		public double SCFTJZMJ
		{
			get{ return m_SCFTJZMJ; }
			set{ m_SCFTJZMJ = value; }
		}
		public double SCDXBFJZMJ
		{
			get{ return m_SCDXBFJZMJ; }
			set{ m_SCDXBFJZMJ = value; }
		}
		public double SCQTJZMJ
		{
			get{ return m_SCQTJZMJ; }
			set{ m_SCQTJZMJ = value; }
		}
		public double SCFTXS
		{
			get{ return m_SCFTXS; }
			set{ m_SCFTXS = value; }
		}
		public double GYTDMJ
		{
			get{ return m_GYTDMJ; }
			set{ m_GYTDMJ = value; }
		}
		public double FTTDMJ
		{
			get{ return m_FTTDMJ; }
			set{ m_FTTDMJ = value; }
		}
		public double DYTDMJ
		{
			get{ return m_DYTDMJ; }
			set{ m_DYTDMJ = value; }
		}
		public double TDSYQMJ
		{
			get{ return m_TDSYQMJ; }
			set{ m_TDSYQMJ = value; }
		}
		public string FWLX
		{
			get{ return m_FWLX; }
			set{ m_FWLX = value; }
		}
		public string YXTFWLXMC
		{
			get{ return m_YXTFWLXMC; }
			set{ m_YXTFWLXMC = value; }
		}
		public string FWXZ
		{
			get{ return m_FWXZ; }
			set{ m_FWXZ = value; }
		}
		public string YXTFWXZMC
		{
			get{ return m_YXTFWXZMC; }
			set{ m_YXTFWXZMC = value; }
		}
		public string SZC
		{
			get{ return m_SZC; }
			set{ m_SZC = value; }
		}
		public long ZCS
		{
			get{ return m_ZCS; }
			set{ m_ZCS = value; }
		}
		public DateTime JGSJ
		{
			get{ return m_JGSJ; }
			set{ m_JGSJ = value; }
		}
		public string FWJS
		{
			get{ return m_FWJS; }
			set{ m_FWJS = value; }
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
		public long ZTS
		{
			get{ return m_ZTS; }
			set{ m_ZTS = value; }
		}
		public string XMMC
		{
			get{ return m_XMMC; }
			set{ m_XMMC = value; }
		}
		public string DYH
		{
			get{ return m_DYH; }
			set{ m_DYH = value; }
		}
		public long FJSXH
		{
			get{ return m_FJSXH; }
			set{ m_FJSXH = value; }
		}
		public int FWLB
		{
			get{ return m_FWLB; }
			set{ m_FWLB = value; }
		}
		public string FWDH
		{
			get{ return m_FWDH; }
			set{ m_FWDH = value; }
		}
		public string FWLDH
		{
			get{ return m_FWLDH; }
			set{ m_FWLDH = value; }
		}
		public string FWCB
		{
			get{ return m_FWCB; }
			set{ m_FWCB = value; }
		}
		public string JCNF
		{
			get{ return m_JCNF; }
			set{ m_JCNF = value; }
		}
		public string CQXZ
		{
			get{ return m_CQXZ; }
			set{ m_CQXZ = value; }
		}
		public string BZ
		{
			get{ return m_BZ; }
			set{ m_BZ = value; }
		}
		public long ZFBSM
		{
			get{ return m_ZFBSM; }
			set{ m_ZFBSM = value; }
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
		public long KFXMXXBSM
		{
			get{ return m_KFXMXXBSM; }
			set{ m_KFXMXXBSM = value; }
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
		public string MYCS
		{
			get{ return m_MYCS; }
			set{ m_MYCS = value; }
		}
		public string DCYWH
		{
			get{ return m_DCYWH; }
			set{ m_DCYWH = value; }
		}
		public DateTime TDSYQSSJ
		{
			get{ return m_TDSYQSSJ; }
			set{ m_TDSYQSSJ = value; }
		}
		public DateTime TDSYJSSJ
		{
			get{ return m_TDSYJSSJ; }
			set{ m_TDSYJSSJ = value; }
		}
		public string TDYT
		{
			get{ return m_TDYT; }
			set{ m_TDYT = value; }
		}
		public string TDQLXZ
		{
			get{ return m_TDQLXZ; }
			set{ m_TDQLXZ = value; }
		}
		public double ZDMJ
		{
			get{ return m_ZDMJ; }
			set{ m_ZDMJ = value; }
		}
		public DateTime BZ_GXSJ
		{
			get{ return m_BZ_GXSJ; }
			set{ m_BZ_GXSJ = value; }
		}
		public string YWH
		{
			get{ return m_YWH; }
			set{ m_YWH = value; }
		}
		public long DCZDSHIYQBSM
		{
			get{ return m_DCZDSHIYQBSM; }
			set{ m_DCZDSHIYQBSM = value; }
		}
		public int FFLB
		{
			get{ return m_FFLB; }
			set{ m_FFLB = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		public string TDYTMC
		{
			get{ return m_TDYTMC; }
			set{ m_TDYTMC = value; }
		}
		public string YFWJG
		{
			get{ return m_YFWJG; }
			set{ m_YFWJG = value; }
		}
		public string YFWCB
		{
			get{ return m_YFWCB; }
			set{ m_YFWCB = value; }
		}
		public long PKBSM
		{
			get{ return m_PKBSM; }
			set{ m_PKBSM = value; }
		}
		public string TDDJ
		{
			get{ return m_TDDJ; }
			set{ m_TDDJ = value; }
		}
		public long QSZT
		{
			get{ return m_QSZT; }
			set{ m_QSZT = value; }
		}
		public int SFJSMJ
		{
			get{ return m_SFJSMJ; }
			set{ m_SFJSMJ = value; }
		}
		public long TDLY
		{
			get{ return m_TDLY; }
			set{ m_TDLY = value; }
		}
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

		#endregion
		public bool IsEquals(clsH obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.ZDSHIYQBSM != obj.ZDSHIYQBSM) bolResult = false;
			if (this.ZRZBSM != obj.ZRZBSM) bolResult = false;
			if (this.LJZBSM != obj.LJZBSM) bolResult = false;
			if (this.CBSM != obj.CBSM) bolResult = false;
			if (this.FWBM != obj.FWBM) bolResult = false;
			if (this.ZRZH != obj.ZRZH) bolResult = false;
			if (this.LJZH != obj.LJZH) bolResult = false;
			if (this.CH != obj.CH) bolResult = false;
			if (this.ZL != obj.ZL) bolResult = false;
			if (this.SJCS != obj.SJCS) bolResult = false;
			if (this.HH != obj.HH) bolResult = false;
			if (this.SHBW != obj.SHBW) bolResult = false;
			if (this.HX != obj.HX) bolResult = false;
			if (this.HXJG != obj.HXJG) bolResult = false;
			if (this.FWJG != obj.FWJG) bolResult = false;
			if (this.FWYT1 != obj.FWYT1) bolResult = false;
			if (this.FWYT2 != obj.FWYT2) bolResult = false;
			if (this.FWYT3 != obj.FWYT3) bolResult = false;
			if (this.YXTFWYTMC1 != obj.YXTFWYTMC1) bolResult = false;
			if (this.YXTFWYTMC2 != obj.YXTFWYTMC2) bolResult = false;
			if (this.YXTFWYTMC3 != obj.YXTFWYTMC3) bolResult = false;
			if (this.GHYT != obj.GHYT) bolResult = false;
			if (this.YXTGHYTMC != obj.YXTGHYTMC) bolResult = false;
			if (this.YCJZMJ != obj.YCJZMJ) bolResult = false;
			if (this.YCTNJZMJ != obj.YCTNJZMJ) bolResult = false;
			if (this.YCFTJZMJ != obj.YCFTJZMJ) bolResult = false;
			if (this.YCDXBFJZMJ != obj.YCDXBFJZMJ) bolResult = false;
			if (this.YCQTJZMJ != obj.YCQTJZMJ) bolResult = false;
			if (this.YCFTXS != obj.YCFTXS) bolResult = false;
			if (this.SCJZMJ != obj.SCJZMJ) bolResult = false;
			if (this.SCTNJZMJ != obj.SCTNJZMJ) bolResult = false;
			if (this.SCFTJZMJ != obj.SCFTJZMJ) bolResult = false;
			if (this.SCDXBFJZMJ != obj.SCDXBFJZMJ) bolResult = false;
			if (this.SCQTJZMJ != obj.SCQTJZMJ) bolResult = false;
			if (this.SCFTXS != obj.SCFTXS) bolResult = false;
			if (this.GYTDMJ != obj.GYTDMJ) bolResult = false;
			if (this.FTTDMJ != obj.FTTDMJ) bolResult = false;
			if (this.DYTDMJ != obj.DYTDMJ) bolResult = false;
			if (this.TDSYQMJ != obj.TDSYQMJ) bolResult = false;
			if (this.FWLX != obj.FWLX) bolResult = false;
			if (this.YXTFWLXMC != obj.YXTFWLXMC) bolResult = false;
			if (this.FWXZ != obj.FWXZ) bolResult = false;
			if (this.YXTFWXZMC != obj.YXTFWXZMC) bolResult = false;
			if (this.SZC != obj.SZC) bolResult = false;
			if (this.ZCS != obj.ZCS) bolResult = false;
			if (this.JGSJ != obj.JGSJ) bolResult = false;
			if (this.FWJS != obj.FWJS) bolResult = false;
			if (this.ZDDM != obj.ZDDM) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.ZTS != obj.ZTS) bolResult = false;
			if (this.XMMC != obj.XMMC) bolResult = false;
			if (this.DYH != obj.DYH) bolResult = false;
			if (this.FJSXH != obj.FJSXH) bolResult = false;
			if (this.FWLB != obj.FWLB) bolResult = false;
			if (this.FWDH != obj.FWDH) bolResult = false;
			if (this.FWLDH != obj.FWLDH) bolResult = false;
			if (this.FWCB != obj.FWCB) bolResult = false;
			if (this.JCNF != obj.JCNF) bolResult = false;
			if (this.CQXZ != obj.CQXZ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.ZFBSM != obj.ZFBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.DCBSM != obj.DCBSM) bolResult = false;
			if (this.KFXMXXBSM != obj.KFXMXXBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.MYCS != obj.MYCS) bolResult = false;
			if (this.DCYWH != obj.DCYWH) bolResult = false;
			if (this.TDSYQSSJ != obj.TDSYQSSJ) bolResult = false;
			if (this.TDSYJSSJ != obj.TDSYJSSJ) bolResult = false;
			if (this.TDYT != obj.TDYT) bolResult = false;
			if (this.TDQLXZ != obj.TDQLXZ) bolResult = false;
			if (this.ZDMJ != obj.ZDMJ) bolResult = false;
			if (this.BZ_GXSJ != obj.BZ_GXSJ) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.DCZDSHIYQBSM != obj.DCZDSHIYQBSM) bolResult = false;
			if (this.FFLB != obj.FFLB) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.TDYTMC != obj.TDYTMC) bolResult = false;
			if (this.YFWJG != obj.YFWJG) bolResult = false;
			if (this.YFWCB != obj.YFWCB) bolResult = false;
			if (this.PKBSM != obj.PKBSM) bolResult = false;
			if (this.TDDJ != obj.TDDJ) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.SFJSMJ != obj.SFJSMJ) bolResult = false;
			if (this.TDLY != obj.TDLY) bolResult = false;
			return bolResult;
		}

		public void Colne(clsH obj)
		{
			this.BSM=obj.BSM;
			this.ZDSHIYQBSM=obj.ZDSHIYQBSM;
			this.ZRZBSM=obj.ZRZBSM;
			this.LJZBSM=obj.LJZBSM;
			this.CBSM=obj.CBSM;
			this.FWBM=obj.FWBM;
			this.ZRZH=obj.ZRZH;
			this.LJZH=obj.LJZH;
			this.CH=obj.CH;
			this.ZL=obj.ZL;
			this.SJCS=obj.SJCS;
			this.HH=obj.HH;
			this.SHBW=obj.SHBW;
			this.HX=obj.HX;
			this.HXJG=obj.HXJG;
			this.FWJG=obj.FWJG;
			this.FWYT1=obj.FWYT1;
			this.FWYT2=obj.FWYT2;
			this.FWYT3=obj.FWYT3;
			this.YXTFWYTMC1=obj.YXTFWYTMC1;
			this.YXTFWYTMC2=obj.YXTFWYTMC2;
			this.YXTFWYTMC3=obj.YXTFWYTMC3;
			this.GHYT=obj.GHYT;
			this.YXTGHYTMC=obj.YXTGHYTMC;
			this.YCJZMJ=obj.YCJZMJ;
			this.YCTNJZMJ=obj.YCTNJZMJ;
			this.YCFTJZMJ=obj.YCFTJZMJ;
			this.YCDXBFJZMJ=obj.YCDXBFJZMJ;
			this.YCQTJZMJ=obj.YCQTJZMJ;
			this.YCFTXS=obj.YCFTXS;
			this.SCJZMJ=obj.SCJZMJ;
			this.SCTNJZMJ=obj.SCTNJZMJ;
			this.SCFTJZMJ=obj.SCFTJZMJ;
			this.SCDXBFJZMJ=obj.SCDXBFJZMJ;
			this.SCQTJZMJ=obj.SCQTJZMJ;
			this.SCFTXS=obj.SCFTXS;
			this.GYTDMJ=obj.GYTDMJ;
			this.FTTDMJ=obj.FTTDMJ;
			this.DYTDMJ=obj.DYTDMJ;
			this.TDSYQMJ=obj.TDSYQMJ;
			this.FWLX=obj.FWLX;
			this.YXTFWLXMC=obj.YXTFWLXMC;
			this.FWXZ=obj.FWXZ;
			this.YXTFWXZMC=obj.YXTFWXZMC;
			this.SZC=obj.SZC;
			this.ZCS=obj.ZCS;
			this.JGSJ=obj.JGSJ;
			this.FWJS=obj.FWJS;
			this.ZDDM=obj.ZDDM;
			this.BDCDYH=obj.BDCDYH;
			this.ZTS=obj.ZTS;
			this.XMMC=obj.XMMC;
			this.DYH=obj.DYH;
			this.FJSXH=obj.FJSXH;
			this.FWLB=obj.FWLB;
			this.FWDH=obj.FWDH;
			this.FWLDH=obj.FWLDH;
			this.FWCB=obj.FWCB;
			this.JCNF=obj.JCNF;
			this.CQXZ=obj.CQXZ;
			this.BZ=obj.BZ;
			this.ZFBSM=obj.ZFBSM;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.DCBSM=obj.DCBSM;
			this.KFXMXXBSM=obj.KFXMXXBSM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.MYCS=obj.MYCS;
			this.DCYWH=obj.DCYWH;
			this.TDSYQSSJ=obj.TDSYQSSJ;
			this.TDSYJSSJ=obj.TDSYJSSJ;
			this.TDYT=obj.TDYT;
			this.TDQLXZ=obj.TDQLXZ;
			this.ZDMJ=obj.ZDMJ;
			this.BZ_GXSJ=obj.BZ_GXSJ;
			this.YWH=obj.YWH;
			this.DCZDSHIYQBSM=obj.DCZDSHIYQBSM;
			this.FFLB=obj.FFLB;
			this.GXSJ=obj.GXSJ;
			this.TDYTMC=obj.TDYTMC;
			this.YFWJG=obj.YFWJG;
			this.YFWCB=obj.YFWCB;
			this.PKBSM=obj.PKBSM;
			this.TDDJ=obj.TDDJ;
			this.QSZT=obj.QSZT;
			this.SFJSMJ=obj.SFJSMJ;
			this.TDLY=obj.TDLY;
		}

	}

	public class clsHSet:EntityBaseSet
	{
		public clsHSet()
		{
			m_TableName="BDCDJ.H";
			m_HisTableName="BDCDJ.H_LS";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsHSet";
		}
		public static clsHSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsHSet clsSet = new clsHSet(); //(clsHSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsHSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsH obj = (clsH)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("ZDSHIYQBSM")) datarow["ZDSHIYQBSM"] = obj.ZDSHIYQBSM;
				if(datarow.Table.Columns.Contains("ZRZBSM")) datarow["ZRZBSM"] = obj.ZRZBSM;
				if(datarow.Table.Columns.Contains("LJZBSM")) datarow["LJZBSM"] = obj.LJZBSM;
				if(datarow.Table.Columns.Contains("CBSM")) datarow["CBSM"] = obj.CBSM;
				if(datarow.Table.Columns.Contains("FWBM")) datarow["FWBM"] = obj.FWBM;
				if(datarow.Table.Columns.Contains("ZRZH")) datarow["ZRZH"] = obj.ZRZH;
				if(datarow.Table.Columns.Contains("LJZH")) datarow["LJZH"] = obj.LJZH;
				if(datarow.Table.Columns.Contains("CH")) datarow["CH"] = obj.CH;
				if(datarow.Table.Columns.Contains("ZL")) datarow["ZL"] = obj.ZL;
				if(datarow.Table.Columns.Contains("SJCS")) datarow["SJCS"] = obj.SJCS;
				if(datarow.Table.Columns.Contains("HH")) datarow["HH"] = obj.HH;
				if(datarow.Table.Columns.Contains("SHBW")) datarow["SHBW"] = obj.SHBW;
				if(datarow.Table.Columns.Contains("HX")) datarow["HX"] = obj.HX;
				if(datarow.Table.Columns.Contains("HXJG")) datarow["HXJG"] = obj.HXJG;
				if(datarow.Table.Columns.Contains("FWJG")) datarow["FWJG"] = obj.FWJG;
				if(datarow.Table.Columns.Contains("FWYT1")) datarow["FWYT1"] = obj.FWYT1;
				if(datarow.Table.Columns.Contains("FWYT2")) datarow["FWYT2"] = obj.FWYT2;
				if(datarow.Table.Columns.Contains("FWYT3")) datarow["FWYT3"] = obj.FWYT3;
				if(datarow.Table.Columns.Contains("YXTFWYTMC1")) datarow["YXTFWYTMC1"] = obj.YXTFWYTMC1;
				if(datarow.Table.Columns.Contains("YXTFWYTMC2")) datarow["YXTFWYTMC2"] = obj.YXTFWYTMC2;
				if(datarow.Table.Columns.Contains("YXTFWYTMC3")) datarow["YXTFWYTMC3"] = obj.YXTFWYTMC3;
				if(datarow.Table.Columns.Contains("GHYT")) datarow["GHYT"] = obj.GHYT;
				if(datarow.Table.Columns.Contains("YXTGHYTMC")) datarow["YXTGHYTMC"] = obj.YXTGHYTMC;
				if(datarow.Table.Columns.Contains("YCJZMJ")) datarow["YCJZMJ"] = obj.YCJZMJ;
				if(datarow.Table.Columns.Contains("YCTNJZMJ")) datarow["YCTNJZMJ"] = obj.YCTNJZMJ;
				if(datarow.Table.Columns.Contains("YCFTJZMJ")) datarow["YCFTJZMJ"] = obj.YCFTJZMJ;
				if(datarow.Table.Columns.Contains("YCDXBFJZMJ")) datarow["YCDXBFJZMJ"] = obj.YCDXBFJZMJ;
				if(datarow.Table.Columns.Contains("YCQTJZMJ")) datarow["YCQTJZMJ"] = obj.YCQTJZMJ;
				if(datarow.Table.Columns.Contains("YCFTXS")) datarow["YCFTXS"] = obj.YCFTXS;
				if(datarow.Table.Columns.Contains("SCJZMJ")) datarow["SCJZMJ"] = obj.SCJZMJ;
				if(datarow.Table.Columns.Contains("SCTNJZMJ")) datarow["SCTNJZMJ"] = obj.SCTNJZMJ;
				if(datarow.Table.Columns.Contains("SCFTJZMJ")) datarow["SCFTJZMJ"] = obj.SCFTJZMJ;
				if(datarow.Table.Columns.Contains("SCDXBFJZMJ")) datarow["SCDXBFJZMJ"] = obj.SCDXBFJZMJ;
				if(datarow.Table.Columns.Contains("SCQTJZMJ")) datarow["SCQTJZMJ"] = obj.SCQTJZMJ;
				if(datarow.Table.Columns.Contains("SCFTXS")) datarow["SCFTXS"] = obj.SCFTXS;
				if(datarow.Table.Columns.Contains("GYTDMJ")) datarow["GYTDMJ"] = obj.GYTDMJ;
				if(datarow.Table.Columns.Contains("FTTDMJ")) datarow["FTTDMJ"] = obj.FTTDMJ;
				if(datarow.Table.Columns.Contains("DYTDMJ")) datarow["DYTDMJ"] = obj.DYTDMJ;
				if(datarow.Table.Columns.Contains("TDSYQMJ")) datarow["TDSYQMJ"] = obj.TDSYQMJ;
				if(datarow.Table.Columns.Contains("FWLX")) datarow["FWLX"] = obj.FWLX;
				if(datarow.Table.Columns.Contains("YXTFWLXMC")) datarow["YXTFWLXMC"] = obj.YXTFWLXMC;
				if(datarow.Table.Columns.Contains("FWXZ")) datarow["FWXZ"] = obj.FWXZ;
				if(datarow.Table.Columns.Contains("YXTFWXZMC")) datarow["YXTFWXZMC"] = obj.YXTFWXZMC;
				if(datarow.Table.Columns.Contains("SZC")) datarow["SZC"] = obj.SZC;
				if(datarow.Table.Columns.Contains("ZCS")) datarow["ZCS"] = obj.ZCS;
				if (obj.JGSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("JGSJ")) datarow["JGSJ"] = obj.JGSJ;
				}
				if(datarow.Table.Columns.Contains("FWJS")) datarow["FWJS"] = obj.FWJS;
				if(datarow.Table.Columns.Contains("ZDDM")) datarow["ZDDM"] = obj.ZDDM;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("ZTS")) datarow["ZTS"] = obj.ZTS;
				if(datarow.Table.Columns.Contains("XMMC")) datarow["XMMC"] = obj.XMMC;
				if(datarow.Table.Columns.Contains("DYH")) datarow["DYH"] = obj.DYH;
				if(datarow.Table.Columns.Contains("FJSXH")) datarow["FJSXH"] = obj.FJSXH;
				if(datarow.Table.Columns.Contains("FWLB")) datarow["FWLB"] = obj.FWLB;
				if(datarow.Table.Columns.Contains("FWDH")) datarow["FWDH"] = obj.FWDH;
				if(datarow.Table.Columns.Contains("FWLDH")) datarow["FWLDH"] = obj.FWLDH;
				if(datarow.Table.Columns.Contains("FWCB")) datarow["FWCB"] = obj.FWCB;
				if(datarow.Table.Columns.Contains("JCNF")) datarow["JCNF"] = obj.JCNF;
				if(datarow.Table.Columns.Contains("CQXZ")) datarow["CQXZ"] = obj.CQXZ;
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("ZFBSM")) datarow["ZFBSM"] = obj.ZFBSM;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("DCBSM")) datarow["DCBSM"] = obj.DCBSM;
				if(datarow.Table.Columns.Contains("KFXMXXBSM")) datarow["KFXMXXBSM"] = obj.KFXMXXBSM;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("MYCS")) datarow["MYCS"] = obj.MYCS;
				if(datarow.Table.Columns.Contains("DCYWH")) datarow["DCYWH"] = obj.DCYWH;
				if (obj.TDSYQSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("TDSYQSSJ")) datarow["TDSYQSSJ"] = obj.TDSYQSSJ;
				}
				if (obj.TDSYJSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("TDSYJSSJ")) datarow["TDSYJSSJ"] = obj.TDSYJSSJ;
				}
				if(datarow.Table.Columns.Contains("TDYT")) datarow["TDYT"] = obj.TDYT;
				if(datarow.Table.Columns.Contains("TDQLXZ")) datarow["TDQLXZ"] = obj.TDQLXZ;
				if(datarow.Table.Columns.Contains("ZDMJ")) datarow["ZDMJ"] = obj.ZDMJ;
				if (obj.BZ_GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("BZ_GXSJ")) datarow["BZ_GXSJ"] = obj.BZ_GXSJ;
				}
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("DCZDSHIYQBSM")) datarow["DCZDSHIYQBSM"] = obj.DCZDSHIYQBSM;
				if(datarow.Table.Columns.Contains("FFLB")) datarow["FFLB"] = obj.FFLB;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("TDYTMC")) datarow["TDYTMC"] = obj.TDYTMC;
				if(datarow.Table.Columns.Contains("YFWJG")) datarow["YFWJG"] = obj.YFWJG;
				if(datarow.Table.Columns.Contains("YFWCB")) datarow["YFWCB"] = obj.YFWCB;
				if(datarow.Table.Columns.Contains("PKBSM")) datarow["PKBSM"] = obj.PKBSM;
				if(datarow.Table.Columns.Contains("TDDJ")) datarow["TDDJ"] = obj.TDDJ;
				if(datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
				if(datarow.Table.Columns.Contains("SFJSMJ")) datarow["SFJSMJ"] = obj.SFJSMJ;
				if(datarow.Table.Columns.Contains("TDLY")) datarow["TDLY"] = obj.TDLY;
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
			clsH obj = null;
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
					obj = new clsH();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="ZDSHIYQBSM")
								if (pRow.Table.Columns.Contains("ZDSHIYQBSM") && pRow["ZDSHIYQBSM"] != DBNull.Value) { obj.ZDSHIYQBSM = Convert.ToInt64(pRow["ZDSHIYQBSM"]); }
							if(strFldName.ToUpper()=="ZRZBSM")
								if (pRow.Table.Columns.Contains("ZRZBSM") && pRow["ZRZBSM"] != DBNull.Value) { obj.ZRZBSM = Convert.ToInt64(pRow["ZRZBSM"]); }
							if(strFldName.ToUpper()=="LJZBSM")
								if (pRow.Table.Columns.Contains("LJZBSM") && pRow["LJZBSM"] != DBNull.Value) { obj.LJZBSM = Convert.ToInt64(pRow["LJZBSM"]); }
							if(strFldName.ToUpper()=="CBSM")
								if (pRow.Table.Columns.Contains("CBSM") && pRow["CBSM"] != DBNull.Value) { obj.CBSM = Convert.ToInt64(pRow["CBSM"]); }
							if(strFldName.ToUpper()=="FWBM")
								if (pRow.Table.Columns.Contains("FWBM") && pRow["FWBM"] != DBNull.Value) { obj.FWBM = Convert.ToString(pRow["FWBM"]); }
							if(strFldName.ToUpper()=="ZRZH")
								if (pRow.Table.Columns.Contains("ZRZH") && pRow["ZRZH"] != DBNull.Value) { obj.ZRZH = Convert.ToString(pRow["ZRZH"]); }
							if(strFldName.ToUpper()=="LJZH")
								if (pRow.Table.Columns.Contains("LJZH") && pRow["LJZH"] != DBNull.Value) { obj.LJZH = Convert.ToString(pRow["LJZH"]); }
							if(strFldName.ToUpper()=="CH")
								if (pRow.Table.Columns.Contains("CH") && pRow["CH"] != DBNull.Value) { obj.CH = Convert.ToString(pRow["CH"]); }
							if(strFldName.ToUpper()=="ZL")
								if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
							if(strFldName.ToUpper()=="SJCS")
								if (pRow.Table.Columns.Contains("SJCS") && pRow["SJCS"] != DBNull.Value) { obj.SJCS = Convert.ToDouble(pRow["SJCS"]); }
							if(strFldName.ToUpper()=="HH")
								if (pRow.Table.Columns.Contains("HH") && pRow["HH"] != DBNull.Value) { obj.HH = Convert.ToString(pRow["HH"]); }
							if(strFldName.ToUpper()=="SHBW")
								if (pRow.Table.Columns.Contains("SHBW") && pRow["SHBW"] != DBNull.Value) { obj.SHBW = Convert.ToString(pRow["SHBW"]); }
							if(strFldName.ToUpper()=="HX")
								if (pRow.Table.Columns.Contains("HX") && pRow["HX"] != DBNull.Value) { obj.HX = Convert.ToString(pRow["HX"]); }
							if(strFldName.ToUpper()=="HXJG")
								if (pRow.Table.Columns.Contains("HXJG") && pRow["HXJG"] != DBNull.Value) { obj.HXJG = Convert.ToString(pRow["HXJG"]); }
							if(strFldName.ToUpper()=="FWJG")
								if (pRow.Table.Columns.Contains("FWJG") && pRow["FWJG"] != DBNull.Value) { obj.FWJG = Convert.ToString(pRow["FWJG"]); }
							if(strFldName.ToUpper()=="FWYT1")
								if (pRow.Table.Columns.Contains("FWYT1") && pRow["FWYT1"] != DBNull.Value) { obj.FWYT1 = Convert.ToString(pRow["FWYT1"]); }
							if(strFldName.ToUpper()=="FWYT2")
								if (pRow.Table.Columns.Contains("FWYT2") && pRow["FWYT2"] != DBNull.Value) { obj.FWYT2 = Convert.ToString(pRow["FWYT2"]); }
							if(strFldName.ToUpper()=="FWYT3")
								if (pRow.Table.Columns.Contains("FWYT3") && pRow["FWYT3"] != DBNull.Value) { obj.FWYT3 = Convert.ToString(pRow["FWYT3"]); }
							if(strFldName.ToUpper()=="YXTFWYTMC1")
								if (pRow.Table.Columns.Contains("YXTFWYTMC1") && pRow["YXTFWYTMC1"] != DBNull.Value) { obj.YXTFWYTMC1 = Convert.ToString(pRow["YXTFWYTMC1"]); }
							if(strFldName.ToUpper()=="YXTFWYTMC2")
								if (pRow.Table.Columns.Contains("YXTFWYTMC2") && pRow["YXTFWYTMC2"] != DBNull.Value) { obj.YXTFWYTMC2 = Convert.ToString(pRow["YXTFWYTMC2"]); }
							if(strFldName.ToUpper()=="YXTFWYTMC3")
								if (pRow.Table.Columns.Contains("YXTFWYTMC3") && pRow["YXTFWYTMC3"] != DBNull.Value) { obj.YXTFWYTMC3 = Convert.ToString(pRow["YXTFWYTMC3"]); }
							if(strFldName.ToUpper()=="GHYT")
								if (pRow.Table.Columns.Contains("GHYT") && pRow["GHYT"] != DBNull.Value) { obj.GHYT = Convert.ToString(pRow["GHYT"]); }
							if(strFldName.ToUpper()=="YXTGHYTMC")
								if (pRow.Table.Columns.Contains("YXTGHYTMC") && pRow["YXTGHYTMC"] != DBNull.Value) { obj.YXTGHYTMC = Convert.ToString(pRow["YXTGHYTMC"]); }
							if(strFldName.ToUpper()=="YCJZMJ")
								if (pRow.Table.Columns.Contains("YCJZMJ") && pRow["YCJZMJ"] != DBNull.Value) { obj.YCJZMJ = Convert.ToDouble(pRow["YCJZMJ"]); }
							if(strFldName.ToUpper()=="YCTNJZMJ")
								if (pRow.Table.Columns.Contains("YCTNJZMJ") && pRow["YCTNJZMJ"] != DBNull.Value) { obj.YCTNJZMJ = Convert.ToDouble(pRow["YCTNJZMJ"]); }
							if(strFldName.ToUpper()=="YCFTJZMJ")
								if (pRow.Table.Columns.Contains("YCFTJZMJ") && pRow["YCFTJZMJ"] != DBNull.Value) { obj.YCFTJZMJ = Convert.ToDouble(pRow["YCFTJZMJ"]); }
							if(strFldName.ToUpper()=="YCDXBFJZMJ")
								if (pRow.Table.Columns.Contains("YCDXBFJZMJ") && pRow["YCDXBFJZMJ"] != DBNull.Value) { obj.YCDXBFJZMJ = Convert.ToDouble(pRow["YCDXBFJZMJ"]); }
							if(strFldName.ToUpper()=="YCQTJZMJ")
								if (pRow.Table.Columns.Contains("YCQTJZMJ") && pRow["YCQTJZMJ"] != DBNull.Value) { obj.YCQTJZMJ = Convert.ToDouble(pRow["YCQTJZMJ"]); }
							if(strFldName.ToUpper()=="YCFTXS")
								if (pRow.Table.Columns.Contains("YCFTXS") && pRow["YCFTXS"] != DBNull.Value) { obj.YCFTXS = Convert.ToDouble(pRow["YCFTXS"]); }
							if(strFldName.ToUpper()=="SCJZMJ")
								if (pRow.Table.Columns.Contains("SCJZMJ") && pRow["SCJZMJ"] != DBNull.Value) { obj.SCJZMJ = Convert.ToDouble(pRow["SCJZMJ"]); }
							if(strFldName.ToUpper()=="SCTNJZMJ")
								if (pRow.Table.Columns.Contains("SCTNJZMJ") && pRow["SCTNJZMJ"] != DBNull.Value) { obj.SCTNJZMJ = Convert.ToDouble(pRow["SCTNJZMJ"]); }
							if(strFldName.ToUpper()=="SCFTJZMJ")
								if (pRow.Table.Columns.Contains("SCFTJZMJ") && pRow["SCFTJZMJ"] != DBNull.Value) { obj.SCFTJZMJ = Convert.ToDouble(pRow["SCFTJZMJ"]); }
							if(strFldName.ToUpper()=="SCDXBFJZMJ")
								if (pRow.Table.Columns.Contains("SCDXBFJZMJ") && pRow["SCDXBFJZMJ"] != DBNull.Value) { obj.SCDXBFJZMJ = Convert.ToDouble(pRow["SCDXBFJZMJ"]); }
							if(strFldName.ToUpper()=="SCQTJZMJ")
								if (pRow.Table.Columns.Contains("SCQTJZMJ") && pRow["SCQTJZMJ"] != DBNull.Value) { obj.SCQTJZMJ = Convert.ToDouble(pRow["SCQTJZMJ"]); }
							if(strFldName.ToUpper()=="SCFTXS")
								if (pRow.Table.Columns.Contains("SCFTXS") && pRow["SCFTXS"] != DBNull.Value) { obj.SCFTXS = Convert.ToDouble(pRow["SCFTXS"]); }
							if(strFldName.ToUpper()=="GYTDMJ")
								if (pRow.Table.Columns.Contains("GYTDMJ") && pRow["GYTDMJ"] != DBNull.Value) { obj.GYTDMJ = Convert.ToDouble(pRow["GYTDMJ"]); }
							if(strFldName.ToUpper()=="FTTDMJ")
								if (pRow.Table.Columns.Contains("FTTDMJ") && pRow["FTTDMJ"] != DBNull.Value) { obj.FTTDMJ = Convert.ToDouble(pRow["FTTDMJ"]); }
							if(strFldName.ToUpper()=="DYTDMJ")
								if (pRow.Table.Columns.Contains("DYTDMJ") && pRow["DYTDMJ"] != DBNull.Value) { obj.DYTDMJ = Convert.ToDouble(pRow["DYTDMJ"]); }
							if(strFldName.ToUpper()=="TDSYQMJ")
								if (pRow.Table.Columns.Contains("TDSYQMJ") && pRow["TDSYQMJ"] != DBNull.Value) { obj.TDSYQMJ = Convert.ToDouble(pRow["TDSYQMJ"]); }
							if(strFldName.ToUpper()=="FWLX")
								if (pRow.Table.Columns.Contains("FWLX") && pRow["FWLX"] != DBNull.Value) { obj.FWLX = Convert.ToString(pRow["FWLX"]); }
							if(strFldName.ToUpper()=="YXTFWLXMC")
								if (pRow.Table.Columns.Contains("YXTFWLXMC") && pRow["YXTFWLXMC"] != DBNull.Value) { obj.YXTFWLXMC = Convert.ToString(pRow["YXTFWLXMC"]); }
							if(strFldName.ToUpper()=="FWXZ")
								if (pRow.Table.Columns.Contains("FWXZ") && pRow["FWXZ"] != DBNull.Value) { obj.FWXZ = Convert.ToString(pRow["FWXZ"]); }
							if(strFldName.ToUpper()=="YXTFWXZMC")
								if (pRow.Table.Columns.Contains("YXTFWXZMC") && pRow["YXTFWXZMC"] != DBNull.Value) { obj.YXTFWXZMC = Convert.ToString(pRow["YXTFWXZMC"]); }
							if(strFldName.ToUpper()=="SZC")
								if (pRow.Table.Columns.Contains("SZC") && pRow["SZC"] != DBNull.Value) { obj.SZC = Convert.ToString(pRow["SZC"]); }
							if(strFldName.ToUpper()=="ZCS")
								if (pRow.Table.Columns.Contains("ZCS") && pRow["ZCS"] != DBNull.Value) { obj.ZCS = Convert.ToInt64(pRow["ZCS"]); }
							if(strFldName.ToUpper()=="JGSJ")
								if (pRow.Table.Columns.Contains("JGSJ") && pRow["JGSJ"] != DBNull.Value) { obj.JGSJ = Convert.ToDateTime(pRow["JGSJ"]); }
							if(strFldName.ToUpper()=="FWJS")
								if (pRow.Table.Columns.Contains("FWJS") && pRow["FWJS"] != DBNull.Value) { obj.FWJS = Convert.ToString(pRow["FWJS"]); }
							if(strFldName.ToUpper()=="ZDDM")
								if (pRow.Table.Columns.Contains("ZDDM") && pRow["ZDDM"] != DBNull.Value) { obj.ZDDM = Convert.ToString(pRow["ZDDM"]); }
							if(strFldName.ToUpper()=="BDCDYH")
								if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
							if(strFldName.ToUpper()=="ZTS")
								if (pRow.Table.Columns.Contains("ZTS") && pRow["ZTS"] != DBNull.Value) { obj.ZTS = Convert.ToInt64(pRow["ZTS"]); }
							if(strFldName.ToUpper()=="XMMC")
								if (pRow.Table.Columns.Contains("XMMC") && pRow["XMMC"] != DBNull.Value) { obj.XMMC = Convert.ToString(pRow["XMMC"]); }
							if(strFldName.ToUpper()=="DYH")
								if (pRow.Table.Columns.Contains("DYH") && pRow["DYH"] != DBNull.Value) { obj.DYH = Convert.ToString(pRow["DYH"]); }
							if(strFldName.ToUpper()=="FJSXH")
								if (pRow.Table.Columns.Contains("FJSXH") && pRow["FJSXH"] != DBNull.Value) { obj.FJSXH = Convert.ToInt64(pRow["FJSXH"]); }
							if(strFldName.ToUpper()=="FWLB")
								if (pRow.Table.Columns.Contains("FWLB") && pRow["FWLB"] != DBNull.Value) { obj.FWLB = Convert.ToInt16(pRow["FWLB"]); }
							if(strFldName.ToUpper()=="FWDH")
								if (pRow.Table.Columns.Contains("FWDH") && pRow["FWDH"] != DBNull.Value) { obj.FWDH = Convert.ToString(pRow["FWDH"]); }
							if(strFldName.ToUpper()=="FWLDH")
								if (pRow.Table.Columns.Contains("FWLDH") && pRow["FWLDH"] != DBNull.Value) { obj.FWLDH = Convert.ToString(pRow["FWLDH"]); }
							if(strFldName.ToUpper()=="FWCB")
								if (pRow.Table.Columns.Contains("FWCB") && pRow["FWCB"] != DBNull.Value) { obj.FWCB = Convert.ToString(pRow["FWCB"]); }
							if(strFldName.ToUpper()=="JCNF")
								if (pRow.Table.Columns.Contains("JCNF") && pRow["JCNF"] != DBNull.Value) { obj.JCNF = Convert.ToString(pRow["JCNF"]); }
							if(strFldName.ToUpper()=="CQXZ")
								if (pRow.Table.Columns.Contains("CQXZ") && pRow["CQXZ"] != DBNull.Value) { obj.CQXZ = Convert.ToString(pRow["CQXZ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="ZFBSM")
								if (pRow.Table.Columns.Contains("ZFBSM") && pRow["ZFBSM"] != DBNull.Value) { obj.ZFBSM = Convert.ToInt64(pRow["ZFBSM"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
							if(strFldName.ToUpper()=="DCBSM")
								if (pRow.Table.Columns.Contains("DCBSM") && pRow["DCBSM"] != DBNull.Value) { obj.DCBSM = Convert.ToInt64(pRow["DCBSM"]); }
							if(strFldName.ToUpper()=="KFXMXXBSM")
								if (pRow.Table.Columns.Contains("KFXMXXBSM") && pRow["KFXMXXBSM"] != DBNull.Value) { obj.KFXMXXBSM = Convert.ToInt64(pRow["KFXMXXBSM"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="MYCS")
								if (pRow.Table.Columns.Contains("MYCS") && pRow["MYCS"] != DBNull.Value) { obj.MYCS = Convert.ToString(pRow["MYCS"]); }
							if(strFldName.ToUpper()=="DCYWH")
								if (pRow.Table.Columns.Contains("DCYWH") && pRow["DCYWH"] != DBNull.Value) { obj.DCYWH = Convert.ToString(pRow["DCYWH"]); }
							if(strFldName.ToUpper()=="TDSYQSSJ")
								if (pRow.Table.Columns.Contains("TDSYQSSJ") && pRow["TDSYQSSJ"] != DBNull.Value) { obj.TDSYQSSJ = Convert.ToDateTime(pRow["TDSYQSSJ"]); }
							if(strFldName.ToUpper()=="TDSYJSSJ")
								if (pRow.Table.Columns.Contains("TDSYJSSJ") && pRow["TDSYJSSJ"] != DBNull.Value) { obj.TDSYJSSJ = Convert.ToDateTime(pRow["TDSYJSSJ"]); }
							if(strFldName.ToUpper()=="TDYT")
								if (pRow.Table.Columns.Contains("TDYT") && pRow["TDYT"] != DBNull.Value) { obj.TDYT = Convert.ToString(pRow["TDYT"]); }
							if(strFldName.ToUpper()=="TDQLXZ")
								if (pRow.Table.Columns.Contains("TDQLXZ") && pRow["TDQLXZ"] != DBNull.Value) { obj.TDQLXZ = Convert.ToString(pRow["TDQLXZ"]); }
							if(strFldName.ToUpper()=="ZDMJ")
								if (pRow.Table.Columns.Contains("ZDMJ") && pRow["ZDMJ"] != DBNull.Value) { obj.ZDMJ = Convert.ToDouble(pRow["ZDMJ"]); }
							if(strFldName.ToUpper()=="BZ_GXSJ")
								if (pRow.Table.Columns.Contains("BZ_GXSJ") && pRow["BZ_GXSJ"] != DBNull.Value) { obj.BZ_GXSJ = Convert.ToDateTime(pRow["BZ_GXSJ"]); }
							
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							
							if(strFldName.ToUpper()=="DCZDSHIYQBSM")
								if (pRow.Table.Columns.Contains("DCZDSHIYQBSM") && pRow["DCZDSHIYQBSM"] != DBNull.Value) { obj.DCZDSHIYQBSM = Convert.ToInt64(pRow["DCZDSHIYQBSM"]); }
							if(strFldName.ToUpper()=="FFLB")
								if (pRow.Table.Columns.Contains("FFLB") && pRow["FFLB"] != DBNull.Value) { obj.FFLB = Convert.ToInt16(pRow["FFLB"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="TDYTMC")
								if (pRow.Table.Columns.Contains("TDYTMC") && pRow["TDYTMC"] != DBNull.Value) { obj.TDYTMC = Convert.ToString(pRow["TDYTMC"]); }
							if(strFldName.ToUpper()=="YFWJG")
								if (pRow.Table.Columns.Contains("YFWJG") && pRow["YFWJG"] != DBNull.Value) { obj.YFWJG = Convert.ToString(pRow["YFWJG"]); }
							if(strFldName.ToUpper()=="YFWCB")
								if (pRow.Table.Columns.Contains("YFWCB") && pRow["YFWCB"] != DBNull.Value) { obj.YFWCB = Convert.ToString(pRow["YFWCB"]); }
							if(strFldName.ToUpper()=="PKBSM")
								if (pRow.Table.Columns.Contains("PKBSM") && pRow["PKBSM"] != DBNull.Value) { obj.PKBSM = Convert.ToInt64(pRow["PKBSM"]); }

							if(strFldName.ToUpper()=="TDDJ")
								if (pRow.Table.Columns.Contains("TDDJ") && pRow["TDDJ"] != DBNull.Value) { obj.TDDJ = Convert.ToString(pRow["TDDJ"]); }
							
							if(strFldName.ToUpper()=="QSZT")
								if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToInt64(pRow["QSZT"]); }
						
							if(strFldName.ToUpper()=="SFJSMJ")
								if (pRow.Table.Columns.Contains("SFJSMJ") && pRow["SFJSMJ"] != DBNull.Value) { obj.SFJSMJ = Convert.ToInt16(pRow["SFJSMJ"]); }
							if(strFldName.ToUpper()=="TDLY")
								if (pRow.Table.Columns.Contains("TDLY") && pRow["TDLY"] != DBNull.Value) { obj.TDLY = Convert.ToInt64(pRow["TDLY"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("ZDSHIYQBSM") && pRow["ZDSHIYQBSM"] != DBNull.Value) { obj.ZDSHIYQBSM = Convert.ToInt64(pRow["ZDSHIYQBSM"]); }
						if (pRow.Table.Columns.Contains("ZRZBSM") && pRow["ZRZBSM"] != DBNull.Value) { obj.ZRZBSM = Convert.ToInt64(pRow["ZRZBSM"]); }
						if (pRow.Table.Columns.Contains("LJZBSM") && pRow["LJZBSM"] != DBNull.Value) { obj.LJZBSM = Convert.ToInt64(pRow["LJZBSM"]); }
						if (pRow.Table.Columns.Contains("CBSM") && pRow["CBSM"] != DBNull.Value) { obj.CBSM = Convert.ToInt64(pRow["CBSM"]); }
						if (pRow.Table.Columns.Contains("FWBM") && pRow["FWBM"] != DBNull.Value) { obj.FWBM = Convert.ToString(pRow["FWBM"]); }
						if (pRow.Table.Columns.Contains("ZRZH") && pRow["ZRZH"] != DBNull.Value) { obj.ZRZH = Convert.ToString(pRow["ZRZH"]); }
						if (pRow.Table.Columns.Contains("LJZH") && pRow["LJZH"] != DBNull.Value) { obj.LJZH = Convert.ToString(pRow["LJZH"]); }
						if (pRow.Table.Columns.Contains("CH") && pRow["CH"] != DBNull.Value) { obj.CH = Convert.ToString(pRow["CH"]); }
						if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
						if (pRow.Table.Columns.Contains("SJCS") && pRow["SJCS"] != DBNull.Value) { obj.SJCS = Convert.ToDouble(pRow["SJCS"]); }
						if (pRow.Table.Columns.Contains("HH") && pRow["HH"] != DBNull.Value) { obj.HH = Convert.ToString(pRow["HH"]); }
						if (pRow.Table.Columns.Contains("SHBW") && pRow["SHBW"] != DBNull.Value) { obj.SHBW = Convert.ToString(pRow["SHBW"]); }
						if (pRow.Table.Columns.Contains("HX") && pRow["HX"] != DBNull.Value) { obj.HX = Convert.ToString(pRow["HX"]); }
						if (pRow.Table.Columns.Contains("HXJG") && pRow["HXJG"] != DBNull.Value) { obj.HXJG = Convert.ToString(pRow["HXJG"]); }
						if (pRow.Table.Columns.Contains("FWJG") && pRow["FWJG"] != DBNull.Value) { obj.FWJG = Convert.ToString(pRow["FWJG"]); }
						if (pRow.Table.Columns.Contains("FWYT1") && pRow["FWYT1"] != DBNull.Value) { obj.FWYT1 = Convert.ToString(pRow["FWYT1"]); }
						if (pRow.Table.Columns.Contains("FWYT2") && pRow["FWYT2"] != DBNull.Value) { obj.FWYT2 = Convert.ToString(pRow["FWYT2"]); }
						if (pRow.Table.Columns.Contains("FWYT3") && pRow["FWYT3"] != DBNull.Value) { obj.FWYT3 = Convert.ToString(pRow["FWYT3"]); }
						if (pRow.Table.Columns.Contains("YXTFWYTMC1") && pRow["YXTFWYTMC1"] != DBNull.Value) { obj.YXTFWYTMC1 = Convert.ToString(pRow["YXTFWYTMC1"]); }
						if (pRow.Table.Columns.Contains("YXTFWYTMC2") && pRow["YXTFWYTMC2"] != DBNull.Value) { obj.YXTFWYTMC2 = Convert.ToString(pRow["YXTFWYTMC2"]); }
						if (pRow.Table.Columns.Contains("YXTFWYTMC3") && pRow["YXTFWYTMC3"] != DBNull.Value) { obj.YXTFWYTMC3 = Convert.ToString(pRow["YXTFWYTMC3"]); }
						if (pRow.Table.Columns.Contains("GHYT") && pRow["GHYT"] != DBNull.Value) { obj.GHYT = Convert.ToString(pRow["GHYT"]); }
						if (pRow.Table.Columns.Contains("YXTGHYTMC") && pRow["YXTGHYTMC"] != DBNull.Value) { obj.YXTGHYTMC = Convert.ToString(pRow["YXTGHYTMC"]); }
						if (pRow.Table.Columns.Contains("YCJZMJ") && pRow["YCJZMJ"] != DBNull.Value) { obj.YCJZMJ = Convert.ToDouble(pRow["YCJZMJ"]); }
						if (pRow.Table.Columns.Contains("YCTNJZMJ") && pRow["YCTNJZMJ"] != DBNull.Value) { obj.YCTNJZMJ = Convert.ToDouble(pRow["YCTNJZMJ"]); }
						if (pRow.Table.Columns.Contains("YCFTJZMJ") && pRow["YCFTJZMJ"] != DBNull.Value) { obj.YCFTJZMJ = Convert.ToDouble(pRow["YCFTJZMJ"]); }
						if (pRow.Table.Columns.Contains("YCDXBFJZMJ") && pRow["YCDXBFJZMJ"] != DBNull.Value) { obj.YCDXBFJZMJ = Convert.ToDouble(pRow["YCDXBFJZMJ"]); }
						if (pRow.Table.Columns.Contains("YCQTJZMJ") && pRow["YCQTJZMJ"] != DBNull.Value) { obj.YCQTJZMJ = Convert.ToDouble(pRow["YCQTJZMJ"]); }
						if (pRow.Table.Columns.Contains("YCFTXS") && pRow["YCFTXS"] != DBNull.Value) { obj.YCFTXS = Convert.ToDouble(pRow["YCFTXS"]); }
						if (pRow.Table.Columns.Contains("SCJZMJ") && pRow["SCJZMJ"] != DBNull.Value) { obj.SCJZMJ = Convert.ToDouble(pRow["SCJZMJ"]); }
						if (pRow.Table.Columns.Contains("SCTNJZMJ") && pRow["SCTNJZMJ"] != DBNull.Value) { obj.SCTNJZMJ = Convert.ToDouble(pRow["SCTNJZMJ"]); }
						if (pRow.Table.Columns.Contains("SCFTJZMJ") && pRow["SCFTJZMJ"] != DBNull.Value) { obj.SCFTJZMJ = Convert.ToDouble(pRow["SCFTJZMJ"]); }
						if (pRow.Table.Columns.Contains("SCDXBFJZMJ") && pRow["SCDXBFJZMJ"] != DBNull.Value) { obj.SCDXBFJZMJ = Convert.ToDouble(pRow["SCDXBFJZMJ"]); }
						if (pRow.Table.Columns.Contains("SCQTJZMJ") && pRow["SCQTJZMJ"] != DBNull.Value) { obj.SCQTJZMJ = Convert.ToDouble(pRow["SCQTJZMJ"]); }
						if (pRow.Table.Columns.Contains("SCFTXS") && pRow["SCFTXS"] != DBNull.Value) { obj.SCFTXS = Convert.ToDouble(pRow["SCFTXS"]); }
						if (pRow.Table.Columns.Contains("GYTDMJ") && pRow["GYTDMJ"] != DBNull.Value) { obj.GYTDMJ = Convert.ToDouble(pRow["GYTDMJ"]); }
						if (pRow.Table.Columns.Contains("FTTDMJ") && pRow["FTTDMJ"] != DBNull.Value) { obj.FTTDMJ = Convert.ToDouble(pRow["FTTDMJ"]); }
						if (pRow.Table.Columns.Contains("DYTDMJ") && pRow["DYTDMJ"] != DBNull.Value) { obj.DYTDMJ = Convert.ToDouble(pRow["DYTDMJ"]); }
						if (pRow.Table.Columns.Contains("TDSYQMJ") && pRow["TDSYQMJ"] != DBNull.Value) { obj.TDSYQMJ = Convert.ToDouble(pRow["TDSYQMJ"]); }
						if (pRow.Table.Columns.Contains("FWLX") && pRow["FWLX"] != DBNull.Value) { obj.FWLX = Convert.ToString(pRow["FWLX"]); }
						if (pRow.Table.Columns.Contains("YXTFWLXMC") && pRow["YXTFWLXMC"] != DBNull.Value) { obj.YXTFWLXMC = Convert.ToString(pRow["YXTFWLXMC"]); }
						if (pRow.Table.Columns.Contains("FWXZ") && pRow["FWXZ"] != DBNull.Value) { obj.FWXZ = Convert.ToString(pRow["FWXZ"]); }
						if (pRow.Table.Columns.Contains("YXTFWXZMC") && pRow["YXTFWXZMC"] != DBNull.Value) { obj.YXTFWXZMC = Convert.ToString(pRow["YXTFWXZMC"]); }
						if (pRow.Table.Columns.Contains("SZC") && pRow["SZC"] != DBNull.Value) { obj.SZC = Convert.ToString(pRow["SZC"]); }
						if (pRow.Table.Columns.Contains("ZCS") && pRow["ZCS"] != DBNull.Value) { obj.ZCS = Convert.ToInt64(pRow["ZCS"]); }
						if (pRow.Table.Columns.Contains("JGSJ") && pRow["JGSJ"] != DBNull.Value) { obj.JGSJ = Convert.ToDateTime(pRow["JGSJ"]); }
						if (pRow.Table.Columns.Contains("FWJS") && pRow["FWJS"] != DBNull.Value) { obj.FWJS = Convert.ToString(pRow["FWJS"]); }
						if (pRow.Table.Columns.Contains("ZDDM") && pRow["ZDDM"] != DBNull.Value) { obj.ZDDM = Convert.ToString(pRow["ZDDM"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("ZTS") && pRow["ZTS"] != DBNull.Value) { obj.ZTS = Convert.ToInt64(pRow["ZTS"]); }
						if (pRow.Table.Columns.Contains("XMMC") && pRow["XMMC"] != DBNull.Value) { obj.XMMC = Convert.ToString(pRow["XMMC"]); }
						if (pRow.Table.Columns.Contains("DYH") && pRow["DYH"] != DBNull.Value) { obj.DYH = Convert.ToString(pRow["DYH"]); }
						if (pRow.Table.Columns.Contains("FJSXH") && pRow["FJSXH"] != DBNull.Value) { obj.FJSXH = Convert.ToInt64(pRow["FJSXH"]); }
						if (pRow.Table.Columns.Contains("FWLB") && pRow["FWLB"] != DBNull.Value) { obj.FWLB = Convert.ToInt16(pRow["FWLB"]); }
						if (pRow.Table.Columns.Contains("FWDH") && pRow["FWDH"] != DBNull.Value) { obj.FWDH = Convert.ToString(pRow["FWDH"]); }
						if (pRow.Table.Columns.Contains("FWLDH") && pRow["FWLDH"] != DBNull.Value) { obj.FWLDH = Convert.ToString(pRow["FWLDH"]); }
						if (pRow.Table.Columns.Contains("FWCB") && pRow["FWCB"] != DBNull.Value) { obj.FWCB = Convert.ToString(pRow["FWCB"]); }
						if (pRow.Table.Columns.Contains("JCNF") && pRow["JCNF"] != DBNull.Value) { obj.JCNF = Convert.ToString(pRow["JCNF"]); }
						if (pRow.Table.Columns.Contains("CQXZ") && pRow["CQXZ"] != DBNull.Value) { obj.CQXZ = Convert.ToString(pRow["CQXZ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("ZFBSM") && pRow["ZFBSM"] != DBNull.Value) { obj.ZFBSM = Convert.ToInt64(pRow["ZFBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("DCBSM") && pRow["DCBSM"] != DBNull.Value) { obj.DCBSM = Convert.ToInt64(pRow["DCBSM"]); }
						if (pRow.Table.Columns.Contains("KFXMXXBSM") && pRow["KFXMXXBSM"] != DBNull.Value) { obj.KFXMXXBSM = Convert.ToInt64(pRow["KFXMXXBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("MYCS") && pRow["MYCS"] != DBNull.Value) { obj.MYCS = Convert.ToString(pRow["MYCS"]); }
						if (pRow.Table.Columns.Contains("DCYWH") && pRow["DCYWH"] != DBNull.Value) { obj.DCYWH = Convert.ToString(pRow["DCYWH"]); }
						if (pRow.Table.Columns.Contains("TDSYQSSJ") && pRow["TDSYQSSJ"] != DBNull.Value) { obj.TDSYQSSJ = Convert.ToDateTime(pRow["TDSYQSSJ"]); }
						if (pRow.Table.Columns.Contains("TDSYJSSJ") && pRow["TDSYJSSJ"] != DBNull.Value) { obj.TDSYJSSJ = Convert.ToDateTime(pRow["TDSYJSSJ"]); }
						if (pRow.Table.Columns.Contains("TDYT") && pRow["TDYT"] != DBNull.Value) { obj.TDYT = Convert.ToString(pRow["TDYT"]); }
						if (pRow.Table.Columns.Contains("TDQLXZ") && pRow["TDQLXZ"] != DBNull.Value) { obj.TDQLXZ = Convert.ToString(pRow["TDQLXZ"]); }
						if (pRow.Table.Columns.Contains("ZDMJ") && pRow["ZDMJ"] != DBNull.Value) { obj.ZDMJ = Convert.ToDouble(pRow["ZDMJ"]); }
						if (pRow.Table.Columns.Contains("BZ_GXSJ") && pRow["BZ_GXSJ"] != DBNull.Value) { obj.BZ_GXSJ = Convert.ToDateTime(pRow["BZ_GXSJ"]); }
					
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						
						if (pRow.Table.Columns.Contains("DCZDSHIYQBSM") && pRow["DCZDSHIYQBSM"] != DBNull.Value) { obj.DCZDSHIYQBSM = Convert.ToInt64(pRow["DCZDSHIYQBSM"]); }
						if (pRow.Table.Columns.Contains("FFLB") && pRow["FFLB"] != DBNull.Value) { obj.FFLB = Convert.ToInt16(pRow["FFLB"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("TDYTMC") && pRow["TDYTMC"] != DBNull.Value) { obj.TDYTMC = Convert.ToString(pRow["TDYTMC"]); }
						if (pRow.Table.Columns.Contains("YFWJG") && pRow["YFWJG"] != DBNull.Value) { obj.YFWJG = Convert.ToString(pRow["YFWJG"]); }
						if (pRow.Table.Columns.Contains("YFWCB") && pRow["YFWCB"] != DBNull.Value) { obj.YFWCB = Convert.ToString(pRow["YFWCB"]); }
						if (pRow.Table.Columns.Contains("PKBSM") && pRow["PKBSM"] != DBNull.Value) { obj.PKBSM = Convert.ToInt64(pRow["PKBSM"]); }
					
						if (pRow.Table.Columns.Contains("TDDJ") && pRow["TDDJ"] != DBNull.Value) { obj.TDDJ = Convert.ToString(pRow["TDDJ"]); }
					
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToInt64(pRow["QSZT"]); }
						
						if (pRow.Table.Columns.Contains("SFJSMJ") && pRow["SFJSMJ"] != DBNull.Value) { obj.SFJSMJ = Convert.ToInt16(pRow["SFJSMJ"]); }
						if (pRow.Table.Columns.Contains("TDLY") && pRow["TDLY"] != DBNull.Value) { obj.TDLY = Convert.ToInt64(pRow["TDLY"]); }
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
