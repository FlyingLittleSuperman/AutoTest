package WinForm.showReports;

import configSelenium.Entity.SeleniumTest.SeleniumSchema;
import configSelenium.StaticValue;
import org.dom4j.Document;
import org.dom4j.DocumentException;
import org.dom4j.DocumentHelper;
import org.dom4j.Element;
import org.dom4j.io.OutputFormat;
import org.dom4j.io.SAXReader;
import org.dom4j.io.XMLWriter;
import util.Path;
import util.XmlUtils;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

import static configSelenium.ConfigSeleniumStart.frchildList;
import static configSelenium.ConfigSeleniumStart.reportsSchemaList;
import static configSelenium.ConfigSeleniumStart.shootChildList;
import static configSelenium.InitCommonParameter.*;

/**
 * @author wangyan
 * @date 2019-03-28  下午 02:08
 */
public class ReportXML {

    public static void saveXml() throws DocumentException, IOException {


        String path=StaticValue.ApplicationPath +"/"+ "ReportsSchema.xml";
        File file=new File(StaticValue.ApplicationPath);
        if(!file.exists()){
            file.mkdirs();
        }
        File file1=new File(path);

        Document document=null;
        Element root=null;

        if (file1.exists()){
            SAXReader reader=new SAXReader();
            reader.setEncoding("UTF-8");
            document=reader.read(file1);
//            document=reader.read(new ByteArrayInputStream(path.getBytes("UTF-8")));
            root=document.getRootElement();
       }else {
             file1.createNewFile();
             document = DocumentHelper.createDocument();
             root = document.addElement("Element"); //创建根元素

        }

        Element schema=root.addElement("Schema");

            schema.addAttribute("ID", reportsSchemaList.get(0).getId());
            schema.addAttribute("Name", reportsSchemaList.get(0).getName());
            schema.addAttribute("Time", reportsSchemaList.get(0).getTime());



        for (ReportsSchema reports:reportsSchemaList) {

            Element prodef=schema.addElement("Prodef");
            prodef.addAttribute("ID",reports.getProdefId());
            prodef.addAttribute("Name",reports.getProdefName());
            prodef.addAttribute("PackageName",reports.getPackageName());
            prodef.addAttribute("PackageID",reports.getPackageId());

            Element prodefchild=prodef.addElement("ProdefChild");
            prodefchild.addAttribute("ID",reports.getChildProdefId());
            prodefchild.addAttribute("Name",reports.getChildProdefName());

            Element report=prodefchild.addElement("Report");
            report.addAttribute("ID",reports.getReportId());
            report.addAttribute("Name",reports.getReportName());

            Element reportchild=report.addElement("ReportChild");
            reportchild.addAttribute("ID",reports.getReportChildId());
            reportchild.addAttribute("Name",reports.getReportChildName());
            reportchild.addAttribute("Modular",reports.getReportChildModular());
            reportchild.addAttribute("Pass",reports.getReportChildPass());
            reportchild.addAttribute("Fail",reports.getReportChildFail());
            reportchild.addAttribute("Skip",reports.getReportChildSkip());
            reportchild.addAttribute("Path",reports.getReportChildPath());
            reportchild.addAttribute("Ywh",reports.getReportChildYwh());
            reportchild.addAttribute("IsSuccess",reports.getReportChildIsSuccess());


            Element screenshoot=prodefchild.addElement("ScreenShoot");
            screenshoot.addAttribute("ID",reports.getScreenShootId());
            screenshoot.addAttribute("Name",reports.getScreenShootName());
            for (ScreenShootUtils shchild:reports.getScreenShootUtilsList()){
                Element screenshootchild=screenshoot.addElement("ScreenShootChild");
                screenshootchild.addAttribute("ID",shchild.getChildId());
                screenshootchild.addAttribute("Name",shchild.getChildName());
                screenshootchild.addAttribute("Path",shchild.getChildPath());
            }


            Element frreport=prodefchild.addElement("FRreport");
            frreport.addAttribute("ID",reports.getFRreportId());
            frreport.addAttribute("Name",reports.getFRreportName());


            for (FRreportUtils frchild:reports.getfRreportUtilsList()) {
                Element frreportchild = frreport.addElement("FRreportChild");
                frreportchild.addAttribute("ID", frchild.getChildId());
                frreportchild.addAttribute("Name", frchild.getChildName());
                frreportchild.addAttribute("Path", frchild.getChildPath());
            }


        }

        OutputFormat format = OutputFormat.createPrettyPrint();
        //设置xml文档的编码为utf-8
        format.setEncoding("UTF-8");
        Writer out;
        try {
            //创建一个输出流对象
            out = new OutputStreamWriter(new FileOutputStream(path),"UTF-8");
            //创建一个dom4j创建xml的对象

            System.out.println("写入XML文件成功！");

            XMLWriter writer = new XMLWriter(out, format);
//            调用write方法将doc文档写到指定路径
            writer.write(document);
            writer.close();

        } catch (IOException e) {
            System.out.print("写入XML文件失败");
            e.printStackTrace();
        }


    }

}
