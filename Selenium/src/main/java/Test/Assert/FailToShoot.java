package Test.Assert;

import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.WebDriver;
import org.testng.ITestResult;
import org.testng.TestListenerAdapter;
import util.Screenshoot;

import java.io.IOException;

/**
 * @author wangyan
 * @date 2019-03-10  上午 10:28
 *
 * 断言错误截图，但是目前没想到好的driver传递方式；而且目前断言采用结果集统一处理的方式
 */
public class FailToShoot extends TestListenerAdapter {



    @Override
    public void onTestFailure(ITestResult it){
        try{
            WebDriver driver=new ChromeDriver();
            Screenshoot.getShoot(driver,"");
        }catch (SecurityException e) {
            e.printStackTrace();
        } catch (IllegalArgumentException e) {
            e.printStackTrace();
        } catch (InterruptedException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

}
