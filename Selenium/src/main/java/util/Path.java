package util;


import configSelenium.StaticValue;

import java.io.File;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Timer;


/**
 * @author wangyan
 * @date 2019-03-08  上午 10:07
 */
public class Path {
    public static Date da = new Date();
    public static SimpleDateFormat day = new SimpleDateFormat("yyyy-MM-dd ");
    public static SimpleDateFormat min = new SimpleDateFormat("yyyy-MM-dd HH:mm");
    public static SimpleDateFormat ss = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
    public static String dirPath=System.getProperty("user.dir");
    public static String date=day.format(da).trim()+"\\"+min.format(da).substring(10).replace(":","_").trim();


    public  static void main(String[] args){

        String ds=min.format(da).trim();
       System.out.println(ds);
    }


    //截图路径
    public  static String  shootPath(){
        String sp=".\\AutoTest_Reports\\"+date+"\\SootScreens";
        return sp;
    }

    //报告路径
    public static String  reportPath(){
        String rp= dirPath+"\\AutoTest_Reports\\"+date;
        return rp;

    }
    public static String  FananreportPath(){
        String rp= ".\\AutoTest_Reports\\"+date;
        return rp;

    }



    //帆软表单输出路径
    public static String FRPath(){
        String fp=".\\AutoTest_Reports\\"+date+"\\FR";
        return fp;
    }



//    public static String elementshotPath(){
//        String ep=".\\"+Path.reportPath()+"/Elementshoot/";
//        return ep;
//    }
}
