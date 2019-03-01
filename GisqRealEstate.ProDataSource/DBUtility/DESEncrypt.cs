using System;
using System.Security.Cryptography;  
using System.Text;
namespace GisqRealEstate.ProDataSource
{
	/// <summary>
	/// DES加密/解密类。
	/// </summary>
	public class DESEncrypt
	{
		public DESEncrypt()
		{			
		}

		#region ========加密======== 
 
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
		public static string Encrypt(string Text) 
		{
			return Encrypt(Text,"GisqLandSystem");
		}
		/// <summary> 
		/// 加密数据 
		/// </summary> 
		/// <param name="Text"></param> 
		/// <param name="sKey"></param> 
		/// <returns></returns> 
		public static string Encrypt(string Text,string sKey) 
		{ 
			DESCryptoServiceProvider des = new DESCryptoServiceProvider(); 
			byte[] inputByteArray; 
			inputByteArray=Encoding.Default.GetBytes(Text); 
			des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8)); 
			des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8)); 
			System.IO.MemoryStream ms=new System.IO.MemoryStream(); 
			CryptoStream cs=new CryptoStream(ms,des.CreateEncryptor(),CryptoStreamMode.Write); 
			cs.Write(inputByteArray,0,inputByteArray.Length); 
			cs.FlushFinalBlock(); 
			StringBuilder ret=new StringBuilder(); 
			foreach( byte b in ms.ToArray()) 
			{ 
				ret.AppendFormat("{0:X2}",b); 
			} 
			return ret.ToString(); 
		} 

		#endregion
		
		#region ========解密======== 
   
 
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
		public static string Decrypt(string Text) 
		{
            return Decrypt(Text, "GisqLandSystem");
		}
		/// <summary> 
		/// 解密数据 
		/// </summary> 
		/// <param name="Text"></param> 
		/// <param name="sKey"></param> 
		/// <returns></returns> 
		public static string Decrypt(string Text,string sKey) 
		{ 
			DESCryptoServiceProvider des = new DESCryptoServiceProvider(); 
			int len; 
			len=Text.Length/2; 
			byte[] inputByteArray = new byte[len]; 
			int x,i; 
			for(x=0;x<len;x++) 
			{ 
				i = Convert.ToInt32(Text.Substring(x * 2, 2), 16); 
				inputByteArray[x]=(byte)i; 
			} 
			des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8)); 
			des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8)); 
			System.IO.MemoryStream ms=new System.IO.MemoryStream(); 
			CryptoStream cs=new CryptoStream(ms,des.CreateDecryptor(),CryptoStreamMode.Write); 
			cs.Write(inputByteArray,0,inputByteArray.Length); 
			cs.FlushFinalBlock(); 
			return Encoding.Default.GetString(ms.ToArray()); 
		} 
 
		#endregion 

        /// <summary>
        /// 老的加密方式（VB那套）
        /// </summary>
        /// <param name="texti"></param>
        /// <param name="salasana"></param>
        /// <param name="OldAlgorithm"></param>
        /// <returns></returns>
        public static string Encrypt(string texti, string salasana, bool OldAlgorithm)
        {
            if (OldAlgorithm == false)
                return Encrypt(texti, salasana);

            int sana = 0;
            double X1 = 0;
            double G = 0;
            string strResult = "";
            double ZS = 0;
            for (int i = 0; i < salasana.Length; i++)
            {
                char a = Convert.ToChar(salasana.Substring(i, 1));
                sana = Convert.ToInt16(a);
                X1 = X1 + sana;
            }
            X1 = (X1 * 0.1) / 6.00;
            ZS = Math.Floor(X1);
            G = 0;

            for (int i = 0; i < texti.Length; i++)
            {
                char a = Convert.ToChar(texti.Substring(i, 1));
                sana = Convert.ToInt16(a);
                G = G + 1;
                if (G == 6) G = 0;
                X1 = 0;
                if (G == 0) X1 = sana - (ZS - 2);
                if (G == 1) X1 = sana + (ZS - 5);
                if (G == 2) X1 = sana - (ZS - 4);
                if (G == 3) X1 = sana + (ZS - 2);
                if (G == 4) X1 = sana - (ZS - 3);
                if (G == 5) X1 = sana + (ZS - 5);
                X1 = X1 + G;
                strResult = strResult + Convert.ToChar(Convert.ToInt16(X1));
            }

            return strResult;
        }

        /// <summary>
        /// 老的解密方式（VB那套）
        /// </summary>
        /// <param name="texti"></param>
        /// <param name="salasana"></param>
        /// <param name="OldAlgorithm"></param>
        /// <returns></returns>
        public static string Decrypt(string texti, string salasana, bool OldAlgorithm)
        {
            if (OldAlgorithm == false)
                return Decrypt(texti, salasana);

            int sana = 0;
            double X1 = 0;
            double G = 0;
            string strResult = "";
            for (int i = 0; i < salasana.Length; i++)
            {
                char a = Convert.ToChar(salasana.Substring(i, 1));
                sana = Convert.ToInt16(a);
                X1 = X1 + sana;
            }
            X1 = (X1 * 0.1) / 6.0;
            double ZS = Math.Floor(X1);
            G = 0;

            for (int i = 0; i < texti.Length; i++)
            {
                char a = Convert.ToChar(texti.Substring(i, 1));
                sana = Convert.ToInt16(a);
                G = G + 1;
                if (G == 6) G = 0;
                X1 = 0;
                if (G == 0) X1 = sana + (ZS - 2);
                if (G == 1) X1 = sana - (ZS - 5);
                if (G == 2) X1 = sana + (ZS - 4);
                if (G == 3) X1 = sana - (ZS - 2);
                if (G == 4) X1 = sana + (ZS - 3);
                if (G == 5) X1 = sana - (ZS - 5);
                X1 = X1 - G;
                strResult = strResult + Convert.ToChar(Convert.ToInt16(X1));
            }

            return strResult;
        }

	}
}
