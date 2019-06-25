package Test.Report;

import java.util.ArrayList;
import java.util.List;

public class EmailInformation {
    private String IpAddress;
    private String Name;
    private String psd;
    private int count;
    private int isPass;
    private int isFail;
    private String FailYwh;

    public String getIpAddress() {
        return IpAddress;
    }

    public void setIpAddress(String ipAddress) {
        IpAddress = ipAddress;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public String getPsd() {
        return psd;
    }

    public void setPsd(String psd) {
        this.psd = psd;
    }

    public int getCount() {
        return count;
    }

    public void setCount(int count) {
        this.count = count;
    }

    public int getIsPass() {
        return isPass;
    }

    public void setIsPass(int isPass) {
        this.isPass = isPass;
    }

    public int getIsFail() {
        return isFail;
    }

    public void setIsFail(int isFail) {
        this.isFail = isFail;
    }

    public String getFailYwh() {
        return FailYwh;
    }

    public void setFailYwh(String failYwh) {
        FailYwh = failYwh;
    }
}
