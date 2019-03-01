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

	public class Fld_BDCDYZ
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string ZDZHBSM="ZDZHBSM";
		public const string ZDZHBM="ZDZHBM";
		public const string DCZDZHBSM="DCZDZHBSM";
		public const string DCZDZHBM="DCZDZHBM";
		public const string ZDZHDM="ZDZHDM";
		public const string ZBSM="ZBSM";
		public const string DCZBSM="DCZBSM";
		public const string ZBM="ZBM";
		public const string ZDYH="ZDYH";
		public const string ZSXH="ZSXH";
		public const string QXDM="QXDM";
		public const string GXSJ="GXSJ";
		public const string REV_="REV_";
		public const string DCSCZBSM="DCSCZBSM";
		public const string BZ="BZ";
		public const string YXTBM="YXTBM";
		#endregion
	}

	public class clsBDCDYZ:IEntity
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
		private long m_ZDZHBSM;
		private string m_ZDZHBM;
		private long m_DCZDZHBSM;
		private string m_DCZDZHBM;
		private string m_ZDZHDM;
		private long m_ZBSM;
		private long m_DCZBSM;
		private string m_ZBM;
		private string m_ZDYH;
		private long m_ZSXH;
		private long m_QXDM;
		private DateTime m_GXSJ;
		private long m_REV_;
		private long m_DCSCZBSM;
		private string m_BZ;
		private string m_YXTBM;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public long ZDZHBSM
		{
			get{ return m_ZDZHBSM; }
			set{ m_ZDZHBSM = value; }
		}
		public string ZDZHBM
		{
			get{ return m_ZDZHBM; }
			set{ m_ZDZHBM = value; }
		}
		public long DCZDZHBSM
		{
			get{ return m_DCZDZHBSM; }
			set{ m_DCZDZHBSM = value; }
		}
		public string DCZDZHBM
		{
			get{ return m_DCZDZHBM; }
			set{ m_DCZDZHBM = value; }
		}
		public string ZDZHDM
		{
			get{ return m_ZDZHDM; }
			set{ m_ZDZHDM = value; }
		}
		public long ZBSM
		{
			get{ return m_ZBSM; }
			set{ m_ZBSM = value; }
		}
		public long DCZBSM
		{
			get{ return m_DCZBSM; }
			set{ m_DCZBSM = value; }
		}
		public string ZBM
		{
			get{ return m_ZBM; }
			set{ m_ZBM = value; }
		}
		public string ZDYH
		{
			get{ return m_ZDYH; }
			set{ m_ZDYH = value; }
		}
		public long ZSXH
		{
			get{ return m_ZSXH; }
			set{ m_ZSXH = value; }
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
		public long REV_
		{
			get{ return m_REV_; }
			set{ m_REV_ = value; }
		}
		public long DCSCZBSM
		{
			get{ return m_DCSCZBSM; }
			set{ m_DCSCZBSM = value; }
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
		public bool IsEquals(clsBDCDYZ obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.ZDZHBSM != obj.ZDZHBSM) bolResult = false;
			if (this.ZDZHBM != obj.ZDZHBM) bolResult = false;
			if (this.DCZDZHBSM != obj.DCZDZHBSM) bolResult = false;
			if (this.DCZDZHBM != obj.DCZDZHBM) bolResult = false;
			if (this.ZDZHDM != obj.ZDZHDM) bolResult = false;
			if (this.ZBSM != obj.ZBSM) bolResult = false;
			if (this.DCZBSM != obj.DCZBSM) bolResult = false;
			if (this.ZBM != obj.ZBM) bolResult = false;
			if (this.ZDYH != obj.ZDYH) bolResult = false;
			if (this.ZSXH != obj.ZSXH) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.DCSCZBSM != obj.DCSCZBSM) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			return bolResult;
		}

		public void Colne(clsBDCDYZ obj)
		{
			this.BSM=obj.BSM;
			this.ZDZHBSM=obj.ZDZHBSM;
			this.ZDZHBM=obj.ZDZHBM;
			this.DCZDZHBSM=obj.DCZDZHBSM;
			this.DCZDZHBM=obj.DCZDZHBM;
			this.ZDZHDM=obj.ZDZHDM;
			this.ZBSM=obj.ZBSM;
			this.DCZBSM=obj.DCZBSM;
			this.ZBM=obj.ZBM;
			this.ZDYH=obj.ZDYH;
			this.ZSXH=obj.ZSXH;
			this.QXDM=obj.QXDM;
			this.GXSJ=obj.GXSJ;
			this.REV_=obj.REV_;
			this.DCSCZBSM=obj.DCSCZBSM;
			this.BZ=obj.BZ;
			this.YXTBM=obj.YXTBM;
		}

	}

	public class clsBDCDYZSet:EntityBaseSet
	{
		public clsBDCDYZSet()
		{
			m_TableName="BDCDJ.BDCDYZ";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsBDCDYZSet";
		}
		public static clsBDCDYZSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsBDCDYZSet clsSet = new clsBDCDYZSet(); //(clsBDCDYZSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsBDCDYZSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsBDCDYZ obj = (clsBDCDYZ)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("ZDZHBSM")) datarow["ZDZHBSM"] = obj.ZDZHBSM;
				if(datarow.Table.Columns.Contains("ZDZHBM")) datarow["ZDZHBM"] = obj.ZDZHBM;
				if(datarow.Table.Columns.Contains("DCZDZHBSM")) datarow["DCZDZHBSM"] = obj.DCZDZHBSM;
				if(datarow.Table.Columns.Contains("DCZDZHBM")) datarow["DCZDZHBM"] = obj.DCZDZHBM;
				if(datarow.Table.Columns.Contains("ZDZHDM")) datarow["ZDZHDM"] = obj.ZDZHDM;
				if(datarow.Table.Columns.Contains("ZBSM")) datarow["ZBSM"] = obj.ZBSM;
				if(datarow.Table.Columns.Contains("DCZBSM")) datarow["DCZBSM"] = obj.DCZBSM;
				if(datarow.Table.Columns.Contains("ZBM")) datarow["ZBM"] = obj.ZBM;
				if(datarow.Table.Columns.Contains("ZDYH")) datarow["ZDYH"] = obj.ZDYH;
				if(datarow.Table.Columns.Contains("ZSXH")) datarow["ZSXH"] = obj.ZSXH;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("DCSCZBSM")) datarow["DCSCZBSM"] = obj.DCSCZBSM;
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
			clsBDCDYZ obj = null;
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
					obj = new clsBDCDYZ();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="ZDZHBSM")
								if (pRow.Table.Columns.Contains("ZDZHBSM") && pRow["ZDZHBSM"] != DBNull.Value) { obj.ZDZHBSM = Convert.ToInt64(pRow["ZDZHBSM"]); }
							if(strFldName.ToUpper()=="ZDZHBM")
								if (pRow.Table.Columns.Contains("ZDZHBM") && pRow["ZDZHBM"] != DBNull.Value) { obj.ZDZHBM = Convert.ToString(pRow["ZDZHBM"]); }
							if(strFldName.ToUpper()=="DCZDZHBSM")
								if (pRow.Table.Columns.Contains("DCZDZHBSM") && pRow["DCZDZHBSM"] != DBNull.Value) { obj.DCZDZHBSM = Convert.ToInt64(pRow["DCZDZHBSM"]); }
							if(strFldName.ToUpper()=="DCZDZHBM")
								if (pRow.Table.Columns.Contains("DCZDZHBM") && pRow["DCZDZHBM"] != DBNull.Value) { obj.DCZDZHBM = Convert.ToString(pRow["DCZDZHBM"]); }
							if(strFldName.ToUpper()=="ZDZHDM")
								if (pRow.Table.Columns.Contains("ZDZHDM") && pRow["ZDZHDM"] != DBNull.Value) { obj.ZDZHDM = Convert.ToString(pRow["ZDZHDM"]); }
							if(strFldName.ToUpper()=="ZBSM")
								if (pRow.Table.Columns.Contains("ZBSM") && pRow["ZBSM"] != DBNull.Value) { obj.ZBSM = Convert.ToInt64(pRow["ZBSM"]); }
							if(strFldName.ToUpper()=="DCZBSM")
								if (pRow.Table.Columns.Contains("DCZBSM") && pRow["DCZBSM"] != DBNull.Value) { obj.DCZBSM = Convert.ToInt64(pRow["DCZBSM"]); }
							if(strFldName.ToUpper()=="ZBM")
								if (pRow.Table.Columns.Contains("ZBM") && pRow["ZBM"] != DBNull.Value) { obj.ZBM = Convert.ToString(pRow["ZBM"]); }
							if(strFldName.ToUpper()=="ZDYH")
								if (pRow.Table.Columns.Contains("ZDYH") && pRow["ZDYH"] != DBNull.Value) { obj.ZDYH = Convert.ToString(pRow["ZDYH"]); }
							if(strFldName.ToUpper()=="ZSXH")
								if (pRow.Table.Columns.Contains("ZSXH") && pRow["ZSXH"] != DBNull.Value) { obj.ZSXH = Convert.ToInt64(pRow["ZSXH"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="DCSCZBSM")
								if (pRow.Table.Columns.Contains("DCSCZBSM") && pRow["DCSCZBSM"] != DBNull.Value) { obj.DCSCZBSM = Convert.ToInt64(pRow["DCSCZBSM"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("ZDZHBSM") && pRow["ZDZHBSM"] != DBNull.Value) { obj.ZDZHBSM = Convert.ToInt64(pRow["ZDZHBSM"]); }
						if (pRow.Table.Columns.Contains("ZDZHBM") && pRow["ZDZHBM"] != DBNull.Value) { obj.ZDZHBM = Convert.ToString(pRow["ZDZHBM"]); }
						if (pRow.Table.Columns.Contains("DCZDZHBSM") && pRow["DCZDZHBSM"] != DBNull.Value) { obj.DCZDZHBSM = Convert.ToInt64(pRow["DCZDZHBSM"]); }
						if (pRow.Table.Columns.Contains("DCZDZHBM") && pRow["DCZDZHBM"] != DBNull.Value) { obj.DCZDZHBM = Convert.ToString(pRow["DCZDZHBM"]); }
						if (pRow.Table.Columns.Contains("ZDZHDM") && pRow["ZDZHDM"] != DBNull.Value) { obj.ZDZHDM = Convert.ToString(pRow["ZDZHDM"]); }
						if (pRow.Table.Columns.Contains("ZBSM") && pRow["ZBSM"] != DBNull.Value) { obj.ZBSM = Convert.ToInt64(pRow["ZBSM"]); }
						if (pRow.Table.Columns.Contains("DCZBSM") && pRow["DCZBSM"] != DBNull.Value) { obj.DCZBSM = Convert.ToInt64(pRow["DCZBSM"]); }
						if (pRow.Table.Columns.Contains("ZBM") && pRow["ZBM"] != DBNull.Value) { obj.ZBM = Convert.ToString(pRow["ZBM"]); }
						if (pRow.Table.Columns.Contains("ZDYH") && pRow["ZDYH"] != DBNull.Value) { obj.ZDYH = Convert.ToString(pRow["ZDYH"]); }
						if (pRow.Table.Columns.Contains("ZSXH") && pRow["ZSXH"] != DBNull.Value) { obj.ZSXH = Convert.ToInt64(pRow["ZSXH"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("DCSCZBSM") && pRow["DCSCZBSM"] != DBNull.Value) { obj.DCSCZBSM = Convert.ToInt64(pRow["DCSCZBSM"]); }
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
