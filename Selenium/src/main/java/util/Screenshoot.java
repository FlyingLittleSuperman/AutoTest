package util;

import configSelenium.InitCommonParameter;
import org.apache.commons.io.FileUtils;
import org.openqa.selenium.*;
import org.testng.Reporter;

import java.io.File;
import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Date;

/**
 * @author wangyan
 * @date 2019-03-08  上午 09:10
 *
 * 将截图功能从case里面拆出来
 */
public class Screenshoot {

    public static void getShoot(WebDriver driver, String shootname ) throws InterruptedException, IOException {


        Date da = new Date();
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd HH:mm");
        String ds = sdf.format(da).substring(10).replace(":", "_");

        String prodefid = InitCommonParameter.prodefid;
        String childprodefid = InitCommonParameter.childprodefid;

        String path=Path.shootPath();
//        String filename=shootname+prodefid+childprodefid+ds;
        String filename=shootname+ds;


        File f = new File(path);

        if (!f.exists()) {
            f.mkdirs();
        }

        System.out.println("file绝对路径："+f.getAbsolutePath());


        Object js1_result;
        String real_top, real_scroll_h;
        String js1 = "return document.body.scrollHeight.toString()+','+document.body.scrollTop.toString()";
        js1_result = ((JavascriptExecutor) driver).executeScript(js1);
        real_scroll_h = js1_result.toString().split(",")[0];
        real_top = js1_result.toString().split(",")[1];
        System.out.println("real_scrol:" + real_scroll_h);
        System.out.println("real_top:" + real_top);
        if (Integer.valueOf(real_top) != 0) {
            ((JavascriptExecutor) driver).executeScript("window.scrollTo(document.body.scrollHeight,0)");
        }
        Thread.sleep(5000);
        File scrFile = ((TakesScreenshot) driver).getScreenshotAs(OutputType.FILE);
        FileUtils.copyFile(scrFile, new File(f.getAbsolutePath()+"\\"+filename + ".png"));
        Thread.sleep(1000);
//        Reporter.log("<img src=" +f.getAbsolutePath()+"\\"+ filename+".png"+ "  onclick='window.open(\"" + filename+ "\")' height='108' width='192'/>");
//        Reporter.log("<img src="+f.getAbsolutePath()+"\\"+ filename+".png>");
        String str= f.getAbsolutePath()+"\\"+ filename+".png";
        Reporter.log(filename);
        Reporter.log("<br/><img src=\""+ str +"\""+"  hight=\"900\" width=\"900\" />");
//        Reporter.log("<img src=\"" +str+ "  onclick=\"window.open(\"+str+ "\)\" height=\"108\" width=\"192\"/>");
        String setscroll;
        int height = 0;


        for (int i = 1; i < (Integer.valueOf(real_scroll_h) / 400) ; i++) {

            if (height > Integer.valueOf(real_scroll_h) || Integer.valueOf(real_scroll_h) < 750) {

                break;

            } else {

                Thread.sleep(5000);
                height = i * 450;
                setscroll = "document.body.scrollTop=" + height;
                JavascriptExecutor jse = (JavascriptExecutor) driver;
                jse.executeScript("0," + setscroll);
                Thread.sleep(5000);
                File scrFile1 = ((TakesScreenshot) driver).getScreenshotAs(OutputType.FILE);

                FileUtils.copyFile(scrFile1, new File(f.getAbsolutePath()+"\\"+filename+"("+ (i + 1) + ")"+".png"));
                String str1= f.getAbsolutePath()+"\\"+ filename+"("+(i + 1)+")"+".png";
                Reporter.log(filename+"("+(i + 1)+")");
                Reporter.log("<br/><img src=\""+ str1 +"\""+ "  hight=\"900\" width=\"900\"  />");


            }
            System.out.println("i:" + i);
            System.out.println("height:" + height);

        }

    }
}
