using System;
using System.Reflection;
using System.Configuration;
namespace GisqRealEstate.ProDataSource
{
	/// <summary>
	/// ���󹤳�ģʽ����DAL��
	/// web.config ��Ҫ�������ã�(���ù���ģʽ+�������+�������,ʵ�ֶ�̬������ͬ�����ݲ����ӿ�)  
	/// DataCache���ڵ���������ļ�����
	/// ���԰�����DAL��Ĵ����������DataAccess����
	/// <appSettings>  
    /// <add key="DAL" value="GisqLandProDataSource" /> (����������ռ����ʵ���������Ϊ�Լ���Ŀ�������ռ�)
	/// </appSettings> 
	/// </summary>
	public sealed class DataAccess
	{
		private static readonly string path = System.Configuration.ConfigurationSettings.AppSettings["DAL"];
		/// <summary>
		/// ���������ӻ����ȡ
		/// </summary>
		public static object CreateObject(string path,string CacheKey)
		{
			object objType = DataCache.GetCache(CacheKey);//�ӻ����ȡ
			if (objType == null)
			{
				try
				{
					objType = Assembly.Load(path).CreateInstance(CacheKey);//���䴴��
					DataCache.SetCache(CacheKey, objType);// д�뻺��
				}
				catch
				{}
			}
			return objType;
		}

        

		
}
}