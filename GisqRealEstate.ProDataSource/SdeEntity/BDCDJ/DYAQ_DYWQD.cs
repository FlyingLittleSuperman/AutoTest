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

	public class Fld_DYAQDYWQD
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string YWH="YWH";
		public const string LPMC="LPMC";
		public const string GHXKZ="GHXKZ";
		public const string SGXKZ="SGXKZ";
		public const string BDCDYH="BDCDYH";
		public const string ZL="ZL";
		public const string JZMJ="JZMJ";
		public const string ZGZQSE="ZGZQSE";
		public const string BZ="BZ";
		public const string QXDM="QXDM";
		public const string GXSJ="GXSJ";
		public const string REV_="REV_";
		public const string DYBSM="DYBSM";
		public const string QLBSM="QLBSM";
		public const string QLRBSM="QLRBSM";
		public const string QLQSSJ="QLQSSJ";
		public const string QLJSSJ="QLJSSJ";
		#endregion
	}

	public class clsDYAQDYWQD:IEntity
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
		private string m_LPMC;
		private string m_GHXKZ;
		private string m_SGXKZ;
		private string m_BDCDYH;
		private string m_ZL;
		private double m_JZMJ;
		private double m_ZGZQSE;
		private string m_BZ;
		private long m_QXDM;
		private DateTime m_GXSJ;
		private long m_REV_;
		private long m_DYBSM;
		private long m_QLBSM;
		private long m_QLRBSM;
		private DateTime m_QLQSSJ;
		private DateTime m_QLJSSJ;

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
		public string LPMC
		{
			get{ return m_LPMC; }
			set{ m_LPMC = value; }
		}
		public string GHXKZ
		{
			get{ return m_GHXKZ; }
			set{ m_GHXKZ = value; }
		}
		public string SGXKZ
		{
			get{ return m_SGXKZ; }
			set{ m_SGXKZ = value; }
		}
		public string BDCDYH
		{
			get{ return m_BDCDYH; }
			set{ m_BDCDYH = value; }
		}
		public string ZL
		{
			get{ return m_ZL; }
			set{ m_ZL = value; }
		}
		public double JZMJ
		{
			get{ return m_JZMJ; }
			set{ m_JZMJ = value; }
		}
		public double ZGZQSE
		{
			get{ return m_ZGZQSE; }
			set{ m_ZGZQSE = value; }
		}
		public string BZ
		{
			get{ return m_BZ; }
			set{ m_BZ = value; }
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
		public long DYBSM
		{
			get{ return m_DYBSM; }
			set{ m_DYBSM = value; }
		}
		public long QLBSM
		{
			get{ return m_QLBSM; }
			set{ m_QLBSM = value; }
		}
		public long QLRBSM
		{
			get{ return m_QLRBSM; }
			set{ m_QLRBSM = value; }
		}
		public DateTime QLQSSJ
		{
			get{ return m_QLQSSJ; }
			set{ m_QLQSSJ = value; }
		}
		public DateTime QLJSSJ
		{
			get{ return m_QLJSSJ; }
			set{ m_QLJSSJ = value; }
		}

		#endregion
		public bool IsEquals(clsDYAQDYWQD obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.YWH != obj.YWH) bolResult = false;
			if (this.LPMC != obj.LPMC) bolResult = false;
			if (this.GHXKZ != obj.GHXKZ) bolResult = false;
			if (this.SGXKZ != obj.SGXKZ) bolResult = false;
			if (this.BDCDYH != obj.BDCDYH) bolResult = false;
			if (this.ZL != obj.ZL) bolResult = false;
			if (this.JZMJ != obj.JZMJ) bolResult = false;
			if (this.ZGZQSE != obj.ZGZQSE) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.DYBSM != obj.DYBSM) bolResult = false;
			if (this.QLBSM != obj.QLBSM) bolResult = false;
			if (this.QLRBSM != obj.QLRBSM) bolResult = false;
			if (this.QLQSSJ != obj.QLQSSJ) bolResult = false;
			if (this.QLJSSJ != obj.QLJSSJ) bolResult = false;
			return bolResult;
		}

		public void Colne(clsDYAQDYWQD obj)
		{
			this.BSM=obj.BSM;
			this.YWH=obj.YWH;
			this.LPMC=obj.LPMC;
			this.GHXKZ=obj.GHXKZ;
			this.SGXKZ=obj.SGXKZ;
			this.BDCDYH=obj.BDCDYH;
			this.ZL=obj.ZL;
			this.JZMJ=obj.JZMJ;
			this.ZGZQSE=obj.ZGZQSE;
			this.BZ=obj.BZ;
			this.QXDM=obj.QXDM;
			this.GXSJ=obj.GXSJ;
			this.REV_=obj.REV_;
			this.DYBSM=obj.DYBSM;
			this.QLBSM=obj.QLBSM;
			this.QLRBSM=obj.QLRBSM;
			this.QLQSSJ=obj.QLQSSJ;
			this.QLJSSJ=obj.QLJSSJ;
		}

	}

	public class clsDYAQDYWQDSet:EntityBaseSet
	{
		public clsDYAQDYWQDSet()
		{
			m_TableName="BDCDJ.DYAQ_DYWQD";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsDYAQDYWQDSet";
		}
		public static clsDYAQDYWQDSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsDYAQDYWQDSet clsSet = new clsDYAQDYWQDSet(); //(clsDYAQDYWQDSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsDYAQDYWQDSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsDYAQDYWQD obj = (clsDYAQDYWQD)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
				if(datarow.Table.Columns.Contains("LPMC")) datarow["LPMC"] = obj.LPMC;
				if(datarow.Table.Columns.Contains("GHXKZ")) datarow["GHXKZ"] = obj.GHXKZ;
				if(datarow.Table.Columns.Contains("SGXKZ")) datarow["SGXKZ"] = obj.SGXKZ;
				if(datarow.Table.Columns.Contains("BDCDYH")) datarow["BDCDYH"] = obj.BDCDYH;
				if(datarow.Table.Columns.Contains("ZL")) datarow["ZL"] = obj.ZL;
				if(datarow.Table.Columns.Contains("JZMJ")) datarow["JZMJ"] = obj.JZMJ;
				if(datarow.Table.Columns.Contains("ZGZQSE")) datarow["ZGZQSE"] = obj.ZGZQSE;
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if(datarow.Table.Columns.Contains("DYBSM")) datarow["DYBSM"] = obj.DYBSM;
				if(datarow.Table.Columns.Contains("QLBSM")) datarow["QLBSM"] = obj.QLBSM;
				if(datarow.Table.Columns.Contains("QLRBSM")) datarow["QLRBSM"] = obj.QLRBSM;
				if (obj.QLQSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("QLQSSJ")) datarow["QLQSSJ"] = obj.QLQSSJ;
				}
				if (obj.QLJSSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("QLJSSJ")) datarow["QLJSSJ"] = obj.QLJSSJ;
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
			clsDYAQDYWQD obj = null;
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
					obj = new clsDYAQDYWQD();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="YWH")
								if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
							if(strFldName.ToUpper()=="LPMC")
								if (pRow.Table.Columns.Contains("LPMC") && pRow["LPMC"] != DBNull.Value) { obj.LPMC = Convert.ToString(pRow["LPMC"]); }
							if(strFldName.ToUpper()=="GHXKZ")
								if (pRow.Table.Columns.Contains("GHXKZ") && pRow["GHXKZ"] != DBNull.Value) { obj.GHXKZ = Convert.ToString(pRow["GHXKZ"]); }
							if(strFldName.ToUpper()=="SGXKZ")
								if (pRow.Table.Columns.Contains("SGXKZ") && pRow["SGXKZ"] != DBNull.Value) { obj.SGXKZ = Convert.ToString(pRow["SGXKZ"]); }
							if(strFldName.ToUpper()=="BDCDYH")
								if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
							if(strFldName.ToUpper()=="ZL")
								if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
							if(strFldName.ToUpper()=="JZMJ")
								if (pRow.Table.Columns.Contains("JZMJ") && pRow["JZMJ"] != DBNull.Value) { obj.JZMJ = Convert.ToDouble(pRow["JZMJ"]); }
							if(strFldName.ToUpper()=="ZGZQSE")
								if (pRow.Table.Columns.Contains("ZGZQSE") && pRow["ZGZQSE"] != DBNull.Value) { obj.ZGZQSE = Convert.ToDouble(pRow["ZGZQSE"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="DYBSM")
								if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
							if(strFldName.ToUpper()=="QLBSM")
								if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
							if(strFldName.ToUpper()=="QLRBSM")
								if (pRow.Table.Columns.Contains("QLRBSM") && pRow["QLRBSM"] != DBNull.Value) { obj.QLRBSM = Convert.ToInt64(pRow["QLRBSM"]); }
							if(strFldName.ToUpper()=="QLQSSJ")
								if (pRow.Table.Columns.Contains("QLQSSJ") && pRow["QLQSSJ"] != DBNull.Value) { obj.QLQSSJ = Convert.ToDateTime(pRow["QLQSSJ"]); }
							if(strFldName.ToUpper()=="QLJSSJ")
								if (pRow.Table.Columns.Contains("QLJSSJ") && pRow["QLJSSJ"] != DBNull.Value) { obj.QLJSSJ = Convert.ToDateTime(pRow["QLJSSJ"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("YWH") && pRow["YWH"] != DBNull.Value) { obj.YWH = Convert.ToString(pRow["YWH"]); }
						if (pRow.Table.Columns.Contains("LPMC") && pRow["LPMC"] != DBNull.Value) { obj.LPMC = Convert.ToString(pRow["LPMC"]); }
						if (pRow.Table.Columns.Contains("GHXKZ") && pRow["GHXKZ"] != DBNull.Value) { obj.GHXKZ = Convert.ToString(pRow["GHXKZ"]); }
						if (pRow.Table.Columns.Contains("SGXKZ") && pRow["SGXKZ"] != DBNull.Value) { obj.SGXKZ = Convert.ToString(pRow["SGXKZ"]); }
						if (pRow.Table.Columns.Contains("BDCDYH") && pRow["BDCDYH"] != DBNull.Value) { obj.BDCDYH = Convert.ToString(pRow["BDCDYH"]); }
						if (pRow.Table.Columns.Contains("ZL") && pRow["ZL"] != DBNull.Value) { obj.ZL = Convert.ToString(pRow["ZL"]); }
						if (pRow.Table.Columns.Contains("JZMJ") && pRow["JZMJ"] != DBNull.Value) { obj.JZMJ = Convert.ToDouble(pRow["JZMJ"]); }
						if (pRow.Table.Columns.Contains("ZGZQSE") && pRow["ZGZQSE"] != DBNull.Value) { obj.ZGZQSE = Convert.ToDouble(pRow["ZGZQSE"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("DYBSM") && pRow["DYBSM"] != DBNull.Value) { obj.DYBSM = Convert.ToInt64(pRow["DYBSM"]); }
						if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
						if (pRow.Table.Columns.Contains("QLRBSM") && pRow["QLRBSM"] != DBNull.Value) { obj.QLRBSM = Convert.ToInt64(pRow["QLRBSM"]); }
						if (pRow.Table.Columns.Contains("QLQSSJ") && pRow["QLQSSJ"] != DBNull.Value) { obj.QLQSSJ = Convert.ToDateTime(pRow["QLQSSJ"]); }
						if (pRow.Table.Columns.Contains("QLJSSJ") && pRow["QLJSSJ"] != DBNull.Value) { obj.QLJSSJ = Convert.ToDateTime(pRow["QLJSSJ"]); }
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
