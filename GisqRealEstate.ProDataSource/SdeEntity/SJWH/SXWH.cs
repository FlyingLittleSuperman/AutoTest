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
修改/创建者：ASSASSIN | 修改时间（2016/11/15) | 说明(包括原因及涉及内容） |
==================================================
*/
namespace GisqRealEstate.ProDataSource
{

	public class Fld_SXWH
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string RWBH="RWBH";
		public const string XGBM="XGBM";
		public const string XGBGJZDMC="XGBGJZDMC";
		public const string XGBGJZDZ="XGBGJZDZ";
		public const string XGZDM="XGZDM";
		public const string XGZDSM="XGZDSM";
		public const string XGQXX="XGQXX";
		public const string XGHXX="XGHXX";
		public const string XGNR="XGNR";
		public const string GXSJ="GXSJ";
		public const string XGZDLX="XGZDLX";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsSXWH:IEntity
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
		private string m_XGBM;
		private string m_XGBGJZDMC;
		private long m_XGBGJZDZ;
		private string m_XGZDM;
		private string m_XGZDSM;
		private string m_XGQXX;
		private string m_XGHXX;
		private string m_XGNR;
		private DateTime m_GXSJ;
		private string m_XGZDLX;
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
		public string XGBM
		{
			get{ return m_XGBM; }
			set{ m_XGBM = value; }
		}
		public string XGBGJZDMC
		{
			get{ return m_XGBGJZDMC; }
			set{ m_XGBGJZDMC = value; }
		}
		public long XGBGJZDZ
		{
			get{ return m_XGBGJZDZ; }
			set{ m_XGBGJZDZ = value; }
		}
		public string XGZDM
		{
			get{ return m_XGZDM; }
			set{ m_XGZDM = value; }
		}
		public string XGZDSM
		{
			get{ return m_XGZDSM; }
			set{ m_XGZDSM = value; }
		}
		public string XGQXX
		{
			get{ return m_XGQXX; }
			set{ m_XGQXX = value; }
		}
		public string XGHXX
		{
			get{ return m_XGHXX; }
			set{ m_XGHXX = value; }
		}
		public string XGNR
		{
			get{ return m_XGNR; }
			set{ m_XGNR = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		public string XGZDLX
		{
			get{ return m_XGZDLX; }
			set{ m_XGZDLX = value; }
		}
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

		#endregion
		public bool IsEquals(clsSXWH obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.RWBH != obj.RWBH) bolResult = false;
			if (this.XGBM != obj.XGBM) bolResult = false;
			if (this.XGBGJZDMC != obj.XGBGJZDMC) bolResult = false;
			if (this.XGBGJZDZ != obj.XGBGJZDZ) bolResult = false;
			if (this.XGZDM != obj.XGZDM) bolResult = false;
			if (this.XGZDSM != obj.XGZDSM) bolResult = false;
			if (this.XGQXX != obj.XGQXX) bolResult = false;
			if (this.XGHXX != obj.XGHXX) bolResult = false;
			if (this.XGNR != obj.XGNR) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.XGZDLX != obj.XGZDLX) bolResult = false;
			return bolResult;
		}

		public void Colne(clsSXWH obj)
		{
			this.BSM=obj.BSM;
			this.RWBH=obj.RWBH;
			this.XGBM=obj.XGBM;
			this.XGBGJZDMC=obj.XGBGJZDMC;
			this.XGBGJZDZ=obj.XGBGJZDZ;
			this.XGZDM=obj.XGZDM;
			this.XGZDSM=obj.XGZDSM;
			this.XGQXX=obj.XGQXX;
			this.XGHXX=obj.XGHXX;
			this.XGNR=obj.XGNR;
			this.GXSJ=obj.GXSJ;
			this.XGZDLX=obj.XGZDLX;
		}

	}

	public class clsSXWHSet:EntityBaseSet
	{
		public clsSXWHSet()
		{
			m_TableName="SXWH";
			m_HisTableName="SXWH_LS";
			m_PrimaryKeyName="BSM";
            m_SequenceName = "BDCDJ.SEQ_BSM";
			m_ClsName="clsSXWHSet";
		}
		public static clsSXWHSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsSXWHSet clsSet = new clsSXWHSet(); //(clsSXWHSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsSXWHSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsSXWH obj = (clsSXWH)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("RWBH")) datarow["RWBH"] = obj.RWBH;
				if(datarow.Table.Columns.Contains("XGBM")) datarow["XGBM"] = obj.XGBM;
				if(datarow.Table.Columns.Contains("XGBGJZDMC")) datarow["XGBGJZDMC"] = obj.XGBGJZDMC;
				if(datarow.Table.Columns.Contains("XGBGJZDZ")) datarow["XGBGJZDZ"] = obj.XGBGJZDZ;
				if(datarow.Table.Columns.Contains("XGZDM")) datarow["XGZDM"] = obj.XGZDM;
				if(datarow.Table.Columns.Contains("XGZDSM")) datarow["XGZDSM"] = obj.XGZDSM;
				if(datarow.Table.Columns.Contains("XGQXX")) datarow["XGQXX"] = obj.XGQXX;
				if(datarow.Table.Columns.Contains("XGHXX")) datarow["XGHXX"] = obj.XGHXX;
				if(datarow.Table.Columns.Contains("XGNR")) datarow["XGNR"] = obj.XGNR;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("XGZDLX")) datarow["XGZDLX"] = obj.XGZDLX;
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
			clsSXWH obj = null;
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
					obj = new clsSXWH();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="RWBH")
								if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
							if(strFldName.ToUpper()=="XGBM")
								if (pRow.Table.Columns.Contains("XGBM") && pRow["XGBM"] != DBNull.Value) { obj.XGBM = Convert.ToString(pRow["XGBM"]); }
							if(strFldName.ToUpper()=="XGBGJZDMC")
								if (pRow.Table.Columns.Contains("XGBGJZDMC") && pRow["XGBGJZDMC"] != DBNull.Value) { obj.XGBGJZDMC = Convert.ToString(pRow["XGBGJZDMC"]); }
							if(strFldName.ToUpper()=="XGBGJZDZ")
								if (pRow.Table.Columns.Contains("XGBGJZDZ") && pRow["XGBGJZDZ"] != DBNull.Value) { obj.XGBGJZDZ = Convert.ToInt64(pRow["XGBGJZDZ"]); }
							if(strFldName.ToUpper()=="XGZDM")
								if (pRow.Table.Columns.Contains("XGZDM") && pRow["XGZDM"] != DBNull.Value) { obj.XGZDM = Convert.ToString(pRow["XGZDM"]); }
							if(strFldName.ToUpper()=="XGZDSM")
								if (pRow.Table.Columns.Contains("XGZDSM") && pRow["XGZDSM"] != DBNull.Value) { obj.XGZDSM = Convert.ToString(pRow["XGZDSM"]); }
							if(strFldName.ToUpper()=="XGQXX")
								if (pRow.Table.Columns.Contains("XGQXX") && pRow["XGQXX"] != DBNull.Value) { obj.XGQXX = Convert.ToString(pRow["XGQXX"]); }
							if(strFldName.ToUpper()=="XGHXX")
								if (pRow.Table.Columns.Contains("XGHXX") && pRow["XGHXX"] != DBNull.Value) { obj.XGHXX = Convert.ToString(pRow["XGHXX"]); }
							if(strFldName.ToUpper()=="XGNR")
								if (pRow.Table.Columns.Contains("XGNR") && pRow["XGNR"] != DBNull.Value) { obj.XGNR = Convert.ToString(pRow["XGNR"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="XGZDLX")
								if (pRow.Table.Columns.Contains("XGZDLX") && pRow["XGZDLX"] != DBNull.Value) { obj.XGZDLX = Convert.ToString(pRow["XGZDLX"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
						if (pRow.Table.Columns.Contains("XGBM") && pRow["XGBM"] != DBNull.Value) { obj.XGBM = Convert.ToString(pRow["XGBM"]); }
						if (pRow.Table.Columns.Contains("XGBGJZDMC") && pRow["XGBGJZDMC"] != DBNull.Value) { obj.XGBGJZDMC = Convert.ToString(pRow["XGBGJZDMC"]); }
						if (pRow.Table.Columns.Contains("XGBGJZDZ") && pRow["XGBGJZDZ"] != DBNull.Value) { obj.XGBGJZDZ = Convert.ToInt64(pRow["XGBGJZDZ"]); }
						if (pRow.Table.Columns.Contains("XGZDM") && pRow["XGZDM"] != DBNull.Value) { obj.XGZDM = Convert.ToString(pRow["XGZDM"]); }
						if (pRow.Table.Columns.Contains("XGZDSM") && pRow["XGZDSM"] != DBNull.Value) { obj.XGZDSM = Convert.ToString(pRow["XGZDSM"]); }
						if (pRow.Table.Columns.Contains("XGQXX") && pRow["XGQXX"] != DBNull.Value) { obj.XGQXX = Convert.ToString(pRow["XGQXX"]); }
						if (pRow.Table.Columns.Contains("XGHXX") && pRow["XGHXX"] != DBNull.Value) { obj.XGHXX = Convert.ToString(pRow["XGHXX"]); }
						if (pRow.Table.Columns.Contains("XGNR") && pRow["XGNR"] != DBNull.Value) { obj.XGNR = Convert.ToString(pRow["XGNR"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("XGZDLX") && pRow["XGZDLX"] != DBNull.Value) { obj.XGZDLX = Convert.ToString(pRow["XGZDLX"]); }
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
