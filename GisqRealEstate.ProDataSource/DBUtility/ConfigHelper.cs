using System;
using System.Configuration;
using System.Xml;

namespace GisqRealEstate.ProDataSource
{
	/// <summary>
	/// web.config������
    /// ����ƽ
    /// 2004.8
	/// </summary>
	public sealed class ConfigHelper
	{
		/// <summary>
		/// �õ�AppSettings�е������ַ�����Ϣ
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static string GetConfigString(string key)
		{
            object objModel = ConfigurationManager.AppSettings[key]; 
            //string CacheKey = "AppSettings-" + key;
            //object objModel = DataCache.GetCache(CacheKey);
            //if (objModel == null)
            //{
            //    try
            //    {
            //        objModel = ConfigurationManager.AppSettings[key]; 
            //        if (objModel != null)
            //        {                        
            //            DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(180), TimeSpan.Zero);
            //        }
            //    }
            //    catch
            //    { }
            //}
            if (objModel == null)
                objModel = "";
            return objModel.ToString();
		}

        public static string GetConfigString(string key,bool isRetNullWhenNotFound)
        {
            object objModel = ConfigurationManager.AppSettings[key];
            //string CacheKey = "AppSettings-" + key;
            //object objModel = DataCache.GetCache(CacheKey);
            //if (objModel == null)
            //{
            //    try
            //    {
            //        objModel = ConfigurationManager.AppSettings[key]; 
            //        if (objModel != null)
            //        {                        
            //            DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(180), TimeSpan.Zero);
            //        }
            //    }
            //    catch
            //    { }
            //}
            if (objModel == null)
            {
                if (isRetNullWhenNotFound)
                {
                    return null;
                }
                objModel = "";
            }
            return objModel.ToString();
        }

		/// <summary>
		/// �õ�AppSettings�е�����Bool��Ϣ
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static bool GetConfigBool(string key)
		{
			bool result = false;
			string cfgVal = GetConfigString(key);
			if(null != cfgVal && string.Empty != cfgVal)
			{
				try
				{
					result = bool.Parse(cfgVal);
				}
				catch(FormatException)
				{
					// Ignore format exceptions.
				}
			}
			return result;
		}
		/// <summary>
		/// �õ�AppSettings�е�����Decimal��Ϣ
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static decimal GetConfigDecimal(string key)
		{
			decimal result = 0;
			string cfgVal = GetConfigString(key);
			if(null != cfgVal && string.Empty != cfgVal)
			{
				try
				{
					result = decimal.Parse(cfgVal);
				}
				catch(FormatException)
				{
					// Ignore format exceptions.
				}
			}

			return result;
		}
		/// <summary>
		/// �õ�AppSettings�е�����int��Ϣ
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static int GetConfigInt(string key)
		{
			int result = 0;
			string cfgVal = GetConfigString(key);
			if(null != cfgVal && string.Empty != cfgVal)
			{
				try
				{
					result = int.Parse(cfgVal);
				}
				catch(FormatException)
				{
					// Ignore format exceptions.
				}
			}

			return result;
		}

        ///<summary>
        ///�ڣ�.exe.config�ļ���appSettings���ý�����һ�Լ���ֵ��
        ///</summary>
        ///<param name="newKey"></param>
        ///<param name="newValue"></param>
        public static void UpdateAppConfig(string newKey, string newValue)
        {
            bool isModified = false;
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == newKey)
                {
                    isModified = true;
                }
            }

            // Open App.Config of executable
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // You need to remove the old settings object before you can replace it
            if (isModified)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            // Add an Application Setting.
            config.AppSettings.Settings.Add(newKey, newValue);
            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Modified);
            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// ��CONFIG��XML�����ļ������ý����Ӽ���ֵ��
        /// </summary>
        /// <param name="strXmlName">�������ƣ�XML���ļ�����</param>
        /// <param name="newKey">����</param>
        /// <param name="newValue">��ֵ</param>
        public static void UpdateAppConfig(string strPath, string strXmlName, string newKey, string newValue)
        {
            XmlDocument objXml = new XmlDocument();
            objXml.Load(strPath + @"\" + strXmlName + ".xml");
            XmlNode objNode = objXml.SelectSingleNode("configuration/add[@key='" + newKey + "']");

            if (objNode == null)
            {
                XmlElement objElement = objXml.CreateElement("add");
                objElement.SetAttribute("key", newKey);
                objElement.SetAttribute("value", newValue);
                XmlNode objRoot = objXml.SelectSingleNode("configuration");
                objRoot.AppendChild(objElement);
            }
            else
            {
                objNode.Attributes["value"].Value = newValue;
            }
            objXml.Save(strPath + @"\" + strXmlName + ".xml");

        }

        /// <summary>
        /// ��CONFIG��XML�����ļ������ý����Ӽ���ֵ��
        /// </summary>
        /// <param name="strXmlName">�������ƣ�XML���ļ�����</param>
        /// <param name="newKey">����</param>
        /// <param name="newValue">��ֵ</param>
        public static void UpdateAppConfig(string strXmlName, string newKey, string newValue)
        {
            UpdateAppConfig(System.Windows.Forms.Application.StartupPath,strXmlName, newKey, newValue);
        }

        /// <summary>
        /// ��ȡ��CONFIG��XML�����ļ������ýڵ�ֵ
        /// </summary>
        /// <param name="strXmlName">�������ƣ�XML���ļ�����</param>
        /// <param name="key">����</param>
        /// <returns></returns>
        public static string GetConfigString(string strXmlName,string key)
        {
            XmlDocument objXml = new XmlDocument();
            objXml.Load(System.Windows.Forms.Application.StartupPath + @"\" + strXmlName + ".xml");
            XmlNode objXmlNode = objXml.SelectSingleNode("configuration/add[@key='" + key + "']");
            if (objXmlNode == null)
            {
                return "";
            }
            else
            {
                return objXml.SelectSingleNode("configuration/add[@key='" + key + "']").Attributes["value"].Value;
            }
        }
	}
}
