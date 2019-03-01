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

	public class Fld_DATM
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string DABH="DABH";
		public const string QZH="QZH";
		public const string FLH="FLH";
		public const string MLH="MLH";
		public const string AJH="AJH";
		public const string AJZH="AJZH";
		public const string DALX="DALX";
		public const string DAWYBM="DAWYBM";
		public const string QXDM="QXDM";
		public const string BZ_YXTBSM="BZ_YXTBSM";
		public const string BZ_ZDQLR_ID="BZ_ZDQLR_ID";
		public const string BZ_YXTBM="BZ_YXTBM";
		public const string REV_="REV_";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string YXTBSM="YXTBSM";
		public const string YXTBM="YXTBM";
		public const string OINSID="OINSID";
		public const string BZ_QLID="BZ_QLID";
		public const string BZ_YWSLID="BZ_YWSLID";
		public const string BZ_QLRMC="BZ_QLRMC";
		public const string BZ_ZL="BZ_ZL";
		public const string BZ_YBDCQZH="BZ_YBDCQZH";
		#endregion
	}

	public class clsDATM:IEntity
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
		private string m_DABH;
		private string m_QZH;
		private string m_FLH;
		private string m_MLH;
		private string m_AJH;
		private string m_AJZH;
		private string m_DALX;
		private string m_DAWYBM;
		private long m_QXDM;
		private long m_REV_;
		private DateTime m_GXSJ;
		private string m_BZ;
		private string m_YXTBSM;
		private string m_YXTBM;

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
		public string DABH
		{
			get{ return m_DABH; }
			set{ m_DABH = value; }
		}
		public string QZH
		{
			get{ return m_QZH; }
			set{ m_QZH = value; }
		}
		public string FLH
		{
			get{ return m_FLH; }
			set{ m_FLH = value; }
		}
		public string MLH
		{
			get{ return m_MLH; }
			set{ m_MLH = value; }
		}
		public string AJH
		{
			get{ return m_AJH; }
			set{ m_AJH = value; }
		}
		public string AJZH
		{
			get{ return m_AJZH; }
			set{ m_AJZH = value; }
		}
		public string DALX
		{
			get{ return m_DALX; }
			set{ m_DALX = value; }
		}
		public string DAWYBM
		{
			get{ return m_DAWYBM; }
			set{ m_DAWYBM = value; }
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
	

		#endregion
		public bool IsEquals(clsDATM obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.DABH != obj.DABH) bolResult = false;
			if (this.QZH != obj.QZH) bolResult = false;
			if (this.FLH != obj.FLH) bolResult = false;
			if (this.MLH != obj.MLH) bolResult = false;
			if (this.AJH != obj.AJH) bolResult = false;
			if (this.AJZH != obj.AJZH) bolResult = false;
			if (this.DALX != obj.DALX) bolResult = false;
			if (this.DAWYBM != obj.DAWYBM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			return bolResult;
		}

		public void Colne(clsDATM obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.DABH=obj.DABH;
			this.QZH=obj.QZH;
			this.FLH=obj.FLH;
			this.MLH=obj.MLH;
			this.AJH=obj.AJH;
			this.AJZH=obj.AJZH;
			this.DALX=obj.DALX;
			this.DAWYBM=obj.DAWYBM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.YXTBSM=obj.YXTBSM;
			this.YXTBM=obj.YXTBM;
		}

	}

	public class clsDATMSet:EntityBaseSet
	{
		public clsDATMSet()
		{
			m_TableName="BDCDJ.DATM";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsDATMSet";
		}
		public static clsDATMSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsDATMSet clsSet = new clsDATMSet(); //(clsDATMSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsDATMSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsDATM obj = (clsDATM)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("DABH")) datarow["DABH"] = obj.DABH;
				if(datarow.Table.Columns.Contains("QZH")) datarow["QZH"] = obj.QZH;
				if(datarow.Table.Columns.Contains("FLH")) datarow["FLH"] = obj.FLH;
				if(datarow.Table.Columns.Contains("MLH")) datarow["MLH"] = obj.MLH;
				if(datarow.Table.Columns.Contains("AJH")) datarow["AJH"] = obj.AJH;
				if(datarow.Table.Columns.Contains("AJZH")) datarow["AJZH"] = obj.AJZH;
				if(datarow.Table.Columns.Contains("DALX")) datarow["DALX"] = obj.DALX;
				if(datarow.Table.Columns.Contains("DAWYBM")) datarow["DAWYBM"] = obj.DAWYBM;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
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
			clsDATM obj = null;
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
					obj = new clsDATM();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="DABH")
								if (pRow.Table.Columns.Contains("DABH") && pRow["DABH"] != DBNull.Value) { obj.DABH = Convert.ToString(pRow["DABH"]); }
							if(strFldName.ToUpper()=="QZH")
								if (pRow.Table.Columns.Contains("QZH") && pRow["QZH"] != DBNull.Value) { obj.QZH = Convert.ToString(pRow["QZH"]); }
							if(strFldName.ToUpper()=="FLH")
								if (pRow.Table.Columns.Contains("FLH") && pRow["FLH"] != DBNull.Value) { obj.FLH = Convert.ToString(pRow["FLH"]); }
							if(strFldName.ToUpper()=="MLH")
								if (pRow.Table.Columns.Contains("MLH") && pRow["MLH"] != DBNull.Value) { obj.MLH = Convert.ToString(pRow["MLH"]); }
							if(strFldName.ToUpper()=="AJH")
								if (pRow.Table.Columns.Contains("AJH") && pRow["AJH"] != DBNull.Value) { obj.AJH = Convert.ToString(pRow["AJH"]); }
							if(strFldName.ToUpper()=="AJZH")
								if (pRow.Table.Columns.Contains("AJZH") && pRow["AJZH"] != DBNull.Value) { obj.AJZH = Convert.ToString(pRow["AJZH"]); }
							if(strFldName.ToUpper()=="DALX")
								if (pRow.Table.Columns.Contains("DALX") && pRow["DALX"] != DBNull.Value) { obj.DALX = Convert.ToString(pRow["DALX"]); }
							if(strFldName.ToUpper()=="DAWYBM")
								if (pRow.Table.Columns.Contains("DAWYBM") && pRow["DAWYBM"] != DBNull.Value) { obj.DAWYBM = Convert.ToString(pRow["DAWYBM"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("DABH") && pRow["DABH"] != DBNull.Value) { obj.DABH = Convert.ToString(pRow["DABH"]); }
						if (pRow.Table.Columns.Contains("QZH") && pRow["QZH"] != DBNull.Value) { obj.QZH = Convert.ToString(pRow["QZH"]); }
						if (pRow.Table.Columns.Contains("FLH") && pRow["FLH"] != DBNull.Value) { obj.FLH = Convert.ToString(pRow["FLH"]); }
						if (pRow.Table.Columns.Contains("MLH") && pRow["MLH"] != DBNull.Value) { obj.MLH = Convert.ToString(pRow["MLH"]); }
						if (pRow.Table.Columns.Contains("AJH") && pRow["AJH"] != DBNull.Value) { obj.AJH = Convert.ToString(pRow["AJH"]); }
						if (pRow.Table.Columns.Contains("AJZH") && pRow["AJZH"] != DBNull.Value) { obj.AJZH = Convert.ToString(pRow["AJZH"]); }
						if (pRow.Table.Columns.Contains("DALX") && pRow["DALX"] != DBNull.Value) { obj.DALX = Convert.ToString(pRow["DALX"]); }
						if (pRow.Table.Columns.Contains("DAWYBM") && pRow["DAWYBM"] != DBNull.Value) { obj.DAWYBM = Convert.ToString(pRow["DAWYBM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
					
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						
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
