using System;

namespace SeleniumConfig.CommonClass.Entity
{
    public class ServicePath
    {
        private string actdefPath;

        private string bizdefFormPath;

        private string bizdefPath;

        private string departmentPath;

        private string departmentUserPath;

        private string loginUrl;

        private string packagePath;

        private string prodefPath;

        public ServicePath()
        {
            IsOrginal = false;
        }


        public string UserName { get; set; }
        public string PassWord { get; set; }

        public string ServiceIP { get; set; }

        public string PackagePath
        {
            get
            {
                if (IsOrginal)
                    return packagePath;
                return packagePath.Replace("{IP}", ServiceIP);
            }
            set { packagePath = value; }
        }

        public string ProdefPath
        {
            get
            {
                if (IsOrginal)
                    return prodefPath;
                return prodefPath.Replace("{IP}", ServiceIP);
            }
            set { prodefPath = value; }
        }

        public string ActdefPath
        {
            get
            {
                if (IsOrginal)
                    return actdefPath;
                return actdefPath.Replace("{IP}", ServiceIP);
            }
            set { actdefPath = value; }
        }

        public string ChromeDriverPath { get; set; }

        public string LoginUrl
        {
            get
            {
                if (IsOrginal)
                    return loginUrl;
                return loginUrl.Replace("{IP}", ServiceIP);
            }
            set { loginUrl = value; }
        }

        public string DepartmentPath
        {
            get
            {
                if (IsOrginal)
                    return departmentPath;
                return departmentPath.Replace("{IP}", ServiceIP);
            }
            set { departmentPath = value; }
        }

        public string DeparmentUserPath
        {
            get
            {
                if (IsOrginal)
                    return departmentUserPath;
                return departmentUserPath.Replace("{IP}", ServiceIP);
            }
            set { departmentUserPath = value; }
        }

        public string FirstPageIframeName { get; set; }

        public string CreateProIframeName { get; set; }

        public string WorkFlowFrameIfram { get; set; }

        public string BizdefPath
        {
            get
            {
                if (IsOrginal)
                    return bizdefPath;
                return bizdefPath.Replace("{IP}", ServiceIP);
            }
            set { bizdefPath = value; }
        }

        public string BizdefFormPath
        {
            get
            {
                if (IsOrginal)
                    return bizdefFormPath;
                return bizdefFormPath.Replace("{IP}", ServiceIP);
            }
            set { bizdefFormPath = value; }
        }

        public string DataCategoryPath { get; set; }

        public string LoginUserName { get; set; }
        public string LoginPassWord { get; set; }

        public bool IsOrginal { get; set; }


        public String DbName { get; set; }
        public String DbUserName { get; set; }
        public String DbPassWord { get; set; }

        public string BizRestServicePath
        {
            get
            {
                if (IsOrginal)
                    return bizRestServicePath;
                return bizRestServicePath.Replace("{IP}", ServiceIP);
            }
            set { bizRestServicePath = value; }
        }

        private string bizRestServicePath;

    }
}