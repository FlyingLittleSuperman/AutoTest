using System.Collections.Generic;

namespace SeleniumConfig.ProInfo.Entity
{
    public class ProdefDataEntity
    {
        private List<ProdefEntity> data;

        public List<ProdefEntity> Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
