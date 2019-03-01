using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace SeleniumConfig.CommonClass
{
    public class RestUserLoginService
    {

        public static string RequestUrl(string method, string url, string param, string userName, string password)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentNullException("URL");

            switch (method.ToUpper())
            {
                case "POST":
                    return Post(url, param, userName, password);
                case "GET":
                    return Get(url, param, userName, password);
                default:
                    throw new EntryPointNotFoundException("method:" + method);
            }
        }

        /// <summary>
        /// Post请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string Post(string url, string param, string userName, string password)
        {
            UrlCheck(ref url);
            byte[] bufferBytes = Encoding.UTF8.GetBytes(param);
            var request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";        
            request.ContentLength = bufferBytes.Length;
            request.Credentials = new NetworkCredential(userName, password);
            request.ContentType = "application/json";
            request.KeepAlive = false;
            request.Timeout = 60000; // 1分钟超时

            using (var requestStream = request.GetRequestStream())
            {
                requestStream.Write(bufferBytes, 0, bufferBytes.Length);
                requestStream.Close();
            }
            return HttpRequest(request);
        }

        /// <summary> 
        /// GET请求 
        /// </summary> 
        /// <param name="url">请求地址</param> 
        /// <param name="param">参数</param> 
        /// <returns>请求返回结果</returns> 
        public static string Get(string url, string param, string user, string password)
        {
            UrlCheck(ref url);

            if (!string.IsNullOrEmpty(param))
                if (!param.StartsWith("?"))
                    param += "?" + param;
                else
                    param += param;

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "GET";
            request.Credentials = new NetworkCredential(user, password);
            request.ContentType = "application/x-www-form-urlencoded";

            return HttpRequest(request);
        }


        public static string GetUSER(string url, string param, string user, string password)
        {
            UrlCheck(ref url);

            if (!string.IsNullOrEmpty(param))
            {
                url = url + param;
            }

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "GET";
            request.Credentials = new NetworkCredential(user, password);
            request.ContentType = "application/x-www-form-urlencoded";
            
            return HttpRequest(request);
        }
       

        /// <summary> 
        /// 请求的主体部分（由此完成请求并返回请求结果） 
        /// </summary> 
        /// <param name="request">请求的对象</param> 
        /// <returns>请求返回结果</returns> 
        private static string HttpRequest(HttpWebRequest request)
        {
            HttpWebResponse response = null;
            try
            {
             
                response = request.GetResponse() as HttpWebResponse;
            }
            catch (WebException ex)
            {
                Logger.Log.Error(request.RequestUri.ToString());
                Logger.Log.Error(ex.ToString());
                throw ex;
            }
           
            string result = string.Empty;
            try
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                        result = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Logger.Log.Error(request.RequestUri.ToString());
                Logger.Log.Error(ex.ToString());
                throw ex;
            }
            return result;
        }

        private static void UrlCheck(ref string url)
        {
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                url = "http://" + url;
        }
    }
}
