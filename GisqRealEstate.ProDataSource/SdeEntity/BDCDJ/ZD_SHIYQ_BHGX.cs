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

	public class Fld_ZDSHIYQ_BHGX
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
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string BZ_BG_BB="BZ_BG_BB";
		public const string BZ_BG_BB_X="BZ_BG_BB_X";
		public const string BZ_FLAG="BZ_FLAG";
		public const string BZ_LZD_ID="BZ_LZD_ID";
		public const string BZ_XZD_ID="BZ_XZD_ID";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string BZ_ZDDM="BZ_ZDDM";
		public const string BZ_YZDBH="BZ_YZDBH";
		public const string BZ_DJH="BZ_DJH";
		public const string BZ_F_ZDBSM="BZ_F_ZDBSM";
		public const string BZ_Z_ZDBSM="BZ_Z_ZDBSM";
		#endregion
	}

	public class clsZDSHIYQ_BHGX:IEntity
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
		private string m_YXTBM;
		private string m_YXTBSM;
		private DateTime m_GXSJ;

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
		
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		

		#endregion
		public bool IsEquals(clsZDSHIYQ_BHGX obj)
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
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;

			return bolResult;
		}

		public void Colne(clsZDSHIYQ_BHGX obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.YDYBSM=obj.YDYBSM;
			this.XDYBSM=obj.XDYBSM;
			this.BHSJ=obj.BHSJ;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.GXSJ=obj.GXSJ;
		}

	}

	public class clsZDSHIYQ_BHGXSet:EntityBaseSet
	{
		public clsZDSHIYQ_BHGXSet()
		{
			m_TableName="BDCDJ.ZD_SHIYQ_BHGX";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsZDSHIYQ_BHGXSet";
		}
		public static clsZDSHIYQ_BHGXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsZDSHIYQ_BHGXSet clsSet = new clsZDSHIYQ_BHGXSet(); //(clsZDSHIYQ_BHGXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsZDSHIYQ_BHGXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsZDSHIYQ_BHGX obj = (clsZDSHIYQ_BHGX)entity;
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
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
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
			clsZDSHIYQ_BHGX obj = null;
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
					obj = new clsZDSHIYQ_BHGX();  
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
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
							
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						
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
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
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
