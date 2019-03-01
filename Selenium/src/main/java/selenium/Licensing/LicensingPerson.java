package selenium.Licensing;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedCondition;
import org.openqa.selenium.support.ui.Select;
import org.openqa.selenium.support.ui.WebDriverWait;

import java.util.List;

/**
 * Created by Administrator on 2016/12/14.
 */
public class LicensingPerson {
    public static void execute(WebDriver driver) {
        WebDriverWait wait = new WebDriverWait(driver, 10); // 最多等10秒
        List<WebElement> elementLZR = wait.until(new ExpectedCondition<List<WebElement>>() {
            public List<WebElement> apply(WebDriver d) {
                return d.findElements(By.id("LZRMC"));
            }
        });

        for (WebElement element : elementLZR) {
            element.sendKeys("倪明奇测试林证人");
        }

        List<WebElement> elementLZRZJLX = driver.findElements(By.id("LZRZJLX"));
        for (WebElement element : elementLZRZJLX) {
            Select select = new Select(element);
            select.selectByValue("2");
        }

        List<WebElement> elemenntLZRZJH = driver.findElements(By.id("LZRZJH"));
        for (WebElement element : elemenntLZRZJH) {
            element.sendKeys("倪明奇测试林证人证件号");
        }
        List<WebElement> elemenntLXDH = driver.findElements(By.id("lxdh"));
        for (WebElement element : elemenntLXDH) {
            element.sendKeys("13985478596");
        }

        List<WebElement> elementAllButtons = driver.findElements(By.xpath("//button[@type='button']"));
        for (WebElement elemntButton : elementAllButtons) {
            if (elemntButton.getAttribute("innerText").indexOf("保存") > -1) {
                elemntButton.click();
            }
        }
    }
}
