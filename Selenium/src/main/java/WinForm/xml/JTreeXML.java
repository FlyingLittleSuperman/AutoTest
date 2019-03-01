package WinForm.xml;

import WinForm.prodef.ProPackage;
import WinForm.prodef.Prodef;
import org.dom4j.Document;
import org.dom4j.DocumentHelper;
import org.dom4j.Element;
import org.dom4j.io.XMLWriter;

import java.io.File;
import java.io.FileWriter;
import java.util.List;
import java.util.Map;

/**
 * Created by Administrator on 2016/12/16.
 */
public class JTreeXML {
    public static void SaveXml(Map<Prodef, ProPackage> allProdefs, List<ProPackage> proPackageList) throws Exception {


        Document document = DocumentHelper.createDocument();
        Element root = document.addElement("Element"); //创建根元素
        for (ProPackage proPackage : proPackageList) {
            Element elementTable = root.addElement("ElementTable");
            elementTable.addAttribute("id", proPackage.getId());
            elementTable.addAttribute("name", proPackage.getCaption());
            elementTable.addAttribute("desc", proPackage.getDescription());
            for (Prodef prodef : allProdefs.keySet()) {
                if (allProdefs.get(prodef).equals(proPackage)) {
                    String id = prodef.getKey();
                    String name = prodef.getName();

                    Element elementInfo = elementTable.addElement("ElementInfo");
                    elementInfo.addAttribute("id", id);
                    elementInfo.addAttribute("name", name);
                }
            }
        }


        XMLWriter output = new XMLWriter(new FileWriter(new File("catalog.xml")));
        output.write(document);
        output.close();
    }
}
