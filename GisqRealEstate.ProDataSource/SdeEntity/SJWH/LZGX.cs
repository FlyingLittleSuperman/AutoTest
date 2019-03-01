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

	public class Fld_LZGX
	{
		#region 表列
		public const string PrimaryKeyName ="BSM";
		public const string BSM="BSM";
		public const string RWBH="RWBH";
		public const string LZDYBM="LZDYBM";
		public const string LZDYBSM="LZDYBSM";
		public const string ZBM="ZBM";
		public const string ZBSM="ZBSM";
		public const string DZWDYBM="DZWDYBM";
		public const string DZWDYBSM="DZWDYBSM";
		public const string GXSJ="GXSJ";
		public const string BG_BB="BG_BB";
		#endregion
	}

	public class clsLZGX:IEntity
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
		private string m_LZDYBM;
		private long m_LZDYBSM;
		private string m_ZBM;
		private long m_ZBSM;
		private string m_DZWDYBM;
		private long m_DZWDYBSM;
		private DateTime m_GXSJ;
		private long m_BG_BB;
        private long m_YZBSM;

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
		public string LZDYBM
		{
			get{ return m_LZDYBM; }
			set{ m_LZDYBM = value; }
		}
		public long LZDYBSM
		{
			get{ return m_LZDYBSM; }
			set{ m_LZDYBSM = value; }
		}
		public string ZBM
		{
			get{ return m_ZBM; }
			set{ m_ZBM = value; }
		}
		public long ZBSM
		{
			get{ return m_ZBSM; }
			set{ m_ZBSM = value; }
		}
		public string DZWDYBM
		{
			get{ return m_DZWDYBM; }
			set{ m_DZWDYBM = value; }
		}
		public long DZWDYBSM
		{
			get{ return m_DZWDYBSM; }
			set{ m_DZWDYBSM = value; }
		}
		public DateTime GXSJ
		{
			get{ return m_GXSJ; }
			set{ m_GXSJ = value; }
		}
		public long BG_BB
		{
			get{ return m_BG_BB; }
			set{ m_BG_BB = value; }
		}

        //增加YZBSM
        // add by maqiong 2018-03-06
        //数据库现状增加了YZBSM,历史中也需要增加
        public long YZBSM
        {
            get { return m_YZBSM; }
            set { m_YZBSM = value; }
        }
        //end by add 
		#endregion
		public bool IsEquals(clsLZGX obj)
		{
			bool bolResult = this.Equals(obj);
			if (bolResult)
			{
				return bolResult;
			}
			bolResult = true;
			if (this.BSM != obj.BSM) bolResult = false;
			if (this.RWBH != obj.RWBH) bolResult = false;
			if (this.LZDYBM != obj.LZDYBM) bolResult = false;
			if (this.LZDYBSM != obj.LZDYBSM) bolResult = false;
			if (this.ZBM != obj.ZBM) bolResult = false;
			if (this.ZBSM != obj.ZBSM) bolResult = false;
			if (this.DZWDYBM != obj.DZWDYBM) bolResult = false;
			if (this.DZWDYBSM != obj.DZWDYBSM) bolResult = false;
			if (this.GXSJ != obj.GXSJ) bolResult = false;
            //增加YZBSM
            // add by maqiong 2018-03-06
            //数据库现状增加了YZBSM,历史中也需要增加
            if (this.YZBSM != obj.YZBSM) bolResult = false;
            //end by add 
			return bolResult;
		}

		public void Colne(clsLZGX obj)
		{
			this.BSM=obj.BSM;
			this.RWBH=obj.RWBH;
			this.LZDYBM=obj.LZDYBM;
			this.LZDYBSM=obj.LZDYBSM;
			this.ZBM=obj.ZBM;
			this.ZBSM=obj.ZBSM;
			this.DZWDYBM=obj.DZWDYBM;
			this.DZWDYBSM=obj.DZWDYBSM;
			this.GXSJ=obj.GXSJ;
            //增加YZBSM
            // add by maqiong 2018-03-06
            //数据库现状增加了YZBSM,历史中也需要增加
            this.YZBSM = obj.YZBSM;
            //end by 
		}

	}

	public class clsLZGXSet:EntityBaseSet
	{
		public clsLZGXSet()
		{
			m_TableName="LZGX";
			m_HisTableName="LZGX_LS";
			m_PrimaryKeyName="BSM";
            m_SequenceName = "BDCDJ.SEQ_BSM";
			m_ClsName="clsLZGXSet";
		}
		public static clsLZGXSet CreateObject(GisqLandProDataSource objDataSource)
		{
			clsLZGXSet clsSet = new clsLZGXSet(); //(clsLZGXSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsLZGXSet");
			clsSet.EntityDataSource = objDataSource;
			return clsSet;
		}
		protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
		{
			if (datarow == null || entity == null) { return false; };
			clsLZGX obj = (clsLZGX)entity;
			try
			{
				if (datarow.Table.Columns.Contains("BSM"))  datarow["BSM"] = obj.PrimaryKeyValue;
				if(datarow.Table.Columns.Contains("RWBH")) datarow["RWBH"] = obj.RWBH;
				if(datarow.Table.Columns.Contains("LZDYBM")) datarow["LZDYBM"] = obj.LZDYBM;
				if(datarow.Table.Columns.Contains("LZDYBSM")) datarow["LZDYBSM"] = obj.LZDYBSM;
				if(datarow.Table.Columns.Contains("ZBM")) datarow["ZBM"] = obj.ZBM;
				if(datarow.Table.Columns.Contains("ZBSM")) datarow["ZBSM"] = obj.ZBSM;
				if(datarow.Table.Columns.Contains("DZWDYBM")) datarow["DZWDYBM"] = obj.DZWDYBM;
				if(datarow.Table.Columns.Contains("DZWDYBSM")) datarow["DZWDYBSM"] = obj.DZWDYBSM;
                //增加YZBSM
                // add by maqiong 2018-03-06
                //数据库现状增加了YZBSM,历史中也需要增加
                if (datarow.Table.Columns.Contains("YZBSM")) datarow["YZBSM"] = obj.YZBSM;
                //end by add 
				if (obj.GXSJ.Year !=1)
				{
					if(datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
				}
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
			clsLZGX obj = null;
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
					obj = new clsLZGX();  
					obj.PrimaryKeyValue = iKey;
					if (strFld!="")
					{
						strFldsplit = strFld.Split(',');
						foreach (string strFldName in strFldsplit)
						{
							if(strFldName.ToUpper()=="RWBH")
								if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
							if(strFldName.ToUpper()=="LZDYBM")
								if (pRow.Table.Columns.Contains("LZDYBM") && pRow["LZDYBM"] != DBNull.Value) { obj.LZDYBM = Convert.ToString(pRow["LZDYBM"]); }
							if(strFldName.ToUpper()=="LZDYBSM")
								if (pRow.Table.Columns.Contains("LZDYBSM") && pRow["LZDYBSM"] != DBNull.Value) { obj.LZDYBSM = Convert.ToInt64(pRow["LZDYBSM"]); }
							if(strFldName.ToUpper()=="ZBM")
								if (pRow.Table.Columns.Contains("ZBM") && pRow["ZBM"] != DBNull.Value) { obj.ZBM = Convert.ToString(pRow["ZBM"]); }
							if(strFldName.ToUpper()=="ZBSM")
								if (pRow.Table.Columns.Contains("ZBSM") && pRow["ZBSM"] != DBNull.Value) { obj.ZBSM = Convert.ToInt64(pRow["ZBSM"]); }
							if(strFldName.ToUpper()=="DZWDYBM")
								if (pRow.Table.Columns.Contains("DZWDYBM") && pRow["DZWDYBM"] != DBNull.Value) { obj.DZWDYBM = Convert.ToString(pRow["DZWDYBM"]); }
							if(strFldName.ToUpper()=="DZWDYBSM")
								if (pRow.Table.Columns.Contains("DZWDYBSM") && pRow["DZWDYBSM"] != DBNull.Value) { obj.DZWDYBSM = Convert.ToInt64(pRow["DZWDYBSM"]); }
							if(strFldName.ToUpper()=="GXSJ")
								if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
                            //增加YZBSM
                            // add by maqiong 2018-03-06
                            //数据库现状增加了YZBSM,历史中也需要增加
                            if (strFldName.ToUpper() == "YZBSM")
                                if (pRow.Table.Columns.Contains("YZBSM") && pRow["YZBSM"] != DBNull.Value) { obj.YZBSM = Convert.ToInt64(pRow["YZBSM"]); }
                            //end add 
						}
					}
					else
					{
						if (pRow.Table.Columns.Contains("RWBH") && pRow["RWBH"] != DBNull.Value) { obj.RWBH = Convert.ToString(pRow["RWBH"]); }
						if (pRow.Table.Columns.Contains("LZDYBM") && pRow["LZDYBM"] != DBNull.Value) { obj.LZDYBM = Convert.ToString(pRow["LZDYBM"]); }
						if (pRow.Table.Columns.Contains("LZDYBSM") && pRow["LZDYBSM"] != DBNull.Value) { obj.LZDYBSM = Convert.ToInt64(pRow["LZDYBSM"]); }
						if (pRow.Table.Columns.Contains("ZBM") && pRow["ZBM"] != DBNull.Value) { obj.ZBM = Convert.ToString(pRow["ZBM"]); }
						if (pRow.Table.Columns.Contains("ZBSM") && pRow["ZBSM"] != DBNull.Value) { obj.ZBSM = Convert.ToInt64(pRow["ZBSM"]); }
						if (pRow.Table.Columns.Contains("DZWDYBM") && pRow["DZWDYBM"] != DBNull.Value) { obj.DZWDYBM = Convert.ToString(pRow["DZWDYBM"]); }
						if (pRow.Table.Columns.Contains("DZWDYBSM") && pRow["DZWDYBSM"] != DBNull.Value) { obj.DZWDYBSM = Convert.ToInt64(pRow["DZWDYBSM"]); }
						if (pRow.Table.Columns.Contains("GXSJ") && pRow["GXSJ"] != DBNull.Value) { obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]); }
                        //增加YZBSM
                        // add by maqiong 2018-03-06
                        //数据库现状增加了YZBSM,历史中也需要增加
                        if (pRow.Table.Columns.Contains("YZBSM") && pRow["YZBSM"] != DBNull.Value) { obj.YZBSM = Convert.ToInt64(pRow["YZBSM"]); }
                        //end add 
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
