using System;
using System.Data;

using GisqRealEstate.ProDataSource;

/*
==================================================
�������³�ͼ������Ϣ�������޹�˾
��Ȩ���У�δ����Ȩ���ý��и��ơ��޸ġ����������򹤳̡�
ģ�����ƣ�
�ļ����ƣ�
ģ��˵����
�޸ļ�¼��
�޸�/�����ߣ�ASSASSIN | �޸�ʱ�䣨2016/11/16) | ˵��(����ԭ���漰���ݣ� |
==================================================
*/
namespace GisqRealEstate.ProDataSource
{

	public class Fld_LQ
	{
		#region ����
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YSDM="YSDM";
		public const string BDCDYH="BDCDYH";
		public const string YWH="YWH";
		public const string QLLX="QLLX";
		public const string DJLX="DJLX";
		public const string DJYY="DJYY";
		public const string FBF="FBF";
		public const string SYQMJ="SYQMJ";
		public const string LDSYQSSJ="LDSYQSSJ";
		public const string LDSYJSSJ="LDSYJSSJ";
		public const string LDSYQXZ="LDSYQXZ";
		public const string SLLMSYQR1="SLLMSYQR1";
		public const string SLLMSYQR2="SLLMSYQR2";
		public const string BDCQZH="BDCQZH";
		public const string DJJG="DJJG";
		public const string DBR="DBR";
		public const string DJSJ="DJSJ";
		public const string LYQLBH="LYQLBH";
		public const string FJ="FJ";
		public const string QSZT="QSZT";
		public const string MJDW="MJDW";
		public const string ZXYWH="ZXYWH";
		public const string ZXSJ="ZXSJ";
		public const string ZXDBR="ZXDBR";
		public const string ZXYY="ZXYY";
		public const string ZXFJ="ZXFJ";
		public const string SHBSM="SHBSM";
		public const string ZXSHBSM="ZXSHBSM";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsLQ:IEntity
	{
		private long m_PrimaryKeyValue = 0;
		private EnumEditState m_enuEditState = EnumEditState.esNoEdit;

		#region IEntity ��Ա
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

		#region ����
		private string m_YSDM;
		private string m_BDCDYH;
		private string m_YWH;
		private string m_QLLX;
		private string m_DJLX;
		private string m_DJYY;
		private string m_FBF;
		private double m_SYQMJ;
		private DateTime m_LDSYQSSJ;
		private DateTime m_LDSYJSSJ;
		private string m_LDSYQXZ;
		private string m_SLLMSYQR1;
		private string m_SLLMSYQR2;
		private string m_BDCQZH;
		private string m_DJJG;
		private string m_DBR;
		private DateTime m_DJSJ;
		private string m_LYQLBH;
		private string m_FJ;
		private string m_QSZT;
		private string m_MJDW;
		private string m_ZXYWH;
		private DateTime m_ZXSJ;
		private string m_ZXDBR;
		private string m_ZXYY;
		private string m_ZXFJ;
		private long m_SHBSM;
		private long m_ZXSHBSM;
		private string m_YXTBM;
		private string m_YXTBSM;
		private long m_QXDM;
		private long m_REV_;
		private DateTime m_GXSJ;
		private string m_BZ;
		private long m_BG_BB;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public string YSDM
		{
			get{ return m_YSDM; }
			set{ m_YSDM = value; }
		}
		public string BDCDYH
		{
			get{ return m_BDCDYH; }
			set{ m_BDCDYH = value; }
		}
		public string YWH
		{
			get{ return m_YWH; }
			set{ m_YWH = value; }
		}
		public string QLLX
		{
			get{ return m_QLLX; }
			set{ m_QLLX = value; }
		}
		public string DJLX
		{
			get{ return m_DJLX; }
			set{ m_DJLX = value; }
		}
		public string DJYY
		{
			get{ return m_DJYY; }
			set{ m_DJYY = value; }
		}
		public string FBF
		{
			get{ return m_FBF; }
			set{ m_FBF = value; }
		}
		public double SYQMJ
		{
			get{ return m_SYQMJ; }
			set{ m_SYQMJ = value; }
		}
		public DateTime LDSYQSSJ
		{
			get{ return m_LDSYQSSJ; }
			set{ m_LDSYQSSJ = value; }
		}
		public DateTime LDSYJSSJ
		{
			get{ return m_LDSYJSSJ; }
			set{ m_LDSYJSSJ = value; }
		}
		public string LDSYQXZ
		{
			get{ return m_LDSYQXZ; }
			set{ m_LDSYQXZ = value; }
		}
		public string SLLMSYQR1
		{
			get{ return m_SLLMSYQR1; }
			set{ m_SLLMSYQR1 = value; }
		}
		public string SLLMSYQR2
		{
			get{ return m_SLLMSYQR2; }
			set{ m_SLLMSYQR2 = value; }
		}
		public string BDCQZH
		{
			get{ return m_BDCQZH; }
			set{ m_BDCQZH = value; }
		}
		public string DJJG
		{
			get{ return m_DJJG; }
			set{ m_DJJG = value; }
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
		public string LYQLBH
		{
			get{ return m_LYQLBH; }
			set{ m_LYQLBH = value; }
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
		public string MJDW
		{
			get{ return m_MJDW; }
			set{ m_MJDW = value; }
		}
		public string ZXYWH
		{
			get{ return m_ZXYWH; }
			set{ m_ZXYWH = value; }
		}
		public DateTime ZXSJ
		{
			get{ return m_ZXSJ; }
			set{ m_ZXSJ = value; }
		}
		public string ZXDBR
		{
			get{ return m_ZXDBR; }
			set{ m_ZXDBR = value; }
		}
		public string ZXYY
		{
			get{ return m_ZXYY; }
			set{ m_ZXYY = value; }
		}
		public string ZXFJ
		{
			get{ return m_ZXFJ; }
			set{ m_ZXFJ = value; }
		}
		public long SHBSM
		{
			get{ return m_SHBSM; }
			set{ m_SHBSM = value; }
		}
		public long ZXSHBSM
		{
			get{ return m_ZXSHBSM; }
			set{ m_ZXSHBSM = value; }
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
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

		#endregion
		public bool IsEquals(clsLQ obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YSDM != obj.YSDM) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.QLLX != obj.QLLX) bolResult = false;
			if (this.DJLX != obj.DJLX) bolResult = false;
			if (this.DJYY != obj.DJYY) bolResult = false;
			if (this.FBF != obj.FBF) bolResult = false;
			if (this.SYQMJ != obj.SYQMJ) bolResult = false;
			if (this.LDSYQSSJ != obj.LDSYQSSJ) bolResult = false;
			if (this.LDSYJSSJ != obj.LDSYJSSJ) bolResult = false;
			if (this.LDSYQXZ != obj.LDSYQXZ) bolResult = false;
			if (this.SLLMSYQR1 != obj.SLLMSYQR1) bolResult = false;
			if (this.SLLMSYQR2 != obj.SLLMSYQR2) bolResult = false;
			if (this.BDCQZH != obj.BDCQZH) bolResult = false;
			if (this.DJJG != obj.DJJG) bolResult = false;
			if (this.DBR != obj.DBR) bolResult = false;
			if (this.DJSJ != obj.DJSJ) bolResult = false;
			if (this.LYQLBH != obj.LYQLBH) bolResult = false;
			if (this.FJ != obj.FJ) bolResult = false;
			if (this.QSZT != obj.QSZT) bolResult = false;
			if (this.MJDW != obj.MJDW) bolResult = false;
			if (this.ZXYWH != obj.ZXYWH) bolResult = false;
			if (this.ZXSJ != obj.ZXSJ) bolResult = false;
			if (this.ZXDBR != obj.ZXDBR) bolResult = false;
			if (this.ZXYY != obj.ZXYY) bolResult = false;
			if (this.ZXFJ != obj.ZXFJ) bolResult = false;
			if (this.SHBSM != obj.SHBSM) bolResult = false;
			if (this.ZXSHBSM != obj.ZXSHBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsLQ obj)
		{
			this.BSM=obj.BSM;
			this.YSDM=obj.YSDM;
			this.BDCDYH=obj.BDCDYH;
			this.YWH=obj.YWH;
			this.QLLX=obj.QLLX;
			this.DJLX=obj.DJLX;
			this.DJYY=obj.DJYY;
			this.FBF=obj.FBF;
			this.SYQMJ=obj.SYQMJ;
			this.LDSYQSSJ=obj.LDSYQSSJ;
			this.LDSYJSSJ=obj.LDSYJSSJ;
			this.LDSYQXZ=obj.LDSYQXZ;
			this.SLLMSYQR1=obj.SLLMSYQR1;
			this.SLLMSYQR2=obj.SLLMSYQR2;
			this.BDCQZH=obj.BDCQZH;
			this.DJJG=obj.DJJG;
			this.DBR=obj.DBR;
			this.DJSJ=obj.DJSJ;
			this.LYQLBH=obj.LYQLBH;
			this.FJ=obj.FJ;
			this.QSZT=obj.QSZT;
			this.MJDW=obj.MJDW;
			this.ZXYWH=obj.ZXYWH;
			this.ZXSJ=obj.ZXSJ;
			this.ZXDBR=obj.ZXDBR;
			this.ZXYY=obj.ZXYY;
			this.ZXFJ=obj.ZXFJ;
			this.SHBSM=obj.SHBSM;
			this.ZXSHBSM=obj.ZXSHBSM;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
		}

	}

	public class clsLQSet:EntityBaseSet
	{
		public clsLQSet()
		{
			m_TableName="BDCDJ.LQ";
			m_HisTableName="BDCDJ.LQ_LS";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsLQSet";
		}
		public static clsLQSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsLQSet clsSet = new clsLQSet(); //(clsLQSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsLQSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsLQ obj = (clsLQ)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YSDM")) datarow["YSDM"] = obj.YSDM;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("QLLX")) datarow["QLLX"] = obj.QLLX;
				if(datarow.Table.Columns.Contains("DJLX")) datarow["DJLX"] = obj.DJLX;
				if(datarow.Table.Columns.Contains("DJYY")) datarow["DJYY"] = obj.DJYY;
				if(datarow.Table.Columns.Contains("FBF")) datarow["FBF"] = obj.FBF;
				if(datarow.Table.Columns.Contains("SYQMJ")) datarow["SYQMJ"] = obj.SYQMJ;
				if (obj.LDSYQSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("LDSYQSSJ")) datarow["LDSYQSSJ"] = obj.LDSYQSSJ;
				}
				if (obj.LDSYJSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("LDSYJSSJ")) datarow["LDSYJSSJ"] = obj.LDSYJSSJ;
				}
				if(datarow.Table.Columns.Contains("LDSYQXZ")) datarow["LDSYQXZ"] = obj.LDSYQXZ;
				if(datarow.Table.Columns.Contains("SLLMSYQR1")) datarow["SLLMSYQR1"] = obj.SLLMSYQR1;
				if(datarow.Table.Columns.Contains("SLLMSYQR2")) datarow["SLLMSYQR2"] = obj.SLLMSYQR2;
				if(datarow.Table.Columns.Contains("BDCQZH")) datarow["BDCQZH"] = obj.BDCQZH;
				if(datarow.Table.Columns.Contains("DJJG")) datarow["DJJG"] = obj.DJJG;
				if(datarow.Table.Columns.Contains("DBR")) datarow["DBR"] = obj.DBR;
				if (obj.DJSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("DJSJ")) datarow["DJSJ"] = obj.DJSJ;
				}
				if(datarow.Table.Columns.Contains("LYQLBH")) datarow["LYQLBH"] = obj.LYQLBH;
				if(datarow.Table.Columns.Contains("FJ")) datarow["FJ"] = obj.FJ;
				if(datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
				if(datarow.Table.Columns.Contains("MJDW")) datarow["MJDW"] = obj.MJDW;
				if(datarow.Table.Columns.Contains("ZXYWH")) datarow["ZXYWH"] = obj.ZXYWH;
				if (obj.ZXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("ZXSJ")) datarow["ZXSJ"] = obj.ZXSJ;
				}
				if(datarow.Table.Columns.Contains("ZXDBR")) datarow["ZXDBR"] = obj.ZXDBR;
				if(datarow.Table.Columns.Contains("ZXYY")) datarow["ZXYY"] = obj.ZXYY;
				if(datarow.Table.Columns.Contains("ZXFJ")) datarow["ZXFJ"] = obj.ZXFJ;
				if(datarow.Table.Columns.Contains("SHBSM")) datarow["SHBSM"] = obj.SHBSM;
				if(datarow.Table.Columns.Contains("ZXSHBSM")) datarow["ZXSHBSM"] = obj.ZXSHBSM;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
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
			clsLQ obj = null;
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
					obj = new clsLQ();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YSDM")
								if (pRow.Table.Columns.Contains("YSDM") && pRow["YSDM"] != DBNull.Value) { obj.YSDM = Convert.ToString(pRow["YSDM"]); }
							if(strFldName.ToUpper()=="BDCDYH")
								if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="QLLX")
								if (pRow.Table.Columns.Contains("QLLX") && pRow["QLLX"] != DBNull.Value) { obj.QLLX = Convert.ToString(pRow["QLLX"]); }
							if(strFldName.ToUpper()=="DJLX")
								if (pRow.Table.Columns.Contains("DJLX") && pRow["DJLX"] != DBNull.Value) { obj.DJLX = Convert.ToString(pRow["DJLX"]); }
							if(strFldName.ToUpper()=="DJYY")
								if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
							if(strFldName.ToUpper()=="FBF")
								if (pRow.Table.Columns.Contains("FBF") && pRow["FBF"] != DBNull.Value) { obj.FBF = Convert.ToString(pRow["FBF"]); }
							if(strFldName.ToUpper()=="SYQMJ")
								if (pRow.Table.Columns.Contains("SYQMJ") && pRow["SYQMJ"] != DBNull.Value) { obj.SYQMJ = Convert.ToDouble(pRow["SYQMJ"]); }
							if(strFldName.ToUpper()=="LDSYQSSJ")
								if (pRow.Table.Columns.Contains("LDSYQSSJ") && pRow["LDSYQSSJ"] != DBNull.Value) { obj.LDSYQSSJ = Convert.ToDateTime(pRow["LDSYQSSJ"]); }
							if(strFldName.ToUpper()=="LDSYJSSJ")
								if (pRow.Table.Columns.Contains("LDSYJSSJ") && pRow["LDSYJSSJ"] != DBNull.Value) { obj.LDSYJSSJ = Convert.ToDateTime(pRow["LDSYJSSJ"]); }
							if(strFldName.ToUpper()=="LDSYQXZ")
								if (pRow.Table.Columns.Contains("LDSYQXZ") && pRow["LDSYQXZ"] != DBNull.Value) { obj.LDSYQXZ = Convert.ToString(pRow["LDSYQXZ"]); }
							if(strFldName.ToUpper()=="SLLMSYQR1")
								if (pRow.Table.Columns.Contains("SLLMSYQR1") && pRow["SLLMSYQR1"] != DBNull.Value) { obj.SLLMSYQR1 = Convert.ToString(pRow["SLLMSYQR1"]); }
							if(strFldName.ToUpper()=="SLLMSYQR2")
								if (pRow.Table.Columns.Contains("SLLMSYQR2") && pRow["SLLMSYQR2"] != DBNull.Value) { obj.SLLMSYQR2 = Convert.ToString(pRow["SLLMSYQR2"]); }
							if(strFldName.ToUpper()=="BDCQZH")
								if (pRow.Table.Columns.Contains("BDCQZH") && pRow["BDCQZH"] != DBNull.Value) { obj.BDCQZH = Convert.ToString(pRow["BDCQZH"]); }
							if(strFldName.ToUpper()=="DJJG")
								if (pRow.Table.Columns.Contains("DJJG") && pRow["DJJG"] != DBNull.Value) { obj.DJJG = Convert.ToString(pRow["DJJG"]); }
							if(strFldName.ToUpper()=="DBR")
								if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
							if(strFldName.ToUpper()=="DJSJ")
								if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
							if(strFldName.ToUpper()=="LYQLBH")
								if (pRow.Table.Columns.Contains("LYQLBH") && pRow["LYQLBH"] != DBNull.Value) { obj.LYQLBH = Convert.ToString(pRow["LYQLBH"]); }
							if(strFldName.ToUpper()=="FJ")
								if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
							if(strFldName.ToUpper()=="QSZT")
								if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
							if(strFldName.ToUpper()=="MJDW")
								if (pRow.Table.Columns.Contains("MJDW") && pRow["MJDW"] != DBNull.Value) { obj.MJDW = Convert.ToString(pRow["MJDW"]); }
							if(strFldName.ToUpper()=="ZXYWH")
								if (pRow.Table.Columns.Contains("ZXYWH") && pRow["ZXYWH"] != DBNull.Value) { obj.ZXYWH = Convert.ToString(pRow["ZXYWH"]); }
							if(strFldName.ToUpper()=="ZXSJ")
								if (pRow.Table.Columns.Contains("ZXSJ") && pRow["ZXSJ"] != DBNull.Value) { obj.ZXSJ = Convert.ToDateTime(pRow["ZXSJ"]); }
							if(strFldName.ToUpper()=="ZXDBR")
								if (pRow.Table.Columns.Contains("ZXDBR") && pRow["ZXDBR"] != DBNull.Value) { obj.ZXDBR = Convert.ToString(pRow["ZXDBR"]); }
							if(strFldName.ToUpper()=="ZXYY")
								if (pRow.Table.Columns.Contains("ZXYY") && pRow["ZXYY"] != DBNull.Value) { obj.ZXYY = Convert.ToString(pRow["ZXYY"]); }
							if(strFldName.ToUpper()=="ZXFJ")
								if (pRow.Table.Columns.Contains("ZXFJ") && pRow["ZXFJ"] != DBNull.Value) { obj.ZXFJ = Convert.ToString(pRow["ZXFJ"]); }
							if(strFldName.ToUpper()=="SHBSM")
								if (pRow.Table.Columns.Contains("SHBSM") && pRow["SHBSM"] != DBNull.Value) { obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]); }
							if(strFldName.ToUpper()=="ZXSHBSM")
								if (pRow.Table.Columns.Contains("ZXSHBSM") && pRow["ZXSHBSM"] != DBNull.Value) { obj.ZXSHBSM = Convert.ToInt64(pRow["ZXSHBSM"]); }
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
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YSDM") && pRow["YSDM"] != DBNull.Value) { obj.YSDM = Convert.ToString(pRow["YSDM"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("QLLX") && pRow["QLLX"] != DBNull.Value) { obj.QLLX = Convert.ToString(pRow["QLLX"]); }
						if (pRow.Table.Columns.Contains("DJLX") && pRow["DJLX"] != DBNull.Value) { obj.DJLX = Convert.ToString(pRow["DJLX"]); }
						if (pRow.Table.Columns.Contains("DJYY") && pRow["DJYY"] != DBNull.Value) { obj.DJYY = Convert.ToString(pRow["DJYY"]); }
						if (pRow.Table.Columns.Contains("FBF") && pRow["FBF"] != DBNull.Value) { obj.FBF = Convert.ToString(pRow["FBF"]); }
						if (pRow.Table.Columns.Contains("SYQMJ") && pRow["SYQMJ"] != DBNull.Value) { obj.SYQMJ = Convert.ToDouble(pRow["SYQMJ"]); }
						if (pRow.Table.Columns.Contains("LDSYQSSJ") && pRow["LDSYQSSJ"] != DBNull.Value) { obj.LDSYQSSJ = Convert.ToDateTime(pRow["LDSYQSSJ"]); }
						if (pRow.Table.Columns.Contains("LDSYJSSJ") && pRow["LDSYJSSJ"] != DBNull.Value) { obj.LDSYJSSJ = Convert.ToDateTime(pRow["LDSYJSSJ"]); }
						if (pRow.Table.Columns.Contains("LDSYQXZ") && pRow["LDSYQXZ"] != DBNull.Value) { obj.LDSYQXZ = Convert.ToString(pRow["LDSYQXZ"]); }
						if (pRow.Table.Columns.Contains("SLLMSYQR1") && pRow["SLLMSYQR1"] != DBNull.Value) { obj.SLLMSYQR1 = Convert.ToString(pRow["SLLMSYQR1"]); }
						if (pRow.Table.Columns.Contains("SLLMSYQR2") && pRow["SLLMSYQR2"] != DBNull.Value) { obj.SLLMSYQR2 = Convert.ToString(pRow["SLLMSYQR2"]); }
						if (pRow.Table.Columns.Contains("BDCQZH") && pRow["BDCQZH"] != DBNull.Value) { obj.BDCQZH = Convert.ToString(pRow["BDCQZH"]); }
						if (pRow.Table.Columns.Contains("DJJG") && pRow["DJJG"] != DBNull.Value) { obj.DJJG = Convert.ToString(pRow["DJJG"]); }
						if (pRow.Table.Columns.Contains("DBR") && pRow["DBR"] != DBNull.Value) { obj.DBR = Convert.ToString(pRow["DBR"]); }
						if (pRow.Table.Columns.Contains("DJSJ") && pRow["DJSJ"] != DBNull.Value) { obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]); }
						if (pRow.Table.Columns.Contains("LYQLBH") && pRow["LYQLBH"] != DBNull.Value) { obj.LYQLBH = Convert.ToString(pRow["LYQLBH"]); }
						if (pRow.Table.Columns.Contains("FJ") && pRow["FJ"] != DBNull.Value) { obj.FJ = Convert.ToString(pRow["FJ"]); }
						if (pRow.Table.Columns.Contains("QSZT") && pRow["QSZT"] != DBNull.Value) { obj.QSZT = Convert.ToString(pRow["QSZT"]); }
						if (pRow.Table.Columns.Contains("MJDW") && pRow["MJDW"] != DBNull.Value) { obj.MJDW = Convert.ToString(pRow["MJDW"]); }
						if (pRow.Table.Columns.Contains("ZXYWH") && pRow["ZXYWH"] != DBNull.Value) { obj.ZXYWH = Convert.ToString(pRow["ZXYWH"]); }
						if (pRow.Table.Columns.Contains("ZXSJ") && pRow["ZXSJ"] != DBNull.Value) { obj.ZXSJ = Convert.ToDateTime(pRow["ZXSJ"]); }
						if (pRow.Table.Columns.Contains("ZXDBR") && pRow["ZXDBR"] != DBNull.Value) { obj.ZXDBR = Convert.ToString(pRow["ZXDBR"]); }
						if (pRow.Table.Columns.Contains("ZXYY") && pRow["ZXYY"] != DBNull.Value) { obj.ZXYY = Convert.ToString(pRow["ZXYY"]); }
						if (pRow.Table.Columns.Contains("ZXFJ") && pRow["ZXFJ"] != DBNull.Value) { obj.ZXFJ = Convert.ToString(pRow["ZXFJ"]); }
						if (pRow.Table.Columns.Contains("SHBSM") && pRow["SHBSM"] != DBNull.Value) { obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]); }
						if (pRow.Table.Columns.Contains("ZXSHBSM") && pRow["ZXSHBSM"] != DBNull.Value) { obj.ZXSHBSM = Convert.ToInt64(pRow["ZXSHBSM"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
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
