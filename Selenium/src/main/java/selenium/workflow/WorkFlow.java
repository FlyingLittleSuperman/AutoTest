package selenium.workflow;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;

import java.util.List;

/**
 * Created by Administrator on 2016/12/13.
 */
public class WorkFlow {

    public static void execute(WebDriver driver) {
        execute(driver, false);
    }

    public static void execute(WebDriver driver, Boolean isLastA) {

        WebElement elementYJ = driver.findElement(By.id("btnComplete"));
        elementYJ.click();

        WebDriver webTransfer = driver.switchTo().frame("ifTransmit");//移交页面，选择人员

        if (!isLastA) {
            //选择人员

            List<WebElement> elementTransferAs = webTransfer.findElements(By.xpath("//div[@class='tabTitle']"));
            for (WebElement elementA : elementTransferAs) {
                if (elementA.getAttribute("innerText").equals("初审")) {
                    elementA.click();
                }
            }
            WebElement elementYJRY = webTransfer.findElement(By.linkText("zscs"));
            elementYJRY.click();
        }

        //移交
        List<WebElement> elementYJSave = webTransfer.findElements(By.xpath("//input[@class='blue_btn']"));
        for (WebElement element : elementYJSave) {
            System.out.println(element.getAttribute("value"));
            if (element.getAttribute("value").indexOf("转出") > -1 || element.getAttribute("value").indexOf("确定") > -1) {
                element.click();
            }
        }
    }


}
