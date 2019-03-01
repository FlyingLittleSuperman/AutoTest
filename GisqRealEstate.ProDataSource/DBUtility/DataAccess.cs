using System;
using System.Reflection;
using System.Configuration;
namespace GisqRealEstate.ProDataSource
{
	/// <summary>
	/// 抽象工厂模式创建DAL。
	/// web.config 需要加入配置：(利用工厂模式+反射机制+缓存机制,实现动态创建不同的数据层对象接口)  
	/// DataCache类在导出代码的文件夹里
	/// 可以把所有DAL类的创建放在这个DataAccess类里
	/// <appSettings>  
    /// <add key="DAL" value="GisqLandProDataSource" /> (这里的命名空间根据实际情况更改为自己项目的命名空间)
	/// </appSettings> 
	/// </summary>
	public sealed class DataAccess
	{
		private static readonly string path = System.Configuration.ConfigurationSettings.AppSettings["DAL"];
		/// <summary>
		/// 创建对象或从缓存获取
		/// </summary>
		public static object CreateObject(string path,string CacheKey)
		{
			object objType = DataCache.GetCache(CacheKey);//从缓存读取
			if (objType == null)
			{
				try
				{
					objType = Assembly.Load(path).CreateInstance(CacheKey);//反射创建
					DataCache.SetCache(CacheKey, objType);// 写入缓存
				}
				catch
				{}
			}
			return objType;
		}

        

		
}
}