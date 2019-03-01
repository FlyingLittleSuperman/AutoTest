using System;
using System.Data;
using System.Text;
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

	public class Fld_XZSJ
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string RWBH="RWBH";
		public const string XZJLBM="XZJLBM";
		public const string XZJLGJZDM="XZJLGJZDM";
		public const string XZJLGJZDZ="XZJLGJZDZ";
		public const string GXSJ="GXSJ";
		public const string XZNR="XZNR";
		public const string BG_BB="BG_BB";
	    public const string BZ = "BZ";

	    #endregion
	}

	public class clsXZSJ:IEntity
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
		private string m_XZJLBM;
		private string m_XZJLGJZDM;
		private long m_XZJLGJZDZ;
		private DateTime m_GXSJ;
		private string m_XZNR;
		private long m_BG_BB;
	    public string BZ { get;  set; }

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
		public string XZJLBM
		{
			get{ return m_XZJLBM; }
			set{ m_XZJLBM = value; }
		}
		public string XZJLGJZDM
		{
			get{ return m_XZJLGJZDM; }
			set{ m_XZJLGJZDM = value; }
		}
		public long XZJLGJZDZ
		{
			get{ return m_XZJLGJZDZ; }
			set{ m_XZJLGJZDZ = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		public string XZNR
		{
			get{ return m_XZNR; }
			set{ m_XZNR = value; }
		}
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

		#endregion
		public bool IsEquals(clsXZSJ obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.RWBH != obj.RWBH) bolResult = false;
			if (this.XZJLBM != obj.XZJLBM) bolResult = false;
			if (this.XZJLGJZDM != obj.XZJLGJZDM) bolResult = false;
			if (this.XZJLGJZDZ != obj.XZJLGJZDZ) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.XZNR != obj.XZNR) bolResult = false;
		    if (this.BZ != obj.BZ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsXZSJ obj)
		{
			this.BSM=obj.BSM;
			this.RWBH=obj.RWBH;
			this.XZJLBM=obj.XZJLBM;
			this.XZJLGJZDM=obj.XZJLGJZDM;
			this.XZJLGJZDZ=obj.XZJLGJZDZ;
			this.GXSJ=obj.GXSJ;
			this.XZNR=obj.XZNR;
		    this.BZ = obj.BZ;
		}

	}

	public class clsXZSJSet:EntityBaseSet
	{
		public clsXZSJSet()
		{
			m_TableName="XZSJ";
			m_HisTableName="XZSJ_LS";
			m_PrimaryKeyName="BSM";
            m_SequenceName = "BDCDJ.SEQ_BSM";
			m_ClsName="clsXZSJSet";
		}
		public static clsXZSJSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsXZSJSet clsSet = new clsXZSJSet(); //(clsXZSJSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsXZSJSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsXZSJ obj = (clsXZSJ)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("RWBH")) datarow["RWBH"] = obj.RWBH;
				if(datarow.Table.Columns.Contains("XZJLBM")) datarow["XZJLBM"] = obj.XZJLBM;
				if(datarow.Table.Columns.Contains("XZJLGJZDM")) datarow["XZJLGJZDM"] = obj.XZJLGJZDM;
				if(datarow.Table.Columns.Contains("XZJLGJZDZ")) datarow["XZJLGJZDZ"] = obj.XZJLGJZDZ;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
                if (datarow.Table.Columns.Contains("XZNR")) datarow["XZNR"] =obj.XZNR ;
                if (datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
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
			clsXZSJ obj = null;
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
					obj = new clsXZSJ();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="RWBH")
								if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
							if(strFldName.ToUpper()=="XZJLBM")
								if (pRow.Table.Columns.Contains("XZJLBM") && pRow["XZJLBM"] != DBNull.Value) { obj.XZJLBM = Convert.ToString(pRow["XZJLBM"]); }
							if(strFldName.ToUpper()=="XZJLGJZDM")
								if (pRow.Table.Columns.Contains("XZJLGJZDM") && pRow["XZJLGJZDM"] != DBNull.Value) { obj.XZJLGJZDM = Convert.ToString(pRow["XZJLGJZDM"]); }
							if(strFldName.ToUpper()=="XZJLGJZDZ")
								if (pRow.Table.Columns.Contains("XZJLGJZDZ") && pRow["XZJLGJZDZ"] != DBNull.Value) { obj.XZJLGJZDZ = Convert.ToInt64(pRow["XZJLGJZDZ"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="XZNR")
								if (pRow.Table.Columns.Contains("XZNR") && pRow["XZNR"] != DBNull.Value) { obj.XZNR = Convert.ToString(pRow["XZNR"]); }
                            if (strFldName.ToUpper() == "BZ")
                                if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
						if (pRow.Table.Columns.Contains("XZJLBM") && pRow["XZJLBM"] != DBNull.Value) { obj.XZJLBM = Convert.ToString(pRow["XZJLBM"]); }
						if (pRow.Table.Columns.Contains("XZJLGJZDM") && pRow["XZJLGJZDM"] != DBNull.Value) { obj.XZJLGJZDM = Convert.ToString(pRow["XZJLGJZDM"]); }
						if (pRow.Table.Columns.Contains("XZJLGJZDZ") && pRow["XZJLGJZDZ"] != DBNull.Value) { obj.XZJLGJZDZ = Convert.ToInt64(pRow["XZJLGJZDZ"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("XZNR") && pRow["XZNR"] != DBNull.Value) { obj.XZNR = Convert.ToString(pRow["XZNR"]); }
                        if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
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
