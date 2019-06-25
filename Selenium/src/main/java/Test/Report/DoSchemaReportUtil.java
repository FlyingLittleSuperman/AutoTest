package Test.Report;

import java.util.List;

public class DoSchemaReportUtil {
    private String prodefName;
    private String schemaName;
    private String ywh;
    private String timeOut;
    private Boolean isFinish;
    private List<String> log;


    public String getProdefName() {
        return prodefName;
    }

    public void setProdefName(String prodefName) {
        this.prodefName = prodefName;
    }

    public String getSchemaName() {
        return schemaName;
    }

    public void setSchemaName(String schemaName) {
        this.schemaName = schemaName;
    }

    public String getYwh() {
        return ywh;
    }

    public void setYwh(String ywh) {
        this.ywh = ywh;
    }

    public String getTimeOut() {
        return timeOut;
    }

    public void setTimeOut(String timeOut) {
        this.timeOut = timeOut;
    }

    public Boolean getFinish() {
        return isFinish;
    }

    public void setFinish(Boolean finish) {
        isFinish = finish;
    }


    public List<String> getLog() {
        return log;
    }

    public void setLog(List<String> log) {
        this.log = log;
    }
}
