package WinForm.prodef;

import com.fasterxml.jackson.databind.ObjectMapper;

import com.fasterxml.jackson.databind.deser.std.ObjectArrayDeserializer;
import org.apache.xerces.impl.dv.dtd.ListDatatypeValidator;
import org.dom4j.Document;
import org.dom4j.Element;
import org.json.JSONObject;
import org.json.JSONArray;
import util.JTree.CheckBoxTreeNode;
import util.PropertiesUtils;
import util.RestUtils;
import util.XmlUtils;

import javax.swing.tree.DefaultMutableTreeNode;
import java.io.File;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by Administrator on 2016/12/15.
 */
public class ProdefTree {

    /**
     * 获取流程包信息
     * @param nodeParent
     * @param parentId
     */
    public static void GetPackage(DefaultMutableTreeNode nodeParent, String parentId){
        String url = PropertiesUtils.getM_PackageRestUrlPath();
        url+="?parentId="+parentId;
        String username = PropertiesUtils.getM_RestUserName();
        String password = PropertiesUtils.getM_RestPassWord();
        String result = RestUtils.get(url,username,password);
        String[] arrResult = result.split("♀");
        int stateCode = Integer.valueOf(arrResult[0]);
        if(stateCode>=200 && stateCode<400){
            try {
                ObjectMapper objectMapper=new ObjectMapper();
                ProPackage[] proPackageList=objectMapper.readValue(arrResult[1], ProPackage[].class);
                for(ProPackage proPackage : proPackageList){
                    DefaultMutableTreeNode nodeChild=new DefaultMutableTreeNode(proPackage);

                    nodeParent.add(nodeChild);
                    GetPackage(nodeChild,proPackage.getId());
                }
            } catch (Exception e) {
                // TODO Auto-generated catch block
                e.printStackTrace();
            }
        }
        else{
            throw new RuntimeException(arrResult[1]);
        }

    }

    /**
     * 加载流程信息
     * @param parentId
     * @param parentNode
     * @throws Exception
     */
    public static void GetProdefNode(String parentId,DefaultMutableTreeNode parentNode) throws Exception{
        String url=PropertiesUtils.getM_ProdefRestUrlPath();
        url+="?category="+parentId+"&size=100&latest=true&order=desc";
        String username = PropertiesUtils.getM_RestUserName();
        String password = PropertiesUtils.getM_RestPassWord();
        String result = RestUtils.post(url,username,password,"{}");
        String[] arrResult = result.split("♀");
        int stateCode = Integer.valueOf(arrResult[0]);
        if(stateCode>=200 && stateCode<400) {
            ObjectMapper objectMapper=new ObjectMapper();
            ProdefData prodefData=objectMapper.readValue(arrResult[1], ProdefData.class);
            for(Prodef prodef : prodefData.getData()){
                CheckBoxTreeNode nodeChild=new CheckBoxTreeNode(prodef);
                parentNode.add(nodeChild);
            }
        }
        else{
            throw new RuntimeException(arrResult[1]);
        }

    }

    /**
     * 获取环节列表
     * @param parentId
     * @param parentNode
     * @throws Exception
     */
    public  static void GetActDefInfo(String parentId,CheckBoxTreeNode parentNode) throws Exception{
        String url=PropertiesUtils.getM_ActdefRestUrlPath();
        String username = PropertiesUtils.getM_RestUserName();
        String password = PropertiesUtils.getM_RestPassWord();
        JSONObject jsonObject =new JSONObject();
        JSONArray jsonArray= new JSONArray();
        jsonArray.put(parentId);
        jsonObject.put("processDefKeys",jsonArray);
        String result = RestUtils.post(url,username,password,jsonObject.toString());
        String[] arrResult = result.split("♀");
        int stateCode = Integer.valueOf(arrResult[0]);
        if(stateCode>=200 && stateCode<400) {
            ObjectMapper objectMapper=new ObjectMapper();
            ActdefData prodefData=objectMapper.readValue(arrResult[1], ActdefData[].class)[0];
            for(Actdef actdef : prodefData.getListTaskInfor()){
                CheckBoxTreeNode nodeChild=new CheckBoxTreeNode(actdef);
                parentNode.add(nodeChild);
            }
        }
        else{
            throw new RuntimeException(arrResult[1]);
        }

    }

    /**
     * 获取已配置的信息
     * @return
     * @throws Exception
     */
    public static Object[][] GetAllSelectProdef() throws Exception{
        File file =new File(".");
        Document document = XmlUtils.CreateDocumentByPath(file.getAbsolutePath()+"\\catalog.xml");
        List<Element>  allElement = document.selectNodes("//ElementTable");
        allElement.size();
        List<List<String>> lst=new ArrayList<List<String>>();
        for(Element element : allElement){

            String packageId=element.attributeValue("id");
            String packageName =element.attributeValue("name");
            String packageDesc = element.attributeValue("desc");

            List<Element> elementChildList =element.selectNodes("ElementInfo");
            for(Element elementChild : elementChildList){
                List<String> lstValues=new ArrayList<String>();
                String prodefId = elementChild.attributeValue("id");
                String prodefName =elementChild.attributeValue("name");
                lstValues.add(packageId);
                lstValues.add(packageName);
                lstValues.add(packageDesc);
                lstValues.add(prodefId);
                lstValues.add(prodefName);
                lst.add(lstValues);
            }
        }

        Object totalValue[][] = new Object[lst.size()][5];
        for (int i=0;i<lst.size();i++){
            List<String> lstTempValue  = lst.get(i);
            for(int j=0;j<5;j++){
                totalValue[i][j] = lstTempValue.get(j);
            }
        }
        return totalValue;

    }






}
