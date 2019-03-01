package configSelenium.Entity.Jsoup;

import org.jsoup.Jsoup;

import org.jsoup.nodes.Document;
import org.jsoup.nodes.Element;
import org.jsoup.select.Elements;

import java.util.ArrayList;
import java.util.Formatter;
import java.util.List;

/**
 * @author wangyan
 * @date 2019-01-24  上午 09:31
 * 解析html地址，并且根据想要的方式显示
 */
 //TODO 将历史搜索记录进行保留，并且可以根据点击重现显示在相应的位置
    //Todo 设想将搜索记录写在一个xml文件中，或者文本中，对于历史记录显示还在思索中，待完善！
public class search {

    Param param=new Param();

    List humls=new ArrayList();

    //格式化显示
    static Formatter formatter = new Formatter(System.out);
    public static void priteTitle(String key,String value){

        formatter.format("%-15s %-20s\n",key,value);

    }

    public  void Search() {
        try {
            if(!param.getY_url().isEmpty()) {
                Document doc;

                doc= Jsoup.connect(param.getY_url()).get();
                Elements elementList=doc.getElementsByAttribute(param.getAttribute());
                Elements elementListAnnx = doc.getElementsByTag(param.getTag());
                elementList.addAll(elementListAnnx);
                String key;
                String value;

                //如果没有输入值，也没有选择默认方案就提示
                if(param.getName().isEmpty()&&param.getValue().isEmpty()&&param.getIsdefault().toString().equalsIgnoreCase("false")){
                    System.out.println("请输入数值或者选择默认!");
                }else if(param.getIsdefault().toString().equalsIgnoreCase("true")){
                    if((param.getAttribute().equalsIgnoreCase("id")||param.getAttribute().equalsIgnoreCase("name"))&&param.getTag().equalsIgnoreCase("button")){
                        param.setName("title");
                        param.setValue("id");
                        for(Element element:elementListAnnx){
                            key=element.attr(param.getName());
                            value=element.attr(param.getValue());
                            priteTitle(key,value);

                        }


                    }else if((param.getAttribute().equalsIgnoreCase("id")||param.getAttribute().equalsIgnoreCase("name"))&&param.getTag().equalsIgnoreCase("input")){
                        param.setName("id");
                        param.setValue("placeholder");
                        for(Element element:elementListAnnx){
                            key=element.attr(param.getName());
                            value=element.attr(param.getValue());
                            priteTitle(key,value);

                        }
                    }

                } else{
                   for(Element element:elementListAnnx){
                      key=element.attr(param.getName());
                      value=element.attr(param.getValue());
                      priteTitle(key,value);

                   }

                }

            }
        }catch (Exception e){
            e.getStackTrace();
        }

    }


}
