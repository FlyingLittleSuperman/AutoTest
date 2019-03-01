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

	public class Fld_DJFZDJZM
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string BDCDYH="BDCDYH";
		public const string BDCDJZMH="BDCDJZMH";
		public const string DJZMZL="DJZMZL";
		public const string QLBSM="QLBSM";
		public const string QLBM="QLBM";
		public const string ZMQLHSX="ZMQLHSX";
		public const string QLR="QLR";
		public const string YWR="YWR";
		public const string ZL="ZL";
		public const string QT="QT";
		public const string FJ="FJ";
		public const string FZJC="FZJC";
		public const string FZDQ="FZDQ";
		public const string FZNF="FZNF";
		public const string FZBM="FZBM";
		public const string FZXH="FZXH";
		public const string FZGBH="FZGBH";
		public const string SZR="SZR";
		public const string SZSJ="SZSJ";
		public const string SZRSGZH="SZRSGZH";
		public const string SZRBSM="SZRBSM";
		public const string SZRDNBH="SZRDNBH";
		public const string FZR="FZR";
		public const string FZSJ="FZSJ";
		public const string FZRSGZH="FZRSGZH";
		public const string FZRBSM="FZRBSM";
		public const string LZR="LZR";
		public const string LZRZJZL="LZRZJZL";
		public const string LZRZJH="LZRZJH";
		public const string LZRDH="LZRDH";
		public const string LZRDZ="LZRDZ";
		public const string LZRYB="LZRYB";
		public const string LZSJ="LZSJ";
		public const string QSZT="QSZT";
		public const string FZJG="FZJG";
		public const string QXDM="QXDM";
		public const string YXTBSM="YXTBSM";
		public const string YXTBM="YXTBM";
		public const string BZ_YGTYPE="BZ_YGTYPE";
		public const string BZ_TDESC="BZ_TDESC";
		public const string BZ_FJ_DESC="BZ_FJ_DESC";
		public const string BZ_QL_TYPE="BZ_QL_TYPE";
		public const string BZ_APPEND="BZ_APPEND";
		public const string REV_="REV_";
		public const string SBH="SBH";
		public const string BZ_DY_ID="BZ_DY_ID";
		public const string BZ_QLR_ID="BZ_QLR_ID";
		public const string BZ_DYR_ID="BZ_DYR_ID";
		public const string BZ_XMBSM="BZ_XMBSM";
		public const string BZ_DY_NM="BZ_DY_NM";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string JZMJ="JZMJ";
		public const string DYCS="DYCS";
		public const string BZ_编号="BZ_编号";
		public const string BZ_ID="BZ_ID";
		#endregion
	}

	public class clsDJFZDJZM:IEntity
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
		private string m_BDCDYH;
		private string m_BDCDJZMH;
		private string m_DJZMZL;
		private long m_QLBSM;
		private string m_QLBM;
		private string m_ZMQLHSX;
		private string m_QLR;
		private string m_YWR;
		private string m_ZL;
		private string m_QT;
		private string m_FJ;
		private string m_FZJC;
		private string m_FZDQ;
		private long m_FZNF;
		private string m_FZBM;
		private long m_FZXH;
		private string m_FZGBH;
		private string m_SZR;
		private DateTime m_SZSJ;
		private string m_SZRSGZH;
		private string m_SZRBSM;
		private string m_SZRDNBH;
		private string m_FZR;
		private DateTime m_FZSJ;
		private string m_FZRSGZH;
		private string m_FZRBSM;
		private string m_LZR;
		private string m_LZRZJZL;
		private string m_LZRZJH;
		private string m_LZRDH;
		private string m_LZRDZ;
		private string m_LZRYB;
		private DateTime m_LZSJ;
		private string m_QSZT;
		private string m_FZJG;
		private long m_QXDM;
		private string m_YXTBSM;
		private string m_YXTBM;
		private long m_REV_;
		private string m_SBH;
	
		private DateTime m_GXSJ;
		private string m_BZ;
		private double m_JZMJ;
		private long m_DYCS;

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
		public string BDCDYH
		{
			get{ return m_BDCDYH; }
			set{ m_BDCDYH = value; }
		}
		public string BDCDJZMH
		{
			get{ return m_BDCDJZMH; }
			set{ m_BDCDJZMH = value; }
		}
		public string DJZMZL
		{
			get{ return m_DJZMZL; }
			set{ m_DJZMZL = value; }
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
		public string ZMQLHSX
		{
			get{ return m_ZMQLHSX; }
			set{ m_ZMQLHSX = value; }
		}
		public string QLR
		{
			get{ return m_QLR; }
			set{ m_QLR = value; }
		}
		public string YWR
		{
			get{ return m_YWR; }
			set{ m_YWR = value; }
		}
		public string ZL
		{
			get{ return m_ZL; }
			set{ m_ZL = value; }
		}
		public string QT
		{
			get{ return m_QT; }
			set{ m_QT = value; }
		}
		public string FJ
		{
			get{ return m_FJ; }
			set{ m_FJ = value; }
		}
		public string FZJC
		{
			get{ return m_FZJC; }
			set{ m_FZJC = value; }
		}
		public string FZDQ
		{
			get{ return m_FZDQ; }
			set{ m_FZDQ = value; }
		}
		public long FZNF
		{
			get{ return m_FZNF; }
			set{ m_FZNF = value; }
		}
		public string FZBM
		{
			get{ return m_FZBM; }
			set{ m_FZBM = value; }
		}
		public long FZXH
		{
			get{ return m_FZXH; }
			set{ m_FZXH = value; }
		}
		public string FZGBH
		{
			get{ return m_FZGBH; }
			set{ m_FZGBH = value; }
		}
		public string SZR
		{
			get{ return m_SZR; }
			set{ m_SZR = value; }
		}
		public DateTime SZSJ
		{
			get{ return m_SZSJ; }
			set{ m_SZSJ = value; }
		}
		public string SZRSGZH
		{
			get{ return m_SZRSGZH; }
			set{ m_SZRSGZH = value; }
		}
		public string SZRBSM
		{
			get{ return m_SZRBSM; }
			set{ m_SZRBSM = value; }
		}
		public string SZRDNBH
		{
			get{ return m_SZRDNBH; }
			set{ m_SZRDNBH = value; }
		}
		public string FZR
		{
			get{ return m_FZR; }
			set{ m_FZR = value; }
		}
		public DateTime FZSJ
		{
			get{ return m_FZSJ; }
			set{ m_FZSJ = value; }
		}
		public string FZRSGZH
		{
			get{ return m_FZRSGZH; }
			set{ m_FZRSGZH = value; }
		}
		public string FZRBSM
		{
			get{ return m_FZRBSM; }
			set{ m_FZRBSM = value; }
		}
		public string LZR
		{
			get{ return m_LZR; }
			set{ m_LZR = value; }
		}
		public string LZRZJZL
		{
			get{ return m_LZRZJZL; }
			set{ m_LZRZJZL = value; }
		}
		public string LZRZJH
		{
			get{ return m_LZRZJH; }
			set{ m_LZRZJH = value; }
		}
		public string LZRDH
		{
			get{ return m_LZRDH; }
			set{ m_LZRDH = value; }
		}
		public string LZRDZ
		{
			get{ return m_LZRDZ; }
			set{ m_LZRDZ = value; }
		}
		public string LZRYB
		{
			get{ return m_LZRYB; }
			set{ m_LZRYB = value; }
		}
		public DateTime LZSJ
		{
			get{ return m_LZSJ; }
			set{ m_LZSJ = value; }
		}
		public string QSZT
		{
			get{ return m_QSZT; }
			set{ m_QSZT = value; }
		}
		public string FZJG
		{
			get{ return m_FZJG; }
			set{ m_FZJG = value; }
		}
		public long QXDM
		{
			get{ return m_QXDM; }
			set{ m_QXDM = value; }
		}
		public string YXTBSM
		{
			get{ return m_YXTBSM; }
			set{ m_YXTBSM = value; }
		}
		public string YXTBM
		{
			get{ return m_YXTBM; }
			set{ m_YXTBM = value; }
		}
		
		public long REV_
		{
			get{ return m_REV_; }
			set{ m_REV_ = value; }
		}
		public string SBH
		{
			get{ return m_SBH; }
			set{ m_SBH = value; }
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
		public double JZMJ
		{
			get{ return m_JZMJ; }
			set{ m_JZMJ = value; }
		}
		public long DYCS
		{
			get{ return m_DYCS; }
			set{ m_DYCS = value; }
		}
		
		#endregion
		public bool IsEquals(clsDJFZDJZM obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.BDCDJZMH != obj.BDCDJZMH) bolResult = false;
			if (this.DJZMZL != obj.DJZMZL) bolResult = false;
			if (this.QLBSM != obj.QLBSM) bolResult = false;
			if (this.QLBM != obj.QLBM) bolResult = false;
			if (this.ZMQLHSX != obj.ZMQLHSX) bolResult = false;
			if (this.QLR != obj.QLR) bolResult = false;
			if (this.YWR != obj.YWR) bolResult = false;
			if (this.ZL != obj.ZL) bolResult = false;
			if (this.QT != obj.QT) bolResult = false;
			if (this.FJ != obj.FJ) bolResult = false;
			if (this.FZJC != obj.FZJC) bolResult = false;
			if (this.FZDQ != obj.FZDQ) bolResult = false;
			if (this.FZNF != obj.FZNF) bolResult = false;
			if (this.FZBM != obj.FZBM) bolResult = false;
			if (this.FZXH != obj.FZXH) bolResult = false;
			if (this.FZGBH != obj.FZGBH) bolResult = false;
			if (this.SZR != obj.SZR) bolResult = false;
			if (this.SZSJ != obj.SZSJ) bolResult = false;
			if (this.SZRSGZH != obj.SZRSGZH) bolResult = false;
			if (this.SZRBSM != obj.SZRBSM) bolResult = false;
			if (this.SZRDNBH != obj.SZRDNBH) bolResult = false;
			if (this.FZR != obj.FZR) bolResult = false;
			if (this.FZSJ != obj.FZSJ) bolResult = false;
			if (this.FZRSGZH != obj.FZRSGZH) bolResult = false;
			if (this.FZRBSM != obj.FZRBSM) bolResult = false;
			if (this.LZR != obj.LZR) bolResult = false;
			if (this.LZRZJZL != obj.LZRZJZL) bolResult = false;
			if (this.LZRZJH != obj.LZRZJH) bolResult = false;
			if (this.LZRDH != obj.LZRDH) bolResult = false;
			if (this.LZRDZ != obj.LZRDZ) bolResult = false;
			if (this.LZRYB != obj.LZRYB) bolResult = false;
			if (this.LZSJ != obj.LZSJ) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.FZJG != obj.FZJG) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;

			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.SBH != obj.SBH) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.JZMJ != obj.JZMJ) bolResult = false;
			if (this.DYCS != obj.DYCS) bolResult = false;
			return bolResult;
		}

		public void Colne(clsDJFZDJZM obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.BDCDYH=obj.BDCDYH;
			this.BDCDJZMH=obj.BDCDJZMH;
			this.DJZMZL=obj.DJZMZL;
			this.QLBSM=obj.QLBSM;
			this.QLBM=obj.QLBM;
			this.ZMQLHSX=obj.ZMQLHSX;
			this.QLR=obj.QLR;
			this.YWR=obj.YWR;
			this.ZL=obj.ZL;
			this.QT=obj.QT;
			this.FJ=obj.FJ;
			this.FZJC=obj.FZJC;
			this.FZDQ=obj.FZDQ;
			this.FZNF=obj.FZNF;
			this.FZBM=obj.FZBM;
			this.FZXH=obj.FZXH;
			this.FZGBH=obj.FZGBH;
			this.SZR=obj.SZR;
			this.SZSJ=obj.SZSJ;
			this.SZRSGZH=obj.SZRSGZH;
			this.SZRBSM=obj.SZRBSM;
			this.SZRDNBH=obj.SZRDNBH;
			this.FZR=obj.FZR;
			this.FZSJ=obj.FZSJ;
			this.FZRSGZH=obj.FZRSGZH;
			this.FZRBSM=obj.FZRBSM;
			this.LZR=obj.LZR;
			this.LZRZJZL=obj.LZRZJZL;
			this.LZRZJH=obj.LZRZJH;
			this.LZRDH=obj.LZRDH;
			this.LZRDZ=obj.LZRDZ;
			this.LZRYB=obj.LZRYB;
			this.LZSJ=obj.LZSJ;
			this.QSZT=obj.QSZT;
			this.FZJG=obj.FZJG;
			this.QXDM=obj.QXDM;
			this.YXTBSM=obj.YXTBSM;
			this.YXTBM=obj.YXTBM;
			this.REV_=obj.REV_;
			this.SBH=obj.SBH;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.JZMJ=obj.JZMJ;
			this.DYCS=obj.DYCS;
		}

	}

	public class clsDJFZDJZMSet:EntityBaseSet
	{
		public clsDJFZDJZMSet()
		{
			m_TableName="BDCDJ.DJFZ_DJZM";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsDJFZDJZMSet";
		}
		public static clsDJFZDJZMSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsDJFZDJZMSet clsSet = new clsDJFZDJZMSet(); //(clsDJFZDJZMSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsDJFZDJZMSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsDJFZDJZM obj = (clsDJFZDJZM)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("BDCDJZMH")) datarow["BDCDJZMH"] = obj.BDCDJZMH;
				if(datarow.Table.Columns.Contains("DJZMZL")) datarow["DJZMZL"] = obj.DJZMZL;
				if(datarow.Table.Columns.Contains("QLBSM")) datarow["QLBSM"] = obj.QLBSM;
				if(datarow.Table.Columns.Contains("QLBM")) datarow["QLBM"] = obj.QLBM;
				if(datarow.Table.Columns.Contains("ZMQLHSX")) datarow["ZMQLHSX"] = obj.ZMQLHSX;
				if(datarow.Table.Columns.Contains("QLR")) datarow["QLR"] = obj.QLR;
				if(datarow.Table.Columns.Contains("YWR")) datarow["YWR"] = obj.YWR;
				if(datarow.Table.Columns.Contains("ZL")) datarow["ZL"] = obj.ZL;
				if(datarow.Table.Columns.Contains("QT")) datarow["QT"] = obj.QT;
				if(datarow.Table.Columns.Contains("FJ")) datarow["FJ"] = obj.FJ;
				if(datarow.Table.Columns.Contains("FZJC")) datarow["FZJC"] = obj.FZJC;
				if(datarow.Table.Columns.Contains("FZDQ")) datarow["FZDQ"] = obj.FZDQ;
				if(datarow.Table.Columns.Contains("FZNF")) datarow["FZNF"] = obj.FZNF;
				if(datarow.Table.Columns.Contains("FZBM")) datarow["FZBM"] = obj.FZBM;
				if(datarow.Table.Columns.Contains("FZXH")) datarow["FZXH"] = obj.FZXH;
				if(datarow.Table.Columns.Contains("FZGBH")) datarow["FZGBH"] = obj.FZGBH;
				if(datarow.Table.Columns.Contains("SZR")) datarow["SZR"] = obj.SZR;
				if (obj.SZSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("SZSJ")) datarow["SZSJ"] = obj.SZSJ;
				}
				if(datarow.Table.Columns.Contains("SZRSGZH")) datarow["SZRSGZH"] = obj.SZRSGZH;
				if(datarow.Table.Columns.Contains("SZRBSM")) datarow["SZRBSM"] = obj.SZRBSM;
				if(datarow.Table.Columns.Contains("SZRDNBH")) datarow["SZRDNBH"] = obj.SZRDNBH;
				if(datarow.Table.Columns.Contains("FZR")) datarow["FZR"] = obj.FZR;
				if (obj.FZSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("FZSJ")) datarow["FZSJ"] = obj.FZSJ;
				}
				if(datarow.Table.Columns.Contains("FZRSGZH")) datarow["FZRSGZH"] = obj.FZRSGZH;
				if(datarow.Table.Columns.Contains("FZRBSM")) datarow["FZRBSM"] = obj.FZRBSM;
				if(datarow.Table.Columns.Contains("LZR")) datarow["LZR"] = obj.LZR;
				if(datarow.Table.Columns.Contains("LZRZJZL")) datarow["LZRZJZL"] = obj.LZRZJZL;
				if(datarow.Table.Columns.Contains("LZRZJH")) datarow["LZRZJH"] = obj.LZRZJH;
				if(datarow.Table.Columns.Contains("LZRDH")) datarow["LZRDH"] = obj.LZRDH;
				if(datarow.Table.Columns.Contains("LZRDZ")) datarow["LZRDZ"] = obj.LZRDZ;
				if(datarow.Table.Columns.Contains("LZRYB")) datarow["LZRYB"] = obj.LZRYB;
				if (obj.LZSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("LZSJ")) datarow["LZSJ"] = obj.LZSJ;
				}
				if(datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
				if(datarow.Table.Columns.Contains("FZJG")) datarow["FZJG"] = obj.FZJG;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("SBH")) datarow["SBH"] = obj.SBH;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("JZMJ")) datarow["JZMJ"] = obj.JZMJ;
				if(datarow.Table.Columns.Contains("DYCS")) datarow["DYCS"] = obj.DYCS;
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
			clsDJFZDJZM obj = null;
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
					obj = new clsDJFZDJZM();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="BDCDYH")
								if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
							if(strFldName.ToUpper()=="BDCDJZMH")
								if (pRow.Table.Columns.Contains("BDCDJZMH") && pRow["BDCDJZMH"] != DBNull.Value) { obj.BDCDJZMH = Convert.ToString(pRow["BDCDJZMH"]); }
							if(strFldName.ToUpper()=="DJZMZL")
								if (pRow.Table.Columns.Contains("DJZMZL") && pRow["DJZMZL"] != DBNull.Value) { obj.DJZMZL = Convert.ToString(pRow["DJZMZL"]); }
							if(strFldName.ToUpper()=="QLBSM")
								if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
							if(strFldName.ToUpper()=="QLBM")
								if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
							if(strFldName.ToUpper()=="ZMQLHSX")
								if (pRow.Table.Columns.Contains("ZMQLHSX") && pRow["ZMQLHSX"] != DBNull.Value) { obj.ZMQLHSX = Convert.ToString(pRow["ZMQLHSX"]); }
							if(strFldName.ToUpper()=="QLR")
								if (pRow.Table.Columns.Contains("QLR") && pRow["QLR"] != DBNull.Value) { obj.QLR = Convert.ToString(pRow["QLR"]); }
							if(strFldName.ToUpper()=="YWR")
								if (pRow.Table.Columns.Contains("YWR") && pRow["YWR"] != DBNull.Value) { obj.YWR = Convert.ToString(pRow["YWR"]); }
							if(strFldName.ToUpper()=="ZL")
								if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
							if(strFldName.ToUpper()=="QT")
								if (pRow.Table.Columns.Contains("QT") && pRow["QT"] != DBNull.Value) { obj.QT = Convert.ToString(pRow["QT"]); }
							if(strFldName.ToUpper()=="FJ")
								if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
							if(strFldName.ToUpper()=="FZJC")
								if (pRow.Table.Columns.Contains("FZJC") && pRow["FZJC"] != DBNull.Value) { obj.FZJC = Convert.ToString(pRow["FZJC"]); }
							if(strFldName.ToUpper()=="FZDQ")
								if (pRow.Table.Columns.Contains("FZDQ") && pRow["FZDQ"] != DBNull.Value) { obj.FZDQ = Convert.ToString(pRow["FZDQ"]); }
							if(strFldName.ToUpper()=="FZNF")
								if (pRow.Table.Columns.Contains("FZNF") && pRow["FZNF"] != DBNull.Value) { obj.FZNF = Convert.ToInt64(pRow["FZNF"]); }
							if(strFldName.ToUpper()=="FZBM")
								if (pRow.Table.Columns.Contains("FZBM") && pRow["FZBM"] != DBNull.Value) { obj.FZBM = Convert.ToString(pRow["FZBM"]); }
							if(strFldName.ToUpper()=="FZXH")
								if (pRow.Table.Columns.Contains("FZXH") && pRow["FZXH"] != DBNull.Value) { obj.FZXH = Convert.ToInt64(pRow["FZXH"]); }
							if(strFldName.ToUpper()=="FZGBH")
								if (pRow.Table.Columns.Contains("FZGBH") && pRow["FZGBH"] != DBNull.Value) { obj.FZGBH = Convert.ToString(pRow["FZGBH"]); }
							if(strFldName.ToUpper()=="SZR")
								if (pRow.Table.Columns.Contains("SZR") && pRow["SZR"] != DBNull.Value) { obj.SZR = Convert.ToString(pRow["SZR"]); }
							if(strFldName.ToUpper()=="SZSJ")
								if (pRow.Table.Columns.Contains("SZSJ") && pRow["SZSJ"] != DBNull.Value) { obj.SZSJ = Convert.ToDateTime(pRow["SZSJ"]); }
							if(strFldName.ToUpper()=="SZRSGZH")
								if (pRow.Table.Columns.Contains("SZRSGZH") && pRow["SZRSGZH"] != DBNull.Value) { obj.SZRSGZH = Convert.ToString(pRow["SZRSGZH"]); }
							if(strFldName.ToUpper()=="SZRBSM")
								if (pRow.Table.Columns.Contains("SZRBSM") && pRow["SZRBSM"] != DBNull.Value) { obj.SZRBSM = Convert.ToString(pRow["SZRBSM"]); }
							if(strFldName.ToUpper()=="SZRDNBH")
								if (pRow.Table.Columns.Contains("SZRDNBH") && pRow["SZRDNBH"] != DBNull.Value) { obj.SZRDNBH = Convert.ToString(pRow["SZRDNBH"]); }
							if(strFldName.ToUpper()=="FZR")
								if (pRow.Table.Columns.Contains("FZR") && pRow["FZR"] != DBNull.Value) { obj.FZR = Convert.ToString(pRow["FZR"]); }
							if(strFldName.ToUpper()=="FZSJ")
								if (pRow.Table.Columns.Contains("FZSJ") && pRow["FZSJ"] != DBNull.Value) { obj.FZSJ = Convert.ToDateTime(pRow["FZSJ"]); }
							if(strFldName.ToUpper()=="FZRSGZH")
								if (pRow.Table.Columns.Contains("FZRSGZH") && pRow["FZRSGZH"] != DBNull.Value) { obj.FZRSGZH = Convert.ToString(pRow["FZRSGZH"]); }
							if(strFldName.ToUpper()=="FZRBSM")
								if (pRow.Table.Columns.Contains("FZRBSM") && pRow["FZRBSM"] != DBNull.Value) { obj.FZRBSM = Convert.ToString(pRow["FZRBSM"]); }
							if(strFldName.ToUpper()=="LZR")
								if (pRow.Table.Columns.Contains("LZR") && pRow["LZR"] != DBNull.Value) { obj.LZR = Convert.ToString(pRow["LZR"]); }
							if(strFldName.ToUpper()=="LZRZJZL")
								if (pRow.Table.Columns.Contains("LZRZJZL") && pRow["LZRZJZL"] != DBNull.Value) { obj.LZRZJZL = Convert.ToString(pRow["LZRZJZL"]); }
							if(strFldName.ToUpper()=="LZRZJH")
								if (pRow.Table.Columns.Contains("LZRZJH") && pRow["LZRZJH"] != DBNull.Value) { obj.LZRZJH = Convert.ToString(pRow["LZRZJH"]); }
							if(strFldName.ToUpper()=="LZRDH")
								if (pRow.Table.Columns.Contains("LZRDH") && pRow["LZRDH"] != DBNull.Value) { obj.LZRDH = Convert.ToString(pRow["LZRDH"]); }
							if(strFldName.ToUpper()=="LZRDZ")
								if (pRow.Table.Columns.Contains("LZRDZ") && pRow["LZRDZ"] != DBNull.Value) { obj.LZRDZ = Convert.ToString(pRow["LZRDZ"]); }
							if(strFldName.ToUpper()=="LZRYB")
								if (pRow.Table.Columns.Contains("LZRYB") && pRow["LZRYB"] != DBNull.Value) { obj.LZRYB = Convert.ToString(pRow["LZRYB"]); }
							if(strFldName.ToUpper()=="LZSJ")
								if (pRow.Table.Columns.Contains("LZSJ") && pRow["LZSJ"] != DBNull.Value) { obj.LZSJ = Convert.ToDateTime(pRow["LZSJ"]); }
							if(strFldName.ToUpper()=="QSZT")
								if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
							if(strFldName.ToUpper()=="FZJG")
								if (pRow.Table.Columns.Contains("FZJG") && pRow["FZJG"] != DBNull.Value) { obj.FZJG = Convert.ToString(pRow["FZJG"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="SBH")
								if (pRow.Table.Columns.Contains("SBH") && pRow["SBH"] != DBNull.Value) { obj.SBH = Convert.ToString(pRow["SBH"]); }
							
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="JZMJ")
								if (pRow.Table.Columns.Contains("JZMJ") && pRow["JZMJ"] != DBNull.Value) { obj.JZMJ = Convert.ToDouble(pRow["JZMJ"]); }
							if(strFldName.ToUpper()=="DYCS")
								if (pRow.Table.Columns.Contains("DYCS") && pRow["DYCS"] != DBNull.Value) { obj.DYCS = Convert.ToInt64(pRow["DYCS"]); }
							
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("BDCDJZMH") && pRow["BDCDJZMH"] != DBNull.Value) { obj.BDCDJZMH = Convert.ToString(pRow["BDCDJZMH"]); }
						if (pRow.Table.Columns.Contains("DJZMZL") && pRow["DJZMZL"] != DBNull.Value) { obj.DJZMZL = Convert.ToString(pRow["DJZMZL"]); }
						if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
						if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
						if (pRow.Table.Columns.Contains("ZMQLHSX") && pRow["ZMQLHSX"] != DBNull.Value) { obj.ZMQLHSX = Convert.ToString(pRow["ZMQLHSX"]); }
						if (pRow.Table.Columns.Contains("QLR") && pRow["QLR"] != DBNull.Value) { obj.QLR = Convert.ToString(pRow["QLR"]); }
						if (pRow.Table.Columns.Contains("YWR") && pRow["YWR"] != DBNull.Value) { obj.YWR = Convert.ToString(pRow["YWR"]); }
						if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
						if (pRow.Table.Columns.Contains("QT") && pRow["QT"] != DBNull.Value) { obj.QT = Convert.ToString(pRow["QT"]); }
						if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
						if (pRow.Table.Columns.Contains("FZJC") && pRow["FZJC"] != DBNull.Value) { obj.FZJC = Convert.ToString(pRow["FZJC"]); }
						if (pRow.Table.Columns.Contains("FZDQ") && pRow["FZDQ"] != DBNull.Value) { obj.FZDQ = Convert.ToString(pRow["FZDQ"]); }
						if (pRow.Table.Columns.Contains("FZNF") && pRow["FZNF"] != DBNull.Value) { obj.FZNF = Convert.ToInt64(pRow["FZNF"]); }
						if (pRow.Table.Columns.Contains("FZBM") && pRow["FZBM"] != DBNull.Value) { obj.FZBM = Convert.ToString(pRow["FZBM"]); }
						if (pRow.Table.Columns.Contains("FZXH") && pRow["FZXH"] != DBNull.Value) { obj.FZXH = Convert.ToInt64(pRow["FZXH"]); }
						if (pRow.Table.Columns.Contains("FZGBH") && pRow["FZGBH"] != DBNull.Value) { obj.FZGBH = Convert.ToString(pRow["FZGBH"]); }
						if (pRow.Table.Columns.Contains("SZR") && pRow["SZR"] != DBNull.Value) { obj.SZR = Convert.ToString(pRow["SZR"]); }
						if (pRow.Table.Columns.Contains("SZSJ") && pRow["SZSJ"] != DBNull.Value) { obj.SZSJ = Convert.ToDateTime(pRow["SZSJ"]); }
						if (pRow.Table.Columns.Contains("SZRSGZH") && pRow["SZRSGZH"] != DBNull.Value) { obj.SZRSGZH = Convert.ToString(pRow["SZRSGZH"]); }
						if (pRow.Table.Columns.Contains("SZRBSM") && pRow["SZRBSM"] != DBNull.Value) { obj.SZRBSM = Convert.ToString(pRow["SZRBSM"]); }
						if (pRow.Table.Columns.Contains("SZRDNBH") && pRow["SZRDNBH"] != DBNull.Value) { obj.SZRDNBH = Convert.ToString(pRow["SZRDNBH"]); }
						if (pRow.Table.Columns.Contains("FZR") && pRow["FZR"] != DBNull.Value) { obj.FZR = Convert.ToString(pRow["FZR"]); }
						if (pRow.Table.Columns.Contains("FZSJ") && pRow["FZSJ"] != DBNull.Value) { obj.FZSJ = Convert.ToDateTime(pRow["FZSJ"]); }
						if (pRow.Table.Columns.Contains("FZRSGZH") && pRow["FZRSGZH"] != DBNull.Value) { obj.FZRSGZH = Convert.ToString(pRow["FZRSGZH"]); }
						if (pRow.Table.Columns.Contains("FZRBSM") && pRow["FZRBSM"] != DBNull.Value) { obj.FZRBSM = Convert.ToString(pRow["FZRBSM"]); }
						if (pRow.Table.Columns.Contains("LZR") && pRow["LZR"] != DBNull.Value) { obj.LZR = Convert.ToString(pRow["LZR"]); }
						if (pRow.Table.Columns.Contains("LZRZJZL") && pRow["LZRZJZL"] != DBNull.Value) { obj.LZRZJZL = Convert.ToString(pRow["LZRZJZL"]); }
						if (pRow.Table.Columns.Contains("LZRZJH") && pRow["LZRZJH"] != DBNull.Value) { obj.LZRZJH = Convert.ToString(pRow["LZRZJH"]); }
						if (pRow.Table.Columns.Contains("LZRDH") && pRow["LZRDH"] != DBNull.Value) { obj.LZRDH = Convert.ToString(pRow["LZRDH"]); }
						if (pRow.Table.Columns.Contains("LZRDZ") && pRow["LZRDZ"] != DBNull.Value) { obj.LZRDZ = Convert.ToString(pRow["LZRDZ"]); }
						if (pRow.Table.Columns.Contains("LZRYB") && pRow["LZRYB"] != DBNull.Value) { obj.LZRYB = Convert.ToString(pRow["LZRYB"]); }
						if (pRow.Table.Columns.Contains("LZSJ") && pRow["LZSJ"] != DBNull.Value) { obj.LZSJ = Convert.ToDateTime(pRow["LZSJ"]); }
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
						if (pRow.Table.Columns.Contains("FZJG") && pRow["FZJG"] != DBNull.Value) { obj.FZJG = Convert.ToString(pRow["FZJG"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("SBH") && pRow["SBH"] != DBNull.Value) { obj.SBH = Convert.ToString(pRow["SBH"]); }
					
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("JZMJ") && pRow["JZMJ"] != DBNull.Value) { obj.JZMJ = Convert.ToDouble(pRow["JZMJ"]); }
						if (pRow.Table.Columns.Contains("DYCS") && pRow["DYCS"] != DBNull.Value) { obj.DYCS = Convert.ToInt64(pRow["DYCS"]); }
						
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
