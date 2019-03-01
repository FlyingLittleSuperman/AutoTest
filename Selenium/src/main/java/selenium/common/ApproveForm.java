package selenium.common;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeDriverService;
import org.openqa.selenium.chrome.ChromeOptions;
import org.openqa.selenium.support.ui.ExpectedCondition;
import org.openqa.selenium.support.ui.WebDriverWait;
import util.FRValue;
import util.TrialEnum;

import java.io.File;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by Administrator on 2016/12/13.
 */
public class ApproveForm {
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
            //options.addExtensions(new File("C:\\Program Files (x86)\\timevale\\天印签章PDF版\\npSOFSignApi.dll"));
            driver = new ChromeDriver(options);

            //WebDriver driver = new RemoteWebDriver(service.getUrl(), DesiredCapabilities.chrome());
            driver.manage().window().maximize();
            driver.get("http://192.168.7.200:8084/realestate/ReportServer?reportlet=" +
                    "realestate/common/approveform/ApproveForm.cpt&op=write" +
                    "&BDFR_GUID=f186c615-e05d-11e5-8188-000c29187a9e&ID=e10a8b75-c0ef-11e6-b0b6-9c5c8e949727" +
                    "&CATEGORY=BDC&RECORDNUMBER=8e1fdb57-e604-4f96-ad93-8b2b14abbe31" +
                    "&BIZDEF_GUID=f18677f1-e05d-11e5-8188-000c29187a9e" +
                    "&BIZINST_GUID=e102c31e-c0ef-11e6-b0b6-9c5c8e949727&TYPE=form" +
                    "&userId=f2e37658-69d2-11e5-a045-000c297c0f34&TRANSACTOR=zscs" +
                    "&aid=sid-919D701A-D922-4252-8200-16E74FFD5C47" +
                    "&ACTDEFID=sid-919D701A-D922-4252-8200-16E74FFD5C47&tid=f6c522f0-c0ef-11e6-a15e-9c5c8e949727" +
                    "&ACTINSTID=f6c522f0-c0ef-11e6-a15e-9c5c8e949727&pid=2d107839-0de3-11e6-b878-000c2984e60c" +
                    "&PRODEFID=2d107839-0de3-11e6-b878-000c2984e60c&instid=df8d3a3e-c0ef-11e6-a15e-9c5c8e949727" +
                    "&PROINSTID=df8d3a3e-c0ef-11e6-a15e-9c5c8e949727&businesskey=20161213-0039516" +
                    "&PROJECTID=20161213-0039516&LCBM=2101&HJDM=CS&XZQBM=3315&task_state=null");
            List<TrialEnum> trialEnumList = new ArrayList<TrialEnum>();
            trialEnumList.add(TrialEnum.初审);
            trialEnumList.add(TrialEnum.复审);
            trialEnumList.add(TrialEnum.核定);
            ApproveForm(driver, trialEnumList);

        } catch (Exception er) {
            driver.quit();
            service.stop();
            er.printStackTrace();
        }
    }


    public static void ApproveForm(WebDriver driverApproveForm, List<TrialEnum> trialEnumList) throws Exception {

        WebDriverWait wait = new WebDriverWait(driverApproveForm, 10); // 最多等10秒
        WebElement elementYJY = wait.until(new ExpectedCondition<WebElement>() {
            @Override
            public WebElement apply(WebDriver d) {
                return d.findElement(By.xpath("//div[@title='意见页']"));
            }
        });
        elementYJY.click();
        Thread.sleep(2000);
        for (TrialEnum trialEnum : trialEnumList) {
            switch (trialEnum) {
                case 初审:
                    FRValue.SetFRValue(driverApproveForm, "GTCSYJ", "自动化测试初审意见");
                    FRValue.SetFRValue(driverApproveForm, "GTCSR", "自动化测试-倪明奇初审");
                    FRValue.SetFRValue(driverApproveForm, "FCCSSJ", "2016-12-13");
                    break;
                case 复审:
                    FRValue.SetFRValue(driverApproveForm, "GTFSYJ", "自动化测试复审意见");
                    FRValue.SetFRValue(driverApproveForm, "GTFSR", "自动化测试-倪明奇复审");
                    FRValue.SetFRValue(driverApproveForm, "FCFSSJ", "2016-12-14");
                    break;
                case 核定:
                    FRValue.SetFRValue(driverApproveForm, "HDYJ", "自动化测试核定意见");
                    FRValue.SetFRValue(driverApproveForm, "HDFZR", "自动化测试-倪明奇核定");
                    FRValue.SetFRValue(driverApproveForm, "HDRQ", "2016-12-15");
                    break;
            }
        }

        List<WebElement> elementSave = driverApproveForm.findElements(By.xpath("//button[@class='fr-btn-text x-emb-submit']"));
        for (WebElement element : elementSave) {
            if (element.getAttribute("innerText").equals("保存")) {
                element.click();
            }
        }


    }


}
