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

	public class Fld_LSXZGX
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string RWBH="RWBH";
		public const string YDYBM="YDYBM";
		public const string YDYBSM="YDYBSM";
		public const string XDYBM="XDYBM";
		public const string XDYBSM="XDYBSM";
		public const string YQLBM="YQLBM";
		public const string YQLBSM="YQLBSM";
		public const string XQLBM="XQLBM";
		public const string XQLBSM="XQLBSM";
		public const string GXSJ="GXSJ";
		public const string LSDYYWH="LSDYYWH";
		public const string QXDM="QXDM";
		public const string BG_BB="BG_BB";
        public const string YQLSFLS = "YQLSFLS";//定义一个变量来区分该权利是否入历史 薛豪豪 2017-05-23
		#endregion
	}

	public class clsLSXZGX:IEntity
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
		private string m_YDYBM;
		private long m_YDYBSM;
		private string m_XDYBM;
		private long m_XDYBSM;
		private string m_YQLBM;
		private long m_YQLBSM;
		private string m_XQLBM;
		private long m_XQLBSM;
		private DateTime m_GXSJ;
		private string m_LSDYYWH;
		private long m_QXDM;
		private long m_BG_BB;
        private string m_YQLSFLS;//定义一个变量来区分该权利是否入历史 薛豪豪 2017-05-23

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
		public string YDYBM
		{
			get{ return m_YDYBM; }
			set{ m_YDYBM = value; }
		}
		public long YDYBSM
		{
			get{ return m_YDYBSM; }
			set{ m_YDYBSM = value; }
		}
		public string XDYBM
		{
			get{ return m_XDYBM; }
			set{ m_XDYBM = value; }
		}
		public long XDYBSM
		{
			get{ return m_XDYBSM; }
			set{ m_XDYBSM = value; }
		}
		public string YQLBM
		{
			get{ return m_YQLBM; }
			set{ m_YQLBM = value; }
		}
		public long YQLBSM
		{
			get{ return m_YQLBSM; }
			set{ m_YQLBSM = value; }
		}
		public string XQLBM
		{
			get{ return m_XQLBM; }
			set{ m_XQLBM = value; }
		}
		public long XQLBSM
		{
			get{ return m_XQLBSM; }
			set{ m_XQLBSM = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		public string LSDYYWH
		{
			get{ return m_LSDYYWH; }
			set{ m_LSDYYWH = value; }
		}
		public long QXDM
		{
			get{ return m_QXDM; }
			set{ m_QXDM = value; }
		}
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

        public string YQLSFLS //定义一个方法来获取区分产权是否入历史的值 薛豪豪 2017-05-23
        {
            get { return m_YQLSFLS; }
            set { m_YQLSFLS = value; }             
        }

		#endregion
		public bool IsEquals(clsLSXZGX obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.RWBH != obj.RWBH) bolResult = false;
			if (this.YDYBM != obj.YDYBM) bolResult = false;
			if (this.YDYBSM != obj.YDYBSM) bolResult = false;
			if (this.XDYBM != obj.XDYBM) bolResult = false;
			if (this.XDYBSM != obj.XDYBSM) bolResult = false;
			if (this.YQLBM != obj.YQLBM) bolResult = false;
			if (this.YQLBSM != obj.YQLBSM) bolResult = false;
			if (this.XQLBM != obj.XQLBM) bolResult = false;
			if (this.XQLBSM != obj.XQLBSM) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
			if (this.LSDYYWH != obj.LSDYYWH) bolResult = false;
			if (this.QXDM != obj.QXDM) bolResult = false;
            if (this.YQLSFLS != obj.YQLSFLS) bolResult = false;
			return bolResult;
		}

		public void Colne(clsLSXZGX obj)
		{
			this.BSM=obj.BSM;
			this.RWBH=obj.RWBH;
			this.YDYBM=obj.YDYBM;
			this.YDYBSM=obj.YDYBSM;
			this.XDYBM=obj.XDYBM;
			this.XDYBSM=obj.XDYBSM;
			this.YQLBM=obj.YQLBM;
			this.YQLBSM=obj.YQLBSM;
			this.XQLBM=obj.XQLBM;
			this.XQLBSM=obj.XQLBSM;
			this.GXSJ=obj.GXSJ;
			this.LSDYYWH=obj.LSDYYWH;
			this.QXDM=obj.QXDM;
            this.YQLSFLS = obj.YQLSFLS;
		}

	}

	public class clsLSXZGXSet:EntityBaseSet
	{
		public clsLSXZGXSet()
		{
			m_TableName="LSXZGX";
			m_HisTableName="LSXZGX_LS";
			m_PrimaryKeyName="BSM";
			m_SequenceName="BDCDJ.SEQ_BSM";
			m_ClsName="clsLSXZGXSet";
		}
		public static clsLSXZGXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsLSXZGXSet clsSet = new clsLSXZGXSet(); //(clsLSXZGXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsLSXZGXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsLSXZGX obj = (clsLSXZGX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("RWBH")) datarow["RWBH"] = obj.RWBH;
				if(datarow.Table.Columns.Contains("YDYBM")) datarow["YDYBM"] = obj.YDYBM;
				if(datarow.Table.Columns.Contains("YDYBSM")) datarow["YDYBSM"] = obj.YDYBSM;
				if(datarow.Table.Columns.Contains("XDYBM")) datarow["XDYBM"] = obj.XDYBM;
				if(datarow.Table.Columns.Contains("XDYBSM")) datarow["XDYBSM"] = obj.XDYBSM;
				if(datarow.Table.Columns.Contains("YQLBM")) datarow["YQLBM"] = obj.YQLBM;
				if(datarow.Table.Columns.Contains("YQLBSM")) datarow["YQLBSM"] = obj.YQLBSM;
				if(datarow.Table.Columns.Contains("XQLBM")) datarow["XQLBM"] = obj.XQLBM;
				if(datarow.Table.Columns.Contains("XQLBSM")) datarow["XQLBSM"] = obj.XQLBSM;
                if (datarow.Table.Columns.Contains("YQLSFLS")) datarow["YQLSFLS"] = obj.YQLSFLS;
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
				if(datarow.Table.Columns.Contains("LSDYYWH")) datarow["LSDYYWH"] = obj.LSDYYWH;
				if(datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
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
			clsLSXZGX obj = null;
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
					obj = new clsLSXZGX();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="RWBH")
								if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
							if(strFldName.ToUpper()=="YDYBM")
								if (pRow.Table.Columns.Contains("YDYBM") && pRow["YDYBM"] != DBNull.Value) { obj.YDYBM = Convert.ToString(pRow["YDYBM"]); }
							if(strFldName.ToUpper()=="YDYBSM")
								if (pRow.Table.Columns.Contains("YDYBSM") && pRow["YDYBSM"] != DBNull.Value) { obj.YDYBSM = Convert.ToInt64(pRow["YDYBSM"]); }
							if(strFldName.ToUpper()=="XDYBM")
								if (pRow.Table.Columns.Contains("XDYBM") && pRow["XDYBM"] != DBNull.Value) { obj.XDYBM = Convert.ToString(pRow["XDYBM"]); }
							if(strFldName.ToUpper()=="XDYBSM")
								if (pRow.Table.Columns.Contains("XDYBSM") && pRow["XDYBSM"] != DBNull.Value) { obj.XDYBSM = Convert.ToInt64(pRow["XDYBSM"]); }
							if(strFldName.ToUpper()=="YQLBM")
								if (pRow.Table.Columns.Contains("YQLBM") && pRow["YQLBM"] != DBNull.Value) { obj.YQLBM = Convert.ToString(pRow["YQLBM"]); }
							if(strFldName.ToUpper()=="YQLBSM")
								if (pRow.Table.Columns.Contains("YQLBSM") && pRow["YQLBSM"] != DBNull.Value) { obj.YQLBSM = Convert.ToInt64(pRow["YQLBSM"]); }
							if(strFldName.ToUpper()=="XQLBM")
								if (pRow.Table.Columns.Contains("XQLBM") && pRow["XQLBM"] != DBNull.Value) { obj.XQLBM = Convert.ToString(pRow["XQLBM"]); }
							if(strFldName.ToUpper()=="XQLBSM")
								if (pRow.Table.Columns.Contains("XQLBSM") && pRow["XQLBSM"] != DBNull.Value) { obj.XQLBSM = Convert.ToInt64(pRow["XQLBSM"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
							if(strFldName.ToUpper()=="LSDYYWH")
								if (pRow.Table.Columns.Contains("LSDYYWH") && pRow["LSDYYWH"] != DBNull.Value) { obj.LSDYYWH = Convert.ToString(pRow["LSDYYWH"]); }
							if(strFldName.ToUpper()=="QXDM")
								if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
                            if(strFldName.ToUpper()=="YQLSFLS")
                                if (pRow.Table.Columns.Contains("YQLSFLS") && pRow["YQLSFLS"] != DBNull.Value) { obj.YQLSFLS = Convert.ToString(pRow["YQLSFLS"]); }
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
						if (pRow.Table.Columns.Contains("YDYBM") && pRow["YDYBM"] != DBNull.Value) { obj.YDYBM = Convert.ToString(pRow["YDYBM"]); }
						if (pRow.Table.Columns.Contains("YDYBSM") && pRow["YDYBSM"] != DBNull.Value) { obj.YDYBSM = Convert.ToInt64(pRow["YDYBSM"]); }
						if (pRow.Table.Columns.Contains("XDYBM") && pRow["XDYBM"] != DBNull.Value) { obj.XDYBM = Convert.ToString(pRow["XDYBM"]); }
						if (pRow.Table.Columns.Contains("XDYBSM") && pRow["XDYBSM"] != DBNull.Value) { obj.XDYBSM = Convert.ToInt64(pRow["XDYBSM"]); }
						if (pRow.Table.Columns.Contains("YQLBM") && pRow["YQLBM"] != DBNull.Value) { obj.YQLBM = Convert.ToString(pRow["YQLBM"]); }
						if (pRow.Table.Columns.Contains("YQLBSM") && pRow["YQLBSM"] != DBNull.Value) { obj.YQLBSM = Convert.ToInt64(pRow["YQLBSM"]); }
						if (pRow.Table.Columns.Contains("XQLBM") && pRow["XQLBM"] != DBNull.Value) { obj.XQLBM = Convert.ToString(pRow["XQLBM"]); }
						if (pRow.Table.Columns.Contains("XQLBSM") && pRow["XQLBSM"] != DBNull.Value) { obj.XQLBSM = Convert.ToInt64(pRow["XQLBSM"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
						if (pRow.Table.Columns.Contains("LSDYYWH") && pRow["LSDYYWH"] != DBNull.Value) { obj.LSDYYWH = Convert.ToString(pRow["LSDYYWH"]); }
						if (pRow.Table.Columns.Contains("QXDM") && pRow["QXDM"] != DBNull.Value) { obj.QXDM = Convert.ToInt64(pRow["QXDM"]); }
                        if (pRow.Table.Columns.Contains("YQLSFLS") && pRow["YQLSFLS"] != DBNull.Value) { obj.YQLSFLS = Convert.ToString(pRow["YQLSFLS"]); }
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
