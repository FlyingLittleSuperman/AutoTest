package util;

import WinForm.showReports.ScreenShootUtils;
import configSelenium.InitCommonParameter;
import org.apache.commons.io.FileUtils;
import org.openqa.selenium.*;
import org.testng.Reporter;

import java.io.File;
import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.concurrent.TimeUnit;

import static configSelenium.ConfigSeleniumStart.shootChildList;

/**
 * @author wangyan
 * @date 2019-03-08  上午 09:10
 *
 * 将截图功能从case里面拆出来
 */
public class Screenshoot {



    public static void getShoot(WebDriver driver, String shootname ) throws InterruptedException, IOException {

        List<ScreenShootUtils> shootChildren=new ArrayList<>();



        Date da = new Date();
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd HH:mm");
        String ds = sdf.format(da).substring(10).replace(":", "_");

        String prodefid = InitCommonParameter.prodefid;
        String childprodefid = InitCommonParameter.childprodefid;


        String path=Path.shootPath();
        String filename=shootname;

        File f = new File(path);


        if (!f.exists()) {
            f.mkdir();
        }
        driver.manage().timeouts().pageLoadTimeout(10, TimeUnit.SECONDS);

        Object js1_result;
        String real_top, real_scroll_h;
        String js1 = "return document.body.scrollHeight.toString()+','+document.body.scrollTop.toString()";
        js1_result = ((JavascriptExecutor) driver).executeScript(js1);
        real_scroll_h = js1_result.toString().split(",")[0];
        real_top = js1_result.toString().split(",")[1];

        if (Integer.valueOf(real_top) != 0) {
            ((JavascriptExecutor) driver).executeScript("window.scrollTo(document.body.scrollHeight,0)");
        }

        File scrFile = ((TakesScreenshot) driver).getScreenshotAs(OutputType.FILE);
        FileUtils.copyFile(scrFile, new File(path+"/"+filename + ".png"));

        String abstr= f.getAbsolutePath()+"/"+ filename+".png";
        String str= path+"/"+ filename+".png";
        ScreenShootUtils  schild = new ScreenShootUtils();
        schild.setChildId(prodefid + DateUtils.getDate());
        schild.setChildName(filename);
        schild.setChildPath(str);
        shootChildList.add(schild);
        System.out.println("查看一下截图集合的值："+shootChildList.size());

        Reporter.log(filename+"<br/><img src=\""+ abstr +"\""+"  hight=\"300\" width=\"300\"  onclick=\"javascript:window.open(this.src);\"/>");

        String setscroll;
        int height = 0;


        for (int i = 1; i < (Integer.valueOf(real_scroll_h) / 400) ; i++) {
            ScreenShootUtils  schild1 = new ScreenShootUtils();

            if (height > Integer.valueOf(real_scroll_h) || Integer.valueOf(real_scroll_h) < 750) {

                break;

            } else {

                Thread.sleep(1000);
                height = i * 450;
                setscroll = "document.body.scrollTop=" + height;
                JavascriptExecutor jse = (JavascriptExecutor) driver;
                jse.executeScript("0," + setscroll);
                Thread.sleep(1000);
                File scrFile1 = ((TakesScreenshot) driver).getScreenshotAs(OutputType.FILE);

                FileUtils.copyFile(scrFile1, new File(path+"/"+filename+"("+ (i + 1) + ")"+".png"));
                String abstr1= f.getAbsolutePath()+"/"+ filename+"("+(i + 1)+")"+".png";
                String str1= path+"/"+ filename+"("+(i + 1)+")"+".png";
                schild1.setChildId(prodefid + DateUtils.getDate());
                schild1.setChildName(filename+"("+(i + 1)+")");

                schild1.setChildPath(str1);
                shootChildList.add(schild1);

                Reporter.log(filename+"("+(i + 1)+")"+"<br/><img src=\""+ abstr1 +"\""+ "  hight=\"300\" width=\"300\" onclick=\"javascript:window.open(this.src);\" />");

            }



        }



    }
}
