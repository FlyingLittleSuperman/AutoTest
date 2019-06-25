package Test.Report;

import com.sun.glass.ui.Application;
import configSelenium.ConfigSeleniumStart;
import org.testng.*;
import org.testng.annotations.Listeners;
import org.testng.annotations.Test;
import org.testng.xml.XmlSuite;
import util.Escape;
import util.Path;

import java.io.File;
import java.io.FileNotFoundException;
import java.net.URL;
import java.util.ArrayList;
import java.util.List;
import Test.emailMessage;


import static Test.emailMessage.failed;
import static Test.emailMessage.passed;
import static Test.emailMessage.*;
import static org.assertj.core.api.Assertions.assertThat;

/**
 * @author wangyan
 * @date 2019-04-17  下午 02:38
 */

@Listeners(value = {org.uncommons.reportng.HTMLReporter.class, org.uncommons.reportng.JUnitXMLReporter.class})
public class test_case  {

    public final String path = null;

    public static  void test()throws Exception{
        int a=3,b=0;
        String str=null;
        try {
            int c=a/b;
            String str1=str;
        } catch (ArithmeticException e){
            System.out.println("不能被0整除!");


        }
        catch (Exception er){
            System.out.println("还能到我这里吗");
            er.printStackTrace();


        }

    }


    public static void main(String[] args) throws Exception {


        String str=System.getProperty("user.dir")+"\\1234";
        String str1=".\\1234\\test1222";

        str1.replace(".",System.getProperty("user.dir"));
        System.out.println(str1);
////        String  str2=".\\1234\\test456";
////        String  str3="\\1234\\test789";
        File file=new File(str);
        File file1=new File(str1);
////        File file2=new File(str2);
////        File file3=new File(str3);
        if(!file.exists()){
            file.mkdirs();
            System.out.println("第一个可以");
        }
        if(!file1.exists()){
            file1.mkdir();
            System.out.println("第2个可以");
        }
//        if(!file2.exists()){
//            file2.mkdir();
//            System.out.println("第3个可以");
//        }
//        if(!file3.exists()){
//            file3.mkdir();
//            System.out.println("第4个可以");
//        }
        System.out.println("1:"+file.getAbsolutePath()+"\n"+file1.getAbsolutePath());

//        String str="你好:你这";
//        System.out.println(str.substring(str.lastIndexOf(":")+1));
//        try {
//
//            for (int i = 0; i < 3; i++) {
//                System.out.println("查看一下i：" + i);
//                try {
//                    test();
//                    System.out.println("循环后，我还跑不跑？"+i);
//                } catch (Exception e) {
//                    e.printStackTrace();
////                    throw e;
//                }finally {
//                    System.out.println("我在方法里面"+i);
//                }
//                System.out.println("在循环内"+i);
//            }
//            System.out.println("我在循环外边");
//            System.out.println("我希望我一直被执行");
//        }catch (Exception er){
//           er.printStackTrace();
//
////            System.exit(0);
////            throw er;
//        }


//        TestNG testNG=new TestNG();
//        Class[] list={test_case.class};
//        testNG.setTestClasses(list);
////        List<Class<? extends ITestNGListener>> listens=new ArrayList<>();
////        listens.add(Test.emailMeaasge.class);
////        testNG.setListenerClasses(listens);
//        Reporter.setEscapeHtml(false);
//        testNG.setOutputDirectory("d://");
//
//
//        System.out.println("报告输出路径："+testNG.getOutputDirectory());
//        testNG.run();
    }


//    @DataProvider(name = "createData")
//    public Iterator<Object[]> createData(){
//        List<Object[]> dataProvider = new ArrayList<Object[]>();
//        for (int i=0;i<2;i++){
//            String[] s = {String.format("我是第（%s）个参数",i)};
//            dataProvider.add(s);
//        }
//        return  dataProvider.iterator();
//    }
//
//    @Test(dataProvider = "creatData")
//    public void dataProviderTest(String s){
//        //输出log会在报告中提现
//        Reporter.log("获取到参数："+s,true);
//        Assert.assertTrue(s.length()>2," 成功？失败？");
//    }
//
    @Test
    public void test1() {
//        Assert.assertTrue(true,"成功咯!");
//        name="1314";
        assertThat("你好").isEqualTo("大家").as("不相等");
        Reporter.log("我是test——case的tetsTrue");
    }

    @Test
    public void testFail() {
//        Assert.fail("失败咯!");
        assertThat("设么").isEqualTo("设么").as("相等");
        Reporter.log("我是test——case的tetsFail");
    }


//    @Test
//    public void Case2(){
//        assertThat("旺达").as("不相等啊").isEqualTo("旺达");
//        String path="D:\\work_space\\js_de\\debug\\SeleniumConfig\\bin\\Debug\\SootScreens\\2019-03-27\\09_39\\资料收取 09_39.png";
//        Reporter.log("测试用例2");
//        Reporter.log("<img src=\""+ path +"\""+ "  hight=\"300\" width=\"300\"  >");
//
//        Reporter.log("<object type=\"application/pdf\" data=\"E:\\work_space\\js_de\\debug\\SeleniumConfig\\bin\\Debug\\FR\\2019-03-20\\20_00\\使用权262e24ae-1f00-11e9-9cb9-00505683a231df2606f6-e189-4109-91bd-30270f38a1d92019-03-20 20.pdf\""
//                + "id=\"review\" style=\"width:800px;  height:750px; margin-top:45px;  margin-left:500px\" >\n" +
//                "</object>");
//
//
//    }


}
