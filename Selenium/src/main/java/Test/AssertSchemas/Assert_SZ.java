package Test.AssertSchemas;

import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * @author wangyan
 * @date 2019-04-18  下午 01:41
 */
public class Assert_SZ {


    @Test(description = "产权证书")
    public void AsBdcqzs(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "登记证明")
    public void AsBdcdjzm(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "登记证书-坐落")
    public void AsZszl(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "登记证明-坐落")
    public void AsZmzl(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }
}
