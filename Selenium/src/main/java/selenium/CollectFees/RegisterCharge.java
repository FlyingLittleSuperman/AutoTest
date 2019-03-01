package selenium.CollectFees;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeDriverService;
import org.openqa.selenium.chrome.ChromeOptions;
import org.openqa.selenium.support.ui.Select;

import java.io.File;
import java.util.List;

/**
 * Created by Administrator on 2016/12/13.
 */
public class RegisterCharge {
    public static void main(String[] args) throws Exception {
        ChromeDriverService service = null;
        WebDriver driver = null;
        try {
            service = new ChromeDriverService.Builder().usingDriverExecutable(
                    new File(
                            "C:\\\\Chrome34\\\\App\\\\Google Chrome\\\\chromedriver.exe")).usingAnyFreePort().build();
            service.start();

            ChromeOptions options = new ChromeOptions();
            options.addArguments("disable-extensions=Chrome Automation Extension"); //采用默认的谷歌配置参数
            driver = new ChromeDriver(options);

            //WebDriver driver = new RemoteWebDriver(service.getUrl(), DesiredCapabilities.chrome());
            driver.manage().window().maximize();
            driver.get("http://192.168.7.200:8084/GisqQueryList/rChargeServer?ver=house&op=write" +
                    "&BDFR_GUID=f186c627-e05d-11e5-8188-000c29187a9e&ID=e10a8b59-c0ef-11e6-b0b6-9c5c8e949727" +
                    "&CATEGORY=BDC&RECORDNUMBER=8e1fdb57-e604-4f96-ad93-8b2b14abbe31" +
                    "&BIZDEF_GUID=f18677f1-e05d-11e5-8188-000c29187a9e" +
                    "&BIZINST_GUID=e102c31e-c0ef-11e6-b0b6-9c5c8e949727&TYPE=form&userId=f2e37658-69d2-11e5-a045-000c297c0f34" +
                    "&TRANSACTOR=zscs&aid=sid-919D701A-D922-4252-8200-16E74FFD5C47" +
                    "&ACTDEFID=sid-919D701A-D922-4252-8200-16E74FFD5C47&tid=f6c522f0-c0ef-11e6-a15e-9c5c8e949727" +
                    "&ACTINSTID=f6c522f0-c0ef-11e6-a15e-9c5c8e949727&pid=2d107839-0de3-11e6-b878-000c2984e60c" +
                    "&PRODEFID=2d107839-0de3-11e6-b878-000c2984e60c&instid=df8d3a3e-c0ef-11e6-a15e-9c5c8e949727" +
                    "&PROINSTID=df8d3a3e-c0ef-11e6-a15e-9c5c8e949727&businesskey=20161213-0039516" +
                    "&PROJECTID=20161213-0039516&LCBM=2101&HJDM=CS&XZQBM=3315&task_state=null");
            RegisterCharge(driver);

        } catch (Exception er) {
            driver.quit();
            service.stop();
            er.printStackTrace();
        }
    }

    public static void RegisterCharge(WebDriver driverRegisterCharge) {
        WebElement elementSelectQlr = driverRegisterCharge.findElement(By.id("selectQlr"));
        Select selectQlr = new Select(elementSelectQlr);
        List<WebElement> listALlOPtions = selectQlr.getAllSelectedOptions();
        for (WebElement elementSingleQlr : listALlOPtions) {
            elementSelectQlr.click();

            WebElement elementSelectAll = driverRegisterCharge.findElement(By.id("checkAll"));
            elementSelectAll.click();

            WebElement elementSave = driverRegisterCharge.findElement(By.id("btn_save"));
            elementSave.click();

        }
    }

    public static void SureRegisterCharge(WebDriver driver) throws Exception {
        WebElement elementQrSf = driver.findElement(By.id("btn_sfqr"));
        elementQrSf.click();
        Thread.sleep(2000);
    }

}
