package WinForm.showReports;

import com.sun.deploy.net.proxy.pac.PACFunctions;
import org.dom4j.Document;
import org.dom4j.DocumentException;
import org.dom4j.DocumentHelper;
import org.dom4j.Element;
import org.dom4j.io.OutputFormat;
import org.dom4j.io.SAXReader;
import org.dom4j.io.XMLWriter;

import java.io.*;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;

import static com.sun.org.apache.xalan.internal.utils.SecuritySupport.getResourceAsStream;

/**
 * @author wangyan
 * @date 2019-04-09  上午 09:14
 */
public class debug_xml {
    public static Date da = new Date();

    public static SimpleDateFormat min = new SimpleDateFormat("yyyy-MM-dd HH:mm");
    public static SimpleDateFormat day = new SimpleDateFormat("yyyy-MM-dd ");

    public static void main(String[] args) throws DocumentException, IOException {
            appendXml("E:/你好","TEST.xml");


    }


    public static void appendXml(String path,String name) throws DocumentException, IOException {


        File file=new File(path);
        if(!file.exists()){
            file.mkdirs();
        }

        File file1=new File(path+"/"+name);

        Document document=null;
        Element element=null;

        if(file1.exists()){
            System.out.println("存在就读取");
            SAXReader reader=new SAXReader();
            System.out.println(path);
            document=reader.read(file1);

//            document=reader.read(new ByteArrayInputStream(path.getBytes("utf-8")));
            document.setXMLEncoding("utf-8");
            element=document.getRootElement();
        }else {
            file1.createNewFile();
            System.out.println("不存在就创建");
            System.out.println(path);
            document= DocumentHelper.createDocument();
            element=document.addElement("Element");

        }

        Element schema=element.addElement("Schema");
        schema.addAttribute("ID","38492ddwqo941ewkwjioeq"+min.format(da).substring(10).replace(":","_").trim());
        schema.addAttribute("Name","国有首次登记"+min.format(da).substring(10).replace(":","_").trim());
        Element prodef=schema.addElement("Prodef");
        prodef.addAttribute("ID","34u20nsndjfbskdfs");
        prodef.addAttribute("Name","首次登记");
        prodef.addAttribute("Packagename","国有建设用地使用权及房屋所有权（单套）");
        Element prodefChild=prodef.addElement("ProdefChild");
        prodefChild.addAttribute("ID","34u20nsndjfbskdfs");
        prodefChild.addAttribute("Name","assert");
        Element report=prodefChild.addElement("Report");
        prodefChild.addAttribute("ID","12312312");
        prodefChild.addAttribute("Name","测试报告");

        Element ReportChild=report.addElement("ReportChild");

        ReportChild.addAttribute("ID","023842342");
        ReportChild.addAttribute("Name","测试结果概览");
        ReportChild.addAttribute("Text","测试模块：断言调试-国有建设用地使用权及房屋所有权（单套）-首次登记\n" +
                "\t测试通过：0\n" +
                "\t测试失败：1\n" +
                "\t测试跳过：0");
        ReportChild.addAttribute("Path","D:\\work_space\\js_de\\debug\\SeleniumConfig\\bin\\Debug\\AutoTest_Reports\\2019-03-28\\17_16\\html\\index.html");


        Element ScreenShoot=prodefChild.addElement("ScreenShoot");
        prodefChild.addAttribute("ID","1231241241213");
        prodefChild.addAttribute("Name","截图展示");
        Element ScreenShootChild=ScreenShoot.addElement("ScreenShootChild");

        ScreenShootChild.addAttribute("ID","45523423");
        ScreenShootChild.addAttribute("Name","资料收取");
        ScreenShootChild.addAttribute("Path","D:\\work_space\\js_de\\debug\\SeleniumConfig\\bin\\Debug\\SootScreens\\2019-03-28\\17_16\\资料收取 17_15.png");

        ScreenShootChild.addAttribute("ID","45523423");
        ScreenShootChild.addAttribute("Name","大保存");
        ScreenShootChild.addAttribute("Path","D:\\work_space\\js_de\\debug\\SeleniumConfig\\bin\\Debug\\SootScreens\\2019-03-28\\17_16\\大保存 17_17(2).png");



        Element FRreport=prodefChild.addElement("FRreport");

        prodefChild.addAttribute("ID","34232ddasda");
        prodefChild.addAttribute("Name","帆软表单");

        Element FRreportChild=FRreport.addElement("FRreportChild");


        FRreportChild.addAttribute("ID","252132231");
        FRreportChild.addAttribute("Name","审批表");
        FRreportChild.addAttribute("Path","D:\\work_space\\js_de\\debug\\SeleniumConfig\\bin\\Debug\\SootScreens\\2019-03-28\\17_16\\审批表.pdf");



        OutputFormat format = OutputFormat.createPrettyPrint();
        //设置xml文档的编码为utf-8
        format.setEncoding("UTF-8");
        Writer out;
        try {
            //创建一个输出流对象
            out = new OutputStreamWriter(new FileOutputStream(path+"/"+name),"UTF-8");
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
