package selenium;

import Test.Assert.Assertion;
import configSelenium.Entity.SeleniumTest.Iframe;
import javafx.scene.shape.Rectangle;
import org.apache.poi.ss.formula.functions.T;
import org.omg.PortableServer.THREAD_POLICY_ID;
import org.openqa.selenium.*;
import org.openqa.selenium.Point;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeDriverService;
import org.openqa.selenium.chrome.ChromeOptions;
import org.openqa.selenium.interactions.Actions;
import org.openqa.selenium.internal.WrapsDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;
import org.testng.Reporter;
import org.testng.TestNG;
import org.testng.annotations.Listeners;
import org.testng.annotations.Test;
import selenium.FirstTrial.FirstTrial;
import selenium.common.ChangeDriver;
import selenium.workflow.WorkFlow;


import javax.imageio.ImageIO;

import javax.swing.*;

import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;

import java.util.List;
import java.util.Map;
import java.util.concurrent.TimeUnit;

import static configSelenium.ConfigSeleniumStart.currentWindow;
import static configSelenium.StaticValue.getAllRequestParam;
import static org.assertj.core.api.Assertions.assertThat;

/**
 * @author wangyan
 * @date 2019-02-18  上午 08:59
 */
@Listeners({org.uncommons.reportng.HTMLReporter.class,org.uncommons.reportng.JUnitXMLReporter.class})
public class debug_richang {

    public static File captureElement(WebElement element) throws IOException {

        WrapsDriver wrapsDriver= (WrapsDriver) element;
        File screen=((TakesScreenshot)wrapsDriver.getWrappedDriver()).getScreenshotAs(OutputType.FILE);
        BufferedImage img = ImageIO.read(screen);
        // 获得元素的高度和宽度
        int width = element.getSize().getWidth();
        int height = element.getSize().getHeight();
        // 创建一个矩形使用上面的高度，和宽度
        Rectangle rect = new Rectangle(width, height);
        // 得到元素的坐标
        Point p = element.getLocation();
//        BufferedImage dest = img.getSubimage(p.getX(), p.getY(), rect.getWidth(), rect.getHeight());
        // 存为png格式
//        ImageIO.write(dest, "png", screen);
        return screen;
    }

    @Test
    public   void getAssert(){
        assertThat("旺达").as("不相等啊").isEqualTo("旺达");
        Assertion.verifyEquals("2","2");
        String path="D:\\work_space\\js_de\\debug\\SeleniumConfig\\bin\\Debug\\SootScreens\\2019-03-27\\09_39\\资料收取 09_39.png";
        Reporter.log("测试用例1");
        Reporter.log("<img src=\""+ path +"\""+ "  hight=\"300\" width=\"300\"  >");
    }


    public static void main(String[] args) throws Exception {
//        TestNG testNG=new TestNG();
//        Class[] classes={debug_richang.class};
//        testNG.setTestClasses(classes);
//        testNG.run();


//        String a="select * from bdcdyzt where ywh=‘{YWH}’";
//        String a1=a.replace("{YWH}","2018-2209-09394");
//        System.out.println(a1);
        ChromeDriverService service = null;
        WebDriver driver = null;


        service = new ChromeDriverService.Builder().usingDriverExecutable(
                new File(
                        "C:\\\\Chrome34\\\\App\\\\Google Chrome\\\\chromedriver.exe")).usingAnyFreePort().build();

        service.start();
        ChromeOptions options = new ChromeOptions();
        options.addArguments("disable-extensions=Chrome Automation Extension"); //采用默认的谷歌配置参数
        options.addArguments("--headless");

        driver = new ChromeDriver(options);

        driver.manage().window().maximize();



        //


        driver.get("http://192.168.11.8:8082/GisqPlatformExplorer/a?login");

        WebElement username = driver.findElement(By.id("username"));
        username.sendKeys("atester");
        WebElement password = driver.findElement(By.id("password"));
        password.sendKeys("1234");
        driver.manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);
        WebElement buttom = driver.findElement(By.className("login_button"));
        buttom.click();
//
//
////        new WebDriverWait(driver,10).until(ExpectedConditions.visibilityOf( driver.findElement(By.className("notClose te"))));
////        driver.findElement(By.xpath("//*[@id=\"tab_line\"]/div[2]/ul/li[1]")).click();
//
//        driver.switchTo().frame("view_首页0");
//        String cu=driver.getWindowHandle();
//        System.out.println("句柄：" + driver.getWindowHandle());
//        WebDriverWait wait = new WebDriverWait(driver, 120);
//        driver.switchTo().defaultContent();
//        WebElement elementGZZX = driver.findElement(By.linkText("工作中心"));
//        wait.until(ExpectedConditions.visibilityOf(elementGZZX));
//        wait.until(ExpectedConditions.elementToBeClickable(elementGZZX));
//        elementGZZX.click();
//        System.out.println("点击工作中心");
//
//        Thread.sleep(5000);
//        WebElement elementPopMenu = driver.findElement(By.xpath("//div[@class='PopupMenu']"));
//        List<WebElement> allFuncitem = driver.findElements(By.xpath("//span[@class='menu_level_0']"));
//        for (WebElement elementFunction : allFuncitem) {
//            if (elementFunction.getAttribute("innerText").equals("在办办件")) {
//
//                elementFunction.click();
//                break;
//            }
//
//        }
////
////        System.out.println("句柄："+driver.getWindowHandle());
//        WebDriver driverXJBJ = driver.switchTo().frame("view_在办办件-1");
//        WebDriverWait ww = new WebDriverWait(driverXJBJ, 120);
//        Thread.sleep(2000);
//        boolean isHaveNext = false;
//
//        WebElement txtinput = driverXJBJ.findElement(By.id("txtInput"));
//        ww.until(ExpectedConditions.visibilityOf(txtinput));
//        ww.until(ExpectedConditions.presenceOfElementLocated(By.id("txtInput")));
//        txtinput.sendKeys("20190330-0004523"); //输入办件号
//        ww.until(ExpectedConditions.elementToBeClickable(By.id("searchButton")));//查询
//
//        driverXJBJ.findElement(By.id("searchButton")).click();//查询
//
//        Thread.sleep(5000);
//        List<WebElement> elementBJ = driverXJBJ.findElements(By.xpath("//div[@class='jqx-grid-cell-left-align']"));
//
//
//        for (WebElement elementNewPJ : elementBJ) {
//            if (elementNewPJ.getAttribute("innerText").equals("20190330-0004523")) {
//
//                ww.until(ExpectedConditions.visibilityOf(elementNewPJ));
//                ww.until(ExpectedConditions.elementToBeClickable(elementNewPJ));
//                elementNewPJ.click();
//
//                break;
//            }
//
//
//        }
//
//
//        WebDriver webNewWindow = ChangeDriver.change(driver, currentWindow);
//        System.out.println("句柄："+webNewWindow.getWindowHandle()+"\t标题："+webNewWindow.getTitle());
//        WebDriverWait wait1 = new WebDriverWait(webNewWindow, 60);
//        Thread.sleep(7000);
//
//        WebDriver driverFilePage = driver.switchTo().frame("clientContainer");
//        driverFilePage.findElement(By.xpath("/html/body/div[1]/div[1]/div[1]"));
////        ChangeDriver.change(driver, currentWindow);
////        System.out.println("iframe名称："+Iframe.class.getName());
//
//        driver.switchTo().defaultContent();
//
//        WebElement elementYJ = webNewWindow.findElement(By.id("btnComplete"));//点击移交
//        wait1.until(ExpectedConditions.visibilityOf(elementYJ));
//        wait1.until(ExpectedConditions.elementToBeClickable(elementYJ));
//        elementYJ.click();
//
//
//        WebDriver webTransfer = driver.switchTo().frame("ifTransmit");//移交页面，选择人员
//        List<WebElement> elementTransferAs = webTransfer.findElements(By.xpath("//div[@class='tabTitle']"));
//
//        if (elementTransferAs != null && elementTransferAs.size() > 0) {
//
//            for (WebElement elementA : elementTransferAs) {
//                if (elementA.getAttribute("innerText").equals("初审")) {
//                    wait.until(ExpectedConditions.visibilityOf(elementA));
//                    wait.until(ExpectedConditions.elementToBeClickable(elementA));
////                    if (isContentClick(elementA)) {
////                        elementA.click();
////                    }
//
//
//                }
//            }
////            最后一个环节的时候不需要选择人员
//            //TODO 2019/02/15增加一个参数作为移交人员的选择;后期采用对接运维接口，用户可以选择的方式
//            try {
//                WebElement elementYJRY = webTransfer.findElement(By.linkText("干晓圆"));
//                wait.until(ExpectedConditions.visibilityOf(elementYJRY));
//                wait.until(ExpectedConditions.elementToBeClickable(elementYJRY));
//                elementYJRY.click();
//
//
//            } catch (NoSuchElementException er) {
//                er.getStackTrace();
//                Reporter.log(er.toString());
//                throw er;
//            }
//
//        }
//
//        WebDriverWait wait2=new WebDriverWait(webTransfer,30);
//
//        //移交
//        List<WebElement> elementYJSave = webTransfer.findElements(By.xpath("//input[@class='blue_btn']"));
//        for (WebElement element : elementYJSave) {
//            if (element.getAttribute("value").indexOf("转出") > -1 || element.getAttribute("value").indexOf("确定") > -1) {
//                wait2.until(ExpectedConditions.elementToBeClickable(element));
//                System.out.println("点击移交或者确定");
//                System.out.println("点击移交的名称："+element.getText());
//                element.click();
//
//            }
//        }

//        driver.findElement(By.className("notClose te")).click();
////        driver.switchTo().parentFrame();
//        driver.switchTo().frame("view_首页0");
////        driver.switchTo().window(cu);
//
//
//        WebElement fdfj = driver.findElement(By.id("38bcedca-df88-11e5-b408-000c29187a9e"));
//        fdfj.click();

//        WebElement scfj = driver.findElement(By.xpath("//a[@pid='35a75c27-d11c-11e8-8026-00505683a231']"));
//        scfj.click();
//        driver.switchTo().defaultContent();
//        driver.manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);
//        Thread.sleep(5000); //等待窗口弹出来
//        String currentWindow = driver.getWindowHandle();
//        System.out.print("主框架句柄：" + currentWindow);
//
//        WebDriver webNewWindow = ChangeDriver.change(driver, currentWindow);
//        webNewWindow.switchTo().defaultContent();
//
//
//
//        String url = webNewWindow.getCurrentUrl();
//        Map<String, String> allRequestParam = getAllRequestParam(url);
//        WebDriver driverFilePage = webNewWindow.switchTo().frame("clientContainer");
//        String projectId = allRequestParam.get("businesskey".toUpperCase());
//
//          /*  WebElement elementSlTzs= driverFilePage.findElement(By.id("ztree_9_a"));
//            elementSlTzs.click();*/
//
//
//        List<WebElement> allElement = driverFilePage.findElements(By.tagName("iframe"));
//        for (WebElement element : allElement) {
//            try {
//                String src1 = element.getAttribute("src1");
//                String id = element.getAttribute("id");
//                if (src1.indexOf("datums_submit") > -1) {
//                    WebDriver driverDataSubmit = driverFilePage.switchTo().frame(id);
//                    WebElement elementDataSubmit = driverDataSubmit.findElement(By.xpath("//div[@role='combobox']"));
//                    String jqWidgetsId = elementDataSubmit.getAttribute("id");
//                    //选择资料类别，默认选中第一个
//                    Thread.sleep(6000);
//                    String js = "$(\"#" + jqWidgetsId + "\").jqxDropDownList('selectIndex', 0 );";
//                    String input_title = (String) ((JavascriptExecutor) driver).executeScript(js);
//
//                    //保存资料类别
//                    WebElement elementSaveDatum = driverDataSubmit.findElement(By.id("saveDatum"));
//                    elementSaveDatum.click();
//                }
//            } catch (Exception er) {
//
//            }
//        }
//        Thread.sleep(2000);
//        //处理受理申请信息
//        webNewWindow.switchTo().defaultContent();
//        driverFilePage = webNewWindow.switchTo().frame("clientContainer");
//        WebElement elementSQXX = driverFilePage.findElement(By.xpath("//a[@title='申请信息']"));
//        Thread.sleep(5000);
//
//        elementSQXX.click();
//
//        webNewWindow.switchTo().defaultContent();
////        driver.get("http://192.168.2.119:8084/GisqQueryList/views/reports/realestate/leaseHold/Acceptance_ThreeRightSplit.jsp?reportlet=realestate/leaseHold/Acceptance_ThreeRightSplit.cpt&op=write&BDFR_GUID=0ab94f61-188e-11e9-b0f7-00505683a231&ID=06c6d5fe-4b03-11e9-af86-00505683a231&CATEGORY=BDC&RECORDNUMBER=8f0e8cf3-e7a5-4529-8948-812946367301&BIZDEF_GUID=08e50498-188e-11e9-b0f7-00505683a231&BIZINST_GUID=066e55b9-4b03-11e9-af86-00505683a231&TYPE=form&userId=67589262-9481-11e8-9b9e-00505683a231&TRANSACTOR=%E7%8E%8B%E5%B2%A9&aid=sid-2179c451-1f00-11e9-9cb9-00505683a231&ACTDEFID=sid-2179c451-1f00-11e9-9cb9-00505683a231&tid=d398eb20-4b03-11e9-b523-00505683a231&ACTINSTID=d398eb20-4b03-11e9-b523-00505683a231&pid=262e24ae-1f00-11e9-9cb9-00505683a231&PRODEFID=262e24ae-1f00-11e9-9cb9-00505683a231&instid=0533b2d7-4b03-11e9-b523-00505683a231&PROINSTID=0533b2d7-4b03-11e9-b523-00505683a231&businesskey=20190320-0003551&PROJECTID=20190320-0003551&LCBM=8201&HJDM=SJ&XZQBM=3314&task_state=null");
////
////
////        System.out.println("1:"+driver.findElement(By.xpath("/html/body/div[2]/table/tbody/tr[2]/td[6]")).getText());
//
//
////        driver.get("http://192.168.2.119:8084/GisqQueryList/views/reports/realestate/common/acceptance/Acceptance_HouseRight_Initial.jsp?reportlet=realestate/common/acceptance/Acceptance_HouseRight_Initial.cpt&op=write&BDFR_GUID=f186c61b-e05d-11e5-8188-000c29187a9e&ID=f615fd12-4adb-11e9-af86-00505683a231&CATEGORY=BDC03&RECORDNUMBER=4b3b8191-8e79-444e-b56d-882077d12f60&BIZDEF_GUID=f18677f1-e05d-11e5-8188-000c29187a9e&BIZINST_GUID=f58c0c88-4adb-11e9-af86-00505683a231&TYPE=form&userId=67589262-9481-11e8-9b9e-00505683a231&TRANSACTOR=%E7%8E%8B%E5%B2%A9&aid=sid-075095F3-5F75-4295-B4D1-5843F0D20C8E&ACTDEFID=sid-075095F3-5F75-4295-B4D1-5843F0D20C8E&tid=f41fd278-4adb-11e9-b523-00505683a231&ACTINSTID=f41fd278-4adb-11e9-b523-00505683a231&pid=2d107839-0de3-11e6-b878-000c2984e60c&PRODEFID=2d107839-0de3-11e6-b878-000c2984e60c&instid=f41b1782-4adb-11e9-b523-00505683a231&PROINSTID=f41b1782-4adb-11e9-b523-00505683a231&businesskey=20190320-0003502&PROJECTID=20190320-0003502&LCBM=2101&HJDM=SJ&XZQBM=3314&task_state=null");
//
////        try {
//            WebElement elementYJ = driver.findElement(By.id("btnComplete"));
//           elementYJ.click();
//            WebDriver webTransfer = driver.switchTo().frame("ifTransmit");//移交页面，选择人员
//            List<WebElement> elementTransferAs = webTransfer.findElements(By.xpath("//div[@class='tabTitle']"));
//          System.out.println("判断一下集合的数目"+elementTransferAs.get(0).getAttribute("innerText").toString());
//
//
//            if (elementTransferAs != null && elementTransferAs.size() > 0) {
//
//                for (WebElement elementA : elementTransferAs) {
////                    if(elementTransferAs.size()==1&&elementA.getAttribute("innerText").equals("初审")){
////                        System.out.println("判断一下集合的数目"+elementTransferAs.size());
////                        break;
////                    }else
//
//                        if (elementA.getAttribute("innerText").equals("初审")) {
//                            System.out.println("判断可点击："+isContentClick(driver,elementA));
//                            if(isContentClick(driver,elementA)){
//                                elementA.click();
//                            }else{
//                                break;
//                            }
//
//                    }
//                }
//                //最后一个环节的时候不需要选择人员
//                //TODO 2019/02/15增加一个参数作为移交人员的选择;后期采用对接运维接口，用户可以选择的方式
//                try {
//                    WebElement elementYJRY = webTransfer.findElement(By.linkText("王岩"));
//
//                    elementYJRY.click();
//
//
//                } catch (NoSuchElementException er) {
//                    er.getStackTrace();
//                }
//
//            }
//
//            //移交
//            List<WebElement> elementYJSave = webTransfer.findElements(By.xpath("//input[@class='blue_btn']"));
//            for (WebElement element : elementYJSave) {
//                if (element.getAttribute("value").indexOf("转出") > -1 || element.getAttribute("value").indexOf("确定") > -1) {
//
//                    element.click();
//                }
//            }
//            boolean isp = webTransfer.findElement(By.xpath("//*[@class=\"layui-layer layui-anim layui-layer-dialog \"")).isDisplayed();
//        boolean isdisplay=webTransfer.findElement(By.id("layui-layer2")).isDisplayed();
//        //*[@id="layui-layer-shade2"]
//        layui-layer2

//            Thread.sleep(5000);
//        WebDriverWait wait=new WebDriverWait(webTransfer,20);
//        wait.until(ExpectedConditions.visibilityOf(webTransfer.findElement(By.xpath("//*[@id=\"layui-layer2\"]"))));

//        System.out.println("判断是否元素存在：" +isContentAppeared(driver, "//*[@id=\"layui-layer2\"]"));
//        new WebDriverWait(webTransfer,10).until(ExpectedConditions.presenceOfElementLocated(By.xpath("//*[@id=\"layui-layer2\"]")));
//        if (isContentAppeared(driver, "//*[@id=\"layui-layer2\"]")) {
//            System.out.println("文本：" + driver.findElement(By.xpath("//*[@id=\"layui-layer2\"]/div[2]")).getText());
////            Reporter.log("移交异常！转出校验信息为：" + driver.findElement(By.xpath("//*[@id=\"layui-layer2\"]/div[2]")).getText());
//            driver.switchTo().defaultContent();
//            ((JavascriptExecutor) driver).executeScript("closeTaskExt(true)");
//        }
//        driver.switchTo().defaultContent();
//        //driver.manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);
//        Thread.sleep(2000); //等待窗口弹出来
//        WebDriver webSercond = ChangeDriver.change(driver, currentWindow);
//
//        //初审环节处理
//        FirstTrial.execute(webSercond);
//        webSercond.switchTo().defaultContent();
//        WorkFlow.execute(webSercond);

//        System.out.println("判断是否有"+isContentAppeared(driver,"//*[@id=\"layui-layer2\"]"));
//            System.out.println("判断是否元素存在："+ExpectedConditions.presenceOfElementLocated(By.xpath("//*[@id=\"layui-layer2\"]")));
//            if(isContentAppeared(driver,"//*[@id=\"layui-layer2\"]")){
//                System.out.println("文本："+driver.findElement(By.xpath("//*[@id=\"layui-layer2\"]/div[2]")).getText());
//                driver.switchTo().defaultContent();
//                ((JavascriptExecutor) driver).executeScript("closeTaskExt(true)");
//            }
//        boolean isable=webTransfer.findElement(By.id("layui-layer2")).isEnabled();
//        System.out.println("是否显示：" +isable);
//            driver.switchTo().defaultContent();
//
//            String str = webTransfer.findElement(By.xpath("//*[@id=\"layui-layer2\"]/div[1]")).getText();
//            System.out.println("看标题：" + str);
//            System.out.println("判断是否找到：" + webTransfer.findElements(By.xpath("//*[@id=\"layui-layer2\"]/div[1]")).isEmpty());
//        if(webTransfer.findElement(By.xpath("//*[@id=\"layui-layer2\"]/div[3]/a")))
            //判断是否有转出校验窗口
//       }catch (Exception  e){
//           e.printStackTrace();
//       }finally {
//           if (!driver.findElements(By.xpath("//*[@id=\"layui-layer2\"]/div[1]")).isEmpty()){
//               driver.switchTo().defaultContent();
//               ((JavascriptExecutor) driver).executeScript("closeTaskExt(true)");
//           }
//       }






//        webTransfer.findElement(By.xpath("//*[@id=\"layui-layer2\"]/div[1]")).click();

//        driver.get("http://192.168.2.119:8082/GisqPlatformExplorer/a?login");
//
//        WebElement username = driver.findElement(By.id("username"));
//        username.sendKeys("wangy12");
//        WebElement password = driver.findElement(By.id("password"));
//        password.sendKeys("1234");
//        driver.manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);
//        WebElement buttom = driver.findElement(By.className("login_button"));
//        buttom.click();
//
//        driver.switchTo().frame("view_首页0");
//        System.out.println("句柄："+driver.getWindowHandle());
//
//        WebElement fdfj = driver.findElement(By.id("38bcedca-df88-11e5-b408-000c29187a9e"));
//        fdfj.click();
//
//        WebElement scfj = driver.findElement(By.xpath("//a[@pid='2d107839-0de3-11e6-b878-000c2984e60c']"));
//        scfj.click();
//        driver.switchTo().defaultContent();
//        driver.manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);
//        Thread.sleep(5000); //等待窗口弹出来
//        String currentWindow = driver.getWindowHandle();
//        System.out.print("主框架句柄：" + currentWindow);
//
//        WebDriver webNewWindow = ChangeDriver.change(driver, currentWindow);
//        Thread.sleep(10000);
////        webNewWindow.findElement(By.xpath("//*[@id=\"btnClose\"]")).click();
//        ((JavascriptExecutor)webNewWindow).executeScript("closeTaskExt(true)");

//        System.out.println("title:"+driver.getTitle());
//        org.openqa.selenium.interactions.Actions action=new Actions(driver);
//        action.sendKeys(Keys.ENTER).perform();
//        System.out.println("完成");

//        ((JavascriptExecutor)driver).executeScript("window.close();");
//        System.out.println("回车键准备好了");


//
//
//        action.sendKeys(Keys.CANCEL).sendKeys(Keys.F4).perform();
//

//        String function="function closeTaskExt(completed){\n" +
//                "\t\tif(window.opener!=null){\n" +
//                "\t\t\tif(completed==true && window.opener.reloadTask){\n" +
//                "\t\t\topener.reloadTask();\n" +
//                "\t\t\t}\n" +
//                "\t\t}\n" +
//                "\t\twindow.close();\n" +
//                "\t}";
//
//        String scriptResult ="";//脚本的执行结果
//        ScriptEngine engine = new ScriptEngineManager().getEngineByName("nashorn");//1.得到脚本引擎
//
//        try{
//            //2.引擎读取 脚本字符串
//            engine.eval(new StringReader(function));
//            //3.将引擎转换为Invocable，这样才可以掉用js的方法
//            Invocable invocable = (Invocable) engine;
//            //4.使用 invocable.invokeFunction掉用js脚本里的方法，第一個参数为方法名，后面的参数为被调用的js方法的入参
//            scriptResult = (String) invocable.invokeFunction("closeTaskExt", "true");
//
//
//        }catch(ScriptException er){
//            er.printStackTrace();
//            System.out.println("Error executing script: "+ er.getMessage()+" script:["+function+"]");
//
//        }catch (NoSuchMethodException er){
//            er.printStackTrace();
//            System.out.println("Error executing script,为找到需要的方法: "+ er.getMessage()+" script:["+function+"]");
//        }
//        System.out.println(scriptResult.toString());

//        System.out.println("执行完成");


//        driver.navigate().back();

//        driver.get("http://192.168.2.119:8082/GisqPlatformExplorer/a/workflow/taskList/task?aid=sid-075095F3-5F75-4295-B4D1-5843F0D20C8E&tid=a94be2e6-3eeb-11e9-88d0-00505683a231&pid=2d107839-0de3-11e6-b878-000c2984e60c&instid=a93b4110-3eeb-11e9-88d0-00505683a231&businesskey=20190305-0002389&name=&task_name=%E6%94%B6%E4%BB%B6%E5%8F%97%E7%90%86&execution_procDefName=%E9%A6%96%E6%AC%A1%E7%99%BB%E8%AE%B0&task_state=firstTask");
//
//        String str="";
//        str=driver.findElement(By.xpath("//*[@id=\"columntablejqwDatumsGrid\"]/div[2]/div/div[1]/span")).getText();
//        System.out.println("str:"+str);

////          driver.get("http://192.168.2.119:8084/realestate/ReportServer?reportlet=realestate/common/approveform/ApproveFormTD_ZM.cpt&op=write&BDFR_GUID=83d65a25-9cd8-11e5-bb50-305a3a80a2ad&ID=8e87bcf6-52d6-11e9-9d95-00505683a231&CATEGORY=BDC&RECORDNUMBER=62f7fdbc-e35a-4df1-ae24-3cd9dbae856f&BIZDEF_GUID=2f123e13-9986-11e5-86c5-305a3a80a2ad&BIZINST_GUID=8e074242-52d6-11e9-9d95-00505683a231&TYPE=form&userId=67589262-9481-11e8-9b9e-00505683a231&TRANSACTOR=%E7%8E%8B%E5%B2%A9&aid=sid-581BC958-7B39-439A-B5B8-89E680890970&ACTDEFID=sid-581BC958-7B39-439A-B5B8-89E680890970&tid=5f14c2be-5391-11e9-973c-00505683a231&ACTINSTID=5f14c2be-5391-11e9-973c-00505683a231&pid=9bd69816-1efd-11e6-a9dc-0050568c3496&PRODEFID=9bd69816-1efd-11e6-a9dc-0050568c3496&instid=8c3bd0a2-52d6-11e9-973c-00505683a231&PROINSTID=8c3bd0a2-52d6-11e9-973c-00505683a231&businesskey=20190330-0004523&PROJECTID=20190330-0004523&LCBM=9701&HJDM=DB&XZQBM=3314&task_state=null");
//        WebDriver webNewWindow = ChangeDriver.change(driver, currentWindow);
////        webNewWindow.switchTo().defaultContent();
//         WebDriver driverFilePage = webNewWindow.switchTo().frame("clientContainer");
////         driver.switchTo().frame("clientContainer");
//        Thread.sleep(5000);
//        driverFilePage.switchTo().frame(driver.findElement(By.xpath("//*[@id=\"TAB_IF_8e87bcf6-52d6-11e9-9d95-00505683a231\"]")));
//        driverFilePage.findElement(By.xpath("//*[@id=\"content-container\"]/div[2]/div[2]/div/div/table/tbody/tr/td[2]/div/table/tbody/tr/td[1]/div")).click();
//          Thread.sleep(5000);
//          String js = "contentPane.curLGP.setCellValue(contentPane.curLGP.write.getWidgetByName(\"HDYJ\").options.location,\"核定意见\");";
//          String js1 = "contentPane.curLGP.setCellValue(contentPane.curLGP.write.getWidgetByName(\"HDFZR\").options.location,\"你好四月\");";
//        String js2 = "contentPane.curLGP.setCellValue(contentPane.curLGP.write.getWidgetByName(\"HDRQ\").options.location,\"2019年3月31日\");";
//        ((JavascriptExecutor) driverFilePage).executeScript(js);
//        ((JavascriptExecutor) driverFilePage).executeScript(js1);
//        ((JavascriptExecutor) driverFilePage).executeScript(js2);
//        System.out.println("写入完成");
//        driverFilePage.findElement(By.xpath("//*[@id=\"fr-btn-\"]/tbody/tr[2]/td[2]/em/button"));
//        System.out.println("点击保存完成");

//


//        driver.get("http://192.168.2.119:8084/GisqQueryList/views/reports/realestate/common/acceptance/Acceptance_HouseRight_Initial.jsp?reportlet=realestate/common/acceptance/Acceptance_HouseRight_Initial.cpt&op=write&BDFR_GUID=f186c61b-e05d-11e5-8188-000c29187a9e&ID=4fb643a2-3317-11e9-a606-00505683a231&CATEGORY=BDC03&RECORDNUMBER=8dd70d3b-498e-41ab-bdb8-6300dbc48819&BIZDEF_GUID=f18677f1-e05d-11e5-8188-000c29187a9e&BIZINST_GUID=47b57768-3317-11e9-a606-00505683a231&TYPE=form&userId=839e28f6-332f-11e8-aee8-00505683a231&TRANSACTOR=%E9%A9%AC%E6%96%8C%E5%80%A9&aid=sid-075095F3-5F75-4295-B4D1-5843F0D20C8E&ACTDEFID=sid-075095F3-5F75-4295-B4D1-5843F0D20C8E&tid=451a5a85-3317-11e9-88d0-00505683a231&ACTINSTID=451a5a85-3317-11e9-88d0-00505683a231&pid=2d107839-0de3-11e6-b878-000c2984e60c&PRODEFID=2d107839-0de3-11e6-b878-000c2984e60c&instid=4518108f-3317-11e9-88d0-00505683a231&PROINSTID=4518108f-3317-11e9-88d0-00505683a231&businesskey=20190218-0001485&PROJECTID=20190218-0001485&LCBM=2101&HJDM=SJ&XZQBM=3314&task_state=firstTask");
            //表单调试
//         driver.get("http://192.168.2.119:8084/realestate/ReportServer?reportlet=realestate/leaseHold/common/ApproveForm_Z.cpt&op=write&PROJECTID=20190218-0001551&spbzl=2&lcbm=8201&userId=839e28f6-332f-11e8-aee8-00505683a231&PROINSTID=4d6491ec-3344-11e9-88d0-00505683a231&ACTDEFID=sid-2179c452-1f00-11e9-9cb9-00505683a231&BDFR_GUID=0abaaf22-188e-11e9-b0f7-00505683a231&TRANSACTOR=%E9%A9%AC%E6%96%8C%E5%80%A9&hjdm=CS&djlx=&BIZDEF_GUID=08e50498-188e-11e9-b0f7-00505683a231&BIZINST_GUID=4ea4da03-3344-11e9-a606-00505683a231&aid=sid-2179c452-1f00-11e9-9cb9-00505683a231");
//            driver.get("http://192.168.2.119:8084/realestate/ReportServer?reportlet=realestate/common/approveform/ApproveForm.cpt&op=write&BDFR_GUID=f186c615-e05d-11e5-8188-000c29187a9e&ID=d8b1c905-3e26-11e9-a606-00505683a231&CATEGORY=BDC03&RECORDNUMBER=b7ee29c2-b37b-4f2e-b1b9-c964cfe5dee3&BIZDEF_GUID=f18677f1-e05d-11e5-8188-000c29187a9e&BIZINST_GUID=d8066dad-3e26-11e9-a606-00505683a231&TYPE=form&userId=67589262-9481-11e8-9b9e-00505683a231&TRANSACTOR=%E7%8E%8B%E5%B2%A9&aid=sid-EB9DF64C-1CF1-495C-B7FE-906BCDD56F7C&ACTDEFID=sid-EB9DF64C-1CF1-495C-B7FE-906BCDD56F7C&tid=ca8779b4-4496-11e9-855a-00505683a231&ACTINSTID=ca8779b4-4496-11e9-855a-00505683a231&pid=2d107839-0de3-11e6-b878-000c2984e60c&PRODEFID=2d107839-0de3-11e6-b878-000c2984e60c&instid=d4e1d506-3e26-11e9-88d0-00505683a231&PROINSTID=d4e1d506-3e26-11e9-88d0-00505683a231&businesskey=20190304-0002328&PROJECTID=20190304-0002328&LCBM=2101&HJDM=FS&XZQBM=3314&task_state=null");
//            Thread.sleep(5000);
//            driver.findElement(By.xpath("//*[@id=\"content-container\"]/div[2]/div[2]/div/div/table/tbody/tr/td[2]/div/table/tbody/tr/td[1]/div")).click();
//
////        String js = "contentPane.curLGP.setCellValue(\"C5\",null,\"你好\");" ;
//            String js = "contentPane.curLGP.setCellValue(contentPane.curLGP.write.getWidgetByName(\"GTCSYJ\").options.location,\"你好四月\");";
//            ((JavascriptExecutor) driver).executeScript(js);
//            driver.findElement(By.xpath("//*[@id=\"fr-btn-\"]/tbody/tr[1]/td[2]"));
//            driver.navigate().refresh();
//            Thread.sleep(5000);
//            driver.findElement(By.xpath("//*[@id=\"content-container\"]/div[2]/div[2]/div/div/table/tbody/tr/td[2]/div/table/tbody/tr/td[1]/div")).click();
//       System.out.println("切换一下啊");
//       driver.findElement(By.xpath("/html/body/div[1]/div[1]/div[2]/div/div[2]/span[1]/div/span")).click();
//       Thread.sleep(5000);
//       System.out.println("切换到第二页");
//       driver.findElement(By.xpath("/html/body/div[1]/div[1]/div[2]/div/div[2]/span[2]/div/span")).click();
//       String js = "contentPane.curLGP.setCellValue(\"C5\",null,\"你好\");" ;
////       Thread.sleep(5000);
//       driver.navigate().refresh();
//       Thread.sleep(5000);
////       String js1="contentPane.setCellValue(\"C5\",null,\"你好\");" ;
////       driver.findElement(By.xpath("//*[@id=\"content-container\"]/div[2]/div[2]/div/div/table/tbody/tr/td[2]/div/table/tbody/tr/td[1]/div")).click();
////       System.out.println("切换一下意见页");
//        driver.navigate().refresh();
//        Thread.sleep(5000);
//        driver.findElement(By.xpath("//*[@id=\"content-container\"]/div[2]/div[2]/div/div/table/tbody/tr/td[2]/div/table/tbody/tr/td[1]/div")).click();
//        Thread.sleep(5000);
//
//       String js2="contentPane.curLGP.setCellValue(contentPane.curLGP.write.getWidgetByName(\"GTCSYJ\")" +
//               ".options.location,\"你好1231\");";
//        System.out.println("帆软2");
//        ((JavascriptExecutor) driver).executeScript(js2);
//        Object resultName;
//        String js = " return contentPane.getWidgetByName(\"GTCSYJ\").getValue();" ;
//        resultName=((JavascriptExecutor)driver).executeScript(js);
//        System.out.println("看一下结果："+resultName.toString());
            //循环办件调试
//     driver.get("http://192.168.2.119:8082/GisqPlatformExplorer/a/login;JSESSIONID=7a22b82495884077a7860a3b86e8ac2f");
//        WebElement username = driver.findElement(By.id("username"));
//        username.sendKeys("wangy12");
//
//        WebElement password = driver.findElement(By.id("password"));
//        password.sendKeys("1234");
//        driver.manage().timeouts().implicitlyWait(2, TimeUnit.SECONDS);
//        WebElement buttom = driver.findElement(By.className("login_button"));
//        buttom.click();
//        Thread.sleep(2000);
//        WebElement elementGZZX = driver.findElement(By.linkText("工作中心"));
//        elementGZZX.click();
//        Thread.sleep(5000);
//        WebElement elementPopMenu = driver.findElement(By.xpath("//div[@class='PopupMenu']"));
//        List<WebElement> allFuncitem = driver.findElements(By.xpath("//span[@class='menu_level_0']"));
//        for (WebElement elementFunction : allFuncitem) {
//            if (elementFunction.getAttribute("innerText").equals("首页")) {
//                elementFunction.click();
//                break;
//            }
//        }
//
//        //测试断言
//        driver.get("http://192.168.2.119:8084/GisqQueryList/views/reports/realestate/common/acceptance/Acceptance_HouseRight_Initial.jsp?reportlet=realestate/common/acceptance/Acceptance_HouseRight_Initial.cpt&op=write&BDFR_GUID=f186c61b-e05d-11e5-8188-000c29187a9e&ID=8f6938cd-3697-11e9-a606-00505683a231&CATEGORY=BDC03&RECORDNUMBER=383f76e4-02ec-4b96-8c99-093fd9cb2b47&BIZDEF_GUID=f18677f1-e05d-11e5-8188-000c29187a9e&BIZINST_GUID=8eda6643-3697-11e9-a606-00505683a231&TYPE=form&userId=67589262-9481-11e8-9b9e-00505683a231&TRANSACTOR=%E7%8E%8B%E5%B2%A9&aid=sid-075095F3-5F75-4295-B4D1-5843F0D20C8E&ACTDEFID=sid-075095F3-5F75-4295-B4D1-5843F0D20C8E&tid=8d4f3241-3697-11e9-88d0-00505683a231&ACTINSTID=8d4f3241-3697-11e9-88d0-00505683a231&pid=2d107839-0de3-11e6-b878-000c2984e60c&PRODEFID=2d107839-0de3-11e6-b878-000c2984e60c&instid=8d48064b-3697-11e9-88d0-00505683a231&PROINSTID=8d48064b-3697-11e9-88d0-00505683a231&businesskey=20190222-0001928&PROJECTID=20190222-0001928&LCBM=2101&HJDM=SJ&XZQBM=3314&task_state=firstTask");
////        String a=driver.findElement(By.xpath("/html/body/div[3]/table/tbody/tr[5]/td[3]")).getText();
////        System.out.println("看看："+a);
//
//        captureElement(driver.findElement(By.id("CZRMC")));
//
//        FileUtils.copyFile( captureElement(driver.findElement(By.id("GFHTBH"))),
//                new File("D:\\"+"持证人名称.png"));
//


    }

    public static boolean isContentAppeared(WebDriver driver, String content) {
        boolean status = false;
        try {
//            WebDriverWait wait=new WebDriverWait(driver,10);
//            wait.until(ExpectedConditions.presenceOfElementLocated(By.xpath(content)));
//            wait.until(ExpectedConditions.visibilityOfAllElementsLocatedBy(By.xpath(content)));
            driver.findElement(By.xpath(content));
            System.out.println(content + " is appeard!");
            status = true;
        } catch (NoSuchElementException e) {
            status = false;
            System.out.println("'" + content + " doesn't exist!");
        }
        return status;
    }

    public static boolean isContentClick(WebDriver driver, WebElement element) {
        boolean status = false;
        try {
            WebDriverWait wait=new WebDriverWait(driver,10);
            wait.until(ExpectedConditions.visibilityOf(element));
            wait.until(ExpectedConditions.elementToBeClickable(element));
            element.click();
            System.out.println(element + " is clicked!");
            status = true;
        } catch (Exception e) {

            status = false;
            System.out.println("'" + element + " doesn't clicked!");
        }
        return status;
    }


    public static void getFRvalue(WebDriver driver ,String cellName) {
        Object resultName;
        String js = " return contentPane.getWidgetByName(\""+cellName+"\").getValue();" ;
        resultName=((JavascriptExecutor)driver).executeScript(js);
        System.out.println("看一下结果："+resultName.toString());
    }

}
