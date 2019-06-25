package configSelenium;

import Test.Assert.Assert_database;
import Test.DataProviderSet_Assert;
import Test.NoAssert;
import Test.Report.DoSchemaReportUtil;
import Test.Report.EmailInformation;
import Test.Report.ZTestReport;
import Test.SendEmail;
import Test.emailMessage;
import WinForm.showReports.*;
import configSelenium.Entity.CommonConfig;
import configSelenium.Entity.ProInfo.Actdef;
import configSelenium.Entity.ProInfo.Prodef;
import configSelenium.Entity.SeleniumTest.ChildLocationElement;
import configSelenium.Entity.SeleniumTest.Iframe;
import configSelenium.Entity.SeleniumTest.LocationElement;
import configSelenium.Entity.SeleniumTest.SeleniumSchema;
import dao.DataProviderSet_procedure;
import org.openqa.selenium.*;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeDriverService;
import org.openqa.selenium.chrome.ChromeOptions;
import org.openqa.selenium.interactions.Actions;
import org.openqa.selenium.support.ui.ExpectedCondition;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.Select;
import org.openqa.selenium.support.ui.WebDriverWait;
import org.testng.Reporter;
import org.testng.TestNG;
import org.testng.annotations.Listeners;
import selenium.common.ChangeDriver;
import util.*;

import java.awt.*;
import java.awt.event.KeyEvent;
import java.io.*;
import java.sql.ResultSet;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Map;
import java.util.concurrent.TimeUnit;

import static Test.Report.Copy_ReportFile.getCopyFile;
import static Test.emailMessage.*;
import static WinForm.showReports.ReportXML.saveXml;
import static util.RandomforName.getName;


/**
 * Created by Administrator on 2016/12/21.
 */
@Listeners(value = {org.uncommons.reportng.HTMLReporter.class, org.uncommons.reportng.JUnitXMLReporter.class, emailMessage.class})
public class ConfigSeleniumStart {

    public static ChromeDriverService service;
    //创建集合：实际结果、预期结果、描述、元素截图
    public static List<String> actuallist=null;
    public static List<String> exceptlist=null ;
    public static List<String> descriptionlist=null ;
    public static List<DoSchemaReportUtil> allSchemaResult=new ArrayList<DoSchemaReportUtil>();

    public static List<ReportsSchema> reportsSchemaList=new ArrayList<>();
    public static List<FRreportUtils> frchildList=null;
    public static List<ScreenShootUtils> shootChildList=null;

    public static String cprodefid=null;
    public static String cprodefname=null;
    public static String cprodefpackagename=null;
    public static String cprodefpackageid=null;
    public static String cprodefChildid=null;
    public static String cprodefChildname=null;

    public static Boolean isSuccess;
    public static String  reportModual=null;




    public static boolean isHaveNext;
    public static String currentWindow;
    public static String errorMessage = "error";
    public static String fanganname = "";
    public static String projectywh;
    public static String acdefName;



    public static String htmlname=null;


    public static Date da = new Date();
    public static SimpleDateFormat day = new SimpleDateFormat("yyyy-MM-dd ");
    public static SimpleDateFormat min = new SimpleDateFormat("yyyy-MM-dd HH:mm");
    public static SimpleDateFormat ss = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");



    public static void main(String[] args) throws Exception {

        if (!(args.length > 0 && args[0].equals("C#"))) {
            File file = new File("");
            StaticValue.ApplicationPath = file.getAbsolutePath();
        }

        WebDriver driver = null;
        String fangan = null;

        try {
            System.out.println("开始准备数据");

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
//            System.setProperty("webdriver.chrome.driver", "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chromedriver.exe");
            CommonConfig commonConfig = (CommonConfig) CacheUtils.get(StaticValue.CommonConfigCacheName, StaticValue.InitParameterKeyName);
            Map<String, StringBuilder> mapAllSchema = (Map<String, StringBuilder>) CacheUtils.get(StaticValue.SqlConfigCacheName, StaticValue.InitSqlConfigAllSqlKeyName);
            Map<String, String> mapColumnValue = (Map<String, String>) CacheUtils.get(StaticValue.SqlConfigCacheName, StaticValue.InitSqlCondfigColumnValue);
            service = new ChromeDriverService.Builder().usingDriverExecutable(
                    new File(commonConfig.getChromeDriverUrl())).usingAnyFreePort().build();

            System.setProperty("webdriver.chrome.driver", commonConfig.getChromeDriverUrl());
            service.start();

            System.out.println("初始化ChromeDriver成功！");

            ChromeOptions options = new ChromeOptions();
            options.addArguments("disable-extensions=Chrome Automation Extension"); //采用默认的谷歌配置参数
            driver = new ChromeDriver(options);

            driver.manage().window().maximize();
            driver.get(commonConfig.getLoginUrl());

            System.out.println("初始化WebDriver成功！");

            /**
             * 登陆
             */
            WebElement username = driver.findElement(By.id("username"));
            username.sendKeys(commonConfig.getLoginUserName());
            WebElement password = driver.findElement(By.id("password"));
            password.sendKeys(commonConfig.getLoginPassWord());
            driver.manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);
            WebElement buttom = driver.findElement(By.className("login_button"));
            buttom.click();

            Object objProdefList = CacheUtils.get(StaticValue.ProdefConfigCacheName, StaticValue.InitProdefKeyName);
            Object objSchemaList = CacheUtils.get(StaticValue.SchemaCacheName, StaticValue.InitSchemaKeyName);
            if (objProdefList == null) {
                throw new Exception("没有找到方案下配置的流程信息，请检查文件");
            }


            List<Prodef> prodefList = (List<Prodef>) objProdefList;
            List<SeleniumSchema> seleniumSchemaList =( List<SeleniumSchema>) objSchemaList;
            if (prodefList.size() == 0) {
                throw new Exception("没有找到方案下配置的流程信息，请检查文件");
            }

            int j=0;

            List<List<String>> loglist=new ArrayList<List<String>>();
            EmailInformation emailInformation=new EmailInformation();
            emailInformation.setIpAddress(commonConfig.getLoginUrl());
            emailInformation.setName(commonConfig.getLoginUserName());
            emailInformation.setPsd(commonConfig.getLoginPassWord());
            emailInformation.setCount(prodefList.size());
            int pass = 0,fail=0;
            String allywh="";

            for (Prodef prodef : prodefList) {

                shootChildList=new ArrayList<>();
                frchildList=new ArrayList<>();
                actuallist = new ArrayList<>();
                exceptlist = new ArrayList<>();
                descriptionlist = new ArrayList<>();
                isSuccess=false;


                if(j<seleniumSchemaList.size()){
                    cprodefid = seleniumSchemaList.get(j).getProdefId();
                    cprodefname = seleniumSchemaList.get(j).getProdefName();
                    cprodefChildid = seleniumSchemaList.get(j).getChildProdefId();
                    cprodefChildname = seleniumSchemaList.get(j).getChildProdefName();
                    cprodefpackagename = seleniumSchemaList.get(j).getPackageName();
                    cprodefpackageid=seleniumSchemaList.get(j).getPackageId();

                }
                frchildList.clear();

                try {
                    driver.switchTo().frame(commonConfig.getFirstPageIframe());
                    System.out.println("开始流程自动化测试！");
                    System.out.println("当前执行方案-流程："+seleniumSchemaList.get(j).getChildProdefName()+"-"+prodef.getName());
                    // 最多等30秒
                    WebDriverWait wait = new WebDriverWait(driver, 30);
                    wait.until(ExpectedConditions.visibilityOfAllElementsLocatedBy(By.id(prodef.getPackageID())));
                    WebElement secondPackage = driver.findElement(By.id(prodef.getPackageID()));

                    Actions action = new Actions(driver);
                    action.moveToElement(secondPackage);

                    wait.until(ExpectedConditions.visibilityOf(secondPackage));
                    wait.until(ExpectedConditions.elementToBeClickable(secondPackage));
                    secondPackage.click();

                    WebElement prodefCLick = driver.findElement(By.xpath("//a[@pid='" + prodef.getId() + "']"));

                    wait.until(ExpectedConditions.visibilityOf(prodefCLick));
                    wait.until(ExpectedConditions.elementToBeClickable(prodefCLick));
                    prodefCLick.click();

                    driver.switchTo().defaultContent();
                    driver.manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);
                    Thread.sleep(2000); //等待窗口弹出来
                    currentWindow = driver.getWindowHandle();
                    System.out.println("流程启动成功!");
//                    System.out.println("主框架句柄：" + currentWindow);
                    ActdefAction(driver, currentWindow, prodef, commonConfig, mapAllSchema, mapColumnValue);


                    driver.navigate().refresh();

                } catch (Exception er) {
                    er.printStackTrace();
                    System.out.println("流程执行存在报错，强行退出");
                    Reporter.log("执行报错信息：" + er.getMessage());
                    Reporter.log("强行退出");
//                    continue;
                } finally {

                    htmlname=seleniumSchemaList.get(j).getChildProdefName();
                    fangan=seleniumSchemaList.get(j).getName() + "-" + seleniumSchemaList.get(j).getPackageName() + "-" + seleniumSchemaList.get(j).getProdefName()
                            +"-"+seleniumSchemaList.get(j).getChildProdefName();
                    reportModual=seleniumSchemaList.get(j).getChildProdefName()+"-"+seleniumSchemaList.get(j).getPackageName() + "-" + seleniumSchemaList.get(j).getProdefName();
                    Reporter.log("业务号："+projectywh);
                    if(isSuccess){
                        Reporter.log("该流程已正常走完!");
                        System.out.println("该流程已正常走完!");
                        pass=pass+1;
                    }else{
                        Reporter.log("该流程未完成，请留意!");
                        System.out.println("该流程未完成，请留意!");
                        fail=fail+1;
                        allywh=allywh+"\t\n"+projectywh;

                    }
                    if(!actuallist.isEmpty()){
                        System.out.println("开始比对：");
                        dotestng(fangan);
                        getCopyFile(fangan);
                    }else {
                        if(fangan!=null){
                            noAssert(fangan);
                            getCopyFile(fangan);
                            System.out.println("未设置任何检查点，无信息比对，仅保留日志显示！");
                        }else {
                            noAssert("系统异常，未获取到方案名！");
                        }
                    }
                    DoSchemaReportUtil rchild=new DoSchemaReportUtil();
                    rchild.setProdefName(seleniumSchemaList.get(j).getPackageName() + "-"+seleniumSchemaList.get(j).getProdefName());
                    rchild.setSchemaName(seleniumSchemaList.get(j).getChildProdefName());
                    rchild.setTimeOut(passed+"-"+failed+"-"+skiped);
                    rchild.setYwh(projectywh);
                    rchild.setFinish(isSuccess);
                    List<String> log=new ArrayList<String>();
                    log.addAll(logs);
                    loglist.add(log);
                    rchild.setLog(loglist.get(j));
                    allSchemaResult.add(rchild);
                    if(projectywh!=null) {
                        System.out.println("业务号：" + projectywh);
                    }
                    //xml文件写入
                    CreatXML c=new CreatXML();
                    c.getReportMessage(fangan);
                    ZTestReport.output(allSchemaResult,seleniumSchemaList.get(0).getName());
                    j++;

                    Reporter.clear();

                }



            }
            emailInformation.setIsPass(pass);
            emailInformation.setIsFail(fail);
            emailInformation.setFailYwh(allywh);
            saveXml();

            if(commonConfig.getSendEmail()){
                System.out.println("准备发送邮件");
                SendEmail.sendEmail(commonConfig.getReceiveEmailAdd(),seleniumSchemaList.get(0).getName(),emailInformation);
            }else {
                System.out.println("未设置邮件发送");
            }



        } catch (Exception er) {

            er.printStackTrace();
            System.exit(0);


        }finally {


            if (driver!= null) {
                Reporter.log("已关闭相关服务进程");
                driver.quit();
                service.stop();

            }

        }

        System.exit(0);


    }




    private static void ActdefAction(WebDriver driver, String currentWindow, Prodef prodef, CommonConfig commonConfig,
                                     Map<String, StringBuilder> mapAllSchema, Map<String, String> mapColumnValue) throws Exception {

        try {
            

            acdefName=null;
            WebDriverWait wait2 = new WebDriverWait(driver, 120);

            Object objProdefList = CacheUtils.get(StaticValue.ProdefConfigCacheName, StaticValue.InitProdefKeyName);

            Date da = new Date();
            SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
            String ds = sdf.format(da).replace(":", "_");
            //包id

            String prodefid = InitCommonParameter.prodefid;



            fanganname = InitCommonParameter.schemaname;
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

            projectywh=projectId;
            //TODO为了获取lcbm
            String plcdm=allRequestParam.get("LCBM");
//            WebElement prodefIframe=driverFilePage.findElement(By.xpath("//iframe[contains(id,'TAB_IF')]"));
//            String url1=prodefIframe.getAttribute("src1");
//            Map<String, String> allRequestParam1 = StaticValue.getAllRequestParam(driverFilePage);
//            System.out.println("url:"+url+"\nurl1:"+url1);
//
//            System.out.println("查看一下流程代码："+plcdm);


            //projectId  业务号
            String aid = allRequestParam.get("AID");
            System.out.println(aid);

            Actdef actdef = StaticValue.GetActdefByIdFromList(prodef.getActdefList(), aid);
            acdefName=actdef.getName();
            System.out.println("当前环节环节名称：" + actdef.getName() + ",环节内码" + actdef.getId());

            if (actdef == null) {
                throw new RuntimeException("找不到环节" + aid + "配置信息");
            }




            List<Iframe> iframeList = actdef.getIframeList();
            for (Iframe iframe : iframeList) {


                System.out.println("开始操作Ifame，Iframe名称：" + iframe.getName());
                WebDriverWait wait = new WebDriverWait(driverFilePage, 30);


                //这里处理，框架的档案袋节点
                // 最多等30秒
                wait.until(ExpectedConditions.visibilityOfAllElementsLocatedBy(By.xpath("//a[@title='" + iframe.getName() + "']")));
                List<WebElement> elementFileBages = driverFilePage.findElements(By.xpath("//a[@title='" + iframe.getName() + "']"));
                List<WebElement> elementFileBages1 = driverFilePage.findElements(By.xpath("//span[@class='button level1 switch center_close']"));
                List<WebElement> elementFileBages2 = driverFilePage.findElements(By.xpath("//span[@class='button level1 switch bottom_close']"));
                //展开节点
                if (elementFileBages1.size() != 0) {
                    for (WebElement element : elementFileBages1) {
                        wait.until(ExpectedConditions.visibilityOf(element));
                        wait.until(ExpectedConditions.elementToBeClickable(element));
                        element.click();
                    }
                }
                if (elementFileBages2.size() != 0) {
                    for (WebElement element1 : elementFileBages2) {
                        wait.until(ExpectedConditions.visibilityOf(element1));
                        wait.until(ExpectedConditions.elementToBeClickable(element1));
                        element1.click();
                    }
                }

                for (WebElement element : elementFileBages) {
                    wait.until(ExpectedConditions.visibilityOf(element));
                    wait.until(ExpectedConditions.elementToBeClickable(element));
                    element.click();

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
                    String introduce = locationElement.getIntroduce();
                    String operateType = locationElement.getOperateType();
                    String defaultValue = locationElement.getDefaultValue();
                    Boolean isRandom = locationElement.getRandom();
                    Boolean isNameRandom = locationElement.getNameRandom();
                    Integer waitSecond = locationElement.getWaitSecond();
                    String sqlSchemaId = locationElement.getSqlSchemaId();
                    System.out.println("当前iframe(" + iframe.getName() + ")操作元素：");
                    System.out.println("       定位方式：" + locationType);
                    System.out.println("       定位路径：" + locationPath);
                    System.out.println("       操作方式：" + operateType);
                    System.out.println("       操作默认值：" + defaultValue);
                    System.out.println("       是否随机数：" + isRandom);
                    System.out.println("       是否Name随机数：" +isNameRandom );
                    System.out.println("       等待时间：" + waitSecond);
                    WebElement needLocationElement = null;
                    List<WebElement> needLocationElementList = null;
                    Actions action = new Actions(driveIframe);
                    //帆软表单输出路径
                    String filename = locationElement.getDefaultValue();

                    WebDriverWait waitlocation=new WebDriverWait(driveIframe,120);
                    switch (locationType) {
                        case "ID":
                            if (!operateType.equals("FR") && !operateType.equals("FR2")) {
                                waitlocation.until(ExpectedConditions.visibilityOfElementLocated(By.id(locationPath)));
                                waitlocation.until(ExpectedConditions.visibilityOfAllElementsLocatedBy(By.id(locationPath)));
                                needLocationElement = driveIframe.findElement(By.id(locationPath));
                                needLocationElementList = driveIframe.findElements(By.id(locationPath));
                            }
                            break;
                        case "NAME":
                            if (!operateType.equals("FR") && !operateType.equals("FR2")) {
                                waitlocation.until(ExpectedConditions.visibilityOfElementLocated(By.id(locationPath)));
                                waitlocation.until(ExpectedConditions.visibilityOfAllElementsLocatedBy(By.name(locationPath)));
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
                            Thread.sleep(waitSecond*1000);
                            defaultValue = defaultValue.replace("{NOW}", DateUtils.getDate());
                            defaultValue = defaultValue.replace("{ZSGBH}", String.format("%09d", StaticValue.GetRandomNumber(8)));
                            for (WebElement webElement : needLocationElementList) {

                                if (webElement.getTagName().equals("select")) {
                                    Select select = new Select(webElement);
                                    select.selectByValue(defaultValue);
                                } else {
                                    defaultValue=isNameRandom?getName(Integer.valueOf(defaultValue)):defaultValue;
                                    webElement.sendKeys(defaultValue + (isRandom ? StaticValue.GetRandomNumber() : ""));
                                }
                            }
                            break;
                        case "SENDKEYS":
                            Actions action3 = new Actions(driveIframe);
                            action3.moveToElement(needLocationElement);
                            Thread.sleep(waitSecond*1000);
                            defaultValue = defaultValue.replace("{NOW}", DateUtils.getDate());
                            defaultValue = defaultValue.replace("{ZSGBH}", String.format("%09d", StaticValue.GetRandomNumber(8)));
                            if (needLocationElement.getTagName().equals("select")) {

                                if(defaultValue.contains("@@@{BSM}")){


                                    String jgzhi=defaultValue.substring(0,defaultValue.indexOf("_"));
                                    String qlbm=defaultValue.substring(2,defaultValue.indexOf("@@@"));
                                    String resultbsm = "";
                                    String resultqxdm = "";
                                    int rownum=Integer.valueOf(jgzhi);
                                    String cxbsm=" select bsm from (select t.*,rownum as rn from "+qlbm+" t  where ywh="+"'"+projectId+"'  order by bsm) where rn="+rownum;
                                    String cxqxdm=" select qxdm from(select t.*,rownum as rn from "+qlbm+" t  where ywh="+"'"+projectId+"' order by bsm) where rn="+rownum;
                                    ResultSet rs = Assert_database.getResult(cxbsm);
                                    ResultSet rs1 = Assert_database.getResult(cxqxdm);

                                    if (rs.next()) {

                                        resultbsm = rs.getString(1);

                                    } else {
                                        resultbsm = "null";

                                    }

                                    if (rs1.next()) {

                                        resultqxdm=rs1.getString(1);
                                    } else {

                                        resultqxdm = "null";

                                    }

                                    Select select = new Select(needLocationElement);
                                    select.selectByValue(qlbm+"@@@"+resultbsm+"@@@"+resultqxdm);
                                }else {
                                    Select select = new Select(needLocationElement);
                                    select.selectByValue(defaultValue);
                                }
                            }else if(defaultValue.contains("@@@{BSM}")){


                                    String jgzhi=defaultValue.substring(0,defaultValue.indexOf("_"));
                                    String qlbm=defaultValue.substring(2,defaultValue.indexOf("@@@"));
                                    String resultbsm = "";
                                    String resultqxdm = "";
                                    int rownum=Integer.valueOf(jgzhi);
                                    String cxbsm=" select bsm from (select t.*,rownum as rn from "+qlbm+" t  where ywh="+"'"+projectId+"'  order by bsm) where rn="+rownum;
                                    String cxqxdm=" select qxdm from(select t.*,rownum as rn from "+qlbm+" t  where ywh="+"'"+projectId+"' order by bsm) where rn="+rownum;
                                    ResultSet rs = Assert_database.getResult(cxbsm);
                                    ResultSet rs1 = Assert_database.getResult(cxqxdm);

                                    if (rs.next()) {

                                        resultbsm = rs.getString(1);

                                    } else {
                                        resultbsm = "null";

                                    }

                                    if (rs1.next()) {

                                        resultqxdm=rs1.getString(1);
                                    } else {

                                        resultqxdm = "null";

                                    }


                                    needLocationElement.sendKeys(qlbm+"@@@"+resultbsm+"@@@"+resultqxdm);
                                }else {

                                        defaultValue=isNameRandom?getName(Integer.valueOf(defaultValue)):defaultValue;
                                        needLocationElement.sendKeys(defaultValue + (isRandom ? StaticValue.GetRandomNumber() : ""));


                            }


                            break;
                        case "CLICK":
                            Thread.sleep(waitSecond*1000);
                            try {
                                Actions action2 = new Actions(driveIframe);
                                WebDriverWait ww = new WebDriverWait(driveIframe, 180);
//                                WaitTime.getElementclick(driveIframe, 30, needLocationElement);
//                                WaitTime.getElementVisi(driveIframe, 30, needLocationElement);
                                action2.moveToElement(needLocationElement);
                                ww.until(ExpectedConditions.elementToBeClickable(needLocationElement));

                                if (locationPath.equalsIgnoreCase("saveDatum")) {
                                    ww.until(ExpectedConditions.elementToBeClickable(needLocationElement));
                                    needLocationElement.click();
                                    ww.until(ExpectedConditions.visibilityOfAllElementsLocatedBy(By.xpath("//div[@class='toast toast-success']")));

                                } else if (locationPath.equalsIgnoreCase("TJSQR")) {
                                    ((JavascriptExecutor) driver).executeScript("window.scrollTo(document.body.scrollHeight,0)");
                                    ww.until(ExpectedConditions.visibilityOf(needLocationElement));
                                    ww.until(ExpectedConditions.elementToBeClickable(needLocationElement));
                                    needLocationElement.click();
                                } else if (locationPath.equalsIgnoreCase("//span[@class=' x-emb-submit']")) {
                                    ww.until(ExpectedConditions.elementToBeClickable(needLocationElement));
                                    ww.until(ExpectedConditions.visibilityOf(needLocationElement));
                                    needLocationElement.click();
                                    new WebDriverWait(driver, 30).until(ExpectedConditions.presenceOfElementLocated(By.id("aaaccceasyicon_cn_32showideasyicon_cn_32fullid")));
                                    System.out.println("大保存完毕");

                                }else if(locationPath.equalsIgnoreCase("CXBDC")){
                                    ww.until(ExpectedConditions.elementToBeClickable(needLocationElement));
                                    ww.until(ExpectedConditions.visibilityOf(needLocationElement));
                                    ((JavascriptExecutor) driveIframe).executeScript("arguments[0].click();", needLocationElement);
                                    System.out.println("js点击查询单元");

                                }
//                                TODO 登簿提示框捕捉
//                                else if(locationPath.equalsIgnoreCase("//button[@type='button']@@@确认登簿")){
//                                    ww.until(ExpectedConditions.visibilityOf(needLocationElement));
//                                    ww.until(ExpectedConditions.elementToBeClickable(needLocationElement));
//                                    new WebDriverWait(driver, 30).until(ExpectedConditions.presenceOfElementLocated(By.xpath("//*[@id=\"easyicon_cn_32showid_h\"]/table/tbody/tr[2]/td[2]/table/tbody/tr/td[2]")));
//                                    needLocationElement.click();
//
//
//                                }
                                else {
                                    ww.until(ExpectedConditions.visibilityOf(needLocationElement));
                                    ww.until(ExpectedConditions.elementToBeClickable(needLocationElement));
                                    needLocationElement.click();

                                }


                            }catch (NoSuchElementException ne){
                                System.out.println("找不到需要点击的元素！");

                            } catch (UnknownError ue){
                                if(ue.getMessage().contains("Element is not clickable ")){
                                    System.out.println("该元素不可点击，请确认！");

                                }
                            } catch (Exception er) {

                                er.printStackTrace();


                            }


                            break;
                        case "IFRAME":
                            Thread.sleep(waitSecond*1000);
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
                                Boolean childIsNameRandom=childLocationElement.getNameRandom();
                                Integer childWaitSecond = childLocationElement.getWaitSecond();
                                String childSqlSchemaId = childLocationElement.getSqlSchemaId();

                                System.out.println("当前iframe(" + locationPath + ")操作元素：");
                                System.out.println("      定位方式：" + childLocationType);
                                System.out.println("      定位路径：" + childLocationPath);
                                System.out.println("      操作方式：" + childOperateType);
                                System.out.println("      默认值：" + childDefaultValue);
                                System.out.println("      是否随机数：" + childIsRandom);
                                System.out.println("       是否Name随机数：" +childIsNameRandom );
                                System.out.println("      等待时间：" + childWaitSecond);


                                WebElement needChildLocationElement = null;
                                List<WebElement> needChildLocationElementList = null;
                                Actions action1 = new Actions(driverIframeDY);
                                switch (childLocationType) {
                                    case "ID":
                                        if (!childOperateType.equals("FR") && !childOperateType.equals("FR2")) {
                                            needChildLocationElement = driverIframeDY.findElement(By.id(childLocationPath));
                                            needChildLocationElementList = driverIframeDY.findElements(By.id(childLocationPath));
                                        }
                                        break;
                                    case "NAME":
                                        if (!childOperateType.equals("FR") && !childOperateType.equals("FR2")) {
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
                                        Thread.sleep(childWaitSecond*1000);

                                        childDefaultValue = childDefaultValue.replace("{NOW}", DateUtils.getDate());
                                        childDefaultValue = childDefaultValue.replace("{ZSGBH}", String.format("%09d", StaticValue.GetRandomNumber(8)));
                                        for (WebElement webElement : needChildLocationElementList) {

                                            if (webElement.getTagName().equals("select")) {
                                                Select select = new Select(webElement);
                                                select.selectByValue(childDefaultValue);
                                            } else {
                                                childDefaultValue=childIsNameRandom?getName(Integer.valueOf(childDefaultValue)):childDefaultValue;
                                                webElement.sendKeys(childDefaultValue + (childIsRandom ? StaticValue.GetRandomNumber() : ""));
                                            }
                                        }
                                        break;
                                    case "SENDKEYS":
                                        Thread.sleep(childWaitSecond*1000);
                                        childDefaultValue = childDefaultValue.replace("{NOW}", DateUtils.getDatesh());
                                        childDefaultValue = childDefaultValue.replace("{ZSGBH}", String.format("%09d", StaticValue.GetRandomNumber(8)));
                                        if (needChildLocationElement.getTagName().equals("select")) {
                                            if(childDefaultValue.contains("@@@{BSM}")){

                                                String jgzhi=childDefaultValue.substring(0,childDefaultValue.indexOf("_"));
                                                String qlbm=childDefaultValue.substring(2,childDefaultValue.indexOf("@@@"));
                                                String resultbsm = "";
                                                String resultqxdm = "";
                                                int rownum=Integer.valueOf(jgzhi);
                                                String cxbsm=" select bsm from (select t.*,rownum as rn from "+qlbm+" t  where ywh="+"'"+projectId+"'  order by bsm) where rn="+rownum;
                                                String cxqxdm=" select qxdm from(select t.*,rownum as rn from "+qlbm+" t  where ywh="+"'"+projectId+"' order by bsm) where rn="+rownum;
                                                ResultSet rs = Assert_database.getResult(cxbsm);
                                                ResultSet rs1 = Assert_database.getResult(cxqxdm);

                                                if (rs.next()) {

                                                    resultbsm = rs.getString(1);

                                                } else {
                                                    resultbsm = "null";

                                                }

                                                if (rs1.next()) {

                                                    resultqxdm=rs1.getString(1);
                                                } else {

                                                    resultqxdm = "null";

                                                }

                                                Select select = new Select(needChildLocationElement);
                                                select.selectByValue(qlbm+"@@@"+resultbsm+"@@@"+resultqxdm);


                                            }else {
                                                Select select = new Select(needChildLocationElement);
                                                select.selectByValue(childDefaultValue);
                                            }
                                        } else if (childDefaultValue.contains("selenium")) {
                                            String result = DataProviderSet_procedure.call(childDefaultValue);
                                            needChildLocationElement.sendKeys(result);

                                        }else if(childDefaultValue.contains("@@@{BSM}")){

                                            String jgzhi=childDefaultValue.substring(0,childDefaultValue.indexOf("_"));
                                            String qlbm=childDefaultValue.substring(2,childDefaultValue.indexOf("@@@"));
                                            String resultbsm = "";
                                            String resultqxdm = "";
                                            int rownum=Integer.valueOf(jgzhi);
                                            String cxbsm=" select bsm from (select t.*,rownum as rn from "+qlbm+" t  where ywh="+"'"+projectId+"'  order by bsm) where rn="+rownum;
                                            String cxqxdm=" select qxdm from(select t.*,rownum as rn from "+qlbm+" t  where ywh="+"'"+projectId+"' order by bsm) where rn="+rownum;
                                            ResultSet rs = Assert_database.getResult(cxbsm);
                                            ResultSet rs1 = Assert_database.getResult(cxqxdm);

                                            if (rs.next()) {

                                                resultbsm = rs.getString(1);

                                            } else {
                                                resultbsm = "null";

                                            }

                                            if (rs1.next()) {

                                                resultqxdm=rs1.getString(1);
                                            } else {

                                                resultqxdm = "null";

                                            }



                                            needChildLocationElement.sendKeys(qlbm+"@@@"+resultbsm+"@@@"+resultqxdm);
                                        } else {

                                                childDefaultValue=childIsNameRandom?getName(Integer.valueOf(childDefaultValue)):childDefaultValue;
                                                needChildLocationElement.sendKeys(childDefaultValue + (childIsRandom ? StaticValue.GetRandomNumber() : ""));

                                        }


                                        break;
                                    case "CLICK":
                                        Thread.sleep(childWaitSecond*1000);
                                        WebDriverWait wait1=new WebDriverWait(driverIframeDY,180);
//                                        WaitTime.getElementclick(driverIframeDY, 180, needChildLocationElement);
//                                        WaitTime.getElementVisi(driverIframeDY, 180, needChildLocationElement);
                                        wait1.until(ExpectedConditions.visibilityOf(needChildLocationElement));
                                        wait1.until(ExpectedConditions.elementToBeClickable(needChildLocationElement));
                                        action1.moveToElement(needChildLocationElement);

                                        needChildLocationElement.click();
                                        System.out.println("已经完成点击事件了");


                                        break;
                                    case "QT": //执行js
                                        Thread.sleep(childWaitSecond*1000);
                                        String id = needChildLocationElement.getAttribute("id");
                                        if (id == null || id.equals("")) {
                                            id = childDefaultValue;
                                        }
                                        String js = childDefaultValue.replace("{ID}", id);
                                        ((JavascriptExecutor) driver).executeScript(js);
                                        break;
                                    case "FR":
                                        Thread.sleep(childWaitSecond*1000);
                                        Thread.sleep(2000);
                                        childDefaultValue = childDefaultValue.replace("{NOW}", DateUtils.getDate());
                                        childDefaultValue = childDefaultValue.replace("{ZSGBH}", String.format("%09d", StaticValue.GetRandomNumber(8)));
                                        FRValue.SetFRValue(driverIframeDY, childLocationPath, childDefaultValue + (isRandom ? StaticValue.GetRandomNumber() : ""));
                                        break;
                                    case "FR2":
                                        Thread.sleep(childWaitSecond*1000);
                                        Thread.sleep(2000);
                                        childDefaultValue = childDefaultValue.replace("{NOW}", DateUtils.getDate());
                                        childDefaultValue = childDefaultValue.replace("{ZSGBH}", String.format("%09d", StaticValue.GetRandomNumber(8)));
                                        FRValue.SetFRValue2(driverIframeDY, childLocationPath, defaultValue + (isRandom ? StaticValue.GetRandomNumber() : ""));
                                        break;
                                    case "FRExport":
                                        //表单输出 word-文件名
                                        Thread.sleep(childWaitSecond*1000);

                                        try {

                                            File f = new File(Path.FRPath());
                                            if (!f.exists()) {
                                                f.mkdir();
                                            }
                                            String format="",finallyname="",houzhui="";
                                            if(filename.contains("-")){
                                                 format=filename.substring(0,filename.indexOf("-")).trim();
                                                 finallyname=filename.substring(filename.indexOf("-")+1);
                                                 houzhui = null;
                                            }else {
                                                 format="pdf";
                                                 finallyname=defaultValue;
                                            }

                                            switch (format){
                                                case "word":
                                                    houzhui=".doc";
                                                    break;
                                                case "pdf":
                                                    houzhui=".pdf";
                                                    break;
                                                case "image":
                                                    houzhui=".png";
                                                    break;
                                                case "excel":
                                                    houzhui=".xls";
                                                    break;

                                            }


                                            String outurl = driver.getCurrentUrl() + "&format="+format;
                                            DownLoadPdf.downLoadFromUrl(outurl,
                                                    finallyname +houzhui, f.getAbsolutePath());
                                            Reporter.log("<a href=\""+ f.getAbsolutePath()+"\\"+finallyname+houzhui+"\"  target=\"_blank\">"+finallyname+"</a>");

                                            FRreportUtils frchild=new FRreportUtils();
                                            frchild.setChildId(prodefid + DateUtils.getDate());
                                            frchild.setChildName(finallyname);
                                            frchild.setChildPath(Path.FRPath()+"\\"+finallyname+houzhui);
                                            frchildList.add(frchild);

                                        } catch (Exception e) {
                                            e.getStackTrace();
                                        }
                                        break;

                                    case "SHOOT":
                                        Thread.sleep(childWaitSecond*1000);
//                                      谷歌截图--可见区域
                                        Screenshoot.getShoot(driverIframeDY, locationElement.getDefaultValue());



                                        break;
                                    case "Assert":
                                        Thread.sleep(childWaitSecond*1000);

                                        WaitTime.getElementVisi(driverIframeDY, 30, needChildLocationElement);
                                        if (needChildLocationElement.getText().isEmpty()) {

                                            ((JavascriptExecutor) driver).executeScript("arguments[0].scrollIntoView(false);", needChildLocationElement);


                                        }

                                        if (childDefaultValue.contains("select")) {
                                            if(childDefaultValue.contains(",")){
                                                String result1="",result2="";

                                                ResultSet rs;
                                                rs= Assert_database.getResult(childDefaultValue);

                                                if (rs.next()) {
                                                    result1 = rs.getString(1);
                                                    result2 = rs.getString(2);
                                                } else {
                                                    result1 = "null";
                                                    result2 = "null";

                                                }

                                                actuallist.add("实际结果：" + needChildLocationElement.getText());
                                                descriptionlist.add(introduce);
                                                exceptlist.add("预期结果：" + result1+"/"+result2);

                                            }
                                            String result = "";
                                            ResultSet rs = Assert_database.getResult(childDefaultValue);
                                                if (rs.next()) {
                                                    result = rs.getString(1);
                                                } else {
                                                    result = "null";

                                                }


                                            actuallist.add("实际结果：" + needChildLocationElement.getText());
                                            descriptionlist.add(introduce);
                                            exceptlist.add("预期结果：" + result);
                                        } else {
                                            actuallist.add("实际结果：" + needChildLocationElement.getText());
                                            descriptionlist.add(introduce);
                                            exceptlist.add("预期结果：" + childDefaultValue);

                                        }

                                        break;

                                    case "Clear":
                                        Thread.sleep(childWaitSecond*1000);
                                        needChildLocationElement.clear();
                                        break;
                                    case "Refresh":
                                        Thread.sleep(childWaitSecond*1000);
                                        driverIframeDY.navigate().refresh();
                                        break;

                                    case "FRAssert":
                                        Thread.sleep(childWaitSecond*1000);
                                        actuallist.add("实际结果：" + FRValue.getFRvalueToAssert(driverIframeDY, childLocationPath));
                                        descriptionlist.add(introduce);
                                        if (childDefaultValue.contains("select")) {
                                            String result = "";
                                            ResultSet rs = Assert_database.getResult(childDefaultValue);
                                            if (rs.next()) {
                                                result = rs.getString(1);
                                            } else {
                                                result = "null";

                                            }

                                            exceptlist.add("预期结果：" + result);
                                        } else {

                                            exceptlist.add("预期结果：" + childDefaultValue);
                                        }


                                        break;

                                }


                                if (childWaitSecond >=0) {
                                    waitForAjaxControls(120, driverIframeDY);
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
                            Thread.sleep(waitSecond*1000);
                            String id = needLocationElement.getAttribute("id");
                            if (id == null || id.equals("")) {
                                id = defaultValue;
                            }
                            String js = defaultValue.replace("{ID}", id);
                            ((JavascriptExecutor) driver).executeScript(js);

                            break;
                        case "FR":
                            Thread.sleep(waitSecond*1000);
                            Thread.sleep(2000);
                            defaultValue = defaultValue.replace("{NOW}", DateUtils.getDate());
                            defaultValue = defaultValue.replace("{ZSGBH}", String.format("%09d", StaticValue.GetRandomNumber(8)));
                            FRValue.SetFRValue(driveIframe, locationPath, defaultValue + (isRandom ? StaticValue.GetRandomNumber() : ""));
                            break;
                        case "FR2":
                            Thread.sleep(waitSecond*1000);
                            Thread.sleep(2000);
                            defaultValue = defaultValue.replace("{NOW}", DateUtils.getDate());
                            defaultValue = defaultValue.replace("{ZSGBH}", String.format("%09d", StaticValue.GetRandomNumber(8)));
                            FRValue.SetFRValue2(driveIframe, locationPath, defaultValue + (isRandom ? StaticValue.GetRandomNumber() : ""));
                            break;
                        case "Refresh":
                            Thread.sleep(waitSecond*1000);
                            driveIframe.navigate().refresh();
                            break;

                        case "FRExport":
                            Thread.sleep(waitSecond*1000);
                            //表单输出
                            try {
                                File f = new File(Path.FRPath());
                                if (!f.exists()) {
                                    f.mkdir();
                                }
                                String format="",finallyname="",houzhui="";
                                if(filename.contains("-")){
                                    format=filename.substring(0,filename.indexOf("-")).trim();
                                    finallyname=filename.substring(filename.indexOf("-")+1);
                                    houzhui = null;
                                }else {
                                    format="pdf";
                                    finallyname=defaultValue;
                                }

                                switch (format){
                                    case "word":
                                        houzhui=".doc";
                                        break;
                                    case "pdf":
                                        houzhui=".pdf";
                                        break;
                                    case "image":
                                        houzhui=".png";
                                        break;
                                    case "excel":
                                        houzhui=".xls";
                                        break;

                                }



                                String outurl = driver.getCurrentUrl() + "&format="+format;
                                DownLoadPdf.downLoadFromUrl(outurl,
                                        finallyname + houzhui, f.getAbsolutePath());
                                Reporter.log("<a href=\""+ f.getAbsolutePath()+"\\"+finallyname+houzhui+"\"  target=\"_blank\">"+finallyname+"</a>");


                                FRreportUtils frchild1=new FRreportUtils();
                                frchild1.setChildId(prodefid + DateUtils.getDate());
                                frchild1.setChildName(finallyname);
                                frchild1.setChildPath(Path.FRPath()+"\\"+finallyname+houzhui);
                                frchildList.add(frchild1);

                            } catch (Exception e) {
                                // TODO: handle exception
                            }
                            break;

                        case "SHOOT":
                            Thread.sleep(waitSecond*1000);

//                            谷歌截图--可见区域
                            Screenshoot.getShoot(driverFilePage, locationElement.getDefaultValue());

                            break;
                        case "Assert":
                            Thread.sleep(waitSecond*1000);

                            WaitTime.getElementVisi(driverFilePage, 30, needLocationElement);

                            if (needLocationElement.getText().isEmpty()) {

                                ((JavascriptExecutor) driver).executeScript("arguments[0].scrollIntoView(false);", needLocationElement);


                            }
                            if (defaultValue.contains("select")) {

                                if(defaultValue.contains(",")) {
                                    String result1 = "", result2 = "";

                                    ResultSet rs;
                                    rs = Assert_database.getResult(defaultValue);

                                    if (rs.next()) {
                                        result1 = rs.getString(1);
                                        result2 = rs.getString(2);
                                    } else {
                                        result1 = "null";
                                        result2 = "null";

                                    }

                                    actuallist.add("实际结果：" + needLocationElement.getText());
                                    descriptionlist.add(introduce);
                                    exceptlist.add("预期结果：" + result1 + "/" + result2);
                                }else {

                                    String result = "";
                                    ResultSet rs = null;
                                    String sqlword = "";

                                    if (defaultValue.contains("{YWH}")) {
                                        sqlword = defaultValue.replace("{YWH}", projectId);
                                        if (defaultValue.contains("{LCDM}")) {
                                            sqlword = defaultValue.replace("{YWH}", projectId).replace("{LCDM}", plcdm);
                                        }


                                    }
                                    rs = Assert_database.getResult(sqlword);

                                    if (rs.next()) {
                                        result = rs.getString(1);
                                    } else {
                                        result = "null";
                                    }

                                    actuallist.add("实际结果：" + needLocationElement.getText());
                                    exceptlist.add("预期结果：" + result);
                                    descriptionlist.add(introduce);


//                                else if(defaultValue.contains("{BDCDYH}")){
//                                    String sqlword = defaultValue.replace("{BDCDYH}", "");
//                                    //暂时不做，因为涉及比较多
//
//                                }else {

//                                    rs = Assert_database.getResult(defaultValue);
//
//                                }
                                }

                            } else {

                                actuallist.add("实际结果：" + needLocationElement.getText());
                                exceptlist.add("预期结果：" + defaultValue);
                                descriptionlist.add(introduce);

                            }

                            break;
                        case "Clear":
                            Thread.sleep(waitSecond*1000);
                            needLocationElement.clear();
                            break;

                        case "FRAssert":
                            Thread.sleep(waitSecond*1000);

                            actuallist.add("实际结果：" + FRValue.getFRvalueToAssert(driverFilePage, locationPath));
                            descriptionlist.add(introduce);
                            if (defaultValue.contains("select")) {
                                String result = "";
                                ResultSet rs = Assert_database.getResult(defaultValue);
                                if (rs.next()) {
                                    result = rs.getString(1);
                                } else {
                                    result = "null";

                                }

                                exceptlist.add("实际结果：" + result);
                            } else {

                                exceptlist.add("实际结果：" + defaultValue);
                            }


                    }


                    if (waitSecond >= 0) {
                        waitForAjaxControls(120, driveIframe);
                               /* System.out.println(locationPath+","+childLocationPath+"等待："+childWaitSecond);
                                Thread.sleep(childWaitSecond);*/
                    }

                }


                Thread.sleep(1000);
                //处理受理申请信息
                webNewWindow.switchTo().defaultContent();
                driverFilePage = webNewWindow.switchTo().frame(commonConfig.getWorkFlowFrameIframe());

            }


            //移交页面
            webNewWindow.switchTo().defaultContent();

            //大保存成功了以后，才进行移交

           TrasferPro(webNewWindow, commonConfig,actdef.getName());


            driver.switchTo().window(currentWindow);

                if(errorMessage.equals("移交存在异常")||errorMessage.equals("移交存在转出校验！")){
                    isHaveNext=false;
                }else {
                    isHaveNext = SelectPro(driver, commonConfig, projectId);
                    if (isHaveNext) {
                        driver.switchTo().defaultContent();
                        //等待窗口弹出来
                        Thread.sleep(2000);
                        ActdefAction(driver, currentWindow, prodef, commonConfig, mapAllSchema, mapColumnValue);
                    }
                }



        }catch(NoSuchElementException er){

            System.out.println(acdefName+"环节，定位信息有误，请确认！");
            Reporter.log(acdefName+"环节，元素定位信息有误："+er);
            Screenshoot.getShoot(driver, "环节操作-找不到元素截图"+min.format(da).replace(":","_").replace(" ","_").trim());


        }catch (NoSuchWindowException er){
            System.out.println("窗口异常，找不到窗口！");
            Reporter.log(acdefName+"环节，窗口异常："+er);
            Screenshoot.getShoot(driver, "环节操作-窗口异常"+min.format(da).replace(":","_").replace(" ","_").trim());
            closeWindow(driver);

        }catch (TimeoutException er){
            System.out.println(acdefName+"环节，超时元素不可见");
            Reporter.log(acdefName+"环节，超时元素不可见："+er);
            Screenshoot.getShoot(driver, acdefName+"-环节操作-超时元素不可见截图"+min.format(da).replace(":","_").replace(" ","_").trim());
            closeAlter(driver);
        } catch (Exception er) {

            Reporter.log(acdefName+"-流程环节操作-报错信息："+er);
            Screenshoot.getShoot(driver, acdefName+"-环节操作-报错截图"+min.format(da).replace(":","_").replace(" ","_").trim());
            er.printStackTrace();
            System.out.println("强行关闭流程窗口，开启下面环节！");
            closeWindow(driver);
            isHaveNext = false;
            errorMessage = "存在报错信息，退出执行其他流程";

        }
    }


    public static void waitForAjaxControls(int timeoutInSeconds, WebDriver driver) {
//        System.out.println(timeoutInSeconds);
        new WebDriverWait(driver, timeoutInSeconds ).until(new ExpectedCondition<Boolean>() {
            @Override
            public Boolean apply(WebDriver driver) {
                System.out.println(DateUtils.getDate("yyyy-MM-dd HH:mm:ss"));
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
        System.out.println(DateUtils.getDate("yyyy-MM-dd HH:mm:ss"));
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
        boolean isHaveNext = false;
        try {

                WebDriverWait wait = new WebDriverWait(driver, 120);
                WebElement elementGZZX = driver.findElement(By.linkText("工作中心"));
                wait.until(ExpectedConditions.visibilityOf(elementGZZX));
                wait.until(ExpectedConditions.elementToBeClickable(elementGZZX));
                elementGZZX.click();
                System.out.println("点击工作中心");

                WebElement elementPopMenu = driver.findElement(By.xpath("//div[@class='PopupMenu']"));
                List<WebElement> allFuncitem = driver.findElements(By.xpath("//span[@class='menu_level_0']"));
                for (WebElement elementFunction : allFuncitem) {
                    if (elementFunction.getAttribute("innerText").equals("新收办件")) {
                        System.out.println("点击新收办件");
                        wait.until(ExpectedConditions.visibilityOf(elementFunction));
                        wait.until(ExpectedConditions.elementToBeClickable(elementFunction));
                        elementFunction.click();
                        break;
                    }

                }


                WebDriver driverXJBJ = driver.switchTo().frame(commonConfig.getCreateProIframe());

                WebDriverWait waitxjbj=new WebDriverWait(driverXJBJ,120);

                waitxjbj.until(ExpectedConditions.visibilityOfElementLocated(By.id("txtInput")));


                driverXJBJ.findElement(By.id("txtInput")).sendKeys(projectId); //输入办件号
                waitxjbj.until(ExpectedConditions.elementToBeClickable(By.id("searchButton")));//查询

                driverXJBJ.findElement(By.id("searchButton")).click();//查询

                Thread.sleep(2000);
                List<WebElement> elementBJ = driverXJBJ.findElements(By.xpath("//div[@class='jqx-grid-cell-left-align']"));


                for (WebElement elementNewPJ : elementBJ) {
                    if (elementNewPJ.getAttribute("innerText").equals(projectId)) {
                        isHaveNext = true;
                        waitxjbj.until(ExpectedConditions.visibilityOf(elementNewPJ));
                        waitxjbj.until(ExpectedConditions.elementToBeClickable(elementNewPJ));
                        elementNewPJ.click();

                        break;
                    }


                }



        } catch (Exception er) {
            er.printStackTrace();

        }
        return isHaveNext;

    }


    private static void TrasferPro(WebDriver driver, CommonConfig commonConfig,String acdefname) throws Exception {

        try {



            WebDriverWait wait = new WebDriverWait(driver, 30);
            WebElement elementYJ = driver.findElement(By.id("btnComplete"));//点击移交
            wait.until(ExpectedConditions.visibilityOf(elementYJ));
            wait.until(ExpectedConditions.elementToBeClickable(elementYJ));
            elementYJ.click();



            WebDriver webTransfer = driver.switchTo().frame("ifTransmit");//移交页面，选择人员
            List<WebElement> elementTransferAs = webTransfer.findElements(By.xpath("//div[@class='tabTitle']"));

            if (elementTransferAs != null && elementTransferAs.size() > 0) {

                for (WebElement elementA : elementTransferAs) {
                    if (elementA.getAttribute("innerText").equals("初审")) {
                        wait.until(ExpectedConditions.visibilityOf(elementA));
                        wait.until(ExpectedConditions.elementToBeClickable(elementA));

                        if (isContentClick(driver,elementA)) {
                            elementA.click();
                        }


                    }
                }
                //最后一个环节的时候不需要选择人员
                //TODO 2019/02/15增加一个参数作为移交人员的选择;后期采用对接运维接口，用户可以选择的方式
//                waitForAjaxControls(30,driver);
                try {
                    WebElement elementYJRY = webTransfer.findElement(By.linkText(commonConfig.getYJName()));

                    elementYJRY.click();


                } catch (NoSuchElementException er) {
//                    er.getStackTrace();
                }

            }

            WebDriverWait wait1=new WebDriverWait(webTransfer,30);

            //移交
            List<WebElement> elementYJSave = webTransfer.findElements(By.xpath("//input[@class='blue_btn']"));

            for (WebElement element : elementYJSave) {
                if (element.getAttribute("value").indexOf("转出") > -1 || element.getAttribute("value").indexOf("确定") > -1) {
                    wait1.until(ExpectedConditions.elementToBeClickable(element));
                    element.click();



                }
                if( element.getAttribute("value").indexOf("确定") > -1){
                    isSuccess=true;

                }


            }
            waitForAjaxControls(30,driver);

            boolean zhua = isContentAppeared(driver, "//div[@class=\"layui-layer layui-anim layui-layer-dialog \"]");

            System.out.println("移交校验是否出现："+zhua);


            if(zhua){

                WebElement element=driver.findElement(By.xpath("//div[@class=\"layui-layer layui-anim layui-layer-dialog \"]"));
                String text=element.getText();
                if(element.getText().length()<4){
                    System.out.println("校验信息未出现关键字段内容，请确认！");
                    Reporter.log(acdefname+"环节移交异常！转出校验信息弹窗没有内容！" );
                }else{

                    System.out.println("校验文本：" +text.substring(2,text.length()-2));
                    Reporter.log(acdefname+"-环节移交异常！转出校验信息为：" + text.substring(2,text.length()-2));
                    Screenshoot.getShoot(driver, "转出校验提示框-"+ss.format(new Date()).replace(":","_").replace(" ","_").trim());


                }
                driver.switchTo().defaultContent();
                ((JavascriptExecutor) driver).executeScript("closeTaskExt(true)");
                errorMessage = "移交存在转出校验！";

            }


        } catch (Exception er) {
            errorMessage = "移交环节报错";
            System.out.println("移交环节报错");


        }




    }


    public static void dotestng(String schemaname) {



        TestNG testNG = new TestNG();
        Class[] classes;
        classes = new Class[]{DataProviderSet_Assert.class};

        testNG.setTestClasses(classes);
        Reporter.setEscapeHtml(false);

        testNG.setOutputDirectory(Path.reportPath());

        testNG.setDefaultTestName("断言详情查看");


        testNG.setDefaultSuiteName(schemaname);

        System.out.println("运行自动化测试");
        Reporter.log("");
        testNG.run();





    }

    public static void noAssert(String schemaname) {


        TestNG testNG = new TestNG();
        Class[] classes;

        classes = new Class[]{NoAssert.class};

        testNG.setTestClasses(classes);
        Reporter.setEscapeHtml(false);
        testNG.setOutputDirectory(Path.reportPath());

        testNG.setDefaultTestName("断言详情查看");
        testNG.setDefaultSuiteName(schemaname);
        Reporter.log("");
        testNG.run();


    }



    public static boolean isContentAppeared(WebDriver driver, String content)  {
        boolean status = false;
        try {
            driver.findElement(By.xpath(content)).isDisplayed();
            status = true;
        } catch (Exception e) {
            status = false;

        }
        return status;

    }

    public static boolean isContentClick( WebDriver driver, WebElement element) {
        boolean status = false;
        try {
            WebDriverWait wait=new WebDriverWait(driver,10);
            wait.until(ExpectedConditions.visibilityOf(element));
            wait.until(ExpectedConditions.elementToBeClickable(element));

            element.click();

            status = true;
        } catch (Exception e) {

            status = false;
        }
        return status;
    }

    public static void closeAlter(WebDriver driver) throws AWTException, InterruptedException {
        driver.switchTo().defaultContent();
        ((JavascriptExecutor) driver).executeScript("closeTask()");
        Robot robot=new Robot();
        robot.keyPress(KeyEvent.VK_ENTER);
        robot.keyRelease(KeyEvent.VK_ENTER);
        Thread.sleep(500);
        robot.keyPress(KeyEvent.VK_ENTER);
        robot.keyRelease(KeyEvent.VK_ENTER);
        driver.switchTo().window(currentWindow);
    }

    public static void closeWindow(WebDriver driver) throws AWTException {
        driver.switchTo().defaultContent();
        ((JavascriptExecutor) driver).executeScript("closeTask()");
        Robot robot=new Robot();
        robot.keyPress(KeyEvent.VK_ENTER);
        robot.keyRelease(KeyEvent.VK_ENTER);
        driver.switchTo().window(currentWindow);

    }



}
