package configSelenium.Entity.ProInfo;

import configSelenium.Entity.SeleniumTest.Iframe;

import java.io.Serializable;
import java.util.List;

/**
 * Created by Administrator on 2016/12/21.
 */
public class Actdef implements Serializable{
    private String id;
    private String Name;

    public List<Iframe> getIframeList() {
        return iframeList;
    }

    public void setIframeList(List<Iframe> iframeList) {
        this.iframeList = iframeList;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    private List<Iframe> iframeList;
}
