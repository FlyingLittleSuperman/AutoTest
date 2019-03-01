using System;

namespace SeleniumConfig.DeparmentUser.Entity
{
    public class DepartmentEntity
    {
        private String name; //名称
        private String pid;//父节点内码
        private String id;//节点内码
        private String type;
        private String open;

        public string Name
        {
            get { return name; }
            set { name = value; }
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

        public string Open
        {
            get { return open; }
            set { open = value; }
        }
    }
}
