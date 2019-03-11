package Test.Assert;

import org.testng.*;
import org.testng.annotations.Test;
import util.Path;

import java.util.ArrayList;
import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * @author wangyan
 * @date 2019-02-23  下午 01:47
 */
//@Listeners(AssertListener.class)
public class TestCase {

    public static void main(String[] args){
//        as("Nihao ");
//        TestNG testNG=new TestNG();
//        Class [] classes={TestCase.class};
//        testNG.setTestClasses(classes);
////        testNG.setDefaultSuiteName("自定义suit");
////        testNG.setDefaultSuiteName("");
////        testNG.setDefaultTestName("测试名:");
//        List<String> a=new ArrayList<>();
//        a.add("1");
//        a.add("2");
//        a.add("3");
//        testNG.setTestNames(a);
//
//
//
//
//        testNG.run();
//         Date da = new Date();
//         SimpleDateFormat day = new SimpleDateFormat("yyyy-MM-dd ");
//         SimpleDateFormat min = new SimpleDateFormat("yyyy-MM-dd HH:mm");
//
//        String path=System.getProperty("user.dir")+day.format(da).trim()+"\\aloo";
       System.out.println("path:"+ Path.reportPath());





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

