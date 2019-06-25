package Test.Assert;

import org.testng.Reporter;
import org.testng.annotations.Listeners;
import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * @author wangyan
 * @date 2019-04-11  上午 10:41
 */
@Listeners({org.uncommons.reportng.HTMLReporter.class,org.uncommons.reportng.JUnitXMLReporter.class})
public class Testcase1 {

    @Test
    public void Case1(){
        assertThat("旺达1111").as("不相等啊").isEqualTo("旺达");

        String path="D:\\work_space\\js_de\\debug\\SeleniumConfig\\bin\\Debug\\SootScreens\\2019-03-27\\09_39\\资料收取 09_39.png";
        Reporter.log("测试用例2");
        Reporter.log("<img src=\""+ path +"\""+ "  hight=\"300\" width=\"300\"  >");


    }
}
