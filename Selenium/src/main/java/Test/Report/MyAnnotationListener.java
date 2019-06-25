package Test.Report;

import org.testng.*;

/**
 * @author wangyan
 * @date 2019-04-18  上午 09:48
 */
public class MyAnnotationListener implements IInvokedMethodListener,ITestListener {
    public String description;



    @Override
    public void beforeInvocation(IInvokedMethod method, ITestResult testResult) {

    }

    @Override
    public void afterInvocation(IInvokedMethod method, ITestResult testResult) {

    }

    @Override
    public void onTestStart(ITestResult result) {
        description=result.getMethod().getConstructorOrMethod().getMethod().getAnnotation(TestDescription.class).description();

    }

    @Override
    public void onTestSuccess(ITestResult result) {

    }

    @Override
    public void onTestFailure(ITestResult result) {

    }

    @Override
    public void onTestSkipped(ITestResult result) {

    }

    @Override
    public void onTestFailedButWithinSuccessPercentage(ITestResult result) {

    }

    @Override
    public void onStart(ITestContext context) {
        for(ITestNGMethod m1 : context.getAllTestMethods()) {
            if(m1.getConstructorOrMethod().getMethod().isAnnotationPresent(TestDescription.class)) {
                description = m1.getConstructorOrMethod().getMethod().getAnnotation(TestDescription.class).description();
            }
        }

    }

    @Override
    public void onFinish(ITestContext context) {

    }
}
