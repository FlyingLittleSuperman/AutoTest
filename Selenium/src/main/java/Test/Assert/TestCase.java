package Test.Assert;



import com.lowagie.text.xml.XmlParser;

import org.dom4j.DocumentException;
import org.dom4j.io.OutputFormat;
import org.dom4j.io.SAXReader;
import org.dom4j.io.XMLWriter;
import org.testng.*;
import org.testng.annotations.Listeners;
import org.testng.annotations.Test;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;
import util.Path;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStream;
import java.util.ArrayList;
import java.util.List;
import java.util.Set;
import Test.emailMessage;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;

import static Test.emailMessage.*;
import static org.assertj.core.api.Assertions.assertThat;

/**
 * @author wangyan
 * @date 2019-02-23  下午 01:47
 */
@Listeners(emailMessage.class)
public class TestCase {


    public static void main(String[] args) throws DocumentException {
//        as("Nihao ");
//        TestNG testNG=new TestNG();
//        Class [] classes={TestCase.class};
//        testNG.setTestClasses(classes);
//////        testNG.setDefaultSuiteName("自定义suit");
//////        testNG.setDefaultSuiteName("");
//////        testNG.setDefaultTestName("测试名:");
////        List<String> a=new ArrayList<>();
////        a.add("1");
////        a.add("2");
////        a.add("3");
//        System.out.println("1"+suitname);
//        testNG.run();

//        String str0="浙江臻善科技股份有限公司-产品研发中心-产品支持部-自动化测试报告\n\n";
//        String str="尊敬的用户，以下是测试结果：\n";
////        String str1="\t测试模块："+suitname;
////        String str2="\n\t测试通过："+passed+"\n\t测试失败："+failed+"\n\t测试跳过："+skiped;
////        System.out.println(str0+str+"\n"+str1+str2);
//////        System.out.println(repath);
//        System.out.println("\t本地报告查看地址："+Path.reportPath()+"\\html\\index.html" );

//         Date da = new Date();
//         SimpleDateFormat day = new SimpleDateFormat("yyyy-MM-dd ");
//         SimpleDateFormat min = new SimpleDateFormat("yyyy-MM-dd HH:mm");
//
//        String path=System.getProperty("user.dir")+day.format(da).trim()+"\\aloo";
//       System.out.println("path:"+ Path.reportPath());
//
//        SAXReader reader = new SAXReader();
//        org.dom4j.Document document = reader.read("D:\\ha.xml");
//        OutputFormat of = new OutputFormat();
//        of.setEncoding("UTF-8"); //改变编码方式
//        XMLWriter writer = new XMLWriter(new FileWriter"d:\\dom4j.xml"),of);


        //1、创建一个DocumentBuilderFactory的对象
//        DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
//        //2、创建一个DocumentBuilder的对象
//        try {
//            //创建DocumentBuilder对象
//            DocumentBuilder db = dbf.newDocumentBuilder();
//            //3、通过DocumentBuilder对象的parser方法加载books.xml文件到当前项目下
//                      /*注意导入Document对象时，要导入org.w3c.dom.Document包下的*/
//            Document document = db.parse("D:\\work_space\\js_de\\debug\\SeleniumConfig\\bin\\Debug\\AutoTest_Reports\\2019-03-15\\12_51\\xml\\Test.DataProviderSet_Assert_results.xml");
//            //传入文件名可以是相对路径也可以是绝对路径
//            //获取所有book节点的集合
//            NodeList bookList = document.getElementsByTagName("testsuite");
//
//            //通过nodelist的getLength()方法可以获取bookList的长度
//            System.out.println("一共有" +document.getNodeName());
//
//
//
//        } catch (ParserConfigurationException e) {
//            e.printStackTrace();
//        } catch (IOException e) {
//            e.printStackTrace();
//        } catch (SAXException e) {
//            e.printStackTrace();
//        }
    }


    public static void as(String a){
        System.out.println("我是测试fangfa ");
        TestNG testNG=new TestNG();
//        Class [] classes={TestCase.class};
//        testNG.setTestClasses(classes);

        testNG.setXmlPathInJar(".\testng.xml");
        testNG.setTestJar("D:\\work_space\\js_de\\debug\\SeleniumConfig\\bin\\Debug\\SeleniumJAVA\\Selenium.jar");
        testNG.setXmlPathInJar("/");


        testNG.run();
//        Case3("哈哈哈");
    }




    @Test(description = "这个一看就是个loser")
    public void Case1(){


        System.out.println("=========Case1=======");
//
//            Assertion.verifyEquals("1","3");
//            Reporter.log(Assertion.errors.iterator().next().getMessage());

        Reporter.log("看一下哈12312312");


    }

    @Test
    public void Case2(){
        assertThat("旺达").as("不相等啊").isEqualTo("地主");
        Reporter.log("测试用例2");

//        System.out.println("=========Case2=======");
//        Assertion.verifyEquals(1, 1,"is not equal ");
//        OutputStream out=new FileOutputStream(new File());


    }


    public static void Case3(String a){
        System.out.println("=========Case3=======");
       System.out.println("我是case3："+a);



    }


}

