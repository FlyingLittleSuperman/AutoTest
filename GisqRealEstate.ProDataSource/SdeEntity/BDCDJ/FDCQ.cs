using System;
using System.Data;

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
    public class Fld_FDCQ
    {
        #region 表列

        public const string PrimaryKeyName = "BSM";
        public const string BSM = "BSM";
        public const string YWH = "YWH";
        public const string QLLX = "QLLX";
        public const string DJLX = "DJLX";
        public const string YXTDJLXMC = "YXTDJLXMC";
        public const string DJYY = "DJYY";
        public const string FDCJYJG = "FDCJYJG";
        public const string BDCQZH = "BDCQZH";
        public const string DBR = "DBR";
        public const string DJSJ = "DJSJ";
        public const string FJ = "FJ";
        public const string QDFS = "QDFS";
        public const string FKFS = "FKFS";
        public const string GFHTBH = "GFHTBH";
        public const string QYRQ = "QYRQ";
        public const string JYLX = "JYLX";
        public const string QSZT = "QSZT";
        public const string ZXYWH = "ZXYWH";
        public const string ZXSJ = "ZXSJ";
        public const string ZXDBR = "ZXDBR";
        public const string ZXYY = "ZXYY";
        public const string ZXFJ = "ZXFJ";
        public const string SHBSM = "SHBSM";
        public const string ZXSHBSM = "ZXSHBSM";
        public const string SJGJZT = "SJGJZT";
        public const string YXTBM = "YXTBM";
        public const string YXTBSM = "YXTBSM";
        public const string QXDM = "QXDM";
        public const string BZ_FCZY_TYPE = "BZ_FCZY_TYPE";
        public const string BZ_FCZY_TDESC = "BZ_FCZY_TDESC";
        public const string REV_ = "REV_";
        public const string DJJG = "DJJG";
        public const string BZ_GXSJ = "BZ_GXSJ";
        public const string TDSYQR = "TDSYQR";
        public const string GXSJ = "GXSJ";
        public const string BZ = "BZ";
        public const string BZ_QDFS = "BZ_QDFS";
        public const string YXTQDFS = "YXTQDFS";
        public const string YFWXZ = "YFWXZ";
        public const string YFWCB = "YFWCB";
        public const string OINSID = "OINSID";
        public const string BZ_SYQZID = "BZ_SYQZID";
        public const string BZ_YWSLID = "BZ_YWSLID";
        public const string BZ_QLID = "BZ_QLID";
        public const string BG_BB = "BG_BB";

        #endregion
    }

    public class clsFDCQ : IEntity
    {
        private EnumEditState m_enuEditState = EnumEditState.esNoEdit;

        public bool IsEquals(clsFDCQ obj)
        {
            var bolResult = Equals(obj);
            if (bolResult)
                return bolResult;
            bolResult = true;
            if (BSM != obj.BSM) bolResult = false;
            if (YWH != obj.YWH) bolResult = false;
            if (QLLX != obj.QLLX) bolResult = false;
            if (DJLX != obj.DJLX) bolResult = false;
            if (YXTDJLXMC != obj.YXTDJLXMC) bolResult = false;
            if (DJYY != obj.DJYY) bolResult = false;
            if (FDCJYJG != obj.FDCJYJG) bolResult = false;
            if (BDCQZH != obj.BDCQZH) bolResult = false;
            if (DBR != obj.DBR) bolResult = false;
            if (DJSJ != obj.DJSJ) bolResult = false;
            if (FJ != obj.FJ) bolResult = false;
            if (QDFS != obj.QDFS) bolResult = false;
            if (FKFS != obj.FKFS) bolResult = false;
            if (GFHTBH != obj.GFHTBH) bolResult = false;
            if (QYRQ != obj.QYRQ) bolResult = false;
            if (JYLX != obj.JYLX) bolResult = false;
            if (QSZT != obj.QSZT) bolResult = false;
            if (ZXYWH != obj.ZXYWH) bolResult = false;
            if (ZXSJ != obj.ZXSJ) bolResult = false;
            if (ZXDBR != obj.ZXDBR) bolResult = false;
            if (ZXYY != obj.ZXYY) bolResult = false;
            if (ZXFJ != obj.ZXFJ) bolResult = false;
            if (SHBSM != obj.SHBSM) bolResult = false;
            if (ZXSHBSM != obj.ZXSHBSM) bolResult = false;
            if (SJGJZT != obj.SJGJZT) bolResult = false;
            if (YXTBM != obj.YXTBM) bolResult = false;
            if (YXTBSM != obj.YXTBSM) bolResult = false;
            if (QXDM != obj.QXDM) bolResult = false;

            if (REV_ != obj.REV_) bolResult = false;
            if (DJJG != obj.DJJG) bolResult = false;
            if (TDSYQR != obj.TDSYQR) bolResult = false;
            if (GXSJ != obj.GXSJ) bolResult = false;
            if (BZ != obj.BZ) bolResult = false;
            return bolResult;
        }

        public void Colne(clsFDCQ obj)
        {
            BSM = obj.BSM;
            YWH = obj.YWH;
            QLLX = obj.QLLX;
            DJLX = obj.DJLX;
            YXTDJLXMC = obj.YXTDJLXMC;
            DJYY = obj.DJYY;
            FDCJYJG = obj.FDCJYJG;
            BDCQZH = obj.BDCQZH;
            DBR = obj.DBR;
            DJSJ = obj.DJSJ;
            FJ = obj.FJ;
            QDFS = obj.QDFS;
            FKFS = obj.FKFS;
            GFHTBH = obj.GFHTBH;
            QYRQ = obj.QYRQ;
            JYLX = obj.JYLX;
            QSZT = obj.QSZT;
            ZXYWH = obj.ZXYWH;
            ZXSJ = obj.ZXSJ;
            ZXDBR = obj.ZXDBR;
            ZXYY = obj.ZXYY;
            ZXFJ = obj.ZXFJ;
            SHBSM = obj.SHBSM;
            ZXSHBSM = obj.ZXSHBSM;
            SJGJZT = obj.SJGJZT;
            YXTBM = obj.YXTBM;
            YXTBSM = obj.YXTBSM;
            QXDM = obj.QXDM;
            REV_ = obj.REV_;
            DJJG = obj.DJJG;
            TDSYQR = obj.TDSYQR;
            GXSJ = obj.GXSJ;
            BZ = obj.BZ;
        }

        #region IEntity 成员

        public long PrimaryKeyValue { get; set; }

        public EnumEditState EditState
        {
            get { return m_enuEditState; }
            set { m_enuEditState = value; }
        }

        #endregion

        #region 属性

        public clsFDCQ()
        {
            PrimaryKeyValue = 0;
        }

        public long BSM
        {
            get { return PrimaryKeyValue; }
            set { PrimaryKeyValue = value; }
        }

        public string YWH { get; set; }

        public string QLLX { get; set; }

        public string DJLX { get; set; }

        public string YXTDJLXMC { get; set; }

        public string DJYY { get; set; }

        public double FDCJYJG { get; set; }

        public string BDCQZH { get; set; }

        public string DBR { get; set; }

        public DateTime DJSJ { get; set; }

        public string FJ { get; set; }

        public string QDFS { get; set; }

        public string FKFS { get; set; }

        public string GFHTBH { get; set; }

        public DateTime QYRQ { get; set; }

        public string JYLX { get; set; }

        public string QSZT { get; set; }

        public string ZXYWH { get; set; }

        public DateTime ZXSJ { get; set; }

        public string ZXDBR { get; set; }

        public string ZXYY { get; set; }

        public string ZXFJ { get; set; }

        public long SHBSM { get; set; }

        public long ZXSHBSM { get; set; }

        public int SJGJZT { get; set; }

        public string YXTBM { get; set; }

        public string YXTBSM { get; set; }

        public long QXDM { get; set; }

        public long REV_ { get; set; }

        public string DJJG { get; set; }

        public string TDSYQR { get; set; }

        public DateTime GXSJ { get; set; }

        public string BZ { get; set; }

        public long BG_BB { get; set; }

        #endregion
    }

    public class clsFDCQSet : EntityBaseSet
    {
        public clsFDCQSet()
        {
            m_TableName = "BDCDJ.FDCQ";
            m_HisTableName = "BDCDJ.FDCQ_LS";
            m_PrimaryKeyName = "BSM";
            m_SequenceName = "BDCDJ.SEQ_BSM";
            m_ClsName = "clsFDCQSet";
        }

        public static clsFDCQSet CreateObject(GisqLandProDataSource objDataSource)
        {
            var clsSet = new clsFDCQSet();
                //(clsFDCQSet)DataAccess.CreateObject("GisqLandSystem.DataEntity", "GisqLandSystem.DataEntity.clsFDCQSet");
            clsSet.EntityDataSource = objDataSource;
            return clsSet;
        }

        protected override bool LetFieldsValue(DataRow datarow, IEntity entity)
        {
            if ((datarow == null) || (entity == null)) return false;
            ;
            var obj = (clsFDCQ) entity;
            try
            {
                if (datarow.Table.Columns.Contains("BSM")) datarow["BSM"] = obj.PrimaryKeyValue;
                if (datarow.Table.Columns.Contains("YWH")) datarow["YWH"] = obj.YWH;
                if (datarow.Table.Columns.Contains("QLLX")) datarow["QLLX"] = obj.QLLX;
                if (datarow.Table.Columns.Contains("DJLX")) datarow["DJLX"] = obj.DJLX;
                if (datarow.Table.Columns.Contains("YXTDJLXMC")) datarow["YXTDJLXMC"] = obj.YXTDJLXMC;
                if (datarow.Table.Columns.Contains("DJYY")) datarow["DJYY"] = obj.DJYY;
                if (datarow.Table.Columns.Contains("FDCJYJG")) datarow["FDCJYJG"] = obj.FDCJYJG;
                if (datarow.Table.Columns.Contains("BDCQZH")) datarow["BDCQZH"] = obj.BDCQZH;
                if (datarow.Table.Columns.Contains("DBR")) datarow["DBR"] = obj.DBR;
                if (obj.DJSJ.Year != 1)
                    if (datarow.Table.Columns.Contains("DJSJ")) datarow["DJSJ"] = obj.DJSJ;
                if (datarow.Table.Columns.Contains("FJ")) datarow["FJ"] = obj.FJ;
                if (datarow.Table.Columns.Contains("QDFS")) datarow["QDFS"] = obj.QDFS;
                if (datarow.Table.Columns.Contains("FKFS")) datarow["FKFS"] = obj.FKFS;
                if (datarow.Table.Columns.Contains("GFHTBH")) datarow["GFHTBH"] = obj.GFHTBH;
                if (obj.QYRQ.Year != 1)
                    if (datarow.Table.Columns.Contains("QYRQ")) datarow["QYRQ"] = obj.QYRQ;
                if (datarow.Table.Columns.Contains("JYLX")) datarow["JYLX"] = obj.JYLX;
                if (datarow.Table.Columns.Contains("QSZT")) datarow["QSZT"] = obj.QSZT;
                if (datarow.Table.Columns.Contains("ZXYWH")) datarow["ZXYWH"] = obj.ZXYWH;
                if (obj.ZXSJ.Year != 1)
                {
                    if (datarow.Table.Columns.Contains("ZXSJ")) datarow["ZXSJ"] = obj.ZXSJ;
                }
                else
                {
                    if (datarow.Table.Columns.Contains("ZXSJ")) datarow["ZXSJ"] = DBNull.Value;
                }
                if (datarow.Table.Columns.Contains("ZXDBR")) datarow["ZXDBR"] = obj.ZXDBR;
                if (datarow.Table.Columns.Contains("ZXYY")) datarow["ZXYY"] = obj.ZXYY;
                if (datarow.Table.Columns.Contains("ZXFJ")) datarow["ZXFJ"] = obj.ZXFJ;
                if (datarow.Table.Columns.Contains("SHBSM")) datarow["SHBSM"] = obj.SHBSM;
                if (datarow.Table.Columns.Contains("ZXSHBSM")) datarow["ZXSHBSM"] = obj.ZXSHBSM;
                if (datarow.Table.Columns.Contains("SJGJZT")) datarow["SJGJZT"] = obj.SJGJZT;
                if (datarow.Table.Columns.Contains("YXTBM")) datarow["YXTBM"] = obj.YXTBM;
                if (datarow.Table.Columns.Contains("YXTBSM"))
                    if (datarow.Table.Columns["YXTBSM"].DataType.FullName == "System.String")
                    {
                        datarow["YXTBSM"] = obj.YXTBSM;
                    }
                    else
                    {
                        if (obj.YXTBSM == null) datarow["YXTBSM"] = DBNull.Value;
                        else datarow["YXTBSM"] = Convert.ToInt64(obj.YXTBSM);
                    }
                if (datarow.Table.Columns.Contains("QXDM")) datarow["QXDM"] = obj.QXDM;
                if (datarow.Table.Columns.Contains("REV_")) datarow["REV_"] = obj.REV_;
                if (datarow.Table.Columns.Contains("DJJG")) datarow["DJJG"] = obj.DJJG;
                if (datarow.Table.Columns.Contains("TDSYQR")) datarow["TDSYQR"] = obj.TDSYQR;
                if (obj.GXSJ.Year != 1)
                    if (datarow.Table.Columns.Contains("GXSJ")) datarow["GXSJ"] = obj.GXSJ;
                if (datarow.Table.Columns.Contains("BZ")) datarow["BZ"] = obj.BZ;
                if (m_HisTable && (m_HisTableName != ""))
                    if (datarow.Table.Columns.Contains("BG_BB")) datarow["BG_BB"] = obj.BG_BB;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        protected override bool GetFieldsValue(DataTable datatable, string strFld)
        {
            var datarows = datatable.Rows;
            clsFDCQ obj = null;
            long iKey = 0;
            DataRow pRow = null;
            string[] strFldsplit = null;
            try
            {
                RemoveAll();
                for (var i = 0; i < datarows.Count; i++)
                {
                    pRow = datarows[i];
                    if (pRow.Table.Columns.Contains("BSM") && (pRow["BSM"] == DBNull.Value)) continue;
                    try
                    {
                        iKey = Convert.ToInt64(pRow["BSM"]);
                    }
                    catch
                    {
                        continue;
                    }
                    obj = new clsFDCQ();
                    obj.PrimaryKeyValue = iKey;
                    if (strFld != "")
                    {
                        strFldsplit = strFld.Split(',');
                        foreach (var strFldName in strFldsplit)
                        {
                            if (strFldName.ToUpper() == "YWH")
                                if (pRow.Table.Columns.Contains("YWH") && (pRow["YWH"] != DBNull.Value))
                                    obj.YWH = Convert.ToString(pRow["YWH"]);
                            if (strFldName.ToUpper() == "QLLX")
                                if (pRow.Table.Columns.Contains("QLLX") && (pRow["QLLX"] != DBNull.Value))
                                    obj.QLLX = Convert.ToString(pRow["QLLX"]);
                            if (strFldName.ToUpper() == "DJLX")
                                if (pRow.Table.Columns.Contains("DJLX") && (pRow["DJLX"] != DBNull.Value))
                                    obj.DJLX = Convert.ToString(pRow["DJLX"]);
                            if (strFldName.ToUpper() == "YXTDJLXMC")
                                if (pRow.Table.Columns.Contains("YXTDJLXMC") && (pRow["YXTDJLXMC"] != DBNull.Value))
                                    obj.YXTDJLXMC = Convert.ToString(pRow["YXTDJLXMC"]);
                            if (strFldName.ToUpper() == "DJYY")
                                if (pRow.Table.Columns.Contains("DJYY") && (pRow["DJYY"] != DBNull.Value))
                                    obj.DJYY = Convert.ToString(pRow["DJYY"]);
                            if (strFldName.ToUpper() == "FDCJYJG")
                                if (pRow.Table.Columns.Contains("FDCJYJG") && (pRow["FDCJYJG"] != DBNull.Value))
                                    obj.FDCJYJG = Convert.ToDouble(pRow["FDCJYJG"]);
                            if (strFldName.ToUpper() == "BDCQZH")
                                if (pRow.Table.Columns.Contains("BDCQZH") && (pRow["BDCQZH"] != DBNull.Value))
                                    obj.BDCQZH = Convert.ToString(pRow["BDCQZH"]);
                            if (strFldName.ToUpper() == "DBR")
                                if (pRow.Table.Columns.Contains("DBR") && (pRow["DBR"] != DBNull.Value))
                                    obj.DBR = Convert.ToString(pRow["DBR"]);
                            if (strFldName.ToUpper() == "DJSJ")
                                if (pRow.Table.Columns.Contains("DJSJ") && (pRow["DJSJ"] != DBNull.Value))
                                    obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]);
                            if (strFldName.ToUpper() == "FJ")
                                if (pRow.Table.Columns.Contains("FJ") && (pRow["FJ"] != DBNull.Value))
                                    obj.FJ = Convert.ToString(pRow["FJ"]);
                            if (strFldName.ToUpper() == "QDFS")
                                if (pRow.Table.Columns.Contains("QDFS") && (pRow["QDFS"] != DBNull.Value))
                                    obj.QDFS = Convert.ToString(pRow["QDFS"]);
                            if (strFldName.ToUpper() == "FKFS")
                                if (pRow.Table.Columns.Contains("FKFS") && (pRow["FKFS"] != DBNull.Value))
                                    obj.FKFS = Convert.ToString(pRow["FKFS"]);
                            if (strFldName.ToUpper() == "GFHTBH")
                                if (pRow.Table.Columns.Contains("GFHTBH") && (pRow["GFHTBH"] != DBNull.Value))
                                    obj.GFHTBH = Convert.ToString(pRow["GFHTBH"]);
                            if (strFldName.ToUpper() == "QYRQ")
                                if (pRow.Table.Columns.Contains("QYRQ") && (pRow["QYRQ"] != DBNull.Value))
                                    obj.QYRQ = Convert.ToDateTime(pRow["QYRQ"]);
                            if (strFldName.ToUpper() == "JYLX")
                                if (pRow.Table.Columns.Contains("JYLX") && (pRow["JYLX"] != DBNull.Value))
                                    obj.JYLX = Convert.ToString(pRow["JYLX"]);
                            if (strFldName.ToUpper() == "QSZT")
                                if (pRow.Table.Columns.Contains("QSZT") && (pRow["QSZT"] != DBNull.Value))
                                    obj.QSZT = Convert.ToString(pRow["QSZT"]);
                            if (strFldName.ToUpper() == "ZXYWH")
                                if (pRow.Table.Columns.Contains("ZXYWH") && (pRow["ZXYWH"] != DBNull.Value))
                                    obj.ZXYWH = Convert.ToString(pRow["ZXYWH"]);
                            if (strFldName.ToUpper() == "ZXSJ")
                                if (pRow.Table.Columns.Contains("ZXSJ") && (pRow["ZXSJ"] != DBNull.Value))
                                    obj.ZXSJ = Convert.ToDateTime(pRow["ZXSJ"]);
                            if (strFldName.ToUpper() == "ZXDBR")
                                if (pRow.Table.Columns.Contains("ZXDBR") && (pRow["ZXDBR"] != DBNull.Value))
                                    obj.ZXDBR = Convert.ToString(pRow["ZXDBR"]);
                            if (strFldName.ToUpper() == "ZXYY")
                                if (pRow.Table.Columns.Contains("ZXYY") && (pRow["ZXYY"] != DBNull.Value))
                                    obj.ZXYY = Convert.ToString(pRow["ZXYY"]);
                            if (strFldName.ToUpper() == "ZXFJ")
                                if (pRow.Table.Columns.Contains("ZXFJ") && (pRow["ZXFJ"] != DBNull.Value))
                                    obj.ZXFJ = Convert.ToString(pRow["ZXFJ"]);
                            if (strFldName.ToUpper() == "SHBSM")
                                if (pRow.Table.Columns.Contains("SHBSM") && (pRow["SHBSM"] != DBNull.Value))
                                    obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]);
                            if (strFldName.ToUpper() == "ZXSHBSM")
                                if (pRow.Table.Columns.Contains("ZXSHBSM") && (pRow["ZXSHBSM"] != DBNull.Value))
                                    obj.ZXSHBSM = Convert.ToInt64(pRow["ZXSHBSM"]);
                            if (strFldName.ToUpper() == "SJGJZT")
                                if (pRow.Table.Columns.Contains("SJGJZT") && (pRow["SJGJZT"] != DBNull.Value))
                                    obj.SJGJZT = Convert.ToInt16(pRow["SJGJZT"]);
                            if (strFldName.ToUpper() == "YXTBM")
                                if (pRow.Table.Columns.Contains("YXTBM") && (pRow["YXTBM"] != DBNull.Value))
                                    obj.YXTBM = Convert.ToString(pRow["YXTBM"]);
                            if (strFldName.ToUpper() == "YXTBSM")
                                if (pRow.Table.Columns.Contains("YXTBSM") && (pRow["YXTBSM"] != DBNull.Value))
                                    obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]);
                            if (strFldName.ToUpper() == "QXDM")
                                if (pRow.Table.Columns.Contains("QXDM") && (pRow["QXDM"] != DBNull.Value))
                                    obj.QXDM = Convert.ToInt64(pRow["QXDM"]);

                            if (strFldName.ToUpper() == "REV_")
                                if (pRow.Table.Columns.Contains("REV_") && (pRow["REV_"] != DBNull.Value))
                                    obj.REV_ = Convert.ToInt64(pRow["REV_"]);
                            if (strFldName.ToUpper() == "DJJG")
                                if (pRow.Table.Columns.Contains("DJJG") && (pRow["DJJG"] != DBNull.Value))
                                    obj.DJJG = Convert.ToString(pRow["DJJG"]);

                            if (strFldName.ToUpper() == "TDSYQR")
                                if (pRow.Table.Columns.Contains("TDSYQR") && (pRow["TDSYQR"] != DBNull.Value))
                                    obj.TDSYQR = Convert.ToString(pRow["TDSYQR"]);
                            if (strFldName.ToUpper() == "GXSJ")
                                if (pRow.Table.Columns.Contains("GXSJ") && (pRow["GXSJ"] != DBNull.Value))
                                    obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]);
                            if (strFldName.ToUpper() == "BZ")
                                if (pRow.Table.Columns.Contains("BZ") && (pRow["BZ"] != DBNull.Value))
                                    obj.BZ = Convert.ToString(pRow["BZ"]);
                        }
                    }
                    else
                    {
                        if (pRow.Table.Columns.Contains("YWH") && (pRow["YWH"] != DBNull.Value))
                            obj.YWH = Convert.ToString(pRow["YWH"]);
                        if (pRow.Table.Columns.Contains("QLLX") && (pRow["QLLX"] != DBNull.Value))
                            obj.QLLX = Convert.ToString(pRow["QLLX"]);
                        if (pRow.Table.Columns.Contains("DJLX") && (pRow["DJLX"] != DBNull.Value))
                            obj.DJLX = Convert.ToString(pRow["DJLX"]);
                        if (pRow.Table.Columns.Contains("YXTDJLXMC") && (pRow["YXTDJLXMC"] != DBNull.Value))
                            obj.YXTDJLXMC = Convert.ToString(pRow["YXTDJLXMC"]);
                        if (pRow.Table.Columns.Contains("DJYY") && (pRow["DJYY"] != DBNull.Value))
                            obj.DJYY = Convert.ToString(pRow["DJYY"]);
                        if (pRow.Table.Columns.Contains("FDCJYJG") && (pRow["FDCJYJG"] != DBNull.Value))
                            obj.FDCJYJG = Convert.ToDouble(pRow["FDCJYJG"]);
                        if (pRow.Table.Columns.Contains("BDCQZH") && (pRow["BDCQZH"] != DBNull.Value))
                            obj.BDCQZH = Convert.ToString(pRow["BDCQZH"]);
                        if (pRow.Table.Columns.Contains("DBR") && (pRow["DBR"] != DBNull.Value))
                            obj.DBR = Convert.ToString(pRow["DBR"]);
                        if (pRow.Table.Columns.Contains("DJSJ") && (pRow["DJSJ"] != DBNull.Value))
                            obj.DJSJ = Convert.ToDateTime(pRow["DJSJ"]);
                        if (pRow.Table.Columns.Contains("FJ") && (pRow["FJ"] != DBNull.Value))
                            obj.FJ = Convert.ToString(pRow["FJ"]);
                        if (pRow.Table.Columns.Contains("QDFS") && (pRow["QDFS"] != DBNull.Value))
                            obj.QDFS = Convert.ToString(pRow["QDFS"]);
                        if (pRow.Table.Columns.Contains("FKFS") && (pRow["FKFS"] != DBNull.Value))
                            obj.FKFS = Convert.ToString(pRow["FKFS"]);
                        if (pRow.Table.Columns.Contains("GFHTBH") && (pRow["GFHTBH"] != DBNull.Value))
                            obj.GFHTBH = Convert.ToString(pRow["GFHTBH"]);
                        if (pRow.Table.Columns.Contains("QYRQ") && (pRow["QYRQ"] != DBNull.Value))
                            obj.QYRQ = Convert.ToDateTime(pRow["QYRQ"]);
                        if (pRow.Table.Columns.Contains("JYLX") && (pRow["JYLX"] != DBNull.Value))
                            obj.JYLX = Convert.ToString(pRow["JYLX"]);
                        if (pRow.Table.Columns.Contains("QSZT") && (pRow["QSZT"] != DBNull.Value))
                            obj.QSZT = Convert.ToString(pRow["QSZT"]);
                        if (pRow.Table.Columns.Contains("ZXYWH") && (pRow["ZXYWH"] != DBNull.Value))
                            obj.ZXYWH = Convert.ToString(pRow["ZXYWH"]);
                        if (pRow.Table.Columns.Contains("ZXSJ") && (pRow["ZXSJ"] != DBNull.Value))
                            obj.ZXSJ = Convert.ToDateTime(pRow["ZXSJ"]);
                        if (pRow.Table.Columns.Contains("ZXDBR") && (pRow["ZXDBR"] != DBNull.Value))
                            obj.ZXDBR = Convert.ToString(pRow["ZXDBR"]);
                        if (pRow.Table.Columns.Contains("ZXYY") && (pRow["ZXYY"] != DBNull.Value))
                            obj.ZXYY = Convert.ToString(pRow["ZXYY"]);
                        if (pRow.Table.Columns.Contains("ZXFJ") && (pRow["ZXFJ"] != DBNull.Value))
                            obj.ZXFJ = Convert.ToString(pRow["ZXFJ"]);
                        if (pRow.Table.Columns.Contains("SHBSM") && (pRow["SHBSM"] != DBNull.Value))
                            obj.SHBSM = Convert.ToInt64(pRow["SHBSM"]);
                        if (pRow.Table.Columns.Contains("ZXSHBSM") && (pRow["ZXSHBSM"] != DBNull.Value))
                            obj.ZXSHBSM = Convert.ToInt64(pRow["ZXSHBSM"]);
                        if (pRow.Table.Columns.Contains("SJGJZT") && (pRow["SJGJZT"] != DBNull.Value))
                            obj.SJGJZT = Convert.ToInt16(pRow["SJGJZT"]);
                        if (pRow.Table.Columns.Contains("YXTBM") && (pRow["YXTBM"] != DBNull.Value))
                            obj.YXTBM = Convert.ToString(pRow["YXTBM"]);
                        if (pRow.Table.Columns.Contains("YXTBSM") && (pRow["YXTBSM"] != DBNull.Value))
                            obj.YXTBSM = Convert.ToString(pRow["YXTBSM"]);
                        if (pRow.Table.Columns.Contains("QXDM") && (pRow["QXDM"] != DBNull.Value))
                            obj.QXDM = Convert.ToInt64(pRow["QXDM"]);

                        if (pRow.Table.Columns.Contains("REV_") && (pRow["REV_"] != DBNull.Value))
                            obj.REV_ = Convert.ToInt64(pRow["REV_"]);
                        if (pRow.Table.Columns.Contains("DJJG") && (pRow["DJJG"] != DBNull.Value))
                            obj.DJJG = Convert.ToString(pRow["DJJG"]);

                        if (pRow.Table.Columns.Contains("TDSYQR") && (pRow["TDSYQR"] != DBNull.Value))
                            obj.TDSYQR = Convert.ToString(pRow["TDSYQR"]);
                        if (pRow.Table.Columns.Contains("GXSJ") && (pRow["GXSJ"] != DBNull.Value))
                            obj.GXSJ = Convert.ToDateTime(pRow["GXSJ"]);
                        if (pRow.Table.Columns.Contains("BZ") && (pRow["BZ"] != DBNull.Value))
                            obj.BZ = Convert.ToString(pRow["BZ"]);
                    }
                    if (m_HisTable && (m_HisTableName != ""))
                        if (pRow.Table.Columns.Contains("BG_BB") && (pRow["BG_BB"] != DBNull.Value))
                            obj.BG_BB = Convert.ToInt64(pRow["BG_BB"]);
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