package selenium.FirstTrial;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import selenium.CollectFees.RegisterCharge;
import selenium.common.ApproveForm;
import util.TrialEnum;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Administrator on 2016/12/13.
 */
public class FirstTrial {

    public static void execute(WebDriver driver) {
        try {
            WebDriver driverFileBage = driver.switchTo().frame("clientContainer");
            List<WebElement> allElement = driverFileBage.findElements(By.tagName("iframe"));
            for (WebElement element : allElement) {
                try {
                    String src1 = element.getAttribute("src1");
                    String id = element.getAttribute("id");
                    //收费环节
                    if (src1.indexOf("rChargeServer") > -1) {
                        WebDriver driverRegisterCharge = driverFileBage.switchTo().frame(id);
                        RegisterCharge.RegisterCharge(driverRegisterCharge);
                    }
                } catch (Exception er) {
                    er.printStackTrace();
                }
            }

            driver.switchTo().defaultContent();
            driverFileBage = driver.switchTo().frame("clientContainer");
            WebElement elementSQXX = driverFileBage.findElement(By.xpath("//a[@title='审批表']"));
            elementSQXX.click();
            allElement = driverFileBage.findElements(By.tagName("iframe"));

            for (WebElement element : allElement) {
                try {
                    String src1 = element.getAttribute("src1");
                    String id = element.getAttribute("id");
                    //初审环节
                    if (src1.indexOf("ApproveForm_TZ.cpt") > -1) {
                        /*WebElement elementSPB = driverFileBage.findElement(By.id(id));
                        elementSPB.click();*/
                        Thread.sleep(2000);
                        WebDriver driverApproveFrom = driverFileBage.switchTo().frame(id);
                        List<TrialEnum> trialEnumList = new ArrayList<TrialEnum>();
                        trialEnumList.add(TrialEnum.初审);
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
