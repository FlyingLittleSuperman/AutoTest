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

	public class Fld_XZQBM
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string XZQJB="XZQJB";
		public const string XZQBM="XZQBM";
		public const string XZQMC="XZQMC";
		public const string FWQBM="FWQBM";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string REV_="REV_";
		public const string FZMC="FZMC";
		public const string BSM="BSM";
		#endregion
	}

	public class clsXZQBM:IEntity
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
		private int m_XZQJB;
		private string m_XZQBM;
		private string m_XZQMC;
		private int m_FWQBM;
		private DateTime m_GXSJ;
		private string m_BZ;
		private long m_REV_;
		private string m_FZMC;

		public int XZQJB
		{
			get{ return m_XZQJB; }
			set{ m_XZQJB = value; }
		}
		public string XZQBM
		{
			get{ return m_XZQBM; }
			set{ m_XZQBM = value; }
		}
		public string XZQMC
		{
			get{ return m_XZQMC; }
			set{ m_XZQMC = value; }
		}
		public int FWQBM
		{
			get{ return m_FWQBM; }
			set{ m_FWQBM = value; }
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
		public long REV_
		{
			get{ return m_REV_; }
			set{ m_REV_ = value; }
		}
		public string FZMC
		{
			get{ return m_FZMC; }
			set{ m_FZMC = value; }
		}
		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}

		#endregion
		public bool IsEquals(clsXZQBM obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.XZQJB != obj.XZQJB) bolResult = false;
			if (this.XZQBM != obj.XZQBM) bolResult = false;
			if (this.XZQMC != obj.XZQMC) bolResult = false;
			if (this.FWQBM != obj.FWQBM) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.FZMC != obj.FZMC) bolResult = false;
			if (this.BSM != obj.BSM) bolResult = false;
			return bolResult;
		}

		public void Colne(clsXZQBM obj)
		{
			this.XZQJB=obj.XZQJB;
			this.XZQBM=obj.XZQBM;
			this.XZQMC=obj.XZQMC;
			this.FWQBM=obj.FWQBM;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.REV_=obj.REV_;
			this.FZMC=obj.FZMC;
			this.BSM=obj.BSM;
		}

	}

	public class clsXZQBMSet:EntityBaseSet
	{
		public clsXZQBMSet()
		{
			m_TableName="BDCDJ.XZQBM";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsXZQBMSet";
		}
		public static clsXZQBMSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsXZQBMSet clsSet = new clsXZQBMSet(); //(clsXZQBMSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsXZQBMSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsXZQBM obj = (clsXZQBM)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("XZQJB")) datarow["XZQJB"] = obj.XZQJB;
				if(datarow.Table.Columns.Contains("XZQBM")) datarow["XZQBM"] = obj.XZQBM;
				if(datarow.Table.Columns.Contains("XZQMC")) datarow["XZQMC"] = obj.XZQMC;
				if(datarow.Table.Columns.Contains("FWQBM")) datarow["FWQBM"] = obj.FWQBM;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("FZMC")) datarow["FZMC"] = obj.FZMC;
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
			clsXZQBM obj = null;
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
					obj = new clsXZQBM();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="XZQJB")
								if (pRow.Table.Columns.Contains("XZQJB") && pRow["XZQJB"] != DBNull.Value) { obj.XZQJB = Convert.ToInt16(pRow["XZQJB"]); }
							if(strFldName.ToUpper()=="XZQBM")
								if (pRow.Table.Columns.Contains("XZQBM") && pRow["XZQBM"] != DBNull.Value) { obj.XZQBM = Convert.ToString(pRow["XZQBM"]); }
							if(strFldName.ToUpper()=="XZQMC")
								if (pRow.Table.Columns.Contains("XZQMC") && pRow["XZQMC"] != DBNull.Value) { obj.XZQMC = Convert.ToString(pRow["XZQMC"]); }
							if(strFldName.ToUpper()=="FWQBM")
								if (pRow.Table.Columns.Contains("FWQBM") && pRow["FWQBM"] != DBNull.Value) { obj.FWQBM = Convert.ToInt16(pRow["FWQBM"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="FZMC")
								if (pRow.Table.Columns.Contains("FZMC") && pRow["FZMC"] != DBNull.Value) { obj.FZMC = Convert.ToString(pRow["FZMC"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("XZQJB") && pRow["XZQJB"] != DBNull.Value) { obj.XZQJB = Convert.ToInt16(pRow["XZQJB"]); }
						if (pRow.Table.Columns.Contains("XZQBM") && pRow["XZQBM"] != DBNull.Value) { obj.XZQBM = Convert.ToString(pRow["XZQBM"]); }
						if (pRow.Table.Columns.Contains("XZQMC") && pRow["XZQMC"] != DBNull.Value) { obj.XZQMC = Convert.ToString(pRow["XZQMC"]); }
						if (pRow.Table.Columns.Contains("FWQBM") && pRow["FWQBM"] != DBNull.Value) { obj.FWQBM = Convert.ToInt16(pRow["FWQBM"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("FZMC") && pRow["FZMC"] != DBNull.Value) { obj.FZMC = Convert.ToString(pRow["FZMC"]); }
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
