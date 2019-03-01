package util;

import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.WebDriver;

/**
 * Created by Administrator on 2016/12/14.
 */
public class FRValue {
    /**
     * 帆软单元格赋值
     *
     * @param driver
     * @param cellName
     * @param value
     */


    public static void SetFRValue(WebDriver driver, String cellName, String value) throws InterruptedException {

        String js = "contentPane.curLGP.setCellValue(contentPane.curLGP.write.getWidgetByName(\"" + cellName + "\")." +
                "options.location,\"" + value + "\");" ;
//        String js = "var window.FR = options;" +
//                "contentPane.curLGP.setCellValue(co   ntentPane.curLGP.write.getWidgetByName(\"" + cellName + "\")." +
//                "window.FR.location,\"" + value + "\");" +
//                "window.FR = null;";
        System.out.println("帆软");


        ((JavascriptExecutor) driver).executeScript(js);
    }

    public static void SetFRValue2(WebDriver driver, String cellName, String value) throws InterruptedException {

//        String js = "contentPane.curLGP.setCellValue(contentPane.curLGP.write.getWidgetByName(\"" + cellName + "\")." +
//                "options.location,\"" + value + "\");" ;
        String js = "contentPane.setCellValue(\"" + cellName + "\""+",null," +"\""+ value + "\");" ;
//        String js1="contentPane.setCellValue(\"C5\",null,\"你好\");" ;
        System.out.println("帆软2");


        ((JavascriptExecutor) driver).executeScript(js);
    }


}
