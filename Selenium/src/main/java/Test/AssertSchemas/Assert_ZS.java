package Test.AssertSchemas;

import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * @author wangyan
 * @date 2019-04-18  上午 10:03
 */
public class Assert_ZS {

    @Test(description = "权利人")
    public void AsQlr(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }


    @Test(description = "共有情况")
    public void AsGyqk(String actual,String except){
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



    @Test(description = "权利类型")
    public void AsQllx(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }


    @Test(description = "权利性质")
    public void AsQlxz(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }


    @Test(description = "面积")
    public void AsMj(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }


    @Test(description = "用途")
    public void AsYt(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "使用期限")
    public void AsSyqx(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }


    @Test(description = "权利其他情况")
    public void AsQlqtqk(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }


    @Test(description = "附记")
    public void AsFj(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }



}
