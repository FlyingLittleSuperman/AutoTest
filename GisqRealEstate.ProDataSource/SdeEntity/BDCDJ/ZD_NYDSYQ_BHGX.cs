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

	public class Fld_ZDNYDSYQ_BHGX
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string YDYBSM="YDYBSM";
		public const string XDYBSM="XDYBSM";
		public const string BHSJ="BHSJ";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		#endregion
	}

	public class clsZDNYDSYQ_BHGX:IEntity
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
		private long m_YDYBSM;
		private long m_XDYBSM;
		private DateTime m_BHSJ;
		private long m_QXDM;
		private long m_REV_;
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
		public long YDYBSM
		{
			get{ return m_YDYBSM; }
			set{ m_YDYBSM = value; }
		}
		public long XDYBSM
		{
			get{ return m_XDYBSM; }
			set{ m_XDYBSM = value; }
		}
		public DateTime BHSJ
		{
			get{ return m_BHSJ; }
			set{ m_BHSJ = value; }
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

		#endregion
		public bool IsEquals(clsZDNYDSYQ_BHGX obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.YDYBSM != obj.YDYBSM) bolResult = false;
			if (this.XDYBSM != obj.XDYBSM) bolResult = false;
			if (this.BHSJ != obj.BHSJ) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsZDNYDSYQ_BHGX obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.YDYBSM=obj.YDYBSM;
			this.XDYBSM=obj.XDYBSM;
			this.BHSJ=obj.BHSJ;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
		}

	}

	public class clsZDNYDSYQ_BHGXSet:EntityBaseSet
	{
		public clsZDNYDSYQ_BHGXSet()
		{
			m_TableName="BDCDJ.ZD_NYDSYQ_BHGX";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsZDNYDSYQ_BHGXSet";
		}
		public static clsZDNYDSYQ_BHGXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsZDNYDSYQ_BHGXSet clsSet = new clsZDNYDSYQ_BHGXSet(); //(clsZDNYDSYQ_BHGXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsZDNYDSYQ_BHGXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsZDNYDSYQ_BHGX obj = (clsZDNYDSYQ_BHGX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("YDYBSM")) datarow["YDYBSM"] = obj.YDYBSM;
				if(datarow.Table.Columns.Contains("XDYBSM")) datarow["XDYBSM"] = obj.XDYBSM;
				if (obj.BHSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("BHSJ")) datarow["BHSJ"] = obj.BHSJ;
				}
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
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
			clsZDNYDSYQ_BHGX obj = null;
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
					obj = new clsZDNYDSYQ_BHGX();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="YDYBSM")
								if (pRow.Table.Columns.Contains("YDYBSM") && pRow["YDYBSM"] != DBNull.Value) { obj.YDYBSM = Convert.ToInt64(pRow["YDYBSM"]); }
							if(strFldName.ToUpper()=="XDYBSM")
								if (pRow.Table.Columns.Contains("XDYBSM") && pRow["XDYBSM"] != DBNull.Value) { obj.XDYBSM = Convert.ToInt64(pRow["XDYBSM"]); }
							if(strFldName.ToUpper()=="BHSJ")
								if (pRow.Table.Columns.Contains("BHSJ") && pRow["BHSJ"] != DBNull.Value) { obj.BHSJ = Convert.ToDateTime(pRow["BHSJ"]); }
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
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("YDYBSM") && pRow["YDYBSM"] != DBNull.Value) { obj.YDYBSM = Convert.ToInt64(pRow["YDYBSM"]); }
						if (pRow.Table.Columns.Contains("XDYBSM") && pRow["XDYBSM"] != DBNull.Value) { obj.XDYBSM = Convert.ToInt64(pRow["XDYBSM"]); }
						if (pRow.Table.Columns.Contains("BHSJ") && pRow["BHSJ"] != DBNull.Value) { obj.BHSJ = Convert.ToDateTime(pRow["BHSJ"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
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
