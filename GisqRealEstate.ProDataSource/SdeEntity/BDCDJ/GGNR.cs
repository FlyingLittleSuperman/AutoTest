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

	public class Fld_GGNR
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string GGFBBSM="GGFBBSM";
		public const string GGLX="GGLX";
		public const string QLBSM="QLBSM";
		public const string QLBM="QLBM";
		public const string QLR="QLR";
		public const string ZL="ZL";
		public const string QLLX="QLLX";
		public const string QLXZ="QLXZ";
		public const string YT="YT";
		public const string MJ="MJ";
		public const string TJRQ="TJRQ";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string BZ_GG_BZ="BZ_GG_BZ";
		public const string BZ_DEP_ID="BZ_DEP_ID";
		public const string BZ_ISFOROUTSIDE="BZ_ISFOROUTSIDE";
		public const string BZ_ZDQLR_ID="BZ_ZDQLR_ID";
		public const string BZ_DJGG_ID="BZ_DJGG_ID";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		#endregion
	}

	public class clsGGNR:IEntity
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
		private long m_GGFBBSM;
		private int m_GGLX;
		private long m_QLBSM;
		private string m_QLBM;
		private string m_QLR;
		private string m_ZL;
		private string m_QLLX;
		private string m_QLXZ;
		private string m_YT;
		private string m_MJ;
		private DateTime m_TJRQ;
		private long m_QXDM;
		private long m_REV_;
		private string m_YXTBM;
		private string m_YXTBSM;
		private string m_BZ_GG_BZ;
		private string m_BZ_DEP_ID;
		private string m_BZ_ISFOROUTSIDE;
		private long m_BZ_ZDQLR_ID;
		private long m_BZ_DJGG_ID;
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
		public long GGFBBSM
		{
			get{ return m_GGFBBSM; }
			set{ m_GGFBBSM = value; }
		}
		public int GGLX
		{
			get{ return m_GGLX; }
			set{ m_GGLX = value; }
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
		public string QLR
		{
			get{ return m_QLR; }
			set{ m_QLR = value; }
		}
		public string ZL
		{
			get{ return m_ZL; }
			set{ m_ZL = value; }
		}
		public string QLLX
		{
			get{ return m_QLLX; }
			set{ m_QLLX = value; }
		}
		public string QLXZ
		{
			get{ return m_QLXZ; }
			set{ m_QLXZ = value; }
		}
		public string YT
		{
			get{ return m_YT; }
			set{ m_YT = value; }
		}
		public string MJ
		{
			get{ return m_MJ; }
			set{ m_MJ = value; }
		}
		public DateTime TJRQ
		{
			get{ return m_TJRQ; }
			set{ m_TJRQ = value; }
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
		public string BZ_GG_BZ
		{
			get{ return m_BZ_GG_BZ; }
			set{ m_BZ_GG_BZ = value; }
		}
		public string BZ_DEP_ID
		{
			get{ return m_BZ_DEP_ID; }
			set{ m_BZ_DEP_ID = value; }
		}
		public string BZ_ISFOROUTSIDE
		{
			get{ return m_BZ_ISFOROUTSIDE; }
			set{ m_BZ_ISFOROUTSIDE = value; }
		}
		public long BZ_ZDQLR_ID
		{
			get{ return m_BZ_ZDQLR_ID; }
			set{ m_BZ_ZDQLR_ID = value; }
		}
		public long BZ_DJGG_ID
		{
			get{ return m_BZ_DJGG_ID; }
			set{ m_BZ_DJGG_ID = value; }
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
		public bool IsEquals(clsGGNR obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.GGFBBSM != obj.GGFBBSM) bolResult = false;
			if (this.GGLX != obj.GGLX) bolResult = false;
			if (this.QLBSM != obj.QLBSM) bolResult = false;
			if (this.QLBM != obj.QLBM) bolResult = false;
			if (this.QLR != obj.QLR) bolResult = false;
			if (this.ZL != obj.ZL) bolResult = false;
			if (this.QLLX != obj.QLLX) bolResult = false;
			if (this.QLXZ != obj.QLXZ) bolResult = false;
			if (this.YT != obj.YT) bolResult = false;
			if (this.MJ != obj.MJ) bolResult = false;
			if (this.TJRQ != obj.TJRQ) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.BZ_GG_BZ != obj.BZ_GG_BZ) bolResult = false;
			if (this.BZ_DEP_ID != obj.BZ_DEP_ID) bolResult = false;
			if (this.BZ_ISFOROUTSIDE != obj.BZ_ISFOROUTSIDE) bolResult = false;
			if (this.BZ_ZDQLR_ID != obj.BZ_ZDQLR_ID) bolResult = false;
			if (this.BZ_DJGG_ID != obj.BZ_DJGG_ID) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsGGNR obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.GGFBBSM=obj.GGFBBSM;
			this.GGLX=obj.GGLX;
			this.QLBSM=obj.QLBSM;
			this.QLBM=obj.QLBM;
			this.QLR=obj.QLR;
			this.ZL=obj.ZL;
			this.QLLX=obj.QLLX;
			this.QLXZ=obj.QLXZ;
			this.YT=obj.YT;
			this.MJ=obj.MJ;
			this.TJRQ=obj.TJRQ;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.BZ_GG_BZ=obj.BZ_GG_BZ;
			this.BZ_DEP_ID=obj.BZ_DEP_ID;
			this.BZ_ISFOROUTSIDE=obj.BZ_ISFOROUTSIDE;
			this.BZ_ZDQLR_ID=obj.BZ_ZDQLR_ID;
			this.BZ_DJGG_ID=obj.BZ_DJGG_ID;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
		}

	}

	public class clsGGNRSet:EntityBaseSet
	{
		public clsGGNRSet()
		{
			m_TableName="BDCDJ.GGNR";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsGGNRSet";
		}
		public static clsGGNRSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsGGNRSet clsSet = new clsGGNRSet(); //(clsGGNRSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsGGNRSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsGGNR obj = (clsGGNR)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("GGFBBSM")) datarow["GGFBBSM"] = obj.GGFBBSM;
				if(datarow.Table.Columns.Contains("GGLX")) datarow["GGLX"] = obj.GGLX;
				if(datarow.Table.Columns.Contains("QLBSM")) datarow["QLBSM"] = obj.QLBSM;
				if(datarow.Table.Columns.Contains("QLBM")) datarow["QLBM"] = obj.QLBM;
				if(datarow.Table.Columns.Contains("QLR")) datarow["QLR"] = obj.QLR;
				if(datarow.Table.Columns.Contains("ZL")) datarow["ZL"] = obj.ZL;
				if(datarow.Table.Columns.Contains("QLLX")) datarow["QLLX"] = obj.QLLX;
				if(datarow.Table.Columns.Contains("QLXZ")) datarow["QLXZ"] = obj.QLXZ;
				if(datarow.Table.Columns.Contains("YT")) datarow["YT"] = obj.YT;
				if(datarow.Table.Columns.Contains("MJ")) datarow["MJ"] = obj.MJ;
				if (obj.TJRQ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("TJRQ")) datarow["TJRQ"] = obj.TJRQ;
				}
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("BZ_GG_BZ")) datarow["BZ_GG_BZ"] = obj.BZ_GG_BZ;
				if(datarow.Table.Columns.Contains("BZ_DEP_ID")) datarow["BZ_DEP_ID"] = obj.BZ_DEP_ID;
				if(datarow.Table.Columns.Contains("BZ_ISFOROUTSIDE")) datarow["BZ_ISFOROUTSIDE"] = obj.BZ_ISFOROUTSIDE;
				if(datarow.Table.Columns.Contains("BZ_ZDQLR_ID")) datarow["BZ_ZDQLR_ID"] = obj.BZ_ZDQLR_ID;
				if(datarow.Table.Columns.Contains("BZ_DJGG_ID")) datarow["BZ_DJGG_ID"] = obj.BZ_DJGG_ID;
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
			clsGGNR obj = null;
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
					obj = new clsGGNR();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="GGFBBSM")
								if (pRow.Table.Columns.Contains("GGFBBSM") && pRow["GGFBBSM"] != DBNull.Value) { obj.GGFBBSM = Convert.ToInt64(pRow["GGFBBSM"]); }
							if(strFldName.ToUpper()=="GGLX")
								if (pRow.Table.Columns.Contains("GGLX") && pRow["GGLX"] != DBNull.Value) { obj.GGLX = Convert.ToInt16(pRow["GGLX"]); }
							if(strFldName.ToUpper()=="QLBSM")
								if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
							if(strFldName.ToUpper()=="QLBM")
								if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
							if(strFldName.ToUpper()=="QLR")
								if (pRow.Table.Columns.Contains("QLR") && pRow["QLR"] != DBNull.Value) { obj.QLR = Convert.ToString(pRow["QLR"]); }
							if(strFldName.ToUpper()=="ZL")
								if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
							if(strFldName.ToUpper()=="QLLX")
								if (pRow.Table.Columns.Contains("QLLX") && pRow["QLLX"] != DBNull.Value) { obj.QLLX = Convert.ToString(pRow["QLLX"]); }
							if(strFldName.ToUpper()=="QLXZ")
								if (pRow.Table.Columns.Contains("QLXZ") && pRow["QLXZ"] != DBNull.Value) { obj.QLXZ = Convert.ToString(pRow["QLXZ"]); }
							if(strFldName.ToUpper()=="YT")
								if (pRow.Table.Columns.Contains("YT") && pRow["YT"] != DBNull.Value) { obj.YT = Convert.ToString(pRow["YT"]); }
							if(strFldName.ToUpper()=="MJ")
								if (pRow.Table.Columns.Contains("MJ") && pRow["MJ"] != DBNull.Value) { obj.MJ = Convert.ToString(pRow["MJ"]); }
							if(strFldName.ToUpper()=="TJRQ")
								if (pRow.Table.Columns.Contains("TJRQ") && pRow["TJRQ"] != DBNull.Value) { obj.TJRQ = Convert.ToDateTime(pRow["TJRQ"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
							if(strFldName.ToUpper()=="BZ_GG_BZ")
								if (pRow.Table.Columns.Contains("BZ_GG_BZ") && pRow["BZ_GG_BZ"] != DBNull.Value) { obj.BZ_GG_BZ = Convert.ToString(pRow["BZ_GG_BZ"]); }
							if(strFldName.ToUpper()=="BZ_DEP_ID")
								if (pRow.Table.Columns.Contains("BZ_DEP_ID") && pRow["BZ_DEP_ID"] != DBNull.Value) { obj.BZ_DEP_ID = Convert.ToString(pRow["BZ_DEP_ID"]); }
							if(strFldName.ToUpper()=="BZ_ISFOROUTSIDE")
								if (pRow.Table.Columns.Contains("BZ_ISFOROUTSIDE") && pRow["BZ_ISFOROUTSIDE"] != DBNull.Value) { obj.BZ_ISFOROUTSIDE = Convert.ToString(pRow["BZ_ISFOROUTSIDE"]); }
							if(strFldName.ToUpper()=="BZ_ZDQLR_ID")
								if (pRow.Table.Columns.Contains("BZ_ZDQLR_ID") && pRow["BZ_ZDQLR_ID"] != DBNull.Value) { obj.BZ_ZDQLR_ID = Convert.ToInt64(pRow["BZ_ZDQLR_ID"]); }
							if(strFldName.ToUpper()=="BZ_DJGG_ID")
								if (pRow.Table.Columns.Contains("BZ_DJGG_ID") && pRow["BZ_DJGG_ID"] != DBNull.Value) { obj.BZ_DJGG_ID = Convert.ToInt64(pRow["BZ_DJGG_ID"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("GGFBBSM") && pRow["GGFBBSM"] != DBNull.Value) { obj.GGFBBSM = Convert.ToInt64(pRow["GGFBBSM"]); }
						if (pRow.Table.Columns.Contains("GGLX") && pRow["GGLX"] != DBNull.Value) { obj.GGLX = Convert.ToInt16(pRow["GGLX"]); }
						if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
						if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
						if (pRow.Table.Columns.Contains("QLR") && pRow["QLR"] != DBNull.Value) { obj.QLR = Convert.ToString(pRow["QLR"]); }
						if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
						if (pRow.Table.Columns.Contains("QLLX") && pRow["QLLX"] != DBNull.Value) { obj.QLLX = Convert.ToString(pRow["QLLX"]); }
						if (pRow.Table.Columns.Contains("QLXZ") && pRow["QLXZ"] != DBNull.Value) { obj.QLXZ = Convert.ToString(pRow["QLXZ"]); }
						if (pRow.Table.Columns.Contains("YT") && pRow["YT"] != DBNull.Value) { obj.YT = Convert.ToString(pRow["YT"]); }
						if (pRow.Table.Columns.Contains("MJ") && pRow["MJ"] != DBNull.Value) { obj.MJ = Convert.ToString(pRow["MJ"]); }
						if (pRow.Table.Columns.Contains("TJRQ") && pRow["TJRQ"] != DBNull.Value) { obj.TJRQ = Convert.ToDateTime(pRow["TJRQ"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("BZ_GG_BZ") && pRow["BZ_GG_BZ"] != DBNull.Value) { obj.BZ_GG_BZ = Convert.ToString(pRow["BZ_GG_BZ"]); }
						if (pRow.Table.Columns.Contains("BZ_DEP_ID") && pRow["BZ_DEP_ID"] != DBNull.Value) { obj.BZ_DEP_ID = Convert.ToString(pRow["BZ_DEP_ID"]); }
						if (pRow.Table.Columns.Contains("BZ_ISFOROUTSIDE") && pRow["BZ_ISFOROUTSIDE"] != DBNull.Value) { obj.BZ_ISFOROUTSIDE = Convert.ToString(pRow["BZ_ISFOROUTSIDE"]); }
						if (pRow.Table.Columns.Contains("BZ_ZDQLR_ID") && pRow["BZ_ZDQLR_ID"] != DBNull.Value) { obj.BZ_ZDQLR_ID = Convert.ToInt64(pRow["BZ_ZDQLR_ID"]); }
						if (pRow.Table.Columns.Contains("BZ_DJGG_ID") && pRow["BZ_DJGG_ID"] != DBNull.Value) { obj.BZ_DJGG_ID = Convert.ToInt64(pRow["BZ_DJGG_ID"]); }
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
