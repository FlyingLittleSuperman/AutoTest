using System;

namespace SeleniumConfig.CreateAction.Entity
{
    public class IFrameEntity
    {
        private String ID;
        private String _name;
        private String _urlPath;


        public string Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string UrlPath
        {
            get { return _urlPath; }
            set { _urlPath = value; }
        }
    }
}
