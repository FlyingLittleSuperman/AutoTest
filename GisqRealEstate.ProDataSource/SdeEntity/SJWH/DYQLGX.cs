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

	public class Fld_DYQLGX
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string RWBH="RWBH";
		public const string DYBM="DYBM";
		public const string DYBSM="DYBSM";
		public const string QLBM="QLBM";
		public const string QLBSM="QLBSM";
		public const string TXQLBM="TXQLBM";
		public const string TXQLBSM="TXQLBSM";
		public const string GXSJ="GXSJ";
		public const string QXDM="QXDM";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsDYQLGX:IEntity
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
		private string m_RWBH;
		private string m_DYBM;
		private long m_DYBSM;
		private string m_QLBM;
		private long m_QLBSM;
		private string m_TXQLBM;
		private long m_TXQLBSM;
		private DateTime m_GXSJ;
		private long m_QXDM;
		private long m_BG_BB;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public string RWBH
		{
			get{ return m_RWBH; }
			set{ m_RWBH = value; }
		}
		public string DYBM
		{
			get{ return m_DYBM; }
			set{ m_DYBM = value; }
		}
		public long DYBSM
		{
			get{ return m_DYBSM; }
			set{ m_DYBSM = value; }
		}
		public string QLBM
		{
			get{ return m_QLBM; }
			set{ m_QLBM = value; }
		}
		public long QLBSM
		{
			get{ return m_QLBSM; }
			set{ m_QLBSM = value; }
		}
		public string TXQLBM
		{
			get{ return m_TXQLBM; }
			set{ m_TXQLBM = value; }
		}
		public long TXQLBSM
		{
			get{ return m_TXQLBSM; }
			set{ m_TXQLBSM = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		public long QXDM
		{
			get{ return m_QXDM; }
			set{ m_QXDM = value; }
		}
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

		#endregion
		public bool IsEquals(clsDYQLGX obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.RWBH != obj.RWBH) bolResult = false;
			if (this.DYBM != obj.DYBM) bolResult = false;
			if (this.DYBSM != obj.DYBSM) bolResult = false;
			if (this.QLBM != obj.QLBM) bolResult = false;
			if (this.QLBSM != obj.QLBSM) bolResult = false;
			if (this.TXQLBM != obj.TXQLBM) bolResult = false;
			if (this.TXQLBSM != obj.TXQLBSM) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			return bolResult;
		}

		public void Colne(clsDYQLGX obj)
		{
			this.BSM=obj.BSM;
			this.RWBH=obj.RWBH;
			this.DYBM=obj.DYBM;
			this.DYBSM=obj.DYBSM;
			this.QLBM=obj.QLBM;
			this.QLBSM=obj.QLBSM;
			this.TXQLBM=obj.TXQLBM;
			this.TXQLBSM=obj.TXQLBSM;
			this.GXSJ=obj.GXSJ;
			this.QXDM=obj.QXDM;
		}

	}

	public class clsDYQLGXSet:EntityBaseSet
	{
		public clsDYQLGXSet()
		{
			m_TableName="DYQLGX";
			m_HisTableName="DYQLGX_LS";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsDYQLGXSet";
		}
		public static clsDYQLGXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsDYQLGXSet clsSet = new clsDYQLGXSet(); //(clsDYQLGXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsDYQLGXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsDYQLGX obj = (clsDYQLGX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("RWBH")) datarow["RWBH"] = obj.RWBH;
				if(datarow.Table.Columns.Contains("DYBM")) datarow["DYBM"] = obj.DYBM;
				if(datarow.Table.Columns.Contains("DYBSM")) datarow["DYBSM"] = obj.DYBSM;
				if(datarow.Table.Columns.Contains("QLBM")) datarow["QLBM"] = obj.QLBM;
				if(datarow.Table.Columns.Contains("QLBSM")) datarow["QLBSM"] = obj.QLBSM;
				if(datarow.Table.Columns.Contains("TXQLBM")) datarow["TXQLBM"] = obj.TXQLBM;
				if(datarow.Table.Columns.Contains("TXQLBSM")) datarow["TXQLBSM"] = obj.TXQLBSM;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
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
			clsDYQLGX obj = null;
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
					obj = new clsDYQLGX();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="RWBH")
								if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
							if(strFldName.ToUpper()=="DYBM")
								if (pRow.Table.Columns.Contains("DYBM") && pRow["DYBM"] != DBNull.Value) { obj.DYBM = Convert.ToString(pRow["DYBM"]); }
							if(strFldName.ToUpper()=="DYBSM")
								if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
							if(strFldName.ToUpper()=="QLBM")
								if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
							if(strFldName.ToUpper()=="QLBSM")
								if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
							if(strFldName.ToUpper()=="TXQLBM")
								if (pRow.Table.Columns.Contains("TXQLBM") && pRow["TXQLBM"] != DBNull.Value) { obj.TXQLBM = Convert.ToString(pRow["TXQLBM"]); }
							if(strFldName.ToUpper()=="TXQLBSM")
								if (pRow.Table.Columns.Contains("TXQLBSM") && pRow["TXQLBSM"] != DBNull.Value) { obj.TXQLBSM = Convert.ToInt64(pRow["TXQLBSM"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
						if (pRow.Table.Columns.Contains("DYBM") && pRow["DYBM"] != DBNull.Value) { obj.DYBM = Convert.ToString(pRow["DYBM"]); }
						if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
						if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
						if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
						if (pRow.Table.Columns.Contains("TXQLBM") && pRow["TXQLBM"] != DBNull.Value) { obj.TXQLBM = Convert.ToString(pRow["TXQLBM"]); }
						if (pRow.Table.Columns.Contains("TXQLBSM") && pRow["TXQLBSM"] != DBNull.Value) { obj.TXQLBSM = Convert.ToInt64(pRow["TXQLBSM"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
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
