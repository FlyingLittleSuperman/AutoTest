package util;


import java.io.File;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Timer;

/**
 * @author wangyan
 * @date 2019-03-08  上午 10:07
 */
public class Path {
    static Date da = new Date();
    static SimpleDateFormat day = new SimpleDateFormat("yyyy-MM-dd ");
    static SimpleDateFormat min = new SimpleDateFormat("yyyy-MM-dd HH:mm");
    static String dirPath=System.getProperty("user.dir");



    public  static void main(String[] args){

        String ds=min.format(da).substring(10).replace(":","_").trim();
       System.out.println(ds);

    }


    //截图路径
    public  static String  shootPath(){
        String sp=dirPath+"\\SootScreens\\"+day.format(da).trim();
        return sp;
    }

    //报告路径
    public static String  reportPath(){
        String rp=dirPath+"\\AutoTest_Reports\\"+day.format(da).trim()+"\\"+min.format(da).substring(10).replace(":","_").trim();
        return rp;

    }

    //帆软表单输出路径
    public static String FRPath(){
        String fp=dirPath+"\\FR\\"+day.format(da).trim();
        return fp;
    }
}
