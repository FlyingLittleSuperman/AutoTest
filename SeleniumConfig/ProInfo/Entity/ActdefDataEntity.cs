using System;

namespace SeleniumConfig.ProInfo.Entity
{
    public class ActdefDataEntity
    {
        private String id;
        private String url;
        private String name;
        private String processKey;
        private ActdefEntity[] listTaskInfor;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ProcessKey
        {
            get { return processKey; }
            set { processKey = value; }
        }

        public ActdefEntity[] ListTaskInfor
        {
            get { return listTaskInfor; }
            set { listTaskInfor = value; }
        }
    }
}
