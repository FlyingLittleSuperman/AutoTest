package configSelenium.Entity.ProInfo;


import java.io.Serializable;
import java.util.List;

/**
 * Created by Administrator on 2016/12/21.
 */
public class Prodef implements Serializable {
    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public List<Actdef> getActdefList() {
        return actdefList;
    }

    public void setActdefList(List<Actdef> actdefList) {
        this.actdefList = actdefList;
    }

    public String getPackageID() {
        return PackageID;
    }

    public void setPackageID(String packageID) {
        PackageID = packageID;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    private  String id;
    private String Name;
    private String PackageID;
//    private String PackageName;
    private List<Actdef> actdefList;


}
