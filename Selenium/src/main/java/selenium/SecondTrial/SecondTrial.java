package selenium.SecondTrial;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import selenium.common.ApproveForm;
import util.TrialEnum;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Administrator on 2016/12/13.
 */
public class SecondTrial {
    public static void execute(WebDriver driver) {
        try {
            driver.switchTo().defaultContent();
            WebDriver driverFileBage = driver.switchTo().frame("clientContainer");
            WebElement elementSQXX = driverFileBage.findElement(By.xpath("//a[@title='审批表']"));
            elementSQXX.click();
            List<WebElement> allElement = driverFileBage.findElements(By.tagName("iframe"));

            for (WebElement element : allElement) {
                try {
                    String src1 = element.getAttribute("src1");
                    String id = element.getAttribute("id");
                    //初审环节
                    if (src1.indexOf("ApproveForm_TZ.cpt") > -1) {
                        Thread.sleep(2000);
                        WebDriver driverApproveFrom = driverFileBage.switchTo().frame(id);
                        List<TrialEnum> trialEnumList = new ArrayList<TrialEnum>();
                        trialEnumList.add(TrialEnum.复审);
                        ApproveForm.ApproveForm(driverApproveFrom, trialEnumList);
                    }
                } catch (Exception er) {
                    er.printStackTrace();
                }
            }
        } catch (Exception er) {
            er.printStackTrace();
        }
    }
}
