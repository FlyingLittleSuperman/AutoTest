package configSelenium.Assert;

import configSelenium.ConfigSeleniumStart;
import org.testng.*;
import org.testng.annotations.BeforeTest;
import org.testng.annotations.Listeners;
import org.testng.annotations.Parameters;
import org.testng.annotations.Test;
import org.testng.log4testng.Logger;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStream;
import java.util.ArrayList;
import java.util.List;

/**
 * @author wangyan
 * @date 2019-02-23  下午 01:47
 */
@Listeners(configSelenium.Assert.AssertListener.class)
public class TestCase {

    public static void main(String[] args){
        as("Nihao ");
    }




    public static void as(String a){
//        System.out.println("我是测试fangfa ");
//        TestNG testNG=new TestNG();
//        Class [] classes={TestCase.class};
//        testNG.setTestClasses(classes);
//        testNG.run();

        TestNG testNG = new TestNG();
        Class[] classes = {ConfigSeleniumStart.class};
        List<String> suites = new ArrayList<String>();
        suites.add("D:\\work_space\\js_de\\debug\\Selenium\\TestNG\\testng.xml");//此处为xml的绝对路径
        testNG.setTestSuites(suites);
        System.out.println("testng已经就位");

        testNG.setOutputDirectory("D:\\AutoTest_Reports");
        Case3("断言");
        testNG.run();
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

//        System.out.println("=========Case2=======");
//        Assertion.verifyEquals(1, 1,"is not equal ");
//        OutputStream out=new FileOutputStream(new File());


    }


    public static void Case3(String a){
        System.out.println("=========Case3=======");
       System.out.println("我是case3："+a);
       Assertion.verifyEquals("2","3");



    }


}

