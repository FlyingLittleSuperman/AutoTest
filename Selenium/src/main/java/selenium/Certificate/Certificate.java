package selenium.Certificate;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeDriverService;
import org.openqa.selenium.chrome.ChromeOptions;

import java.io.File;
import java.util.List;

/**
 * Created by Administrator on 2016/12/14.
 */
public class Certificate {
    public static void main(String[] args) throws Exception {
        ChromeDriverService service = null;
        WebDriver driver = null;
        try {
            service = new ChromeDriverService.Builder().usingDriverExecutable(
                    new File(
                            "C:\\\\Users\\\\Administrator\\\\AppData\\\\Local\\\\Google\\\\Chrome\\\\Application\\\\chromedriver.exe")).usingAnyFreePort().build();
            service.start();

            ChromeOptions options = new ChromeOptions();
            options.addArguments("disable-extensions=Chrome Automation Extension"); //采用默认的谷歌配置参数
            driver = new ChromeDriver(options);

            //WebDriver driver = new RemoteWebDriver(service.getUrl(), DesiredCapabilities.chrome());
            driver.manage().window().maximize();
            driver.get("http://192.168.7.200:8084/GisqQueryList/views/reports/realestate/common/certificate/RECertiInfo.jsp" +
                    "?reportlet=realestate/common/certificate/RECertiInfo.cpt" +
                    "&bizinst_guid=81754039-c1c2-11e6-a3fa-9c5c8e949727" +
                    "&PROJECTID=20161214-0039582&userId=f2e37658-69d2-11e5-a045-000c297c0f34" +
                    "&hjdm=SZ&PROINSTID=80c6d882-c1c2-11e6-a192-9c5c8e949727" +
                    "&ACTDEFID=sid-77EDD353-06E8-4755-B486-143EF23C63C8" +
                    "&BDFR_GUID=f186c619-e05d-11e5-8188-000c29187a9e&LCBM=2101");
            CertificateNumber.execute(driver);

        } catch (Exception er) {
            driver.quit();
            service.stop();
            er.printStackTrace();
        }
    }

    public static void execute(WebDriver driver) throws Exception {
        System.out.println("开始执行缮证过程");
        Thread.sleep(2000);
        WebDriver driverFileBage = driver.switchTo().frame("clientContainer");
        List<WebElement> allElement = driverFileBage.findElements(By.tagName("iframe"));
        for (WebElement element : allElement) {
            try {
                String src1 = element.getAttribute("src1");
                System.out.println(src1);
                String id = element.getAttribute("id");
                System.out.println(id);
                //收费环节
                if (src1.indexOf("RECertiList.cpt") > -1) {
                    System.out.println("进入缮证页面");
                    WebDriver driverRegisterCharge = driverFileBage.switchTo().frame(id);
                    CertificateNumber.execute(driverRegisterCharge);
                }
            } catch (Exception er) {
                er.printStackTrace();
            }
        }
    }


}
