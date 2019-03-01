package configSelenium.Entity.SeleniumTest;

import java.io.Serializable;
import java.util.List;

/**
 * Created by Administrator on 2016/12/21.
 */
public class Iframe implements Serializable{
    private String id;
    private String Name;
    private String Url;

    public List<LocationElement> getLocationElementList() {
        return locationElementList;
    }

    public void setLocationElementList(List<LocationElement> locationElementList) {
        this.locationElementList = locationElementList;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public String getUrl() {
        return Url;
    }

    public void setUrl(String url) {
        Url = url;
    }

    private List<LocationElement> locationElementList;

}
