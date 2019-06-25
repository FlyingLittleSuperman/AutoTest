package Test;

import org.testng.*;
import org.testng.xml.XmlSuite;

import java.util.*;



/**
 * @author wangyan
 * @date 2019-03-12  上午 10:34
 */
public class emailMessage implements IReporter {
    public static String passed;
    public static String failed;
    public static String skiped;
    public static String suitname;
    public static int pass,skip,fail;
    public  static List<String> logs;



    @Override
    public void generateReport(List<XmlSuite> xmlSuites, List<ISuite> suites,
                               String outputDirectory) {
        List<ITestResult> list = new ArrayList<ITestResult>();



        for(ISuite suit:suites){
            String suitName=suit.getName();
            Map<String,ISuiteResult> suiteResult=suit.getResults();
            for (ISuiteResult sr : suiteResult.values()) {
                ITestContext tc = sr.getTestContext();




//                String str1="\t测试模块："+suitName;
//                String str2="\n\t测试通过："+String.valueOf(tc.getPassedTests().getAllResults().size())+"\n\t测试失败："+String.valueOf(tc.getFailedTests().getAllResults().size())
//                        +"\n\t测试跳过："+String.valueOf(tc.getSkippedTests().getAllResults().size());
//                System.out.println(str1+str2);

                passed=String.valueOf(tc.getPassedTests().getAllResults().size());
                failed=String.valueOf(tc.getFailedTests().getAllResults().size());
                skiped=String.valueOf(tc.getSkippedTests().getAllResults().size());

                suitname=suitName;

                ITestContext testContext = sr.getTestContext();
                IResultMap passedTests = testContext.getPassedTests();
                pass = pass + passedTests.size();
                IResultMap failedTests = testContext.getFailedTests();
                fail = fail + failedTests.size();
                IResultMap skippedTests = testContext.getSkippedTests();
                skip = skip + skippedTests.size();
                IResultMap failedConfig = testContext.getFailedConfigurations();
                IResultMap scuessConfig = testContext.getPassedConfigurations();
                IResultMap skipConfig = testContext.getSkippedConfigurations();
                list.addAll(this.listTestResult(passedTests));
                list.addAll(this.listTestResult(failedTests));
                list.addAll(this.listTestResult(skippedTests));
                list.addAll(this.listTestResult(failedConfig));
                list.addAll(this.listTestResult(scuessConfig));
                list.addAll(this.listTestResult(skipConfig));



            }


        }
        this.sort(list);
        this.outputResult(list);


    }






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
    private void outputResult(List<ITestResult> list) {

        logs = Reporter.getOutput();

        for (ITestResult result : list) {


            for (int i = 0; i < logs.size(); i++) {
                logs.set(i, logs.get(i).replaceAll("\"", "\\\""));
            }
            Throwable throwable = result.getThrowable();
            if (throwable != null) {
                logs.add(throwable.toString().replaceAll("\"", "\\\""));
            }

        }
//        System.out.println("output:"+logs);


    }

}
