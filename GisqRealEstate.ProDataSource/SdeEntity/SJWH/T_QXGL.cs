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

	public class Fld_TQXGL
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string JSBSM="JSBSM";
		public const string QXDM="QXDM";
		public const string BZ="BZ";
		public const string GXSJ="GXSJ";
		public const string QXMC="QXMC";
		public const string QXLX="QXLX";
		public const string QXFL="QXFL";
		#endregion
	}

	public class clsTQXGL:IEntity
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
		private string m_QXDM;
		private string m_BZ;
		private DateTime m_GXSJ;
		private string m_QXMC;
		private int m_QXLX;
		private string m_QXFL;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public long JSBSM
		{
			get{ return m_JSBSM; }
			set{ m_JSBSM = value; }
		}
		public string QXDM
		{
			get{ return m_QXDM; }
			set{ m_QXDM = value; }
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
		public string QXMC
		{
			get{ return m_QXMC; }
			set{ m_QXMC = value; }
		}
		public int QXLX
		{
			get{ return m_QXLX; }
			set{ m_QXLX = value; }
		}
		public string QXFL
		{
			get{ return m_QXFL; }
			set{ m_QXFL = value; }
		}

		#endregion
		public bool IsEquals(clsTQXGL obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.JSBSM != obj.JSBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.QXMC != obj.QXMC) bolResult = false;
			if (this.QXLX != obj.QXLX) bolResult = false;
			if (this.QXFL != obj.QXFL) bolResult = false;
			return bolResult;
		}

		public void Colne(clsTQXGL obj)
		{
			this.BSM=obj.BSM;
			this.JSBSM=obj.JSBSM;
			this.QXDM=obj.QXDM;
			this.BZ=obj.BZ;
			this.GXSJ=obj.GXSJ;
			this.QXMC=obj.QXMC;
			this.QXLX=obj.QXLX;
			this.QXFL=obj.QXFL;
		}

	}

	public class clsTQXGLSet:EntityBaseSet
	{
		public clsTQXGLSet()
		{
			m_TableName="T_QXGL";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
            m_SequenceName = "BDCDJ.SEQ_BSM";
			m_ClsName="clsTQXGLSet";
		}
		public static clsTQXGLSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsTQXGLSet clsSet = new clsTQXGLSet(); //(clsTQXGLSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsTQXGLSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsTQXGL obj = (clsTQXGL)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("JSBSM")) datarow["JSBSM"] = obj.JSBSM;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("QXMC")) datarow["QXMC"] = obj.QXMC;
				if(datarow.Table.Columns.Contains("QXLX")) datarow["QXLX"] = obj.QXLX;
				if(datarow.Table.Columns.Contains("QXFL")) datarow["QXFL"] = obj.QXFL;
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
			clsTQXGL obj = null;
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
					obj = new clsTQXGL();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="JSBSM")
								if (pRow.Table.Columns.Contains("JSBSM") && pRow["JSBSM"] != DBNull.Value) { obj.JSBSM = Convert.ToInt64(pRow["JSBSM"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToString(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="QXMC")
								if (pRow.Table.Columns.Contains("QXMC") && pRow["QXMC"] != DBNull.Value) { obj.QXMC = Convert.ToString(pRow["QXMC"]); }
							if(strFldName.ToUpper()=="QXLX")
								if (pRow.Table.Columns.Contains("QXLX") && pRow["QXLX"] != DBNull.Value) { obj.QXLX = Convert.ToInt16(pRow["QXLX"]); }
							if(strFldName.ToUpper()=="QXFL")
								if (pRow.Table.Columns.Contains("QXFL") && pRow["QXFL"] != DBNull.Value) { obj.QXFL = Convert.ToString(pRow["QXFL"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("JSBSM") && pRow["JSBSM"] != DBNull.Value) { obj.JSBSM = Convert.ToInt64(pRow["JSBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToString(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("QXMC") && pRow["QXMC"] != DBNull.Value) { obj.QXMC = Convert.ToString(pRow["QXMC"]); }
						if (pRow.Table.Columns.Contains("QXLX") && pRow["QXLX"] != DBNull.Value) { obj.QXLX = Convert.ToInt16(pRow["QXLX"]); }
						if (pRow.Table.Columns.Contains("QXFL") && pRow["QXFL"] != DBNull.Value) { obj.QXFL = Convert.ToString(pRow["QXFL"]); }
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
