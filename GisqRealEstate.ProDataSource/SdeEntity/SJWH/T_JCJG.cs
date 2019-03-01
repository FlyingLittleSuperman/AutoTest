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

	public class Fld_TJCJG
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string BM="BM";
		public const string GJZDM="GJZDM";
		public const string GJZDZ="GJZDZ";
		public const string JCGZBSM="JCGZBSM";
		public const string JCGZLX="JCGZLX";
		public const string GXZT="GXZT";
		public const string BZ="BZ";
		public const string GXSJ="GXSJ";
		#endregion
	}

	public class clsTJCJG:IEntity
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
		private string m_BM;
		private string m_GJZDM;
		private long m_GJZDZ;
		private long m_JCGZBSM;
		private string m_JCGZLX;
		private int m_GXZT;
		private string m_BZ;
		private DateTime m_GXSJ;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public string BM
		{
			get{ return m_BM; }
			set{ m_BM = value; }
		}
		public string GJZDM
		{
			get{ return m_GJZDM; }
			set{ m_GJZDM = value; }
		}
		public long GJZDZ
		{
			get{ return m_GJZDZ; }
			set{ m_GJZDZ = value; }
		}
		public long JCGZBSM
		{
			get{ return m_JCGZBSM; }
			set{ m_JCGZBSM = value; }
		}
		public string JCGZLX
		{
			get{ return m_JCGZLX; }
			set{ m_JCGZLX = value; }
		}
		public int GXZT
		{
			get{ return m_GXZT; }
			set{ m_GXZT = value; }
		}
		public string BZ
		{
			get{ return m_BZ; }
			set{ m_BZ = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}

		#endregion
		public bool IsEquals(clsTJCJG obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.BM != obj.BM) bolResult = false;
			if (this.GJZDM != obj.GJZDM) bolResult = false;
			if (this.GJZDZ != obj.GJZDZ) bolResult = false;
			if (this.JCGZBSM != obj.JCGZBSM) bolResult = false;
			if (this.JCGZLX != obj.JCGZLX) bolResult = false;
			if (this.GXZT != obj.GXZT) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsTJCJG obj)
		{
			this.BSM=obj.BSM;
			this.BM=obj.BM;
			this.GJZDM=obj.GJZDM;
			this.GJZDZ=obj.GJZDZ;
			this.JCGZBSM=obj.JCGZBSM;
			this.JCGZLX=obj.JCGZLX;
			this.GXZT=obj.GXZT;
			this.BZ=obj.BZ;
			this.GXSJ=obj.GXSJ;
		}

	}

	public class clsTJCJGSet:EntityBaseSet
	{
		public clsTJCJGSet()
		{
			m_TableName="T_JCJG";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
            m_SequenceName = "BDCDJ.SEQ_BSM";
			m_ClsName="clsTJCJGSet";
		}
		public static clsTJCJGSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsTJCJGSet clsSet = new clsTJCJGSet(); //(clsTJCJGSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsTJCJGSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsTJCJG obj = (clsTJCJG)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("BM")) datarow["BM"] = obj.BM;
				if(datarow.Table.Columns.Contains("GJZDM")) datarow["GJZDM"] = obj.GJZDM;
				if(datarow.Table.Columns.Contains("GJZDZ")) datarow["GJZDZ"] = obj.GJZDZ;
				if(datarow.Table.Columns.Contains("JCGZBSM")) datarow["JCGZBSM"] = obj.JCGZBSM;
				if(datarow.Table.Columns.Contains("JCGZLX")) datarow["JCGZLX"] = obj.JCGZLX;
				if(datarow.Table.Columns.Contains("GXZT")) datarow["GXZT"] = obj.GXZT;
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
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
			clsTJCJG obj = null;
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
					obj = new clsTJCJG();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="BM")
								if (pRow.Table.Columns.Contains("BM") && pRow["BM"] != DBNull.Value) { obj.BM = Convert.ToString(pRow["BM"]); }
							if(strFldName.ToUpper()=="GJZDM")
								if (pRow.Table.Columns.Contains("GJZDM") && pRow["GJZDM"] != DBNull.Value) { obj.GJZDM = Convert.ToString(pRow["GJZDM"]); }
							if(strFldName.ToUpper()=="GJZDZ")
								if (pRow.Table.Columns.Contains("GJZDZ") && pRow["GJZDZ"] != DBNull.Value) { obj.GJZDZ = Convert.ToInt64(pRow["GJZDZ"]); }
							if(strFldName.ToUpper()=="JCGZBSM")
								if (pRow.Table.Columns.Contains("JCGZBSM") && pRow["JCGZBSM"] != DBNull.Value) { obj.JCGZBSM = Convert.ToInt64(pRow["JCGZBSM"]); }
							if(strFldName.ToUpper()=="JCGZLX")
								if (pRow.Table.Columns.Contains("JCGZLX") && pRow["JCGZLX"] != DBNull.Value) { obj.JCGZLX = Convert.ToString(pRow["JCGZLX"]); }
							if(strFldName.ToUpper()=="GXZT")
								if (pRow.Table.Columns.Contains("GXZT") && pRow["GXZT"] != DBNull.Value) { obj.GXZT = Convert.ToInt16(pRow["GXZT"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("BM") && pRow["BM"] != DBNull.Value) { obj.BM = Convert.ToString(pRow["BM"]); }
						if (pRow.Table.Columns.Contains("GJZDM") && pRow["GJZDM"] != DBNull.Value) { obj.GJZDM = Convert.ToString(pRow["GJZDM"]); }
						if (pRow.Table.Columns.Contains("GJZDZ") && pRow["GJZDZ"] != DBNull.Value) { obj.GJZDZ = Convert.ToInt64(pRow["GJZDZ"]); }
						if (pRow.Table.Columns.Contains("JCGZBSM") && pRow["JCGZBSM"] != DBNull.Value) { obj.JCGZBSM = Convert.ToInt64(pRow["JCGZBSM"]); }
						if (pRow.Table.Columns.Contains("JCGZLX") && pRow["JCGZLX"] != DBNull.Value) { obj.JCGZLX = Convert.ToString(pRow["JCGZLX"]); }
						if (pRow.Table.Columns.Contains("GXZT") && pRow["GXZT"] != DBNull.Value) { obj.GXZT = Convert.ToInt16(pRow["GXZT"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
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
