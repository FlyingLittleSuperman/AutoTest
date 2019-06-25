package Test.AssertSchemas;

import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * @author wangyan
 * @date 2019-04-18  上午 10:03
 */
public class Assert_ZM {

    @Test(description = "证明/证书权利或事项")
    public void AsZmzsqlhsx(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "申请人")
    public void AsSqr(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "义务人")
    public void AsYwr(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "坐落")
    public void AsZl(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "不动产单元号")
    public void AsBdcdyh(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }


    @Test(description = "其他")
    public void AsQt(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

}
