package Test.OCR;

import com.baidu.aip.ocr.AipOcr;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.IOException;
import java.util.HashMap;

import static org.openqa.selenium.server.IOHelper.readFile;

public class ocr_result {

   public static void main(String []args){

   }

    public static void getResult(AipOcr client) throws JSONException, IOException {
        HashMap<String,String > options=new HashMap<String,String >();
//        options.put("language_type","CHN_ENG");
        options.put("detect_language","true");
        options.put("detect_direction","true");
//        options.put("probability","true");

        String path ="E:\\ocrdemo.png";
        JSONObject res=client.basicAccurateGeneral(path,options);
        System.out.println(res.toString(2));

//        参数为二进制数组
//        byte[] file = readFile("E:\\work_space\\js_de\\debug\\SeleniumConfig\\bin\\Debug\\SootScreens\\2019-03-13\\12 17_20.png");
//        res = client.handwriting(file, options);
//        System.out.println(res.toString(2));

    }
}
