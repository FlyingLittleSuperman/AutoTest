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

	public class Fld_DYAQDYGX
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string DYBSM="DYBSM";
		public const string BDCDYLX="BDCDYLX";
		public const string DYAQBSM="DYAQBSM";
		public const string DYAQZXBSM="DYAQZXBSM";
		public const string DYBM="DYBM";
		public const string QLBM="QLBM";
		public const string QLBSM="QLBSM";
		public const string BDCDYH="BDCDYH";
		public const string CQZH="CQZH";
		public const string ZL="ZL";
		public const string QXDM="QXDM";
		public const string YXTBSM="YXTBSM";
		public const string BZ_FW_NM="BZ_FW_NM";
		public const string BZ_FH_NM="BZ_FH_NM";
		public const string YXTBM="YXTBM";
		public const string REV_="REV_";
		public const string BZ_DY_MJ="BZ_DY_MJ";
		public const string BZ_ZC_ZE="BZ_ZC_ZE";
		public const string BZ_DY_JE="BZ_DY_JE";
		public const string BZ_YZDQLRID="BZ_YZDQLRID";
		public const string BZ_ZGDY_JE="BZ_ZGDY_JE";
		public const string BZ_DY_ID="BZ_DY_ID";
		public const string BZ_DYZS_ID="BZ_DYZS_ID";
		public const string BZ_ZDQLR_ID="BZ_ZDQLR_ID";
		public const string DYSXH="DYSXH";
		public const string DYSX="DYSX";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string BZ_RIGHT_ID="BZ_RIGHT_ID";
		public const string BZ_YWSLID="BZ_YWSLID";
		public const string BZ_QLID="BZ_QLID";
		public const string BZ_QZID="BZ_QZID";
		public const string BZ_QSZT="BZ_QSZT";
		public const string FJ2="FJ2";
		public const string BZ_编号="BZ_编号";
		public const string BZ_ID="BZ_ID";
		public const string DYAWJZ="DYAWJZ";
		public const string ZQSE="ZQSE";
		#endregion
	}

	public class clsDYAQDYGX:IEntity
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
		private long m_DYAQBSM;
		private long m_DYAQZXBSM;
		private string m_DYBM;
		private string m_QLBM;
		private long m_QLBSM;
		private string m_BDCDYH;
		private string m_CQZH;
		private string m_ZL;
		private long m_QXDM;
		private string m_YXTBSM;
		private long m_BZ_FW_NM;
		private long m_BZ_FH_NM;
		private string m_YXTBM;
		private long m_REV_;
		private string m_DYSXH;
		private string m_DYSX;
		private DateTime m_GXSJ;
		private string m_BZ;
		private double m_DYAWJZ;
		private long m_ZQSE;

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
		public long DYAQBSM
		{
			get{ return m_DYAQBSM; }
			set{ m_DYAQBSM = value; }
		}
		public long DYAQZXBSM
		{
			get{ return m_DYAQZXBSM; }
			set{ m_DYAQZXBSM = value; }
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
		public long BZ_FW_NM
		{
			get{ return m_BZ_FW_NM; }
			set{ m_BZ_FW_NM = value; }
		}
		public long BZ_FH_NM
		{
			get{ return m_BZ_FH_NM; }
			set{ m_BZ_FH_NM = value; }
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
		
		
		
		
		public string DYSXH
		{
			get{ return m_DYSXH; }
			set{ m_DYSXH = value; }
		}
		public string DYSX
		{
			get{ return m_DYSX; }
			set{ m_DYSX = value; }
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
		public double DYAWJZ
		{
			get{ return m_DYAWJZ; }
			set{ m_DYAWJZ = value; }
		}
		public long ZQSE
		{
			get{ return m_ZQSE; }
			set{ m_ZQSE = value; }
		}

		#endregion
		public bool IsEquals(clsDYAQDYGX obj)
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
			if (this.DYAQBSM != obj.DYAQBSM) bolResult = false;
			if (this.DYAQZXBSM != obj.DYAQZXBSM) bolResult = false;
			if (this.DYBM != obj.DYBM) bolResult = false;
			if (this.QLBM != obj.QLBM) bolResult = false;
			if (this.QLBSM != obj.QLBSM) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.CQZH != obj.CQZH) bolResult = false;
			if (this.ZL != obj.ZL) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.BZ_FW_NM != obj.BZ_FW_NM) bolResult = false;
			if (this.BZ_FH_NM != obj.BZ_FH_NM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.DYSXH != obj.DYSXH) bolResult = false;
			if (this.DYSX != obj.DYSX) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.DYAWJZ != obj.DYAWJZ) bolResult = false;
			if (this.ZQSE != obj.ZQSE) bolResult = false;
			return bolResult;
		}

		public void Colne(clsDYAQDYGX obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.DYBSM=obj.DYBSM;
			this.BDCDYLX=obj.BDCDYLX;
			this.DYAQBSM=obj.DYAQBSM;
			this.DYAQZXBSM=obj.DYAQZXBSM;
			this.DYBM=obj.DYBM;
			this.QLBM=obj.QLBM;
			this.QLBSM=obj.QLBSM;
			this.BDCDYH=obj.BDCDYH;
			this.CQZH=obj.CQZH;
			this.ZL=obj.ZL;
			this.QXDM=obj.QXDM;
			this.YXTBSM=obj.YXTBSM;
			this.BZ_FW_NM=obj.BZ_FW_NM;
			this.BZ_FH_NM=obj.BZ_FH_NM;
			this.YXTBM=obj.YXTBM;
			this.REV_=obj.REV_;
			this.DYSXH=obj.DYSXH;
			this.DYSX=obj.DYSX;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.DYAWJZ=obj.DYAWJZ;
			this.ZQSE=obj.ZQSE;
		}

	}

	public class clsDYAQDYGXSet:EntityBaseSet
	{
		public clsDYAQDYGXSet()
		{
			m_TableName="BDCDJ.DYAQ_DYGX";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsDYAQDYGXSet";
		}
		public static clsDYAQDYGXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsDYAQDYGXSet clsSet = new clsDYAQDYGXSet(); //(clsDYAQDYGXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsDYAQDYGXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsDYAQDYGX obj = (clsDYAQDYGX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("DYBSM")) datarow["DYBSM"] = obj.DYBSM;
				if(datarow.Table.Columns.Contains("BDCDYLX")) datarow["BDCDYLX"] = obj.BDCDYLX;
				if(datarow.Table.Columns.Contains("DYAQBSM")) datarow["DYAQBSM"] = obj.DYAQBSM;
				if(datarow.Table.Columns.Contains("DYAQZXBSM")) datarow["DYAQZXBSM"] = obj.DYAQZXBSM;
				if(datarow.Table.Columns.Contains("DYBM")) datarow["DYBM"] = obj.DYBM;
				if(datarow.Table.Columns.Contains("QLBM")) datarow["QLBM"] = obj.QLBM;
				if(datarow.Table.Columns.Contains("QLBSM")) datarow["QLBSM"] = obj.QLBSM;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("CQZH")) datarow["CQZH"] = obj.CQZH;
				if(datarow.Table.Columns.Contains("ZL")) datarow["ZL"] = obj.ZL;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("BZ_FW_NM")) datarow["BZ_FW_NM"] = obj.BZ_FW_NM;
				if(datarow.Table.Columns.Contains("BZ_FH_NM")) datarow["BZ_FH_NM"] = obj.BZ_FH_NM;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("DYSXH")) datarow["DYSXH"] = obj.DYSXH;
				if(datarow.Table.Columns.Contains("DYSX")) datarow["DYSX"] = obj.DYSX;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("DYAWJZ")) datarow["DYAWJZ"] = obj.DYAWJZ;
				if(datarow.Table.Columns.Contains("ZQSE")) datarow["ZQSE"] = obj.ZQSE;
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
			clsDYAQDYGX obj = null;
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
					obj = new clsDYAQDYGX();  
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
							if(strFldName.ToUpper()=="DYAQBSM")
								if (pRow.Table.Columns.Contains("DYAQBSM") && pRow["DYAQBSM"] != DBNull.Value) { obj.DYAQBSM = Convert.ToInt64(pRow["DYAQBSM"]); }
							if(strFldName.ToUpper()=="DYAQZXBSM")
								if (pRow.Table.Columns.Contains("DYAQZXBSM") && pRow["DYAQZXBSM"] != DBNull.Value) { obj.DYAQZXBSM = Convert.ToInt64(pRow["DYAQZXBSM"]); }
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
							if(strFldName.ToUpper()=="BZ_FW_NM")
								if (pRow.Table.Columns.Contains("BZ_FW_NM") && pRow["BZ_FW_NM"] != DBNull.Value) { obj.BZ_FW_NM = Convert.ToInt64(pRow["BZ_FW_NM"]); }
							if(strFldName.ToUpper()=="BZ_FH_NM")
								if (pRow.Table.Columns.Contains("BZ_FH_NM") && pRow["BZ_FH_NM"] != DBNull.Value) { obj.BZ_FH_NM = Convert.ToInt64(pRow["BZ_FH_NM"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							
							if(strFldName.ToUpper()=="DYSXH")
								if (pRow.Table.Columns.Contains("DYSXH") && pRow["DYSXH"] != DBNull.Value) { obj.DYSXH = Convert.ToString(pRow["DYSXH"]); }
							if(strFldName.ToUpper()=="DYSX")
								if (pRow.Table.Columns.Contains("DYSX") && pRow["DYSX"] != DBNull.Value) { obj.DYSX = Convert.ToString(pRow["DYSX"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							
							if(strFldName.ToUpper()=="DYAWJZ")
								if (pRow.Table.Columns.Contains("DYAWJZ") && pRow["DYAWJZ"] != DBNull.Value) { obj.DYAWJZ = Convert.ToDouble(pRow["DYAWJZ"]); }
							if(strFldName.ToUpper()=="ZQSE")
								if (pRow.Table.Columns.Contains("ZQSE") && pRow["ZQSE"] != DBNull.Value) { obj.ZQSE = Convert.ToInt64(pRow["ZQSE"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
						if (pRow.Table.Columns.Contains("BDCDYLX") && pRow["BDCDYLX"] != DBNull.Value) { obj.BDCDYLX = Convert.ToString(pRow["BDCDYLX"]); }
						if (pRow.Table.Columns.Contains("DYAQBSM") && pRow["DYAQBSM"] != DBNull.Value) { obj.DYAQBSM = Convert.ToInt64(pRow["DYAQBSM"]); }
						if (pRow.Table.Columns.Contains("DYAQZXBSM") && pRow["DYAQZXBSM"] != DBNull.Value) { obj.DYAQZXBSM = Convert.ToInt64(pRow["DYAQZXBSM"]); }
						if (pRow.Table.Columns.Contains("DYBM") && pRow["DYBM"] != DBNull.Value) { obj.DYBM = Convert.ToString(pRow["DYBM"]); }
						if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
						if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("CQZH") && pRow["CQZH"] != DBNull.Value) { obj.CQZH = Convert.ToString(pRow["CQZH"]); }
						if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("BZ_FW_NM") && pRow["BZ_FW_NM"] != DBNull.Value) { obj.BZ_FW_NM = Convert.ToInt64(pRow["BZ_FW_NM"]); }
						if (pRow.Table.Columns.Contains("BZ_FH_NM") && pRow["BZ_FH_NM"] != DBNull.Value) { obj.BZ_FH_NM = Convert.ToInt64(pRow["BZ_FH_NM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }

						if (pRow.Table.Columns.Contains("DYSXH") && pRow["DYSXH"] != DBNull.Value) { obj.DYSXH = Convert.ToString(pRow["DYSXH"]); }
						if (pRow.Table.Columns.Contains("DYSX") && pRow["DYSX"] != DBNull.Value) { obj.DYSX = Convert.ToString(pRow["DYSX"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
					
						if (pRow.Table.Columns.Contains("DYAWJZ") && pRow["DYAWJZ"] != DBNull.Value) { obj.DYAWJZ = Convert.ToDouble(pRow["DYAWJZ"]); }
						if (pRow.Table.Columns.Contains("ZQSE") && pRow["ZQSE"] != DBNull.Value) { obj.ZQSE = Convert.ToInt64(pRow["ZQSE"]); }
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
