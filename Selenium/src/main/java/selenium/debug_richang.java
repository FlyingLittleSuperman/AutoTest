package selenium;

import javafx.scene.shape.Rectangle;
import org.openqa.selenium.*;
import org.openqa.selenium.Point;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.chrome.ChromeDriverService;
import org.openqa.selenium.chrome.ChromeOptions;
import org.openqa.selenium.internal.WrapsDriver;

import javax.imageio.ImageIO;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;

/**
 * @author wangyan
 * @date 2019-02-18  上午 08:59
 */
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


    public static void main(String[] args) throws Exception {
//        TestNG testNG=new TestNG();
//        Class[] classes={ TestCase.class};
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
        driver.get("http://192.168.2.119:8082/GisqPlatformExplorer/a/workflow/taskList/task?aid=sid-075095F3-5F75-4295-B4D1-5843F0D20C8E&tid=a94be2e6-3eeb-11e9-88d0-00505683a231&pid=2d107839-0de3-11e6-b878-000c2984e60c&instid=a93b4110-3eeb-11e9-88d0-00505683a231&businesskey=20190305-0002389&name=&task_name=%E6%94%B6%E4%BB%B6%E5%8F%97%E7%90%86&execution_procDefName=%E9%A6%96%E6%AC%A1%E7%99%BB%E8%AE%B0&task_state=firstTask");
//
//        String str="";
//        str=driver.findElement(By.xpath("//*[@id=\"columntablejqwDatumsGrid\"]/div[2]/div/div[1]/span")).getText();
//        System.out.println("str:"+str);
//




//////        driver.get("http://192.168.2.119:8084/GisqQueryList/views/reports/realestate/common/acceptance/Acceptance_HouseRight_Initial.jsp?reportlet=realestate/common/acceptance/Acceptance_HouseRight_Initial.cpt&op=write&BDFR_GUID=f186c61b-e05d-11e5-8188-000c29187a9e&ID=4fb643a2-3317-11e9-a606-00505683a231&CATEGORY=BDC03&RECORDNUMBER=8dd70d3b-498e-41ab-bdb8-6300dbc48819&BIZDEF_GUID=f18677f1-e05d-11e5-8188-000c29187a9e&BIZINST_GUID=47b57768-3317-11e9-a606-00505683a231&TYPE=form&userId=839e28f6-332f-11e8-aee8-00505683a231&TRANSACTOR=%E9%A9%AC%E6%96%8C%E5%80%A9&aid=sid-075095F3-5F75-4295-B4D1-5843F0D20C8E&ACTDEFID=sid-075095F3-5F75-4295-B4D1-5843F0D20C8E&tid=451a5a85-3317-11e9-88d0-00505683a231&ACTINSTID=451a5a85-3317-11e9-88d0-00505683a231&pid=2d107839-0de3-11e6-b878-000c2984e60c&PRODEFID=2d107839-0de3-11e6-b878-000c2984e60c&instid=4518108f-3317-11e9-88d0-00505683a231&PROINSTID=4518108f-3317-11e9-88d0-00505683a231&businesskey=20190218-0001485&PROJECTID=20190218-0001485&LCBM=2101&HJDM=SJ&XZQBM=3314&task_state=firstTask");
//    //表单调试
//       driver.get("http://192.168.2.119:8084/realestate/ReportServer?reportlet=realestate/leaseHold/common/ApproveForm_Z.cpt&op=write&PROJECTID=20190218-0001551&spbzl=4&lcbm=8201&userId=839e28f6-332f-11e8-aee8-00505683a231&PROINSTID=4d6491ec-3344-11e9-88d0-00505683a231&ACTDEFID=sid-2179c452-1f00-11e9-9cb9-00505683a231&BDFR_GUID=0abaaf22-188e-11e9-b0f7-00505683a231&TRANSACTOR=%E9%A9%AC%E6%96%8C%E5%80%A9&hjdm=CS&djlx=&BIZDEF_GUID=08e50498-188e-11e9-b0f7-00505683a231&BIZINST_GUID=4ea4da03-3344-11e9-a606-00505683a231&aid=sid-2179c452-1f00-11e9-9cb9-00505683a231");
//       driver.findElement(By.xpath("/html/body/div[1]/div[1]/div[2]/div/div[2]/span[2]/div/span")).click();
//       Thread.sleep(5000);
//       driver.findElement(By.xpath("//*[@id=\"content-container\"]/div[2]/div[2]/div/div/table/tbody/tr/td[2]/div/table/tbody/tr/td[1]/div")).click();
//       String js = "contentPane.curLGP.setCellValue(\"C5\",null,\"你好\");" ;
//       Thread.sleep(5000);
//       driver.navigate().refresh();
//       String js1="contentPane.setCellValue(\"C5\",null,\"你好\");" ;
//       driver.findElement(By.xpath("//*[@id=\"content-container\"]/div[2]/div[2]/div/div/table/tbody/tr/td[2]/div/table/tbody/tr/td[1]/div")).click();
//       String js2="contentPane.curLGP.setCellValue(contentPane.curLGP.write.getWidgetByName(\"GTCSYJ\").options.location,\"你好1231\");";
//        System.out.println("帆软2");
//        ((JavascriptExecutor) driver).executeScript(js2);
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
}
