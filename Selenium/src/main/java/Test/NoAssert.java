package Test;

import Test.Report.ZTestReport;
import org.testng.Reporter;
import org.testng.annotations.AfterSuite;
import org.testng.annotations.Listeners;
import org.testng.annotations.Test;


import static org.assertj.core.api.Assertions.assertThat;
@Test
@Listeners({org.uncommons.reportng.HTMLReporter.class,org.uncommons.reportng.JUnitXMLReporter.class,emailMessage.class})
public class NoAssert {
    @Test
    public void showReport(){
        Reporter.log("");
    }




}

