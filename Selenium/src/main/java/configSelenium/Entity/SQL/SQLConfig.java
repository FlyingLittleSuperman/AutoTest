package configSelenium.Entity.SQL;

import java.io.Serializable;
import java.util.List;

/**
 * Created by Administrator on 2017/1/4.
 */
public class SQLConfig implements Serializable {
    public String getSchemaId() {
        return schemaId;
    }

    public void setSchemaId(String schemaId) {
        this.schemaId = schemaId;
    }

    public List<Table> getTableList() {
        return tableList;
    }

    public void setTableList(List<Table> tableList) {
        this.tableList = tableList;
    }

    public String getSchemaName() {
        return schemaName;
    }

    public void setSchemaName(String schemaName) {
        this.schemaName = schemaName;
    }

    public List<TableRelation> getTableRelationList() {
        return tableRelationList;
    }

    public void setTableRelationList(List<TableRelation> tableRelationList) {
        this.tableRelationList = tableRelationList;
    }

    private String schemaId;  //方案内码
    private String schemaName; //方案名称
    private List<Table> tableList; //表
    private List<TableRelation> tableRelationList; //表关系
}
