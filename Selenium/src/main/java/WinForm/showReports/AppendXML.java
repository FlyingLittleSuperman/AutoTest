package WinForm.showReports;

import configSelenium.StaticValue;
import org.dom4j.Document;
import org.dom4j.DocumentHelper;
import org.dom4j.Element;
import util.CacheUtils;
import util.XmlUtils;

import java.util.ArrayList;
import java.util.List;

/**
 * @author wangyan
 * @date 2019-04-03  上午 10:36
 */
public class AppendXML {
    public static List<ReportsSchema> reportSchemaList = new ArrayList<>();


    public static void getReports() {
        try {

            CreatXML c=new CreatXML();
            c.getReportMessage();
            Document document = XmlUtils.CreateDocumentByPath(StaticValue.ApplicationPath + "/ReportsSchema.xml");

            Element elementSchema = (Element) document.selectSingleNode("//Schema");


            if (elementSchema != null) {

                String schemaId = elementSchema.attributeValue("ID");
                String schemaName = elementSchema.attributeValue("Name");
                List<Element> elementProdefList = elementSchema.elements("Prodef");

                for (Element elementProdef : elementProdefList) {
                    String prodefId = elementProdef.attributeValue("ID");
                    String prodefName = elementProdef.attributeValue("Name");
                    String packageName = elementProdef.attributeValue("PackageName");
                    List<Element> elementProdefChildList = elementProdef.elements("ProdefChild");


                    for (Element elementProdefChild : elementProdefChildList) {

                        String childProdefId = elementProdefChild.attributeValue("ID");
                        String childProdefName = elementProdefChild.attributeValue("Name");


                        ReportsSchema reportSchema = new ReportsSchema();
                        reportSchema.setId(schemaId);
                        reportSchema.setName(schemaName);
                        reportSchema.setProdefId(prodefId);
                        reportSchema.setProdefName(prodefName);
                        reportSchema.setPackageName(packageName);
                        reportSchema.setChildProdefId(childProdefId);
                        reportSchema.setChildProdefName(childProdefName);


                        List<Element> elementReportList = elementProdef.elements("Report");
                        for (Element elmentReport : elementReportList) {
                            String reportId = elmentReport.attributeValue("ID");
                            String reportName = elmentReport.attributeValue("Name");

                            List<Element> elementReportChildList = elementProdef.elements("ReportChild");
                            for (Element elmentChildReport : elementReportChildList) {
                                String reportChildId = elmentChildReport.attributeValue("ID");
                                String reportChildName = elmentChildReport.attributeValue("Name");
                                String reportChildText = elmentChildReport.attributeValue("Text");
                                String reportChildPath = elmentChildReport.attributeValue("Path");

                                reportSchema.setReportId(reportId);
                                reportSchema.setReportName(reportName);
                                reportSchema.setReportChildId(reportChildId);
                                reportSchema.setReportChildName(reportChildName);
                                reportSchema.setReportChildText(reportChildText);
                                reportSchema.setReportChildPath(reportChildPath);

                            }
                        }
                        List<Element> elementScreenShootList = elementProdef.elements("ScreenShoot");
                        for (Element elmentScreenShoot : elementScreenShootList) {
                            String screenShootId = elmentScreenShoot.attributeValue("ID");
                            String screenShootName = elmentScreenShoot.attributeValue("Name");

                            List<Element> elementScreenShootChildList = elementProdef.elements("ScreenShootChild");
                            for (Element elmentScreenShootChild : elementScreenShootChildList) {
                                String screenShootChildId = elmentScreenShootChild.attributeValue("ID");
                                String screenShootChildName = elmentScreenShootChild.attributeValue("Name");
                                String screenShootChildPath = elmentScreenShootChild.attributeValue("Path");

                                reportSchema.setScreenShootId(screenShootId);
                                reportSchema.setScreenShootName(screenShootName);
                                reportSchema.setScreenShootChildId(screenShootChildId);
                                reportSchema.setScreenShootChildName(screenShootChildName);
                                reportSchema.setScreenShootChildPath(screenShootChildPath);
                            }

                        }
                        List<Element> elementFRreportList = elementProdef.elements("FRreport");
                        for (Element elmentFRreport : elementFRreportList) {
                            String frreportCId = elmentFRreport.attributeValue("ID");
                            String frreportName = elmentFRreport.attributeValue("Name");

                            List<Element> elementFRreportChildList = elementProdef.elements("FRreportChild");
                            for (Element elmentFRreportChild : elementFRreportChildList) {
                                String frreportChildId = elmentFRreportChild.attributeValue("ID");
                                String frreportChildName = elmentFRreportChild.attributeValue("Name");
                                String frreportChildPath = elmentFRreportChild.attributeValue("Path");

                                reportSchema.setFRreportId(frreportCId);
                                reportSchema.setFRreportName(frreportName);
                                reportSchema.setFRreportChildId(frreportChildId);
                                reportSchema.setFRreportChildName(frreportChildName);
                                reportSchema.setFRreportChildPath(frreportChildPath);


                            }

                        }


                        reportSchemaList.add(reportSchema);

                         }
                     }
               }

             }catch (Exception er){
            er.printStackTrace();
        }
        CacheUtils.put(StaticValue.SchemaCacheName, StaticValue.InitSchemaKeyName, reportSchemaList);
    }

}
