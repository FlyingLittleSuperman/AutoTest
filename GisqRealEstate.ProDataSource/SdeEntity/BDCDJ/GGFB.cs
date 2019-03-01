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

	public class Fld_GGFB
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string GGTS="GGTS";
		public const string GGSJ="GGSJ";
		public const string GGKSSJ="GGKSSJ";
		public const string GGJSSJ="GGJSSJ";
		public const string GGNF="GGNF";
		public const string GGXH="GGXH";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string BZ_GG_LX="BZ_GG_LX";
		public const string BZ_GGR="BZ_GGR";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string GGFBSJ="GGFBSJ";
		public const string GGFBKSSJ="GGFBKSSJ";
		public const string GGFBJSSJ="GGFBJSSJ";
		public const string GGFBZT="GGFBZT";
		#endregion
	}

	public class clsGGFB:IEntity
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
		private int m_GGTS;
		private DateTime m_GGSJ;
		private DateTime m_GGKSSJ;
		private DateTime m_GGJSSJ;
		private long m_GGNF;
		private long m_GGXH;
		private long m_QXDM;
		private long m_REV_;
		private string m_YXTBM;
		private string m_YXTBSM;
		private string m_BZ_GG_LX;
		private string m_BZ_GGR;
		private DateTime m_GXSJ;
		private string m_BZ;
		private DateTime m_GGFBSJ;
		private DateTime m_GGFBKSSJ;
		private DateTime m_GGFBJSSJ;
		private long m_GGFBZT;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public int GGTS
		{
			get{ return m_GGTS; }
			set{ m_GGTS = value; }
		}
		public DateTime GGSJ
		{
			get{ return m_GGSJ; }
			set{ m_GGSJ = value; }
		}
		public DateTime GGKSSJ
		{
			get{ return m_GGKSSJ; }
			set{ m_GGKSSJ = value; }
		}
		public DateTime GGJSSJ
		{
			get{ return m_GGJSSJ; }
			set{ m_GGJSSJ = value; }
		}
		public long GGNF
		{
			get{ return m_GGNF; }
			set{ m_GGNF = value; }
		}
		public long GGXH
		{
			get{ return m_GGXH; }
			set{ m_GGXH = value; }
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
		public string BZ_GG_LX
		{
			get{ return m_BZ_GG_LX; }
			set{ m_BZ_GG_LX = value; }
		}
		public string BZ_GGR
		{
			get{ return m_BZ_GGR; }
			set{ m_BZ_GGR = value; }
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
		public DateTime GGFBSJ
		{
			get{ return m_GGFBSJ; }
			set{ m_GGFBSJ = value; }
		}
		public DateTime GGFBKSSJ
		{
			get{ return m_GGFBKSSJ; }
			set{ m_GGFBKSSJ = value; }
		}
		public DateTime GGFBJSSJ
		{
			get{ return m_GGFBJSSJ; }
			set{ m_GGFBJSSJ = value; }
		}
		public long GGFBZT
		{
			get{ return m_GGFBZT; }
			set{ m_GGFBZT = value; }
		}

		#endregion
		public bool IsEquals(clsGGFB obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.GGTS != obj.GGTS) bolResult = false;
			if (this.GGSJ != obj.GGSJ) bolResult = false;
			if (this.GGKSSJ != obj.GGKSSJ) bolResult = false;
			if (this.GGJSSJ != obj.GGJSSJ) bolResult = false;
			if (this.GGNF != obj.GGNF) bolResult = false;
			if (this.GGXH != obj.GGXH) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.BZ_GG_LX != obj.BZ_GG_LX) bolResult = false;
			if (this.BZ_GGR != obj.BZ_GGR) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.GGFBSJ != obj.GGFBSJ) bolResult = false;
			if (this.GGFBKSSJ != obj.GGFBKSSJ) bolResult = false;
			if (this.GGFBJSSJ != obj.GGFBJSSJ) bolResult = false;
			if (this.GGFBZT != obj.GGFBZT) bolResult = false;
			return bolResult;
		}

		public void Colne(clsGGFB obj)
		{
			this.BSM=obj.BSM;
			this.GGTS=obj.GGTS;
			this.GGSJ=obj.GGSJ;
			this.GGKSSJ=obj.GGKSSJ;
			this.GGJSSJ=obj.GGJSSJ;
			this.GGNF=obj.GGNF;
			this.GGXH=obj.GGXH;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.BZ_GG_LX=obj.BZ_GG_LX;
			this.BZ_GGR=obj.BZ_GGR;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.GGFBSJ=obj.GGFBSJ;
			this.GGFBKSSJ=obj.GGFBKSSJ;
			this.GGFBJSSJ=obj.GGFBJSSJ;
			this.GGFBZT=obj.GGFBZT;
		}

	}

	public class clsGGFBSet:EntityBaseSet
	{
		public clsGGFBSet()
		{
			m_TableName="BDCDJ.GGFB";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsGGFBSet";
		}
		public static clsGGFBSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsGGFBSet clsSet = new clsGGFBSet(); //(clsGGFBSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsGGFBSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsGGFB obj = (clsGGFB)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("GGTS")) datarow["GGTS"] = obj.GGTS;
				if (obj.GGSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GGSJ")) datarow["GGSJ"] = obj.GGSJ;
				}
				if (obj.GGKSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GGKSSJ")) datarow["GGKSSJ"] = obj.GGKSSJ;
				}
				if (obj.GGJSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GGJSSJ")) datarow["GGJSSJ"] = obj.GGJSSJ;
				}
				if(datarow.Table.Columns.Contains("GGNF")) datarow["GGNF"] = obj.GGNF;
				if(datarow.Table.Columns.Contains("GGXH")) datarow["GGXH"] = obj.GGXH;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("BZ_GG_LX")) datarow["BZ_GG_LX"] = obj.BZ_GG_LX;
				if(datarow.Table.Columns.Contains("BZ_GGR")) datarow["BZ_GGR"] = obj.BZ_GGR;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if (obj.GGFBSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GGFBSJ")) datarow["GGFBSJ"] = obj.GGFBSJ;
				}
				if (obj.GGFBKSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GGFBKSSJ")) datarow["GGFBKSSJ"] = obj.GGFBKSSJ;
				}
				if (obj.GGFBJSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GGFBJSSJ")) datarow["GGFBJSSJ"] = obj.GGFBJSSJ;
				}
				if(datarow.Table.Columns.Contains("GGFBZT")) datarow["GGFBZT"] = obj.GGFBZT;
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
			clsGGFB obj = null;
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
					obj = new clsGGFB();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="GGTS")
								if (pRow.Table.Columns.Contains("GGTS") && pRow["GGTS"] != DBNull.Value) { obj.GGTS = Convert.ToInt16(pRow["GGTS"]); }
							if(strFldName.ToUpper()=="GGSJ")
								if (pRow.Table.Columns.Contains("GGSJ") && pRow["GGSJ"] != DBNull.Value) { obj.GGSJ = Convert.ToDateTime(pRow["GGSJ"]); }
							if(strFldName.ToUpper()=="GGKSSJ")
								if (pRow.Table.Columns.Contains("GGKSSJ") && pRow["GGKSSJ"] != DBNull.Value) { obj.GGKSSJ = Convert.ToDateTime(pRow["GGKSSJ"]); }
							if(strFldName.ToUpper()=="GGJSSJ")
								if (pRow.Table.Columns.Contains("GGJSSJ") && pRow["GGJSSJ"] != DBNull.Value) { obj.GGJSSJ = Convert.ToDateTime(pRow["GGJSSJ"]); }
							if(strFldName.ToUpper()=="GGNF")
								if (pRow.Table.Columns.Contains("GGNF") && pRow["GGNF"] != DBNull.Value) { obj.GGNF = Convert.ToInt64(pRow["GGNF"]); }
							if(strFldName.ToUpper()=="GGXH")
								if (pRow.Table.Columns.Contains("GGXH") && pRow["GGXH"] != DBNull.Value) { obj.GGXH = Convert.ToInt64(pRow["GGXH"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
							if(strFldName.ToUpper()=="BZ_GG_LX")
								if (pRow.Table.Columns.Contains("BZ_GG_LX") && pRow["BZ_GG_LX"] != DBNull.Value) { obj.BZ_GG_LX = Convert.ToString(pRow["BZ_GG_LX"]); }
							if(strFldName.ToUpper()=="BZ_GGR")
								if (pRow.Table.Columns.Contains("BZ_GGR") && pRow["BZ_GGR"] != DBNull.Value) { obj.BZ_GGR = Convert.ToString(pRow["BZ_GGR"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="GGFBSJ")
								if (pRow.Table.Columns.Contains("GGFBSJ") && pRow["GGFBSJ"] != DBNull.Value) { obj.GGFBSJ = Convert.ToDateTime(pRow["GGFBSJ"]); }
							if(strFldName.ToUpper()=="GGFBKSSJ")
								if (pRow.Table.Columns.Contains("GGFBKSSJ") && pRow["GGFBKSSJ"] != DBNull.Value) { obj.GGFBKSSJ = Convert.ToDateTime(pRow["GGFBKSSJ"]); }
							if(strFldName.ToUpper()=="GGFBJSSJ")
								if (pRow.Table.Columns.Contains("GGFBJSSJ") && pRow["GGFBJSSJ"] != DBNull.Value) { obj.GGFBJSSJ = Convert.ToDateTime(pRow["GGFBJSSJ"]); }
							if(strFldName.ToUpper()=="GGFBZT")
								if (pRow.Table.Columns.Contains("GGFBZT") && pRow["GGFBZT"] != DBNull.Value) { obj.GGFBZT = Convert.ToInt64(pRow["GGFBZT"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("GGTS") && pRow["GGTS"] != DBNull.Value) { obj.GGTS = Convert.ToInt16(pRow["GGTS"]); }
						if (pRow.Table.Columns.Contains("GGSJ") && pRow["GGSJ"] != DBNull.Value) { obj.GGSJ = Convert.ToDateTime(pRow["GGSJ"]); }
						if (pRow.Table.Columns.Contains("GGKSSJ") && pRow["GGKSSJ"] != DBNull.Value) { obj.GGKSSJ = Convert.ToDateTime(pRow["GGKSSJ"]); }
						if (pRow.Table.Columns.Contains("GGJSSJ") && pRow["GGJSSJ"] != DBNull.Value) { obj.GGJSSJ = Convert.ToDateTime(pRow["GGJSSJ"]); }
						if (pRow.Table.Columns.Contains("GGNF") && pRow["GGNF"] != DBNull.Value) { obj.GGNF = Convert.ToInt64(pRow["GGNF"]); }
						if (pRow.Table.Columns.Contains("GGXH") && pRow["GGXH"] != DBNull.Value) { obj.GGXH = Convert.ToInt64(pRow["GGXH"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
						if (pRow.Table.Columns.Contains("BZ_GG_LX") && pRow["BZ_GG_LX"] != DBNull.Value) { obj.BZ_GG_LX = Convert.ToString(pRow["BZ_GG_LX"]); }
						if (pRow.Table.Columns.Contains("BZ_GGR") && pRow["BZ_GGR"] != DBNull.Value) { obj.BZ_GGR = Convert.ToString(pRow["BZ_GGR"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("GGFBSJ") && pRow["GGFBSJ"] != DBNull.Value) { obj.GGFBSJ = Convert.ToDateTime(pRow["GGFBSJ"]); }
						if (pRow.Table.Columns.Contains("GGFBKSSJ") && pRow["GGFBKSSJ"] != DBNull.Value) { obj.GGFBKSSJ = Convert.ToDateTime(pRow["GGFBKSSJ"]); }
						if (pRow.Table.Columns.Contains("GGFBJSSJ") && pRow["GGFBJSSJ"] != DBNull.Value) { obj.GGFBJSSJ = Convert.ToDateTime(pRow["GGFBJSSJ"]); }
						if (pRow.Table.Columns.Contains("GGFBZT") && pRow["GGFBZT"] != DBNull.Value) { obj.GGFBZT = Convert.ToInt64(pRow["GGFBZT"]); }
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
