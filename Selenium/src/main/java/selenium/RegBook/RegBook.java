package selenium.RegBook;

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
public class RegBook {

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
            driver.get("http://192.168.7.200:8084/GisqQueryList/views/reports/realestate/common/recordregbook/" +
                    "RECertiRecordRegBook_Initial_F.jsp?reportlet=realestate/common/recordregbook/" +
                    "RECertiRecordRegBook_Initial_F.cpt&op=write" +
                    "&BDFR_GUID=76cb87db-e68f-11e5-a54a-000c29187a9e&ID=8040d207-c1bd-11e6-a3fa-9c5c8e949727" +
                    "&CATEGORY=BDC&RECORDNUMBER=b00ed4f7-4490-45c5-b081-dd0acf4e706f" +
                    "&BIZDEF_GUID=f18677f1-e05d-11e5-8188-000c29187a9e&BIZINST_GUID=80358745-c1bd-11e6-a3fa-9c5c8e949727" +
                    "&TYPE=form&userId=f2e37658-69d2-11e5-a045-000c297c0f34&TRANSACTOR=zscs" +
                    "&aid=sid-69DA37DF-F769-4B36-9EB1-B5AD0A9A5ED1" +
                    "&ACTDEFID=sid-69DA37DF-F769-4B36-9EB1-B5AD0A9A5ED1&tid=bb60ed07-c1bd-11e6-a192-9c5c8e949727" +
                    "&ACTINSTID=bb60ed07-c1bd-11e6-a192-9c5c8e949727" +
                    "&pid=2d107839-0de3-11e6-b878-000c2984e60c&PRODEFID=2d107839-0de3-11e6-b878-000c2984e60c" +
                    "&instid=7f6bf4f1-c1bd-11e6-a192-9c5c8e949727&PROINSTID=7f6bf4f1-c1bd-11e6-a192-9c5c8e949727" +
                    "&businesskey=20161214-0039575&PROJECTID=20161214-0039575&LCBM=2101&HJDM=DB&XZQBM=3315&task_state=null");
            RegisterBook.execute(driver);

        } catch (Exception er) {
            driver.quit();
            service.stop();
            er.printStackTrace();
        }
    }

    public static void execute(WebDriver driver) throws Exception {
        System.out.println("开始执行登簿过程");
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
                if (src1.indexOf("RECertiRecordRegBook_Initial.jsp") > -1) {
                    WebDriver driverRegisterCharge = driverFileBage.switchTo().frame(id);
                    RegisterBook.execute(driverRegisterCharge);
                }
            } catch (Exception er) {
                er.printStackTrace();
            }
        }
    }
}
