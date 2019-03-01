using System.Collections.Generic;

namespace SeleniumConfig.SQLConfig.Entity
{
    public class TableEntity
    {
        private string tableName;
        private string comments;
        private string tableSpaceName;
        private List<ColumnEntity> columnEntityList;

        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        public List<ColumnEntity> ColumnEntityList
        {
            get { return columnEntityList; }
            set { columnEntityList = value; }
        }

        public string TableSpaceName
        {
            get { return tableSpaceName; }
            set { tableSpaceName = value; }
        }
    }
}
