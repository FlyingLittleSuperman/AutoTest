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

	public class Fld_TXMGX
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string RWBH="RWBH";
		public const string DYBM="DYBM";
		public const string QLBM="QLBM";
		public const string DYBSM="DYBSM";
		public const string YQLBSM="YQLBSM";
		public const string QTDJBM="QTDJBM";
		public const string QTDJBSM="QTDJBSM";
		public const string DJYWH="DJYWH";
		public const string GXSJ="GXSJ";
		public const string QXDM="QXDM";
		public const string SJLX="SJLX";
        public const string FRWMC = "FRWMC";
        public const string ZRWMC = "ZRWMC";
        public const string YHBSM = "YHBSM";
        public const string ZL = "ZL";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsTXMGX:IEntity
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
		private string m_DYBM;
		private string m_QLBM;
		private long m_DYBSM;
		private long m_YQLBSM;
		private string m_QTDJBM;
		private long m_QTDJBSM;
		private string m_DJYWH;
		private DateTime m_GXSJ;
		private long m_QXDM;
		private int m_SJLX;
        private string m_FRWMC;
        private string m_ZRWMC;
        private string m_ZL;
        private long m_YHBSM;
		private long m_BG_BB;

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
		public long DYBSM
		{
			get{ return m_DYBSM; }
			set{ m_DYBSM = value; }
		}
		public long YQLBSM
		{
			get{ return m_YQLBSM; }
			set{ m_YQLBSM = value; }
		}
		public string QTDJBM
		{
			get{ return m_QTDJBM; }
			set{ m_QTDJBM = value; }
		}
		public long QTDJBSM
		{
			get{ return m_QTDJBSM; }
			set{ m_QTDJBSM = value; }
		}
		public string DJYWH
		{
			get{ return m_DJYWH; }
			set{ m_DJYWH = value; }
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
		public int SJLX
		{
			get{ return m_SJLX; }
			set{ m_SJLX = value; }
		}
        public long YHBSM
        {
            get { return m_YHBSM; }
            set { m_YHBSM = value; }
        }
        public string ZL
        {
            get { return m_ZL; }
            set { m_ZL = value; }
        }
        public string FRWMC
        {
            get { return m_FRWMC; }
            set { m_FRWMC = value; }
        }
        public string ZRWMC
        {
            get { return m_ZRWMC; }
            set { m_ZRWMC = value; }
        }
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

		#endregion
		public bool IsEquals(clsTXMGX obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.RWBH != obj.RWBH) bolResult = false;
			if (this.DYBM != obj.DYBM) bolResult = false;
			if (this.QLBM != obj.QLBM) bolResult = false;
			if (this.DYBSM != obj.DYBSM) bolResult = false;
			if (this.YQLBSM != obj.YQLBSM) bolResult = false;
			if (this.QTDJBM != obj.QTDJBM) bolResult = false;
			if (this.QTDJBSM != obj.QTDJBSM) bolResult = false;
			if (this.DJYWH != obj.DJYWH) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.SJLX != obj.SJLX) bolResult = false;
            if (this.YHBSM != obj.YHBSM) bolResult = false;
            if (this.FRWMC != obj.FRWMC) bolResult = false;
            if (this.ZRWMC != obj.ZRWMC) bolResult = false;
            if (this.ZL != obj.ZL) bolResult = false;
			return bolResult;
		}

		public void Colne(clsTXMGX obj)
		{
			this.BSM=obj.BSM;
			this.RWBH=obj.RWBH;
			this.DYBM=obj.DYBM;
			this.QLBM=obj.QLBM;
			this.DYBSM=obj.DYBSM;
			this.YQLBSM=obj.YQLBSM;
			this.QTDJBM=obj.QTDJBM;
			this.QTDJBSM=obj.QTDJBSM;
			this.DJYWH=obj.DJYWH;
			this.GXSJ=obj.GXSJ;
			this.QXDM=obj.QXDM;
			this.SJLX=obj.SJLX;
            this.FRWMC = obj.FRWMC;
            this.ZL = obj.ZL;
            this.ZRWMC = obj.ZRWMC;
            this.YHBSM = obj.YHBSM;
		}

	}

	public class clsTXMGXSet:EntityBaseSet
	{
		public clsTXMGXSet()
		{
			m_TableName="T_XMGX";
			m_HisTableName="T_XMGX_LS";
			m_PrimaryKeyName="BSM";
            m_SequenceName = "BDCDJ.SEQ_BSM";
			m_ClsName="clsTXMGXSet";
		}
		public static clsTXMGXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsTXMGXSet clsSet = new clsTXMGXSet(); //(clsTXMGXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsTXMGXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsTXMGX obj = (clsTXMGX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("RWBH")) datarow["RWBH"] = obj.RWBH;
				if(datarow.Table.Columns.Contains("DYBM")) datarow["DYBM"] = obj.DYBM;
				if(datarow.Table.Columns.Contains("QLBM")) datarow["QLBM"] = obj.QLBM;
				if(datarow.Table.Columns.Contains("DYBSM")) datarow["DYBSM"] = obj.DYBSM;
				if(datarow.Table.Columns.Contains("YQLBSM")) datarow["YQLBSM"] = obj.YQLBSM;
				if(datarow.Table.Columns.Contains("QTDJBM")) datarow["QTDJBM"] = obj.QTDJBM;
				if(datarow.Table.Columns.Contains("QTDJBSM")) datarow["QTDJBSM"] = obj.QTDJBSM;
				if(datarow.Table.Columns.Contains("DJYWH")) datarow["DJYWH"] = obj.DJYWH;
                if (datarow.Table.Columns.Contains("FRWMC")) datarow["FRWMC"] = obj.FRWMC;
                if (datarow.Table.Columns.Contains("ZRWMC")) datarow["ZRWMC"] = obj.ZRWMC;
                if (datarow.Table.Columns.Contains("ZL")) datarow["ZL"] = obj.ZL;
                if (datarow.Table.Columns.Contains("YHBSM")) datarow["YHBSM"] = obj.YHBSM;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("SJLX")) datarow["SJLX"] = obj.SJLX;
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
			clsTXMGX obj = null;
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
					obj = new clsTXMGX();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="RWBH")
								if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
							if(strFldName.ToUpper()=="DYBM")
								if (pRow.Table.Columns.Contains("DYBM") && pRow["DYBM"] != DBNull.Value) { obj.DYBM = Convert.ToString(pRow["DYBM"]); }
							if(strFldName.ToUpper()=="QLBM")
								if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
							if(strFldName.ToUpper()=="DYBSM")
								if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
							if(strFldName.ToUpper()=="YQLBSM")
								if (pRow.Table.Columns.Contains("YQLBSM") && pRow["YQLBSM"] != DBNull.Value) { obj.YQLBSM = Convert.ToInt64(pRow["YQLBSM"]); }
							if(strFldName.ToUpper()=="QTDJBM")
								if (pRow.Table.Columns.Contains("QTDJBM") && pRow["QTDJBM"] != DBNull.Value) { obj.QTDJBM = Convert.ToString(pRow["QTDJBM"]); }
							if(strFldName.ToUpper()=="QTDJBSM")
								if (pRow.Table.Columns.Contains("QTDJBSM") && pRow["QTDJBSM"] != DBNull.Value) { obj.QTDJBSM = Convert.ToInt64(pRow["QTDJBSM"]); }
							if(strFldName.ToUpper()=="DJYWH")
								if (pRow.Table.Columns.Contains("DJYWH") && pRow["DJYWH"] != DBNull.Value) { obj.DJYWH = Convert.ToString(pRow["DJYWH"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="SJLX")
								if (pRow.Table.Columns.Contains("SJLX") && pRow["SJLX"] != DBNull.Value) { obj.SJLX = Convert.ToInt16(pRow["SJLX"]); }
                            if (strFldName.ToUpper() == "FRWMC")
                                if (pRow.Table.Columns.Contains("FRWMC") && pRow["FRWMC"] != DBNull.Value) { obj.FRWMC = Convert.ToString(pRow["FRWMC"]); }
                            if (strFldName.ToUpper() == "ZRWMC")
                                if (pRow.Table.Columns.Contains("ZRWMC") && pRow["ZRWMC"] != DBNull.Value) { obj.ZRWMC = Convert.ToString(pRow["ZRWMC"]); }
                            if (strFldName.ToUpper() == "ZL")
                                if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.DJYWH = Convert.ToString(pRow["ZL"]); }
                            if (strFldName.ToUpper() == "YHBSM")
                                if (pRow.Table.Columns.Contains("YHBSM") && pRow["YHBSM"] != DBNull.Value) { obj.YHBSM = Convert.ToInt64(pRow["YHBSM"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
						if (pRow.Table.Columns.Contains("DYBM") && pRow["DYBM"] != DBNull.Value) { obj.DYBM = Convert.ToString(pRow["DYBM"]); }
						if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
						if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
						if (pRow.Table.Columns.Contains("YQLBSM") && pRow["YQLBSM"] != DBNull.Value) { obj.YQLBSM = Convert.ToInt64(pRow["YQLBSM"]); }
						if (pRow.Table.Columns.Contains("QTDJBM") && pRow["QTDJBM"] != DBNull.Value) { obj.QTDJBM = Convert.ToString(pRow["QTDJBM"]); }
						if (pRow.Table.Columns.Contains("QTDJBSM") && pRow["QTDJBSM"] != DBNull.Value) { obj.QTDJBSM = Convert.ToInt64(pRow["QTDJBSM"]); }
						if (pRow.Table.Columns.Contains("DJYWH") && pRow["DJYWH"] != DBNull.Value) { obj.DJYWH = Convert.ToString(pRow["DJYWH"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("SJLX") && pRow["SJLX"] != DBNull.Value) { obj.SJLX = Convert.ToInt16(pRow["SJLX"]); }
                        if (pRow.Table.Columns.Contains("FRWMC") && pRow["FRWMC"] != DBNull.Value) { obj.FRWMC = Convert.ToString(pRow["FRWMC"]); }
                        if (pRow.Table.Columns.Contains("ZRWMC") && pRow["ZRWMC"] != DBNull.Value) { obj.ZRWMC = Convert.ToString(pRow["ZRWMC"]); }
                        if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
                        if (pRow.Table.Columns.Contains("YHBSM") && pRow["YHBSM"] != DBNull.Value) { obj.YHBSM = Convert.ToInt64(pRow["YHBSM"]); }
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
