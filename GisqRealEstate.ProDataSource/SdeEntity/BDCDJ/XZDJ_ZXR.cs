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

	public class Fld_XZDJZXR
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string XZDJBSM="XZDJBSM";
		public const string XM="XM";
		public const string GZZH="GZZH";
		public const string ZXGWZH="ZXGWZH";
		public const string LXDH="LXDH";
		public const string DZYX="DZYX";
		public const string QXDM="QXDM";
		public const string REV_="REV_";
		public const string YWH="YWH";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string YXTBM="YXTBM";
		#endregion
	}

	public class clsXZDJZXR:IEntity
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
		private long m_XZDJBSM;
		private string m_XM;
		private string m_GZZH;
		private string m_ZXGWZH;
		private string m_LXDH;
		private string m_DZYX;
		private long m_QXDM;
		private long m_REV_;
		private string m_YWH;
		private DateTime m_GXSJ;
		private string m_BZ;
		private string m_YXTBM;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public long XZDJBSM
		{
			get{ return m_XZDJBSM; }
			set{ m_XZDJBSM = value; }
		}
		public string XM
		{
			get{ return m_XM; }
			set{ m_XM = value; }
		}
		public string GZZH
		{
			get{ return m_GZZH; }
			set{ m_GZZH = value; }
		}
		public string ZXGWZH
		{
			get{ return m_ZXGWZH; }
			set{ m_ZXGWZH = value; }
		}
		public string LXDH
		{
			get{ return m_LXDH; }
			set{ m_LXDH = value; }
		}
		public string DZYX
		{
			get{ return m_DZYX; }
			set{ m_DZYX = value; }
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
		public string YWH
		{
			get{ return m_YWH; }
			set{ m_YWH = value; }
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
		public string YXTBM
		{
			get{ return m_YXTBM; }
			set{ m_YXTBM = value; }
		}

		#endregion
		public bool IsEquals(clsXZDJZXR obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.XZDJBSM != obj.XZDJBSM) bolResult = false;
			if (this.XM != obj.XM) bolResult = false;
			if (this.GZZH != obj.GZZH) bolResult = false;
			if (this.ZXGWZH != obj.ZXGWZH) bolResult = false;
			if (this.LXDH != obj.LXDH) bolResult = false;
			if (this.DZYX != obj.DZYX) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			return bolResult;
		}

		public void Colne(clsXZDJZXR obj)
		{
			this.BSM=obj.BSM;
			this.XZDJBSM=obj.XZDJBSM;
			this.XM=obj.XM;
			this.GZZH=obj.GZZH;
			this.ZXGWZH=obj.ZXGWZH;
			this.LXDH=obj.LXDH;
			this.DZYX=obj.DZYX;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.YWH=obj.YWH;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.YXTBM=obj.YXTBM;
		}

	}

	public class clsXZDJZXRSet:EntityBaseSet
	{
		public clsXZDJZXRSet()
		{
			m_TableName="BDCDJ.XZDJ_ZXR";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsXZDJZXRSet";
		}
		public static clsXZDJZXRSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsXZDJZXRSet clsSet = new clsXZDJZXRSet(); //(clsXZDJZXRSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsXZDJZXRSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsXZDJZXR obj = (clsXZDJZXR)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("XZDJBSM")) datarow["XZDJBSM"] = obj.XZDJBSM;
				if(datarow.Table.Columns.Contains("XM")) datarow["XM"] = obj.XM;
				if(datarow.Table.Columns.Contains("GZZH")) datarow["GZZH"] = obj.GZZH;
				if(datarow.Table.Columns.Contains("ZXGWZH")) datarow["ZXGWZH"] = obj.ZXGWZH;
				if(datarow.Table.Columns.Contains("LXDH")) datarow["LXDH"] = obj.LXDH;
				if(datarow.Table.Columns.Contains("DZYX")) datarow["DZYX"] = obj.DZYX;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
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
			clsXZDJZXR obj = null;
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
					obj = new clsXZDJZXR();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="XZDJBSM")
								if (pRow.Table.Columns.Contains("XZDJBSM") && pRow["XZDJBSM"] != DBNull.Value) { obj.XZDJBSM = Convert.ToInt64(pRow["XZDJBSM"]); }
							if(strFldName.ToUpper()=="XM")
								if (pRow.Table.Columns.Contains("XM") && pRow["XM"] != DBNull.Value) { obj.XM = Convert.ToString(pRow["XM"]); }
							if(strFldName.ToUpper()=="GZZH")
								if (pRow.Table.Columns.Contains("GZZH") && pRow["GZZH"] != DBNull.Value) { obj.GZZH = Convert.ToString(pRow["GZZH"]); }
							if(strFldName.ToUpper()=="ZXGWZH")
								if (pRow.Table.Columns.Contains("ZXGWZH") && pRow["ZXGWZH"] != DBNull.Value) { obj.ZXGWZH = Convert.ToString(pRow["ZXGWZH"]); }
							if(strFldName.ToUpper()=="LXDH")
								if (pRow.Table.Columns.Contains("LXDH") && pRow["LXDH"] != DBNull.Value) { obj.LXDH = Convert.ToString(pRow["LXDH"]); }
							if(strFldName.ToUpper()=="DZYX")
								if (pRow.Table.Columns.Contains("DZYX") && pRow["DZYX"] != DBNull.Value) { obj.DZYX = Convert.ToString(pRow["DZYX"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("XZDJBSM") && pRow["XZDJBSM"] != DBNull.Value) { obj.XZDJBSM = Convert.ToInt64(pRow["XZDJBSM"]); }
						if (pRow.Table.Columns.Contains("XM") && pRow["XM"] != DBNull.Value) { obj.XM = Convert.ToString(pRow["XM"]); }
						if (pRow.Table.Columns.Contains("GZZH") && pRow["GZZH"] != DBNull.Value) { obj.GZZH = Convert.ToString(pRow["GZZH"]); }
						if (pRow.Table.Columns.Contains("ZXGWZH") && pRow["ZXGWZH"] != DBNull.Value) { obj.ZXGWZH = Convert.ToString(pRow["ZXGWZH"]); }
						if (pRow.Table.Columns.Contains("LXDH") && pRow["LXDH"] != DBNull.Value) { obj.LXDH = Convert.ToString(pRow["LXDH"]); }
						if (pRow.Table.Columns.Contains("DZYX") && pRow["DZYX"] != DBNull.Value) { obj.DZYX = Convert.ToString(pRow["DZYX"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
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
