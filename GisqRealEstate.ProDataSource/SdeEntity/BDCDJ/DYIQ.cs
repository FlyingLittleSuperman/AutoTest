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

	public class Fld_DYIQ
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string XYDZL="XYDZL";
		public const string GYDZL="GYDZL";
		public const string GYDQLRBSM="GYDQLRBSM";
		public const string GYDQLR="GYDQLR";
		public const string GYDQLRZJZL="GYDQLRZJZL";
		public const string GYDQLRZJH="GYDQLRZJH";
		public const string DJLX="DJLX";
		public const string DJYY="DJYY";
		public const string DYQNR="DYQNR";
		public const string DJZMH="DJZMH";
		public const string DJZMBSM="DJZMBSM";
		public const string DBR="DBR";
		public const string DJSJ="DJSJ";
		public const string FJ="FJ";
		public const string QLLX="QLLX";
		public const string QLQSSJ="QLQSSJ";
		public const string QLJSSJ="QLJSSJ";
		public const string ZXYWH="ZXYWH";
		public const string ZXYY="ZXYY";
		public const string ZXSJ="ZXSJ";
		public const string ZXDBR="ZXDBR";
		public const string ZXFJ="ZXFJ";
		public const string QSZT="QSZT";
		public const string SHBSM="SHBSM";
		public const string ZXSHBSM="ZXSHBSM";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string DJJG="DJJG";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string LYMD="LYMD";
		public const string LYFF="LYFF";
		#endregion
	}

	public class clsDYIQ:IEntity
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
		private string m_XYDZL;
		private string m_GYDZL;
		private long m_GYDQLRBSM;
		private string m_GYDQLR;
		private string m_GYDQLRZJZL;
		private string m_GYDQLRZJH;
		private string m_DJLX;
		private string m_DJYY;
		private string m_DYQNR;
		private string m_DJZMH;
		private long m_DJZMBSM;
		private string m_DBR;
		private DateTime m_DJSJ;
		private string m_FJ;
		private string m_QLLX;
		private DateTime m_QLQSSJ;
		private DateTime m_QLJSSJ;
		private string m_ZXYWH;
		private string m_ZXYY;
		private DateTime m_ZXSJ;
		private string m_ZXDBR;
		private string m_ZXFJ;
		private string m_QSZT;
		private long m_SHBSM;
		private long m_ZXSHBSM;
		private string m_YXTBM;
		private string m_YXTBSM;
		private long m_QXDM;
		private long m_REV_;
		private string m_DJJG;
		private DateTime m_GXSJ;
		private string m_BZ;
		private string m_LYMD;
		private string m_LYFF;

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
		public string XYDZL
		{
			get{ return m_XYDZL; }
			set{ m_XYDZL = value; }
		}
		public string GYDZL
		{
			get{ return m_GYDZL; }
			set{ m_GYDZL = value; }
		}
		public long GYDQLRBSM
		{
			get{ return m_GYDQLRBSM; }
			set{ m_GYDQLRBSM = value; }
		}
		public string GYDQLR
		{
			get{ return m_GYDQLR; }
			set{ m_GYDQLR = value; }
		}
		public string GYDQLRZJZL
		{
			get{ return m_GYDQLRZJZL; }
			set{ m_GYDQLRZJZL = value; }
		}
		public string GYDQLRZJH
		{
			get{ return m_GYDQLRZJH; }
			set{ m_GYDQLRZJH = value; }
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
		public string DYQNR
		{
			get{ return m_DYQNR; }
			set{ m_DYQNR = value; }
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
		public string QLLX
		{
			get{ return m_QLLX; }
			set{ m_QLLX = value; }
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
		public string ZXYWH
		{
			get{ return m_ZXYWH; }
			set{ m_ZXYWH = value; }
		}
		public string ZXYY
		{
			get{ return m_ZXYY; }
			set{ m_ZXYY = value; }
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

		#endregion
		public bool IsEquals(clsDYIQ obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.XYDZL != obj.XYDZL) bolResult = false;
			if (this.GYDZL != obj.GYDZL) bolResult = false;
			if (this.GYDQLRBSM != obj.GYDQLRBSM) bolResult = false;
			if (this.GYDQLR != obj.GYDQLR) bolResult = false;
			if (this.GYDQLRZJZL != obj.GYDQLRZJZL) bolResult = false;
			if (this.GYDQLRZJH != obj.GYDQLRZJH) bolResult = false;
			if (this.DJLX != obj.DJLX) bolResult = false;
			if (this.DJYY != obj.DJYY) bolResult = false;
			if (this.DYQNR != obj.DYQNR) bolResult = false;
			if (this.DJZMH != obj.DJZMH) bolResult = false;
			if (this.DJZMBSM != obj.DJZMBSM) bolResult = false;
			if (this.DBR != obj.DBR) bolResult = false;
			if (this.DJSJ != obj.DJSJ) bolResult = false;
			if (this.FJ != obj.FJ) bolResult = false;
			if (this.QLLX != obj.QLLX) bolResult = false;
			if (this.QLQSSJ != obj.QLQSSJ) bolResult = false;
			if (this.QLJSSJ != obj.QLJSSJ) bolResult = false;
			if (this.ZXYWH != obj.ZXYWH) bolResult = false;
			if (this.ZXYY != obj.ZXYY) bolResult = false;
			if (this.ZXSJ != obj.ZXSJ) bolResult = false;
			if (this.ZXDBR != obj.ZXDBR) bolResult = false;
			if (this.ZXFJ != obj.ZXFJ) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.SHBSM != obj.SHBSM) bolResult = false;
			if (this.ZXSHBSM != obj.ZXSHBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.DJJG != obj.DJJG) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.LYMD != obj.LYMD) bolResult = false;
			if (this.LYFF != obj.LYFF) bolResult = false;
			return bolResult;
		}

		public void Colne(clsDYIQ obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.XYDZL=obj.XYDZL;
			this.GYDZL=obj.GYDZL;
			this.GYDQLRBSM=obj.GYDQLRBSM;
			this.GYDQLR=obj.GYDQLR;
			this.GYDQLRZJZL=obj.GYDQLRZJZL;
			this.GYDQLRZJH=obj.GYDQLRZJH;
			this.DJLX=obj.DJLX;
			this.DJYY=obj.DJYY;
			this.DYQNR=obj.DYQNR;
			this.DJZMH=obj.DJZMH;
			this.DJZMBSM=obj.DJZMBSM;
			this.DBR=obj.DBR;
			this.DJSJ=obj.DJSJ;
			this.FJ=obj.FJ;
			this.QLLX=obj.QLLX;
			this.QLQSSJ=obj.QLQSSJ;
			this.QLJSSJ=obj.QLJSSJ;
			this.ZXYWH=obj.ZXYWH;
			this.ZXYY=obj.ZXYY;
			this.ZXSJ=obj.ZXSJ;
			this.ZXDBR=obj.ZXDBR;
			this.ZXFJ=obj.ZXFJ;
			this.QSZT=obj.QSZT;
			this.SHBSM=obj.SHBSM;
			this.ZXSHBSM=obj.ZXSHBSM;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.DJJG=obj.DJJG;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.LYMD=obj.LYMD;
			this.LYFF=obj.LYFF;
		}

	}

	public class clsDYIQSet:EntityBaseSet
	{
		public clsDYIQSet()
		{
			m_TableName="BDCDJ.DYIQ";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsDYIQSet";
		}
		public static clsDYIQSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsDYIQSet clsSet = new clsDYIQSet(); //(clsDYIQSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsDYIQSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsDYIQ obj = (clsDYIQ)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("XYDZL")) datarow["XYDZL"] = obj.XYDZL;
				if(datarow.Table.Columns.Contains("GYDZL")) datarow["GYDZL"] = obj.GYDZL;
				if(datarow.Table.Columns.Contains("GYDQLRBSM")) datarow["GYDQLRBSM"] = obj.GYDQLRBSM;
				if(datarow.Table.Columns.Contains("GYDQLR")) datarow["GYDQLR"] = obj.GYDQLR;
				if(datarow.Table.Columns.Contains("GYDQLRZJZL")) datarow["GYDQLRZJZL"] = obj.GYDQLRZJZL;
				if(datarow.Table.Columns.Contains("GYDQLRZJH")) datarow["GYDQLRZJH"] = obj.GYDQLRZJH;
				if(datarow.Table.Columns.Contains("DJLX")) datarow["DJLX"] = obj.DJLX;
				if(datarow.Table.Columns.Contains("DJYY")) datarow["DJYY"] = obj.DJYY;
				if(datarow.Table.Columns.Contains("DYQNR")) datarow["DYQNR"] = obj.DYQNR;
				if(datarow.Table.Columns.Contains("DJZMH")) datarow["DJZMH"] = obj.DJZMH;
				if(datarow.Table.Columns.Contains("DJZMBSM")) datarow["DJZMBSM"] = obj.DJZMBSM;
				if(datarow.Table.Columns.Contains("DBR")) datarow["DBR"] = obj.DBR;
				if (obj.DJSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("DJSJ")) datarow["DJSJ"] = obj.DJSJ;
				}
				if(datarow.Table.Columns.Contains("FJ")) datarow["FJ"] = obj.FJ;
				if(datarow.Table.Columns.Contains("QLLX")) datarow["QLLX"] = obj.QLLX;
				if (obj.QLQSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("QLQSSJ")) datarow["QLQSSJ"] = obj.QLQSSJ;
				}
				if (obj.QLJSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("QLJSSJ")) datarow["QLJSSJ"] = obj.QLJSSJ;
				}
				if(datarow.Table.Columns.Contains("ZXYWH")) datarow["ZXYWH"] = obj.ZXYWH;
				if(datarow.Table.Columns.Contains("ZXYY")) datarow["ZXYY"] = obj.ZXYY;
				if (obj.ZXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("ZXSJ")) datarow["ZXSJ"] = obj.ZXSJ;
                }
                else
                {
                    if (datarow.Table.Columns.Contains("ZXSJ")) datarow["ZXSJ"] = DBNull.Value;
                }
				if(datarow.Table.Columns.Contains("ZXDBR")) datarow["ZXDBR"] = obj.ZXDBR;
				if(datarow.Table.Columns.Contains("ZXFJ")) datarow["ZXFJ"] = obj.ZXFJ;
				if(datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
				if(datarow.Table.Columns.Contains("SHBSM")) datarow["SHBSM"] = obj.SHBSM;
				if(datarow.Table.Columns.Contains("ZXSHBSM")) datarow["ZXSHBSM"] = obj.ZXSHBSM;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("DJJG")) datarow["DJJG"] = obj.DJJG;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("LYMD")) datarow["LYMD"] = obj.LYMD;
				if(datarow.Table.Columns.Contains("LYFF")) datarow["LYFF"] = obj.LYFF;
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
			clsDYIQ obj = null;
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
					obj = new clsDYIQ();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="XYDZL")
								if (pRow.Table.Columns.Contains("XYDZL") && pRow["XYDZL"] != DBNull.Value) { obj.XYDZL = Convert.ToString(pRow["XYDZL"]); }
							if(strFldName.ToUpper()=="GYDZL")
								if (pRow.Table.Columns.Contains("GYDZL") && pRow["GYDZL"] != DBNull.Value) { obj.GYDZL = Convert.ToString(pRow["GYDZL"]); }
							if(strFldName.ToUpper()=="GYDQLRBSM")
								if (pRow.Table.Columns.Contains("GYDQLRBSM") && pRow["GYDQLRBSM"] != DBNull.Value) { obj.GYDQLRBSM = Convert.ToInt64(pRow["GYDQLRBSM"]); }
							if(strFldName.ToUpper()=="GYDQLR")
								if (pRow.Table.Columns.Contains("GYDQLR") && pRow["GYDQLR"] != DBNull.Value) { obj.GYDQLR = Convert.ToString(pRow["GYDQLR"]); }
							if(strFldName.ToUpper()=="GYDQLRZJZL")
								if (pRow.Table.Columns.Contains("GYDQLRZJZL") && pRow["GYDQLRZJZL"] != DBNull.Value) { obj.GYDQLRZJZL = Convert.ToString(pRow["GYDQLRZJZL"]); }
							if(strFldName.ToUpper()=="GYDQLRZJH")
								if (pRow.Table.Columns.Contains("GYDQLRZJH") && pRow["GYDQLRZJH"] != DBNull.Value) { obj.GYDQLRZJH = Convert.ToString(pRow["GYDQLRZJH"]); }
							if(strFldName.ToUpper()=="DJLX")
								if (pRow.Table.Columns.Contains("DJLX") && pRow["DJLX"] != DBNull.Value) { obj.DJLX = Convert.ToString(pRow["DJLX"]); }
							if(strFldName.ToUpper()=="DJYY")
								if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
							if(strFldName.ToUpper()=="DYQNR")
								if (pRow.Table.Columns.Contains("DYQNR") && pRow["DYQNR"] != DBNull.Value) { obj.DYQNR = Convert.ToString(pRow["DYQNR"]); }
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
							if(strFldName.ToUpper()=="QLLX")
								if (pRow.Table.Columns.Contains("QLLX") && pRow["QLLX"] != DBNull.Value) { obj.QLLX = Convert.ToString(pRow["QLLX"]); }
							if(strFldName.ToUpper()=="QLQSSJ")
								if (pRow.Table.Columns.Contains("QLQSSJ") && pRow["QLQSSJ"] != DBNull.Value) { obj.QLQSSJ = Convert.ToDateTime(pRow["QLQSSJ"]); }
							if(strFldName.ToUpper()=="QLJSSJ")
								if (pRow.Table.Columns.Contains("QLJSSJ") && pRow["QLJSSJ"] != DBNull.Value) { obj.QLJSSJ = Convert.ToDateTime(pRow["QLJSSJ"]); }
							if(strFldName.ToUpper()=="ZXYWH")
								if (pRow.Table.Columns.Contains("ZXYWH") && pRow["ZXYWH"] != DBNull.Value) { obj.ZXYWH = Convert.ToString(pRow["ZXYWH"]); }
							if(strFldName.ToUpper()=="ZXYY")
								if (pRow.Table.Columns.Contains("ZXYY") && pRow["ZXYY"] != DBNull.Value) { obj.ZXYY = Convert.ToString(pRow["ZXYY"]); }
							if(strFldName.ToUpper()=="ZXSJ")
								if (pRow.Table.Columns.Contains("ZXSJ") && pRow["ZXSJ"] != DBNull.Value) { obj.ZXSJ = Convert.ToDateTime(pRow["ZXSJ"]); }
							if(strFldName.ToUpper()=="ZXDBR")
								if (pRow.Table.Columns.Contains("ZXDBR") && pRow["ZXDBR"] != DBNull.Value) { obj.ZXDBR = Convert.ToString(pRow["ZXDBR"]); }
							if(strFldName.ToUpper()=="ZXFJ")
								if (pRow.Table.Columns.Contains("ZXFJ") && pRow["ZXFJ"] != DBNull.Value) { obj.ZXFJ = Convert.ToString(pRow["ZXFJ"]); }
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
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="LYMD")
								if (pRow.Table.Columns.Contains("LYMD") && pRow["LYMD"] != DBNull.Value) { obj.LYMD = Convert.ToString(pRow["LYMD"]); }
							if(strFldName.ToUpper()=="LYFF")
								if (pRow.Table.Columns.Contains("LYFF") && pRow["LYFF"] != DBNull.Value) { obj.LYFF = Convert.ToString(pRow["LYFF"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("XYDZL") && pRow["XYDZL"] != DBNull.Value) { obj.XYDZL = Convert.ToString(pRow["XYDZL"]); }
						if (pRow.Table.Columns.Contains("GYDZL") && pRow["GYDZL"] != DBNull.Value) { obj.GYDZL = Convert.ToString(pRow["GYDZL"]); }
						if (pRow.Table.Columns.Contains("GYDQLRBSM") && pRow["GYDQLRBSM"] != DBNull.Value) { obj.GYDQLRBSM = Convert.ToInt64(pRow["GYDQLRBSM"]); }
						if (pRow.Table.Columns.Contains("GYDQLR") && pRow["GYDQLR"] != DBNull.Value) { obj.GYDQLR = Convert.ToString(pRow["GYDQLR"]); }
						if (pRow.Table.Columns.Contains("GYDQLRZJZL") && pRow["GYDQLRZJZL"] != DBNull.Value) { obj.GYDQLRZJZL = Convert.ToString(pRow["GYDQLRZJZL"]); }
						if (pRow.Table.Columns.Contains("GYDQLRZJH") && pRow["GYDQLRZJH"] != DBNull.Value) { obj.GYDQLRZJH = Convert.ToString(pRow["GYDQLRZJH"]); }
						if (pRow.Table.Columns.Contains("DJLX") && pRow["DJLX"] != DBNull.Value) { obj.DJLX = Convert.ToString(pRow["DJLX"]); }
						if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
						if (pRow.Table.Columns.Contains("DYQNR") && pRow["DYQNR"] != DBNull.Value) { obj.DYQNR = Convert.ToString(pRow["DYQNR"]); }
						if (pRow.Table.Columns.Contains("DJZMH") && pRow["DJZMH"] != DBNull.Value) { obj.DJZMH = Convert.ToString(pRow["DJZMH"]); }
						if (pRow.Table.Columns.Contains("DJZMBSM") && pRow["DJZMBSM"] != DBNull.Value) { obj.DJZMBSM = Convert.ToInt64(pRow["DJZMBSM"]); }
						if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
						if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
						if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
						if (pRow.Table.Columns.Contains("QLLX") && pRow["QLLX"] != DBNull.Value) { obj.QLLX = Convert.ToString(pRow["QLLX"]); }
						if (pRow.Table.Columns.Contains("QLQSSJ") && pRow["QLQSSJ"] != DBNull.Value) { obj.QLQSSJ = Convert.ToDateTime(pRow["QLQSSJ"]); }
						if (pRow.Table.Columns.Contains("QLJSSJ") && pRow["QLJSSJ"] != DBNull.Value) { obj.QLJSSJ = Convert.ToDateTime(pRow["QLJSSJ"]); }
						if (pRow.Table.Columns.Contains("ZXYWH") && pRow["ZXYWH"] != DBNull.Value) { obj.ZXYWH = Convert.ToString(pRow["ZXYWH"]); }
						if (pRow.Table.Columns.Contains("ZXYY") && pRow["ZXYY"] != DBNull.Value) { obj.ZXYY = Convert.ToString(pRow["ZXYY"]); }
						if (pRow.Table.Columns.Contains("ZXSJ") && pRow["ZXSJ"] != DBNull.Value) { obj.ZXSJ = Convert.ToDateTime(pRow["ZXSJ"]); }
						if (pRow.Table.Columns.Contains("ZXDBR") && pRow["ZXDBR"] != DBNull.Value) { obj.ZXDBR = Convert.ToString(pRow["ZXDBR"]); }
						if (pRow.Table.Columns.Contains("ZXFJ") && pRow["ZXFJ"] != DBNull.Value) { obj.ZXFJ = Convert.ToString(pRow["ZXFJ"]); }
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
						if (pRow.Table.Columns.Contains("SHBSM") && pRow["SHBSM"] != DBNull.Value) { obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]); }
						if (pRow.Table.Columns.Contains("ZXSHBSM") && pRow["ZXSHBSM"] != DBNull.Value) { obj.ZXSHBSM = Convert.ToInt64(pRow["ZXSHBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("DJJG") && pRow["DJJG"] != DBNull.Value) { obj.DJJG = Convert.ToString(pRow["DJJG"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("LYMD") && pRow["LYMD"] != DBNull.Value) { obj.LYMD = Convert.ToString(pRow["LYMD"]); }
						if (pRow.Table.Columns.Contains("LYFF") && pRow["LYFF"] != DBNull.Value) { obj.LYFF = Convert.ToString(pRow["LYFF"]); }
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
