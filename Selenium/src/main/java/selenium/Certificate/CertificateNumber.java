package selenium.Certificate;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedCondition;
import org.openqa.selenium.support.ui.WebDriverWait;

import java.util.List;

/**
 * Created by Administrator on 2016/12/14.
 */
public class CertificateNumber {
    public static void execute(WebDriver driver) throws Exception {
        long code = (long) (Math.random() * 100000000L);
        WebDriverWait wait = new WebDriverWait(driver, 10); // 最多等10秒
        WebElement elementCode = wait.until(new ExpectedCondition<WebElement>() {
            public WebElement apply(WebDriver d) {
                return d.findElement(By.id("txtCode"));
            }
        });
        elementCode.sendKeys("33" + String.format("%09d", code));

        List<WebElement> elements = driver.findElements(By.xpath("//button[@type='button']"));
        for (WebElement element : elements) {
            if (element.getAttribute("innerText").indexOf("保存") > -1) {
                element.click();
            }
        }
        Thread.sleep(2000);
    }
}
