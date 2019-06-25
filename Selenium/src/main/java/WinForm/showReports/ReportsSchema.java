package WinForm.showReports;

import javax.xml.crypto.Data;
import java.io.Serializable;
import java.util.List;

/**
 * @author wangyan
 * @date 2019-03-28  下午 12:51
 */
public class ReportsSchema implements Serializable {

    private String Id;
    private String Name;
    private String Time;
    private String Path;
    private String ProdefId;
    private String ProdefName;
    private String PackageName;
    private String PackageId;
    private String ChildProdefId;
    private String ChildProdefName;
    private String ScreenShootId;
    private String ScreenShootName;
    private String FRreportId;
    private String FRreportName;


    private List<ScreenShootUtils> screenShootUtilsList;
    private List<FRreportUtils> fRreportUtilsList;

    private String ReportId;
    private String ReportName;
    private String ReportChildId;
    private String ReportChildName;
    private String ReportChildModular;
    private String ReportChildPass;
    private String ReportChildFail;
    private String ReportChildSkip;
    private String ReportChildPath;
    private String ReportChildYwh;
    private String ReportChildIsSuccess;






    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public String getProdefId() {
        return ProdefId;
    }

    public void setProdefId(String prodefId) {
        ProdefId = prodefId;
    }

    public String getProdefName() {
        return ProdefName;
    }

    public void setProdefName(String prodefName) {
        ProdefName = prodefName;
    }

    public String getPackageName() {
        return PackageName;
    }

    public void setPackageName(String packageName) {
        PackageName = packageName;
    }

    public String getChildProdefId() {
        return ChildProdefId;
    }

    public void setChildProdefId(String childProdefId) {
        ChildProdefId = childProdefId;
    }

    public String getChildProdefName() {
        return ChildProdefName;
    }

    public void setChildProdefName(String childProdefName) {
        ChildProdefName = childProdefName;
    }

    public String getReportId() {
        return ReportId;
    }

    public void setReportId(String reportId) {
        ReportId = reportId;
    }

    public String getReportName() {
        return ReportName;
    }

    public void setReportName(String reportName) {
        ReportName = reportName;
    }

    public String getReportChildId() {
        return ReportChildId;
    }

    public void setReportChildId(String reportChildId) {
        ReportChildId = reportChildId;
    }

    public String getReportChildName() {
        return ReportChildName;
    }

    public void setReportChildName(String reportChildName) {
        ReportChildName = reportChildName;
    }



    public String getReportChildPath() {
        return ReportChildPath;
    }

    public void setReportChildPath(String reportChildPath) {
        ReportChildPath = reportChildPath;
    }



    public String getId() {
        return Id;
    }

    public void setId(String id) {
        Id = id;
    }

    public String getReportChildModular() {
        return ReportChildModular;
    }

    public void setReportChildModular(String reportChildModular) {
        ReportChildModular = reportChildModular;
    }

    public String getReportChildPass() {
        return ReportChildPass;
    }

    public void setReportChildPass(String reportChildPass) {
        ReportChildPass = reportChildPass;
    }


    public String getPackageId() {
        return PackageId;
    }

    public void setPackageId(String packageId) {
        PackageId = packageId;
    }

    public String getReportChildFail() {
        return ReportChildFail;
    }

    public void setReportChildFail(String reportChildFail) {
        ReportChildFail = reportChildFail;
    }

    public String getReportChildSkip() {
        return ReportChildSkip;
    }

    public void setReportChildSkip(String reportChildSkip) {
        ReportChildSkip = reportChildSkip;
    }


    public String getTime() {
        return Time;
    }

    public void setTime(String time) {
        Time = time;
    }

    public List<ScreenShootUtils> getScreenShootUtilsList() {
        return screenShootUtilsList;
    }

    public void setScreenShootUtilsList(List<ScreenShootUtils> screenShootUtilsList) {
        this.screenShootUtilsList = screenShootUtilsList;
    }

    public List<FRreportUtils> getfRreportUtilsList() {
        return fRreportUtilsList;
    }

    public void setfRreportUtilsList(List<FRreportUtils> fRreportUtilsList) {
        this.fRreportUtilsList = fRreportUtilsList;
    }

    public String getScreenShootId() {
        return ScreenShootId;
    }

    public void setScreenShootId(String screenShootId) {
        ScreenShootId = screenShootId;
    }

    public String getScreenShootName() {
        return ScreenShootName;
    }

    public void setScreenShootName(String screenShootName) {
        ScreenShootName = screenShootName;
    }

    public String getFRreportId() {
        return FRreportId;
    }

    public void setFRreportId(String FRreportId) {
        this.FRreportId = FRreportId;
    }

    public String getFRreportName() {
        return FRreportName;
    }

    public void setFRreportName(String FRreportName) {
        this.FRreportName = FRreportName;
    }

    public String getReportChildYwh() {
        return ReportChildYwh;
    }

    public void setReportChildYwh(String reportChildYwh) {
        ReportChildYwh = reportChildYwh;
    }

    public String getReportChildIsSuccess() {
        return ReportChildIsSuccess;
    }

    public void setReportChildIsSuccess(String reportChildIsSuccess) {
        ReportChildIsSuccess = reportChildIsSuccess;
    }

    public String getPath() {
        return Path;
    }

    public void setPath(String path) {
        Path = path;
    }
}
