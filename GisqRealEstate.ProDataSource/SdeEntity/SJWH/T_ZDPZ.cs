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

	public class Fld_TZDPZ
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string BM="BM";
		public const string BMSM="BMSM";
		public const string ZDM="ZDM";
		public const string ZDSM="ZDSM";
		public const string ZDLX="ZDLX";
		public const string SFMJJS="SFMJJS";
		public const string MJJSMC="MJJSMC";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string REV_="REV_";
		public const string SFZJ="SFZJ";
		#endregion
	}

	public class clsTZDPZ:IEntity
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
		private string m_BM;
		private string m_BMSM;
		private string m_ZDM;
		private string m_ZDSM;
		private string m_ZDLX;
		private int m_SFMJJS;
		private string m_MJJSMC;
		private DateTime m_GXSJ;
		private string m_BZ;
		private long m_REV_;
		private int m_SFZJ;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public string BM
		{
			get{ return m_BM; }
			set{ m_BM = value; }
		}
		public string BMSM
		{
			get{ return m_BMSM; }
			set{ m_BMSM = value; }
		}
		public string ZDM
		{
			get{ return m_ZDM; }
			set{ m_ZDM = value; }
		}
		public string ZDSM
		{
			get{ return m_ZDSM; }
			set{ m_ZDSM = value; }
		}
		public string ZDLX
		{
			get{ return m_ZDLX; }
			set{ m_ZDLX = value; }
		}
		public int SFMJJS
		{
			get{ return m_SFMJJS; }
			set{ m_SFMJJS = value; }
		}
		public string MJJSMC
		{
			get{ return m_MJJSMC; }
			set{ m_MJJSMC = value; }
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
		public long REV_
		{
			get{ return m_REV_; }
			set{ m_REV_ = value; }
		}
		public int SFZJ
		{
			get{ return m_SFZJ; }
			set{ m_SFZJ = value; }
		}

		#endregion
		public bool IsEquals(clsTZDPZ obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.BM != obj.BM) bolResult = false;
			if (this.BMSM != obj.BMSM) bolResult = false;
			if (this.ZDM != obj.ZDM) bolResult = false;
			if (this.ZDSM != obj.ZDSM) bolResult = false;
			if (this.ZDLX != obj.ZDLX) bolResult = false;
			if (this.SFMJJS != obj.SFMJJS) bolResult = false;
			if (this.MJJSMC != obj.MJJSMC) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.SFZJ != obj.SFZJ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsTZDPZ obj)
		{
			this.BSM=obj.BSM;
			this.BM=obj.BM;
			this.BMSM=obj.BMSM;
			this.ZDM=obj.ZDM;
			this.ZDSM=obj.ZDSM;
			this.ZDLX=obj.ZDLX;
			this.SFMJJS=obj.SFMJJS;
			this.MJJSMC=obj.MJJSMC;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.REV_=obj.REV_;
			this.SFZJ=obj.SFZJ;
		}

	}

	public class clsTZDPZSet:EntityBaseSet
	{
		public clsTZDPZSet()
		{
			m_TableName="T_ZDPZ";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
            m_SequenceName = "BDCDJ.SEQ_BSM";
			m_ClsName="clsTZDPZSet";
		}
		public static clsTZDPZSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsTZDPZSet clsSet = new clsTZDPZSet(); //(clsTZDPZSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsTZDPZSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsTZDPZ obj = (clsTZDPZ)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("BM")) datarow["BM"] = obj.BM;
				if(datarow.Table.Columns.Contains("BMSM")) datarow["BMSM"] = obj.BMSM;
				if(datarow.Table.Columns.Contains("ZDM")) datarow["ZDM"] = obj.ZDM;
				if(datarow.Table.Columns.Contains("ZDSM")) datarow["ZDSM"] = obj.ZDSM;
				if(datarow.Table.Columns.Contains("ZDLX")) datarow["ZDLX"] = obj.ZDLX;
				if(datarow.Table.Columns.Contains("SFMJJS")) datarow["SFMJJS"] = obj.SFMJJS;
				if(datarow.Table.Columns.Contains("MJJSMC")) datarow["MJJSMC"] = obj.MJJSMC;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("SFZJ")) datarow["SFZJ"] = obj.SFZJ;
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
			clsTZDPZ obj = null;
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
					obj = new clsTZDPZ();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="BM")
								if (pRow.Table.Columns.Contains("BM") && pRow["BM"] != DBNull.Value) { obj.BM = Convert.ToString(pRow["BM"]); }
							if(strFldName.ToUpper()=="BMSM")
								if (pRow.Table.Columns.Contains("BMSM") && pRow["BMSM"] != DBNull.Value) { obj.BMSM = Convert.ToString(pRow["BMSM"]); }
							if(strFldName.ToUpper()=="ZDM")
								if (pRow.Table.Columns.Contains("ZDM") && pRow["ZDM"] != DBNull.Value) { obj.ZDM = Convert.ToString(pRow["ZDM"]); }
							if(strFldName.ToUpper()=="ZDSM")
								if (pRow.Table.Columns.Contains("ZDSM") && pRow["ZDSM"] != DBNull.Value) { obj.ZDSM = Convert.ToString(pRow["ZDSM"]); }
							if(strFldName.ToUpper()=="ZDLX")
								if (pRow.Table.Columns.Contains("ZDLX") && pRow["ZDLX"] != DBNull.Value) { obj.ZDLX = Convert.ToString(pRow["ZDLX"]); }
							if(strFldName.ToUpper()=="SFMJJS")
								if (pRow.Table.Columns.Contains("SFMJJS") && pRow["SFMJJS"] != DBNull.Value) { obj.SFMJJS = Convert.ToInt16(pRow["SFMJJS"]); }
							if(strFldName.ToUpper()=="MJJSMC")
								if (pRow.Table.Columns.Contains("MJJSMC") && pRow["MJJSMC"] != DBNull.Value) { obj.MJJSMC = Convert.ToString(pRow["MJJSMC"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="SFZJ")
								if (pRow.Table.Columns.Contains("SFZJ") && pRow["SFZJ"] != DBNull.Value) { obj.SFZJ = Convert.ToInt16(pRow["SFZJ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("BM") && pRow["BM"] != DBNull.Value) { obj.BM = Convert.ToString(pRow["BM"]); }
						if (pRow.Table.Columns.Contains("BMSM") && pRow["BMSM"] != DBNull.Value) { obj.BMSM = Convert.ToString(pRow["BMSM"]); }
						if (pRow.Table.Columns.Contains("ZDM") && pRow["ZDM"] != DBNull.Value) { obj.ZDM = Convert.ToString(pRow["ZDM"]); }
						if (pRow.Table.Columns.Contains("ZDSM") && pRow["ZDSM"] != DBNull.Value) { obj.ZDSM = Convert.ToString(pRow["ZDSM"]); }
						if (pRow.Table.Columns.Contains("ZDLX") && pRow["ZDLX"] != DBNull.Value) { obj.ZDLX = Convert.ToString(pRow["ZDLX"]); }
						if (pRow.Table.Columns.Contains("SFMJJS") && pRow["SFMJJS"] != DBNull.Value) { obj.SFMJJS = Convert.ToInt16(pRow["SFMJJS"]); }
						if (pRow.Table.Columns.Contains("MJJSMC") && pRow["MJJSMC"] != DBNull.Value) { obj.MJJSMC = Convert.ToString(pRow["MJJSMC"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("SFZJ") && pRow["SFZJ"] != DBNull.Value) { obj.SFZJ = Convert.ToInt16(pRow["SFZJ"]); }
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
