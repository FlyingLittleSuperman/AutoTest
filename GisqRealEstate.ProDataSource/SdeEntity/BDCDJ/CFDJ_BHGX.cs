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

	public class Fld_CFDJBHGX
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string YCFDJBSM="YCFDJBSM";
		public const string CFDJBSM="CFDJBSM";
		public const string QXDM="QXDM";
		public const string BZ_NEWCF_NM="BZ_NEWCF_NM";
		public const string BZ_OLDCF_NM="BZ_OLDCF_NM";
		public const string REV_="REV_";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string YXTBM="YXTBM";
		#endregion
	}

	public class clsCFDJBHGX:IEntity
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
		private long m_YCFDJBSM;
		private long m_CFDJBSM;
		private long m_QXDM;
		private long m_BZ_NEWCF_NM;
		private long m_BZ_OLDCF_NM;
		private long m_REV_;
		private DateTime m_GXSJ;
		private string m_BZ;
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
		public long YCFDJBSM
		{
			get{ return m_YCFDJBSM; }
			set{ m_YCFDJBSM = value; }
		}
		public long CFDJBSM
		{
			get{ return m_CFDJBSM; }
			set{ m_CFDJBSM = value; }
		}
		public long QXDM
		{
			get{ return m_QXDM; }
			set{ m_QXDM = value; }
		}
		public long BZ_NEWCF_NM
		{
			get{ return m_BZ_NEWCF_NM; }
			set{ m_BZ_NEWCF_NM = value; }
		}
		public long BZ_OLDCF_NM
		{
			get{ return m_BZ_OLDCF_NM; }
			set{ m_BZ_OLDCF_NM = value; }
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
		public string YXTBM
		{
			get{ return m_YXTBM; }
			set{ m_YXTBM = value; }
		}

		#endregion
		public bool IsEquals(clsCFDJBHGX obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.YCFDJBSM != obj.YCFDJBSM) bolResult = false;
			if (this.CFDJBSM != obj.CFDJBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.BZ_NEWCF_NM != obj.BZ_NEWCF_NM) bolResult = false;
			if (this.BZ_OLDCF_NM != obj.BZ_OLDCF_NM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			return bolResult;
		}

		public void Colne(clsCFDJBHGX obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.YCFDJBSM=obj.YCFDJBSM;
			this.CFDJBSM=obj.CFDJBSM;
			this.QXDM=obj.QXDM;
			this.BZ_NEWCF_NM=obj.BZ_NEWCF_NM;
			this.BZ_OLDCF_NM=obj.BZ_OLDCF_NM;
			this.REV_=obj.REV_;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.YXTBM=obj.YXTBM;
		}

	}

	public class clsCFDJBHGXSet:EntityBaseSet
	{
		public clsCFDJBHGXSet()
		{
			m_TableName="BDCDJ.CFDJ_BHGX";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsCFDJBHGXSet";
		}
		public static clsCFDJBHGXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsCFDJBHGXSet clsSet = new clsCFDJBHGXSet(); //(clsCFDJBHGXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsCFDJBHGXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsCFDJBHGX obj = (clsCFDJBHGX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("YCFDJBSM")) datarow["YCFDJBSM"] = obj.YCFDJBSM;
				if(datarow.Table.Columns.Contains("CFDJBSM")) datarow["CFDJBSM"] = obj.CFDJBSM;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("BZ_NEWCF_NM")) datarow["BZ_NEWCF_NM"] = obj.BZ_NEWCF_NM;
				if(datarow.Table.Columns.Contains("BZ_OLDCF_NM")) datarow["BZ_OLDCF_NM"] = obj.BZ_OLDCF_NM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
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
			clsCFDJBHGX obj = null;
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
					obj = new clsCFDJBHGX();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="YCFDJBSM")
								if (pRow.Table.Columns.Contains("YCFDJBSM") && pRow["YCFDJBSM"] != DBNull.Value) { obj.YCFDJBSM = Convert.ToInt64(pRow["YCFDJBSM"]); }
							if(strFldName.ToUpper()=="CFDJBSM")
								if (pRow.Table.Columns.Contains("CFDJBSM") && pRow["CFDJBSM"] != DBNull.Value) { obj.CFDJBSM = Convert.ToInt64(pRow["CFDJBSM"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="BZ_NEWCF_NM")
								if (pRow.Table.Columns.Contains("BZ_NEWCF_NM") && pRow["BZ_NEWCF_NM"] != DBNull.Value) { obj.BZ_NEWCF_NM = Convert.ToInt64(pRow["BZ_NEWCF_NM"]); }
							if(strFldName.ToUpper()=="BZ_OLDCF_NM")
								if (pRow.Table.Columns.Contains("BZ_OLDCF_NM") && pRow["BZ_OLDCF_NM"] != DBNull.Value) { obj.BZ_OLDCF_NM = Convert.ToInt64(pRow["BZ_OLDCF_NM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("YCFDJBSM") && pRow["YCFDJBSM"] != DBNull.Value) { obj.YCFDJBSM = Convert.ToInt64(pRow["YCFDJBSM"]); }
						if (pRow.Table.Columns.Contains("CFDJBSM") && pRow["CFDJBSM"] != DBNull.Value) { obj.CFDJBSM = Convert.ToInt64(pRow["CFDJBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("BZ_NEWCF_NM") && pRow["BZ_NEWCF_NM"] != DBNull.Value) { obj.BZ_NEWCF_NM = Convert.ToInt64(pRow["BZ_NEWCF_NM"]); }
						if (pRow.Table.Columns.Contains("BZ_OLDCF_NM") && pRow["BZ_OLDCF_NM"] != DBNull.Value) { obj.BZ_OLDCF_NM = Convert.ToInt64(pRow["BZ_OLDCF_NM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
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
