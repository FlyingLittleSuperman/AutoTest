package Test.Report;

import org.testng.Reporter;
import org.testng.TestNG;
import org.testng.annotations.Listeners;
import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

@Listeners(value = {org.uncommons.reportng.HTMLReporter.class, org.uncommons.reportng.JUnitXMLReporter.class})

public class debug {

    public static void main(String []args){
        TestNG testNG=new TestNG();
        Class[] list={debug.class};
        testNG.setTestClasses(list);

        Reporter.setEscapeHtml(false);

        testNG.setDefaultTestName("断言详情查看");
        testNG.setOutputDirectory( "E:\\调试");

////            testNG.setGroups("你好"+i);
        testNG.run();
    }
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
}
