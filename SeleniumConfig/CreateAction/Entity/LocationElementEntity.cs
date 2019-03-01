using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumConfig.CreateAction.Entity
{
    public class LocationElementEntity
    {
        public enum LocateType
        {
            ID,
            NAME,
            XPATH
        }

        private String id;
        private String locationType;
        private String locationPath;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string LocationType
        {
            get { return locationType; }
            set { locationType = value; }
        }

        public string LocationPath
        {
            get { return locationPath; }
            set { locationPath = value; }
        }

        public string OperateType
        {
            get { return operateType; }
            set { operateType = value; }
        }

        public string LocationDefaultValue
        {
            get { return locationDefaultValue; }
            set { locationDefaultValue = value; }
        }

        public string Order
        {
            get { return order; }
            set { order = value; }
        }

        public string Introduce
        {
            get { return _introduce; }
            set { _introduce = value; }
        }

        public bool IsRanddom
        {
            get { return _isRanddom; }
            set { _isRanddom = value; }
        }

        public int WaitSecond
        {
            get { return _waitSecond; }
            set { _waitSecond = value; }
        }

        public string SqlSchemaId
        {
            get { return _sqlSchemaId; }
            set { _sqlSchemaId = value; }
        }


        private string operateType;
        private string locationDefaultValue;

        private string order;


        public string _introduce;

        private bool _isRanddom = false;

        private int _waitSecond;

        private string _sqlSchemaId;
    }
}
