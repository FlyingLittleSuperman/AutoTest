package Test.AssertSchemas;

import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * @author wangyan
 * @date 2019-04-18  上午 10:00
 */
public class Assert_DB {

        @Test(description = "省编号比对")
        public void AsSbh(String actual,String except){
            assertThat(actual).isEqualTo(except);
        }


}
