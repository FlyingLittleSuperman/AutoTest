package selenium.CollectFees;

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
public class CollectFees {

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
                    "&BDFR_GUID=f186c627-e05d-11e5-8188-000c29187a9e" +
                    "&ID=8186f384-c1c2-11e6-a3fa-9c5c8e949727&CATEGORY=BDC" +
                    "&RECORDNUMBER=375b04a3-25fc-40b7-b293-af422c0336f1" +
                    "&BIZDEF_GUID=f18677f1-e05d-11e5-8188-000c29187a9e" +
                    "&BIZINST_GUID=81754039-c1c2-11e6-a3fa-9c5c8e949727&TYPE=form" +
                    "&userId=f2e37658-69d2-11e5-a045-000c297c0f34&TRANSACTOR=zscs" +
                    "&aid=sid-534618B1-950C-4C1F-A008-C1A39C0EBD64" +
                    "&ACTDEFID=sid-534618B1-950C-4C1F-A008-C1A39C0EBD64&tid=f8ba8edb-c1c6-11e6-a192-9c5c8e949727" +
                    "&ACTINSTID=f8ba8edb-c1c6-11e6-a192-9c5c8e949727&pid=2d107839-0de3-11e6-b878-000c2984e60c" +
                    "&PRODEFID=2d107839-0de3-11e6-b878-000c2984e60c&instid=80c6d882-c1c2-11e6-a192-9c5c8e949727" +
                    "&PROINSTID=80c6d882-c1c2-11e6-a192-9c5c8e949727&businesskey=20161214-0039582" +
                    "&PROJECTID=20161214-0039582&LCBM=2101&HJDM=SF&XZQBM=3315&task_state=null");
            RegisterCharge.SureRegisterCharge(driver);

        } catch (Exception er) {
            driver.quit();
            service.stop();
            er.printStackTrace();
        }
    }

    public static void execute(WebDriver driver) throws Exception {
        System.out.println("开始执行收费过程");
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
                if (src1.indexOf("rChargeServer") > -1) {
                    WebDriver driverRegisterCharge = driverFileBage.switchTo().frame(id);
                    RegisterCharge.SureRegisterCharge(driverRegisterCharge);
                }
            } catch (Exception er) {
                er.printStackTrace();
            }
        }
    }
}
