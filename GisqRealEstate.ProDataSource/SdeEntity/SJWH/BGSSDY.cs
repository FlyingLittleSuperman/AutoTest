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

	public class Fld_BGSSDY
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string RWBH="RWBH";
		public const string QLBM="QLBM";
		public const string QLBSM="QLBSM";
		public const string YDYBM="YDYBM";
		public const string YDYBSM="YDYBSM";
		public const string XDYBM="XDYBM";
		public const string XDYBSM="XDYBSM";
		public const string GXSJ="GXSJ";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsBGSSDY:IEntity
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
		private string m_QLBM;
		private long m_QLBSM;
		private string m_YDYBM;
		private long m_YDYBSM;
		private string m_XDYBM;
		private long m_XDYBSM;
		private DateTime m_GXSJ;
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
		public string YDYBM
		{
			get{ return m_YDYBM; }
			set{ m_YDYBM = value; }
		}
		public long YDYBSM
		{
			get{ return m_YDYBSM; }
			set{ m_YDYBSM = value; }
		}
		public string XDYBM
		{
			get{ return m_XDYBM; }
			set{ m_XDYBM = value; }
		}
		public long XDYBSM
		{
			get{ return m_XDYBSM; }
			set{ m_XDYBSM = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

		#endregion
		public bool IsEquals(clsBGSSDY obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.RWBH != obj.RWBH) bolResult = false;
			if (this.QLBM != obj.QLBM) bolResult = false;
			if (this.QLBSM != obj.QLBSM) bolResult = false;
			if (this.YDYBM != obj.YDYBM) bolResult = false;
			if (this.YDYBSM != obj.YDYBSM) bolResult = false;
			if (this.XDYBM != obj.XDYBM) bolResult = false;
			if (this.XDYBSM != obj.XDYBSM) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsBGSSDY obj)
		{
			this.BSM=obj.BSM;
			this.RWBH=obj.RWBH;
			this.QLBM=obj.QLBM;
			this.QLBSM=obj.QLBSM;
			this.YDYBM=obj.YDYBM;
			this.YDYBSM=obj.YDYBSM;
			this.XDYBM=obj.XDYBM;
			this.XDYBSM=obj.XDYBSM;
			this.GXSJ=obj.GXSJ;
		}

	}

	public class clsBGSSDYSet:EntityBaseSet
	{
		public clsBGSSDYSet()
		{
			m_TableName="BGSSDY";
			m_HisTableName="BGSSDY_LS";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsBGSSDYSet";
		}
		public static clsBGSSDYSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsBGSSDYSet clsSet = new clsBGSSDYSet(); //(clsBGSSDYSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsBGSSDYSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsBGSSDY obj = (clsBGSSDY)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("RWBH")) datarow["RWBH"] = obj.RWBH;
				if(datarow.Table.Columns.Contains("QLBM")) datarow["QLBM"] = obj.QLBM;
				if(datarow.Table.Columns.Contains("QLBSM")) datarow["QLBSM"] = obj.QLBSM;
				if(datarow.Table.Columns.Contains("YDYBM")) datarow["YDYBM"] = obj.YDYBM;
				if(datarow.Table.Columns.Contains("YDYBSM")) datarow["YDYBSM"] = obj.YDYBSM;
				if(datarow.Table.Columns.Contains("XDYBM")) datarow["XDYBM"] = obj.XDYBM;
				if(datarow.Table.Columns.Contains("XDYBSM")) datarow["XDYBSM"] = obj.XDYBSM;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
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
			clsBGSSDY obj = null;
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
					obj = new clsBGSSDY();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="RWBH")
								if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
							if(strFldName.ToUpper()=="QLBM")
								if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
							if(strFldName.ToUpper()=="QLBSM")
								if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
							if(strFldName.ToUpper()=="YDYBM")
								if (pRow.Table.Columns.Contains("YDYBM") && pRow["YDYBM"] != DBNull.Value) { obj.YDYBM = Convert.ToString(pRow["YDYBM"]); }
							if(strFldName.ToUpper()=="YDYBSM")
								if (pRow.Table.Columns.Contains("YDYBSM") && pRow["YDYBSM"] != DBNull.Value) { obj.YDYBSM = Convert.ToInt64(pRow["YDYBSM"]); }
							if(strFldName.ToUpper()=="XDYBM")
								if (pRow.Table.Columns.Contains("XDYBM") && pRow["XDYBM"] != DBNull.Value) { obj.XDYBM = Convert.ToString(pRow["XDYBM"]); }
							if(strFldName.ToUpper()=="XDYBSM")
								if (pRow.Table.Columns.Contains("XDYBSM") && pRow["XDYBSM"] != DBNull.Value) { obj.XDYBSM = Convert.ToInt64(pRow["XDYBSM"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
						if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
						if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
						if (pRow.Table.Columns.Contains("YDYBM") && pRow["YDYBM"] != DBNull.Value) { obj.YDYBM = Convert.ToString(pRow["YDYBM"]); }
						if (pRow.Table.Columns.Contains("YDYBSM") && pRow["YDYBSM"] != DBNull.Value) { obj.YDYBSM = Convert.ToInt64(pRow["YDYBSM"]); }
						if (pRow.Table.Columns.Contains("XDYBM") && pRow["XDYBM"] != DBNull.Value) { obj.XDYBM = Convert.ToString(pRow["XDYBM"]); }
						if (pRow.Table.Columns.Contains("XDYBSM") && pRow["XDYBSM"] != DBNull.Value) { obj.XDYBSM = Convert.ToInt64(pRow["XDYBSM"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
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
