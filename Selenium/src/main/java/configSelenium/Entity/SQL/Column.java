package configSelenium.Entity.SQL;

import java.io.Serializable;

/**
 * Created by Administrator on 2017/1/4.
 */
public class Column implements Serializable {
    public String getColumnName() {
        return columnName;
    }

    public void setColumnName(String columnName) {
        this.columnName = columnName;
    }

    public String getColumnComments() {
        return columnComments;
    }

    public void setColumnComments(String columnComments) {
        this.columnComments = columnComments;
    }

    public String getColumnType() {
        return columnType;
    }

    public void setColumnType(String columnType) {
        this.columnType = columnType;
    }

    public Integer getColumnLength() {
        return columnLength;
    }

    public void setColumnLength(Integer columnLength) {
        this.columnLength = columnLength;
    }

    public Integer getColumnScale() {
        return columnScale;
    }

    public void setColumnScale(Integer columnScale) {
        this.columnScale = columnScale;
    }

    private String columnName; //字段名
    private String columnComments; //字段说明
    private String columnType; //字段类型
    private Integer columnLength; //字段长度
    private Integer columnScale; //字段精度

    public String getColumnValue() {
        return columnValue;
    }

    public void setColumnValue(String columnValue) {
        this.columnValue = columnValue;
    }

    private String columnValue; //字段值
}
