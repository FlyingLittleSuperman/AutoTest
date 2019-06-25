package Test.OCR;

import com.baidu.aip.ocr.AipOcr;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.IOException;
import java.util.HashMap;

import static Test.OCR.ocr_result.getResult;

public class sample {
    //设置APP ID /AK/SK
    public static final String APP_ID="16172775";
    public static final String API_KEY="dVX94cdlDm5x9H8fnNXKwcvM";
    public static final String SECRET_KEY="Y7ekolcftsUXXU0F56teQFPVe4trrdz4";

    public static void main(String []args) throws JSONException, IOException {
        //初始化一个AipOcr
        AipOcr client=new AipOcr(APP_ID,API_KEY,SECRET_KEY);
        getResult(client);

//        //设置网络连接数
//        client.setConnectionTimeoutInMillis(2000);
//        client.setSocketTimeoutInMillis(60000);
//
//        //调用接口
//        String path ="E:\\work_space\\js_de\\debug\\SeleniumConfig\\bin\\Debug\\SootScreens\\2019-04-28\\17_24\\申请信息截图.png";
//        JSONObject res=client.basicGeneral(path,new HashMap<String,String>());
//        System.out.println("看一下输出"+res.toString());
    }


}
