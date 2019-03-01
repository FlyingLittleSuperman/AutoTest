using System;

namespace SeleniumConfig.Forms.Entity
{
    public class ChildProdefEntity
    {
        private String _propackageName;
        private String _prodefId;
        private String _prodefName;
        private String _childProdefId;
        private String _childProdefName;

        public string PropackageName
        {
            get { return _propackageName; }
            set { _propackageName = value; }
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
    }
}
