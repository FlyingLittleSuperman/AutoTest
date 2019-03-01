using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumConfig.SQLConfig.Entity
{
    public  class SQLConfigEntity
    {
        private string columnName;
        private string columnType;
        private string columnLength;
        private string columnScale;
        private string columnValue;
        private string comments;
        public string ColumnName
        {
            get { return columnName; }
            set { columnName = value; }
        }

        public string ColumnType
        {
            get { return columnType; }
            set { columnType = value; }
        }

        public string ColumnValue
        {
            get { return columnValue; }
            set { columnValue = value; }
        }

        public string ColumnLength
        {
            get { return columnLength; }
            set { columnLength = value; }
        }

        public string ColumnScale
        {
            get { return columnScale; }
            set { columnScale = value; }
        }

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
    }
}
