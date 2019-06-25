package selenium.common;

import org.openqa.selenium.WebDriver;

import java.util.Set;

/**
 * Created by Administrator on 2016/12/13.
 */
public class ChangeDriver {
    public static WebDriver change(WebDriver driver, String currentWindow) throws Exception {
        Set<String> currentThree = driver.getWindowHandles();

        WebDriver webThree = null;
        for (String s : currentThree) {
            if (s.equals(currentWindow)) {
                continue;
            } else {
                webThree = driver.switchTo().window(s);
                break;
            }
        }
        Thread.sleep(2000);
        return webThree;
    }
}
