using System;

namespace SeleniumConfig.ProInfo.Entity
{
    class PropackageEntity
    {
        String id;
        String caption; //包名称
        private String description; //描述
        private int seqOrder; //排序
        private String parentId; //父节点内码
        private String url; //连接地址
        private String subGuid;
        private String subName;
        private String iconPath;
        private String categoryIdSet;



        public string Caption
        {
            get { return caption; }
            set { caption = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int SeqOrder
        {
            get { return seqOrder; }
            set { seqOrder = value; }
        }

        public string ParentId
        {
            get { return parentId; }
            set { parentId = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public string SubGuid
        {
            get { return subGuid; }
            set { subGuid = value; }
        }

        public string SubName
        {
            get { return subName; }
            set { subName = value; }
        }

        public string IconPath
        {
            get { return iconPath; }
            set { iconPath = value; }
        }

        public string CategoryIdSet
        {
            get { return categoryIdSet; }
            set { categoryIdSet = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
