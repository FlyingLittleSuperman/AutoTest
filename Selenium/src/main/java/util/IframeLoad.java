package util;

import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.WebDriver;

/**
 * Created by Administrator on 2016/12/15.
 */
public class IframeLoad {

    /**
     * 等待iframe加载完成
     *
     * @param driver
     * @param iframeId
     */
    public static void WaitIframeLoad(WebDriver driver, String iframeId) {
        /*String tempJs = "var iframe1 = document.getElementById('"+iframeId+"'); alert(iframe1);";
        ((JavascriptExecutor) driver).executeScript(tempJs);*/

        String js = "$(\"#" + iframeId + "\").load(function() { \n" +
                "isOnLoad = false;\n" +
                "alert('load success'); \n" +
                "}); ";
        ((JavascriptExecutor) driver).executeScript(js);
    }

}
