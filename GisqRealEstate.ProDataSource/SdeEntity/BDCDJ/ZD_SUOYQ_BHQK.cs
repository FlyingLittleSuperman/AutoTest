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

	public class Fld_ZDSUOYQ_BHQK
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string DYBSM="DYBSM";
		public const string ZDDM="ZDDM";
		public const string BHYY="BHYY";
		public const string BHNR="BHNR";
		public const string DJSJ="DJSJ";
		public const string DBR="DBR";
		public const string FJ="FJ";
		public const string REV_="REV_";
		public const string QXDM="QXDM";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		#endregion
	}

	public class clsZDSUOYQ_BHQK:IEntity
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
		private long m_DYBSM;
		private string m_ZDDM;
		private string m_BHYY;
		private string m_BHNR;
		private DateTime m_DJSJ;
		private string m_DBR;
		private string m_FJ;
		private long m_REV_;
		private long m_QXDM;
		private DateTime m_GXSJ;
		private string m_BZ;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public long DYBSM
		{
			get{ return m_DYBSM; }
			set{ m_DYBSM = value; }
		}
		public string ZDDM
		{
			get{ return m_ZDDM; }
			set{ m_ZDDM = value; }
		}
		public string BHYY
		{
			get{ return m_BHYY; }
			set{ m_BHYY = value; }
		}
		public string BHNR
		{
			get{ return m_BHNR; }
			set{ m_BHNR = value; }
		}
		public DateTime DJSJ
		{
			get{ return m_DJSJ; }
			set{ m_DJSJ = value; }
		}
		public string DBR
		{
			get{ return m_DBR; }
			set{ m_DBR = value; }
		}
		public string FJ
		{
			get{ return m_FJ; }
			set{ m_FJ = value; }
		}
		public long REV_
		{
			get{ return m_REV_; }
			set{ m_REV_ = value; }
		}
		public long QXDM
		{
			get{ return m_QXDM; }
			set{ m_QXDM = value; }
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
		public bool IsEquals(clsZDSUOYQ_BHQK obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.DYBSM != obj.DYBSM) bolResult = false;
			if (this.ZDDM != obj.ZDDM) bolResult = false;
			if (this.BHYY != obj.BHYY) bolResult = false;
			if (this.BHNR != obj.BHNR) bolResult = false;
			if (this.DJSJ != obj.DJSJ) bolResult = false;
			if (this.DBR != obj.DBR) bolResult = false;
			if (this.FJ != obj.FJ) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsZDSUOYQ_BHQK obj)
		{
			this.BSM=obj.BSM;
			this.DYBSM=obj.DYBSM;
			this.ZDDM=obj.ZDDM;
			this.BHYY=obj.BHYY;
			this.BHNR=obj.BHNR;
			this.DJSJ=obj.DJSJ;
			this.DBR=obj.DBR;
			this.FJ=obj.FJ;
			this.REV_=obj.REV_;
			this.QXDM=obj.QXDM;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
		}

	}

	public class clsZDSUOYQ_BHQKSet:EntityBaseSet
	{
		public clsZDSUOYQ_BHQKSet()
		{
			m_TableName="BDCDJ.ZD_SUOYQ_BHQK";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsZDSUOYQ_BHQKSet";
		}
		public static clsZDSUOYQ_BHQKSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsZDSUOYQ_BHQKSet clsSet = new clsZDSUOYQ_BHQKSet(); //(clsZDSUOYQ_BHQKSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsZDSUOYQ_BHQKSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsZDSUOYQ_BHQK obj = (clsZDSUOYQ_BHQK)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("DYBSM")) datarow["DYBSM"] = obj.DYBSM;
				if(datarow.Table.Columns.Contains("ZDDM")) datarow["ZDDM"] = obj.ZDDM;
				if(datarow.Table.Columns.Contains("BHYY")) datarow["BHYY"] = obj.BHYY;
				if(datarow.Table.Columns.Contains("BHNR")) datarow["BHNR"] = obj.BHNR;
				if (obj.DJSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("DJSJ")) datarow["DJSJ"] = obj.DJSJ;
				}
				if(datarow.Table.Columns.Contains("DBR")) datarow["DBR"] = obj.DBR;
				if(datarow.Table.Columns.Contains("FJ")) datarow["FJ"] = obj.FJ;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
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
			clsZDSUOYQ_BHQK obj = null;
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
					obj = new clsZDSUOYQ_BHQK();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="DYBSM")
								if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
							if(strFldName.ToUpper()=="ZDDM")
								if (pRow.Table.Columns.Contains("ZDDM") && pRow["ZDDM"] != DBNull.Value) { obj.ZDDM = Convert.ToString(pRow["ZDDM"]); }
							if(strFldName.ToUpper()=="BHYY")
								if (pRow.Table.Columns.Contains("BHYY") && pRow["BHYY"] != DBNull.Value) { obj.BHYY = Convert.ToString(pRow["BHYY"]); }
							if(strFldName.ToUpper()=="BHNR")
								if (pRow.Table.Columns.Contains("BHNR") && pRow["BHNR"] != DBNull.Value) { obj.BHNR = Convert.ToString(pRow["BHNR"]); }
							if(strFldName.ToUpper()=="DJSJ")
								if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
							if(strFldName.ToUpper()=="DBR")
								if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
							if(strFldName.ToUpper()=="FJ")
								if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
						if (pRow.Table.Columns.Contains("ZDDM") && pRow["ZDDM"] != DBNull.Value) { obj.ZDDM = Convert.ToString(pRow["ZDDM"]); }
						if (pRow.Table.Columns.Contains("BHYY") && pRow["BHYY"] != DBNull.Value) { obj.BHYY = Convert.ToString(pRow["BHYY"]); }
						if (pRow.Table.Columns.Contains("BHNR") && pRow["BHNR"] != DBNull.Value) { obj.BHNR = Convert.ToString(pRow["BHNR"]); }
						if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
						if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
						if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
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
