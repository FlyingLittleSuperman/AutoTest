package Test.AssertSchemas;

import org.testng.annotations.Test;

import static org.assertj.core.api.Assertions.assertThat;

/**
 * @author wangyan
 * @date 2019-04-02  上午 09:56
 */
public class Assert_SH {

    @Test(description = "不动产情况")
    public void AsBdcqk(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "不动产单元号")
    public void AsBdcdyh(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "坐落")
    public void AsZl(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }


    @Test(description = "不动产类型")
    public void AsBdcdlx(String actual,String except){
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


    @Test(description = "权利性质")
    public void AsQlxz(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }


    @Test(description = "共有情况")
    public void AsGyqk(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }


    @Test(description = "使用期限")
    public void AsSyqx(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "房屋结构")
    public void AsFwjg(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "所在层/总层数")
    public void AsSzaiceng(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "房屋分摊面积")
    public void AsBFwftmj(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "林种")
    public void AsLz(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "用海类型")
    public void AsYhlx(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "构筑物类型")
    public void AsGzwlx(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "原不动产权证书号")
    public void AsYbdcqzsh(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "原不动产权证明号")
    public void AsYbdcqzmh(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "抵押方式")
    public void AsDyfs(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }
    @Test(description = "抵押顺序")
    public void AsDysx(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }
    @Test(description = "一般抵押被担保债权数额")
    public void AsYbdybdbse(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }

    @Test(description = "最高债权数额")
    public void AsZgzqse(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }


    @Test(description = "在建建筑物抵押范围")
    public void AsZjjzwdyfw(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }


    @Test(description = "债务履行期限(债权确定期间)")
    public void AsZwlxqx(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }


    @Test(description = "地役权-利用目的")
    public void AsDyqlymd(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }


    @Test(description = "地役权-利用方法")
    public void AsDyqlyff(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }


    @Test(description = "地役权-利用期限")
    public void AsDyqlyqx(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }



    @Test(description = "需役地不动产权证书号")
    public void AsXydbdcqzsh(String actual,String except){
        assertThat(actual).isEqualTo(except);
    }




}
