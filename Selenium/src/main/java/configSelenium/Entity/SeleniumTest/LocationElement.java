package configSelenium.Entity.SeleniumTest;

import java.io.Serializable;
import java.util.List;

/**
 * Created by Administrator on 2016/12/21.
 */
public class LocationElement implements Serializable{
    private String id;

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getLocationType() {
        return LocationType;
    }

    public void setLocationType(String locationType) {
        LocationType = locationType;
    }

    public String getLocationPath() {
        return LocationPath;
    }

    public void setLocationPath(String locationPath) {
        LocationPath = locationPath;
    }

    public String getOperateType() {
        return OperateType;
    }

    public void setOperateType(String operateType) {
        OperateType = operateType;
    }

    public Integer getOrder() {
        return Order;
    }

    public void setOrder(Integer order) {
        Order = order;
    }

    public String getDefaultValue() {
        return DefaultValue;
    }

    public void setDefaultValue(String defaultValue) {
        DefaultValue = defaultValue;
    }

    public String getIntroduce() {
        return Introduce;
    }

    public void setIntroduce(String introduce) {
        Introduce = introduce;
    }

    public Boolean getRandom() {
        return IsRandom;
    }

    public void setRandom(Boolean random) {
        IsRandom = random;
    }

    public List<ChildLocationElement> getChildLocationElementList() {
        return childLocationElementList;
    }

    public void setChildLocationElementList(List<ChildLocationElement> childLocationElementList) {
        this.childLocationElementList = childLocationElementList;
    }

    private String LocationType; //定位方式
    private String LocationPath;//定位路径
    private String OperateType;//操作方式
    private Integer Order;//顺序
    private String DefaultValue;//默认值
    private String Introduce;//资料说明
    private Boolean IsRandom;//默认值是否加随机数
    private List<ChildLocationElement> childLocationElementList;

    public Integer getWaitSecond() {
        return WaitSecond;
    }

    public void setWaitSecond(Integer waitSecond) {
        WaitSecond = waitSecond;
    }

    private Integer WaitSecond;

    public String getSqlSchemaId() {
        return SqlSchemaId;
    }

    public void setSqlSchemaId(String sqlSchemaId) {
        SqlSchemaId = sqlSchemaId;
    }

    private String SqlSchemaId;//sql方案内码

}
