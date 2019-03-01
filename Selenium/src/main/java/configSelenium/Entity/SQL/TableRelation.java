package configSelenium.Entity.SQL;

import java.io.Serializable;

/**
 * Created by Administrator on 2017/1/4.
 */
public class TableRelation implements Serializable {
    public String getTableRelationId() {
        return tableRelationId;
    }

    public void setTableRelationId(String tableRelationId) {
        this.tableRelationId = tableRelationId;
    }

    public String getfTableSpaceName() {
        return fTableSpaceName;
    }

    public void setfTableSpaceName(String fTableSpaceName) {
        this.fTableSpaceName = fTableSpaceName;
    }

    public String getfTableName() {
        return fTableName;
    }

    public void setfTableName(String fTableName) {
        this.fTableName = fTableName;
    }

    public String getfColumnName() {
        return fColumnName;
    }

    public void setfColumnName(String fColumnName) {
        this.fColumnName = fColumnName;
    }

    public String getlTableSpaceName() {
        return lTableSpaceName;
    }

    public void setlTableSpaceName(String lTableSpaceName) {
        this.lTableSpaceName = lTableSpaceName;
    }

    public String getlTableName() {
        return lTableName;
    }

    public void setlTableName(String lTableName) {
        this.lTableName = lTableName;
    }

    public String getlColumnName() {
        return lColumnName;
    }

    public void setlColumnName(String lColumnName) {
        this.lColumnName = lColumnName;
    }

    public String getTableRelationExpress() {
        return tableRelationExpress;
    }

    public void setTableRelationExpress(String tableRelationExpress) {
        this.tableRelationExpress = tableRelationExpress;
    }

    private String tableRelationId;//内码
    private String fTableSpaceName;//关联前表空间名
    private String fTableName;//关联前表名
    private String fColumnName;//关联前字段名
    private String lTableSpaceName;//关联后表控件名
    private String lTableName; //关联后表名
    private String lColumnName; //关联后字段名
    private String tableRelationExpress;//表达式
}
