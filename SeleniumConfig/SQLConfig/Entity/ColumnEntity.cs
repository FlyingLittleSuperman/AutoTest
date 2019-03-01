using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumConfig.SQLConfig.Entity
{
    public class ColumnEntity
    {
        private string tableName;
        private string columnName;
        private string dataType;
        private string dataLength;
        private string dataScale;
        private string comments;

        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        public string ColumnName
        {
            get { return columnName; }
            set { columnName = value; }
        }

        public string DataType
        {
            get { return dataType; }
            set { dataType = value; }
        }

        public string DataLength
        {
            get { return dataLength; }
            set { dataLength = value; }
        }

        public string DataScale
        {
            get { return dataScale; }
            set { dataScale = value; }
        }

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
    }
}
