package selenium.workflow;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;

import java.util.List;

/**
 * Created by Administrator on 2016/12/13.
 */
public class QueryProList {
    public static void execute(WebDriver driver, String projectId) throws Exception {
        WebElement elementGZZX = driver.findElement(By.linkText("工作中心"));
        elementGZZX.click();

        Thread.sleep(1500);
        WebElement elementPopMenu = driver.findElement(By.xpath("//div[@class='PopupMenu']"));
        List<WebElement> allFuncitem = driver.findElements(By.xpath("//span[@class='menu_level_0']"));
        for (WebElement elementFunction : allFuncitem) {
            if (elementFunction.getAttribute("innerText").equals("新收办件")) {
                elementFunction.click();
                break;
            }
        }


        WebDriver driverXJBJ = driver.switchTo().frame("view_新收办件-1");
        Thread.sleep(500);
        List<WebElement> elementBJ = driverXJBJ.findElements(By.xpath("//div[@class='jqx-grid-cell-left-align']"));
        for (WebElement elementNewPJ : elementBJ) {
            if (elementNewPJ.getAttribute("innerText").equals(projectId)) {
                elementNewPJ.click();
                break;
            }
        }
    }
}
