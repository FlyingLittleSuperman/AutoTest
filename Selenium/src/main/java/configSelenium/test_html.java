package configSelenium;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.nodes.Element;
import org.jsoup.select.Elements;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Formatter;


/**
 * @author wangyan
 * @date 2019-01-18  下午 05:11
 */
public class test_html {
    static Formatter formatter = new Formatter(System.out);
    public static void priteTitle(String key,String value){

        formatter.format("%-15s %-20s\n",key,value);

    }
    public static void main(String[] args) throws IOException {
//        String html = "<html><head><title>First parse</title></head>"
//                + "<body><p>Parsed HTML into a doc.</p></body></html>";
//        Document doc = Jsoup.parse(html);
//        Document doc=Jsoup.connect("http://www.baidu.com").get();
//        Document doc=Jsoup.connect("http://192.168.2.119:8082/GisqPlatformExplorer/a/login;JSESSIONID=92d6ec460e6143738235b0cf147f090b").get();
        Document doc;
        doc=Jsoup.connect("http://192.168.2.119:8084/GisqQueryList/views/reports/realestate/common/acceptance/Acceptance_HouseRight.jsp?reportlet=realestate/common/acceptance/Acceptance_HouseRight.cpt&op=write&BDFR_GUID=f186c614-e05d-11e5-8188-000c29187a9e&ID=a0d3e57d-1eeb-11e9-a9b5-00505683a231&CATEGORY=BDC03&RECORDNUMBER=12981545-75a4-40b0-a46d-251990adddf9&BIZDEF_GUID=f18677f1-e05d-11e5-8188-000c29187a9e&BIZINST_GUID=a05a96c2-1eeb-11e9-a9b5-00505683a231&TYPE=form&userId=f2e37658-69d2-11e5-a045-000c297c0f34&TRANSACTOR=zscs&aid=sid-448F2700-65D1-46BD-A405-2DF2DCF69D2A&ACTDEFID=sid-448F2700-65D1-46BD-A405-2DF2DCF69D2A&tid=9efefeec-1eeb-11e9-9cb9-00505683a231&ACTINSTID=9efefeec-1eeb-11e9-9cb9-00505683a231&pid=3ce22705-0de3-11e6-b878-000c2984e60c&PRODEFID=3ce22705-0de3-11e6-b878-000c2984e60c&instid=9efa43f6-1eeb-11e9-9cb9-00505683a231&PROINSTID=9efa43f6-1eeb-11e9-9cb9-00505683a231&businesskey=20190123-0001066&PROJECTID=20190123-0001066&LCBM=2102&HJDM=SJ&XZQBM=3314,33&task_state=firstTask").get();
        System.out.println(doc.title());


//        Elements elementList = doc.getElementsByTag("input");
//        Element element=doc.getElementById("clientContainer");
//        Elements elements=element.getElementsByTag("input");
//        for(Element element1:elements){
//            String key=elements.attr("title");
//            String value=elements.attr("id");
//            System.out.println("Param name:"+key+"\nParam value:"+value);
//
//        }



        Elements elementList=doc.getElementsByAttribute("id");
        Elements elementListAnnx = doc.getElementsByTag("input");
        elementList.addAll(elementListAnnx);

        for(Element element:elementListAnnx){
            String key=element.attr("id");
            String value=element.attr("placeholder");
            if(!key.isEmpty()&&!value.isEmpty()){
//                System.out.println("Param name:"+key+"\nParam value:"+value);
                priteTitle(key,value);

//                System.out.printf(key+value);

            }

        }

            System.out.println(elementListAnnx.toString());
        formatter.close();



//        Document doc = Jsoup.connect("http://example.com")
//                .data("query", "Java")
//                .userAgent("Mozilla")
//                .cookie("auth", "token")
//                .timeout(3000)
//                .post();
//        Elements elementList = doc.getElementsByTag("img");
//        Elements elementListAnnx = doc.getElementsByTag("a");
//        elementList.addAll(elementListAnnx);
    }






}
