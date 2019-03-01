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

	public class Fld_BDCDY
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string BDCDYH="BDCDYH";
		public const string ZDZHBSM="ZDZHBSM";
		public const string ZDZHBM="ZDZHBM";
		public const string DCZDZHBSM="DCZDZHBSM";
		public const string DCZDZHBM="DCZDZHBM";
		public const string DZWDYBSM="DZWDYBSM";
		public const string DZWDYBM="DZWDYBM";
		public const string DCDZWDYBSM="DCDZWDYBSM";
		public const string DCDZWDYBM="DCDZWDYBM";
		public const string BDCDYLX="BDCDYLX";
		public const string ZL="ZL";
		public const string ZDZHDM="ZDZHDM";
		public const string DZWBM="DZWBM";
		public const string DZWTZM="DZWTZM";
		public const string DZWSXH="DZWSXH";
		public const string QXDM="QXDM";
		public const string GXSJ="GXSJ";
		public const string REV_="REV_";
		public const string DCSCDZWDYBSM="DCSCDZWDYBSM";
		public const string BZ="BZ";
		public const string DCZBSM="DCZBSM";
		public const string YXTBM="YXTBM";
		#endregion
	}

	public class clsBDCDY:IEntity
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
		private string m_BDCDYH;
		private long m_ZDZHBSM;
		private string m_ZDZHBM;
		private long m_DCZDZHBSM;
		private string m_DCZDZHBM;
		private long m_DZWDYBSM;
		private string m_DZWDYBM;
		private long m_DCDZWDYBSM;
		private string m_DCDZWDYBM;
		private string m_BDCDYLX;
		private string m_ZL;
		private string m_ZDZHDM;
		private string m_DZWBM;
		private string m_DZWTZM;
		private long m_DZWSXH;
		private long m_QXDM;
		private DateTime m_GXSJ;
		private long m_REV_;
		private long m_DCSCDZWDYBSM;
		private string m_BZ;
		private long m_DCZBSM;
		private string m_YXTBM;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public string BDCDYH
		{
			get{ return m_BDCDYH; }
			set{ m_BDCDYH = value; }
		}
		public long ZDZHBSM
		{
			get{ return m_ZDZHBSM; }
			set{ m_ZDZHBSM = value; }
		}
		public string ZDZHBM
		{
			get{ return m_ZDZHBM; }
			set{ m_ZDZHBM = value; }
		}
		public long DCZDZHBSM
		{
			get{ return m_DCZDZHBSM; }
			set{ m_DCZDZHBSM = value; }
		}
		public string DCZDZHBM
		{
			get{ return m_DCZDZHBM; }
			set{ m_DCZDZHBM = value; }
		}
		public long DZWDYBSM
		{
			get{ return m_DZWDYBSM; }
			set{ m_DZWDYBSM = value; }
		}
		public string DZWDYBM
		{
			get{ return m_DZWDYBM; }
			set{ m_DZWDYBM = value; }
		}
		public long DCDZWDYBSM
		{
			get{ return m_DCDZWDYBSM; }
			set{ m_DCDZWDYBSM = value; }
		}
		public string DCDZWDYBM
		{
			get{ return m_DCDZWDYBM; }
			set{ m_DCDZWDYBM = value; }
		}
		public string BDCDYLX
		{
			get{ return m_BDCDYLX; }
			set{ m_BDCDYLX = value; }
		}
		public string ZL
		{
			get{ return m_ZL; }
			set{ m_ZL = value; }
		}
		public string ZDZHDM
		{
			get{ return m_ZDZHDM; }
			set{ m_ZDZHDM = value; }
		}
		public string DZWBM
		{
			get{ return m_DZWBM; }
			set{ m_DZWBM = value; }
		}
		public string DZWTZM
		{
			get{ return m_DZWTZM; }
			set{ m_DZWTZM = value; }
		}
		public long DZWSXH
		{
			get{ return m_DZWSXH; }
			set{ m_DZWSXH = value; }
		}
		public long QXDM
		{
			get{ return m_QXDM; }
			set{ m_QXDM = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		public long REV_
		{
			get{ return m_REV_; }
			set{ m_REV_ = value; }
		}
		public long DCSCDZWDYBSM
		{
			get{ return m_DCSCDZWDYBSM; }
			set{ m_DCSCDZWDYBSM = value; }
		}
		public string BZ
		{
			get{ return m_BZ; }
			set{ m_BZ = value; }
		}
		public long DCZBSM
		{
			get{ return m_DCZBSM; }
			set{ m_DCZBSM = value; }
		}
		public string YXTBM
		{
			get{ return m_YXTBM; }
			set{ m_YXTBM = value; }
		}

		#endregion
		public bool IsEquals(clsBDCDY obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.ZDZHBSM != obj.ZDZHBSM) bolResult = false;
			if (this.ZDZHBM != obj.ZDZHBM) bolResult = false;
			if (this.DCZDZHBSM != obj.DCZDZHBSM) bolResult = false;
			if (this.DCZDZHBM != obj.DCZDZHBM) bolResult = false;
			if (this.DZWDYBSM != obj.DZWDYBSM) bolResult = false;
			if (this.DZWDYBM != obj.DZWDYBM) bolResult = false;
			if (this.DCDZWDYBSM != obj.DCDZWDYBSM) bolResult = false;
			if (this.DCDZWDYBM != obj.DCDZWDYBM) bolResult = false;
			if (this.BDCDYLX != obj.BDCDYLX) bolResult = false;
			if (this.ZL != obj.ZL) bolResult = false;
			if (this.ZDZHDM != obj.ZDZHDM) bolResult = false;
			if (this.DZWBM != obj.DZWBM) bolResult = false;
			if (this.DZWTZM != obj.DZWTZM) bolResult = false;
			if (this.DZWSXH != obj.DZWSXH) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.DCSCDZWDYBSM != obj.DCSCDZWDYBSM) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.DCZBSM != obj.DCZBSM) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			return bolResult;
		}

		public void Colne(clsBDCDY obj)
		{
			this.BSM=obj.BSM;
			this.BDCDYH=obj.BDCDYH;
			this.ZDZHBSM=obj.ZDZHBSM;
			this.ZDZHBM=obj.ZDZHBM;
			this.DCZDZHBSM=obj.DCZDZHBSM;
			this.DCZDZHBM=obj.DCZDZHBM;
			this.DZWDYBSM=obj.DZWDYBSM;
			this.DZWDYBM=obj.DZWDYBM;
			this.DCDZWDYBSM=obj.DCDZWDYBSM;
			this.DCDZWDYBM=obj.DCDZWDYBM;
			this.BDCDYLX=obj.BDCDYLX;
			this.ZL=obj.ZL;
			this.ZDZHDM=obj.ZDZHDM;
			this.DZWBM=obj.DZWBM;
			this.DZWTZM=obj.DZWTZM;
			this.DZWSXH=obj.DZWSXH;
			this.QXDM=obj.QXDM;
			this.GXSJ=obj.GXSJ;
			this.REV_=obj.REV_;
			this.DCSCDZWDYBSM=obj.DCSCDZWDYBSM;
			this.BZ=obj.BZ;
			this.DCZBSM=obj.DCZBSM;
			this.YXTBM=obj.YXTBM;
		}

	}

	public class clsBDCDYSet:EntityBaseSet
	{
		public clsBDCDYSet()
		{
			m_TableName="BDCDJ.BDCDY";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsBDCDYSet";
		}
		public static clsBDCDYSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsBDCDYSet clsSet = new clsBDCDYSet(); //(clsBDCDYSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsBDCDYSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsBDCDY obj = (clsBDCDY)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("ZDZHBSM")) datarow["ZDZHBSM"] = obj.ZDZHBSM;
				if(datarow.Table.Columns.Contains("ZDZHBM")) datarow["ZDZHBM"] = obj.ZDZHBM;
				if(datarow.Table.Columns.Contains("DCZDZHBSM")) datarow["DCZDZHBSM"] = obj.DCZDZHBSM;
				if(datarow.Table.Columns.Contains("DCZDZHBM")) datarow["DCZDZHBM"] = obj.DCZDZHBM;
				if(datarow.Table.Columns.Contains("DZWDYBSM")) datarow["DZWDYBSM"] = obj.DZWDYBSM;
				if(datarow.Table.Columns.Contains("DZWDYBM")) datarow["DZWDYBM"] = obj.DZWDYBM;
				if(datarow.Table.Columns.Contains("DCDZWDYBSM")) datarow["DCDZWDYBSM"] = obj.DCDZWDYBSM;
				if(datarow.Table.Columns.Contains("DCDZWDYBM")) datarow["DCDZWDYBM"] = obj.DCDZWDYBM;
				if(datarow.Table.Columns.Contains("BDCDYLX")) datarow["BDCDYLX"] = obj.BDCDYLX;
				if(datarow.Table.Columns.Contains("ZL")) datarow["ZL"] = obj.ZL;
				if(datarow.Table.Columns.Contains("ZDZHDM")) datarow["ZDZHDM"] = obj.ZDZHDM;
				if(datarow.Table.Columns.Contains("DZWBM")) datarow["DZWBM"] = obj.DZWBM;
				if(datarow.Table.Columns.Contains("DZWTZM")) datarow["DZWTZM"] = obj.DZWTZM;
				if(datarow.Table.Columns.Contains("DZWSXH")) datarow["DZWSXH"] = obj.DZWSXH;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("DCSCDZWDYBSM")) datarow["DCSCDZWDYBSM"] = obj.DCSCDZWDYBSM;
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("DCZBSM")) datarow["DCZBSM"] = obj.DCZBSM;
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
			clsBDCDY obj = null;
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
					obj = new clsBDCDY();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="BDCDYH")
								if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
							if(strFldName.ToUpper()=="ZDZHBSM")
								if (pRow.Table.Columns.Contains("ZDZHBSM") && pRow["ZDZHBSM"] != DBNull.Value) { obj.ZDZHBSM = Convert.ToInt64(pRow["ZDZHBSM"]); }
							if(strFldName.ToUpper()=="ZDZHBM")
								if (pRow.Table.Columns.Contains("ZDZHBM") && pRow["ZDZHBM"] != DBNull.Value) { obj.ZDZHBM = Convert.ToString(pRow["ZDZHBM"]); }
							if(strFldName.ToUpper()=="DCZDZHBSM")
								if (pRow.Table.Columns.Contains("DCZDZHBSM") && pRow["DCZDZHBSM"] != DBNull.Value) { obj.DCZDZHBSM = Convert.ToInt64(pRow["DCZDZHBSM"]); }
							if(strFldName.ToUpper()=="DCZDZHBM")
								if (pRow.Table.Columns.Contains("DCZDZHBM") && pRow["DCZDZHBM"] != DBNull.Value) { obj.DCZDZHBM = Convert.ToString(pRow["DCZDZHBM"]); }
							if(strFldName.ToUpper()=="DZWDYBSM")
								if (pRow.Table.Columns.Contains("DZWDYBSM") && pRow["DZWDYBSM"] != DBNull.Value) { obj.DZWDYBSM = Convert.ToInt64(pRow["DZWDYBSM"]); }
							if(strFldName.ToUpper()=="DZWDYBM")
								if (pRow.Table.Columns.Contains("DZWDYBM") && pRow["DZWDYBM"] != DBNull.Value) { obj.DZWDYBM = Convert.ToString(pRow["DZWDYBM"]); }
							if(strFldName.ToUpper()=="DCDZWDYBSM")
								if (pRow.Table.Columns.Contains("DCDZWDYBSM") && pRow["DCDZWDYBSM"] != DBNull.Value) { obj.DCDZWDYBSM = Convert.ToInt64(pRow["DCDZWDYBSM"]); }
							if(strFldName.ToUpper()=="DCDZWDYBM")
								if (pRow.Table.Columns.Contains("DCDZWDYBM") && pRow["DCDZWDYBM"] != DBNull.Value) { obj.DCDZWDYBM = Convert.ToString(pRow["DCDZWDYBM"]); }
							if(strFldName.ToUpper()=="BDCDYLX")
								if (pRow.Table.Columns.Contains("BDCDYLX") && pRow["BDCDYLX"] != DBNull.Value) { obj.BDCDYLX = Convert.ToString(pRow["BDCDYLX"]); }
							if(strFldName.ToUpper()=="ZL")
								if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
							if(strFldName.ToUpper()=="ZDZHDM")
								if (pRow.Table.Columns.Contains("ZDZHDM") && pRow["ZDZHDM"] != DBNull.Value) { obj.ZDZHDM = Convert.ToString(pRow["ZDZHDM"]); }
							if(strFldName.ToUpper()=="DZWBM")
								if (pRow.Table.Columns.Contains("DZWBM") && pRow["DZWBM"] != DBNull.Value) { obj.DZWBM = Convert.ToString(pRow["DZWBM"]); }
							if(strFldName.ToUpper()=="DZWTZM")
								if (pRow.Table.Columns.Contains("DZWTZM") && pRow["DZWTZM"] != DBNull.Value) { obj.DZWTZM = Convert.ToString(pRow["DZWTZM"]); }
							if(strFldName.ToUpper()=="DZWSXH")
								if (pRow.Table.Columns.Contains("DZWSXH") && pRow["DZWSXH"] != DBNull.Value) { obj.DZWSXH = Convert.ToInt64(pRow["DZWSXH"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="DCSCDZWDYBSM")
								if (pRow.Table.Columns.Contains("DCSCDZWDYBSM") && pRow["DCSCDZWDYBSM"] != DBNull.Value) { obj.DCSCDZWDYBSM = Convert.ToInt64(pRow["DCSCDZWDYBSM"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="DCZBSM")
								if (pRow.Table.Columns.Contains("DCZBSM") && pRow["DCZBSM"] != DBNull.Value) { obj.DCZBSM = Convert.ToInt64(pRow["DCZBSM"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("ZDZHBSM") && pRow["ZDZHBSM"] != DBNull.Value) { obj.ZDZHBSM = Convert.ToInt64(pRow["ZDZHBSM"]); }
						if (pRow.Table.Columns.Contains("ZDZHBM") && pRow["ZDZHBM"] != DBNull.Value) { obj.ZDZHBM = Convert.ToString(pRow["ZDZHBM"]); }
						if (pRow.Table.Columns.Contains("DCZDZHBSM") && pRow["DCZDZHBSM"] != DBNull.Value) { obj.DCZDZHBSM = Convert.ToInt64(pRow["DCZDZHBSM"]); }
						if (pRow.Table.Columns.Contains("DCZDZHBM") && pRow["DCZDZHBM"] != DBNull.Value) { obj.DCZDZHBM = Convert.ToString(pRow["DCZDZHBM"]); }
						if (pRow.Table.Columns.Contains("DZWDYBSM") && pRow["DZWDYBSM"] != DBNull.Value) { obj.DZWDYBSM = Convert.ToInt64(pRow["DZWDYBSM"]); }
						if (pRow.Table.Columns.Contains("DZWDYBM") && pRow["DZWDYBM"] != DBNull.Value) { obj.DZWDYBM = Convert.ToString(pRow["DZWDYBM"]); }
						if (pRow.Table.Columns.Contains("DCDZWDYBSM") && pRow["DCDZWDYBSM"] != DBNull.Value) { obj.DCDZWDYBSM = Convert.ToInt64(pRow["DCDZWDYBSM"]); }
						if (pRow.Table.Columns.Contains("DCDZWDYBM") && pRow["DCDZWDYBM"] != DBNull.Value) { obj.DCDZWDYBM = Convert.ToString(pRow["DCDZWDYBM"]); }
						if (pRow.Table.Columns.Contains("BDCDYLX") && pRow["BDCDYLX"] != DBNull.Value) { obj.BDCDYLX = Convert.ToString(pRow["BDCDYLX"]); }
						if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
						if (pRow.Table.Columns.Contains("ZDZHDM") && pRow["ZDZHDM"] != DBNull.Value) { obj.ZDZHDM = Convert.ToString(pRow["ZDZHDM"]); }
						if (pRow.Table.Columns.Contains("DZWBM") && pRow["DZWBM"] != DBNull.Value) { obj.DZWBM = Convert.ToString(pRow["DZWBM"]); }
						if (pRow.Table.Columns.Contains("DZWTZM") && pRow["DZWTZM"] != DBNull.Value) { obj.DZWTZM = Convert.ToString(pRow["DZWTZM"]); }
						if (pRow.Table.Columns.Contains("DZWSXH") && pRow["DZWSXH"] != DBNull.Value) { obj.DZWSXH = Convert.ToInt64(pRow["DZWSXH"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("DCSCDZWDYBSM") && pRow["DCSCDZWDYBSM"] != DBNull.Value) { obj.DCSCDZWDYBSM = Convert.ToInt64(pRow["DCSCDZWDYBSM"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("DCZBSM") && pRow["DCZBSM"] != DBNull.Value) { obj.DCZBSM = Convert.ToInt64(pRow["DCZBSM"]); }
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
