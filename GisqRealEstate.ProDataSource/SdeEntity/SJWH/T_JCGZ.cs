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

	public class Fld_TJCGZ
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string JCGZMC="JCGZMC";
		public const string JCGZLX="JCGZLX";
		public const string JCJB="JCJB";
		public const string JCGZCXTJ="JCGZCXTJ";
		public const string BZ="BZ";
		public const string GXSJ="GXSJ";
		#endregion
	}

	public class clsTJCGZ:IEntity
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
		private string m_JCGZMC;
		private string m_JCGZLX;
		private string m_JCJB;
		private string m_JCGZCXTJ;
		private string m_BZ;
		private DateTime m_GXSJ;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public string JCGZMC
		{
			get{ return m_JCGZMC; }
			set{ m_JCGZMC = value; }
		}
		public string JCGZLX
		{
			get{ return m_JCGZLX; }
			set{ m_JCGZLX = value; }
		}
		public string JCJB
		{
			get{ return m_JCJB; }
			set{ m_JCJB = value; }
		}
		public string JCGZCXTJ
		{
			get{ return m_JCGZCXTJ; }
			set{ m_JCGZCXTJ = value; }
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
		public bool IsEquals(clsTJCGZ obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.JCGZMC != obj.JCGZMC) bolResult = false;
			if (this.JCGZLX != obj.JCGZLX) bolResult = false;
			if (this.JCJB != obj.JCJB) bolResult = false;
			if (this.JCGZCXTJ != obj.JCGZCXTJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsTJCGZ obj)
		{
			this.BSM=obj.BSM;
			this.JCGZMC=obj.JCGZMC;
			this.JCGZLX=obj.JCGZLX;
			this.JCJB=obj.JCJB;
			this.JCGZCXTJ=obj.JCGZCXTJ;
			this.BZ=obj.BZ;
			this.GXSJ=obj.GXSJ;
		}

	}

	public class clsTJCGZSet:EntityBaseSet
	{
		public clsTJCGZSet()
		{
			m_TableName="T_JCGZ";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
            m_SequenceName = "BDCDJ.SEQ_BSM";
			m_ClsName="clsTJCGZSet";
		}
		public static clsTJCGZSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsTJCGZSet clsSet = new clsTJCGZSet(); //(clsTJCGZSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsTJCGZSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsTJCGZ obj = (clsTJCGZ)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("JCGZMC")) datarow["JCGZMC"] = obj.JCGZMC;
				if(datarow.Table.Columns.Contains("JCGZLX")) datarow["JCGZLX"] = obj.JCGZLX;
				if(datarow.Table.Columns.Contains("JCJB")) datarow["JCJB"] = obj.JCJB;
				if(datarow.Table.Columns.Contains("JCGZCXTJ")) datarow["JCGZCXTJ"] = obj.JCGZCXTJ;
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
			clsTJCGZ obj = null;
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
					obj = new clsTJCGZ();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="JCGZMC")
								if (pRow.Table.Columns.Contains("JCGZMC") && pRow["JCGZMC"] != DBNull.Value) { obj.JCGZMC = Convert.ToString(pRow["JCGZMC"]); }
							if(strFldName.ToUpper()=="JCGZLX")
								if (pRow.Table.Columns.Contains("JCGZLX") && pRow["JCGZLX"] != DBNull.Value) { obj.JCGZLX = Convert.ToString(pRow["JCGZLX"]); }
							if(strFldName.ToUpper()=="JCJB")
								if (pRow.Table.Columns.Contains("JCJB") && pRow["JCJB"] != DBNull.Value) { obj.JCJB = Convert.ToString(pRow["JCJB"]); }
							if(strFldName.ToUpper()=="JCGZCXTJ")
								if (pRow.Table.Columns.Contains("JCGZCXTJ") && pRow["JCGZCXTJ"] != DBNull.Value) { obj.JCGZCXTJ = Convert.ToString(pRow["JCGZCXTJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("JCGZMC") && pRow["JCGZMC"] != DBNull.Value) { obj.JCGZMC = Convert.ToString(pRow["JCGZMC"]); }
						if (pRow.Table.Columns.Contains("JCGZLX") && pRow["JCGZLX"] != DBNull.Value) { obj.JCGZLX = Convert.ToString(pRow["JCGZLX"]); }
						if (pRow.Table.Columns.Contains("JCJB") && pRow["JCJB"] != DBNull.Value) { obj.JCJB = Convert.ToString(pRow["JCJB"]); }
						if (pRow.Table.Columns.Contains("JCGZCXTJ") && pRow["JCGZCXTJ"] != DBNull.Value) { obj.JCGZCXTJ = Convert.ToString(pRow["JCGZCXTJ"]); }
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
