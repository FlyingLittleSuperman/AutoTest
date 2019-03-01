using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumConfig.SeleniumSchema.Entity
{
    public class SeleniumSchemaEntity
    {
        private String _id;
        private String _name;
        private String _prodefId;
        private String _prodefName;
        private String _childProdefId;
        private String _childProdefName;
        private String _propackageName;
        private Boolean _isSelect;
        private Boolean _isExecute;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string ProdefId
        {
            get { return _prodefId; }
            set { _prodefId = value; }
        }

        public string ProdefName
        {
            get { return _prodefName; }
            set { _prodefName = value; }
        }
        public string PropackageName
        {
            get { return _propackageName; }
            set { _propackageName = value; }
        }

        public string ChildProdefId
        {
            get { return _childProdefId; }
            set { _childProdefId = value; }
        }

        public string ChildProdefName
        {
            get { return _childProdefName; }
            set { _childProdefName = value; }
        }

        public bool IsSelect
        {
            get { return _isSelect; }
            set { _isSelect = value; }
        }

        public bool IsExecute
        {
            get { return _isExecute; }
            set { _isExecute = value; }
        }
    }
}
