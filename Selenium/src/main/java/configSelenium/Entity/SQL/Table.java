package configSelenium.Entity.SQL;

import java.io.Serializable;
import java.util.List;

/**
 * Created by Administrator on 2017/1/4.
 */
public class Table implements Serializable {
    public String getTableName() {
        return tableName;
    }

    public void setTableName(String tableName) {
        this.tableName = tableName;
    }

    public String getTableComments() {
        return tableComments;
    }

    public void setTableComments(String tableComments) {
        this.tableComments = tableComments;
    }

    public String getTableSpaceName() {
        return tableSpaceName;
    }

    public void setTableSpaceName(String tableSpaceName) {
        this.tableSpaceName = tableSpaceName;
    }

    public List<Column> getColumnList() {
        return columnList;
    }

    public void setColumnList(List<Column> columnList) {
        this.columnList = columnList;
    }

    private String tableName; //表名
    private String tableComments;//表说明
    private String tableSpaceName; //表空间名
    private List<Column> columnList; //字段
}
