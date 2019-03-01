
package configSelenium.Assert;

import dao.DataProviderSet_xlsx;

import org.testng.annotations.DataProvider;
import org.testng.annotations.Test;

import java.util.*;

/**
 * @author wangyan
 * @date 2019-01-18  下午 04:55
 *
 */
public class sql {

    //数据驱动测试
//    @Test(dataProvider = "dataArraryProvider")
//    public void testArrayDataProvider(String var1,String var2,String var3){
//        System.out.printf("%s,%s,%s\n",var1,var2,var3);
//
//    }


    //矩阵
    @DataProvider(name = "dataArraryProvider")
    public Object[][] dataArraryProvider(){
        Object[][] dates=new Object[4][3];

        dates[0]=new Object[]{"101","102","103"};
        dates[1]=new Object[]{"201","202","203"};
        dates[2]=new Object[]{"301","302","303"};
        dates[3]=new Object[]{"401","402","403"};

        return dates;
    }

    //虽然Iterator是一位数组，但这也是个矩阵
    @DataProvider(name = "dataProvider")
    public Iterator<Object[]> dataProvider(){
        List<Object[]> dates=new ArrayList<Object[]>();

        dates.add(new Object[]{"101","102","103"});
        dates.add(new Object[]{"201","202","203"});
        dates.add(new Object[]{"301","302","303"});
        dates.add(new Object[]{"401","402","403"});


        return dates.iterator();
    }

    //封装
    @Test(dataProvider = "mapDataProvider",dataProviderClass = DataProviderSet_xlsx.class)
    public void testMapDataProviderr(HashMap<?,?> map){
        System.out.printf("%s,%s,%s\n",map.get("var1"),map.get("var2"),map.get("var3"));
    }
    @DataProvider(name = "mapDataProvider")
    public Iterator<Object[]> mapDataProvider(){
        List<Object[]> datas=new ArrayList<Object[]>();

        HashMap<String,String> map1=new HashMap<>();
        map1.put("var1","100");map1.put("var2","101");map1.put("var3","102");
        HashMap<String,String> map2=new HashMap<>();
        map2.put("var1","200");map2.put("var2","201");map2.put("var3","202");
        HashMap<String,String> map3=new HashMap<>();
        map3.put("var1","300");map3.put("var2","301");map3.put("var3","302");

        datas.add(new Object[]{map1});
        datas.add(new Object[]{map2});
        datas.add(new Object[]{map3});

        return datas.iterator();

    }
    @Test(dataProvider = "mapDataProvider",dataProviderClass = DataProviderSet_xlsx.class)
    public void testMapDataProviderFromExcel(String var1,String var2,String var3){
//        if(var3.equalsIgnoreCase("f")){
//            System.out.println("var1:"+var1+"\nvar2:"+var2+"\nvar3:"+var3);
//        }
        System.out.println("var1:"+var1);
//        System.out.println("var1:"+var1+"\nvar2:"+var2+"\nvar3:"+var3);
//        Set<Map.Entry<String,String>> sets=map.entrySet();
//        System.out.println("size"+sets.size());

//        Set<Map.Entry<String,String>> sets=map.entrySet();
//        Iterator<Map.Entry<String,String>> iterEntry=sets.iterator();
//        System.out.println();
////        while (iterEntry.hasNext()){
//            Map.Entry<String,String> entry=iterEntry.next();
//            System.out.println(entry.getKey()+"->"+entry.getValue());
//
//        }


    }


}
