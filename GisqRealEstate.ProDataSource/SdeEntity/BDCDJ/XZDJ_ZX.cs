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

	public class Fld_XZDJZX
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string XZDJBSM="XZDJBSM";
		public const string JCXZFS="JCXZFS";
		public const string JCXZWJ="JCXZWJ";
		public const string JCXZWJLX="JCXZWJLX";
		public const string JCXZWH="JCXZWH";
		public const string DJYY="DJYY";
		public const string FJ="FJ";
		public const string QSZT="QSZT";
		public const string SHBSM="SHBSM";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string DBR="DBR";
		public const string DJSJ="DJSJ";
		public const string OINSID="OINSID";
		public const string BZ_FWCODE="BZ_FWCODE";
		#endregion
	}

	public class clsXZDJZX:IEntity
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
		private long m_XZDJBSM;
		private string m_JCXZFS;
		private string m_JCXZWJ;
		private string m_JCXZWJLX;
		private string m_JCXZWH;
		private string m_DJYY;
		private string m_FJ;
		private string m_QSZT;
		private long m_SHBSM;
		private string m_YXTBM;
		private string m_YXTBSM;
		private long m_QXDM;
		private long m_REV_;
		private DateTime m_GXSJ;
		private string m_BZ;
		private string m_DBR;
		private DateTime m_DJSJ;


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
		public long XZDJBSM
		{
			get{ return m_XZDJBSM; }
			set{ m_XZDJBSM = value; }
		}
		public string JCXZFS
		{
			get{ return m_JCXZFS; }
			set{ m_JCXZFS = value; }
		}
		public string JCXZWJ
		{
			get{ return m_JCXZWJ; }
			set{ m_JCXZWJ = value; }
		}
		public string JCXZWJLX
		{
			get{ return m_JCXZWJLX; }
			set{ m_JCXZWJLX = value; }
		}
		public string JCXZWH
		{
			get{ return m_JCXZWH; }
			set{ m_JCXZWH = value; }
		}
		public string DJYY
		{
			get{ return m_DJYY; }
			set{ m_DJYY = value; }
		}
		public string FJ
		{
			get{ return m_FJ; }
			set{ m_FJ = value; }
		}
		public string QSZT
		{
			get{ return m_QSZT; }
			set{ m_QSZT = value; }
		}
		public long SHBSM
		{
			get{ return m_SHBSM; }
			set{ m_SHBSM = value; }
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
		public string DBR
		{
			get{ return m_DBR; }
			set{ m_DBR = value; }
		}
		public DateTime DJSJ
		{
			get{ return m_DJSJ; }
			set{ m_DJSJ = value; }
		}

		#endregion
		public bool IsEquals(clsXZDJZX obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.XZDJBSM != obj.XZDJBSM) bolResult = false;
			if (this.JCXZFS != obj.JCXZFS) bolResult = false;
			if (this.JCXZWJ != obj.JCXZWJ) bolResult = false;
			if (this.JCXZWJLX != obj.JCXZWJLX) bolResult = false;
			if (this.JCXZWH != obj.JCXZWH) bolResult = false;
			if (this.DJYY != obj.DJYY) bolResult = false;
			if (this.FJ != obj.FJ) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.SHBSM != obj.SHBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.DBR != obj.DBR) bolResult = false;
			if (this.DJSJ != obj.DJSJ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsXZDJZX obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.XZDJBSM=obj.XZDJBSM;
			this.JCXZFS=obj.JCXZFS;
			this.JCXZWJ=obj.JCXZWJ;
			this.JCXZWJLX=obj.JCXZWJLX;
			this.JCXZWH=obj.JCXZWH;
			this.DJYY=obj.DJYY;
			this.FJ=obj.FJ;
			this.QSZT=obj.QSZT;
			this.SHBSM=obj.SHBSM;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.DBR=obj.DBR;
			this.DJSJ=obj.DJSJ;
		}

	}

	public class clsXZDJZXSet:EntityBaseSet
	{
		public clsXZDJZXSet()
		{
			m_TableName="BDCDJ.XZDJ_ZX";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsXZDJZXSet";
		}
		public static clsXZDJZXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsXZDJZXSet clsSet = new clsXZDJZXSet(); //(clsXZDJZXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsXZDJZXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsXZDJZX obj = (clsXZDJZX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("XZDJBSM")) datarow["XZDJBSM"] = obj.XZDJBSM;
				if(datarow.Table.Columns.Contains("JCXZFS")) datarow["JCXZFS"] = obj.JCXZFS;
				if(datarow.Table.Columns.Contains("JCXZWJ")) datarow["JCXZWJ"] = obj.JCXZWJ;
				if(datarow.Table.Columns.Contains("JCXZWJLX")) datarow["JCXZWJLX"] = obj.JCXZWJLX;
				if(datarow.Table.Columns.Contains("JCXZWH")) datarow["JCXZWH"] = obj.JCXZWH;
				if(datarow.Table.Columns.Contains("DJYY")) datarow["DJYY"] = obj.DJYY;
				if(datarow.Table.Columns.Contains("FJ")) datarow["FJ"] = obj.FJ;
				if(datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
				if(datarow.Table.Columns.Contains("SHBSM")) datarow["SHBSM"] = obj.SHBSM;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("DBR")) datarow["DBR"] = obj.DBR;
				if (obj.DJSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("DJSJ")) datarow["DJSJ"] = obj.DJSJ;
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
			clsXZDJZX obj = null;
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
					obj = new clsXZDJZX();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="XZDJBSM")
								if (pRow.Table.Columns.Contains("XZDJBSM") && pRow["XZDJBSM"] != DBNull.Value) { obj.XZDJBSM = Convert.ToInt64(pRow["XZDJBSM"]); }
							if(strFldName.ToUpper()=="JCXZFS")
								if (pRow.Table.Columns.Contains("JCXZFS") && pRow["JCXZFS"] != DBNull.Value) { obj.JCXZFS = Convert.ToString(pRow["JCXZFS"]); }
							if(strFldName.ToUpper()=="JCXZWJ")
								if (pRow.Table.Columns.Contains("JCXZWJ") && pRow["JCXZWJ"] != DBNull.Value) { obj.JCXZWJ = Convert.ToString(pRow["JCXZWJ"]); }
							if(strFldName.ToUpper()=="JCXZWJLX")
								if (pRow.Table.Columns.Contains("JCXZWJLX") && pRow["JCXZWJLX"] != DBNull.Value) { obj.JCXZWJLX = Convert.ToString(pRow["JCXZWJLX"]); }
							if(strFldName.ToUpper()=="JCXZWH")
								if (pRow.Table.Columns.Contains("JCXZWH") && pRow["JCXZWH"] != DBNull.Value) { obj.JCXZWH = Convert.ToString(pRow["JCXZWH"]); }
							if(strFldName.ToUpper()=="DJYY")
								if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
							if(strFldName.ToUpper()=="FJ")
								if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
							if(strFldName.ToUpper()=="QSZT")
								if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
							if(strFldName.ToUpper()=="SHBSM")
								if (pRow.Table.Columns.Contains("SHBSM") && pRow["SHBSM"] != DBNull.Value) { obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="DBR")
								if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
							if(strFldName.ToUpper()=="DJSJ")
								if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
							
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("XZDJBSM") && pRow["XZDJBSM"] != DBNull.Value) { obj.XZDJBSM = Convert.ToInt64(pRow["XZDJBSM"]); }
						if (pRow.Table.Columns.Contains("JCXZFS") && pRow["JCXZFS"] != DBNull.Value) { obj.JCXZFS = Convert.ToString(pRow["JCXZFS"]); }
						if (pRow.Table.Columns.Contains("JCXZWJ") && pRow["JCXZWJ"] != DBNull.Value) { obj.JCXZWJ = Convert.ToString(pRow["JCXZWJ"]); }
						if (pRow.Table.Columns.Contains("JCXZWJLX") && pRow["JCXZWJLX"] != DBNull.Value) { obj.JCXZWJLX = Convert.ToString(pRow["JCXZWJLX"]); }
						if (pRow.Table.Columns.Contains("JCXZWH") && pRow["JCXZWH"] != DBNull.Value) { obj.JCXZWH = Convert.ToString(pRow["JCXZWH"]); }
						if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
						if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
						if (pRow.Table.Columns.Contains("SHBSM") && pRow["SHBSM"] != DBNull.Value) { obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
						if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
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
