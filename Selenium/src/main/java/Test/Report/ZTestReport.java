package Test.Report;
import Test.emailMessage;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import org.testng.*;
import org.testng.annotations.Listeners;
import util.Path;

import java.io.*;
import java.text.SimpleDateFormat;
import java.util.*;
import java.util.regex.Matcher;


import static Test.emailMessage.*;

@Listeners(value = {emailMessage.class})
public class ZTestReport {

//    Map<DoSchemaReportUtil,ITestResult> testResult=new HashMap<DoSchemaReportUtil, ITestResult>();


    //    List<>
    private static long currentTime = System.currentTimeMillis();
    private static  SimpleDateFormat formatter = new SimpleDateFormat ("yyyy年-MM月-dd日-HH时mm分ss秒");
    private static Date date = new Date(currentTime);
    private static String reportdate = formatter.format(date);
    // 定义生成测试报告的路径和文件名，为兼容Windows和Linux此处使用File.separator代替分隔符
    private static String path = System.getProperty("user.dir")+ File.separator+reportdate+".html";
    // 定义html样式模板所在路径
    private static String templatePath = System.getProperty("user.dir")+File.separator+"template";


//    private static String templatePath = ;

    private  static int  testsPass =0 ;

    private  static int testsFail =0 ;



    private static int testsSkip = 0;;

    private static String beginTime;

    private  static long totalTime;

    private static String name = "不动产登记系统自动化测试";
    /**
     public TestReport(){
     long currentTime = System.currentTimeMillis();
     SimpleDateFormat formatter = new SimpleDateFormat ("yyyy年-MM月-dd日-HH时mm分ss秒");
     Date date = new Date(currentTime);
     name = formatter.format(date);
     }

     public TestReport(String name){
     this.name = name;
     if(this.name==null){
     long currentTime = System.currentTimeMillis();
     SimpleDateFormat formatter = new SimpleDateFormat ("yyyy年-MM月-dd日-HH时mm分ss秒");
     Date date = new Date(currentTime);
     this.name = formatter.format(date);
     }
     }
     */


    private ArrayList<ITestResult> listTestResult(IResultMap resultMap) {
        Set<ITestResult> results = resultMap.getAllResults();
        return new ArrayList<ITestResult>(results);
    }

    private void sort(List<ITestResult> list) {
        Collections.sort(list, new Comparator<ITestResult>() {
            @Override
            public int compare(ITestResult r1, ITestResult r2) {
                if (r1.getStartMillis() > r2.getStartMillis()) {
                    return 1;
                } else {
                    return -1;
                }
            }
        });
    }

    public static void output(List<DoSchemaReportUtil> allSchemaResult,String exFanan) throws FileNotFoundException {

            List<ReportInfo> listInfo = new ArrayList<ReportInfo>();
            SimpleDateFormat formatter = new SimpleDateFormat ("yyyy-MM-dd HH:mm:ss.SSS");
            beginTime = formatter.format(new Date());


        for (DoSchemaReportUtil rchild:allSchemaResult) {

            try{
            String status = getSucss(rchild.getFinish());
            ReportInfo info = new ReportInfo();
            info.setName(rchild.getProdefName());
            info.setSpendTime(rchild.getTimeOut());
            info.setStatus(status);
            info.setClassName(rchild.getProdefName());
            info.setMethodName(rchild.getSchemaName());
            info.setDescription(rchild.getYwh());
            info.setLog(rchild.getLog());
            listInfo.add(info);

            Map<String, Object> result = new HashMap<String, Object>();
            result.put("testName", name);
            result.put("testPass", pass);
            result.put("testFail", fail);
            result.put("testSkip", skip);
            result.put("testAll",   pass+skip+fail);
            result.put("beginTime", beginTime);
            result.put("totalTime", totalTime+"ms");
            result.put("testResult", listInfo);
            result.put("filterAll",passed+failed+skiped);
            result.put("filterOk",passed);
            result.put("filterFail",failed);
            result.put("filterSkip",skiped);



            Gson gson = new GsonBuilder().disableHtmlEscaping().setPrettyPrinting().create();
            String template = read(templatePath);

            String path2=Path.reportPath()+"/"+exFanan+".html";

            BufferedWriter output = new BufferedWriter( new OutputStreamWriter(new FileOutputStream(new File(path2)),"utf-8"));
            template = template.replaceFirst("\\$\\{resultData\\}", Matcher.quoteReplacement(gson.toJson(result)));

            output.write(template);
            output.flush();
            output.close();
        }
        catch( Exception er){
                er.printStackTrace();
            }


        }



    }


    private String getStatus(int status) {
        String statusString = null;
        switch (status) {
            case 1:
                statusString = "成功";
                break;
            case 2:
                statusString = "失败";
                break;
            case 3:
                statusString = "跳过";
                break;
            default:
                break;
        }
        return statusString;
    }

    private static String getSucss(boolean istrue) {
        String statusString = null;
        if(istrue){
            statusString = "流程已执行完成！";
        }else{
            statusString = "流程未执行完成，请留意！";
        }

        return statusString;
    }

    public static class ReportInfo {

        private String name;

        private String className;

        private String methodName;

        private String description;

        private String spendTime;

        private String status;

        private List<String> log;


        public String getName() {
            return name;
        }

        public void setName(String name) {
            this.name = name;
        }

        public String getClassName() {
            return className;
        }

        public void setClassName(String className) {
            this.className = className;
        }

        public String getMethodName() {
            return methodName;
        }

        public void setMethodName(String methodName) {
            this.methodName = methodName;
        }

        public String getSpendTime() {
            return spendTime;
        }

        public void setSpendTime(String spendTime) {
            this.spendTime = spendTime;
        }

        public String getStatus() {
            return status;
        }

        public void setStatus(String status) {
            this.status = status;
        }


        public String getDescription() {
            return description;
        }

        public void setDescription(String description) {
            this.description = description;
        }

        public List<String> getLog() {
            return log;
        }

        public void setLog(List<String> log) {
            this.log = log;
        }

    }

    private static String read(String path) {
        File file = new File(path);
        InputStream is = null;
        StringBuffer sb = new StringBuffer();
        try {

            is = new FileInputStream(file);
            int index = 0;
            byte[] b = new byte[1024];

            while ((index = is.read(b)) != -1) {
                sb.append(new String(b, 0, index,"UTF-8"));
            }
            return sb.toString();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            try {
                if (is != null) {
                    is.close();
                }
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
        return null;
    }
}
