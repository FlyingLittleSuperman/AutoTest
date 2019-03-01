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

	public class Fld_XZDJ
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string XZZXJG="XZZXJG";
		public const string XZLX="XZLX";
		public const string XZFS="XZFS";
		public const string XZWJ="XZWJ";
		public const string XZWJLX="XZWJLX";
		public const string XZWH="XZWH";
		public const string XZQSSJ="XZQSSJ";
		public const string XZJSSJ="XZJSSJ";
		public const string BXZR="BXZR";
		public const string XZBW="XZBW";
		public const string BXZQZH="BXZQZH";
		public const string XZMJ="XZMJ";
		public const string SAJE="SAJE";
		public const string XZYY="XZYY";
		public const string XGR="XGR";
		public const string DBR="DBR";
		public const string DJSJ="DJSJ";
		public const string FJ="FJ";
		public const string QSZT="QSZT";
		public const string SHBSM="SHBSM";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string QXDM="QXDM";
		public const string BZ_ISDELETE="BZ_ISDELETE";
		public const string BZ_TDESC="BZ_TDESC";
		public const string REV_="REV_";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string YXTBSM1="YXTBSM1";
		public const string OINSID="OINSID";
		public const string BXZZL="BXZZL";
		public const string WGLZT="WGLZT";
		public const string BXZZMH="BXZZMH";
		public const string HH="HH";
		public const string XZSQR="XZSQR";
		public const string XZQXSJ="XZQXSJ";
		public const string BZ_MJ="BZ_MJ";
		public const string BZ_YT="BZ_YT";
		#endregion
	}

	public class clsXZDJ:IEntity
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
		private string m_XZZXJG;
		private string m_XZLX;
		private string m_XZFS;
		private string m_XZWJ;
		private string m_XZWJLX;
		private string m_XZWH;
		private DateTime m_XZQSSJ;
		private DateTime m_XZJSSJ;
		private string m_BXZR;
		private string m_XZBW;
		private string m_BXZQZH;
		private double m_XZMJ;
		private double m_SAJE;
		private string m_XZYY;
		private string m_XGR;
		private string m_DBR;
		private DateTime m_DJSJ;
		private string m_FJ;
		private string m_QSZT;
		private long m_SHBSM;
		private string m_YXTBM;
		private string m_YXTBSM;
		private long m_QXDM;
		private long m_REV_;
		private DateTime m_GXSJ;
		private string m_BZ;
		private string m_BXZZL;
		private int m_WGLZT;
		private string m_BXZZMH;
		private string m_HH;
		private string m_XZSQR;
		private DateTime m_XZQXSJ;


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
		public string XZZXJG
		{
			get{ return m_XZZXJG; }
			set{ m_XZZXJG = value; }
		}
		public string XZLX
		{
			get{ return m_XZLX; }
			set{ m_XZLX = value; }
		}
		public string XZFS
		{
			get{ return m_XZFS; }
			set{ m_XZFS = value; }
		}
		public string XZWJ
		{
			get{ return m_XZWJ; }
			set{ m_XZWJ = value; }
		}
		public string XZWJLX
		{
			get{ return m_XZWJLX; }
			set{ m_XZWJLX = value; }
		}
		public string XZWH
		{
			get{ return m_XZWH; }
			set{ m_XZWH = value; }
		}
		public DateTime XZQSSJ
		{
			get{ return m_XZQSSJ; }
			set{ m_XZQSSJ = value; }
		}
		public DateTime XZJSSJ
		{
			get{ return m_XZJSSJ; }
			set{ m_XZJSSJ = value; }
		}
		public string BXZR
		{
			get{ return m_BXZR; }
			set{ m_BXZR = value; }
		}
		public string XZBW
		{
			get{ return m_XZBW; }
			set{ m_XZBW = value; }
		}
		public string BXZQZH
		{
			get{ return m_BXZQZH; }
			set{ m_BXZQZH = value; }
		}
		public double XZMJ
		{
			get{ return m_XZMJ; }
			set{ m_XZMJ = value; }
		}
		public double SAJE
		{
			get{ return m_SAJE; }
			set{ m_SAJE = value; }
		}
		public string XZYY
		{
			get{ return m_XZYY; }
			set{ m_XZYY = value; }
		}
		public string XGR
		{
			get{ return m_XGR; }
			set{ m_XGR = value; }
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
		public string BXZZL
		{
			get{ return m_BXZZL; }
			set{ m_BXZZL = value; }
		}
		public int WGLZT
		{
			get{ return m_WGLZT; }
			set{ m_WGLZT = value; }
		}
		public string BXZZMH
		{
			get{ return m_BXZZMH; }
			set{ m_BXZZMH = value; }
		}
		public string HH
		{
			get{ return m_HH; }
			set{ m_HH = value; }
		}
		public string XZSQR
		{
			get{ return m_XZSQR; }
			set{ m_XZSQR = value; }
		}
		public DateTime XZQXSJ
		{
			get{ return m_XZQXSJ; }
			set{ m_XZQXSJ = value; }
		}

		#endregion
		public bool IsEquals(clsXZDJ obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.XZZXJG != obj.XZZXJG) bolResult = false;
			if (this.XZLX != obj.XZLX) bolResult = false;
			if (this.XZFS != obj.XZFS) bolResult = false;
			if (this.XZWJ != obj.XZWJ) bolResult = false;
			if (this.XZWJLX != obj.XZWJLX) bolResult = false;
			if (this.XZWH != obj.XZWH) bolResult = false;
			if (this.XZQSSJ != obj.XZQSSJ) bolResult = false;
			if (this.XZJSSJ != obj.XZJSSJ) bolResult = false;
			if (this.BXZR != obj.BXZR) bolResult = false;
			if (this.XZBW != obj.XZBW) bolResult = false;
			if (this.BXZQZH != obj.BXZQZH) bolResult = false;
			if (this.XZMJ != obj.XZMJ) bolResult = false;
			if (this.SAJE != obj.SAJE) bolResult = false;
			if (this.XZYY != obj.XZYY) bolResult = false;
			if (this.XGR != obj.XGR) bolResult = false;
			if (this.DBR != obj.DBR) bolResult = false;
			if (this.DJSJ != obj.DJSJ) bolResult = false;
			if (this.FJ != obj.FJ) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.SHBSM != obj.SHBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.BXZZL != obj.BXZZL) bolResult = false;
			if (this.WGLZT != obj.WGLZT) bolResult = false;
			if (this.BXZZMH != obj.BXZZMH) bolResult = false;
			if (this.HH != obj.HH) bolResult = false;
			if (this.XZSQR != obj.XZSQR) bolResult = false;
			if (this.XZQXSJ != obj.XZQXSJ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsXZDJ obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.XZZXJG=obj.XZZXJG;
			this.XZLX=obj.XZLX;
			this.XZFS=obj.XZFS;
			this.XZWJ=obj.XZWJ;
			this.XZWJLX=obj.XZWJLX;
			this.XZWH=obj.XZWH;
			this.XZQSSJ=obj.XZQSSJ;
			this.XZJSSJ=obj.XZJSSJ;
			this.BXZR=obj.BXZR;
			this.XZBW=obj.XZBW;
			this.BXZQZH=obj.BXZQZH;
			this.XZMJ=obj.XZMJ;
			this.SAJE=obj.SAJE;
			this.XZYY=obj.XZYY;
			this.XGR=obj.XGR;
			this.DBR=obj.DBR;
			this.DJSJ=obj.DJSJ;
			this.FJ=obj.FJ;
			this.QSZT=obj.QSZT;
			this.SHBSM=obj.SHBSM;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.BXZZL=obj.BXZZL;
			this.WGLZT=obj.WGLZT;
			this.BXZZMH=obj.BXZZMH;
			this.HH=obj.HH;
			this.XZSQR=obj.XZSQR;
			this.XZQXSJ=obj.XZQXSJ;
		}

	}

	public class clsXZDJSet:EntityBaseSet
	{
		public clsXZDJSet()
		{
			m_TableName="BDCDJ.XZDJ";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsXZDJSet";
		}
		public static clsXZDJSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsXZDJSet clsSet = new clsXZDJSet(); //(clsXZDJSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsXZDJSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsXZDJ obj = (clsXZDJ)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("XZZXJG")) datarow["XZZXJG"] = obj.XZZXJG;
				if(datarow.Table.Columns.Contains("XZLX")) datarow["XZLX"] = obj.XZLX;
				if(datarow.Table.Columns.Contains("XZFS")) datarow["XZFS"] = obj.XZFS;
				if(datarow.Table.Columns.Contains("XZWJ")) datarow["XZWJ"] = obj.XZWJ;
				if(datarow.Table.Columns.Contains("XZWJLX")) datarow["XZWJLX"] = obj.XZWJLX;
				if(datarow.Table.Columns.Contains("XZWH")) datarow["XZWH"] = obj.XZWH;
				if (obj.XZQSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("XZQSSJ")) datarow["XZQSSJ"] = obj.XZQSSJ;
				}
				if (obj.XZJSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("XZJSSJ")) datarow["XZJSSJ"] = obj.XZJSSJ;
				}
				if(datarow.Table.Columns.Contains("BXZR")) datarow["BXZR"] = obj.BXZR;
				if(datarow.Table.Columns.Contains("XZBW")) datarow["XZBW"] = obj.XZBW;
				if(datarow.Table.Columns.Contains("BXZQZH")) datarow["BXZQZH"] = obj.BXZQZH;
				if(datarow.Table.Columns.Contains("XZMJ")) datarow["XZMJ"] = obj.XZMJ;
				if(datarow.Table.Columns.Contains("SAJE")) datarow["SAJE"] = obj.SAJE;
				if(datarow.Table.Columns.Contains("XZYY")) datarow["XZYY"] = obj.XZYY;
				if(datarow.Table.Columns.Contains("XGR")) datarow["XGR"] = obj.XGR;
				if(datarow.Table.Columns.Contains("DBR")) datarow["DBR"] = obj.DBR;
				if (obj.DJSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("DJSJ")) datarow["DJSJ"] = obj.DJSJ;
				}
				if(datarow.Table.Columns.Contains("FJ")) datarow["FJ"] = obj.FJ;
				if(datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
				if(datarow.Table.Columns.Contains("SHBSM")) datarow["SHBSM"] = obj.SHBSM;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("BXZZL")) datarow["BXZZL"] = obj.BXZZL;
				if(datarow.Table.Columns.Contains("WGLZT")) datarow["WGLZT"] = obj.WGLZT;
				if(datarow.Table.Columns.Contains("BXZZMH")) datarow["BXZZMH"] = obj.BXZZMH;
				if(datarow.Table.Columns.Contains("HH")) datarow["HH"] = obj.HH;
				if(datarow.Table.Columns.Contains("XZSQR")) datarow["XZSQR"] = obj.XZSQR;
				if (obj.XZQXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("XZQXSJ")) datarow["XZQXSJ"] = obj.XZQXSJ;
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
			clsXZDJ obj = null;
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
					obj = new clsXZDJ();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="XZZXJG")
								if (pRow.Table.Columns.Contains("XZZXJG") && pRow["XZZXJG"] != DBNull.Value) { obj.XZZXJG = Convert.ToString(pRow["XZZXJG"]); }
							if(strFldName.ToUpper()=="XZLX")
								if (pRow.Table.Columns.Contains("XZLX") && pRow["XZLX"] != DBNull.Value) { obj.XZLX = Convert.ToString(pRow["XZLX"]); }
							if(strFldName.ToUpper()=="XZFS")
								if (pRow.Table.Columns.Contains("XZFS") && pRow["XZFS"] != DBNull.Value) { obj.XZFS = Convert.ToString(pRow["XZFS"]); }
							if(strFldName.ToUpper()=="XZWJ")
								if (pRow.Table.Columns.Contains("XZWJ") && pRow["XZWJ"] != DBNull.Value) { obj.XZWJ = Convert.ToString(pRow["XZWJ"]); }
							if(strFldName.ToUpper()=="XZWJLX")
								if (pRow.Table.Columns.Contains("XZWJLX") && pRow["XZWJLX"] != DBNull.Value) { obj.XZWJLX = Convert.ToString(pRow["XZWJLX"]); }
							if(strFldName.ToUpper()=="XZWH")
								if (pRow.Table.Columns.Contains("XZWH") && pRow["XZWH"] != DBNull.Value) { obj.XZWH = Convert.ToString(pRow["XZWH"]); }
							if(strFldName.ToUpper()=="XZQSSJ")
								if (pRow.Table.Columns.Contains("XZQSSJ") && pRow["XZQSSJ"] != DBNull.Value) { obj.XZQSSJ = Convert.ToDateTime(pRow["XZQSSJ"]); }
							if(strFldName.ToUpper()=="XZJSSJ")
								if (pRow.Table.Columns.Contains("XZJSSJ") && pRow["XZJSSJ"] != DBNull.Value) { obj.XZJSSJ = Convert.ToDateTime(pRow["XZJSSJ"]); }
							if(strFldName.ToUpper()=="BXZR")
								if (pRow.Table.Columns.Contains("BXZR") && pRow["BXZR"] != DBNull.Value) { obj.BXZR = Convert.ToString(pRow["BXZR"]); }
							if(strFldName.ToUpper()=="XZBW")
								if (pRow.Table.Columns.Contains("XZBW") && pRow["XZBW"] != DBNull.Value) { obj.XZBW = Convert.ToString(pRow["XZBW"]); }
							if(strFldName.ToUpper()=="BXZQZH")
								if (pRow.Table.Columns.Contains("BXZQZH") && pRow["BXZQZH"] != DBNull.Value) { obj.BXZQZH = Convert.ToString(pRow["BXZQZH"]); }
							if(strFldName.ToUpper()=="XZMJ")
								if (pRow.Table.Columns.Contains("XZMJ") && pRow["XZMJ"] != DBNull.Value) { obj.XZMJ = Convert.ToDouble(pRow["XZMJ"]); }
							if(strFldName.ToUpper()=="SAJE")
								if (pRow.Table.Columns.Contains("SAJE") && pRow["SAJE"] != DBNull.Value) { obj.SAJE = Convert.ToDouble(pRow["SAJE"]); }
							if(strFldName.ToUpper()=="XZYY")
								if (pRow.Table.Columns.Contains("XZYY") && pRow["XZYY"] != DBNull.Value) { obj.XZYY = Convert.ToString(pRow["XZYY"]); }
							if(strFldName.ToUpper()=="XGR")
								if (pRow.Table.Columns.Contains("XGR") && pRow["XGR"] != DBNull.Value) { obj.XGR = Convert.ToString(pRow["XGR"]); }
							if(strFldName.ToUpper()=="DBR")
								if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
							if(strFldName.ToUpper()=="DJSJ")
								if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
							if(strFldName.ToUpper()=="FJ")
								if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
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
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							
							if(strFldName.ToUpper()=="BXZZL")
								if (pRow.Table.Columns.Contains("BXZZL") && pRow["BXZZL"] != DBNull.Value) { obj.BXZZL = Convert.ToString(pRow["BXZZL"]); }
							if(strFldName.ToUpper()=="WGLZT")
								if (pRow.Table.Columns.Contains("WGLZT") && pRow["WGLZT"] != DBNull.Value) { obj.WGLZT = Convert.ToInt16(pRow["WGLZT"]); }
							if(strFldName.ToUpper()=="BXZZMH")
								if (pRow.Table.Columns.Contains("BXZZMH") && pRow["BXZZMH"] != DBNull.Value) { obj.BXZZMH = Convert.ToString(pRow["BXZZMH"]); }
							if(strFldName.ToUpper()=="HH")
								if (pRow.Table.Columns.Contains("HH") && pRow["HH"] != DBNull.Value) { obj.HH = Convert.ToString(pRow["HH"]); }
							if(strFldName.ToUpper()=="XZSQR")
								if (pRow.Table.Columns.Contains("XZSQR") && pRow["XZSQR"] != DBNull.Value) { obj.XZSQR = Convert.ToString(pRow["XZSQR"]); }
							if(strFldName.ToUpper()=="XZQXSJ")
								if (pRow.Table.Columns.Contains("XZQXSJ") && pRow["XZQXSJ"] != DBNull.Value) { obj.XZQXSJ = Convert.ToDateTime(pRow["XZQXSJ"]); }
							
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("XZZXJG") && pRow["XZZXJG"] != DBNull.Value) { obj.XZZXJG = Convert.ToString(pRow["XZZXJG"]); }
						if (pRow.Table.Columns.Contains("XZLX") && pRow["XZLX"] != DBNull.Value) { obj.XZLX = Convert.ToString(pRow["XZLX"]); }
						if (pRow.Table.Columns.Contains("XZFS") && pRow["XZFS"] != DBNull.Value) { obj.XZFS = Convert.ToString(pRow["XZFS"]); }
						if (pRow.Table.Columns.Contains("XZWJ") && pRow["XZWJ"] != DBNull.Value) { obj.XZWJ = Convert.ToString(pRow["XZWJ"]); }
						if (pRow.Table.Columns.Contains("XZWJLX") && pRow["XZWJLX"] != DBNull.Value) { obj.XZWJLX = Convert.ToString(pRow["XZWJLX"]); }
						if (pRow.Table.Columns.Contains("XZWH") && pRow["XZWH"] != DBNull.Value) { obj.XZWH = Convert.ToString(pRow["XZWH"]); }
						if (pRow.Table.Columns.Contains("XZQSSJ") && pRow["XZQSSJ"] != DBNull.Value) { obj.XZQSSJ = Convert.ToDateTime(pRow["XZQSSJ"]); }
						if (pRow.Table.Columns.Contains("XZJSSJ") && pRow["XZJSSJ"] != DBNull.Value) { obj.XZJSSJ = Convert.ToDateTime(pRow["XZJSSJ"]); }
						if (pRow.Table.Columns.Contains("BXZR") && pRow["BXZR"] != DBNull.Value) { obj.BXZR = Convert.ToString(pRow["BXZR"]); }
						if (pRow.Table.Columns.Contains("XZBW") && pRow["XZBW"] != DBNull.Value) { obj.XZBW = Convert.ToString(pRow["XZBW"]); }
						if (pRow.Table.Columns.Contains("BXZQZH") && pRow["BXZQZH"] != DBNull.Value) { obj.BXZQZH = Convert.ToString(pRow["BXZQZH"]); }
						if (pRow.Table.Columns.Contains("XZMJ") && pRow["XZMJ"] != DBNull.Value) { obj.XZMJ = Convert.ToDouble(pRow["XZMJ"]); }
						if (pRow.Table.Columns.Contains("SAJE") && pRow["SAJE"] != DBNull.Value) { obj.SAJE = Convert.ToDouble(pRow["SAJE"]); }
						if (pRow.Table.Columns.Contains("XZYY") && pRow["XZYY"] != DBNull.Value) { obj.XZYY = Convert.ToString(pRow["XZYY"]); }
						if (pRow.Table.Columns.Contains("XGR") && pRow["XGR"] != DBNull.Value) { obj.XGR = Convert.ToString(pRow["XGR"]); }
						if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
						if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
						if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
						if (pRow.Table.Columns.Contains("SHBSM") && pRow["SHBSM"] != DBNull.Value) { obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
		
						if (pRow.Table.Columns.Contains("BXZZL") && pRow["BXZZL"] != DBNull.Value) { obj.BXZZL = Convert.ToString(pRow["BXZZL"]); }
						if (pRow.Table.Columns.Contains("WGLZT") && pRow["WGLZT"] != DBNull.Value) { obj.WGLZT = Convert.ToInt16(pRow["WGLZT"]); }
						if (pRow.Table.Columns.Contains("BXZZMH") && pRow["BXZZMH"] != DBNull.Value) { obj.BXZZMH = Convert.ToString(pRow["BXZZMH"]); }
						if (pRow.Table.Columns.Contains("HH") && pRow["HH"] != DBNull.Value) { obj.HH = Convert.ToString(pRow["HH"]); }
						if (pRow.Table.Columns.Contains("XZSQR") && pRow["XZSQR"] != DBNull.Value) { obj.XZSQR = Convert.ToString(pRow["XZSQR"]); }
						if (pRow.Table.Columns.Contains("XZQXSJ") && pRow["XZQXSJ"] != DBNull.Value) { obj.XZQXSJ = Convert.ToDateTime(pRow["XZQXSJ"]); }
					
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
