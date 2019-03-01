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

	public class Fld_YYDJDYGX
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string DYBSM="DYBSM";
		public const string BDCDYLX="BDCDYLX";
		public const string YYDJBSM="YYDJBSM";
		public const string YYDJZXBSM="YYDJZXBSM";
		public const string DYBM="DYBM";
		public const string QLBM="QLBM";
		public const string QLBSM="QLBSM";
		public const string BDCDYH="BDCDYH";
		public const string CQZH="CQZH";
		public const string ZL="ZL";
		public const string BZ="BZ";
		public const string GXSJ="GXSJ";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string YZXBSM="YZXBSM";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		#endregion
	}

	public class clsYYDJDYGX:IEntity
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
		private string m_YWH;
		private long m_DYBSM;
		private string m_BDCDYLX;
		private long m_YYDJBSM;
		private long m_YYDJZXBSM;
		private string m_DYBM;
		private string m_QLBM;
		private long m_QLBSM;
		private string m_BDCDYH;
		private string m_CQZH;
		private string m_ZL;
		private string m_BZ;
		private DateTime m_GXSJ;
		private long m_QXDM;
		private long m_REV_;
		private long m_YZXBSM;
		private string m_YXTBM;
		private string m_YXTBSM;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public string YWH
		{
			get{ return m_YWH; }
			set{ m_YWH = value; }
		}
		public long DYBSM
		{
			get{ return m_DYBSM; }
			set{ m_DYBSM = value; }
		}
		public string BDCDYLX
		{
			get{ return m_BDCDYLX; }
			set{ m_BDCDYLX = value; }
		}
		public long YYDJBSM
		{
			get{ return m_YYDJBSM; }
			set{ m_YYDJBSM = value; }
		}
		public long YYDJZXBSM
		{
			get{ return m_YYDJZXBSM; }
			set{ m_YYDJZXBSM = value; }
		}
		public string DYBM
		{
			get{ return m_DYBM; }
			set{ m_DYBM = value; }
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
		public string BDCDYH
		{
			get{ return m_BDCDYH; }
			set{ m_BDCDYH = value; }
		}
		public string CQZH
		{
			get{ return m_CQZH; }
			set{ m_CQZH = value; }
		}
		public string ZL
		{
			get{ return m_ZL; }
			set{ m_ZL = value; }
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
		public long QXDM
		{
			get{ return m_QXDM; }
			set{ m_QXDM = value; }
		}
		public long REV_
		{
			get{ return m_REV_; }
			set{ m_REV_ = value; }
		}
		public long YZXBSM
		{
			get{ return m_YZXBSM; }
			set{ m_YZXBSM = value; }
		}
		public string YXTBM
		{
			get{ return m_YXTBM; }
			set{ m_YXTBM = value; }
		}
		public string YXTBSM
		{
			get{ return m_YXTBSM; }
			set{ m_YXTBSM = value; }
		}

		#endregion
		public bool IsEquals(clsYYDJDYGX obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.DYBSM != obj.DYBSM) bolResult = false;
			if (this.BDCDYLX != obj.BDCDYLX) bolResult = false;
			if (this.YYDJBSM != obj.YYDJBSM) bolResult = false;
			if (this.YYDJZXBSM != obj.YYDJZXBSM) bolResult = false;
			if (this.DYBM != obj.DYBM) bolResult = false;
			if (this.QLBM != obj.QLBM) bolResult = false;
			if (this.QLBSM != obj.QLBSM) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.CQZH != obj.CQZH) bolResult = false;
			if (this.ZL != obj.ZL) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.YZXBSM != obj.YZXBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			return bolResult;
		}

		public void Colne(clsYYDJDYGX obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.DYBSM=obj.DYBSM;
			this.BDCDYLX=obj.BDCDYLX;
			this.YYDJBSM=obj.YYDJBSM;
			this.YYDJZXBSM=obj.YYDJZXBSM;
			this.DYBM=obj.DYBM;
			this.QLBM=obj.QLBM;
			this.QLBSM=obj.QLBSM;
			this.BDCDYH=obj.BDCDYH;
			this.CQZH=obj.CQZH;
			this.ZL=obj.ZL;
			this.BZ=obj.BZ;
			this.GXSJ=obj.GXSJ;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.YZXBSM=obj.YZXBSM;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
		}

	}

	public class clsYYDJDYGXSet:EntityBaseSet
	{
		public clsYYDJDYGXSet()
		{
			m_TableName="BDCDJ.YYDJ_DYGX";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsYYDJDYGXSet";
		}
		public static clsYYDJDYGXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsYYDJDYGXSet clsSet = new clsYYDJDYGXSet(); //(clsYYDJDYGXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsYYDJDYGXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsYYDJDYGX obj = (clsYYDJDYGX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("DYBSM")) datarow["DYBSM"] = obj.DYBSM;
				if(datarow.Table.Columns.Contains("BDCDYLX")) datarow["BDCDYLX"] = obj.BDCDYLX;
				if(datarow.Table.Columns.Contains("YYDJBSM")) datarow["YYDJBSM"] = obj.YYDJBSM;
				if(datarow.Table.Columns.Contains("YYDJZXBSM")) datarow["YYDJZXBSM"] = obj.YYDJZXBSM;
				if(datarow.Table.Columns.Contains("DYBM")) datarow["DYBM"] = obj.DYBM;
				if(datarow.Table.Columns.Contains("QLBM")) datarow["QLBM"] = obj.QLBM;
				if(datarow.Table.Columns.Contains("QLBSM")) datarow["QLBSM"] = obj.QLBSM;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("CQZH")) datarow["CQZH"] = obj.CQZH;
				if(datarow.Table.Columns.Contains("ZL")) datarow["ZL"] = obj.ZL;
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("YZXBSM")) datarow["YZXBSM"] = obj.YZXBSM;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
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
			clsYYDJDYGX obj = null;
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
					obj = new clsYYDJDYGX();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="DYBSM")
								if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
							if(strFldName.ToUpper()=="BDCDYLX")
								if (pRow.Table.Columns.Contains("BDCDYLX") && pRow["BDCDYLX"] != DBNull.Value) { obj.BDCDYLX = Convert.ToString(pRow["BDCDYLX"]); }
							if(strFldName.ToUpper()=="YYDJBSM")
								if (pRow.Table.Columns.Contains("YYDJBSM") && pRow["YYDJBSM"] != DBNull.Value) { obj.YYDJBSM = Convert.ToInt64(pRow["YYDJBSM"]); }
							if(strFldName.ToUpper()=="YYDJZXBSM")
								if (pRow.Table.Columns.Contains("YYDJZXBSM") && pRow["YYDJZXBSM"] != DBNull.Value) { obj.YYDJZXBSM = Convert.ToInt64(pRow["YYDJZXBSM"]); }
							if(strFldName.ToUpper()=="DYBM")
								if (pRow.Table.Columns.Contains("DYBM") && pRow["DYBM"] != DBNull.Value) { obj.DYBM = Convert.ToString(pRow["DYBM"]); }
							if(strFldName.ToUpper()=="QLBM")
								if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
							if(strFldName.ToUpper()=="QLBSM")
								if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
							if(strFldName.ToUpper()=="BDCDYH")
								if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
							if(strFldName.ToUpper()=="CQZH")
								if (pRow.Table.Columns.Contains("CQZH") && pRow["CQZH"] != DBNull.Value) { obj.CQZH = Convert.ToString(pRow["CQZH"]); }
							if(strFldName.ToUpper()=="ZL")
								if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="YZXBSM")
								if (pRow.Table.Columns.Contains("YZXBSM") && pRow["YZXBSM"] != DBNull.Value) { obj.YZXBSM = Convert.ToInt64(pRow["YZXBSM"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
						if (pRow.Table.Columns.Contains("BDCDYLX") && pRow["BDCDYLX"] != DBNull.Value) { obj.BDCDYLX = Convert.ToString(pRow["BDCDYLX"]); }
						if (pRow.Table.Columns.Contains("YYDJBSM") && pRow["YYDJBSM"] != DBNull.Value) { obj.YYDJBSM = Convert.ToInt64(pRow["YYDJBSM"]); }
						if (pRow.Table.Columns.Contains("YYDJZXBSM") && pRow["YYDJZXBSM"] != DBNull.Value) { obj.YYDJZXBSM = Convert.ToInt64(pRow["YYDJZXBSM"]); }
						if (pRow.Table.Columns.Contains("DYBM") && pRow["DYBM"] != DBNull.Value) { obj.DYBM = Convert.ToString(pRow["DYBM"]); }
						if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
						if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("CQZH") && pRow["CQZH"] != DBNull.Value) { obj.CQZH = Convert.ToString(pRow["CQZH"]); }
						if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("YZXBSM") && pRow["YZXBSM"] != DBNull.Value) { obj.YZXBSM = Convert.ToInt64(pRow["YZXBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
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
