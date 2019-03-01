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

	public class Fld_QLR
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string QLRLB="QLRLB";
		public const string QLBM="QLBM";
		public const string QLBSM="QLBSM";
		public const string SXH="SXH";
		public const string QLRMC="QLRMC";
		public const string ZJZL="ZJZL";
		public const string ZJH="ZJH";
		public const string SSHY="SSHY";
		public const string XB="XB";
		public const string GDDH="GDDH";
		public const string YDDH="YDDH";
		public const string DZ="DZ";
		public const string YB="YB";
		public const string GZDW="GZDW";
		public const string DZYJ="DZYJ";
		public const string QLRLX="QLRLX";
		public const string QLMJ="QLMJ";
		public const string QLBL="QLBL";
		public const string GYFS="GYFS";
		public const string GYQK="GYQK";
		public const string QLRFRMC="QLRFRMC";
		public const string QLRFRDH="QLRFRDH";
		public const string QLRFRZJZL="QLRFRZJZL";
		public const string QLRFRZJH="QLRFRZJH";
		public const string QLRFRLXDZ="QLRFRLXDZ";
		public const string QLRDLRMC="QLRDLRMC";
		public const string QLRDLRDH="QLRDLRDH";
		public const string QLRDLRZJZL="QLRDLRZJZL";
		public const string QLRDLRZJH="QLRDLRZJH";
		public const string QLRDLJG="QLRDLJG";
		public const string QLRDLJGDM="QLRDLJGDM";
		public const string BZ="BZ";
		public const string QSZT="QSZT";
		public const string ZSBSM="ZSBSM";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string SQRBSM="SQRBSM";
		public const string QXDM="QXDM";
		public const string BZ_GYBW_NAME="BZ_GYBW_NAME";
		public const string BZ_FCZ_NM="BZ_FCZ_NM";
		public const string BZ_GY_TYPE="BZ_GY_TYPE";
		public const string BZ_SYQR_XZ="BZ_SYQR_XZ";
		public const string REV_="REV_";
		public const string BZ_GHKH="BZ_GHKH";
		public const string BZ_ADD1="BZ_ADD1";
		public const string BZ_ZDQLR_ID="BZ_ZDQLR_ID";
		public const string BZ_SQR_NM="BZ_SQR_NM";
		public const string BZ_GXSJ="BZ_GXSJ";
		public const string GXSJ="GXSJ";
		public const string BZ_DY_ID="BZ_DY_ID";
		public const string BZ_CF_ID="BZ_CF_ID";
		public const string QLLXMC="QLLXMC";
		public const string YXTGYFS="YXTGYFS";
		public const string YXTZJLX="YXTZJLX";
		public const string GJ="GJ";
		public const string BZ_RIGHT_ID="BZ_RIGHT_ID";
		public const string BZ_MOR_ID="BZ_MOR_ID";
		public const string BZ_SEI_ID="BZ_SEI_ID";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsQLR:IEntity
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
		private string m_QLRLB;
		private string m_QLBM;
		private long m_QLBSM;
		private long m_SXH;
		private string m_QLRMC;
		private string m_ZJZL;
		private string m_ZJH;
		private string m_SSHY;
		private string m_XB;
		private string m_GDDH;
		private string m_YDDH;
		private string m_DZ;
		private string m_YB;
		private string m_GZDW;
		private string m_DZYJ;
		private string m_QLRLX;
		private double m_QLMJ;
		private string m_QLBL;
		private string m_GYFS;
		private string m_GYQK;
		private string m_QLRFRMC;
		private string m_QLRFRDH;
		private string m_QLRFRZJZL;
		private string m_QLRFRZJH;
		private string m_QLRFRLXDZ;
		private string m_QLRDLRMC;
		private string m_QLRDLRDH;
		private string m_QLRDLRZJZL;
		private string m_QLRDLRZJH;
		private string m_QLRDLJG;
		private string m_QLRDLJGDM;
		private string m_BZ;
		private string m_QSZT;
		private long m_ZSBSM;
		private string m_YXTBM;
		private string m_YXTBSM;
		private long m_SQRBSM;
		private long m_QXDM;
		private long m_REV_;
		private DateTime m_GXSJ;
		private string m_GJ;
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
		public string QLRLB
		{
			get{ return m_QLRLB; }
			set{ m_QLRLB = value; }
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
		public long SXH
		{
			get{ return m_SXH; }
			set{ m_SXH = value; }
		}
		public string QLRMC
		{
			get{ return m_QLRMC; }
			set{ m_QLRMC = value; }
		}
		public string ZJZL
		{
			get{ return m_ZJZL; }
			set{ m_ZJZL = value; }
		}
		public string ZJH
		{
			get{ return m_ZJH; }
			set{ m_ZJH = value; }
		}
		public string SSHY
		{
			get{ return m_SSHY; }
			set{ m_SSHY = value; }
		}
		public string XB
		{
			get{ return m_XB; }
			set{ m_XB = value; }
		}
		public string GDDH
		{
			get{ return m_GDDH; }
			set{ m_GDDH = value; }
		}
		public string YDDH
		{
			get{ return m_YDDH; }
			set{ m_YDDH = value; }
		}
		public string DZ
		{
			get{ return m_DZ; }
			set{ m_DZ = value; }
		}
		public string YB
		{
			get{ return m_YB; }
			set{ m_YB = value; }
		}
		public string GZDW
		{
			get{ return m_GZDW; }
			set{ m_GZDW = value; }
		}
		public string DZYJ
		{
			get{ return m_DZYJ; }
			set{ m_DZYJ = value; }
		}
		public string QLRLX
		{
			get{ return m_QLRLX; }
			set{ m_QLRLX = value; }
		}
		public double QLMJ
		{
			get{ return m_QLMJ; }
			set{ m_QLMJ = value; }
		}
		public string QLBL
		{
			get{ return m_QLBL; }
			set{ m_QLBL = value; }
		}
		public string GYFS
		{
			get{ return m_GYFS; }
			set{ m_GYFS = value; }
		}
		public string GYQK
		{
			get{ return m_GYQK; }
			set{ m_GYQK = value; }
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
		public string QLRFRZJZL
		{
			get{ return m_QLRFRZJZL; }
			set{ m_QLRFRZJZL = value; }
		}
		public string QLRFRZJH
		{
			get{ return m_QLRFRZJH; }
			set{ m_QLRFRZJH = value; }
		}
		public string QLRFRLXDZ
		{
			get{ return m_QLRFRLXDZ; }
			set{ m_QLRFRLXDZ = value; }
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
		public string QLRDLRZJZL
		{
			get{ return m_QLRDLRZJZL; }
			set{ m_QLRDLRZJZL = value; }
		}
		public string QLRDLRZJH
		{
			get{ return m_QLRDLRZJH; }
			set{ m_QLRDLRZJH = value; }
		}
		public string QLRDLJG
		{
			get{ return m_QLRDLJG; }
			set{ m_QLRDLJG = value; }
		}
		public string QLRDLJGDM
		{
			get{ return m_QLRDLJGDM; }
			set{ m_QLRDLJGDM = value; }
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
		public long ZSBSM
		{
			get{ return m_ZSBSM; }
			set{ m_ZSBSM = value; }
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
		public long SQRBSM
		{
			get{ return m_SQRBSM; }
			set{ m_SQRBSM = value; }
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
		
		public string GJ
		{
			get{ return m_GJ; }
			set{ m_GJ = value; }
		}
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

		#endregion
		public bool IsEquals(clsQLR obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.QLRLB != obj.QLRLB) bolResult = false;
			if (this.QLBM != obj.QLBM) bolResult = false;
			if (this.QLBSM != obj.QLBSM) bolResult = false;
			if (this.SXH != obj.SXH) bolResult = false;
			if (this.QLRMC != obj.QLRMC) bolResult = false;
			if (this.ZJZL != obj.ZJZL) bolResult = false;
			if (this.ZJH != obj.ZJH) bolResult = false;
			if (this.SSHY != obj.SSHY) bolResult = false;
			if (this.XB != obj.XB) bolResult = false;
			if (this.GDDH != obj.GDDH) bolResult = false;
			if (this.YDDH != obj.YDDH) bolResult = false;
			if (this.DZ != obj.DZ) bolResult = false;
			if (this.YB != obj.YB) bolResult = false;
			if (this.GZDW != obj.GZDW) bolResult = false;
			if (this.DZYJ != obj.DZYJ) bolResult = false;
			if (this.QLRLX != obj.QLRLX) bolResult = false;
			if (this.QLMJ != obj.QLMJ) bolResult = false;
			if (this.QLBL != obj.QLBL) bolResult = false;
			if (this.GYFS != obj.GYFS) bolResult = false;
			if (this.GYQK != obj.GYQK) bolResult = false;
			if (this.QLRFRMC != obj.QLRFRMC) bolResult = false;
			if (this.QLRFRDH != obj.QLRFRDH) bolResult = false;
			if (this.QLRFRZJZL != obj.QLRFRZJZL) bolResult = false;
			if (this.QLRFRZJH != obj.QLRFRZJH) bolResult = false;
			if (this.QLRFRLXDZ != obj.QLRFRLXDZ) bolResult = false;
			if (this.QLRDLRMC != obj.QLRDLRMC) bolResult = false;
			if (this.QLRDLRDH != obj.QLRDLRDH) bolResult = false;
			if (this.QLRDLRZJZL != obj.QLRDLRZJZL) bolResult = false;
			if (this.QLRDLRZJH != obj.QLRDLRZJH) bolResult = false;
			if (this.QLRDLJG != obj.QLRDLJG) bolResult = false;
			if (this.QLRDLJGDM != obj.QLRDLJGDM) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.ZSBSM != obj.ZSBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.SQRBSM != obj.SQRBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.GJ != obj.GJ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsQLR obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.QLRLB=obj.QLRLB;
			this.QLBM=obj.QLBM;
			this.QLBSM=obj.QLBSM;
			this.SXH=obj.SXH;
			this.QLRMC=obj.QLRMC;
			this.ZJZL=obj.ZJZL;
			this.ZJH=obj.ZJH;
			this.SSHY=obj.SSHY;
			this.XB=obj.XB;
			this.GDDH=obj.GDDH;
			this.YDDH=obj.YDDH;
			this.DZ=obj.DZ;
			this.YB=obj.YB;
			this.GZDW=obj.GZDW;
			this.DZYJ=obj.DZYJ;
			this.QLRLX=obj.QLRLX;
			this.QLMJ=obj.QLMJ;
			this.QLBL=obj.QLBL;
			this.GYFS=obj.GYFS;
			this.GYQK=obj.GYQK;
			this.QLRFRMC=obj.QLRFRMC;
			this.QLRFRDH=obj.QLRFRDH;
			this.QLRFRZJZL=obj.QLRFRZJZL;
			this.QLRFRZJH=obj.QLRFRZJH;
			this.QLRFRLXDZ=obj.QLRFRLXDZ;
			this.QLRDLRMC=obj.QLRDLRMC;
			this.QLRDLRDH=obj.QLRDLRDH;
			this.QLRDLRZJZL=obj.QLRDLRZJZL;
			this.QLRDLRZJH=obj.QLRDLRZJH;
			this.QLRDLJG=obj.QLRDLJG;
			this.QLRDLJGDM=obj.QLRDLJGDM;
			this.BZ=obj.BZ;
			this.QSZT=obj.QSZT;
			this.ZSBSM=obj.ZSBSM;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.SQRBSM=obj.SQRBSM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.GXSJ=obj.GXSJ;
			this.GJ=obj.GJ;
		}

	}

	public class clsQLRSet:EntityBaseSet
	{
		public clsQLRSet()
		{
			m_TableName="BDCDJ.QLR";
			m_HisTableName="BDCDJ.QLR_LS";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsQLRSet";
		}
		public static clsQLRSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsQLRSet clsSet = new clsQLRSet(); //(clsQLRSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsQLRSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsQLR obj = (clsQLR)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("QLRLB")) datarow["QLRLB"] = obj.QLRLB;
				if(datarow.Table.Columns.Contains("QLBM")) datarow["QLBM"] = obj.QLBM;
				if(datarow.Table.Columns.Contains("QLBSM")) datarow["QLBSM"] = obj.QLBSM;
				if(datarow.Table.Columns.Contains("SXH")) datarow["SXH"] = obj.SXH;
				if(datarow.Table.Columns.Contains("QLRMC")) datarow["QLRMC"] = obj.QLRMC;
				if(datarow.Table.Columns.Contains("ZJZL")) datarow["ZJZL"] = obj.ZJZL;
				if(datarow.Table.Columns.Contains("ZJH")) datarow["ZJH"] = obj.ZJH;
				if(datarow.Table.Columns.Contains("SSHY")) datarow["SSHY"] = obj.SSHY;
				if(datarow.Table.Columns.Contains("XB")) datarow["XB"] = obj.XB;
				if(datarow.Table.Columns.Contains("GDDH")) datarow["GDDH"] = obj.GDDH;
				if(datarow.Table.Columns.Contains("YDDH")) datarow["YDDH"] = obj.YDDH;
				if(datarow.Table.Columns.Contains("DZ")) datarow["DZ"] = obj.DZ;
				if(datarow.Table.Columns.Contains("YB")) datarow["YB"] = obj.YB;
				if(datarow.Table.Columns.Contains("GZDW")) datarow["GZDW"] = obj.GZDW;
				if(datarow.Table.Columns.Contains("DZYJ")) datarow["DZYJ"] = obj.DZYJ;
				if(datarow.Table.Columns.Contains("QLRLX")) datarow["QLRLX"] = obj.QLRLX;
				if(datarow.Table.Columns.Contains("QLMJ")) datarow["QLMJ"] = obj.QLMJ;
				if(datarow.Table.Columns.Contains("QLBL")) datarow["QLBL"] = obj.QLBL;
				if(datarow.Table.Columns.Contains("GYFS")) datarow["GYFS"] = obj.GYFS;
				if(datarow.Table.Columns.Contains("GYQK")) datarow["GYQK"] = obj.GYQK;
				if(datarow.Table.Columns.Contains("QLRFRMC")) datarow["QLRFRMC"] = obj.QLRFRMC;
				if(datarow.Table.Columns.Contains("QLRFRDH")) datarow["QLRFRDH"] = obj.QLRFRDH;
				if(datarow.Table.Columns.Contains("QLRFRZJZL")) datarow["QLRFRZJZL"] = obj.QLRFRZJZL;
				if(datarow.Table.Columns.Contains("QLRFRZJH")) datarow["QLRFRZJH"] = obj.QLRFRZJH;
				if(datarow.Table.Columns.Contains("QLRFRLXDZ")) datarow["QLRFRLXDZ"] = obj.QLRFRLXDZ;
				if(datarow.Table.Columns.Contains("QLRDLRMC")) datarow["QLRDLRMC"] = obj.QLRDLRMC;
				if(datarow.Table.Columns.Contains("QLRDLRDH")) datarow["QLRDLRDH"] = obj.QLRDLRDH;
				if(datarow.Table.Columns.Contains("QLRDLRZJZL")) datarow["QLRDLRZJZL"] = obj.QLRDLRZJZL;
				if(datarow.Table.Columns.Contains("QLRDLRZJH")) datarow["QLRDLRZJH"] = obj.QLRDLRZJH;
				if(datarow.Table.Columns.Contains("QLRDLJG")) datarow["QLRDLJG"] = obj.QLRDLJG;
				if(datarow.Table.Columns.Contains("QLRDLJGDM")) datarow["QLRDLJGDM"] = obj.QLRDLJGDM;
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
				if(datarow.Table.Columns.Contains("ZSBSM")) datarow["ZSBSM"] = obj.ZSBSM;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("SQRBSM")) datarow["SQRBSM"] = obj.SQRBSM;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}

				if(datarow.Table.Columns.Contains("GJ")) datarow["GJ"] = obj.GJ;
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
			clsQLR obj = null;
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
					obj = new clsQLR();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="QLRLB")
								if (pRow.Table.Columns.Contains("QLRLB") && pRow["QLRLB"] != DBNull.Value) { obj.QLRLB = Convert.ToString(pRow["QLRLB"]); }
							if(strFldName.ToUpper()=="QLBM")
								if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
							if(strFldName.ToUpper()=="QLBSM")
								if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
							if(strFldName.ToUpper()=="SXH")
								if (pRow.Table.Columns.Contains("SXH") && pRow["SXH"] != DBNull.Value) { obj.SXH = Convert.ToInt64(pRow["SXH"]); }
							if(strFldName.ToUpper()=="QLRMC")
								if (pRow.Table.Columns.Contains("QLRMC") && pRow["QLRMC"] != DBNull.Value) { obj.QLRMC = Convert.ToString(pRow["QLRMC"]); }
							if(strFldName.ToUpper()=="ZJZL")
								if (pRow.Table.Columns.Contains("ZJZL") && pRow["ZJZL"] != DBNull.Value) { obj.ZJZL = Convert.ToString(pRow["ZJZL"]); }
							if(strFldName.ToUpper()=="ZJH")
								if (pRow.Table.Columns.Contains("ZJH") && pRow["ZJH"] != DBNull.Value) { obj.ZJH = Convert.ToString(pRow["ZJH"]); }
							if(strFldName.ToUpper()=="SSHY")
								if (pRow.Table.Columns.Contains("SSHY") && pRow["SSHY"] != DBNull.Value) { obj.SSHY = Convert.ToString(pRow["SSHY"]); }
							if(strFldName.ToUpper()=="XB")
								if (pRow.Table.Columns.Contains("XB") && pRow["XB"] != DBNull.Value) { obj.XB = Convert.ToString(pRow["XB"]); }
							if(strFldName.ToUpper()=="GDDH")
								if (pRow.Table.Columns.Contains("GDDH") && pRow["GDDH"] != DBNull.Value) { obj.GDDH = Convert.ToString(pRow["GDDH"]); }
							if(strFldName.ToUpper()=="YDDH")
								if (pRow.Table.Columns.Contains("YDDH") && pRow["YDDH"] != DBNull.Value) { obj.YDDH = Convert.ToString(pRow["YDDH"]); }
							if(strFldName.ToUpper()=="DZ")
								if (pRow.Table.Columns.Contains("DZ") && pRow["DZ"] != DBNull.Value) { obj.DZ = Convert.ToString(pRow["DZ"]); }
							if(strFldName.ToUpper()=="YB")
								if (pRow.Table.Columns.Contains("YB") && pRow["YB"] != DBNull.Value) { obj.YB = Convert.ToString(pRow["YB"]); }
							if(strFldName.ToUpper()=="GZDW")
								if (pRow.Table.Columns.Contains("GZDW") && pRow["GZDW"] != DBNull.Value) { obj.GZDW = Convert.ToString(pRow["GZDW"]); }
							if(strFldName.ToUpper()=="DZYJ")
								if (pRow.Table.Columns.Contains("DZYJ") && pRow["DZYJ"] != DBNull.Value) { obj.DZYJ = Convert.ToString(pRow["DZYJ"]); }
							if(strFldName.ToUpper()=="QLRLX")
								if (pRow.Table.Columns.Contains("QLRLX") && pRow["QLRLX"] != DBNull.Value) { obj.QLRLX = Convert.ToString(pRow["QLRLX"]); }
							if(strFldName.ToUpper()=="QLMJ")
								if (pRow.Table.Columns.Contains("QLMJ") && pRow["QLMJ"] != DBNull.Value) { obj.QLMJ = Convert.ToDouble(pRow["QLMJ"]); }
							if(strFldName.ToUpper()=="QLBL")
								if (pRow.Table.Columns.Contains("QLBL") && pRow["QLBL"] != DBNull.Value) { obj.QLBL = Convert.ToString(pRow["QLBL"]); }
							if(strFldName.ToUpper()=="GYFS")
								if (pRow.Table.Columns.Contains("GYFS") && pRow["GYFS"] != DBNull.Value) { obj.GYFS = Convert.ToString(pRow["GYFS"]); }
							if(strFldName.ToUpper()=="GYQK")
								if (pRow.Table.Columns.Contains("GYQK") && pRow["GYQK"] != DBNull.Value) { obj.GYQK = Convert.ToString(pRow["GYQK"]); }
							if(strFldName.ToUpper()=="QLRFRMC")
								if (pRow.Table.Columns.Contains("QLRFRMC") && pRow["QLRFRMC"] != DBNull.Value) { obj.QLRFRMC = Convert.ToString(pRow["QLRFRMC"]); }
							if(strFldName.ToUpper()=="QLRFRDH")
								if (pRow.Table.Columns.Contains("QLRFRDH") && pRow["QLRFRDH"] != DBNull.Value) { obj.QLRFRDH = Convert.ToString(pRow["QLRFRDH"]); }
							if(strFldName.ToUpper()=="QLRFRZJZL")
								if (pRow.Table.Columns.Contains("QLRFRZJZL") && pRow["QLRFRZJZL"] != DBNull.Value) { obj.QLRFRZJZL = Convert.ToString(pRow["QLRFRZJZL"]); }
							if(strFldName.ToUpper()=="QLRFRZJH")
								if (pRow.Table.Columns.Contains("QLRFRZJH") && pRow["QLRFRZJH"] != DBNull.Value) { obj.QLRFRZJH = Convert.ToString(pRow["QLRFRZJH"]); }
							if(strFldName.ToUpper()=="QLRFRLXDZ")
								if (pRow.Table.Columns.Contains("QLRFRLXDZ") && pRow["QLRFRLXDZ"] != DBNull.Value) { obj.QLRFRLXDZ = Convert.ToString(pRow["QLRFRLXDZ"]); }
							if(strFldName.ToUpper()=="QLRDLRMC")
								if (pRow.Table.Columns.Contains("QLRDLRMC") && pRow["QLRDLRMC"] != DBNull.Value) { obj.QLRDLRMC = Convert.ToString(pRow["QLRDLRMC"]); }
							if(strFldName.ToUpper()=="QLRDLRDH")
								if (pRow.Table.Columns.Contains("QLRDLRDH") && pRow["QLRDLRDH"] != DBNull.Value) { obj.QLRDLRDH = Convert.ToString(pRow["QLRDLRDH"]); }
							if(strFldName.ToUpper()=="QLRDLRZJZL")
								if (pRow.Table.Columns.Contains("QLRDLRZJZL") && pRow["QLRDLRZJZL"] != DBNull.Value) { obj.QLRDLRZJZL = Convert.ToString(pRow["QLRDLRZJZL"]); }
							if(strFldName.ToUpper()=="QLRDLRZJH")
								if (pRow.Table.Columns.Contains("QLRDLRZJH") && pRow["QLRDLRZJH"] != DBNull.Value) { obj.QLRDLRZJH = Convert.ToString(pRow["QLRDLRZJH"]); }
							if(strFldName.ToUpper()=="QLRDLJG")
								if (pRow.Table.Columns.Contains("QLRDLJG") && pRow["QLRDLJG"] != DBNull.Value) { obj.QLRDLJG = Convert.ToString(pRow["QLRDLJG"]); }
							if(strFldName.ToUpper()=="QLRDLJGDM")
								if (pRow.Table.Columns.Contains("QLRDLJGDM") && pRow["QLRDLJGDM"] != DBNull.Value) { obj.QLRDLJGDM = Convert.ToString(pRow["QLRDLJGDM"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="QSZT")
								if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
							if(strFldName.ToUpper()=="ZSBSM")
								if (pRow.Table.Columns.Contains("ZSBSM") && pRow["ZSBSM"] != DBNull.Value) { obj.ZSBSM = Convert.ToInt64(pRow["ZSBSM"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
							if(strFldName.ToUpper()=="SQRBSM")
								if (pRow.Table.Columns.Contains("SQRBSM") && pRow["SQRBSM"] != DBNull.Value) { obj.SQRBSM = Convert.ToInt64(pRow["SQRBSM"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						
							if(strFldName.ToUpper()=="GJ")
								if (pRow.Table.Columns.Contains("GJ") && pRow["GJ"] != DBNull.Value) { obj.GJ = Convert.ToString(pRow["GJ"]); }
						
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("QLRLB") && pRow["QLRLB"] != DBNull.Value) { obj.QLRLB = Convert.ToString(pRow["QLRLB"]); }
						if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
						if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
						if (pRow.Table.Columns.Contains("SXH") && pRow["SXH"] != DBNull.Value) { obj.SXH = Convert.ToInt64(pRow["SXH"]); }
						if (pRow.Table.Columns.Contains("QLRMC") && pRow["QLRMC"] != DBNull.Value) { obj.QLRMC = Convert.ToString(pRow["QLRMC"]); }
						if (pRow.Table.Columns.Contains("ZJZL") && pRow["ZJZL"] != DBNull.Value) { obj.ZJZL = Convert.ToString(pRow["ZJZL"]); }
						if (pRow.Table.Columns.Contains("ZJH") && pRow["ZJH"] != DBNull.Value) { obj.ZJH = Convert.ToString(pRow["ZJH"]); }
						if (pRow.Table.Columns.Contains("SSHY") && pRow["SSHY"] != DBNull.Value) { obj.SSHY = Convert.ToString(pRow["SSHY"]); }
						if (pRow.Table.Columns.Contains("XB") && pRow["XB"] != DBNull.Value) { obj.XB = Convert.ToString(pRow["XB"]); }
						if (pRow.Table.Columns.Contains("GDDH") && pRow["GDDH"] != DBNull.Value) { obj.GDDH = Convert.ToString(pRow["GDDH"]); }
						if (pRow.Table.Columns.Contains("YDDH") && pRow["YDDH"] != DBNull.Value) { obj.YDDH = Convert.ToString(pRow["YDDH"]); }
						if (pRow.Table.Columns.Contains("DZ") && pRow["DZ"] != DBNull.Value) { obj.DZ = Convert.ToString(pRow["DZ"]); }
						if (pRow.Table.Columns.Contains("YB") && pRow["YB"] != DBNull.Value) { obj.YB = Convert.ToString(pRow["YB"]); }
						if (pRow.Table.Columns.Contains("GZDW") && pRow["GZDW"] != DBNull.Value) { obj.GZDW = Convert.ToString(pRow["GZDW"]); }
						if (pRow.Table.Columns.Contains("DZYJ") && pRow["DZYJ"] != DBNull.Value) { obj.DZYJ = Convert.ToString(pRow["DZYJ"]); }
						if (pRow.Table.Columns.Contains("QLRLX") && pRow["QLRLX"] != DBNull.Value) { obj.QLRLX = Convert.ToString(pRow["QLRLX"]); }
						if (pRow.Table.Columns.Contains("QLMJ") && pRow["QLMJ"] != DBNull.Value) { obj.QLMJ = Convert.ToDouble(pRow["QLMJ"]); }
						if (pRow.Table.Columns.Contains("QLBL") && pRow["QLBL"] != DBNull.Value) { obj.QLBL = Convert.ToString(pRow["QLBL"]); }
						if (pRow.Table.Columns.Contains("GYFS") && pRow["GYFS"] != DBNull.Value) { obj.GYFS = Convert.ToString(pRow["GYFS"]); }
						if (pRow.Table.Columns.Contains("GYQK") && pRow["GYQK"] != DBNull.Value) { obj.GYQK = Convert.ToString(pRow["GYQK"]); }
						if (pRow.Table.Columns.Contains("QLRFRMC") && pRow["QLRFRMC"] != DBNull.Value) { obj.QLRFRMC = Convert.ToString(pRow["QLRFRMC"]); }
						if (pRow.Table.Columns.Contains("QLRFRDH") && pRow["QLRFRDH"] != DBNull.Value) { obj.QLRFRDH = Convert.ToString(pRow["QLRFRDH"]); }
						if (pRow.Table.Columns.Contains("QLRFRZJZL") && pRow["QLRFRZJZL"] != DBNull.Value) { obj.QLRFRZJZL = Convert.ToString(pRow["QLRFRZJZL"]); }
						if (pRow.Table.Columns.Contains("QLRFRZJH") && pRow["QLRFRZJH"] != DBNull.Value) { obj.QLRFRZJH = Convert.ToString(pRow["QLRFRZJH"]); }
						if (pRow.Table.Columns.Contains("QLRFRLXDZ") && pRow["QLRFRLXDZ"] != DBNull.Value) { obj.QLRFRLXDZ = Convert.ToString(pRow["QLRFRLXDZ"]); }
						if (pRow.Table.Columns.Contains("QLRDLRMC") && pRow["QLRDLRMC"] != DBNull.Value) { obj.QLRDLRMC = Convert.ToString(pRow["QLRDLRMC"]); }
						if (pRow.Table.Columns.Contains("QLRDLRDH") && pRow["QLRDLRDH"] != DBNull.Value) { obj.QLRDLRDH = Convert.ToString(pRow["QLRDLRDH"]); }
						if (pRow.Table.Columns.Contains("QLRDLRZJZL") && pRow["QLRDLRZJZL"] != DBNull.Value) { obj.QLRDLRZJZL = Convert.ToString(pRow["QLRDLRZJZL"]); }
						if (pRow.Table.Columns.Contains("QLRDLRZJH") && pRow["QLRDLRZJH"] != DBNull.Value) { obj.QLRDLRZJH = Convert.ToString(pRow["QLRDLRZJH"]); }
						if (pRow.Table.Columns.Contains("QLRDLJG") && pRow["QLRDLJG"] != DBNull.Value) { obj.QLRDLJG = Convert.ToString(pRow["QLRDLJG"]); }
						if (pRow.Table.Columns.Contains("QLRDLJGDM") && pRow["QLRDLJGDM"] != DBNull.Value) { obj.QLRDLJGDM = Convert.ToString(pRow["QLRDLJGDM"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
						if (pRow.Table.Columns.Contains("ZSBSM") && pRow["ZSBSM"] != DBNull.Value) { obj.ZSBSM = Convert.ToInt64(pRow["ZSBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("SQRBSM") && pRow["SQRBSM"] != DBNull.Value) { obj.SQRBSM = Convert.ToInt64(pRow["SQRBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
					
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
					
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						
						if (pRow.Table.Columns.Contains("GJ") && pRow["GJ"] != DBNull.Value) { obj.GJ = Convert.ToString(pRow["GJ"]); }
					
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
