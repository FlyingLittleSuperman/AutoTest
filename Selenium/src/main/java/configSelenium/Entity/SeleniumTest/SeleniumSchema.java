package configSelenium.Entity.SeleniumTest;

import java.io.Serializable;

/**
 * Created by Administrator on 2016/12/26.
 */
public class SeleniumSchema implements Serializable {
    private String Id;
    private String Name;
    private Boolean Execute;
    private String ProdefId;

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

    public String getChildProdefName() {
        return ChildProdefName;
    }

    public void setChildProdefName(String childProdefName) {
        ChildProdefName = childProdefName;
    }

    private String ProdefName;
    private String PackageName;
    private String PackageId;
    private String ChildProdefId;
    private String ChildProdefName;
    private String filePath;

    public String getChildProdefId() {
        return ChildProdefId;
    }

    public void setChildProdefId(String childProdefId) {
        ChildProdefId = childProdefId;
    }

    public String getId() {
        return Id;
    }

    public void setId(String id) {
        Id = id;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public Boolean getExecute() {
        return Execute;
    }

    public void setExecute(Boolean execute) {
        Execute = execute;
    }

    public String getProdefId() {
        return ProdefId;
    }

    public void setProdefId(String prodefId) {
        ProdefId = prodefId;
    }



    public String getFilePath() {
        return filePath;
    }

    public void setFilePath(String filePath) {
        this.filePath = filePath;
    }


    public String getPackageId() {
        return PackageId;
    }

    public void setPackageId(String packageId) {
        PackageId = packageId;
    }
}
