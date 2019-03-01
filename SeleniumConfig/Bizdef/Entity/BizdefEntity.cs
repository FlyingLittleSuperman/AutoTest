using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumConfig.Bizdef.Entity
{
    public class BizdefEntity
    {
        private string bizDefGuid;
        private string titleField;
        private string appType;
        private string keyField;
        private string datumFilters;
        private string group;
        private string name;
        private string id;
        private string groupGuid;
        private string seqOrder;
        private string parentBizDefGuid;
        private string amserviceGroupID;
        private string label;
        private string amcategoryID;
        private string mapViewPage;
        private string mapSetPage;
        private string databaseCode;
        private string databaseTable;

        public string BizDefGuid
        {
            get { return bizDefGuid; }
            set { bizDefGuid = value; }
        }

        public string TitleField
        {
            get { return titleField; }
            set { titleField = value; }
        }

        public string AppType
        {
            get { return appType; }
            set { appType = value; }
        }

        public string KeyField
        {
            get { return keyField; }
            set { keyField = value; }
        }

        public string DatumFilters
        {
            get { return datumFilters; }
            set { datumFilters = value; }
        }

        public string Group
        {
            get { return @group; }
            set { @group = value; }
        }

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

        public string SeqOrder
        {
            get { return seqOrder; }
            set { seqOrder = value; }
        }

        public string ParentBizDefGuid
        {
            get { return parentBizDefGuid; }
            set { parentBizDefGuid = value; }
        }

        public string AmserviceGroupId
        {
            get { return amserviceGroupID; }
            set { amserviceGroupID = value; }
        }

        public string Label
        {
            get { return label; }
            set { label = value; }
        }

        public string AmcategoryId
        {
            get { return amcategoryID; }
            set { amcategoryID = value; }
        }

        public string MapViewPage
        {
            get { return mapViewPage; }
            set { mapViewPage = value; }
        }

        public string MapSetPage
        {
            get { return mapSetPage; }
            set { mapSetPage = value; }
        }

        public string DatabaseCode
        {
            get { return databaseCode; }
            set { databaseCode = value; }
        }

        public string DatabaseTable
        {
            get { return databaseTable; }
            set { databaseTable = value; }
        }
    }
}
