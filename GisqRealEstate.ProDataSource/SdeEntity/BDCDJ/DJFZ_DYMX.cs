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

	public class Fld_DJFZDYMX
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string BDCDYH="BDCDYH";
		public const string QLBSM="QLBSM";
		public const string QLBM="QLBM";
		public const string DYBSM="DYBSM";
		public const string DYBM="DYBM";
		public const string BDCQZH="BDCQZH";
		public const string BDCDJZMH="BDCDJZMH";
		public const string ZL="ZL";
		public const string MJ="MJ";
		public const string YT="YT";
		public const string SZC="SZC";
		public const string ZCS="ZCS";
		public const string FWYT="FWYT";
		public const string JZMJ="JZMJ";
		public const string ZYJZMJ="ZYJZMJ";
		public const string FTJZMJ="FTJZMJ";
		public const string QXDM="QXDM";
		public const string FWXZ="FWXZ";
		public const string FWJG="FWJG";
		public const string QLXZ="QLXZ";
		public const string REV_="REV_";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string BZ_ZD_ID="BZ_ZD_ID";
		public const string YXTBM="YXTBM";
		public const string YBDCQZH="YBDCQZH";
		public const string FJ2="FJ2";
		#endregion
	}

	public class clsDJFZDYMX:IEntity
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
		private long m_QLBSM;
		private string m_QLBM;
		private long m_DYBSM;
		private string m_DYBM;
		private string m_BDCQZH;
		private string m_BDCDJZMH;
		private string m_ZL;
		private string m_MJ;
		private string m_YT;
		private string m_SZC;
		private long m_ZCS;
		private string m_FWYT;
		private double m_JZMJ;
		private double m_ZYJZMJ;
		private double m_FTJZMJ;
		private long m_QXDM;
		private string m_FWXZ;
		private string m_FWJG;
		private string m_QLXZ;
		private int m_REV_;
		private DateTime m_GXSJ;
		private string m_BZ;
		private string m_YXTBM;
		private string m_YBDCQZH;

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
		public long DYBSM
		{
			get{ return m_DYBSM; }
			set{ m_DYBSM = value; }
		}
		public string DYBM
		{
			get{ return m_DYBM; }
			set{ m_DYBM = value; }
		}
		public string BDCQZH
		{
			get{ return m_BDCQZH; }
			set{ m_BDCQZH = value; }
		}
		public string BDCDJZMH
		{
			get{ return m_BDCDJZMH; }
			set{ m_BDCDJZMH = value; }
		}
		public string ZL
		{
			get{ return m_ZL; }
			set{ m_ZL = value; }
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
		public string FWYT
		{
			get{ return m_FWYT; }
			set{ m_FWYT = value; }
		}
		public double JZMJ
		{
			get{ return m_JZMJ; }
			set{ m_JZMJ = value; }
		}
		public double ZYJZMJ
		{
			get{ return m_ZYJZMJ; }
			set{ m_ZYJZMJ = value; }
		}
		public double FTJZMJ
		{
			get{ return m_FTJZMJ; }
			set{ m_FTJZMJ = value; }
		}
		public long QXDM
		{
			get{ return m_QXDM; }
			set{ m_QXDM = value; }
		}
		public string FWXZ
		{
			get{ return m_FWXZ; }
			set{ m_FWXZ = value; }
		}
		public string FWJG
		{
			get{ return m_FWJG; }
			set{ m_FWJG = value; }
		}
		public string QLXZ
		{
			get{ return m_QLXZ; }
			set{ m_QLXZ = value; }
		}
		public int REV_
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
		public string YXTBM
		{
			get{ return m_YXTBM; }
			set{ m_YXTBM = value; }
		}
		public string YBDCQZH
		{
			get{ return m_YBDCQZH; }
			set{ m_YBDCQZH = value; }
		}

		#endregion
		public bool IsEquals(clsDJFZDYMX obj)
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
			if (this.QLBSM != obj.QLBSM) bolResult = false;
			if (this.QLBM != obj.QLBM) bolResult = false;
			if (this.DYBSM != obj.DYBSM) bolResult = false;
			if (this.DYBM != obj.DYBM) bolResult = false;
			if (this.BDCQZH != obj.BDCQZH) bolResult = false;
			if (this.BDCDJZMH != obj.BDCDJZMH) bolResult = false;
			if (this.ZL != obj.ZL) bolResult = false;
			if (this.MJ != obj.MJ) bolResult = false;
			if (this.YT != obj.YT) bolResult = false;
			if (this.SZC != obj.SZC) bolResult = false;
			if (this.ZCS != obj.ZCS) bolResult = false;
			if (this.FWYT != obj.FWYT) bolResult = false;
			if (this.JZMJ != obj.JZMJ) bolResult = false;
			if (this.ZYJZMJ != obj.ZYJZMJ) bolResult = false;
			if (this.FTJZMJ != obj.FTJZMJ) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.FWXZ != obj.FWXZ) bolResult = false;
			if (this.FWJG != obj.FWJG) bolResult = false;
			if (this.QLXZ != obj.QLXZ) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YBDCQZH != obj.YBDCQZH) bolResult = false;
			return bolResult;
		}

		public void Colne(clsDJFZDYMX obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.BDCDYH=obj.BDCDYH;
			this.QLBSM=obj.QLBSM;
			this.QLBM=obj.QLBM;
			this.DYBSM=obj.DYBSM;
			this.DYBM=obj.DYBM;
			this.BDCQZH=obj.BDCQZH;
			this.BDCDJZMH=obj.BDCDJZMH;
			this.ZL=obj.ZL;
			this.MJ=obj.MJ;
			this.YT=obj.YT;
			this.SZC=obj.SZC;
			this.ZCS=obj.ZCS;
			this.FWYT=obj.FWYT;
			this.JZMJ=obj.JZMJ;
			this.ZYJZMJ=obj.ZYJZMJ;
			this.FTJZMJ=obj.FTJZMJ;
			this.QXDM=obj.QXDM;
			this.FWXZ=obj.FWXZ;
			this.FWJG=obj.FWJG;
			this.QLXZ=obj.QLXZ;
			this.REV_=obj.REV_;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.YXTBM=obj.YXTBM;
			this.YBDCQZH=obj.YBDCQZH;
		}

	}

	public class clsDJFZDYMXSet:EntityBaseSet
	{
		public clsDJFZDYMXSet()
		{
			m_TableName="BDCDJ.DJFZ_DYMX";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsDJFZDYMXSet";
		}
		public static clsDJFZDYMXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsDJFZDYMXSet clsSet = new clsDJFZDYMXSet(); //(clsDJFZDYMXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsDJFZDYMXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsDJFZDYMX obj = (clsDJFZDYMX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("QLBSM")) datarow["QLBSM"] = obj.QLBSM;
				if(datarow.Table.Columns.Contains("QLBM")) datarow["QLBM"] = obj.QLBM;
				if(datarow.Table.Columns.Contains("DYBSM")) datarow["DYBSM"] = obj.DYBSM;
				if(datarow.Table.Columns.Contains("DYBM")) datarow["DYBM"] = obj.DYBM;
				if(datarow.Table.Columns.Contains("BDCQZH")) datarow["BDCQZH"] = obj.BDCQZH;
				if(datarow.Table.Columns.Contains("BDCDJZMH")) datarow["BDCDJZMH"] = obj.BDCDJZMH;
				if(datarow.Table.Columns.Contains("ZL")) datarow["ZL"] = obj.ZL;
				if(datarow.Table.Columns.Contains("MJ")) datarow["MJ"] = obj.MJ;
				if(datarow.Table.Columns.Contains("YT")) datarow["YT"] = obj.YT;
				if(datarow.Table.Columns.Contains("SZC")) datarow["SZC"] = obj.SZC;
				if(datarow.Table.Columns.Contains("ZCS")) datarow["ZCS"] = obj.ZCS;
				if(datarow.Table.Columns.Contains("FWYT")) datarow["FWYT"] = obj.FWYT;
				if(datarow.Table.Columns.Contains("JZMJ")) datarow["JZMJ"] = obj.JZMJ;
				if(datarow.Table.Columns.Contains("ZYJZMJ")) datarow["ZYJZMJ"] = obj.ZYJZMJ;
				if(datarow.Table.Columns.Contains("FTJZMJ")) datarow["FTJZMJ"] = obj.FTJZMJ;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("FWXZ")) datarow["FWXZ"] = obj.FWXZ;
				if(datarow.Table.Columns.Contains("FWJG")) datarow["FWJG"] = obj.FWJG;
				if(datarow.Table.Columns.Contains("QLXZ")) datarow["QLXZ"] = obj.QLXZ;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YBDCQZH")) datarow["YBDCQZH"] = obj.YBDCQZH;
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
			clsDJFZDYMX obj = null;
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
					obj = new clsDJFZDYMX();  
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
							if(strFldName.ToUpper()=="QLBSM")
								if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
							if(strFldName.ToUpper()=="QLBM")
								if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
							if(strFldName.ToUpper()=="DYBSM")
								if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
							if(strFldName.ToUpper()=="DYBM")
								if (pRow.Table.Columns.Contains("DYBM") && pRow["DYBM"] != DBNull.Value) { obj.DYBM = Convert.ToString(pRow["DYBM"]); }
							if(strFldName.ToUpper()=="BDCQZH")
								if (pRow.Table.Columns.Contains("BDCQZH") && pRow["BDCQZH"] != DBNull.Value) { obj.BDCQZH = Convert.ToString(pRow["BDCQZH"]); }
							if(strFldName.ToUpper()=="BDCDJZMH")
								if (pRow.Table.Columns.Contains("BDCDJZMH") && pRow["BDCDJZMH"] != DBNull.Value) { obj.BDCDJZMH = Convert.ToString(pRow["BDCDJZMH"]); }
							if(strFldName.ToUpper()=="ZL")
								if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
							if(strFldName.ToUpper()=="MJ")
								if (pRow.Table.Columns.Contains("MJ") && pRow["MJ"] != DBNull.Value) { obj.MJ = Convert.ToString(pRow["MJ"]); }
							if(strFldName.ToUpper()=="YT")
								if (pRow.Table.Columns.Contains("YT") && pRow["YT"] != DBNull.Value) { obj.YT = Convert.ToString(pRow["YT"]); }
							if(strFldName.ToUpper()=="SZC")
								if (pRow.Table.Columns.Contains("SZC") && pRow["SZC"] != DBNull.Value) { obj.SZC = Convert.ToString(pRow["SZC"]); }
							if(strFldName.ToUpper()=="ZCS")
								if (pRow.Table.Columns.Contains("ZCS") && pRow["ZCS"] != DBNull.Value) { obj.ZCS = Convert.ToInt64(pRow["ZCS"]); }
							if(strFldName.ToUpper()=="FWYT")
								if (pRow.Table.Columns.Contains("FWYT") && pRow["FWYT"] != DBNull.Value) { obj.FWYT = Convert.ToString(pRow["FWYT"]); }
							if(strFldName.ToUpper()=="JZMJ")
								if (pRow.Table.Columns.Contains("JZMJ") && pRow["JZMJ"] != DBNull.Value) { obj.JZMJ = Convert.ToDouble(pRow["JZMJ"]); }
							if(strFldName.ToUpper()=="ZYJZMJ")
								if (pRow.Table.Columns.Contains("ZYJZMJ") && pRow["ZYJZMJ"] != DBNull.Value) { obj.ZYJZMJ = Convert.ToDouble(pRow["ZYJZMJ"]); }
							if(strFldName.ToUpper()=="FTJZMJ")
								if (pRow.Table.Columns.Contains("FTJZMJ") && pRow["FTJZMJ"] != DBNull.Value) { obj.FTJZMJ = Convert.ToDouble(pRow["FTJZMJ"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="FWXZ")
								if (pRow.Table.Columns.Contains("FWXZ") && pRow["FWXZ"] != DBNull.Value) { obj.FWXZ = Convert.ToString(pRow["FWXZ"]); }
							if(strFldName.ToUpper()=="FWJG")
								if (pRow.Table.Columns.Contains("FWJG") && pRow["FWJG"] != DBNull.Value) { obj.FWJG = Convert.ToString(pRow["FWJG"]); }
							if(strFldName.ToUpper()=="QLXZ")
								if (pRow.Table.Columns.Contains("QLXZ") && pRow["QLXZ"] != DBNull.Value) { obj.QLXZ = Convert.ToString(pRow["QLXZ"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt16(pRow["REV_"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }

							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="YBDCQZH")
								if (pRow.Table.Columns.Contains("YBDCQZH") && pRow["YBDCQZH"] != DBNull.Value) { obj.YBDCQZH = Convert.ToString(pRow["YBDCQZH"]); }

						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
						if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
						if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
						if (pRow.Table.Columns.Contains("DYBM") && pRow["DYBM"] != DBNull.Value) { obj.DYBM = Convert.ToString(pRow["DYBM"]); }
						if (pRow.Table.Columns.Contains("BDCQZH") && pRow["BDCQZH"] != DBNull.Value) { obj.BDCQZH = Convert.ToString(pRow["BDCQZH"]); }
						if (pRow.Table.Columns.Contains("BDCDJZMH") && pRow["BDCDJZMH"] != DBNull.Value) { obj.BDCDJZMH = Convert.ToString(pRow["BDCDJZMH"]); }
						if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
						if (pRow.Table.Columns.Contains("MJ") && pRow["MJ"] != DBNull.Value) { obj.MJ = Convert.ToString(pRow["MJ"]); }
						if (pRow.Table.Columns.Contains("YT") && pRow["YT"] != DBNull.Value) { obj.YT = Convert.ToString(pRow["YT"]); }
						if (pRow.Table.Columns.Contains("SZC") && pRow["SZC"] != DBNull.Value) { obj.SZC = Convert.ToString(pRow["SZC"]); }
						if (pRow.Table.Columns.Contains("ZCS") && pRow["ZCS"] != DBNull.Value) { obj.ZCS = Convert.ToInt64(pRow["ZCS"]); }
						if (pRow.Table.Columns.Contains("FWYT") && pRow["FWYT"] != DBNull.Value) { obj.FWYT = Convert.ToString(pRow["FWYT"]); }
						if (pRow.Table.Columns.Contains("JZMJ") && pRow["JZMJ"] != DBNull.Value) { obj.JZMJ = Convert.ToDouble(pRow["JZMJ"]); }
						if (pRow.Table.Columns.Contains("ZYJZMJ") && pRow["ZYJZMJ"] != DBNull.Value) { obj.ZYJZMJ = Convert.ToDouble(pRow["ZYJZMJ"]); }
						if (pRow.Table.Columns.Contains("FTJZMJ") && pRow["FTJZMJ"] != DBNull.Value) { obj.FTJZMJ = Convert.ToDouble(pRow["FTJZMJ"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("FWXZ") && pRow["FWXZ"] != DBNull.Value) { obj.FWXZ = Convert.ToString(pRow["FWXZ"]); }
						if (pRow.Table.Columns.Contains("FWJG") && pRow["FWJG"] != DBNull.Value) { obj.FWJG = Convert.ToString(pRow["FWJG"]); }
						if (pRow.Table.Columns.Contains("QLXZ") && pRow["QLXZ"] != DBNull.Value) { obj.QLXZ = Convert.ToString(pRow["QLXZ"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt16(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YBDCQZH") && pRow["YBDCQZH"] != DBNull.Value) { obj.YBDCQZH = Convert.ToString(pRow["YBDCQZH"]); }
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
