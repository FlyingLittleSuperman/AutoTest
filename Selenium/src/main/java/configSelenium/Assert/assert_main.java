package configSelenium.Assert;

import org.testng.Assert;
import org.testng.annotations.Test;

import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;
import java.util.Set;


import static org.testng.Assert.*;

/**
 * @author wangyan
 * @date 2019-01-18  下午 04:13
 */
public class assert_main {


    public  void test() {

//       Assert.assertEquals("a","a","成功了")
        String[] a = new String[]{"a1", "a3", "a2"};
        String[] a1=new String[]{"a1","a2","a3"};
        String[] b = new String[]{"a1", "a3", "a2"};

//       Assert.assertEquals(a,b,"haohaiyou");

        Map<String, String> map = new HashMap();
        map.put("1", "你好");
        map.put("2", "我叫");

        Map<String, String> map1 = new HashMap<>();
        map1.put("2", "我叫");
        map1.put("1", "你好");

//       Assert.assertEqualsDeep(map,map);

        //对于set和map集合里面是数组的，最好用equaldeep，这样会遍历每一个元素的equal方法

        Set<String[]> set1 = new HashSet<>();
        set1.add(a);

        Set<String[]> set2 = new HashSet<>();
        set2.add(b);

        //这种直接调用set的equal方
//        Assert.assertEquals(set1, set2);
        System.out.println("===============================");
        //会遍历数组的内容，每一个元素的equal方法
        assertEqualsDeep(set1,set2,"is not equal");

        //断言两个数组包含相同的元素，并且忽略数组元素的排列顺序
        assertEqualsNoOrder(a,a1);

        //断言两个boolean类型数据
        assertFalse(false);
        assertTrue(true);

        //断言Object类型数据是否为null
        assertNull(null);
        assertNotNull(new Object());

        //断言两个对象是否引用同一个对象
        assertNotSame(new Integer(1),new Integer(1));//success;

        //断言一段可执行程序有异常抛出
        assertThrows(()->{throw new RuntimeException();});//success
        //预期为空指针异常，实际为后面的运行异常
        assertThrows(NullPointerException.class,()->{throw new RuntimeException();});//false

        //自定义断言失败
        if(false) {
            fail("Test execution failed cased by something reason");
        }

    }
}
