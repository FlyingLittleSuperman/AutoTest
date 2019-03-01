package selenium.RegBook;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedCondition;
import org.openqa.selenium.support.ui.WebDriverWait;

import java.util.List;

/**
 * Created by Administrator on 2016/12/14.
 */
public class RegisterBook {

    public static void execute(WebDriver driver) throws Exception {
        WebDriverWait wait = new WebDriverWait(driver, 5); // 最多等10秒
        List<WebElement> elementAllButton = wait.until(new ExpectedCondition<List<WebElement>>() {
            public List<WebElement> apply(WebDriver d) {
                return d.findElements(By.xpath("//button[@type='button']"));
            }
        });

        for (WebElement element : elementAllButton) {
            if (element.getAttribute("innerText").indexOf("保存") > -1) {
                element.click();
            }
        }
        Thread.sleep(2000);
        for (WebElement element : elementAllButton) {
            if (element.getAttribute("innerText").indexOf("确认登簿") > -1) {
                element.click();
            }
        }
        WebElement elemeent = driver.findElement(By.xpath("//div[@class='btnSure novTime']"));
        elemeent.click();

        Thread.sleep(5000);
    }
}
