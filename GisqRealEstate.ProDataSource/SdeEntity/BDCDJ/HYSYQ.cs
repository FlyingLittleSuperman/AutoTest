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

	public class Fld_HYSYQ
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YSDM="YSDM";
		public const string ZHHDDM="ZHHDDM";
		public const string BDCDYH="BDCDYH";
		public const string YWH="YWH";
		public const string QLLX="QLLX";
		public const string DJLX="DJLX";
		public const string DJYY="DJYY";
		public const string SYQMJ="SYQMJ";
		public const string SYQQSSJ="SYQQSSJ";
		public const string SYQJSSJ="SYQJSSJ";
		public const string SYJZE="SYJZE";
		public const string SYJBZYJ="SYJBZYJ";
		public const string SYJJNQK="SYJJNQK";
		public const string BDCQZH="BDCQZH";
		public const string DJJG="DJJG";
		public const string DBR="DBR";
		public const string DJSJ="DJSJ";
		public const string FJ="FJ";
		public const string QSZT="QSZT";
		public const string LYQLBH="LYQLBH";
		public const string HYMJDW="HYMJDW";
		public const string HYMJ="HYMJ";
		public const string ZXYWH="ZXYWH";
		public const string ZXSJ="ZXSJ";
		public const string ZXDBR="ZXDBR";
		public const string ZXYY="ZXYY";
		public const string ZXFJ="ZXFJ";
		public const string SHBSM="SHBSM";
		public const string ZXSHBSM="ZXSHBSM";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsHYSYQ:IEntity
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
		private string m_ZHHDDM;
		private string m_BDCDYH;
		private string m_YWH;
		private string m_QLLX;
		private string m_DJLX;
		private string m_DJYY;
		private double m_SYQMJ;
		private DateTime m_SYQQSSJ;
		private DateTime m_SYQJSSJ;
		private double m_SYJZE;
		private string m_SYJBZYJ;
		private string m_SYJJNQK;
		private string m_BDCQZH;
		private string m_DJJG;
		private string m_DBR;
		private DateTime m_DJSJ;
		private string m_FJ;
		private string m_QSZT;
		private string m_LYQLBH;
		private string m_HYMJDW;
		private double m_HYMJ;
		private string m_ZXYWH;
		private DateTime m_ZXSJ;
		private string m_ZXDBR;
		private string m_ZXYY;
		private string m_ZXFJ;
		private long m_SHBSM;
		private long m_ZXSHBSM;
		private string m_YXTBM;
		private string m_YXTBSM;
		private long m_QXDM;
		private long m_REV_;
		private DateTime m_GXSJ;
		private string m_BZ;
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
		public string ZHHDDM
		{
			get{ return m_ZHHDDM; }
			set{ m_ZHHDDM = value; }
		}
		public string BDCDYH
		{
			get{ return m_BDCDYH; }
			set{ m_BDCDYH = value; }
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
		public double SYJZE
		{
			get{ return m_SYJZE; }
			set{ m_SYJZE = value; }
		}
		public string SYJBZYJ
		{
			get{ return m_SYJBZYJ; }
			set{ m_SYJBZYJ = value; }
		}
		public string SYJJNQK
		{
			get{ return m_SYJJNQK; }
			set{ m_SYJJNQK = value; }
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
		public string LYQLBH
		{
			get{ return m_LYQLBH; }
			set{ m_LYQLBH = value; }
		}
		public string HYMJDW
		{
			get{ return m_HYMJDW; }
			set{ m_HYMJDW = value; }
		}
		public double HYMJ
		{
			get{ return m_HYMJ; }
			set{ m_HYMJ = value; }
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
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

		#endregion
		public bool IsEquals(clsHYSYQ obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YSDM != obj.YSDM) bolResult = false;
			if (this.ZHHDDM != obj.ZHHDDM) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.QLLX != obj.QLLX) bolResult = false;
			if (this.DJLX != obj.DJLX) bolResult = false;
			if (this.DJYY != obj.DJYY) bolResult = false;
			if (this.SYQMJ != obj.SYQMJ) bolResult = false;
			if (this.SYQQSSJ != obj.SYQQSSJ) bolResult = false;
			if (this.SYQJSSJ != obj.SYQJSSJ) bolResult = false;
			if (this.SYJZE != obj.SYJZE) bolResult = false;
			if (this.SYJBZYJ != obj.SYJBZYJ) bolResult = false;
			if (this.SYJJNQK != obj.SYJJNQK) bolResult = false;
			if (this.BDCQZH != obj.BDCQZH) bolResult = false;
			if (this.DJJG != obj.DJJG) bolResult = false;
			if (this.DBR != obj.DBR) bolResult = false;
			if (this.DJSJ != obj.DJSJ) bolResult = false;
			if (this.FJ != obj.FJ) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.LYQLBH != obj.LYQLBH) bolResult = false;
			if (this.HYMJDW != obj.HYMJDW) bolResult = false;
			if (this.HYMJ != obj.HYMJ) bolResult = false;
			if (this.ZXYWH != obj.ZXYWH) bolResult = false;
			if (this.ZXSJ != obj.ZXSJ) bolResult = false;
			if (this.ZXDBR != obj.ZXDBR) bolResult = false;
			if (this.ZXYY != obj.ZXYY) bolResult = false;
			if (this.ZXFJ != obj.ZXFJ) bolResult = false;
			if (this.SHBSM != obj.SHBSM) bolResult = false;
			if (this.ZXSHBSM != obj.ZXSHBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsHYSYQ obj)
		{
			this.BSM=obj.BSM;
			this.YSDM=obj.YSDM;
			this.ZHHDDM=obj.ZHHDDM;
			this.BDCDYH=obj.BDCDYH;
			this.YWH=obj.YWH;
			this.QLLX=obj.QLLX;
			this.DJLX=obj.DJLX;
			this.DJYY=obj.DJYY;
			this.SYQMJ=obj.SYQMJ;
			this.SYQQSSJ=obj.SYQQSSJ;
			this.SYQJSSJ=obj.SYQJSSJ;
			this.SYJZE=obj.SYJZE;
			this.SYJBZYJ=obj.SYJBZYJ;
			this.SYJJNQK=obj.SYJJNQK;
			this.BDCQZH=obj.BDCQZH;
			this.DJJG=obj.DJJG;
			this.DBR=obj.DBR;
			this.DJSJ=obj.DJSJ;
			this.FJ=obj.FJ;
			this.QSZT=obj.QSZT;
			this.LYQLBH=obj.LYQLBH;
			this.HYMJDW=obj.HYMJDW;
			this.HYMJ=obj.HYMJ;
			this.ZXYWH=obj.ZXYWH;
			this.ZXSJ=obj.ZXSJ;
			this.ZXDBR=obj.ZXDBR;
			this.ZXYY=obj.ZXYY;
			this.ZXFJ=obj.ZXFJ;
			this.SHBSM=obj.SHBSM;
			this.ZXSHBSM=obj.ZXSHBSM;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
		}

	}

	public class clsHYSYQSet:EntityBaseSet
	{
		public clsHYSYQSet()
		{
			m_TableName="BDCDJ.HYSYQ";
			m_HisTableName="BDCDJ.HYSYQ_LS";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsHYSYQSet";
		}
		public static clsHYSYQSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsHYSYQSet clsSet = new clsHYSYQSet(); //(clsHYSYQSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsHYSYQSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsHYSYQ obj = (clsHYSYQ)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YSDM")) datarow["YSDM"] = obj.YSDM;
				if(datarow.Table.Columns.Contains("ZHHDDM")) datarow["ZHHDDM"] = obj.ZHHDDM;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
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
				if(datarow.Table.Columns.Contains("SYJZE")) datarow["SYJZE"] = obj.SYJZE;
				if(datarow.Table.Columns.Contains("SYJBZYJ")) datarow["SYJBZYJ"] = obj.SYJBZYJ;
				if(datarow.Table.Columns.Contains("SYJJNQK")) datarow["SYJJNQK"] = obj.SYJJNQK;
				if(datarow.Table.Columns.Contains("BDCQZH")) datarow["BDCQZH"] = obj.BDCQZH;
				if(datarow.Table.Columns.Contains("DJJG")) datarow["DJJG"] = obj.DJJG;
				if(datarow.Table.Columns.Contains("DBR")) datarow["DBR"] = obj.DBR;
				if (obj.DJSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("DJSJ")) datarow["DJSJ"] = obj.DJSJ;
				}
				if(datarow.Table.Columns.Contains("FJ")) datarow["FJ"] = obj.FJ;
				if(datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
				if(datarow.Table.Columns.Contains("LYQLBH")) datarow["LYQLBH"] = obj.LYQLBH;
				if(datarow.Table.Columns.Contains("HYMJDW")) datarow["HYMJDW"] = obj.HYMJDW;
				if(datarow.Table.Columns.Contains("HYMJ")) datarow["HYMJ"] = obj.HYMJ;
				if(datarow.Table.Columns.Contains("ZXYWH")) datarow["ZXYWH"] = obj.ZXYWH;
				if (obj.ZXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("ZXSJ")) datarow["ZXSJ"] = obj.ZXSJ;
				}
				if(datarow.Table.Columns.Contains("ZXDBR")) datarow["ZXDBR"] = obj.ZXDBR;
				if(datarow.Table.Columns.Contains("ZXYY")) datarow["ZXYY"] = obj.ZXYY;
				if(datarow.Table.Columns.Contains("ZXFJ")) datarow["ZXFJ"] = obj.ZXFJ;
				if(datarow.Table.Columns.Contains("SHBSM")) datarow["SHBSM"] = obj.SHBSM;
				if(datarow.Table.Columns.Contains("ZXSHBSM")) datarow["ZXSHBSM"] = obj.ZXSHBSM;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
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
			clsHYSYQ obj = null;
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
					obj = new clsHYSYQ();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YSDM")
								if (pRow.Table.Columns.Contains("YSDM") && pRow["YSDM"] != DBNull.Value) { obj.YSDM = Convert.ToString(pRow["YSDM"]); }
							if(strFldName.ToUpper()=="ZHHDDM")
								if (pRow.Table.Columns.Contains("ZHHDDM") && pRow["ZHHDDM"] != DBNull.Value) { obj.ZHHDDM = Convert.ToString(pRow["ZHHDDM"]); }
							if(strFldName.ToUpper()=="BDCDYH")
								if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
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
							if(strFldName.ToUpper()=="SYJZE")
								if (pRow.Table.Columns.Contains("SYJZE") && pRow["SYJZE"] != DBNull.Value) { obj.SYJZE = Convert.ToDouble(pRow["SYJZE"]); }
							if(strFldName.ToUpper()=="SYJBZYJ")
								if (pRow.Table.Columns.Contains("SYJBZYJ") && pRow["SYJBZYJ"] != DBNull.Value) { obj.SYJBZYJ = Convert.ToString(pRow["SYJBZYJ"]); }
							if(strFldName.ToUpper()=="SYJJNQK")
								if (pRow.Table.Columns.Contains("SYJJNQK") && pRow["SYJJNQK"] != DBNull.Value) { obj.SYJJNQK = Convert.ToString(pRow["SYJJNQK"]); }
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
							if(strFldName.ToUpper()=="LYQLBH")
								if (pRow.Table.Columns.Contains("LYQLBH") && pRow["LYQLBH"] != DBNull.Value) { obj.LYQLBH = Convert.ToString(pRow["LYQLBH"]); }
							if(strFldName.ToUpper()=="HYMJDW")
								if (pRow.Table.Columns.Contains("HYMJDW") && pRow["HYMJDW"] != DBNull.Value) { obj.HYMJDW = Convert.ToString(pRow["HYMJDW"]); }
							if(strFldName.ToUpper()=="HYMJ")
								if (pRow.Table.Columns.Contains("HYMJ") && pRow["HYMJ"] != DBNull.Value) { obj.HYMJ = Convert.ToDouble(pRow["HYMJ"]); }
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
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YSDM") && pRow["YSDM"] != DBNull.Value) { obj.YSDM = Convert.ToString(pRow["YSDM"]); }
						if (pRow.Table.Columns.Contains("ZHHDDM") && pRow["ZHHDDM"] != DBNull.Value) { obj.ZHHDDM = Convert.ToString(pRow["ZHHDDM"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("QLLX") && pRow["QLLX"] != DBNull.Value) { obj.QLLX = Convert.ToString(pRow["QLLX"]); }
						if (pRow.Table.Columns.Contains("DJLX") && pRow["DJLX"] != DBNull.Value) { obj.DJLX = Convert.ToString(pRow["DJLX"]); }
						if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
						if (pRow.Table.Columns.Contains("SYQMJ") && pRow["SYQMJ"] != DBNull.Value) { obj.SYQMJ = Convert.ToDouble(pRow["SYQMJ"]); }
						if (pRow.Table.Columns.Contains("SYQQSSJ") && pRow["SYQQSSJ"] != DBNull.Value) { obj.SYQQSSJ = Convert.ToDateTime(pRow["SYQQSSJ"]); }
						if (pRow.Table.Columns.Contains("SYQJSSJ") && pRow["SYQJSSJ"] != DBNull.Value) { obj.SYQJSSJ = Convert.ToDateTime(pRow["SYQJSSJ"]); }
						if (pRow.Table.Columns.Contains("SYJZE") && pRow["SYJZE"] != DBNull.Value) { obj.SYJZE = Convert.ToDouble(pRow["SYJZE"]); }
						if (pRow.Table.Columns.Contains("SYJBZYJ") && pRow["SYJBZYJ"] != DBNull.Value) { obj.SYJBZYJ = Convert.ToString(pRow["SYJBZYJ"]); }
						if (pRow.Table.Columns.Contains("SYJJNQK") && pRow["SYJJNQK"] != DBNull.Value) { obj.SYJJNQK = Convert.ToString(pRow["SYJJNQK"]); }
						if (pRow.Table.Columns.Contains("BDCQZH") && pRow["BDCQZH"] != DBNull.Value) { obj.BDCQZH = Convert.ToString(pRow["BDCQZH"]); }
						if (pRow.Table.Columns.Contains("DJJG") && pRow["DJJG"] != DBNull.Value) { obj.DJJG = Convert.ToString(pRow["DJJG"]); }
						if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
						if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
						if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
						if (pRow.Table.Columns.Contains("LYQLBH") && pRow["LYQLBH"] != DBNull.Value) { obj.LYQLBH = Convert.ToString(pRow["LYQLBH"]); }
						if (pRow.Table.Columns.Contains("HYMJDW") && pRow["HYMJDW"] != DBNull.Value) { obj.HYMJDW = Convert.ToString(pRow["HYMJDW"]); }
						if (pRow.Table.Columns.Contains("HYMJ") && pRow["HYMJ"] != DBNull.Value) { obj.HYMJ = Convert.ToDouble(pRow["HYMJ"]); }
						if (pRow.Table.Columns.Contains("ZXYWH") && pRow["ZXYWH"] != DBNull.Value) { obj.ZXYWH = Convert.ToString(pRow["ZXYWH"]); }
						if (pRow.Table.Columns.Contains("ZXSJ") && pRow["ZXSJ"] != DBNull.Value) { obj.ZXSJ = Convert.ToDateTime(pRow["ZXSJ"]); }
						if (pRow.Table.Columns.Contains("ZXDBR") && pRow["ZXDBR"] != DBNull.Value) { obj.ZXDBR = Convert.ToString(pRow["ZXDBR"]); }
						if (pRow.Table.Columns.Contains("ZXYY") && pRow["ZXYY"] != DBNull.Value) { obj.ZXYY = Convert.ToString(pRow["ZXYY"]); }
						if (pRow.Table.Columns.Contains("ZXFJ") && pRow["ZXFJ"] != DBNull.Value) { obj.ZXFJ = Convert.ToString(pRow["ZXFJ"]); }
						if (pRow.Table.Columns.Contains("SHBSM") && pRow["SHBSM"] != DBNull.Value) { obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]); }
						if (pRow.Table.Columns.Contains("ZXSHBSM") && pRow["ZXSHBSM"] != DBNull.Value) { obj.ZXSHBSM = Convert.ToInt64(pRow["ZXSHBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
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
