using System;
using System.Collections.Generic;

namespace SeleniumConfig.Bizdef.Entity
{
    public class BizdefFormDataEntity
    {
        private String id;
        private String bizDefGuid; //业务定制guid
        private String bdfbGuid;//档案袋节点guid
        private String displayText; //节点名称
        private String displayType;//节点类型
        private String linkUrl;//链接地址
        private String bdfbCode;//节点代码
        private String parentBdfbGuid;//父节点guid
        private String bdfrGuid;//表单GUID
        private List<BizdefFormEntity> items;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string BizDefGuid
        {
            get { return bizDefGuid; }
            set { bizDefGuid = value; }
        }

        public string BdfbGuid
        {
            get { return bdfbGuid; }
            set { bdfbGuid = value; }
        }

        public string DisplayText
        {
            get { return displayText; }
            set { displayText = value; }
        }

        public string DisplayType
        {
            get { return displayType; }
            set { displayType = value; }
        }

        public string LinkUrl
        {
            get { return linkUrl; }
            set { linkUrl = value; }
        }

        public string BdfbCode
        {
            get { return bdfbCode; }
            set { bdfbCode = value; }
        }

        public string ParentBdfbGuid
        {
            get { return parentBdfbGuid; }
            set { parentBdfbGuid = value; }
        }

        public string BdfrGuid
        {
            get { return bdfrGuid; }
            set { bdfrGuid = value; }
        }

        public List<BizdefFormEntity> Items
        {
            get { return items; }
            set { items = value; }
        }
    }
}
