package configSelenium;

import configSelenium.Entity.CommonConfig;
import configSelenium.Entity.ProInfo.Actdef;
import configSelenium.Entity.ProInfo.Prodef;
import configSelenium.Entity.SQL.Column;
import configSelenium.Entity.SQL.SQLConfig;
import configSelenium.Entity.SQL.Table;
import configSelenium.Entity.SQL.TableRelation;
import configSelenium.Entity.SeleniumTest.ChildLocationElement;
import configSelenium.Entity.SeleniumTest.Iframe;
import configSelenium.Entity.SeleniumTest.LocationElement;
import configSelenium.Entity.SeleniumTest.SeleniumSchema;
import org.dom4j.Document;
import org.dom4j.Element;
import util.CacheUtils;
import util.DataBase;
import util.DateUtils;
import util.XmlUtils;

import java.io.File;
import java.text.SimpleDateFormat;
import java.util.*;

/**
 * Created by Administrator on 2016/12/21.
 */
public class InitCommonParameter {

//    public  static String pdd;
    /**
     * 设置参数缓存
     *
     * @throws Exception
     */

    public static void SetCommonConfigCache() throws Exception {

        Document document = XmlUtils.CreateDocumentByPath(StaticValue.ApplicationPath + "/ServicePath.xml");
        System.out.println("读取服务地址"+StaticValue.ApplicationPath);
        CommonConfig commonConfig = new CommonConfig();
        commonConfig.setChromeDriverUrl(document.selectSingleNode("//ElementInfo[@ID='ChromeDriverUrl']").getText());
        commonConfig.setLoginUrl(document.selectSingleNode("//ElementInfo[@ID='LoginUrl']").getText());
        commonConfig.setLoginUserName(document.selectSingleNode("//ElementInfo[@ID='LoginUserName']").getText());
        commonConfig.setYJName(document.selectSingleNode("//ElementInfo[@ID='YJName']").getText());
        commonConfig.setLoginPassWord(document.selectSingleNode("//ElementInfo[@ID='LoginPassWord']").getText());
        commonConfig.setFirstPageIframe(document.selectSingleNode("//ElementInfo[@ID='FirstPageIframe']").getText());
        commonConfig.setCreateProIframe(document.selectSingleNode("//ElementInfo[@ID='CreateProIframe']").getText());
        commonConfig.setWorkFlowFrameIframe(document.selectSingleNode("//ElementInfo[@ID='WorkFlowFrameIframe']").getText());
        commonConfig.setDataCategory(document.selectSingleNode("//ElementInfo[@ID='DataCategory']").getText());
        commonConfig.setServiceIP(document.selectSingleNode("//ElementInfo[@ID='ServiceIP']").getText());

        commonConfig.setDbName(document.selectSingleNode("//ElementInfo[@ID='DbName']").getText());
        commonConfig.setDbUserName(document.selectSingleNode("//ElementInfo[@ID='DbUserName']").getText());
        commonConfig.setDbPassWord(document.selectSingleNode("//ElementInfo[@ID='DbPassWord']").getText());

        CacheUtils.put(StaticValue.CommonConfigCacheName, StaticValue.InitParameterKeyName, commonConfig);
    }

    /**
     * 初始化流程配置信息
     *
     * @throws Exception
     */
    public static void SetProdefConfigCache() throws Exception {

        try {

            Object objSchema = CacheUtils.get(StaticValue.SchemaCacheName, StaticValue.InitSchemaKeyName);
            if (objSchema == null) {
                return;
            }

            List<SeleniumSchema> seleniumSchemaList = (List<SeleniumSchema>) objSchema;

            File fileList = new File(StaticValue.ApplicationPath + "/XML");
            File[] listFiles = fileList.listFiles();
            List<Prodef> prodefList = new ArrayList<Prodef>();
            for (File file : listFiles) {
                if (file.getName().indexOf("Prodef_") == -1) {
                    continue;
                }
                if (!StaticValue.GetProdefConfigBySchema(seleniumSchemaList, file.getName())) {
                    continue; //是否在方案中
                }
                Document document = XmlUtils.CreateDocumentByPath(file.getAbsolutePath());

                Element elementProdef = (Element) document.selectSingleNode("//Prodef");//流程信息
                //添加流程信息
                Prodef prodef = new Prodef();
                prodef.setId(elementProdef.attributeValue("ID"));
                prodef.setName(elementProdef.attributeValue("Name"));
                prodef.setPackageID(elementProdef.attributeValue("PackageID"));


                List<Actdef> actdefList = new ArrayList<Actdef>();
                List<Element> elementActdefList = elementProdef.elements("Actdef"); //环节信息
                for (Element elementActdef : elementActdefList) {

                    //添加环节信息
                    Actdef actdef = new Actdef();
                    actdef.setId(elementActdef.attributeValue("ID"));
                    actdef.setName(elementActdef.attributeValue("Name"));
                    actdefList.add(actdef);

                    List<Iframe> iframeList = new ArrayList<Iframe>();
                    List<Element> elementIframeList = elementActdef.element("iframe").elements("iframeChild"); //iframe信息

                    for (Element elementIframe : elementIframeList) {

                        //添加iframe信息
                        Iframe iframe = new Iframe();
                        iframe.setId(elementIframe.attributeValue("ID"));
                        iframe.setName(elementIframe.attributeValue("Name"));
                        iframe.setUrl(elementIframe.attributeValue("URL"));
                        iframeList.add(iframe);

                        List<LocationElement> locationElementList = new ArrayList<LocationElement>();
                        List<Element> elementLocationElementList = elementIframe.elements("LocationElement"); //Iframe元素信息
                        for (Element elementLocationElement : elementLocationElementList) {

                            //添加Iframe元素操作信息
                            LocationElement locationElement = new LocationElement();
                            locationElement.setId(elementLocationElement.attributeValue("ID"));
                            locationElement.setLocationType(elementLocationElement.attributeValue("LocationType"));
                            locationElement.setLocationPath(elementLocationElement.attributeValue("Path"));
                            locationElement.setOperateType(elementLocationElement.attributeValue("OperateType"));
                            locationElement.setOrder(Integer.valueOf(elementLocationElement.attributeValue("Order")));
                            locationElement.setDefaultValue(elementLocationElement.attributeValue("DefaultValue"));
                            locationElement.setIntroduce(elementLocationElement.attributeValue("Introduce"));
                            locationElement.setRandom(Boolean.valueOf(elementLocationElement.attributeValue("IsRandom") == "" ? "false" : elementLocationElement.attributeValue("IsRandom")));
                            locationElement.setWaitSecond(elementLocationElement.attributeValue("WaitSecond") == null ? 0 : Integer.valueOf(elementLocationElement.attributeValue("WaitSecond")));
                            locationElement.setSqlSchemaId(elementLocationElement.attributeValue("SqlSchemaId") == null ? "" : elementLocationElement.attributeValue("SqlSchemaId"));
                            locationElementList.add(locationElement);

                            List<ChildLocationElement> childLocationElementList = new ArrayList<ChildLocationElement>();
                            List<Element> elementChildLocationElementList = elementLocationElement.elements("ChildLocationElement");
                            for (Element elementChildLocationElement : elementChildLocationElementList) {
                                ChildLocationElement childLocationElement = new ChildLocationElement();
                                childLocationElement.setId(elementChildLocationElement.attributeValue("ID"));
                                childLocationElement.setLocationType(elementChildLocationElement.attributeValue("LocationType"));
                                childLocationElement.setLocationPath(elementChildLocationElement.attributeValue("Path"));
                                childLocationElement.setOperateType(elementChildLocationElement.attributeValue("OperateType"));
                                childLocationElement.setOrder(Integer.valueOf(elementChildLocationElement.attributeValue("Order")));
                                childLocationElement.setDefaultValue(elementChildLocationElement.attributeValue("DefaultValue"));
                                childLocationElement.setIntroduce(elementChildLocationElement.attributeValue("Introduce"));
                                childLocationElement.setRandom(Boolean.valueOf(elementChildLocationElement.attributeValue("IsRandom") == "" ? "false" : elementChildLocationElement.attributeValue("IsRandom")));
                                childLocationElement.setWaitSecond(elementChildLocationElement.attributeValue("WaitSecond") == null ? 0 : Integer.valueOf(elementChildLocationElement.attributeValue("WaitSecond")));
                                childLocationElement.setSqlSchemaId(elementChildLocationElement.attributeValue("SqlSchemaId") == null ? "" : elementChildLocationElement.attributeValue("SqlSchemaId"));
                                childLocationElementList.add(childLocationElement);
                            }
                            locationElement.setChildLocationElementList(childLocationElementList);
                        }
                        iframe.setLocationElementList(locationElementList);
                    }
                    actdef.setIframeList(iframeList);
                }
                prodef.setActdefList(actdefList);
                prodefList.add(prodef);
            }

            CacheUtils.put(StaticValue.ProdefConfigCacheName, StaticValue.InitProdefKeyName, prodefList);
        }catch (Exception e){
            System.out.println(e.getStackTrace());

        }
    }

    /**
     * 加载方案配置缓存
     *
     * @throws Exception
     */

    public static String prodefid;
    public static String prodefname;
    public static String packagename;
    public static String childprodefid;
    public static String childprodefname;
    public static String schemaid;
    public static String schemaname;
    public static List<Element> elementProdefChildList;
    public static void InitSeleniumConfig() throws Exception {
        Document document = XmlUtils.CreateDocumentByPath(StaticValue.ApplicationPath + "/SeleniumSchema.xml");
        Element elementSchema = (Element) document.selectSingleNode("//Schema[@Execute='true']");
        List<SeleniumSchema> seleniumSchemaList = new ArrayList<>();
        if (elementSchema != null) {

            String schemaId = elementSchema.attributeValue("ID");
            String schemaName = elementSchema.attributeValue("Name");
            List<Element> elementProdefList = elementSchema.elements("Prodef");

            for (Element elementProdef : elementProdefList) {
                String prodefId = elementProdef.attributeValue("ID");
                String prodefName = elementProdef.attributeValue("Name");
                String packageName = elementProdef.attributeValue("PackageName");
                 elementProdefChildList = elementProdef.elements("ProdefChild");
                for (Element elementProdefChild : elementProdefChildList) {

                    String childProdefId = elementProdefChild.attributeValue("ID");
                    String childProdefName = elementProdefChild.attributeValue("Name");
                    SeleniumSchema seleniumSchema = new SeleniumSchema();
                    seleniumSchema.setId(schemaId);
                    seleniumSchema.setName(schemaName);
                    seleniumSchema.setProdefId(prodefId);
                    seleniumSchema.setProdefName(prodefName);
                    seleniumSchema.setPackageName(packageName);
                    seleniumSchema.setChildProdefId(childProdefId);
                    seleniumSchema.setChildProdefName(childProdefName);
                    schemaid =seleniumSchema.getId();
                    schemaname=seleniumSchema.getName();

                    prodefid=seleniumSchema.getProdefId();
                     prodefname=seleniumSchema.getProdefName();
                     packagename=seleniumSchema.getPackageName();
                     childprodefid=seleniumSchema.getChildProdefId();
                     childprodefname=seleniumSchema.getChildProdefName();
                   seleniumSchema.setFilePath(String.format("Prodef_%s_%s.xml", prodefId, childProdefId));
                    seleniumSchemaList.add(seleniumSchema);

                }
            }
        }
        CacheUtils.put(StaticValue.SchemaCacheName, StaticValue.InitSchemaKeyName, seleniumSchemaList);
    }

    /**
     * 初始化SQL参数配置
     *
     * @throws Exception
     */





    public static void InitSqlConfig() throws Exception {
        Document document = XmlUtils.CreateDocumentByPath(StaticValue.ApplicationPath + "/SQLConfig.xml");
        List<Element> elementSchema = document.selectNodes("//SqlSchema");
        Map<String, SQLConfig> mapAllSchema = new HashMap<>();
        SQLConfig sqlConfig;
        Table table;
        Column column;
        TableRelation tableRelation;
        for (Element element : elementSchema) {
            sqlConfig = new SQLConfig();
            String schemaId = element.attributeValue("ID");
            String schemaName = element.attributeValue("Name");
            sqlConfig.setSchemaId(schemaId);
            sqlConfig.setSchemaName(schemaName);
            mapAllSchema.put(schemaId, sqlConfig); //加载Map
            List<Element> elementTableList = element.selectNodes("Table");
            List<Table> tableList = new ArrayList<>();
            for (Element elementTable : elementTableList) {
                table = new Table();
                String tableName = elementTable.attributeValue("ID");
                String tableComments = elementTable.attributeValue("Name");
                String tableSpaceName = elementTable.attributeValue("TableSpace");
                table.setTableName(tableName);
                table.setTableComments(tableComments);
                table.setTableSpaceName(tableSpaceName);

                List<Element> elementColumnList = elementTable.selectNodes("Column");
                List<Column> columnList = new ArrayList<>();
                for (Element elementColumn : elementColumnList) {
                    column = new Column();
                    column.setColumnName(elementColumn.attributeValue("ID"));
                    column.setColumnValue(elementColumn.getText());
                    column.setColumnType(elementColumn.attributeValue("Type"));
                    column.setColumnLength(Integer.valueOf(elementColumn.attributeValue("Length") == "" ? "0" : elementColumn.attributeValue("Length")));
                    column.setColumnScale(Integer.valueOf(elementColumn.attributeValue("Scale") == "" ? "0" : elementColumn.attributeValue("Scale")));
                    column.setColumnComments(elementColumn.attributeValue("Name"));
                    columnList.add(column);
                }
                table.setColumnList(columnList);
                tableList.add(table);
            }
            sqlConfig.setTableList(tableList);


            List<Element> elementTableRelationList = element.selectNodes("TableRelation/DetialRelation");
            List<TableRelation> tableRelationList = new ArrayList<>();
            for (Element elementTableRelation : elementTableRelationList) {
                tableRelation = new TableRelation();
                tableRelation.setTableRelationId(elementTableRelation.attributeValue("ID"));
                tableRelation.setfTableSpaceName(elementTableRelation.attributeValue("FTableSpaceName"));
                tableRelation.setfTableName(elementTableRelation.attributeValue("FTableName"));
                tableRelation.setfColumnName(elementTableRelation.attributeValue("FColumnName"));
                tableRelation.setlTableSpaceName(elementTableRelation.attributeValue("LTableSpaceName"));
                tableRelation.setlTableName(elementTableRelation.attributeValue("LTableName"));
                tableRelation.setlColumnName(elementTableRelation.attributeValue("LColumnName"));
                tableRelation.setTableRelationExpress(elementTableRelation.getText());
                tableRelationList.add(tableRelation);
            }
            sqlConfig.setTableRelationList(tableRelationList);
        }

        CacheUtils.put(StaticValue.SqlConfigCacheName, StaticValue.InitSqlConfigKeyName, mapAllSchema);
    }

    public static String fbdcdyh;
    public static String wbdcdyh;
    public static String lbdcdyh;
    public static String ywh;
    public static String djqdm;
    public static String djqzh;
    public static String zdsyqlx;
    public static String zdtzm;
    public static String lzdyh;
    public static String fzdyh;
    public static String zddm;
    public static String wdzwtzm;
    public static String fdzwtzm;
    public static String ldzwtzm;
    public static String zsxh;
    public static String dzwsxh;
    public static String qxdm;
    //添加关于证书的字段--20181213wy
    public static String zsfzjc;
    public static String zsfzdq;
    public static String zsfznf;
    public static String zsfzbm;
    public static String zsfzxh;
    public static String bdcqzh;
    public static String fzgbh;
    //添加关于证明的字段--20181213wy
    public static String zmfzjc;
    public static String zmfzdq;
    public static String zmfznf;
    public static String zmfzbm;
    public static String zmfzxh;
    public static String bdcdjzmh;
    public static String sbh;
    public static Map<String, String> mapBdcdyhInfo;


    public static void InitSqlConfigBatchSql() {
        Map<String, StringBuilder> mapAllSchemaSqls = new HashMap<>();
        Map<String, String> mapColumnValue = new HashMap<>();
        Object obj = CacheUtils.get(StaticValue.SqlConfigCacheName, StaticValue.InitSqlConfigKeyName);
        if (obj != null) {
            Map<String, SQLConfig> mapSqlConfig = (Map<String, SQLConfig>) obj;
            for (String key : mapSqlConfig.keySet()) {
                SQLConfig sqlConfig = mapSqlConfig.get(key);
                List<Table> tableList = sqlConfig.getTableList();
                List<TableRelation> tableRelations = sqlConfig.getTableRelationList();
                StringBuilder sbSchemaSql = new StringBuilder();
                if (tableList != null && tableList.size() > 0) {
                    fbdcdyh = "";
                    wbdcdyh = "";
                    lbdcdyh = "";
                    ywh = "";
                    djqdm = "";
                    djqzh = "";
                    zdsyqlx = "";
                    zdtzm = "";
                    lzdyh = "";
                    fzdyh = "";
                    zddm = "";
                    wdzwtzm = "";
                    fdzwtzm = "";
                    ldzwtzm = "";
                    zsxh = "";
                    dzwsxh = "";
                    qxdm = "";
                    ywh = "";
                    zsfzjc = "";
                    zsfzdq = "";
                    zsfznf = "";
                    zsfzbm = "";
                    zsfzxh = "";
                    bdcqzh = "";
                    fzgbh = "";
                    zmfzjc = "";
                    zmfzdq = "";
                    zmfznf = "";
                    zmfzbm = "";
                    zmfzxh = "";
                    bdcdjzmh = "";
                    sbh = "";

                    mapBdcdyhInfo = new HashMap<>();

                    //先统一赋值，用于处理关联关系
                    for (Table table : tableList) {
                        List<Column> columnList = table.getColumnList();
                        if (columnList != null && columnList.size() > 0) {
                            for (Column column : columnList) {
                                String columnValue = column.getColumnValue();
                                columnValue = FilterValue(columnValue);

                                switch (column.getColumnType()) {
                                    case "NUMBER":
                                        column.setColumnValue(columnValue);
                                        break;
                                    case "DATE":
                                        if (!DateUtils.IsLongDate(columnValue)) {
                                            column.setColumnValue(String.format("to_date('%s','YYYY-MM-DD HH24:MI:SS')", columnValue));
                                        } else {
                                            column.setColumnValue(String.format("to_date('%s','YYYY-MM-DD')", columnValue));
                                        }
                                        break;
                                    case "VARCHAR2":
                                    case "NVARCHAR2":
                                        column.setColumnValue(String.format("'%s'", columnValue));
                                        break;
                                }


                                mapColumnValue.put(String.format("%s.%s.%s", table.getTableSpaceName(), table.getTableName(), column.getColumnName()), columnValue);
                            }
                        }
                    }


                    for (Table table : tableList) {
                        List<Column> columnList = table.getColumnList();
                        if (columnList != null && columnList.size() > 0) {
                            StringBuilder sbColumnName = new StringBuilder();
                            StringBuilder sbColumnValue = new StringBuilder();
                            for (Column column : columnList) {
                                String columnValue = column.getColumnValue();
                                sbColumnName.append(column.getColumnName()).append(",");
                                sbColumnValue.append(columnValue).append(",");
                            }

                            if (tableRelations != null && tableRelations.size() > 0) {
                                for (TableRelation tableRelation : tableRelations) {
                                    if (tableRelation.getfTableSpaceName().equals(table.getTableSpaceName())  //关联前
                                            && tableRelation.getfTableName().equals(table.getTableName())) {
                                        String tempColumnName = tableRelation.getfColumnName();
                                        String tempLTableSpaceName = tableRelation.getlTableSpaceName(); //关联后表空间名
                                        String tempLTableName = tableRelation.getlTableName(); //关联后表名
                                        String tempLColumnName = tableRelation.getlColumnName();//关联后字段名
                                        if (("," + sbColumnName + ",").indexOf("," + tempColumnName + ",") == -1) {
                                            sbColumnName.append(tempColumnName).append(",");
                                            String tempColumnValue = mapColumnValue.get(String.format("%s.%s.%s", tempLTableSpaceName, tempLTableName, tempLColumnName));
                                            sbColumnValue.append(tempColumnValue).append(",");
                                        }
                                    } else if (tableRelation.getlTableSpaceName().equals(table.getTableSpaceName()) //关联后
                                            && tableRelation.getlTableName().equals(table.getTableName())) {
                                        String tempColumnName = tableRelation.getlColumnName();
                                        String tempFTableSpaceName = tableRelation.getfTableSpaceName();//关联前表空间名
                                        String tempFTableName = tableRelation.getfTableName();//关联前表名
                                        String tempFColumnName = tableRelation.getfColumnName();//关联前字段名

                                        if (("," + sbColumnName + ",").indexOf("," + tempColumnName + ",") == -1) {
                                            sbColumnName.append(tempColumnName).append(",");
                                            String tempColumnValue = mapColumnValue.get(String.format("%s.%s.%s", tempFTableSpaceName, tempFTableName, tempFColumnName));
                                            sbColumnValue.append(tempColumnValue).append(",");
                                        }
                                    }
                                }
                            }


                            if (sbColumnName.length() > 0 && sbColumnName.lastIndexOf(",") > -1) {
                                sbColumnName = sbColumnName.deleteCharAt(sbColumnName.lastIndexOf(","));
                            }

                            if (sbColumnValue.length() > 0 && sbColumnValue.lastIndexOf(",") > -1) {
                                sbColumnValue = sbColumnValue.deleteCharAt(sbColumnValue.lastIndexOf(","));
                            }
                            String sql = String.format("insert into %s.%s(%s) values(%s);", table.getTableSpaceName(), table.getTableName(), sbColumnName.toString(), sbColumnValue.toString());
                            sbSchemaSql.append(sql).append("\r\n");
                        }


                    }
                }
                mapAllSchemaSqls.put(sqlConfig.getSchemaId(), sbSchemaSql);
            }
        }
        CacheUtils.put(StaticValue.SqlConfigCacheName, StaticValue.InitSqlConfigAllSqlKeyName, mapAllSchemaSqls);
        CacheUtils.put(StaticValue.SqlConfigCacheName, StaticValue.InitSqlCondfigColumnValue, mapColumnValue);
    }

    private static String FilterValue(String value) {
        if (value.equals("#SEQ_BSM#")) {
            return DataBase.GetNewID("SEQ_BSM").toString();
        } else if (value.equals("#SYSDATE#")) {
            return DateUtils.getDate(DateUtils.parsePatterns[1]);
        } else if (value.equals("#YWH#")) {
            if (ywh.equals("")) {
                ywh = String.format("%s-ZDH-%s", DateUtils.getDate().replace("-", ""), StaticValue.GetRandomNumber(9));
            }
            return ywh;
        } else if (value.indexOf("#") > -1) {
            return GetBdcdyhInfo(value);
            //加入关于证书的书写过程---2018-1213
        } else {
            return value;
        }
    }


    private static String GetBdcgzhInfo(String value) {
        if (!(zsfzjc != "" && zsfzdq != "" && zsfznf != "" && zsfzbm != "" && zsfzxh != "")) {
            zsfzjc = "浙";
            zsfzdq = "杭州市";
            Calendar date = Calendar.getInstance();
            zsfznf = String.valueOf(date.get(Calendar.YEAR));
            zsfzbm = "00" + StaticValue.GetRandomNumber(5).toString();
            zsfzxh = zsfzbm.substring(2);
        }
        return mapBdcdyhInfo.get(value);
    }


    private static String GetBdcdyhInfo(String value) {
        if (!(qxdm != "" && djqdm != "" && djqzh != "" && zdsyqlx != "" && zdtzm != "")) {
            qxdm = StaticValue.GetRandomNumber(6).toString();
            String tempDjqdm = StaticValue.GetRandomNumber(3).toString();
            String tempDjzqdm = StaticValue.GetRandomNumber(3).toString();
            djqdm = qxdm + tempDjqdm + tempDjzqdm;
            zdsyqlx = "G";
            zdtzm = "B";
            djqzh = StaticValue.GetRandomNumber(5).toString();
            zddm = djqdm + zdsyqlx + zdtzm + djqzh;
            zsxh = StaticValue.GetRandomNumber(4).toString();
            dzwsxh = StaticValue.GetRandomNumber(4).toString();
            wdzwtzm = "W";
            fdzwtzm = "F";
            ldzwtzm = "L";
            lzdyh = zddm + ldzwtzm + zsxh;
            fzdyh = zddm + fdzwtzm + zsxh;
            wbdcdyh = zddm + wdzwtzm + "00000000";
            lbdcdyh = lzdyh + dzwsxh;
            fbdcdyh = fzdyh + dzwsxh;

            mapBdcdyhInfo.put("#QXDM#", qxdm);
            mapBdcdyhInfo.put("#DJQDM#", djqdm);
            mapBdcdyhInfo.put("#ZDSYQLX#", zdsyqlx);
            mapBdcdyhInfo.put("#ZDTZM#", zdtzm);
            mapBdcdyhInfo.put("#DJQZH#", djqzh);
            mapBdcdyhInfo.put("#ZDDM#", zddm);
            mapBdcdyhInfo.put("#ZSXH#", zsxh);
            mapBdcdyhInfo.put("#DZWSXH#", dzwsxh);
            mapBdcdyhInfo.put("#WDZWTZM#", wdzwtzm);
            mapBdcdyhInfo.put("#FDZWTZM#", fdzwtzm);
            mapBdcdyhInfo.put("#LDZWTZM#", ldzwtzm);
            mapBdcdyhInfo.put("#LZDYH#", lzdyh);
            mapBdcdyhInfo.put("#FZDYH#", fzdyh);
            mapBdcdyhInfo.put("#FBDCDYH#", fbdcdyh);
            mapBdcdyhInfo.put("#LBDCDYH#", lbdcdyh);
            mapBdcdyhInfo.put("#WBDCDYH#", wbdcdyh);
        }
        return mapBdcdyhInfo.get(value);
    }

}
