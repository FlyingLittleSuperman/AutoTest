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

	public class Fld_SP
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string RWBH="RWBH";
		public const string JBR="JBR";
		public const string JBSJ="JBSJ";
		public const string JBYJ="JBYJ";
		public const string CSR="CSR";
		public const string CSSJ="CSSJ";
		public const string CSYJ="CSYJ";
		public const string FSR="FSR";
		public const string FSSJ="FSSJ";
		public const string FSYJ="FSYJ";
		public const string HDR="HDR";
		public const string HDSJ="HDSJ";
		public const string HSYJ="HSYJ";
		public const string DBR="DBR";
		public const string DBSJ="DBSJ";
		public const string DBNR="DBNR";
		public const string QSZT="QSZT";
		public const string GXSJ="GXSJ";
		#endregion
	}

	public class clsSP:IEntity
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
		private string m_JBR;
		private DateTime m_JBSJ;
		private string m_JBYJ;
		private string m_CSR;
		private DateTime m_CSSJ;
		private string m_CSYJ;
		private string m_FSR;
		private DateTime m_FSSJ;
		private string m_FSYJ;
		private string m_HDR;
		private DateTime m_HDSJ;
		private string m_HSYJ;
		private string m_DBR;
		private DateTime m_DBSJ;
		private string m_DBNR;
		private int m_QSZT;
		private DateTime m_GXSJ;

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
		public string JBR
		{
			get{ return m_JBR; }
			set{ m_JBR = value; }
		}
		public DateTime JBSJ
		{
			get{ return m_JBSJ; }
			set{ m_JBSJ = value; }
		}
		public string JBYJ
		{
			get{ return m_JBYJ; }
			set{ m_JBYJ = value; }
		}
		public string CSR
		{
			get{ return m_CSR; }
			set{ m_CSR = value; }
		}
		public DateTime CSSJ
		{
			get{ return m_CSSJ; }
			set{ m_CSSJ = value; }
		}
		public string CSYJ
		{
			get{ return m_CSYJ; }
			set{ m_CSYJ = value; }
		}
		public string FSR
		{
			get{ return m_FSR; }
			set{ m_FSR = value; }
		}
		public DateTime FSSJ
		{
			get{ return m_FSSJ; }
			set{ m_FSSJ = value; }
		}
		public string FSYJ
		{
			get{ return m_FSYJ; }
			set{ m_FSYJ = value; }
		}
		public string HDR
		{
			get{ return m_HDR; }
			set{ m_HDR = value; }
		}
		public DateTime HDSJ
		{
			get{ return m_HDSJ; }
			set{ m_HDSJ = value; }
		}
		public string HSYJ
		{
			get{ return m_HSYJ; }
			set{ m_HSYJ = value; }
		}
		public string DBR
		{
			get{ return m_DBR; }
			set{ m_DBR = value; }
		}
		public DateTime DBSJ
		{
			get{ return m_DBSJ; }
			set{ m_DBSJ = value; }
		}
		public string DBNR
		{
			get{ return m_DBNR; }
			set{ m_DBNR = value; }
		}
		public int QSZT
		{
			get{ return m_QSZT; }
			set{ m_QSZT = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}

		#endregion
		public bool IsEquals(clsSP obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.RWBH != obj.RWBH) bolResult = false;
			if (this.JBR != obj.JBR) bolResult = false;
			if (this.JBSJ != obj.JBSJ) bolResult = false;
			if (this.JBYJ != obj.JBYJ) bolResult = false;
			if (this.CSR != obj.CSR) bolResult = false;
			if (this.CSSJ != obj.CSSJ) bolResult = false;
			if (this.CSYJ != obj.CSYJ) bolResult = false;
			if (this.FSR != obj.FSR) bolResult = false;
			if (this.FSSJ != obj.FSSJ) bolResult = false;
			if (this.FSYJ != obj.FSYJ) bolResult = false;
			if (this.HDR != obj.HDR) bolResult = false;
			if (this.HDSJ != obj.HDSJ) bolResult = false;
			if (this.HSYJ != obj.HSYJ) bolResult = false;
			if (this.DBR != obj.DBR) bolResult = false;
			if (this.DBSJ != obj.DBSJ) bolResult = false;
			if (this.DBNR != obj.DBNR) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsSP obj)
		{
			this.BSM=obj.BSM;
			this.RWBH=obj.RWBH;
			this.JBR=obj.JBR;
			this.JBSJ=obj.JBSJ;
			this.JBYJ=obj.JBYJ;
			this.CSR=obj.CSR;
			this.CSSJ=obj.CSSJ;
			this.CSYJ=obj.CSYJ;
			this.FSR=obj.FSR;
			this.FSSJ=obj.FSSJ;
			this.FSYJ=obj.FSYJ;
			this.HDR=obj.HDR;
			this.HDSJ=obj.HDSJ;
			this.HSYJ=obj.HSYJ;
			this.DBR=obj.DBR;
			this.DBSJ=obj.DBSJ;
			this.DBNR=obj.DBNR;
			this.QSZT=obj.QSZT;
			this.GXSJ=obj.GXSJ;
		}

	}

	public class clsSPSet:EntityBaseSet
	{
		public clsSPSet()
		{
			m_TableName="SP";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
            m_SequenceName = "BDCDJ.SEQ_BSM";
			m_ClsName="clsSPSet";
		}
		public static clsSPSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsSPSet clsSet = new clsSPSet(); //(clsSPSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsSPSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsSP obj = (clsSP)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("RWBH")) datarow["RWBH"] = obj.RWBH;
				if(datarow.Table.Columns.Contains("JBR")) datarow["JBR"] = obj.JBR;
				if (obj.JBSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("JBSJ")) datarow["JBSJ"] = obj.JBSJ;
				}
				if(datarow.Table.Columns.Contains("JBYJ")) datarow["JBYJ"] = obj.JBYJ;
				if(datarow.Table.Columns.Contains("CSR")) datarow["CSR"] = obj.CSR;
				if (obj.CSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("CSSJ")) datarow["CSSJ"] = obj.CSSJ;
				}
				if(datarow.Table.Columns.Contains("CSYJ")) datarow["CSYJ"] = obj.CSYJ;
				if(datarow.Table.Columns.Contains("FSR")) datarow["FSR"] = obj.FSR;
				if (obj.FSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("FSSJ")) datarow["FSSJ"] = obj.FSSJ;
				}
				if(datarow.Table.Columns.Contains("FSYJ")) datarow["FSYJ"] = obj.FSYJ;
				if(datarow.Table.Columns.Contains("HDR")) datarow["HDR"] = obj.HDR;
				if (obj.HDSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("HDSJ")) datarow["HDSJ"] = obj.HDSJ;
				}
				if(datarow.Table.Columns.Contains("HSYJ")) datarow["HSYJ"] = obj.HSYJ;
				if(datarow.Table.Columns.Contains("DBR")) datarow["DBR"] = obj.DBR;
				if (obj.DBSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("DBSJ")) datarow["DBSJ"] = obj.DBSJ;
				}
				if(datarow.Table.Columns.Contains("DBNR")) datarow["DBNR"] = obj.DBNR;
				if(datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
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
			clsSP obj = null;
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
					obj = new clsSP();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="RWBH")
								if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
							if(strFldName.ToUpper()=="JBR")
								if (pRow.Table.Columns.Contains("JBR") && pRow["JBR"] != DBNull.Value) { obj.JBR = Convert.ToString(pRow["JBR"]); }
							if(strFldName.ToUpper()=="JBSJ")
								if (pRow.Table.Columns.Contains("JBSJ") && pRow["JBSJ"] != DBNull.Value) { obj.JBSJ = Convert.ToDateTime(pRow["JBSJ"]); }
							if(strFldName.ToUpper()=="JBYJ")
								if (pRow.Table.Columns.Contains("JBYJ") && pRow["JBYJ"] != DBNull.Value) { obj.JBYJ = Convert.ToString(pRow["JBYJ"]); }
							if(strFldName.ToUpper()=="CSR")
								if (pRow.Table.Columns.Contains("CSR") && pRow["CSR"] != DBNull.Value) { obj.CSR = Convert.ToString(pRow["CSR"]); }
							if(strFldName.ToUpper()=="CSSJ")
								if (pRow.Table.Columns.Contains("CSSJ") && pRow["CSSJ"] != DBNull.Value) { obj.CSSJ = Convert.ToDateTime(pRow["CSSJ"]); }
							if(strFldName.ToUpper()=="CSYJ")
								if (pRow.Table.Columns.Contains("CSYJ") && pRow["CSYJ"] != DBNull.Value) { obj.CSYJ = Convert.ToString(pRow["CSYJ"]); }
							if(strFldName.ToUpper()=="FSR")
								if (pRow.Table.Columns.Contains("FSR") && pRow["FSR"] != DBNull.Value) { obj.FSR = Convert.ToString(pRow["FSR"]); }
							if(strFldName.ToUpper()=="FSSJ")
								if (pRow.Table.Columns.Contains("FSSJ") && pRow["FSSJ"] != DBNull.Value) { obj.FSSJ = Convert.ToDateTime(pRow["FSSJ"]); }
							if(strFldName.ToUpper()=="FSYJ")
								if (pRow.Table.Columns.Contains("FSYJ") && pRow["FSYJ"] != DBNull.Value) { obj.FSYJ = Convert.ToString(pRow["FSYJ"]); }
							if(strFldName.ToUpper()=="HDR")
								if (pRow.Table.Columns.Contains("HDR") && pRow["HDR"] != DBNull.Value) { obj.HDR = Convert.ToString(pRow["HDR"]); }
							if(strFldName.ToUpper()=="HDSJ")
								if (pRow.Table.Columns.Contains("HDSJ") && pRow["HDSJ"] != DBNull.Value) { obj.HDSJ = Convert.ToDateTime(pRow["HDSJ"]); }
							if(strFldName.ToUpper()=="HSYJ")
								if (pRow.Table.Columns.Contains("HSYJ") && pRow["HSYJ"] != DBNull.Value) { obj.HSYJ = Convert.ToString(pRow["HSYJ"]); }
							if(strFldName.ToUpper()=="DBR")
								if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
							if(strFldName.ToUpper()=="DBSJ")
								if (pRow.Table.Columns.Contains("DBSJ") && pRow["DBSJ"] != DBNull.Value) { obj.DBSJ = Convert.ToDateTime(pRow["DBSJ"]); }
							if(strFldName.ToUpper()=="DBNR")
								if (pRow.Table.Columns.Contains("DBNR") && pRow["DBNR"] != DBNull.Value) { obj.DBNR = Convert.ToString(pRow["DBNR"]); }
							if(strFldName.ToUpper()=="QSZT")
								if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToInt16(pRow["QSZT"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
						if (pRow.Table.Columns.Contains("JBR") && pRow["JBR"] != DBNull.Value) { obj.JBR = Convert.ToString(pRow["JBR"]); }
						if (pRow.Table.Columns.Contains("JBSJ") && pRow["JBSJ"] != DBNull.Value) { obj.JBSJ = Convert.ToDateTime(pRow["JBSJ"]); }
						if (pRow.Table.Columns.Contains("JBYJ") && pRow["JBYJ"] != DBNull.Value) { obj.JBYJ = Convert.ToString(pRow["JBYJ"]); }
						if (pRow.Table.Columns.Contains("CSR") && pRow["CSR"] != DBNull.Value) { obj.CSR = Convert.ToString(pRow["CSR"]); }
						if (pRow.Table.Columns.Contains("CSSJ") && pRow["CSSJ"] != DBNull.Value) { obj.CSSJ = Convert.ToDateTime(pRow["CSSJ"]); }
						if (pRow.Table.Columns.Contains("CSYJ") && pRow["CSYJ"] != DBNull.Value) { obj.CSYJ = Convert.ToString(pRow["CSYJ"]); }
						if (pRow.Table.Columns.Contains("FSR") && pRow["FSR"] != DBNull.Value) { obj.FSR = Convert.ToString(pRow["FSR"]); }
						if (pRow.Table.Columns.Contains("FSSJ") && pRow["FSSJ"] != DBNull.Value) { obj.FSSJ = Convert.ToDateTime(pRow["FSSJ"]); }
						if (pRow.Table.Columns.Contains("FSYJ") && pRow["FSYJ"] != DBNull.Value) { obj.FSYJ = Convert.ToString(pRow["FSYJ"]); }
						if (pRow.Table.Columns.Contains("HDR") && pRow["HDR"] != DBNull.Value) { obj.HDR = Convert.ToString(pRow["HDR"]); }
						if (pRow.Table.Columns.Contains("HDSJ") && pRow["HDSJ"] != DBNull.Value) { obj.HDSJ = Convert.ToDateTime(pRow["HDSJ"]); }
						if (pRow.Table.Columns.Contains("HSYJ") && pRow["HSYJ"] != DBNull.Value) { obj.HSYJ = Convert.ToString(pRow["HSYJ"]); }
						if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
						if (pRow.Table.Columns.Contains("DBSJ") && pRow["DBSJ"] != DBNull.Value) { obj.DBSJ = Convert.ToDateTime(pRow["DBSJ"]); }
						if (pRow.Table.Columns.Contains("DBNR") && pRow["DBNR"] != DBNull.Value) { obj.DBNR = Convert.ToString(pRow["DBNR"]); }
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToInt16(pRow["QSZT"]); }
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
