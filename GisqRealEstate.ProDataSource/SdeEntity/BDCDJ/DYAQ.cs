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

	public class Fld_DYAQ
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string DYBDCLX="DYBDCLX";
		public const string DYFS="DYFS";
		public const string ZJJZWZL="ZJJZWZL";
		public const string ZJJZWDYFW="ZJJZWDYFW";
		public const string BDBZQSE="BDBZQSE";
		public const string ZGZQSE="ZGZQSE";
		public const string QLQSSJ="QLQSSJ";
		public const string QLJSSJ="QLJSSJ";
		public const string QLQX="QLQX";
		public const string ZGZQQDSSHSE="ZGZQQDSSHSE";
		public const string DJYY="DJYY";
		public const string DBR="DBR";
		public const string DJSJ="DJSJ";
		public const string DJZMH="DJZMH";
		public const string DJZMBSM="DJZMBSM";
		public const string FJ="FJ";
		public const string DYSXH="DYSXH";
		public const string QSZT="QSZT";
		public const string SHBSM="SHBSM";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string QXDM="QXDM";
		public const string BZ_JS_MARK="BZ_JS_MARK";
		public const string BZ_SIGN_DATE="BZ_SIGN_DATE";
		public const string BZ_CSF="BZ_CSF";
		public const string BZ_DKAGG_ID="BZ_DKAGG_ID";
		public const string BZ_TDESC="BZ_TDESC";
		public const string BZ_DY_AREA="BZ_DY_AREA";
		public const string BZ_DYTD_AREA="BZ_DYTD_AREA";
		public const string BZ_EST_PRICE="BZ_EST_PRICE";
		public const string BZ_EST_DEPT="BZ_EST_DEPT";
		public const string BZ_FZ_MARK="BZ_FZ_MARK";
		public const string BZ_DY_YJ="BZ_DY_YJ";
		public const string BZ_QL_VALUE="BZ_QL_VALUE";
		public const string REV_="REV_";
		public const string DJJG="DJJG";
		public const string BZ_DY_QLSX="BZ_DY_QLSX";
		public const string BZ_DY_CXQX="BZ_DY_CXQX";
		public const string BZ_DYZDBH="BZ_DYZDBH";
		public const string BZ_ZX_XH="BZ_ZX_XH";
		public const string BZ_ZX_BM="BZ_ZX_BM";
		public const string BZ_ZX_NF="BZ_ZX_NF";
		public const string BZ_TS_BM="BZ_TS_BM";
		public const string BZ_DY_MJ="BZ_DY_MJ";
		public const string BZ_DY_ZCZE="BZ_DY_ZCZE";
		public const string HTBH="HTBH";
		public const string BZ="BZ";
		public const string BZ_DY_ID="BZ_DY_ID";
		public const string DYSX="DYSX";
		public const string BZ_GXSJ="BZ_GXSJ";
		public const string GXSJ="GXSJ";
		public const string BZ_QLR_ID="BZ_QLR_ID";
		public const string BZ_DYR_ID="BZ_DYR_ID";
		public const string OINSID="OINSID";
		public const string BZ_QLID="BZ_QLID";
		public const string BZ_QZID="BZ_QZID";
		public const string BZ_YWSLID="BZ_YWSLID";
		public const string BZ_MJ="BZ_MJ";
		public const string BZ_YT="BZ_YT";
		public const string BZ_ZDDM="BZ_ZDDM";
		public const string DBFW="DBFW";
		public const string BZ_MOR_TYPE_SCOPE="BZ_MOR_TYPE_SCOPE";
		public const string BZ_BLDW="BZ_BLDW";
		public const string BZ_LAND_PRICE="BZ_LAND_PRICE";
		public const string BZ_MOR_CANCEL_DATE="BZ_MOR_CANCEL_DATE";
		public const string BZ_REG_TYPE="BZ_REG_TYPE";
		public const string BZ_MAP_ID="BZ_MAP_ID";
		public const string BZ_LAND_RIGHT_SOURCE="BZ_LAND_RIGHT_SOURCE";
		public const string BZ_编号="BZ_编号";
		public const string BZ_ID="BZ_ID";
		public const string HBLX="HBLX";
		#endregion
	}

	public class clsDYAQ:IEntity
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
		private string m_DYBDCLX;
		private string m_DYFS;
		private string m_ZJJZWZL;
		private string m_ZJJZWDYFW;
		private double m_BDBZQSE;
		private double m_ZGZQSE;
		private DateTime m_QLQSSJ;
		private DateTime m_QLJSSJ;
		private string m_QLQX;
		private string m_ZGZQQDSSHSE;
		private string m_DJYY;
		private string m_DBR;
		private DateTime m_DJSJ;
		private string m_DJZMH;
		private long m_DJZMBSM;
		private string m_FJ;
		private int m_DYSXH;
		private string m_QSZT;
		private long m_SHBSM;
		private string m_YXTBM;
		private string m_YXTBSM;
		private long m_QXDM;
		private long m_REV_;
		private string m_DJJG;
		private string m_HTBH;
		private string m_BZ;
		private string m_DYSX;
		private DateTime m_GXSJ;
		private string m_DBFW;

		private string m_HBLX;

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
		public string DYBDCLX
		{
			get{ return m_DYBDCLX; }
			set{ m_DYBDCLX = value; }
		}
		public string DYFS
		{
			get{ return m_DYFS; }
			set{ m_DYFS = value; }
		}
		public string ZJJZWZL
		{
			get{ return m_ZJJZWZL; }
			set{ m_ZJJZWZL = value; }
		}
		public string ZJJZWDYFW
		{
			get{ return m_ZJJZWDYFW; }
			set{ m_ZJJZWDYFW = value; }
		}
		public double BDBZQSE
		{
			get{ return m_BDBZQSE; }
			set{ m_BDBZQSE = value; }
		}
		public double ZGZQSE
		{
			get{ return m_ZGZQSE; }
			set{ m_ZGZQSE = value; }
		}
		public DateTime QLQSSJ
		{
			get{ return m_QLQSSJ; }
			set{ m_QLQSSJ = value; }
		}
		public DateTime QLJSSJ
		{
			get{ return m_QLJSSJ; }
			set{ m_QLJSSJ = value; }
		}
		public string QLQX
		{
			get{ return m_QLQX; }
			set{ m_QLQX = value; }
		}
		public string ZGZQQDSSHSE
		{
			get{ return m_ZGZQQDSSHSE; }
			set{ m_ZGZQQDSSHSE = value; }
		}
		public string DJYY
		{
			get{ return m_DJYY; }
			set{ m_DJYY = value; }
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
		public string DJZMH
		{
			get{ return m_DJZMH; }
			set{ m_DJZMH = value; }
		}
		public long DJZMBSM
		{
			get{ return m_DJZMBSM; }
			set{ m_DJZMBSM = value; }
		}
		public string FJ
		{
			get{ return m_FJ; }
			set{ m_FJ = value; }
		}
		public int DYSXH
		{
			get{ return m_DYSXH; }
			set{ m_DYSXH = value; }
		}
		public string QSZT
		{
			get{ return m_QSZT; }
			set{ m_QSZT = value; }
		}
		public long SHBSM
		{
			get{ return m_SHBSM; }
			set{ m_SHBSM = value; }
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
		public string DJJG
		{
			get{ return m_DJJG; }
			set{ m_DJJG = value; }
		}
		public string HTBH
		{
			get{ return m_HTBH; }
			set{ m_HTBH = value; }
		}
		public string BZ
		{
			get{ return m_BZ; }
			set{ m_BZ = value; }
		}
		public string DYSX
		{
			get{ return m_DYSX; }
			set{ m_DYSX = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		public string DBFW
		{
			get{ return m_DBFW; }
			set{ m_DBFW = value; }
		}
	
		public string HBLX
		{
			get{ return m_HBLX; }
			set{ m_HBLX = value; }
		}

		#endregion
		public bool IsEquals(clsDYAQ obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.DYBDCLX != obj.DYBDCLX) bolResult = false;
			if (this.DYFS != obj.DYFS) bolResult = false;
			if (this.ZJJZWZL != obj.ZJJZWZL) bolResult = false;
			if (this.ZJJZWDYFW != obj.ZJJZWDYFW) bolResult = false;
			if (this.BDBZQSE != obj.BDBZQSE) bolResult = false;
			if (this.ZGZQSE != obj.ZGZQSE) bolResult = false;
			if (this.QLQSSJ != obj.QLQSSJ) bolResult = false;
			if (this.QLJSSJ != obj.QLJSSJ) bolResult = false;
			if (this.QLQX != obj.QLQX) bolResult = false;
			if (this.ZGZQQDSSHSE != obj.ZGZQQDSSHSE) bolResult = false;
			if (this.DJYY != obj.DJYY) bolResult = false;
			if (this.DBR != obj.DBR) bolResult = false;
			if (this.DJSJ != obj.DJSJ) bolResult = false;
			if (this.DJZMH != obj.DJZMH) bolResult = false;
			if (this.DJZMBSM != obj.DJZMBSM) bolResult = false;
			if (this.FJ != obj.FJ) bolResult = false;
			if (this.DYSXH != obj.DYSXH) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.SHBSM != obj.SHBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.DJJG != obj.DJJG) bolResult = false;
			if (this.HTBH != obj.HTBH) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
		
			if (this.DYSX != obj.DYSX) bolResult = false;
		
			if (this.GXSJ != obj.GXSJ) bolResult = false;
		
			if (this.DBFW != obj.DBFW) bolResult = false;
		
			if (this.HBLX != obj.HBLX) bolResult = false;
			return bolResult;
		}

		public void Colne(clsDYAQ obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.DYBDCLX=obj.DYBDCLX;
			this.DYFS=obj.DYFS;
			this.ZJJZWZL=obj.ZJJZWZL;
			this.ZJJZWDYFW=obj.ZJJZWDYFW;
			this.BDBZQSE=obj.BDBZQSE;
			this.ZGZQSE=obj.ZGZQSE;
			this.QLQSSJ=obj.QLQSSJ;
			this.QLJSSJ=obj.QLJSSJ;
			this.QLQX=obj.QLQX;
			this.ZGZQQDSSHSE=obj.ZGZQQDSSHSE;
			this.DJYY=obj.DJYY;
			this.DBR=obj.DBR;
			this.DJSJ=obj.DJSJ;
			this.DJZMH=obj.DJZMH;
			this.DJZMBSM=obj.DJZMBSM;
			this.FJ=obj.FJ;
			this.DYSXH=obj.DYSXH;
			this.QSZT=obj.QSZT;
			this.SHBSM=obj.SHBSM;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.QXDM=obj.QXDM;
		
			this.REV_=obj.REV_;
			this.DJJG=obj.DJJG;
	
			this.HTBH=obj.HTBH;
			this.BZ=obj.BZ;
			this.DYSX=obj.DYSX;
			
			this.GXSJ=obj.GXSJ;
		
			this.DBFW=obj.DBFW;
	
			this.HBLX=obj.HBLX;
		}

	}

	public class clsDYAQSet:EntityBaseSet
	{
		public clsDYAQSet()
		{
			m_TableName="BDCDJ.DYAQ";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsDYAQSet";
		}
		public static clsDYAQSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsDYAQSet clsSet = new clsDYAQSet(); //(clsDYAQSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsDYAQSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsDYAQ obj = (clsDYAQ)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("DYBDCLX")) datarow["DYBDCLX"] = obj.DYBDCLX;
				if(datarow.Table.Columns.Contains("DYFS")) datarow["DYFS"] = obj.DYFS;
				if(datarow.Table.Columns.Contains("ZJJZWZL")) datarow["ZJJZWZL"] = obj.ZJJZWZL;
				if(datarow.Table.Columns.Contains("ZJJZWDYFW")) datarow["ZJJZWDYFW"] = obj.ZJJZWDYFW;
				if(datarow.Table.Columns.Contains("BDBZQSE")) datarow["BDBZQSE"] = obj.BDBZQSE;
				if(datarow.Table.Columns.Contains("ZGZQSE")) datarow["ZGZQSE"] = obj.ZGZQSE;
				if (obj.QLQSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("QLQSSJ")) datarow["QLQSSJ"] = obj.QLQSSJ;
				}
				if (obj.QLJSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("QLJSSJ")) datarow["QLJSSJ"] = obj.QLJSSJ;
				}
				if(datarow.Table.Columns.Contains("QLQX")) datarow["QLQX"] = obj.QLQX;
				if(datarow.Table.Columns.Contains("ZGZQQDSSHSE")) datarow["ZGZQQDSSHSE"] = obj.ZGZQQDSSHSE;
				if(datarow.Table.Columns.Contains("DJYY")) datarow["DJYY"] = obj.DJYY;
				if(datarow.Table.Columns.Contains("DBR")) datarow["DBR"] = obj.DBR;
				if (obj.DJSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("DJSJ")) datarow["DJSJ"] = obj.DJSJ;
				}
				if(datarow.Table.Columns.Contains("DJZMH")) datarow["DJZMH"] = obj.DJZMH;
				if(datarow.Table.Columns.Contains("DJZMBSM")) datarow["DJZMBSM"] = obj.DJZMBSM;
				if(datarow.Table.Columns.Contains("FJ")) datarow["FJ"] = obj.FJ;
				if(datarow.Table.Columns.Contains("DYSXH")) datarow["DYSXH"] = obj.DYSXH;
				if(datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
				if(datarow.Table.Columns.Contains("SHBSM")) datarow["SHBSM"] = obj.SHBSM;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
			
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("DJJG")) datarow["DJJG"] = obj.DJJG;
				
				if(datarow.Table.Columns.Contains("HTBH")) datarow["HTBH"] = obj.HTBH;
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				
				if(datarow.Table.Columns.Contains("DYSX")) datarow["DYSX"] = obj.DYSX;
			
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				
				if(datarow.Table.Columns.Contains("DBFW")) datarow["DBFW"] = obj.DBFW;
				if(datarow.Table.Columns.Contains("HBLX")) datarow["HBLX"] = obj.HBLX;
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
			clsDYAQ obj = null;
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
					obj = new clsDYAQ();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="DYBDCLX")
								if (pRow.Table.Columns.Contains("DYBDCLX") && pRow["DYBDCLX"] != DBNull.Value) { obj.DYBDCLX = Convert.ToString(pRow["DYBDCLX"]); }
							if(strFldName.ToUpper()=="DYFS")
								if (pRow.Table.Columns.Contains("DYFS") && pRow["DYFS"] != DBNull.Value) { obj.DYFS = Convert.ToString(pRow["DYFS"]); }
							if(strFldName.ToUpper()=="ZJJZWZL")
								if (pRow.Table.Columns.Contains("ZJJZWZL") && pRow["ZJJZWZL"] != DBNull.Value) { obj.ZJJZWZL = Convert.ToString(pRow["ZJJZWZL"]); }
							if(strFldName.ToUpper()=="ZJJZWDYFW")
								if (pRow.Table.Columns.Contains("ZJJZWDYFW") && pRow["ZJJZWDYFW"] != DBNull.Value) { obj.ZJJZWDYFW = Convert.ToString(pRow["ZJJZWDYFW"]); }
							if(strFldName.ToUpper()=="BDBZQSE")
								if (pRow.Table.Columns.Contains("BDBZQSE") && pRow["BDBZQSE"] != DBNull.Value) { obj.BDBZQSE = Convert.ToDouble(pRow["BDBZQSE"]); }
							if(strFldName.ToUpper()=="ZGZQSE")
								if (pRow.Table.Columns.Contains("ZGZQSE") && pRow["ZGZQSE"] != DBNull.Value) { obj.ZGZQSE = Convert.ToDouble(pRow["ZGZQSE"]); }
							if(strFldName.ToUpper()=="QLQSSJ")
								if (pRow.Table.Columns.Contains("QLQSSJ") && pRow["QLQSSJ"] != DBNull.Value) { obj.QLQSSJ = Convert.ToDateTime(pRow["QLQSSJ"]); }
							if(strFldName.ToUpper()=="QLJSSJ")
								if (pRow.Table.Columns.Contains("QLJSSJ") && pRow["QLJSSJ"] != DBNull.Value) { obj.QLJSSJ = Convert.ToDateTime(pRow["QLJSSJ"]); }
							if(strFldName.ToUpper()=="QLQX")
								if (pRow.Table.Columns.Contains("QLQX") && pRow["QLQX"] != DBNull.Value) { obj.QLQX = Convert.ToString(pRow["QLQX"]); }
							if(strFldName.ToUpper()=="ZGZQQDSSHSE")
								if (pRow.Table.Columns.Contains("ZGZQQDSSHSE") && pRow["ZGZQQDSSHSE"] != DBNull.Value) { obj.ZGZQQDSSHSE = Convert.ToString(pRow["ZGZQQDSSHSE"]); }
							if(strFldName.ToUpper()=="DJYY")
								if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
							if(strFldName.ToUpper()=="DBR")
								if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
							if(strFldName.ToUpper()=="DJSJ")
								if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
							if(strFldName.ToUpper()=="DJZMH")
								if (pRow.Table.Columns.Contains("DJZMH") && pRow["DJZMH"] != DBNull.Value) { obj.DJZMH = Convert.ToString(pRow["DJZMH"]); }
							if(strFldName.ToUpper()=="DJZMBSM")
								if (pRow.Table.Columns.Contains("DJZMBSM") && pRow["DJZMBSM"] != DBNull.Value) { obj.DJZMBSM = Convert.ToInt64(pRow["DJZMBSM"]); }
							if(strFldName.ToUpper()=="FJ")
								if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
							if(strFldName.ToUpper()=="DYSXH")
								if (pRow.Table.Columns.Contains("DYSXH") && pRow["DYSXH"] != DBNull.Value) { obj.DYSXH = Convert.ToInt16(pRow["DYSXH"]); }
							if(strFldName.ToUpper()=="QSZT")
								if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
							if(strFldName.ToUpper()=="SHBSM")
								if (pRow.Table.Columns.Contains("SHBSM") && pRow["SHBSM"] != DBNull.Value) { obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="DJJG")
								if (pRow.Table.Columns.Contains("DJJG") && pRow["DJJG"] != DBNull.Value) { obj.DJJG = Convert.ToString(pRow["DJJG"]); }
							
							if(strFldName.ToUpper()=="HTBH")
								if (pRow.Table.Columns.Contains("HTBH") && pRow["HTBH"] != DBNull.Value) { obj.HTBH = Convert.ToString(pRow["HTBH"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							
							if(strFldName.ToUpper()=="DYSX")
								if (pRow.Table.Columns.Contains("DYSX") && pRow["DYSX"] != DBNull.Value) { obj.DYSX = Convert.ToString(pRow["DYSX"]); }
							
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							
							if(strFldName.ToUpper()=="DBFW")
								if (pRow.Table.Columns.Contains("DBFW") && pRow["DBFW"] != DBNull.Value) { obj.DBFW = Convert.ToString(pRow["DBFW"]); }
							
							if(strFldName.ToUpper()=="HBLX")
								if (pRow.Table.Columns.Contains("HBLX") && pRow["HBLX"] != DBNull.Value) { obj.HBLX = Convert.ToString(pRow["HBLX"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("DYBDCLX") && pRow["DYBDCLX"] != DBNull.Value) { obj.DYBDCLX = Convert.ToString(pRow["DYBDCLX"]); }
						if (pRow.Table.Columns.Contains("DYFS") && pRow["DYFS"] != DBNull.Value) { obj.DYFS = Convert.ToString(pRow["DYFS"]); }
						if (pRow.Table.Columns.Contains("ZJJZWZL") && pRow["ZJJZWZL"] != DBNull.Value) { obj.ZJJZWZL = Convert.ToString(pRow["ZJJZWZL"]); }
						if (pRow.Table.Columns.Contains("ZJJZWDYFW") && pRow["ZJJZWDYFW"] != DBNull.Value) { obj.ZJJZWDYFW = Convert.ToString(pRow["ZJJZWDYFW"]); }
						if (pRow.Table.Columns.Contains("BDBZQSE") && pRow["BDBZQSE"] != DBNull.Value) { obj.BDBZQSE = Convert.ToDouble(pRow["BDBZQSE"]); }
						if (pRow.Table.Columns.Contains("ZGZQSE") && pRow["ZGZQSE"] != DBNull.Value) { obj.ZGZQSE = Convert.ToDouble(pRow["ZGZQSE"]); }
						if (pRow.Table.Columns.Contains("QLQSSJ") && pRow["QLQSSJ"] != DBNull.Value) { obj.QLQSSJ = Convert.ToDateTime(pRow["QLQSSJ"]); }
						if (pRow.Table.Columns.Contains("QLJSSJ") && pRow["QLJSSJ"] != DBNull.Value) { obj.QLJSSJ = Convert.ToDateTime(pRow["QLJSSJ"]); }
						if (pRow.Table.Columns.Contains("QLQX") && pRow["QLQX"] != DBNull.Value) { obj.QLQX = Convert.ToString(pRow["QLQX"]); }
						if (pRow.Table.Columns.Contains("ZGZQQDSSHSE") && pRow["ZGZQQDSSHSE"] != DBNull.Value) { obj.ZGZQQDSSHSE = Convert.ToString(pRow["ZGZQQDSSHSE"]); }
						if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
						if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
						if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
						if (pRow.Table.Columns.Contains("DJZMH") && pRow["DJZMH"] != DBNull.Value) { obj.DJZMH = Convert.ToString(pRow["DJZMH"]); }
						if (pRow.Table.Columns.Contains("DJZMBSM") && pRow["DJZMBSM"] != DBNull.Value) { obj.DJZMBSM = Convert.ToInt64(pRow["DJZMBSM"]); }
						if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
						if (pRow.Table.Columns.Contains("DYSXH") && pRow["DYSXH"] != DBNull.Value) { obj.DYSXH = Convert.ToInt16(pRow["DYSXH"]); }
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
						if (pRow.Table.Columns.Contains("SHBSM") && pRow["SHBSM"] != DBNull.Value) { obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("DJJG") && pRow["DJJG"] != DBNull.Value) { obj.DJJG = Convert.ToString(pRow["DJJG"]); }
						
						if (pRow.Table.Columns.Contains("HTBH") && pRow["HTBH"] != DBNull.Value) { obj.HTBH = Convert.ToString(pRow["HTBH"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						
						if (pRow.Table.Columns.Contains("DYSX") && pRow["DYSX"] != DBNull.Value) { obj.DYSX = Convert.ToString(pRow["DYSX"]); }
						
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						
						if (pRow.Table.Columns.Contains("DBFW") && pRow["DBFW"] != DBNull.Value) { obj.DBFW = Convert.ToString(pRow["DBFW"]); }
						
						if (pRow.Table.Columns.Contains("HBLX") && pRow["HBLX"] != DBNull.Value) { obj.HBLX = Convert.ToString(pRow["HBLX"]); }
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
