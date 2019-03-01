using System.Collections.Generic;

namespace SeleniumConfig.Bizdef.Entity
{
    public class BizdefPackageEntity
    {
        private string name;
        private string id;
        private string groupGuid;
        private int seqOrder;
        private string  parentGroupGuid;
        private string reMark;
        private List<Entity.BizdefEntity> items;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string GroupGuid
        {
            get { return groupGuid; }
            set { groupGuid = value; }
        }

        public int SeqOrder
        {
            get { return seqOrder; }
            set { seqOrder = value; }
        }

        public string ParentGroupGuid
        {
            get { return parentGroupGuid; }
            set { parentGroupGuid = value; }
        }

        public string ReMark
        {
            get { return reMark; }
            set { reMark = value; }
        }

        public List<BizdefEntity> Items
        {
            get { return items; }
            set { items = value; }
        }
    }
}
