package configSelenium.Entity.Jsoup;

/**
 * @author wangyan
 * @date 2019-01-24  上午 09:40
 */
public class Param {
    private  String y_url;
    private   String attribute;
    private  String tag;
    private  String name;
    private  String value;
    private  Boolean isdefault;


    public String getValue() {
        return value;
    }

    public void setValue(String value) {
        this.value = value;
    }


    public String getY_url() {
        return y_url;
    }

    public void setY_url(String y_url) {
        this.y_url = y_url;
    }

    public String getAttribute() {
        return attribute;
    }

    public void setAttribute(String attribute) {
        this.attribute = attribute;
    }

    public String getTag() {
        return tag;
    }

    public void setTag(String tag) {
        this.tag = tag;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Boolean getIsdefault() {
        return isdefault;
    }

    public void setIsdefault(Boolean isdefault) {
        this.isdefault = isdefault;
    }
}
