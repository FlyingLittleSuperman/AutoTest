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

	public class Fld_TYHGL
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YHM="YHM";
		public const string XM="XM";
		public const string MM="MM";
		public const string BZ="BZ";
		public const string GXSJ="GXSJ";
		#endregion
	}

	public class clsTYHGL:IEntity
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
		private string m_YHM;
		private string m_XM;
		private string m_MM;
		private string m_BZ;
		private DateTime m_GXSJ;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public string YHM
		{
			get{ return m_YHM; }
			set{ m_YHM = value; }
		}
		public string XM
		{
			get{ return m_XM; }
			set{ m_XM = value; }
		}
		public string MM
		{
			get{ return m_MM; }
			set{ m_MM = value; }
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
		public bool IsEquals(clsTYHGL obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YHM != obj.YHM) bolResult = false;
			if (this.XM != obj.XM) bolResult = false;
			if (this.MM != obj.MM) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsTYHGL obj)
		{
			this.BSM=obj.BSM;
			this.YHM=obj.YHM;
			this.XM=obj.XM;
			this.MM=obj.MM;
			this.BZ=obj.BZ;
			this.GXSJ=obj.GXSJ;
		}

	}

	public class clsTYHGLSet:EntityBaseSet
	{
		public clsTYHGLSet()
		{
			m_TableName="T_YHGL";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
            m_SequenceName = "BDCDJ.SEQ_BSM";
			m_ClsName="clsTYHGLSet";
		}
		public static clsTYHGLSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsTYHGLSet clsSet = new clsTYHGLSet(); //(clsTYHGLSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsTYHGLSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsTYHGL obj = (clsTYHGL)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YHM")) datarow["YHM"] = obj.YHM;
				if(datarow.Table.Columns.Contains("XM")) datarow["XM"] = obj.XM;
				if(datarow.Table.Columns.Contains("MM")) datarow["MM"] = obj.MM;
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
			clsTYHGL obj = null;
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
					obj = new clsTYHGL();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YHM")
								if (pRow.Table.Columns.Contains("YHM") && pRow["YHM"] != DBNull.Value) { obj.YHM = Convert.ToString(pRow["YHM"]); }
							if(strFldName.ToUpper()=="XM")
								if (pRow.Table.Columns.Contains("XM") && pRow["XM"] != DBNull.Value) { obj.XM = Convert.ToString(pRow["XM"]); }
							if(strFldName.ToUpper()=="MM")
								if (pRow.Table.Columns.Contains("MM") && pRow["MM"] != DBNull.Value) { obj.MM = Convert.ToString(pRow["MM"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YHM") && pRow["YHM"] != DBNull.Value) { obj.YHM = Convert.ToString(pRow["YHM"]); }
						if (pRow.Table.Columns.Contains("XM") && pRow["XM"] != DBNull.Value) { obj.XM = Convert.ToString(pRow["XM"]); }
						if (pRow.Table.Columns.Contains("MM") && pRow["MM"] != DBNull.Value) { obj.MM = Convert.ToString(pRow["MM"]); }
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
