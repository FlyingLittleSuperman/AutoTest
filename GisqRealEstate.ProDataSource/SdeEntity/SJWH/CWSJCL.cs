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

	public class Fld_CWSJCL
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string RWBH="RWBH";
		public const string SCBM="SCBM";
		public const string SCJLGJZDM="SCJLGJZDM";
        public const string BGLBZDZ = "BGLBZDZ";
		public const string SCJLGJZMZ="SCJLGJZDZ";
		public const string GXSJ="GXSJ";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsCWSJCL:IEntity
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
		private string m_SCBM;
		private string m_SCJLGJZDM;
        private long m_BGLBZDZ;
		private long m_SCJLGJZDZ;
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
		public string SCBM
		{
			get{ return m_SCBM; }
			set{ m_SCBM = value; }
		}
		public string SCJLGJZDM
		{
			get{ return m_SCJLGJZDM; }
			set{ m_SCJLGJZDM = value; }
		}
		public long SCJLGJZDZ
		{
			get{ return m_SCJLGJZDZ; }
			set{ m_SCJLGJZDZ = value; }
		}
        public long BGLBZDZ
        {
            get { return m_BGLBZDZ; }
            set { m_BGLBZDZ = value; }
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
		public bool IsEquals(clsCWSJCL obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.RWBH != obj.RWBH) bolResult = false;
			if (this.SCBM != obj.SCBM) bolResult = false;
			if (this.SCJLGJZDM != obj.SCJLGJZDM) bolResult = false;
			if (this.SCJLGJZDZ != obj.SCJLGJZDZ) bolResult = false;
            if (this.BGLBZDZ != obj.BGLBZDZ) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsCWSJCL obj)
		{
			this.BSM=obj.BSM;
			this.RWBH=obj.RWBH;
			this.SCBM=obj.SCBM;
			this.SCJLGJZDM=obj.SCJLGJZDM;
			this.SCJLGJZDZ=obj.SCJLGJZDZ;
            this.BGLBZDZ = obj.BGLBZDZ;
			this.GXSJ=obj.GXSJ;
		}

	}

	public class clsCWSJCLSet:EntityBaseSet
	{
		public clsCWSJCLSet()
		{
			m_TableName="CWSJCL";
			m_HisTableName="CWSJCL_LS";
			m_PrimaryKeyName="BSM";
            m_SequenceName = "BDCDJ.SEQ_BSM";
			m_ClsName="clsCWSJCLSet";
		}
		public static clsCWSJCLSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsCWSJCLSet clsSet = new clsCWSJCLSet(); //(clsCWSJCLSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsCWSJCLSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsCWSJCL obj = (clsCWSJCL)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("RWBH")) datarow["RWBH"] = obj.RWBH;
				if(datarow.Table.Columns.Contains("SCBM")) datarow["SCBM"] = obj.SCBM;
                //被关联表字段,户合并的时候用到
                if (datarow.Table.Columns.Contains("BGLBZDZ")) datarow["BGLBZDZ"] = obj.BGLBZDZ;
				if(datarow.Table.Columns.Contains("SCJLGJZDM")) datarow["SCJLGJZDM"] = obj.SCJLGJZDM;
				if(datarow.Table.Columns.Contains("SCJLGJZDZ")) datarow["SCJLGJZDZ"] = obj.SCJLGJZDZ;
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
			clsCWSJCL obj = null;
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
					obj = new clsCWSJCL();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="RWBH")
								if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
							if(strFldName.ToUpper()=="SCBM")
								if (pRow.Table.Columns.Contains("SCBM") && pRow["SCBM"] != DBNull.Value) { obj.SCBM = Convert.ToString(pRow["SCBM"]); }
							if(strFldName.ToUpper()=="SCJLGJZDM")
								if (pRow.Table.Columns.Contains("SCJLGJZDM") && pRow["SCJLGJZDM"] != DBNull.Value) { obj.SCJLGJZDM = Convert.ToString(pRow["SCJLGJZDM"]); }
                            if (strFldName.ToUpper() == "SCJLGJZDZ")
                                if (pRow.Table.Columns.Contains("SCJLGJZDZ") && pRow["SCJLGJZDZ"] != DBNull.Value) { obj.SCJLGJZDZ = Convert.ToInt64(pRow["SCJLGJZDZ"]); }
                            //被关联表字段,户合并的时候用到
                            if (strFldName.ToUpper() == "BGLBZDZ")
                                if (pRow.Table.Columns.Contains("BGLBZDZ") && pRow["BGLBZDZ"] != DBNull.Value) { obj.BGLBZDZ = Convert.ToInt64(pRow["BGLBZDZ"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
						if (pRow.Table.Columns.Contains("SCBM") && pRow["SCBM"] != DBNull.Value) { obj.SCBM = Convert.ToString(pRow["SCBM"]); }
						if (pRow.Table.Columns.Contains("SCJLGJZDM") && pRow["SCJLGJZDM"] != DBNull.Value) { obj.SCJLGJZDM = Convert.ToString(pRow["SCJLGJZDM"]); }
                        if (pRow.Table.Columns.Contains("SCJLGJZDZ") && pRow["SCJLGJZDZ"] != DBNull.Value) { obj.SCJLGJZDZ = Convert.ToInt64(pRow["SCJLGJZDZ"]); }
                        //被关联表字段,户合并的时候用到
                        if (pRow.Table.Columns.Contains("BGLBZDZ") && pRow["BGLBZDZ"] != DBNull.Value) { obj.BGLBZDZ = Convert.ToInt64(pRow["BGLBZDZ"]); }
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
