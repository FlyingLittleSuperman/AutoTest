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

	public class Fld_YGDJ
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string BDCZL="BDCZL";
		public const string YGDJZL="YGDJZL";
		public const string DJLX="DJLX";
		public const string YXTDJLXMC="YXTDJLXMC";
		public const string DJYY="DJYY";
		public const string TDSYQR="TDSYQR";
		public const string QDJG="QDJG";
		public const string DJZMH="DJZMH";
		public const string DJZMBSM="DJZMBSM";
		public const string DBR="DBR";
		public const string DJSJ="DJSJ";
		public const string FJ="FJ";
		public const string FKFS="FKFS";
		public const string DKLX="DKLX";
		public const string HTBH="HTBH";
		public const string ZXYWH="ZXYWH";
		public const string ZXSJ="ZXSJ";
		public const string ZXDBR="ZXDBR";
		public const string ZXFJ="ZXFJ";
		public const string ZXYY="ZXYY";
		public const string QLQSSJ="QLQSSJ";
		public const string QLJSSJ="QLJSSJ";
		public const string BZ="BZ";
		public const string QSZT="QSZT";
		public const string SHBSM="SHBSM";
		public const string ZXSHBSM="ZXSHBSM";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string DJJG="DJJG";
		public const string DYFS="DYFS";
		public const string DYSX="DYSX";
		public const string BZ_XMBSM="BZ_XMBSM";
		public const string BZ_GXSJ="BZ_GXSJ";
		public const string GXSJ="GXSJ";
		public const string OINSID="OINSID";
		public const string BZ_QLID="BZ_QLID";
		public const string BZ_YWSLID="BZ_YWSLID";
		public const string HBLX="HBLX";
		#endregion
	}

	public class clsYGDJ:IEntity
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
		private string m_BDCZL;
		private string m_YGDJZL;
		private string m_DJLX;
		private string m_YXTDJLXMC;
		private string m_DJYY;
		private string m_TDSYQR;
		private double m_QDJG;
		private string m_DJZMH;
		private long m_DJZMBSM;
		private string m_DBR;
		private DateTime m_DJSJ;
		private string m_FJ;
		private string m_FKFS;
		private string m_DKLX;
		private string m_HTBH;
		private string m_ZXYWH;
		private DateTime m_ZXSJ;
		private string m_ZXDBR;
		private string m_ZXFJ;
		private string m_ZXYY;
		private DateTime m_QLQSSJ;
		private DateTime m_QLJSSJ;
		private string m_BZ;
		private string m_QSZT;
		private long m_SHBSM;
		private long m_ZXSHBSM;
		private string m_YXTBM;
		private string m_YXTBSM;
		private long m_QXDM;
		private long m_REV_;
		private string m_DJJG;
		private string m_DYFS;
		private string m_DYSX;
		private DateTime m_GXSJ;
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
		public string BDCZL
		{
			get{ return m_BDCZL; }
			set{ m_BDCZL = value; }
		}
		public string YGDJZL
		{
			get{ return m_YGDJZL; }
			set{ m_YGDJZL = value; }
		}
		public string DJLX
		{
			get{ return m_DJLX; }
			set{ m_DJLX = value; }
		}
		public string YXTDJLXMC
		{
			get{ return m_YXTDJLXMC; }
			set{ m_YXTDJLXMC = value; }
		}
		public string DJYY
		{
			get{ return m_DJYY; }
			set{ m_DJYY = value; }
		}
		public string TDSYQR
		{
			get{ return m_TDSYQR; }
			set{ m_TDSYQR = value; }
		}
		public double QDJG
		{
			get{ return m_QDJG; }
			set{ m_QDJG = value; }
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
		public string FKFS
		{
			get{ return m_FKFS; }
			set{ m_FKFS = value; }
		}
		public string DKLX
		{
			get{ return m_DKLX; }
			set{ m_DKLX = value; }
		}
		public string HTBH
		{
			get{ return m_HTBH; }
			set{ m_HTBH = value; }
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
		public string ZXFJ
		{
			get{ return m_ZXFJ; }
			set{ m_ZXFJ = value; }
		}
		public string ZXYY
		{
			get{ return m_ZXYY; }
			set{ m_ZXYY = value; }
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
		public string DJJG
		{
			get{ return m_DJJG; }
			set{ m_DJJG = value; }
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
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		public string HBLX
		{
			get{ return m_HBLX; }
			set{ m_HBLX = value; }
		}

		#endregion
		public bool IsEquals(clsYGDJ obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.BDCZL != obj.BDCZL) bolResult = false;
			if (this.YGDJZL != obj.YGDJZL) bolResult = false;
			if (this.DJLX != obj.DJLX) bolResult = false;
			if (this.YXTDJLXMC != obj.YXTDJLXMC) bolResult = false;
			if (this.DJYY != obj.DJYY) bolResult = false;
			if (this.TDSYQR != obj.TDSYQR) bolResult = false;
			if (this.QDJG != obj.QDJG) bolResult = false;
			if (this.DJZMH != obj.DJZMH) bolResult = false;
			if (this.DJZMBSM != obj.DJZMBSM) bolResult = false;
			if (this.DBR != obj.DBR) bolResult = false;
			if (this.DJSJ != obj.DJSJ) bolResult = false;
			if (this.FJ != obj.FJ) bolResult = false;
			if (this.FKFS != obj.FKFS) bolResult = false;
			if (this.DKLX != obj.DKLX) bolResult = false;
			if (this.HTBH != obj.HTBH) bolResult = false;
			if (this.ZXYWH != obj.ZXYWH) bolResult = false;
			if (this.ZXSJ != obj.ZXSJ) bolResult = false;
			if (this.ZXDBR != obj.ZXDBR) bolResult = false;
			if (this.ZXFJ != obj.ZXFJ) bolResult = false;
			if (this.ZXYY != obj.ZXYY) bolResult = false;
			if (this.QLQSSJ != obj.QLQSSJ) bolResult = false;
			if (this.QLJSSJ != obj.QLJSSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.SHBSM != obj.SHBSM) bolResult = false;
			if (this.ZXSHBSM != obj.ZXSHBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.DJJG != obj.DJJG) bolResult = false;
			if (this.DYFS != obj.DYFS) bolResult = false;
			if (this.DYSX != obj.DYSX) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.HBLX != obj.HBLX) bolResult = false;
			return bolResult;
		}

		public void Colne(clsYGDJ obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.BDCZL=obj.BDCZL;
			this.YGDJZL=obj.YGDJZL;
			this.DJLX=obj.DJLX;
			this.YXTDJLXMC=obj.YXTDJLXMC;
			this.DJYY=obj.DJYY;
			this.TDSYQR=obj.TDSYQR;
			this.QDJG=obj.QDJG;
			this.DJZMH=obj.DJZMH;
			this.DJZMBSM=obj.DJZMBSM;
			this.DBR=obj.DBR;
			this.DJSJ=obj.DJSJ;
			this.FJ=obj.FJ;
			this.FKFS=obj.FKFS;
			this.DKLX=obj.DKLX;
			this.HTBH=obj.HTBH;
			this.ZXYWH=obj.ZXYWH;
			this.ZXSJ=obj.ZXSJ;
			this.ZXDBR=obj.ZXDBR;
			this.ZXFJ=obj.ZXFJ;
			this.ZXYY=obj.ZXYY;
			this.QLQSSJ=obj.QLQSSJ;
			this.QLJSSJ=obj.QLJSSJ;
			this.BZ=obj.BZ;
			this.QSZT=obj.QSZT;
			this.SHBSM=obj.SHBSM;
			this.ZXSHBSM=obj.ZXSHBSM;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.DJJG=obj.DJJG;
			this.DYFS=obj.DYFS;
			this.DYSX=obj.DYSX;
			this.GXSJ=obj.GXSJ;
			this.HBLX=obj.HBLX;
		}

	}

	public class clsYGDJSet:EntityBaseSet
	{
		public clsYGDJSet()
		{
			m_TableName="BDCDJ.YGDJ";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsYGDJSet";
		}
		public static clsYGDJSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsYGDJSet clsSet = new clsYGDJSet(); //(clsYGDJSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsYGDJSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsYGDJ obj = (clsYGDJ)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("BDCZL")) datarow["BDCZL"] = obj.BDCZL;
				if(datarow.Table.Columns.Contains("YGDJZL")) datarow["YGDJZL"] = obj.YGDJZL;
				if(datarow.Table.Columns.Contains("DJLX")) datarow["DJLX"] = obj.DJLX;
				if(datarow.Table.Columns.Contains("YXTDJLXMC")) datarow["YXTDJLXMC"] = obj.YXTDJLXMC;
				if(datarow.Table.Columns.Contains("DJYY")) datarow["DJYY"] = obj.DJYY;
				if(datarow.Table.Columns.Contains("TDSYQR")) datarow["TDSYQR"] = obj.TDSYQR;
				if(datarow.Table.Columns.Contains("QDJG")) datarow["QDJG"] = obj.QDJG;
				if(datarow.Table.Columns.Contains("DJZMH")) datarow["DJZMH"] = obj.DJZMH;
				if(datarow.Table.Columns.Contains("DJZMBSM")) datarow["DJZMBSM"] = obj.DJZMBSM;
				if(datarow.Table.Columns.Contains("DBR")) datarow["DBR"] = obj.DBR;
				if (obj.DJSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("DJSJ")) datarow["DJSJ"] = obj.DJSJ;
				}
				if(datarow.Table.Columns.Contains("FJ")) datarow["FJ"] = obj.FJ;
				if(datarow.Table.Columns.Contains("FKFS")) datarow["FKFS"] = obj.FKFS;
				if(datarow.Table.Columns.Contains("DKLX")) datarow["DKLX"] = obj.DKLX;
				if(datarow.Table.Columns.Contains("HTBH")) datarow["HTBH"] = obj.HTBH;
				if(datarow.Table.Columns.Contains("ZXYWH")) datarow["ZXYWH"] = obj.ZXYWH;
				if (obj.ZXSJ.Year !=1)
				{
                    if (datarow.Table.Columns.Contains("ZXSJ")) datarow["ZXSJ"] = obj.ZXSJ;
					
				}
                else
                {
                    if (datarow.Table.Columns.Contains("ZXSJ")) datarow["ZXSJ"] = DBNull.Value;
                }
				if(datarow.Table.Columns.Contains("ZXDBR")) datarow["ZXDBR"] = obj.ZXDBR;
				if(datarow.Table.Columns.Contains("ZXFJ")) datarow["ZXFJ"] = obj.ZXFJ;
				if(datarow.Table.Columns.Contains("ZXYY")) datarow["ZXYY"] = obj.ZXYY;
				if (obj.QLQSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("QLQSSJ")) datarow["QLQSSJ"] = obj.QLQSSJ;
				}
				if (obj.QLJSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("QLJSSJ")) datarow["QLJSSJ"] = obj.QLJSSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
				if(datarow.Table.Columns.Contains("SHBSM")) datarow["SHBSM"] = obj.SHBSM;
				if(datarow.Table.Columns.Contains("ZXSHBSM")) datarow["ZXSHBSM"] = obj.ZXSHBSM;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("DJJG")) datarow["DJJG"] = obj.DJJG;
				if(datarow.Table.Columns.Contains("DYFS")) datarow["DYFS"] = obj.DYFS;
				if(datarow.Table.Columns.Contains("DYSX")) datarow["DYSX"] = obj.DYSX;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
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
			clsYGDJ obj = null;
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
					obj = new clsYGDJ();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="BDCZL")
								if (pRow.Table.Columns.Contains("BDCZL") && pRow["BDCZL"] != DBNull.Value) { obj.BDCZL = Convert.ToString(pRow["BDCZL"]); }
							if(strFldName.ToUpper()=="YGDJZL")
								if (pRow.Table.Columns.Contains("YGDJZL") && pRow["YGDJZL"] != DBNull.Value) { obj.YGDJZL = Convert.ToString(pRow["YGDJZL"]); }
							if(strFldName.ToUpper()=="DJLX")
								if (pRow.Table.Columns.Contains("DJLX") && pRow["DJLX"] != DBNull.Value) { obj.DJLX = Convert.ToString(pRow["DJLX"]); }
							if(strFldName.ToUpper()=="YXTDJLXMC")
								if (pRow.Table.Columns.Contains("YXTDJLXMC") && pRow["YXTDJLXMC"] != DBNull.Value) { obj.YXTDJLXMC = Convert.ToString(pRow["YXTDJLXMC"]); }
							if(strFldName.ToUpper()=="DJYY")
								if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
							if(strFldName.ToUpper()=="TDSYQR")
								if (pRow.Table.Columns.Contains("TDSYQR") && pRow["TDSYQR"] != DBNull.Value) { obj.TDSYQR = Convert.ToString(pRow["TDSYQR"]); }
							if(strFldName.ToUpper()=="QDJG")
								if (pRow.Table.Columns.Contains("QDJG") && pRow["QDJG"] != DBNull.Value) { obj.QDJG = Convert.ToDouble(pRow["QDJG"]); }
							if(strFldName.ToUpper()=="DJZMH")
								if (pRow.Table.Columns.Contains("DJZMH") && pRow["DJZMH"] != DBNull.Value) { obj.DJZMH = Convert.ToString(pRow["DJZMH"]); }
							if(strFldName.ToUpper()=="DJZMBSM")
								if (pRow.Table.Columns.Contains("DJZMBSM") && pRow["DJZMBSM"] != DBNull.Value) { obj.DJZMBSM = Convert.ToInt64(pRow["DJZMBSM"]); }
							if(strFldName.ToUpper()=="DBR")
								if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
							if(strFldName.ToUpper()=="DJSJ")
								if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
							if(strFldName.ToUpper()=="FJ")
								if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
							if(strFldName.ToUpper()=="FKFS")
								if (pRow.Table.Columns.Contains("FKFS") && pRow["FKFS"] != DBNull.Value) { obj.FKFS = Convert.ToString(pRow["FKFS"]); }
							if(strFldName.ToUpper()=="DKLX")
								if (pRow.Table.Columns.Contains("DKLX") && pRow["DKLX"] != DBNull.Value) { obj.DKLX = Convert.ToString(pRow["DKLX"]); }
							if(strFldName.ToUpper()=="HTBH")
								if (pRow.Table.Columns.Contains("HTBH") && pRow["HTBH"] != DBNull.Value) { obj.HTBH = Convert.ToString(pRow["HTBH"]); }
							if(strFldName.ToUpper()=="ZXYWH")
								if (pRow.Table.Columns.Contains("ZXYWH") && pRow["ZXYWH"] != DBNull.Value) { obj.ZXYWH = Convert.ToString(pRow["ZXYWH"]); }
							if(strFldName.ToUpper()=="ZXSJ")
								if (pRow.Table.Columns.Contains("ZXSJ") && pRow["ZXSJ"] != DBNull.Value) { obj.ZXSJ = Convert.ToDateTime(pRow["ZXSJ"]); }
							if(strFldName.ToUpper()=="ZXDBR")
								if (pRow.Table.Columns.Contains("ZXDBR") && pRow["ZXDBR"] != DBNull.Value) { obj.ZXDBR = Convert.ToString(pRow["ZXDBR"]); }
							if(strFldName.ToUpper()=="ZXFJ")
								if (pRow.Table.Columns.Contains("ZXFJ") && pRow["ZXFJ"] != DBNull.Value) { obj.ZXFJ = Convert.ToString(pRow["ZXFJ"]); }
							if(strFldName.ToUpper()=="ZXYY")
								if (pRow.Table.Columns.Contains("ZXYY") && pRow["ZXYY"] != DBNull.Value) { obj.ZXYY = Convert.ToString(pRow["ZXYY"]); }
							if(strFldName.ToUpper()=="QLQSSJ")
								if (pRow.Table.Columns.Contains("QLQSSJ") && pRow["QLQSSJ"] != DBNull.Value) { obj.QLQSSJ = Convert.ToDateTime(pRow["QLQSSJ"]); }
							if(strFldName.ToUpper()=="QLJSSJ")
								if (pRow.Table.Columns.Contains("QLJSSJ") && pRow["QLJSSJ"] != DBNull.Value) { obj.QLJSSJ = Convert.ToDateTime(pRow["QLJSSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="QSZT")
								if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
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
							if(strFldName.ToUpper()=="DJJG")
								if (pRow.Table.Columns.Contains("DJJG") && pRow["DJJG"] != DBNull.Value) { obj.DJJG = Convert.ToString(pRow["DJJG"]); }
							if(strFldName.ToUpper()=="DYFS")
								if (pRow.Table.Columns.Contains("DYFS") && pRow["DYFS"] != DBNull.Value) { obj.DYFS = Convert.ToString(pRow["DYFS"]); }
							if(strFldName.ToUpper()=="DYSX")
								if (pRow.Table.Columns.Contains("DYSX") && pRow["DYSX"] != DBNull.Value) { obj.DYSX = Convert.ToString(pRow["DYSX"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="HBLX")
								if (pRow.Table.Columns.Contains("HBLX") && pRow["HBLX"] != DBNull.Value) { obj.HBLX = Convert.ToString(pRow["HBLX"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("BDCZL") && pRow["BDCZL"] != DBNull.Value) { obj.BDCZL = Convert.ToString(pRow["BDCZL"]); }
						if (pRow.Table.Columns.Contains("YGDJZL") && pRow["YGDJZL"] != DBNull.Value) { obj.YGDJZL = Convert.ToString(pRow["YGDJZL"]); }
						if (pRow.Table.Columns.Contains("DJLX") && pRow["DJLX"] != DBNull.Value) { obj.DJLX = Convert.ToString(pRow["DJLX"]); }
						if (pRow.Table.Columns.Contains("YXTDJLXMC") && pRow["YXTDJLXMC"] != DBNull.Value) { obj.YXTDJLXMC = Convert.ToString(pRow["YXTDJLXMC"]); }
						if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
						if (pRow.Table.Columns.Contains("TDSYQR") && pRow["TDSYQR"] != DBNull.Value) { obj.TDSYQR = Convert.ToString(pRow["TDSYQR"]); }
						if (pRow.Table.Columns.Contains("QDJG") && pRow["QDJG"] != DBNull.Value) { obj.QDJG = Convert.ToDouble(pRow["QDJG"]); }
						if (pRow.Table.Columns.Contains("DJZMH") && pRow["DJZMH"] != DBNull.Value) { obj.DJZMH = Convert.ToString(pRow["DJZMH"]); }
						if (pRow.Table.Columns.Contains("DJZMBSM") && pRow["DJZMBSM"] != DBNull.Value) { obj.DJZMBSM = Convert.ToInt64(pRow["DJZMBSM"]); }
						if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
						if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
						if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
						if (pRow.Table.Columns.Contains("FKFS") && pRow["FKFS"] != DBNull.Value) { obj.FKFS = Convert.ToString(pRow["FKFS"]); }
						if (pRow.Table.Columns.Contains("DKLX") && pRow["DKLX"] != DBNull.Value) { obj.DKLX = Convert.ToString(pRow["DKLX"]); }
						if (pRow.Table.Columns.Contains("HTBH") && pRow["HTBH"] != DBNull.Value) { obj.HTBH = Convert.ToString(pRow["HTBH"]); }
						if (pRow.Table.Columns.Contains("ZXYWH") && pRow["ZXYWH"] != DBNull.Value) { obj.ZXYWH = Convert.ToString(pRow["ZXYWH"]); }
						if (pRow.Table.Columns.Contains("ZXSJ") && pRow["ZXSJ"] != DBNull.Value) { obj.ZXSJ = Convert.ToDateTime(pRow["ZXSJ"]); }
						if (pRow.Table.Columns.Contains("ZXDBR") && pRow["ZXDBR"] != DBNull.Value) { obj.ZXDBR = Convert.ToString(pRow["ZXDBR"]); }
						if (pRow.Table.Columns.Contains("ZXFJ") && pRow["ZXFJ"] != DBNull.Value) { obj.ZXFJ = Convert.ToString(pRow["ZXFJ"]); }
						if (pRow.Table.Columns.Contains("ZXYY") && pRow["ZXYY"] != DBNull.Value) { obj.ZXYY = Convert.ToString(pRow["ZXYY"]); }
						if (pRow.Table.Columns.Contains("QLQSSJ") && pRow["QLQSSJ"] != DBNull.Value) { obj.QLQSSJ = Convert.ToDateTime(pRow["QLQSSJ"]); }
						if (pRow.Table.Columns.Contains("QLJSSJ") && pRow["QLJSSJ"] != DBNull.Value) { obj.QLJSSJ = Convert.ToDateTime(pRow["QLJSSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
						if (pRow.Table.Columns.Contains("SHBSM") && pRow["SHBSM"] != DBNull.Value) { obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]); }
						if (pRow.Table.Columns.Contains("ZXSHBSM") && pRow["ZXSHBSM"] != DBNull.Value) { obj.ZXSHBSM = Convert.ToInt64(pRow["ZXSHBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("DJJG") && pRow["DJJG"] != DBNull.Value) { obj.DJJG = Convert.ToString(pRow["DJJG"]); }
						if (pRow.Table.Columns.Contains("DYFS") && pRow["DYFS"] != DBNull.Value) { obj.DYFS = Convert.ToString(pRow["DYFS"]); }
						if (pRow.Table.Columns.Contains("DYSX") && pRow["DYSX"] != DBNull.Value) { obj.DYSX = Convert.ToString(pRow["DYSX"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
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
