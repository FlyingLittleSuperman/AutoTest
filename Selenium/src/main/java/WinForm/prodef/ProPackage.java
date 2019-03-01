package WinForm.prodef;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

/**
 * Created by Administrator on 2016/12/15.
 */
@JsonIgnoreProperties(ignoreUnknown = true)
public class ProPackage{
    private String caption; //包名称
    private String description;//描述
    private Integer  seqOrder;//排序
    private String parentId;//父节点内码
    private String url;//连接地址
    private String subGuid;
    private String subName;
    private String iconPath;
    private String categoryIdSet;

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getCaption() {
        return caption;
    }

    public void setCaption(String caption) {
        this.caption = caption;
    }

    public Integer getSeqOrder() {
        return seqOrder;
    }

    public void setSeqOrder(Integer seqOrder) {
        this.seqOrder = seqOrder;
    }

    public String getParentId() {
        return parentId;
    }

    public void setParentId(String parentId) {
        this.parentId = parentId;
    }

    public String getUrl() {
        return url;
    }

    public void setUrl(String url) {
        this.url = url;
    }

    public String getSubGuid() {
        return subGuid;
    }

    public void setSubGuid(String subGuid) {
        this.subGuid = subGuid;
    }

    public String getSubName() {
        return subName;
    }

    public void setSubName(String subName) {
        this.subName = subName;
    }

    public String getIconPath() {
        return iconPath;
    }

    public void setIconPath(String iconPath) {
        this.iconPath = iconPath;
    }

    public String getCategoryIdSet() {
        return categoryIdSet;
    }

    public void setCategoryIdSet(String categoryIdSet) {
        this.categoryIdSet = categoryIdSet;
    }

    private String id;


    public String toString() {
        return caption;
    }
}

