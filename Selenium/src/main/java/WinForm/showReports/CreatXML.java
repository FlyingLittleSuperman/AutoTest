package WinForm.showReports;

import configSelenium.Entity.SeleniumTest.SeleniumSchema;
import configSelenium.InitCommonParameter;
import configSelenium.StaticValue;

import org.dom4j.Document;
import org.dom4j.DocumentException;
import org.dom4j.DocumentHelper;
import org.dom4j.Element;
import org.dom4j.io.OutputFormat;
import org.dom4j.io.XMLWriter;
import util.CacheUtils;
import util.DateUtils;
import util.Path;
import util.XmlUtils;

import java.io.FileWriter;
import java.io.IOException;
import java.io.Writer;
import java.util.ArrayList;
import java.util.List;

import static Test.emailMessage.*;
import static WinForm.showReports.ReportXML.saveXml;
import static configSelenium.ConfigSeleniumStart.*;
import static configSelenium.InitCommonParameter.*;
import static configSelenium.InitCommonParameter.childprodefid;
import static configSelenium.InitCommonParameter.prodefid;
import static util.Path.da;
import static util.Path.day;
import static util.Path.min;

/**
 * @author wangyan
 * @date 2019-03-28  下午 01:18
 */
public class CreatXML {

    public  ReportsSchema getReportMessage( String fanganName) throws DocumentException {
        ReportsSchema reportSchema = new ReportsSchema();
        String modular="\n\t测试模块："+reportModual;
        String pass="\n\t测试通过："+passed;
        String skip="\n\t测试跳过："+skiped;
        String fail="\n\t测试失败："+failed;
        String isPass="";
        if(isSuccess){
            isPass="流程已执行完成！";
        }else{
            isPass="流程未执行完成，请留意！";
        }





        reportSchema.setId(InitCommonParameter.schemaid+min.format(da).trim());
        reportSchema.setName(InitCommonParameter.schemaname+min.format(da).trim());
        reportSchema.setTime(min.format(da));
        reportSchema.setPath(Path.FananreportPath()+"\\"+InitCommonParameter.schemaname+".html");


        reportSchema.setProdefId(cprodefid);
        reportSchema.setProdefName(cprodefname);
        reportSchema.setPackageName(cprodefpackagename);
        reportSchema.setPackageId(cprodefpackageid);
        reportSchema.setChildProdefId(cprodefChildid);
        reportSchema.setChildProdefName(cprodefChildname);

        reportSchema.setReportId(cprodefid + DateUtils.getDate());
        reportSchema.setReportName("测试报告");
        reportSchema.setReportChildId(cprodefChildid + DateUtils.getDate());
        reportSchema.setReportChildName("断言结果概览：");
        reportSchema.setReportChildModular(modular);
        reportSchema.setReportChildPass(pass);
        reportSchema.setReportChildFail(fail);
        reportSchema.setReportChildSkip(skip);
        reportSchema.setReportChildPath(Path.reportPath()+"\\html_"+fanganName+"\\index.html");
        reportSchema.setReportChildYwh(projectywh);
        reportSchema.setReportChildIsSuccess(isPass);



        reportSchema.setScreenShootId(cprodefid + DateUtils.getDate());
        reportSchema.setScreenShootName("截图展示");

        reportSchema.setScreenShootUtilsList(shootChildList);


        reportSchema.setFRreportId(cprodefid + DateUtils.getDate());
        reportSchema.setFRreportName("帆软表单");
        reportSchema.setfRreportUtilsList(frchildList);


        reportsSchemaList.add(reportSchema);


        return reportSchema;

    }

}
