package configSelenium;

import configSelenium.Entity.ProInfo.Actdef;
import configSelenium.Entity.SeleniumTest.SeleniumSchema;
import net.sf.ehcache.CacheManager;
import org.openqa.selenium.WebElement;
import util.LoggerUtils;

import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Random;

/**
 * Created by Administrator on 2016/12/21.
 */
public class StaticValue {
    public static CacheManager cacheManager;
    public static String CommonConfigCacheName="Common";
    public static String InitParameterKeyName ="InitParameter";

    public static String ProdefConfigCacheName="PRODEF";
    public static String InitProdefKeyName ="InitProdef";

    public static String SchemaCacheName="Schema";
    public static String InitSchemaKeyName="InitSchema";

    public static String ExecuteTypeCacheName="ExecuteType";
    public static String InitExecuteTypeKeyName="InitExecuteType";

    public static String SqlConfigCacheName="SQLConfig";
    public static String InitSqlConfigKeyName ="InitSqlConfig";
    public static String InitSqlConfigAllSqlKeyName="InitSqlConfigAllSql";
    public static String InitSqlCondfigColumnValue ="InitSqlConfigColumnValue";


    public static String ApplicationPath=null;

    static{
        if(ApplicationPath==null){
            try {
                String path = ConfigSeleniumStart.class.getProtectionDomain().getCodeSource().getLocation().getPath();
                path = java.net.URLDecoder.decode(path, "UTF-8");
                path = path.replace("/SeleniumJAVA/Selenium.jar","");
                ApplicationPath = path;
            }
            catch (Exception er){
                LoggerUtils.error(er);
            }
        }
    }




    /**
     * 获取URL参数，返回Map对象
     * @param url
     * @return
     */
    public static Map<String,String> getAllRequestParam(String url){
        //String url="http://192.168.7.200:8082/GisqPlatformExplorer/a/workflow/taskList/task?aid=sid-919D701A-D922-4252-8200-16E74FFD5C47&tid=fb92e978-c0ed-11e6-a15e-9c5c8e949727&pid=2d107839-0de3-11e6-b878-000c2984e60c&instid=d6ba14b6-c0ed-11e6-a15e-9c5c8e949727&businesskey=20161213-0039515&name=%E5%80%AA%E6%98%8E%E5%A5%87%E8%87%AA%E5%8A%A8%E5%8C%96%E6%B5%8B%E8%AF%95%E9%A6%96%E6%AC%A1%E7%99%BB%E8%AE%B0&task_name=%E5%88%9D%E5%AE%A1&execution_procDefName=%E9%A6%96%E6%AC%A1%E7%99%BB%E8%AE%B0&processKey=pid-ccce3e0a-89e2-453b-a271-1a9f376f8a9b&HJDM=CS";
        System.out.println("获取所有参数");
        Map<String,String> allRequestParam =new HashMap<String, String>();
        String[] arrUrls= url.split("\\?");
        if(arrUrls.length==1){
            return allRequestParam;
        }
        else{
            String[] arrParams = arrUrls[1].split("&");
            for(String params : arrParams){

                String[] arrKeyAndValue = params.split("=");
                if(arrKeyAndValue.length==1){
                    allRequestParam.put(arrKeyAndValue[0].toUpperCase(),"");
                }
                else{
                    allRequestParam.put(arrKeyAndValue[0].toUpperCase(),arrKeyAndValue[1]);
                }
            }
        }

        return allRequestParam;
    }

    /**
     * 获取指定ID的Actdef信息
     * @param actdefList
     * @param actdefId
     * @return
     */
    public static Actdef GetActdefByIdFromList(List<Actdef> actdefList, String actdefId){
        for(Actdef actdef : actdefList){
            if(actdef.getId().equals(actdefId)) {
                return actdef;
            }
        }
        return null;
    }


    /**
     * 通过URL获取WebElement
     * @param webElementList
     * @param url
     * @return
     */
    public static WebElement GetWebElementByUrlFromList(List<WebElement> webElementList,String url){
        for(WebElement element : webElementList){
            String elementUrl = element.getAttribute("src");
            if(elementUrl!=null && elementUrl.indexOf(url)>-1) {
                return element;
            }
        }
        return null;
    }

    /**
     * 判断流程配置信息是否在方案中
     * @param seleniumSchemaList
     * @param fileName
     * @return
     */
    public static Boolean GetProdefConfigBySchema(List<SeleniumSchema> seleniumSchemaList, String fileName){
        for(SeleniumSchema seleniumSchema : seleniumSchemaList){
            if(seleniumSchema.getFilePath().toUpperCase().equals(fileName.toUpperCase())){
                return true;
            }
        }
        return false;
    }

    /**
     * 获取随机数
     * @return
     */
    public static  Long GetRandomNumber(){
        return GetRandomNumber(5);
    }
    public static Long GetRandomNumber(int length){

        String code ="";
        for (int i=0;i<length;i++){
            code+="0";
        }
        code="1"+code;
        Random random = new Random();

        return GetRandonNumber(length,random,code);
    }

    private static long GetRandonNumber(int length,Random random,String code){
        Long value= new Double(random.nextDouble() * Long.valueOf(code)).longValue();
        if(value.toString().length()!=length) {
            return GetRandonNumber(length, random, code);
        }
        return value;
    }

}
