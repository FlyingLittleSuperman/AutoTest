package Test;
import org.testng.Assert;
import org.testng.annotations.Test;


/**
 * @author wangyan
 * @date 2019-01-21  下午 01:52
 */
public class Test_helloword {

    @Test
    public void testEmailGenerator() {

        RandomEmailGenerator obj = new RandomEmailGenerator();
        String email = obj.generate();

        Assert.assertNotNull(email);
        Assert.assertEquals(email, "feedback@yiibai.com");

    }


}
