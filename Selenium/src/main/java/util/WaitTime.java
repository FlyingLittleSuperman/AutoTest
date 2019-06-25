package util;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

import javax.xml.bind.Element;

/**
 * @author wangyan
 * @date 2019-03-19  上午 11:07
 */
public class WaitTime {


    public  static void getWaitTime(WebDriver driver,Integer time){

        WebDriverWait wait=new WebDriverWait(driver,time);


    }

    public static void getElementVisi(WebDriver driver, Integer time, WebElement element){

        WebDriverWait wait=new WebDriverWait(driver,time);
        wait.until(ExpectedConditions.visibilityOf(element));

    }

    public static void getElementpresen(WebDriver driver, Integer time, String  path){

        WebDriverWait wait=new WebDriverWait(driver,time);
        wait.until(ExpectedConditions.presenceOfElementLocated(By.xpath(path)));

    }
    public static void getElementclick(WebDriver driver, Integer time, WebElement element){

        WebDriverWait wait=new WebDriverWait(driver,time);
        wait.until(ExpectedConditions.elementToBeClickable(element));

    }
}
