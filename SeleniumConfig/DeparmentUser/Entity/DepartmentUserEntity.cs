using System;

namespace SeleniumConfig.DeparmentUser.Entity
{
    public class DepartmentUserEntity
    {
        private String name;
        private String icon;
        private String pid;
        private String id;
        private String type;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Icon
        {
            get { return icon; }
            set { icon = value; }
        }

        public string Pid
        {
            get { return pid; }
            set { pid = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Type1
        {
            get { return type; }
            set { type = value; }
        }
    }
}
