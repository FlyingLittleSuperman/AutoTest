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

	public class Fld_TJSYHGX
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string JSBSM="JSBSM";
		public const string YHBSM="YHBSM";
		public const string GXSJ="GXSJ";
		public const string BSM="BSM";
		#endregion
	}

	public class clsTJSYHGX:IEntity
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
		private long m_JSBSM;
		private long m_YHBSM;
		private DateTime m_GXSJ;

		public long JSBSM
		{
			get{ return m_JSBSM; }
			set{ m_JSBSM = value; }
		}
		public long YHBSM
		{
			get{ return m_YHBSM; }
			set{ m_YHBSM = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}

		#endregion
		public bool IsEquals(clsTJSYHGX obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.JSBSM != obj.JSBSM) bolResult = false;
			if (this.YHBSM != obj.YHBSM) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BSM != obj.BSM) bolResult = false;
			return bolResult;
		}

		public void Colne(clsTJSYHGX obj)
		{
			this.JSBSM=obj.JSBSM;
			this.YHBSM=obj.YHBSM;
			this.GXSJ=obj.GXSJ;
			this.BSM=obj.BSM;
		}

	}

	public class clsTJSYHGXSet:EntityBaseSet
	{
		public clsTJSYHGXSet()
		{
			m_TableName="T_JSYHGX";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
            m_SequenceName = "BDCDJ.SEQ_BSM";
			m_ClsName="clsTJSYHGXSet";
		}
		public static clsTJSYHGXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsTJSYHGXSet clsSet = new clsTJSYHGXSet(); //(clsTJSYHGXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsTJSYHGXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsTJSYHGX obj = (clsTJSYHGX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("JSBSM")) datarow["JSBSM"] = obj.JSBSM;
				if(datarow.Table.Columns.Contains("YHBSM")) datarow["YHBSM"] = obj.YHBSM;
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
			clsTJSYHGX obj = null;
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
					obj = new clsTJSYHGX();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="JSBSM")
								if (pRow.Table.Columns.Contains("JSBSM") && pRow["JSBSM"] != DBNull.Value) { obj.JSBSM = Convert.ToInt64(pRow["JSBSM"]); }
							if(strFldName.ToUpper()=="YHBSM")
								if (pRow.Table.Columns.Contains("YHBSM") && pRow["YHBSM"] != DBNull.Value) { obj.YHBSM = Convert.ToInt64(pRow["YHBSM"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("JSBSM") && pRow["JSBSM"] != DBNull.Value) { obj.JSBSM = Convert.ToInt64(pRow["JSBSM"]); }
						if (pRow.Table.Columns.Contains("YHBSM") && pRow["YHBSM"] != DBNull.Value) { obj.YHBSM = Convert.ToInt64(pRow["YHBSM"]); }
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
