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

	public class Fld_DAQLGX
	{
		#region ����
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string DATMBSM="DATMBSM";
		public const string QLBM="QLBM";
		public const string QLBSM="QLBSM";
		public const string QXDM="QXDM";
		public const string BZ_YXTBM="BZ_YXTBM";
		public const string BZ_YXTBSM="BZ_YXTBSM";
		public const string BZ_PIGEID="BZ_PIGEID";
		public const string BZ_ZDQLR_ID="BZ_ZDQLR_ID";
		public const string REV_="REV_";
		public const string GXSJ="GXSJ";
		public const string BZ="BZ";
		public const string YXTBM="YXTBM";
		public const string YXTBSM="YXTBSM";
		public const string OINSID="OINSID";
		public const string BZ_QLID="BZ_QLID";
		public const string DALB="DALB";
		public const string BZ_YWSLID="BZ_YWSLID";
		public const string BZ_QLRMC="BZ_QLRMC";
		public const string BZ_ZL="BZ_ZL";
		public const string BZ_YBDCQZH="BZ_YBDCQZH";
		public const string FLH="FLH";
		#endregion
	}

	public class clsDAQLGX:IEntity
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
		private long m_DATMBSM;
		private string m_QLBM;
		private long m_QLBSM;
		private long m_QXDM;
		private long m_REV_;
		private DateTime m_GXSJ;
		private string m_BZ;
		private string m_YXTBM;
		private string m_YXTBSM;
		private string m_DALB;
		private string m_FLH;

		public long BSM
		{
			get{ return m_PrimaryKeyValue; }
			set{ m_PrimaryKeyValue = value; }
		}
		public long DATMBSM
		{
			get{ return m_DATMBSM; }
			set{ m_DATMBSM = value; }
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
		public string DALB
		{
			get{ return m_DALB; }
			set{ m_DALB = value; }
		}
		public string FLH
		{
			get{ return m_FLH; }
			set{ m_FLH = value; }
		}

		#endregion
		public bool IsEquals(clsDAQLGX obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.DATMBSM != obj.DATMBSM) bolResult = false;
			if (this.QLBM != obj.QLBM) bolResult = false;
			if (this.QLBSM != obj.QLBSM) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
			if (this.REV_ != obj.REV_) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.BZ != obj.BZ) bolResult = false;
			if (this.YXTBM != obj.YXTBM) bolResult = false;
			if (this.YXTBSM != obj.YXTBSM) bolResult = false;
			if (this.DALB != obj.DALB) bolResult = false;
			if (this.FLH != obj.FLH) bolResult = false;
			return bolResult;
		}

		public void Colne(clsDAQLGX obj)
		{
			this.BSM=obj.BSM;
			this.DATMBSM=obj.DATMBSM;
			this.QLBM=obj.QLBM;
			this.QLBSM=obj.QLBSM;
			this.QXDM=obj.QXDM;
			this.REV_=obj.REV_;
			this.GXSJ=obj.GXSJ;
			this.BZ=obj.BZ;
			this.YXTBM=obj.YXTBM;
			this.YXTBSM=obj.YXTBSM;
			this.DALB=obj.DALB;
			this.FLH=obj.FLH;
		}

	}

	public class clsDAQLGXSet:EntityBaseSet
	{
		public clsDAQLGXSet()
		{
			m_TableName="BDCDJ.DAQLGX";
			m_HisTableName="";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsDAQLGXSet";
		}
		public static clsDAQLGXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsDAQLGXSet clsSet = new clsDAQLGXSet(); //(clsDAQLGXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsDAQLGXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsDAQLGX obj = (clsDAQLGX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("DATMBSM")) datarow["DATMBSM"] = obj.DATMBSM;
				if(datarow.Table.Columns.Contains("QLBM")) datarow["QLBM"] = obj.QLBM;
				if(datarow.Table.Columns.Contains("QLBSM")) datarow["QLBSM"] = obj.QLBSM;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
				if(datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
				if(datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
				if(datarow.Table.Columns.Contains("YXTBSM"))  {if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String"){datarow["YXTBSM"] = obj.YXTBSM;}else{if (obj.YXTBSM == null){datarow["YXTBSM"] = DBNull.Value;}else{datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM); }} }
				if(datarow.Table.Columns.Contains("DALB")) datarow["DALB"] = obj.DALB;
				if(datarow.Table.Columns.Contains("FLH")) datarow["FLH"] = obj.FLH;
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
			clsDAQLGX obj = null;
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
					obj = new clsDAQLGX();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="DATMBSM")
								if (pRow.Table.Columns.Contains("DATMBSM") && pRow["DATMBSM"] != DBNull.Value) { obj.DATMBSM = Convert.ToInt64(pRow["DATMBSM"]); }
							if(strFldName.ToUpper()=="QLBM")
								if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
							if(strFldName.ToUpper()=="QLBSM")
								if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
							
							if(strFldName.ToUpper()=="REV_")
								if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="BZ")
								if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
							if(strFldName.ToUpper()=="YXTBM")
								if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
							if(strFldName.ToUpper()=="YXTBSM")
								if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
							
							if(strFldName.ToUpper()=="DALB")
								if (pRow.Table.Columns.Contains("DALB") && pRow["DALB"] != DBNull.Value) { obj.DALB = Convert.ToString(pRow["DALB"]); }
						
							if(strFldName.ToUpper()=="FLH")
								if (pRow.Table.Columns.Contains("FLH") && pRow["FLH"] != DBNull.Value) { obj.FLH = Convert.ToString(pRow["FLH"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("DATMBSM") && pRow["DATMBSM"] != DBNull.Value) { obj.DATMBSM = Convert.ToInt64(pRow["DATMBSM"]); }
						if (pRow.Table.Columns.Contains("QLBM") && pRow["QLBM"] != DBNull.Value) { obj.QLBM = Convert.ToString(pRow["QLBM"]); }
						if (pRow.Table.Columns.Contains("QLBSM") && pRow["QLBSM"] != DBNull.Value) { obj.QLBSM = Convert.ToInt64(pRow["QLBSM"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }

						if (pRow.Table.Columns.Contains("REV_") && pRow["REV_"] != DBNull.Value) { obj.REV_ = Convert.ToInt64(pRow["REV_"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("BZ") && pRow["BZ"] != DBNull.Value) { obj.BZ = Convert.ToString(pRow["BZ"]); }
						if (pRow.Table.Columns.Contains("YXTBM") && pRow["YXTBM"] != DBNull.Value) { obj.YXTBM = Convert.ToString(pRow["YXTBM"]); }
						if (pRow.Table.Columns.Contains("YXTBSM") && pRow["YXTBSM"] != DBNull.Value) { obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]); }
	
						if (pRow.Table.Columns.Contains("DALB") && pRow["DALB"] != DBNull.Value) { obj.DALB = Convert.ToString(pRow["DALB"]); }
			
						if (pRow.Table.Columns.Contains("FLH") && pRow["FLH"] != DBNull.Value) { obj.FLH = Convert.ToString(pRow["FLH"]); }
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
