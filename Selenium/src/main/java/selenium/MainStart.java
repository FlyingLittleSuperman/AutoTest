package selenium;

import org.openqa.selenium.By;
import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeDriverService;
import org.openqa.selenium.chrome.ChromeOptions;
import org.openqa.selenium.support.ui.Select;
import selenium.Certificate.Certificate;
import selenium.CollectFees.CollectFees;
import selenium.FirstTrial.FirstTrial;
import selenium.Licensing.Licensing;
import selenium.RegBook.RegBook;
import selenium.SecondTrial.SecondTrial;
import selenium.ThreeTrial.ThreeTrial;
import selenium.common.ChangeDriver;
import selenium.workflow.QueryProList;
import selenium.workflow.WorkFlow;

import java.io.File;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.concurrent.TimeUnit;


/**
 * Created by Administrator on 2016/12/12.
 */
public class MainStart {

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
//            options.addExtensions(new File("C:\\Program Files (x86)\\timevale\\天印签章PDF版\\npSOFSignApi.dll"));
            //options.addExtensions(new File("C:\\Users\\swang\\AppData\\Local\\Google\\Chrome\\UserData\\Default\\Extensions\\ijaobnmmgonppmablhldddpfmgpklbfh\\1.6.0_0.crx"));
            //options.addArguments("C:\\Users\\Administrator.MTC-20151016FIN\\AppData\\Local\\Google\\Chrome\\User Data\\Default"); //采用默认的谷歌配置参数
            driver = new ChromeDriver(options);

            //WebDriver driver = new RemoteWebDriver(service.getUrl(), DesiredCapabilities.chrome());
            driver.manage().window().maximize();
            driver.get("http://192.168.2.119:8082/GisqPlatformExplorer/a/login;JSESSIONID=7a22b82495884077a7860a3b86e8ac2f");
            WebElement username = driver.findElement(By.id("username"));
            username.sendKeys("zscs");
            WebElement password = driver.findElement(By.id("password"));
            password.sendKeys("1234");
            driver.manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);
            WebElement buttom = driver.findElement(By.className("login_button"));
            buttom.click();

            driver.switchTo().frame("view_首页0");

            WebElement fdfj = driver.findElement(By.id("38bcedca-df88-11e5-b408-000c29187a9e"));
            fdfj.click();

            WebElement scfj = driver.findElement(By.xpath("//a[@pid='2d107839-0de3-11e6-b878-000c2984e60c']"));
            scfj.click();
            driver.switchTo().defaultContent();
            driver.manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);
            Thread.sleep(2000); //等待窗口弹出来
            String currentWindow = driver.getWindowHandle();
            System.out.print("主框架句柄：" + currentWindow);

            WebDriver webNewWindow = ChangeDriver.change(driver, currentWindow);
            webNewWindow.switchTo().defaultContent();



            String url = webNewWindow.getCurrentUrl();
            Map<String, String> allRequestParam = getAllRequestParam(url);
            WebDriver driverFilePage = webNewWindow.switchTo().frame("clientContainer");
            String projectId = allRequestParam.get("businesskey".toUpperCase());

          /*  WebElement elementSlTzs= driverFilePage.findElement(By.id("ztree_9_a"));
            elementSlTzs.click();*/


            List<WebElement> allElement = driverFilePage.findElements(By.tagName("iframe"));
            for (WebElement element : allElement) {
                try {
                    String src1 = element.getAttribute("src1");
                    String id = element.getAttribute("id");
                    if (src1.indexOf("datums_submit") > -1) {
                        WebDriver driverDataSubmit = driverFilePage.switchTo().frame(id);
                        WebElement elementDataSubmit = driverDataSubmit.findElement(By.xpath("//div[@role='combobox']"));
                        String jqWidgetsId = elementDataSubmit.getAttribute("id");
                        //选择资料类别，默认选中第一个
                        String js = "$(\"#" + jqWidgetsId + "\").jqxDropDownList('selectIndex', 0 );";
                        String input_title = (String) ((JavascriptExecutor) driver).executeScript(js);

                        //保存资料类别
                        WebElement elementSaveDatum = driverDataSubmit.findElement(By.id("saveDatum"));
                        elementSaveDatum.click();
                    }
                } catch (Exception er) {

                }
            }
            Thread.sleep(2000);
            //处理受理申请信息
            webNewWindow.switchTo().defaultContent();
            driverFilePage = webNewWindow.switchTo().frame("clientContainer");
            WebElement elementSQXX = driverFilePage.findElement(By.xpath("//a[@title='申请信息']"));
            elementSQXX.click();
            allElement = driverFilePage.findElements(By.tagName("iframe"));
            for (WebElement element : allElement) {
                try {
                    String src1 = element.getAttribute("src1");
                    String id = element.getAttribute("id");
                    if (src1.indexOf("Acceptance_HouseRight_Initial.jsp") > -1) {
                        WebDriver driverSLSQ = driverFilePage.switchTo().frame(id);

                        WebElement elementCXBDC = driverSLSQ.findElement(By.id("CXBDC"));
                        elementCXBDC.click();
                        Thread.sleep(2000); //等待窗口弹出来


                        //输入不动产单元号查询条件
                        WebDriver driverIframeDY = driverSLSQ.switchTo().frame("iFrameDY");
                        WebElement elementBdcdyh = driverIframeDY.findElement(By.id("bdcdyh"));
                        String test = "123";
                        elementBdcdyh.sendKeys("330102003004GB00064F00010010");


                        WebElement elementQuery = driverIframeDY.findElement(By.id("btn_search"));
                        elementQuery.click();


                        Thread.sleep(1000);

                        //全选
                        WebElement elementCheckAll = driverIframeDY.findElement(By.xpath("//div[@class='l-grid-hd-cell-text l-grid-hd-cell-btn-checkbox']"));
                        elementCheckAll.click();

                        //确认选择
                        WebElement elementSureClick = driverIframeDY.findElement(By.id("btn_ok"));
                        elementSureClick.click();

                        Thread.sleep(5000);

                        //弹出申请人界面
                        webNewWindow.switchTo().defaultContent();
                        driverFilePage = webNewWindow.switchTo().frame("clientContainer");
                        driverSLSQ = driverFilePage.switchTo().frame(id);
                        WebElement elementTdsyqz = driverSLSQ.findElement(By.id("TJSQR"));
                        elementTdsyqz.click();

                        //跳转到申请人录入界面
                        WebDriver driverSqr = driverSLSQ.switchTo().frame("addSqr");


                        //申请人类别
                        WebElement webSqrLb = driverSqr.findElement(By.id("SQRLB"));
                        Select selectSqrLb = new Select(webSqrLb);
                        selectSqrLb.selectByValue("1");

                        //申请人名称
                        WebElement webSqrMC = driverSqr.findElement(By.id("SQRMC"));
                        webSqrMC.sendKeys("倪明奇自动化测试首次登记");

                        //申请人类型
                        WebElement webSqrLx = driverSqr.findElement(By.id("SQRLX"));
                        Select selectSqrLx = new Select(webSqrLx);
                        selectSqrLx.selectByValue("1");

                        //证件种类
                        WebElement webZjzl = driverSqr.findElement(By.id("ZJZL"));
                        Select selectZJzl = new Select(webZjzl);
                        selectZJzl.selectByValue("2");

                        //证件号
                        Double zjhRandom = Math.random();
                        WebElement webZjh = driverSqr.findElement(By.id("ZJH"));
                        webZjh.sendKeys("ZDHCS" + zjhRandom);

                        //共有方式
                        WebElement webGYfs = driverSqr.findElement(By.id("GYFS"));
                        Select selectGyfs = new Select(webGYfs);
                        selectGyfs.selectByValue("1");

                        //移动电话
                        WebElement webYDDH = driverSqr.findElement(By.id("YDDH"));
                        webYDDH.sendKeys("13588104047");

                        //保存申请人
                        WebElement webSqrSave = driverSqr.findElement(By.xpath("//span[@class=' x-emb-submit']"));
                        webSqrSave.click();

                        //切回申请人界面
                        webNewWindow.switchTo().defaultContent();
                        driverFilePage = webNewWindow.switchTo().frame("clientContainer");
                        driverSLSQ = driverFilePage.switchTo().frame(id);


                        //关闭申请人对话框
                        WebElement webClose = driverSLSQ.findElement(By.xpath("//a[@class='jbox-close']"));
                        webClose.click();


                        //土地证书
                        WebElement elementTDSYZ = driverSLSQ.findElement(By.id("GFHTBH_TDZ"));
                        elementTdsyqz.sendKeys("测试土地证书");

                        WebElement elementCZRMC = driverSLSQ.findElement(By.id("CZRMC"));
                        elementCZRMC.sendKeys("测试持证人");

                        WebElement elementBZ = driverSLSQ.findElement(By.id("BZ"));
                        elementBZ.sendKeys("测试备注");


                        //不注销土地大证
                        WebElement elementSFZXDZ = driverSLSQ.findElement(By.xpath("//input[@name='GETSFZXYTDDZ'and@value='0']"));
                        elementSFZXDZ.click();


                        //保存受理申请信息
                        WebElement elementSLSQSave = driverSLSQ.findElement(By.xpath("//span[@class=' x-emb-submit']"));
                        elementSLSQSave.click();

                        Thread.sleep(3000);
                        //移交页面
                        webNewWindow.switchTo().defaultContent();
                        WorkFlow.execute(webNewWindow);
                        driver.switchTo().window(currentWindow);

                        Thread.sleep(500);

                        QueryProList.execute(driver, projectId);


                        driver.switchTo().defaultContent();
                        //driver.manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);
                        Thread.sleep(2000); //等待窗口弹出来
                        WebDriver webSercond = ChangeDriver.change(driver, currentWindow);

                        //初审环节处理
                        FirstTrial.execute(webSercond);
                        webSercond.switchTo().defaultContent();
                        WorkFlow.execute(webSercond);

                        //切回首页
                        driver.switchTo().window(currentWindow);
                        QueryProList.execute(driver, projectId);


                        Thread.sleep(2000); //等待窗口弹出来
                        WebDriver webThree = ChangeDriver.change(driver, currentWindow);

                        //复审环节处理
                        SecondTrial.execute(webThree);
                        webThree.switchTo().defaultContent();
                        WorkFlow.execute(webThree);

                        //切回首页
                        driver.switchTo().window(currentWindow);
                        QueryProList.execute(driver, projectId);


                        Thread.sleep(2000); //等待窗口弹出来
                        WebDriver webFour = ChangeDriver.change(driver, currentWindow);
                        //核定环节处理
                        ThreeTrial.execute(webFour);
                        webFour.switchTo().defaultContent();
                        WorkFlow.execute(webFour);

                        //切回首页
                        driver.switchTo().window(currentWindow);
                        QueryProList.execute(driver, projectId);

                        Thread.sleep(2000); //等待窗口弹出来
                        WebDriver webDB = ChangeDriver.change(driver, currentWindow);
                        //登簿环节处理
                        RegBook.execute(webDB);
                        webDB.switchTo().defaultContent();
                        WorkFlow.execute(webDB);

                        //切回首页
                        driver.switchTo().window(currentWindow);
                        QueryProList.execute(driver, projectId);


                        Thread.sleep(2000); //等待窗口弹出来
                        WebDriver webSZ = ChangeDriver.change(driver, currentWindow);
                        //缮证环节处理
                        Certificate.execute(webSZ);
                        webSZ.switchTo().defaultContent();
                        WorkFlow.execute(webSZ);

                        //切回首页
                        driver.switchTo().window(currentWindow);
                        QueryProList.execute(driver, projectId);


                        Thread.sleep(2000); //等待窗口弹出来
                        WebDriver webSf = ChangeDriver.change(driver, currentWindow);
                        //收费环节处理
                        CollectFees.execute(webSf);
                        webSf.switchTo().defaultContent();
                        WorkFlow.execute(webSf);

                        //切回首页
                        driver.switchTo().window(currentWindow);
                        QueryProList.execute(driver, projectId);


                        Thread.sleep(2000); //等待窗口弹出来
                        WebDriver webLZ = ChangeDriver.change(driver, currentWindow);
                        Licensing.execute(webLZ);
                        webLZ.switchTo().defaultContent();
                        WorkFlow.execute(webLZ, true);

                        //切回首页
                        driver.switchTo().window(currentWindow);

                        System.out.println(projectId);

                    }
                } catch (Exception er) {
                    if (er.getMessage() != null && er.getMessage().indexOf("element is not attached to the page document") == -1) {
                        er.printStackTrace();
                    }
                }
            }


        } catch (Exception er) {

            driver.quit();
            service.stop();
            throw new RuntimeException(er.getMessage());
        }

    }

    private static Map<String, String> getAllRequestParam(String url) {
        //String url="http://192.168.7.200:8082/GisqPlatformExplorer/a/workflow/taskList/task?aid=sid-919D701A-D922-4252-8200-16E74FFD5C47&tid=fb92e978-c0ed-11e6-a15e-9c5c8e949727&pid=2d107839-0de3-11e6-b878-000c2984e60c&instid=d6ba14b6-c0ed-11e6-a15e-9c5c8e949727&businesskey=20161213-0039515&name=%E5%80%AA%E6%98%8E%E5%A5%87%E8%87%AA%E5%8A%A8%E5%8C%96%E6%B5%8B%E8%AF%95%E9%A6%96%E6%AC%A1%E7%99%BB%E8%AE%B0&task_name=%E5%88%9D%E5%AE%A1&execution_procDefName=%E9%A6%96%E6%AC%A1%E7%99%BB%E8%AE%B0&processKey=pid-ccce3e0a-89e2-453b-a271-1a9f376f8a9b&HJDM=CS";
        Map<String, String> allRequestParam = new HashMap<String, String>();
        String[] arrUrls = url.split("\\?");
        if (arrUrls.length == 1) {
            return allRequestParam;
        } else {
            String[] arrParams = arrUrls[1].split("&");
            for (String params : arrParams) {

                String[] arrKeyAndValue = params.split("=");
                if (arrKeyAndValue.length == 1) {
                    allRequestParam.put(arrKeyAndValue[0].toUpperCase(), "");
                } else {
                    allRequestParam.put(arrKeyAndValue[0].toUpperCase(), arrKeyAndValue[1]);
                }
            }
        }

        return allRequestParam;
    }
}
