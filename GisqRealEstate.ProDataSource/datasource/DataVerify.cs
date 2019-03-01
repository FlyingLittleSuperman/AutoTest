using System;

namespace GisqRealEstate.ProDataSource
{
	/// <summary>
	/// Verifier 的摘要说明。
	/// </summary>
    public class DataVerify
	{
		public DataVerify()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		/// <summary>
		/// 校验是否为日期格式
		/// </summary>
		/// <param name="Value">要校验的值</param>
		/// <returns>合法日期返回传入值,非法日期返回当前日期值</returns>
		static public DateTime VerifyDateTime(object Value){
			if(DBNull.Value.Equals(Value))
				return DateTime.Now;
			else
			{
				if(Value!=null)
				{
					if(Value.ToString()=="")
						return DateTime.Now;
					return DateTime.Parse(Value.ToString());
				}
				else
					return DateTime.Now;
			}
		}
		/// <summary>
		/// 校验是否为长整型格式
		/// </summary>
		/// <param name="Value">要校验的值</param>
		/// <returns>合法长整型返回传入值,非法长整型返回零</returns>
		static public long VerifyLong(object Value){
			if(DBNull.Value.Equals(Value))
				return 0;
			else
			{
				if((Value!=null)&&(Value.ToString()!="null"))
				{
					if(Value.ToString()=="")
						return 0;					
					return Int64.Parse(Value.ToString());
				}
				else
					return 0;
			}
		}
		/// <summary>
		/// 校验是否为短整型格式
		/// </summary>
		/// <param name="Value">要校验的值</param>
		/// <returns>合法短整型返回传入值,非法短整型返回零</returns>
		static public short VerifyShort(object Value){
			if(DBNull.Value.Equals(Value))
				return 0;
			else
			{
				if(Value!=null)
				{
					if(Value.ToString()=="")
						return 0;
					return Int16.Parse(Value.ToString());
				}
				else
					return 0;
			}
		}
		/// <summary>
		/// 校验是否为整型格式
		/// </summary>
		/// <param name="Value">要校验的值</param>
		/// <returns>合法整型返回传入值,非法整型返回零</returns>
		static public int VerifyInt(object Value){
			if(DBNull.Value.Equals(Value))
				return 0;
			else
			{
				if(Value!=null)
				{
					if(Value.ToString()=="")
						return 0;
					return Int32.Parse(Value.ToString());
				}
				else
					return 0;
			}
		}
		/// <summary>
		/// 校验是否为字符串
		/// </summary>
		/// <param name="Value"></param>
		/// <returns></returns>
		static public string VerifyString(object Value){
			if(DBNull.Value.Equals(Value))
				return "";
			else
			{
				if(Value!=null)
					return Value.ToString();
				else
					return "";
			}
		}	
		/// <summary>
		/// 校验布尔值
		/// </summary>
		/// <param name="Value"></param>
		/// <returns></returns>
		static public bool VerifyBool(object Value){
			if(DBNull.Value.Equals(Value))
				return false;
			else{
				if(Value!=null)
				{
					if(Value.ToString()=="")
						return false;

					if(Value.ToString()=="0")
						return false;
					if(Value.ToString()=="1")
						return true;

					return Boolean.Parse(Value.ToString());

				}
				else
					return false;
			}
		}

		/// <summary>
		/// 校验是否为double型格式
		/// </summary>
		/// <param name="Value">要校验的值</param>
		/// <returns>合法double型返回传入值,非法double型返回零</returns>
		static public double VerifyDouble(object Value)
		{
			if(DBNull.Value.Equals(Value))
				return 0;
			else
			{
				if(Value!=null)
				{
					if(Value.ToString()=="")
						return 0;
					return System.Double.Parse(Value.ToString());
				}
				else
					return 0;
			}
		}

		/// <summary>
		/// 校验是否为single型格式
		/// </summary>
		/// <param name="Value">要校验的值</param>
		/// <returns>合法single型返回传入值,非法single型返回零</returns>
		static public float VerifySingle(object Value)
		{
			if(DBNull.Value.Equals(Value))
				return 0;
			else
			{
				if(Value!=null)
				{
					if(Value.ToString()=="")
						return 0;
					return System.Single.Parse(Value.ToString());
				}
				else
					return 0;
			}
		}

		/// <summary>
		/// 校验是否为字节格式
		/// </summary>
		/// <param name="Value">要校验的值</param>
		/// <returns>合法字节返回传入值,非法字节返回零</returns>
		static public byte VerifyByte(object Value)
		{
			if(System.DBNull.Value.Equals(Value))
				return 0;
			else
			{
				if(Value!=null)
				{
					if(Value.ToString()=="")
						return 0;
					return byte.Parse(Value.ToString());
				}
				else
					return 0;
			}
		}


        /// <summary>
        /// 主要用来判断是否是1899-12-30 0001-1-1等非正常的日期
        /// </summary>
        /// <param name="Value">这里最好传入已经知道是日期格式的值</param>
        /// <returns>正常的日期返回true</returns>
        static public bool IsCorrectDate(object Value)
        {
            if (DBNull.Value.Equals(Value)) return false;
            if (Value == null) return false;
            if (Value.ToString().Length == 0) return false;
            string strDate = Convert.ToDateTime(Value).ToString("yyyy-MM-dd");
            if (strDate == "1899-12-30" || strDate == "0001-01-01") return false;

            return true;
        }

        static public bool IsCorrectDate(object Value, out string o_strDate)
        {
            o_strDate = "";
            bool isCorrect = IsCorrectDate(Value);
            if (isCorrect)
            {
                o_strDate = Convert.ToDateTime(Value).ToString("yyyy-MM-dd");
            }
            return isCorrect;
        }

        /// <summary>
        /// 判断是不是日期格式的值
        /// </summary>
        /// <param name="Value">传入未知格式的值</param>
        /// <returns></returns>
        static public bool IsDate(object Value)
        {
            if (DBNull.Value.Equals(Value)) return false;
            if (Value == null) return false;
            if (Value.ToString().Length == 0) return false;

            DateTime date;
            return DateTime.TryParse(Value.ToString(), out date);
        }

        /// <summary>
        /// 转换成枚举值
        /// </summary>
        /// <typeparam name="OutType">枚举类型</typeparam>
        /// <param name="Value">要转换的值</param>
        /// <returns>返回枚举</returns>
        static public OutType VerifyEnum<OutType>(object Value)
        {
            return (OutType)Enum.Parse(typeof(OutType), Value.ToString());
        }
	}
}
