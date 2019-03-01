using System;

namespace SeleniumConfig.ProInfo.Entity
{
    public class ActdefEntity
    {
        private String task_id;
        private String task_name;

        public string Task_id
        {
            get { return task_id; }
            set { task_id = value; }
        }

        public string Task_name
        {
            get { return task_name; }
            set { task_name = value; }
        }
    }
}
