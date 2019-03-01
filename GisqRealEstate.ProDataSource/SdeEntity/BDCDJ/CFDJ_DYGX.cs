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

	public class Fld_CFDJDYGX
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string DYBSM="DYBSM";
		public const string BDCDYLX="BDCDYLX";
		public const string CFDJBSM="CFDJBSM";
		public const string CFDJZXBSM="CFDJZXBSM";
		public const string DYBM="DYBM";
		public const string QLBM="QLBM";
		public const string QLBSM="QLBSM";
		public const string BDCDYH="BDCDYH";
		public const string CQZH="CQZH";
		public const string ZL="ZL";
		public const string QXDM="QXDM";
		public const string YXTBSM="YXTBSM";
		public const string BZ_FH_NM="BZ_FH_NM";
		public const string BZ_FW_NM="BZ_FW_NM";
		public const string YXTBM="YXTBM";
		public const string REV_="REV_";
		public const string BZ_ZDQLR_ID="BZ_ZDQLR_ID";
		public const string BZ_CF_ID="BZ_CF_ID";
		public const string CFSXH="CFSXH";
		public const string CFLX="CFLX";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string YJFBSM="YJFBSM";
		public const string BZ_RIGHT_ID="BZ_RIGHT_ID";
		public const string BZ_QSZT="BZ_QSZT";
		public const string FJ2="FJ2";
		public const string BZ_编号="BZ_编号";
		public const string BZ_ID="BZ_ID";
		#endregion
	}

	public class clsCFDJDYGX:IEntity
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
		private long m_CFDJBSM;
		private long m_CFDJZXBSM;
		private string m_DYBM;
		private string m_QLBM;
		private long m_QLBSM;
		private string m_BDCDYH;
		private string m_CQZH;
		private string m_ZL;
		private long m_QXDM;
		private string m_YXTBSM;
		private string m_YXTBM;
		private long m_REV_;
		private string m_CFSXH;
		private string m_CFLX;
		private DateTime m_GXSJ;
		private string m_BZ;

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
		public long CFDJBSM
		{
			get{ return m_CFDJBSM; }
			set{ m_CFDJBSM = value; }
		}
		public long CFDJZXBSM
		{
			get{ return m_CFDJZXBSM; }
			set{ m_CFDJZXBSM = value; }
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
		public long QXDM
		{
			get{ return m_QXDM; }
			set{ m_QXDM = value; }
		}
		public string YXTBSM
		{
			get{ return m_YXTBSM; }
			set{ m_YXTBSM = value; }
		}
		public string YXTBM
		{
			get{ return m_YXTBM; }
			set{ m_YXTBM = value; }
		}
		public long REV_
		{
			get{ return m_REV_; }
			set{ m_REV_ = value; }
		}
		public string CFSXH
		{
			get{ return m_CFSXH; }
			set{ m_CFSXH = value; }
		}
		public string CFLX
		{
			get{ return m_CFLX; }
			set{ m_CFLX = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		public string BZ
		{
			get{ return m_BZ; }
			set{ m_BZ = value; }
		}

		#endregion
		public bool IsEquals(clsCFDJDYGX obj)
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
			if (this.CFDJBSM != obj.CFDJBSM) bolResult = false;
			if (this.CFDJZXBSM != obj.CFDJZXBSM) bolResult = false;
			if (this.DYBM != obj.DYBM) bolResult = false;
			if (this.QLBM != obj.QLBM) bolResult = false;
			if (this.QLBSM != obj.QLBSM) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.CQZH != obj.CQZH) bolResult = false;
			if (this.ZL != obj.ZL) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.CFSXH != obj.CFSXH) bolResult = false;
			if (this.CFLX != obj.CFLX) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsCFDJDYGX obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.DYBSM=obj.DYBSM;
			this.BDCDYLX=obj.BDCDYLX;
			this.CFDJBSM=obj.CFDJBSM;
			this.CFDJZXBSM=obj.CFDJZXBSM;
			this.DYBM=obj.DYBM;
			this.QLBM=obj.QLBM;
			this.QLBSM=obj.QLBSM;
			this.BDCDYH=obj.BDCDYH;
			this.CQZH=obj.CQZH;
			this.ZL=obj.ZL;
			this.QXDM=obj.QXDM;
			this.YXTBSM=obj.YXTBSM;
			this.YXTBM=obj.YXTBM;
			this.REV_=obj.REV_;
			this.CFSXH=obj.CFSXH;
			this.CFLX=obj.CFLX;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
		}

	}

	public class clsCFDJDYGXSet:EntityBaseSet
	{
		public clsCFDJDYGXSet()
		{
			m_TableName="BDCDJ.CFDJ_DYGX";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsCFDJDYGXSet";
		}
		public static clsCFDJDYGXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsCFDJDYGXSet clsSet = new clsCFDJDYGXSet(); //(clsCFDJDYGXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsCFDJDYGXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsCFDJDYGX obj = (clsCFDJDYGX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("DYBSM")) datarow["DYBSM"] = obj.DYBSM;
				if(datarow.Table.Columns.Contains("BDCDYLX")) datarow["BDCDYLX"] = obj.BDCDYLX;
				if(datarow.Table.Columns.Contains("CFDJBSM")) datarow["CFDJBSM"] = obj.CFDJBSM;
				if(datarow.Table.Columns.Contains("CFDJZXBSM")) datarow["CFDJZXBSM"] = obj.CFDJZXBSM;
				if(datarow.Table.Columns.Contains("DYBM")) datarow["DYBM"] = obj.DYBM;
				if(datarow.Table.Columns.Contains("QLBM")) datarow["QLBM"] = obj.QLBM;
				if(datarow.Table.Columns.Contains("QLBSM")) datarow["QLBSM"] = obj.QLBSM;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("CQZH")) datarow["CQZH"] = obj.CQZH;
				if(datarow.Table.Columns.Contains("ZL")) datarow["ZL"] = obj.ZL;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("CFSXH")) datarow["CFSXH"] = obj.CFSXH;
				if(datarow.Table.Columns.Contains("CFLX")) datarow["CFLX"] = obj.CFLX;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
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
			clsCFDJDYGX obj = null;
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
					obj = new clsCFDJDYGX();  
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
							if(strFldName.ToUpper()=="CFDJBSM")
								if (pRow.Table.Columns.Contains("CFDJBSM") && pRow["CFDJBSM"] != DBNull.Value) { obj.CFDJBSM = Convert.ToInt64(pRow["CFDJBSM"]); }
							if(strFldName.ToUpper()=="CFDJZXBSM")
								if (pRow.Table.Columns.Contains("CFDJZXBSM") && pRow["CFDJZXBSM"] != DBNull.Value) { obj.CFDJZXBSM = Convert.ToInt64(pRow["CFDJZXBSM"]); }
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
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							
							if(strFldName.ToUpper()=="CFSXH")
								if (pRow.Table.Columns.Contains("CFSXH") && pRow["CFSXH"] != DBNull.Value) { obj.CFSXH = Convert.ToString(pRow["CFSXH"]); }
							if(strFldName.ToUpper()=="CFLX")
								if (pRow.Table.Columns.Contains("CFLX") && pRow["CFLX"] != DBNull.Value) { obj.CFLX = Convert.ToString(pRow["CFLX"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
						if (pRow.Table.Columns.Contains("BDCDYLX") && pRow["BDCDYLX"] != DBNull.Value) { obj.BDCDYLX = Convert.ToString(pRow["BDCDYLX"]); }
						if (pRow.Table.Columns.Contains("CFDJBSM") && pRow["CFDJBSM"] != DBNull.Value) { obj.CFDJBSM = Convert.ToInt64(pRow["CFDJBSM"]); }
						if (pRow.Table.Columns.Contains("CFDJZXBSM") && pRow["CFDJZXBSM"] != DBNull.Value) { obj.CFDJZXBSM = Convert.ToInt64(pRow["CFDJZXBSM"]); }
						if (pRow.Table.Columns.Contains("DYBM") && pRow["DYBM"] != DBNull.Value) { obj.DYBM = Convert.ToString(pRow["DYBM"]); }
						if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
						if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("CQZH") && pRow["CQZH"] != DBNull.Value) { obj.CQZH = Convert.ToString(pRow["CQZH"]); }
						if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						
						if (pRow.Table.Columns.Contains("CFSXH") && pRow["CFSXH"] != DBNull.Value) { obj.CFSXH = Convert.ToString(pRow["CFSXH"]); }
						if (pRow.Table.Columns.Contains("CFLX") && pRow["CFLX"] != DBNull.Value) { obj.CFLX = Convert.ToString(pRow["CFLX"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
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
