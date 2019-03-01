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

	public class Fld_FDGJGX
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string RWBH="RWBH";
		public const string ZDZHBM="ZDZHBM";
		public const string ZDZHBSM="ZDZHBSM";
		public const string ZDZHQLBM="ZDZHQLBM";
		public const string ZDZHQLBSM="ZDZHQLBSM";
		public const string DZWDYBM="DZWDYBM";
		public const string DZWDYBSM="DZWDYBSM";
		public const string DZWQLBM="DZWQLBM";
		public const string DZWQLBSM="DZWQLBSM";
		public const string GXSJ="GXSJ";
		public const string QXDM="QXDM";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsFDGJGX:IEntity
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
		private string m_ZDZHBM;
		private long m_ZDZHBSM;
		private string m_ZDZHQLBM;
		private long m_ZDZHQLBSM;
		private string m_DZWDYBM;
		private long m_DZWDYBSM;
		private string m_DZWQLBM;
		private long m_DZWQLBSM;
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
		public string ZDZHBM
		{
			get{ return m_ZDZHBM; }
			set{ m_ZDZHBM = value; }
		}
		public long ZDZHBSM
		{
			get{ return m_ZDZHBSM; }
			set{ m_ZDZHBSM = value; }
		}
		public string ZDZHQLBM
		{
			get{ return m_ZDZHQLBM; }
			set{ m_ZDZHQLBM = value; }
		}
		public long ZDZHQLBSM
		{
			get{ return m_ZDZHQLBSM; }
			set{ m_ZDZHQLBSM = value; }
		}
		public string DZWDYBM
		{
			get{ return m_DZWDYBM; }
			set{ m_DZWDYBM = value; }
		}
		public long DZWDYBSM
		{
			get{ return m_DZWDYBSM; }
			set{ m_DZWDYBSM = value; }
		}
		public string DZWQLBM
		{
			get{ return m_DZWQLBM; }
			set{ m_DZWQLBM = value; }
		}
		public long DZWQLBSM
		{
			get{ return m_DZWQLBSM; }
			set{ m_DZWQLBSM = value; }
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
		public bool IsEquals(clsFDGJGX obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.RWBH != obj.RWBH) bolResult = false;
			if (this.ZDZHBM != obj.ZDZHBM) bolResult = false;
			if (this.ZDZHBSM != obj.ZDZHBSM) bolResult = false;
			if (this.ZDZHQLBM != obj.ZDZHQLBM) bolResult = false;
			if (this.ZDZHQLBSM != obj.ZDZHQLBSM) bolResult = false;
			if (this.DZWDYBM != obj.DZWDYBM) bolResult = false;
			if (this.DZWDYBSM != obj.DZWDYBSM) bolResult = false;
			if (this.DZWQLBM != obj.DZWQLBM) bolResult = false;
			if (this.DZWQLBSM != obj.DZWQLBSM) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			return bolResult;
		}

		public void Colne(clsFDGJGX obj)
		{
			this.BSM=obj.BSM;
			this.RWBH=obj.RWBH;
			this.ZDZHBM=obj.ZDZHBM;
			this.ZDZHBSM=obj.ZDZHBSM;
			this.ZDZHQLBM=obj.ZDZHQLBM;
			this.ZDZHQLBSM=obj.ZDZHQLBSM;
			this.DZWDYBM=obj.DZWDYBM;
			this.DZWDYBSM=obj.DZWDYBSM;
			this.DZWQLBM=obj.DZWQLBM;
			this.DZWQLBSM=obj.DZWQLBSM;
			this.GXSJ=obj.GXSJ;
			this.QXDM=obj.QXDM;
		}

	}

	public class clsFDGJGXSet:EntityBaseSet
	{
		public clsFDGJGXSet()
		{
			m_TableName="FDGJGX";
			m_HisTableName="FDGJGX_LS";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsFDGJGXSet";
		}
		public static clsFDGJGXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsFDGJGXSet clsSet = new clsFDGJGXSet(); //(clsFDGJGXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsFDGJGXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsFDGJGX obj = (clsFDGJGX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("RWBH")) datarow["RWBH"] = obj.RWBH;
				if(datarow.Table.Columns.Contains("ZDZHBM")) datarow["ZDZHBM"] = obj.ZDZHBM;
				if(datarow.Table.Columns.Contains("ZDZHBSM")) datarow["ZDZHBSM"] = obj.ZDZHBSM;
				if(datarow.Table.Columns.Contains("ZDZHQLBM")) datarow["ZDZHQLBM"] = obj.ZDZHQLBM;
				if(datarow.Table.Columns.Contains("ZDZHQLBSM")) datarow["ZDZHQLBSM"] = obj.ZDZHQLBSM;
				if(datarow.Table.Columns.Contains("DZWDYBM")) datarow["DZWDYBM"] = obj.DZWDYBM;
				if(datarow.Table.Columns.Contains("DZWDYBSM")) datarow["DZWDYBSM"] = obj.DZWDYBSM;
				if(datarow.Table.Columns.Contains("DZWQLBM")) datarow["DZWQLBM"] = obj.DZWQLBM;
				if(datarow.Table.Columns.Contains("DZWQLBSM")) datarow["DZWQLBSM"] = obj.DZWQLBSM;
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
			clsFDGJGX obj = null;
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
					obj = new clsFDGJGX();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="RWBH")
								if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
							if(strFldName.ToUpper()=="ZDZHBM")
								if (pRow.Table.Columns.Contains("ZDZHBM") && pRow["ZDZHBM"] != DBNull.Value) { obj.ZDZHBM = Convert.ToString(pRow["ZDZHBM"]); }
							if(strFldName.ToUpper()=="ZDZHBSM")
								if (pRow.Table.Columns.Contains("ZDZHBSM") && pRow["ZDZHBSM"] != DBNull.Value) { obj.ZDZHBSM = Convert.ToInt64(pRow["ZDZHBSM"]); }
							if(strFldName.ToUpper()=="ZDZHQLBM")
								if (pRow.Table.Columns.Contains("ZDZHQLBM") && pRow["ZDZHQLBM"] != DBNull.Value) { obj.ZDZHQLBM = Convert.ToString(pRow["ZDZHQLBM"]); }
							if(strFldName.ToUpper()=="ZDZHQLBSM")
								if (pRow.Table.Columns.Contains("ZDZHQLBSM") && pRow["ZDZHQLBSM"] != DBNull.Value) { obj.ZDZHQLBSM = Convert.ToInt64(pRow["ZDZHQLBSM"]); }
							if(strFldName.ToUpper()=="DZWDYBM")
								if (pRow.Table.Columns.Contains("DZWDYBM") && pRow["DZWDYBM"] != DBNull.Value) { obj.DZWDYBM = Convert.ToString(pRow["DZWDYBM"]); }
							if(strFldName.ToUpper()=="DZWDYBSM")
								if (pRow.Table.Columns.Contains("DZWDYBSM") && pRow["DZWDYBSM"] != DBNull.Value) { obj.DZWDYBSM = Convert.ToInt64(pRow["DZWDYBSM"]); }
							if(strFldName.ToUpper()=="DZWQLBM")
								if (pRow.Table.Columns.Contains("DZWQLBM") && pRow["DZWQLBM"] != DBNull.Value) { obj.DZWQLBM = Convert.ToString(pRow["DZWQLBM"]); }
							if(strFldName.ToUpper()=="DZWQLBSM")
								if (pRow.Table.Columns.Contains("DZWQLBSM") && pRow["DZWQLBSM"] != DBNull.Value) { obj.DZWQLBSM = Convert.ToInt64(pRow["DZWQLBSM"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
						if (pRow.Table.Columns.Contains("ZDZHBM") && pRow["ZDZHBM"] != DBNull.Value) { obj.ZDZHBM = Convert.ToString(pRow["ZDZHBM"]); }
						if (pRow.Table.Columns.Contains("ZDZHBSM") && pRow["ZDZHBSM"] != DBNull.Value) { obj.ZDZHBSM = Convert.ToInt64(pRow["ZDZHBSM"]); }
						if (pRow.Table.Columns.Contains("ZDZHQLBM") && pRow["ZDZHQLBM"] != DBNull.Value) { obj.ZDZHQLBM = Convert.ToString(pRow["ZDZHQLBM"]); }
						if (pRow.Table.Columns.Contains("ZDZHQLBSM") && pRow["ZDZHQLBSM"] != DBNull.Value) { obj.ZDZHQLBSM = Convert.ToInt64(pRow["ZDZHQLBSM"]); }
						if (pRow.Table.Columns.Contains("DZWDYBM") && pRow["DZWDYBM"] != DBNull.Value) { obj.DZWDYBM = Convert.ToString(pRow["DZWDYBM"]); }
						if (pRow.Table.Columns.Contains("DZWDYBSM") && pRow["DZWDYBSM"] != DBNull.Value) { obj.DZWDYBSM = Convert.ToInt64(pRow["DZWDYBSM"]); }
						if (pRow.Table.Columns.Contains("DZWQLBM") && pRow["DZWQLBM"] != DBNull.Value) { obj.DZWQLBM = Convert.ToString(pRow["DZWQLBM"]); }
						if (pRow.Table.Columns.Contains("DZWQLBSM") && pRow["DZWQLBSM"] != DBNull.Value) { obj.DZWQLBSM = Convert.ToInt64(pRow["DZWQLBSM"]); }
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
