using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumConfig.SQLConfig.Entity
{
    public class TableRelationEntity
    {
        private string _id;

        private string _fTableSpaceName;
        private string _fTableName;
        private string _fColumnName;

        private string _lTableSpaceName;
        private string _lTableName;
        private string _lColumnName;


        public string FTableSpaceName
        {
            get { return _fTableSpaceName; }
            set { _fTableSpaceName = value; }
        }

        public string FTableName
        {
            get { return _fTableName; }
            set { _fTableName = value; }
        }

        public string FColumnName
        {
            get { return _fColumnName; }
            set { _fColumnName = value; }
        }

        public string LTableSpaceName
        {
            get { return _lTableSpaceName; }
            set { _lTableSpaceName = value; }
        }

        public string LTableName
        {
            get { return _lTableName; }
            set { _lTableName = value; }
        }

        public string LColumnName
        {
            get { return _lColumnName; }
            set { _lColumnName = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
