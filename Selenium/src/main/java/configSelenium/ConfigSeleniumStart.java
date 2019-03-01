package configSelenium;

import configSelenium.Assert.Assert_database;
import configSelenium.Assert.Assertion;
import configSelenium.Entity.CommonConfig;
import configSelenium.Entity.ProInfo.Actdef;
import configSelenium.Entity.ProInfo.Prodef;
import configSelenium.Entity.SeleniumTest.ChildLocationElement;
import configSelenium.Entity.SeleniumTest.Iframe;
import configSelenium.Entity.SeleniumTest.LocationElement;
import dao.DataProviderSet_procedure;
import org.apache.commons.io.FileUtils;
import org.openqa.selenium.*;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeDriverService;
import org.openqa.selenium.chrome.ChromeOptions;
import org.openqa.selenium.interactions.Actions;
import org.openqa.selenium.support.ui.ExpectedCondition;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.Select;
import org.openqa.selenium.support.ui.WebDriverWait;
import org.testng.*;
import org.testng.annotations.Test;
import org.testng.annotations.*;
import selenium.common.ChangeDriver;
import util.CacheUtils;
import util.DataBase;
import util.DateUtils;
import util.FRValue;

import java.io.File;
import java.sql.ResultSet;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Map;
import java.util.concurrent.TimeUnit;

import static configSelenium.ScreenShot.getDateFormat;


/**
 * Created by Administrator on 2016/12/21.
 */

public class ConfigSeleniumStart {

    public static ChromeDriverService service;
    public static String actual;
    public static String except;


    public static void main(String[] args) throws Exception {


        if (!(args.length > 0 && args[0].equals("C#"))) {
            File file = new File("");
            StaticValue.ApplicationPath = file.getAbsolutePath();
            System.out.println("开始"+file.getAbsolutePath());
        }

        System.out.println(StaticValue.ApplicationPath);



        WebDriver driver = null;

        WebElement webElement = null;

        try {

            System.out.println("开始准备数据");
            Reporter.log("开始准备测试数据 ");
            System.out.println("开始缓存总体参数配置文件");
            InitCommonParameter.SetCommonConfigCache(); //初始化配置参数缓存
            System.out.println("缓存总体参数配置文件成功！");

            System.out.println("开始缓存SQL配置信息");//SQL配置信息缓存
            InitCommonParameter.InitSqlConfig();
            System.out.println("缓存SQL配置信息成功！");

            System.out.println("开始缓存SQL配置的SQL语句信息");//SQL配置信息缓存
            InitCommonParameter.InitSqlConfigBatchSql();
            System.out.println("缓存SQL配置的SQL语句信息成功！");

            System.out.println("开始缓存自动化测试配置方案文件");
            InitCommonParameter.InitSeleniumConfig();//初始化测试配置方案
            System.out.println("缓存自动化测试配置方案文件成功！");
            System.out.println("开始缓存初始化配置参数成功！");
            InitCommonParameter.SetProdefConfigCache(); //初始化流程配置信息
            System.out.println("缓存流程配置信息成功！");


            /*
            /**
             * 初始化ChormeDriver
             */

            //目前在其他人电脑出现问题，先写死driver配置。2019/0125
//            System.setProperty("webdriver.chrome.driver", "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chromedriver.exe");

            CommonConfig commonConfig = (CommonConfig) CacheUtils.get(StaticValue.CommonConfigCacheName, StaticValue.InitParameterKeyName);
            Map<String, StringBuilder> mapAllSchema = (Map<String, StringBuilder>) CacheUtils.get(StaticValue.SqlConfigCacheName, StaticValue.InitSqlConfigAllSqlKeyName);
            Map<String, String> mapColumnValue = (Map<String, String>) CacheUtils.get(StaticValue.SqlConfigCacheName, StaticValue.InitSqlCondfigColumnValue);
            service = new ChromeDriverService.Builder().usingDriverExecutable(
                    new File(commonConfig.getChromeDriverUrl())).usingAnyFreePort().build();

            service.start();

            System.out.println("初始化ChromeDriver成功！");

            ChromeOptions options = new ChromeOptions();
            options.addArguments("disable-extensions=Chrome Automation Extension"); //采用默认的谷歌配置参数

            driver = new ChromeDriver(options);

            driver.manage().window().maximize();
            driver.get(commonConfig.getLoginUrl());
            System.out.println("初始化WebDriver成功！");
            System.out.println("系统登陆地址：" + commonConfig.getLoginUrl());


            /**
             * 登陆
             */
            WebElement username = driver.findElement(By.id("username"));
            username.sendKeys(commonConfig.getLoginUserName());
            Assert.assertEquals(commonConfig.getLoginUserName(), "wangy12", "is not equal");
            WebElement password = driver.findElement(By.id("password"));
            password.sendKeys(commonConfig.getLoginPassWord());
            driver.manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);
            WebElement buttom = driver.findElement(By.className("login_button"));
            buttom.click();


            Object objProdefList = CacheUtils.get(StaticValue.ProdefConfigCacheName, StaticValue.InitProdefKeyName);
            if (objProdefList == null) {
                throw new Exception("没有找到方案下配置的流程信息，请检查文件");
            }


            List<Prodef> prodefList = (List<Prodef>) objProdefList;
            if (prodefList.size() == 0) {
                throw new Exception("没有找到方案下配置的流程信息，请检查文件");
            }


            for (Prodef prodef : prodefList) {
                //切换到首页
                driver.switchTo().frame(commonConfig.getFirstPageIframe());

                try {
                    System.out.println("开始流程自动化测试！");
                    System.out.println("流程内码：" + prodef.getId() + ",流程名称" + prodef.getName());
                    // 最多等30秒
                    WebDriverWait wait = new WebDriverWait(driver, 30);
                    wait.until(ExpectedConditions.visibilityOfAllElementsLocatedBy(By.id(prodef.getPackageID())));
                    WebElement secondPackage = driver.findElement(By.id(prodef.getPackageID()));

                    //实现滚动方式一
                    Actions action = new Actions(driver);
                    action.moveToElement(secondPackage);
                    //第二种种实现方式
//                    ((JavascriptExecutor) driver).executeScript("arguments[0].scrollIntoView(false);", secondPackage);
                    wait.until(ExpectedConditions.visibilityOf(secondPackage));
                    wait.until(ExpectedConditions.elementToBeClickable(secondPackage));
                    secondPackage.click();
                    Thread.sleep(5000);
                    WebElement prodefCLick = driver.findElement(By.xpath("//a[@pid='" + prodef.getId() + "']"));

                    wait.until(ExpectedConditions.visibilityOf(prodefCLick));
                    wait.until(ExpectedConditions.elementToBeClickable(prodefCLick));
                    prodefCLick.click();

                    driver.switchTo().defaultContent();
                    driver.manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);
                    Thread.sleep(2000); //等待窗口弹出来

                    String currentWindow = driver.getWindowHandle();

                    System.out.println("流程启动成功，主框架句柄：" + currentWindow);
                    ActdefAction(driver, currentWindow, prodef, commonConfig, mapAllSchema, mapColumnValue);


                } catch (Exception er) {
                    er.printStackTrace();
                }
            }

            System.exit(0);


        } catch (Exception er) {

            er.printStackTrace();
            System.out.println("试试关闭情况--249");
            if (driver != null) {
                //quit和close的区别，close关闭的更加彻底
                driver.close();
                service.stop();
            }

            System.exit(0);


        }

        System.exit(0);


    }


    private static void ActdefAction(WebDriver driver, String currentWindow, Prodef prodef, CommonConfig commonConfig,
                                    Map<String, StringBuilder> mapAllSchema, Map<String, String> mapColumnValue) throws Exception {

        try {
            TestNG testNG = new TestNG();
            Class[] classes = {ConfigSeleniumStart.class};
            List<String> suites = new ArrayList<String>();
            suites.add("D:\\work_space\\js_de\\debug\\Selenium\\TestNG\\testng.xml");//此处为xml的绝对路径
            testNG.setTestSuites(suites);
            System.out.println("testng已经就位");

//            testNG.setTestClasses(classes);
            testNG.setOutputDirectory("D:\\AutoTest_Reports");
//            testNG.setXmlPathInJar(".\testng.xml");
//            testNG.setTestJar("D:\\work_space\\js_de\\debug\\SeleniumConfig\\bin\\Debug\\SeleniumJAVA");
//            testNG.setXmlPathInJar("/");



            WebDriverWait wait2 = new WebDriverWait(driver, 50); // 最多等50秒

            Object objProdefList = CacheUtils.get(StaticValue.ProdefConfigCacheName, StaticValue.InitProdefKeyName);

            Date da = new Date();
            SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd HH");
            String ds = sdf.format(da).replace(":", "_");
            //包id
            String packid = prodef.getPackageID();
            System.out.println("包的id：" + packid);
            String schemaid = InitCommonParameter.schemaid;
            System.out.println("schemaid:" + schemaid);

            String schemaname = InitCommonParameter.schemaname;
            System.out.println("schemaname:" + schemaname);

            String prodefid = InitCommonParameter.prodefid;
            System.out.println("prodef:" + prodefid);
            String prodefname = InitCommonParameter.prodefname;
            System.out.println("prodef:" + prodefname);

            String packagename = InitCommonParameter.packagename;
            System.out.println("packname:" + packagename);

            String childprodefid = InitCommonParameter.childprodefid;
            System.out.println("cchild:" + childprodefid);
            String childprodefname = InitCommonParameter.childprodefname;
            System.out.println("childname:" + childprodefname);

            String schema = "(" + schemaname + ")" + schemaid;
            String child = "(" + childprodefname + ")" + childprodefid;
            String bao = "(" + packagename + ")" + packid;
            String lc = "(" + prodefname + ")" + prodefid;


            String path = "D:/SootScreen/" + ds + "/" + schema + "/" + child + "/" + bao + "/" + lc + "/";

            File f = new File(path);

            if (!f.exists()) {
                f.mkdirs();
            }


            WebDriver webNewWindow = wait2.until((ExpectedCondition<WebDriver>) d -> {
                try {
                    return ChangeDriver.change(driver, currentWindow);
                } catch (Exception er) {
                    return null;
                }

            });
            String url = webNewWindow.getCurrentUrl();
            Map<String, String> allRequestParam = StaticValue.getAllRequestParam(url);
            WebDriver driverFilePage = webNewWindow.switchTo().frame(commonConfig.getWorkFlowFrameIframe());
            String projectId = allRequestParam.get("businesskey".toUpperCase());

            //projectId  业务号
            String aid = allRequestParam.get("AID");
            System.out.println(aid);

            Actdef actdef = StaticValue.GetActdefByIdFromList(prodef.getActdefList(), aid);
            System.out.println("当前环节环节名称：" + actdef.getName() + ",环节内码" + actdef.getId());

            if (actdef == null) {
                throw new RuntimeException("找不到环节" + aid + "配置信息");
            }


            List<Iframe> iframeList = actdef.getIframeList();
            for (Iframe iframe : iframeList) {

                System.out.println("开始操作Ifame，Iframe名称：" + iframe.getName());

                //这里处理，框架的档案袋节点
                // 最多等10秒
                WebDriverWait wait = new WebDriverWait(driverFilePage, 50);
                wait.until(ExpectedConditions.visibilityOfAllElementsLocatedBy(By.xpath("//a[@title='" + iframe.getName() + "']")));
                List<WebElement> elementFileBages = driverFilePage.findElements(By.xpath("//a[@title='" + iframe.getName() + "']"));
                List<WebElement> elementFileBages1 = driverFilePage.findElements(By.xpath("//span[@class='button level1 switch center_close']"));
                if (elementFileBages1.size() != 0) {
                    for (WebElement element : elementFileBages1) {
                        System.out.println("element.getText：" + element.getText());
                        element.click();
                        System.out.println("element点击完成啦");
                    }
                }

                for (WebElement element : elementFileBages) {

                    element.click();
                    System.out.println("点击完成1");
                }


                List<WebElement> allElement = driverFilePage.findElements(By.tagName("iframe"));
                System.out.println("获取到所有的iframe了" + DateUtils.getDateTime());
                //切换到要操作的Iframe上去
                WebElement element = StaticValue.GetWebElementByUrlFromList(allElement, iframe.getUrl());
                System.out.println("ifame地址1是：" + iframe.getUrl() + DateUtils.getDateTime());
                String iframeWebElementId = element.getAttribute("id");
                System.out.println("获取到ID是：" + iframeWebElementId + DateUtils.getDateTime());
                WebDriver driveIframe = driverFilePage.switchTo().frame(iframeWebElementId);
                System.out.println("切换到指定的iframe了" + DateUtils.getDateTime());
                System.out.println("Iframe地址：" + iframe.getUrl());
                List<LocationElement> locationElementList = iframe.getLocationElementList();
                ((JavascriptExecutor) driveIframe).executeScript("window.ajax_loading = false;");
                ((JavascriptExecutor) driveIframe).executeScript("$(document).ajaxStart(function() {\n" +
                        "        window.ajax_loading = true;\n" +
                        "    });");
                ((JavascriptExecutor) driveIframe).executeScript(" $(document).ajaxStop(function() {\n" +
                        "        window.ajax_loading = false;\n" +
                        "    });");
                for (LocationElement locationElement : locationElementList) {
                    String locationType = locationElement.getLocationType();
                    String locationPath = locationElement.getLocationPath();
                    String operateType = locationElement.getOperateType();
                    String defaultValue = locationElement.getDefaultValue();
                    Boolean isRandom = locationElement.getRandom();
                    Integer waitSecond = locationElement.getWaitSecond();
                    String sqlSchemaId = locationElement.getSqlSchemaId();
                    System.out.println("当前iframe(" + iframe.getName() + ")操作元素：");
                    System.out.println("       定位方式：" + locationType);
                    System.out.println("       定位路径：" + locationPath);
                    System.out.println("       操作方式：" + operateType);
                    System.out.println("       默认值：" + defaultValue);
                    System.out.println("       是否随机数：" + isRandom);
                    System.out.println("       等待时间：" + waitSecond);
                    WebElement needLocationElement = null;
                    List<WebElement> needLocationElementList = null;
                    Actions action = new Actions(driveIframe);

                    switch (locationType) {
                        case "ID":
                            if (!operateType.equals("FR") && !operateType.equals("FR2")) {
                                needLocationElement = driveIframe.findElement(By.id(locationPath));
                                needLocationElementList = driveIframe.findElements(By.id(locationPath));
                            }
                            break;
                        case "NAME":
                            if (!operateType.equals("FR") && !operateType.equals("FR2")) {
                                needLocationElement = driveIframe.findElement(By.name(locationPath));
                                needLocationElementList = driveIframe.findElements(By.name(locationPath));
                            }
                            break;
                        case "XPATH":
                            if (locationPath.indexOf("@@@") > -1) {
                                String[] arrPaths = locationPath.split("@@@");
                                List<WebElement> elementList = driveIframe.findElements(By.xpath(arrPaths[0]));
                                for (WebElement tempElement : elementList) {
                                    if (tempElement.getAttribute("innerText").indexOf(arrPaths[1]) > -1) {
                                        needLocationElement = tempElement;
                                        System.out.println("找到" + arrPaths[1] + "元素");
                                    }
                                }

                                if (needLocationElement == null) {
                                    throw new Exception("找不到" + locationPath + "元素");
                                }
                            } else {
                                needLocationElement = driveIframe.findElement(By.xpath(locationPath));
                                needLocationElementList = driveIframe.findElements(By.xpath(locationPath));
                            }
                            break;
                    }

                    if (sqlSchemaId != null && sqlSchemaId != "") {
                        StringBuilder executeSql = mapAllSchema.get(sqlSchemaId);
                        if (executeSql != null) {
                            DataBase.ExecuteSql(executeSql.toString());
                            defaultValue = mapColumnValue.get(defaultValue); //重新处理默认值
                        }
                    }

                    System.out.println("开始执行操作");
                    switch (operateType) {
                        case "CIRCLESENDKEYS": //循环赋值
                            defaultValue = defaultValue.replace("{NOW}", DateUtils.getDate());
                            defaultValue = defaultValue.replace("{ZSGBH}", String.format("%09d", StaticValue.GetRandomNumber(8)));
                            for (WebElement webElement : needLocationElementList) {
                                action.moveToElement(webElement);
                                if (webElement.getTagName().equals("select")) {
                                    Select select = new Select(webElement);
                                    select.selectByValue(defaultValue);
                                } else {
                                    webElement.sendKeys(defaultValue + (isRandom ? StaticValue.GetRandomNumber() : ""));
                                }
                            }
                            break;
                        case "SENDKEYS":
                            defaultValue = defaultValue.replace("{NOW}", DateUtils.getDate());
                            defaultValue = defaultValue.replace("{ZSGBH}", String.format("%09d", StaticValue.GetRandomNumber(8)));
                            action.moveToElement(needLocationElement);
                            if (needLocationElement.getTagName().equals("select")) {
                                Select select = new Select(needLocationElement);
                                select.selectByValue(defaultValue);
                            } else {
                                needLocationElement.sendKeys(defaultValue + (isRandom ? StaticValue.GetRandomNumber() : ""));
                            }

                            break;
                        case "CLICK":
                            try {
                                WebDriverWait ww = new WebDriverWait(driverFilePage, 50);

                                if (locationPath.equalsIgnoreCase("saveDatum")) {
                                    ww.until(ExpectedConditions.elementToBeClickable(needLocationElement));
                                    needLocationElement.click();
                                    System.out.println("我已经点击完成了");
                                    ww.until(ExpectedConditions.visibilityOfAllElementsLocatedBy(By.xpath("//div[@class='toast toast-success']")));

                                } else if (locationPath.equalsIgnoreCase("TJSQR")) {
                                    ((JavascriptExecutor) driver).executeScript("window.scrollTo(document.body.scrollHeight,0)");
                                    needLocationElement.click();
                                } else if (locationPath.equalsIgnoreCase("//span[@class=' x-emb-submit']")) {
                                    needLocationElement.click();
                                    System.out.println("开始等待大保存完毕");
                                    new WebDriverWait(driver, 50).until(ExpectedConditions.presenceOfElementLocated(By.id("aaaccceasyicon_cn_32showideasyicon_cn_32fullid")));
                                    System.out.println("大保存完毕");

                                } else {
                                    ww.until(ExpectedConditions.visibilityOf(needLocationElement));
                                    ww.until(ExpectedConditions.elementToBeClickable(needLocationElement));
                                    needLocationElement.click();

                                }


                            } catch (Exception er) {
                                System.out.println("======exception reason=======" + er);
                                //图片名称加时间戳
                                String dateString = getDateFormat();
                                // getScreenshotAs()对当前窗口进行截图
                                File srcFile = ((TakesScreenshot) driverFilePage).getScreenshotAs(OutputType.FILE);
                                // 需要指定图片的保存路径及文件名
                                FileUtils.copyFile(srcFile, new File("./error_png" + dateString + ".png"));
                                er.printStackTrace();
                                throw er;

                            }


                            break;
                        case "IFRAME":
                            WebDriver driverIframeDY = driveIframe.switchTo().frame(locationPath);
                            List<ChildLocationElement> childLocationElementList = locationElement.getChildLocationElementList();

                            ((JavascriptExecutor) driverIframeDY).executeScript("window.ajax_loading = false;");
                            ((JavascriptExecutor) driverIframeDY).executeScript("$(document).ajaxStart(function() {\n" +
                                    "        window.ajax_loading = true;\n" +
                                    "    });");
                            ((JavascriptExecutor) driverIframeDY).executeScript(" $(document).ajaxStop(function() {\n" +
                                    "        window.ajax_loading = false;\n" +
                                    "    });");


                            for (ChildLocationElement childLocationElement : childLocationElementList) {
                                String childLocationType = childLocationElement.getLocationType();
                                String childLocationPath = childLocationElement.getLocationPath();
                                String childOperateType = childLocationElement.getOperateType();
                                String childDefaultValue = childLocationElement.getDefaultValue();
                                Boolean childIsRandom = childLocationElement.getRandom();
                                Integer childWaitSecond = childLocationElement.getWaitSecond();
                                String childSqlSchemaId = childLocationElement.getSqlSchemaId();

                                System.out.println("当前iframe(" + locationPath + ")操作元素：");
                                System.out.println("      定位方式：" + childLocationType);
                                System.out.println("      定位路径：" + childLocationPath);
                                System.out.println("      操作方式：" + childOperateType);
                                System.out.println("      默认值：" + childDefaultValue);
                                System.out.println("      是否随机数：" + childIsRandom);
                                System.out.println("      等待时间：" + childWaitSecond);


                                WebElement needChildLocationElement = null;
                                List<WebElement> needChildLocationElementList = null;
                                Actions action1 = new Actions(driverIframeDY);
                                switch (childLocationType) {
                                    case "ID":
                                        if (!childOperateType.equals("FR")) {
                                            needChildLocationElement = driverIframeDY.findElement(By.id(childLocationPath));
                                            needChildLocationElementList = driverIframeDY.findElements(By.id(childLocationPath));
                                        }
                                        break;
                                    case "NAME":
                                        if (!childOperateType.equals("FR")) {
                                            needChildLocationElement = driverIframeDY.findElement(By.name(childLocationPath));
                                            needChildLocationElementList = driverIframeDY.findElements(By.name(childLocationPath));
                                        }

                                        break;
                                    case "XPATH":
                                        if (childLocationPath.indexOf("@@@") > -1) {
                                            String[] arrPaths = childLocationPath.split("@@@");
                                            List<WebElement> elementList = driverIframeDY.findElements(By.xpath(arrPaths[0]));
                                            for (WebElement tempElement : elementList) {
                                                if (tempElement.getAttribute("innerText").indexOf(arrPaths[1]) > -1) {
                                                    needChildLocationElement = tempElement;
                                                }
                                            }
                                            if (needChildLocationElement == null) {
                                                throw new Exception("找不到" + childLocationPath + "元素");
                                            }
                                        } else {
                                            needChildLocationElement = driverIframeDY.findElement(By.xpath(childLocationPath));
                                            needChildLocationElementList = driverIframeDY.findElements(By.xpath(childLocationPath));

                                        }
                                        break;

                                }

                                if (childSqlSchemaId != null && childSqlSchemaId != "") {
                                    StringBuilder executeChildSql = mapAllSchema.get(childSqlSchemaId);
                                    if (executeChildSql != null) {

                                        DataBase.ExecuteSql(executeChildSql.toString());
                                        childDefaultValue = mapColumnValue.get(childDefaultValue); //重新处理默认值
                                    }
                                }
                                switch (childOperateType) {

                                    case "CIRCLESENDKEYS": //循环赋值
                                        childDefaultValue = childDefaultValue.replace("{NOW}", DateUtils.getDate());
                                        childDefaultValue = childDefaultValue.replace("{ZSGBH}", String.format("%09d", StaticValue.GetRandomNumber(8)));
                                        for (WebElement webElement : needChildLocationElementList) {
                                            action1.moveToElement(webElement);
                                            if (webElement.getTagName().equals("select")) {
                                                Select select = new Select(webElement);
                                                select.selectByValue(childDefaultValue);
                                            } else {
                                                webElement.sendKeys(childDefaultValue + (childIsRandom ? StaticValue.GetRandomNumber() : ""));
                                            }
                                        }
                                        break;
                                    case "SENDKEYS":
                                        action1.moveToElement(needChildLocationElement);

                                        if (needChildLocationElement.getTagName().equals("select")) {
                                            Select select = new Select(needChildLocationElement);
                                            select.selectByValue(childDefaultValue);
                                        } else if (childDefaultValue.contains("SELENIUM_PRO")) {
                                            String result = DataProviderSet_procedure.call(childDefaultValue);
                                            needChildLocationElement.sendKeys(result);

//                                        }else if(childDefaultValue.equalsIgnoreCase("xlsx")){
//                                            System.out.println("xlsx单元号："+xlsx_bdcdyh);
//                                            needChildLocationElement.sendKeys(xlsx_bdcdyh);
                                        } else {
                                            needChildLocationElement.sendKeys(childDefaultValue + (childIsRandom ? StaticValue.GetRandomNumber() : ""));
                                        }

                                        break;
                                    case "CLICK":
                                        action1.moveToElement(needChildLocationElement);

                                        WebDriverWait ziw = new WebDriverWait(driverIframeDY, 50);
                                        ziw.until(ExpectedConditions.visibilityOf(needChildLocationElement));

                                        System.out.println("元素可见了吧");
                                        ziw.until(ExpectedConditions.elementToBeClickable(needChildLocationElement));
                                        System.out.println("已经判断完成可点击了：" + ExpectedConditions.elementToBeClickable(needLocationElement));

                                        needChildLocationElement.click();
                                        System.out.println("已经完成点击事件了");


                                        break;
                                    case "QT": //执行js
                                        String id = needChildLocationElement.getAttribute("id");
                                        if (id == null || id.equals("")) {
                                            id = childDefaultValue;
                                        }
                                        String js = childDefaultValue.replace("{ID}", id);
                                        ((JavascriptExecutor) driver).executeScript(js);
                                        break;
                                    case "FR":
                                        Thread.sleep(5000);
                                        childDefaultValue = childDefaultValue.replace("{NOW}", DateUtils.getDate());
                                        FRValue.SetFRValue(driverIframeDY, childLocationPath, childDefaultValue + (isRandom ? StaticValue.GetRandomNumber() : ""));
                                        break;
                                    case "FRExport":
                                        //表单输出
                                        try {

                                            String outurl = driverFilePage.getCurrentUrl() + "&format=pdf";
                                            DownLoadPdf.downLoadFromUrl(outurl,
                                                    locationElement.getDefaultValue() + ".pdf", path);

                                        } catch (Exception e) {
                                            e.getStackTrace();
                                        }
                                        break;

                                    case "SHOOT":
//                                      谷歌截图--可见区域
                                        Object js1_result;
                                        String real_top, real_scroll_h;
                                        String js1 = "return document.body.scrollHeight.toString()+','+document.body.scrollTop.toString()";
                                        js1_result = ((JavascriptExecutor) driverIframeDY).executeScript(js1);
                                        real_scroll_h = js1_result.toString().split(",")[0];
                                        real_top = js1_result.toString().split(",")[1];
                                        System.out.println("real_scrol:" + real_scroll_h);
                                        System.out.println("real_top:" + real_top);
                                        if (Integer.valueOf(real_top) != 0) {
                                            ((JavascriptExecutor) driverIframeDY).executeScript("window.scrollTo(document.body.scrollHeight,0)");
                                        }
                                        Thread.sleep(5000);
                                        File scrFile = ((TakesScreenshot) driverIframeDY).getScreenshotAs(OutputType.FILE);
                                        FileUtils.copyFile(scrFile, new File(path + locationElement.getDefaultValue() + ".png"));
                                        Thread.sleep(1000);

                                        String setscroll;
                                        int height = 0;
                                        String path1;

                                        for (int i = 1; i < (Integer.valueOf(real_scroll_h) / 400) + 1; i++) {

                                            if (height > Integer.valueOf(real_scroll_h) || Integer.valueOf(real_scroll_h) < 750) {
//                                                System.out.println("这就是底部吗？");
                                                break;

                                            } else {

                                                Thread.sleep(5000);
                                                height = i * 450;
                                                setscroll = "document.body.scrollTop=" + height;
                                                JavascriptExecutor jse = (JavascriptExecutor) driverIframeDY;
                                                jse.executeScript("0," + setscroll);
                                                Thread.sleep(5000);
                                                File scrFile1 = ((TakesScreenshot) driverIframeDY).getScreenshotAs(OutputType.FILE);

                                                FileUtils.copyFile(scrFile1, new File(path + locationElement.getDefaultValue() + (i + 1) + ".png"));
                                                path1 = path + locationElement.getDefaultValue() + (i + 1) + ".png";
//                                                System.out.println("这不是底部啊");
                                            }
                                            System.out.println("i:" + i);
                                            System.out.println("height:" + height);
//                                            报告输出图片
//                                            Reporter.log("<img src=" + path1 + "  onclick='window.open(\"" + path1 + "\")' height='108' width='192'/>");
                                        }


                                        break;
                                    case "Assert":
                                        if (childDefaultValue.contains("select")) {
                                            String result = "";
                                            ResultSet rs = Assert_database.getResult(childDefaultValue);
                                            if (rs.next()) {
                                                result = rs.getString(1);
                                            }
                                            actual=needChildLocationElement.getText();
                                            except=result;
                                        } else {
                                            actual=needChildLocationElement.getText();
                                            except=childDefaultValue;

                                        }
                                        System.out.println("我要运行测试了");
                                        testNG.run();
                                        System.out.println("运行完成了");
                                        break;

                                    case "Clear":
                                        needChildLocationElement.clear();
                                        break;

                                }


                                if (childWaitSecond > 0) {
                                    waitForAjaxControls(childWaitSecond, driverIframeDY);
                               /* System.out.println(locationPath+","+childLocationPath+"等待："+childWaitSecond);
                                Thread.sleep(childWaitSecond);*/
                                }
                            }

                            //弹出申请人界面
                            webNewWindow.switchTo().defaultContent();
                            driverFilePage = webNewWindow.switchTo().frame(commonConfig.getWorkFlowFrameIframe());
                            driveIframe = driverFilePage.switchTo().frame(iframeWebElementId);
                            break;
                        case "QT": //执行js
                            String id = needLocationElement.getAttribute("id");
                            if (id == null || id.equals("")) {
                                id = defaultValue;
                            }
                            String js = defaultValue.replace("{ID}", id);
                            ((JavascriptExecutor) driver).executeScript(js);

                            break;
                        case "FR":
                            Thread.sleep(5000);
                            defaultValue = defaultValue.replace("{NOW}", DateUtils.getDate());
                            FRValue.SetFRValue(driveIframe, locationPath, defaultValue + (isRandom ? StaticValue.GetRandomNumber() : ""));
                            break;
                        case "FR2":
                            Thread.sleep(5000);
                            defaultValue = defaultValue.replace("{NOW}", DateUtils.getDate());
                            FRValue.SetFRValue2(driveIframe, locationPath, defaultValue + (isRandom ? StaticValue.GetRandomNumber() : ""));
                            break;

                        case "FRExport":
                            //表单输出
                            try {

                                String outurl = driverFilePage.getCurrentUrl() + "&format=pdf";
                                DownLoadPdf.downLoadFromUrl(outurl,
                                        locationElement.getDefaultValue() + ".pdf", path);

                            } catch (Exception e) {
                                // TODO: handle exception
                            }
                            break;

                        case "SHOOT":

//                            谷歌截图--可见区域
                            Object js1_result;
                            String real_top, real_scroll_h;
                            String js1 = "return document.body.scrollHeight.toString()+','+document.body.scrollTop.toString()";
                            js1_result = ((JavascriptExecutor) driverFilePage).executeScript(js1);
                            real_scroll_h = js1_result.toString().split(",")[0];
                            real_top = js1_result.toString().split(",")[1];
                            System.out.println("real_scrol:" + real_scroll_h);
                            System.out.println("real_top:" + real_top);
                            if (Integer.valueOf(real_top) != 0) {
                                ((JavascriptExecutor) driverFilePage).executeScript("window.scrollTo(document.body.scrollHeight,0)");
                            }
                            Thread.sleep(5000);
                            File scrFile = ((TakesScreenshot) driverFilePage).getScreenshotAs(OutputType.FILE);
                            FileUtils.copyFile(scrFile, new File(path + locationElement.getDefaultValue() + ".png"));
                            Thread.sleep(1000);

                            String setscroll;
                            int height = 0;


                            for (int i = 1; i < (Integer.valueOf(real_scroll_h) / 400) + 1; i++) {

                                if (height > Integer.valueOf(real_scroll_h) || Integer.valueOf(real_scroll_h) < 720) {

                                    break;

                                } else {
                                    Thread.sleep(5000);
                                    height = i * 450;
                                    setscroll = "window.scrollTo" + "(" + "0," + height + ")";
                                    JavascriptExecutor jse = (JavascriptExecutor) driver;
                                    jse.executeScript("0," + setscroll);
                                    Thread.sleep(5000);
                                    File scrFile1 = ((TakesScreenshot) driverFilePage).getScreenshotAs(OutputType.FILE);
                                    FileUtils.copyFile(scrFile1, new File(path + locationElement.getDefaultValue() + i + ".png"));

                                }
                                System.out.println("i:" + i);
                                System.out.println("height:" + height);
                            }

                            break;
                        case "Assert":
                            System.out.println("断言处理");
                            if (defaultValue.contains("select")) {
                                String result = "";
                                ResultSet rs = null;

                                if (defaultValue.contains("{YWH}")) {
                                    String sqlword = defaultValue.replace("{YWH}", projectId);
                                    rs = Assert_database.getResult(sqlword);
                                    if (rs.next()) {
                                        result = rs.getString(1);
                                    }
                                    actual=needLocationElement.getText();
                                    except=result;

                                }


//                                else if(defaultValue.contains("{BDCDYH}")){
//                                    String sqlword = defaultValue.replace("{BDCDYH}", "");
//                                    //暂时不做，因为涉及比较多
//
//                                }else {

//                                    rs = Assert_database.getResult(defaultValue);
//
//                                }

                            } else {
                                actual=needLocationElement.getText();
                                except=defaultValue;

                            }
                            System.out.println("我要运行测试了-out");
                            testNG.run();
                            System.out.println("运行完成了-out");
                            break;
                        case "Clear":
                            needLocationElement.clear();
                            break;


                    }

                    System.out.println("等待时间：" + waitSecond);
//                    if (waitSecond > 0) {
//                        waitForAjaxControls(waitSecond, driveIframe);
//                               /* System.out.println(locationPath+","+childLocationPath+"等待："+childWaitSecond);
//                                Thread.sleep(childWaitSecond);*/
//                    }

                }


                Thread.sleep(1000);
                //处理受理申请信息
                webNewWindow.switchTo().defaultContent();
                driverFilePage = webNewWindow.switchTo().frame(commonConfig.getWorkFlowFrameIframe());

            }


            //移交页面
            webNewWindow.switchTo().defaultContent();

            //大保存成功了以后，才进行移交

            TrasferPro(webNewWindow, commonConfig);


            driver.switchTo().window(currentWindow);

            Thread.sleep(5000);

            boolean isHaveNext = SelectPro(driver, commonConfig, projectId);

            if (isHaveNext) {
                driver.switchTo().defaultContent();
                //等待窗口弹出来
                Thread.sleep(2000);
                ActdefAction(driver, currentWindow, prodef, commonConfig, mapAllSchema, mapColumnValue);
            }
        } catch (Exception er) {
            System.out.println("======exception reason=======" + er);
            //图片名称加时间戳
            Reporter.log(er.getStackTrace().toString());
            String dateString = getDateFormat();
            // getScreenshotAs()对当前窗口进行截图
            File srcFile = ((TakesScreenshot) driver).getScreenshotAs(OutputType.FILE);
            // 需要指定图片的保存路径及文件名
            FileUtils.copyFile(srcFile, new File("./error_png" + dateString + ".png"));
            er.printStackTrace();
            throw er;

        } finally {
//            driver.close();
//            service.stop();
        }
    }



    public static void waitForAjaxControls(int timeoutInSeconds, WebDriver driver) {
        System.out.println(timeoutInSeconds);
        new WebDriverWait(driver, timeoutInSeconds / 1000).until(new ExpectedCondition<Boolean>() {
            @Override
            public Boolean apply(WebDriver driver) {
//                System.out.println(DateUtils.getDate("yyyy-MM-dd HH:mm:ss"));
                JavascriptExecutor js = (JavascriptExecutor) driver;
                Boolean test = (Boolean) js.executeScript("return window.ajax_loading");
                if (test == null) {
                    return true;
                } else if (test.equals("true")) {
                    System.out.println("是否存在Ajax请求：" + !test + ",IRL地址" + driver.getCurrentUrl());
                }

                return !test;
            }
        });
//        System.out.println(DateUtils.getDate("yyyy-MM-dd HH:mm:ss"));
    }

    /**
     * 选择流程
     *
     * @param driver
     * @param commonConfig
     * @param projectId
     * @return
     * @throws Exception
     */
    private static Boolean SelectPro(WebDriver driver, CommonConfig commonConfig, String projectId) throws Exception {
        try {

            WebDriverWait wait = new WebDriverWait(driver, 50);
            WebElement elementGZZX = driver.findElement(By.linkText("工作中心"));
            wait.until(ExpectedConditions.visibilityOf(elementGZZX));
            wait.until(ExpectedConditions.elementToBeClickable(elementGZZX));
            elementGZZX.click();
            System.out.println("点击工作中心");

            Thread.sleep(5000);
            WebElement elementPopMenu = driver.findElement(By.xpath("//div[@class='PopupMenu']"));
            List<WebElement> allFuncitem = driver.findElements(By.xpath("//span[@class='menu_level_0']"));
            for (WebElement elementFunction : allFuncitem) {
                if (elementFunction.getAttribute("innerText").equals("新收办件")) {
                    System.out.println("判断如果是新收办件，就开始了点击事件");

                    elementFunction.click();
                    break;
                }

            }


            WebDriver driverXJBJ = driver.switchTo().frame(commonConfig.getCreateProIframe());
            WebDriverWait ww = new WebDriverWait(driverXJBJ, 50);
            Thread.sleep(2000);
            boolean isHaveNext = false;
            ww.until(ExpectedConditions.visibilityOfAllElementsLocatedBy(By.id("txtInput")));
//            System.out.println("selectPro方法内的项目编号：" + projectId);
            driverXJBJ.findElement(By.id("txtInput")).sendKeys(projectId); //输入办件号

            ww.until(ExpectedConditions.elementToBeClickable(By.id("searchButton")));//查询

            driverXJBJ.findElement(By.id("searchButton")).click();//查询

            Thread.sleep(5000);
            List<WebElement> elementBJ = driverXJBJ.findElements(By.xpath("//div[@class='jqx-grid-cell-left-align']"));

            for (WebElement elementNewPJ : elementBJ) {
                if (elementNewPJ.getAttribute("innerText").equals(projectId)) {
//                    System.out.println("如果有结果，那么就执行这里了，并且把isHaveNext改为True");
                    isHaveNext = true;
                    ww.until(ExpectedConditions.visibilityOf(elementNewPJ));
                    ww.until(ExpectedConditions.elementToBeClickable(elementNewPJ));
                    elementNewPJ.click();

                    break;
                }


            }

            return isHaveNext;
        } catch (Exception er) {
            System.out.println("======exception reason=======" + er);
            //图片名称加时间戳
            String dateString = getDateFormat();
            // getScreenshotAs()对当前窗口进行截图
            File srcFile = ((TakesScreenshot) driver).getScreenshotAs(OutputType.FILE);
            // 需要指定图片的保存路径及文件名
            FileUtils.copyFile(srcFile, new File("./error_png" + dateString + ".png"));
            er.printStackTrace();
            throw er;

        } finally {
//            driver.close();
//            service.stop();
        }

    }


    private static void TrasferPro(WebDriver driver, CommonConfig commonConfig) throws Exception {
        try {
            WebElement elementYJ = driver.findElement(By.id("btnComplete"));//点击移交
            System.out.println("点击移交");

            elementYJ.click();
            System.out.println("点击完成");

            WebDriver webTransfer = driver.switchTo().frame("ifTransmit");//移交页面，选择人员
            WebDriverWait newwait2 = new WebDriverWait(webTransfer, 50);
            List<WebElement> elementTransferAs = webTransfer.findElements(By.xpath("//div[@class='tabTitle']"));

            if (elementTransferAs != null && elementTransferAs.size() > 0) {

                for (WebElement elementA : elementTransferAs) {
                    if (elementA.getAttribute("innerText").equals("初审")) {
//                        System.out.println("这里是为了区别开那个批量审批的，应该是");
                        newwait2.until(ExpectedConditions.elementToBeClickable(elementA));
                        elementA.click();


                    }
                }
                //最后一个环节的时候不需要选择人员
                //TODO 2019/02/15增加一个参数作为移交人员的选择;后期采用对接运维接口，用户可以选择的方式
                try {
                    WebElement elementYJRY = webTransfer.findElement(By.linkText(commonConfig.getYJName()));

                    elementYJRY.click();


                } catch (NoSuchElementException er) {
                    er.getStackTrace();
                }

            }

            //移交
            List<WebElement> elementYJSave = webTransfer.findElements(By.xpath("//input[@class='blue_btn']"));
            for (WebElement element : elementYJSave) {
                if (element.getAttribute("value").indexOf("转出") > -1 || element.getAttribute("value").indexOf("确定") > -1) {

                    element.click();
                }
            }
        } catch (Exception er) {
            System.out.println("======exception reason=======" + er);
            //图片名称加时间戳
            String dateString = getDateFormat();
            // getScreenshotAs()对当前窗口进行截图
            File srcFile = ((TakesScreenshot) driver).getScreenshotAs(OutputType.FILE);
            // 需要指定图片的保存路径及文件名
            FileUtils.copyFile(srcFile, new File("./error_png" + dateString + ".png"));
            er.printStackTrace();
            throw er;

        } finally {
//            driver.close();
//            service.stop();
        }
    }

    public void AsserFailStop(){
        Assert.assertEquals(actual,except);
        Reporter.log(Assertion.errors.iterator().next().toString());
    }

   @Test
    public void AssertReult(){
        Assertion.verifyEquals(actual, except);
        Reporter.log(Assertion.errors.iterator().next().getMessage());
    }
    @AfterTest
    public void closeDB(){
        Assert_database.getClose();
    }

}
