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

	public class Fld_CFDJ
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string CFJG="CFJG";
		public const string CFWH="CFWH";
		public const string CFQSSJ="CFQSSJ";
		public const string CFJSSJ="CFJSSJ";
		public const string CFFW="CFFW";
		public const string CFYYF="CFYYF";
		public const string DBR="DBR";
		public const string DJSJ="DJSJ";
		public const string FJ="FJ";
		public const string QSZT="QSZT";
		public const string SHBSM="SHBSM";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string QXDM="QXDM";
		public const string BZ_CFREASON="BZ_CFREASON";
		public const string BZ_TDESC="BZ_TDESC";
		public const string BZ_CF_COUSE="BZ_CF_COUSE";
		public const string BZ_CF_ACTOR="BZ_CF_ACTOR";
		public const string BZ_CF_WH="BZ_CF_WH";
		public const string BZ_QZ_STATE="BZ_QZ_STATE";
		public const string BZ_CF_TYPE="BZ_CF_TYPE";
		public const string REV_="REV_";
		public const string DJJG="DJJG";
		public const string DJYY="DJYY";
		public const string BZ_CF_ID="BZ_CF_ID";
		public const string BZ_CF_MJ="BZ_CF_MJ";
		public const string BZ_CF_JE="BZ_CF_JE";
		public const string BZ_YCF_ZL="BZ_YCF_ZL";
		public const string BZ_SW_RQ="BZ_SW_RQ";
		public const string BZ_LW_LXR="BZ_LW_LXR";
		public const string BZ_LW_LXDH="BZ_LW_LXDH";
		public const string BZ_BZ="BZ_BZ";
		public const string BZ_YCFQLR_ID="BZ_YCFQLR_ID";
		public const string BZ_CF_NF="BZ_CF_NF";
		public const string BZ_CF_XH="BZ_CF_XH";
		public const string BZ_CF_BM="BZ_CF_BM";
		public const string BZ_JF_NF="BZ_JF_NF";
		public const string BZ_JF_XH="BZ_JF_XH";
		public const string BZ_JF_BM="BZ_JF_BM";
		public const string BZ_YCF_PROJECTID="BZ_YCF_PROJECTID";
		public const string BZ_YCF_ZDID="BZ_YCF_ZDID";
		public const string BZ_YCF_BZBH="BZ_YCF_BZBH";
		public const string BZ_YCF_JFPROJECTID="BZ_YCF_JFPROJECTID";
		public const string BZ_ZDQLR_ID="BZ_ZDQLR_ID";
		public const string BZ_CF_ZT="BZ_CF_ZT";
		public const string YCFZL="YCFZL";
		public const string CFWJ="CFWJ";
		public const string CFLX="CFLX";
		public const string BZ_CFWJ="BZ_CFWJ";
		public const string BZ_TYPH="BZ_TYPH";
		public const string BZ_TYPHZX="BZ_TYPHZX";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string BZ_YWH="BZ_YWH";
		public const string OINSID="OINSID";
		public const string BZ_YWSLID="BZ_YWSLID";
		public const string BZ_MJ="BZ_MJ";
		public const string BZ_ZDDM="BZ_ZDDM";
		public const string BZ_SEIZURE_SUBSCRIPT="BZ_SEIZURE_SUBSCRIPT";
		public const string BZ_REOPENED_PEOPLE="BZ_REOPENED_PEOPLE";
		public const string BZ_REOPENED_TIME="BZ_REOPENED_TIME";
		public const string BZ_LAND_RIGHT_SOURCE="BZ_LAND_RIGHT_SOURCE";
		public const string BZ_BLDW="BZ_BLDW";
		public const string BZ_编号="BZ_编号";
		public const string BZ_ID="BZ_ID";
		#endregion
	}

	public class clsCFDJ:IEntity
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
		private string m_CFJG;
		private string m_CFWH;
		private DateTime m_CFQSSJ;
		private DateTime m_CFJSSJ;
		private string m_CFFW;
		private string m_CFYYF;
		private string m_DBR;
		private DateTime m_DJSJ;
		private string m_FJ;
		private string m_QSZT;
		private long m_SHBSM;
		private string m_YXTBM;
		private string m_YXTBSM;
		private long m_QXDM;
		private long m_REV_;
		private string m_DJJG;
		private string m_DJYY;

		private string m_YCFZL;
		private string m_CFWJ;
		private long m_CFLX;
	
		private DateTime m_GXSJ;
		private string m_BZ;
	

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
		public string CFJG
		{
			get{ return m_CFJG; }
			set{ m_CFJG = value; }
		}
		public string CFWH
		{
			get{ return m_CFWH; }
			set{ m_CFWH = value; }
		}
		public DateTime CFQSSJ
		{
			get{ return m_CFQSSJ; }
			set{ m_CFQSSJ = value; }
		}
		public DateTime CFJSSJ
		{
			get{ return m_CFJSSJ; }
			set{ m_CFJSSJ = value; }
		}
		public string CFFW
		{
			get{ return m_CFFW; }
			set{ m_CFFW = value; }
		}
		public string CFYYF
		{
			get{ return m_CFYYF; }
			set{ m_CFYYF = value; }
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
		public string DJJG
		{
			get{ return m_DJJG; }
			set{ m_DJJG = value; }
		}
		public string DJYY
		{
			get{ return m_DJYY; }
			set{ m_DJYY = value; }
		}
		
		
		
		
		
		
		
		
		
		
		
		public string YCFZL
		{
			get{ return m_YCFZL; }
			set{ m_YCFZL = value; }
		}
		public string CFWJ
		{
			get{ return m_CFWJ; }
			set{ m_CFWJ = value; }
		}
		public long CFLX
		{
			get{ return m_CFLX; }
			set{ m_CFLX = value; }
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
		

		#endregion
		public bool IsEquals(clsCFDJ obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.CFJG != obj.CFJG) bolResult = false;
			if (this.CFWH != obj.CFWH) bolResult = false;
			if (this.CFQSSJ != obj.CFQSSJ) bolResult = false;
			if (this.CFJSSJ != obj.CFJSSJ) bolResult = false;
			if (this.CFFW != obj.CFFW) bolResult = false;
			if (this.CFYYF != obj.CFYYF) bolResult = false;
			if (this.DBR != obj.DBR) bolResult = false;
			if (this.DJSJ != obj.DJSJ) bolResult = false;
			if (this.FJ != obj.FJ) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.SHBSM != obj.SHBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.DJJG != obj.DJJG) bolResult = false;
			if (this.DJYY != obj.DJYY) bolResult = false;
			
			if (this.YCFZL != obj.YCFZL) bolResult = false;
			if (this.CFWJ != obj.CFWJ) bolResult = false;
			if (this.CFLX != obj.CFLX) bolResult = false;
			
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			
			return bolResult;
		}

		public void Colne(clsCFDJ obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.CFJG=obj.CFJG;
			this.CFWH=obj.CFWH;
			this.CFQSSJ=obj.CFQSSJ;
			this.CFJSSJ=obj.CFJSSJ;
			this.CFFW=obj.CFFW;
			this.CFYYF=obj.CFYYF;
			this.DBR=obj.DBR;
			this.DJSJ=obj.DJSJ;
			this.FJ=obj.FJ;
			this.QSZT=obj.QSZT;
			this.SHBSM=obj.SHBSM;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.DJJG=obj.DJJG;
			this.DJYY=obj.DJYY;
			this.YCFZL=obj.YCFZL;
			this.CFWJ=obj.CFWJ;
			this.CFLX=obj.CFLX;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
		}

	}

	public class clsCFDJSet:EntityBaseSet
	{
		public clsCFDJSet()
		{
			m_TableName="BDCDJ.CFDJ";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsCFDJSet";
		}
		public static clsCFDJSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsCFDJSet clsSet = new clsCFDJSet(); //(clsCFDJSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsCFDJSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsCFDJ obj = (clsCFDJ)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("CFJG")) datarow["CFJG"] = obj.CFJG;
				if(datarow.Table.Columns.Contains("CFWH")) datarow["CFWH"] = obj.CFWH;
				if (obj.CFQSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("CFQSSJ")) datarow["CFQSSJ"] = obj.CFQSSJ;
				}
				if (obj.CFJSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("CFJSSJ")) datarow["CFJSSJ"] = obj.CFJSSJ;
				}
				if(datarow.Table.Columns.Contains("CFFW")) datarow["CFFW"] = obj.CFFW;
				if(datarow.Table.Columns.Contains("CFYYF")) datarow["CFYYF"] = obj.CFYYF;
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
				if(datarow.Table.Columns.Contains("DJJG")) datarow["DJJG"] = obj.DJJG;
				if(datarow.Table.Columns.Contains("DJYY")) datarow["DJYY"] = obj.DJYY;
				if(datarow.Table.Columns.Contains("YCFZL")) datarow["YCFZL"] = obj.YCFZL;
				if(datarow.Table.Columns.Contains("CFWJ")) datarow["CFWJ"] = obj.CFWJ;
				if(datarow.Table.Columns.Contains("CFLX")) datarow["CFLX"] = obj.CFLX;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
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
			clsCFDJ obj = null;
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
					obj = new clsCFDJ();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="CFJG")
								if (pRow.Table.Columns.Contains("CFJG") && pRow["CFJG"] != DBNull.Value) { obj.CFJG = Convert.ToString(pRow["CFJG"]); }
							if(strFldName.ToUpper()=="CFWH")
								if (pRow.Table.Columns.Contains("CFWH") && pRow["CFWH"] != DBNull.Value) { obj.CFWH = Convert.ToString(pRow["CFWH"]); }
							if(strFldName.ToUpper()=="CFQSSJ")
								if (pRow.Table.Columns.Contains("CFQSSJ") && pRow["CFQSSJ"] != DBNull.Value) { obj.CFQSSJ = Convert.ToDateTime(pRow["CFQSSJ"]); }
							if(strFldName.ToUpper()=="CFJSSJ")
								if (pRow.Table.Columns.Contains("CFJSSJ") && pRow["CFJSSJ"] != DBNull.Value) { obj.CFJSSJ = Convert.ToDateTime(pRow["CFJSSJ"]); }
							if(strFldName.ToUpper()=="CFFW")
								if (pRow.Table.Columns.Contains("CFFW") && pRow["CFFW"] != DBNull.Value) { obj.CFFW = Convert.ToString(pRow["CFFW"]); }
							if(strFldName.ToUpper()=="CFYYF")
								if (pRow.Table.Columns.Contains("CFYYF") && pRow["CFYYF"] != DBNull.Value) { obj.CFYYF = Convert.ToString(pRow["CFYYF"]); }
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
							if(strFldName.ToUpper()=="DJJG")
								if (pRow.Table.Columns.Contains("DJJG") && pRow["DJJG"] != DBNull.Value) { obj.DJJG = Convert.ToString(pRow["DJJG"]); }
							if(strFldName.ToUpper()=="DJYY")
								if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
							
							if(strFldName.ToUpper()=="YCFZL")
								if (pRow.Table.Columns.Contains("YCFZL") && pRow["YCFZL"] != DBNull.Value) { obj.YCFZL = Convert.ToString(pRow["YCFZL"]); }
							if(strFldName.ToUpper()=="CFWJ")
								if (pRow.Table.Columns.Contains("CFWJ") && pRow["CFWJ"] != DBNull.Value) { obj.CFWJ = Convert.ToString(pRow["CFWJ"]); }
							if(strFldName.ToUpper()=="CFLX")
								if (pRow.Table.Columns.Contains("CFLX") && pRow["CFLX"] != DBNull.Value) { obj.CFLX = Convert.ToInt64(pRow["CFLX"]); }
							
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("CFJG") && pRow["CFJG"] != DBNull.Value) { obj.CFJG = Convert.ToString(pRow["CFJG"]); }
						if (pRow.Table.Columns.Contains("CFWH") && pRow["CFWH"] != DBNull.Value) { obj.CFWH = Convert.ToString(pRow["CFWH"]); }
						if (pRow.Table.Columns.Contains("CFQSSJ") && pRow["CFQSSJ"] != DBNull.Value) { obj.CFQSSJ = Convert.ToDateTime(pRow["CFQSSJ"]); }
						if (pRow.Table.Columns.Contains("CFJSSJ") && pRow["CFJSSJ"] != DBNull.Value) { obj.CFJSSJ = Convert.ToDateTime(pRow["CFJSSJ"]); }
						if (pRow.Table.Columns.Contains("CFFW") && pRow["CFFW"] != DBNull.Value) { obj.CFFW = Convert.ToString(pRow["CFFW"]); }
						if (pRow.Table.Columns.Contains("CFYYF") && pRow["CFYYF"] != DBNull.Value) { obj.CFYYF = Convert.ToString(pRow["CFYYF"]); }
						if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
						if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
						if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
						if (pRow.Table.Columns.Contains("SHBSM") && pRow["SHBSM"] != DBNull.Value) { obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("DJJG") && pRow["DJJG"] != DBNull.Value) { obj.DJJG = Convert.ToString(pRow["DJJG"]); }
						if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
						
						if (pRow.Table.Columns.Contains("YCFZL") && pRow["YCFZL"] != DBNull.Value) { obj.YCFZL = Convert.ToString(pRow["YCFZL"]); }
						if (pRow.Table.Columns.Contains("CFWJ") && pRow["CFWJ"] != DBNull.Value) { obj.CFWJ = Convert.ToString(pRow["CFWJ"]); }
						if (pRow.Table.Columns.Contains("CFLX") && pRow["CFLX"] != DBNull.Value) { obj.CFLX = Convert.ToInt64(pRow["CFLX"]); }
						
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
					
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
