using System;
using System.Text;

namespace SeleniumConfig.CommonClass
{
    public class TypeConvert
    {
        /// <summary>
        /// 类型转换：转不成功时，会抛出异常
        /// </summary>
        /// <typeparam name="InType">转换前的数据类型</typeparam>
        /// <typeparam name="OutType">转换后的数据类型</typeparam>
        /// <param name="p_objInput">要转换的值</param>
        /// <returns></returns>
        static public OutType ToConvert<InType, OutType>(InType p_objInput)
        {
            OutType ret = default(OutType);

            try
            { ///当想把其它类型转换成str时，用上面可能转不成功，转不成功时用下面这种方法
                if (typeof(OutType).Equals(typeof(StringBuilder)))
                {
                    if (p_objInput is StringBuilder)
                    {
                        return (OutType)Convert.ChangeType(p_objInput, typeof(OutType));
                    }
                    StringBuilder sbRet = new StringBuilder(ToConvert<InType, string>(p_objInput));
                    return ToConvert<StringBuilder, OutType>(sbRet);
                }
                else if (typeof(InType).Equals(typeof(StringBuilder)))
                {
                    string str = p_objInput.ToString();
                    return ToConvert<string, OutType>(str);
                }
                else
                {
                    return (OutType)Convert.ChangeType(p_objInput, typeof(OutType));
                }
            }
            catch
            {
                throw new Exception("类型间不能转换");
            }

            return ret;
        }

        /// <summary>
        /// 转换成枚举
        /// </summary>
        /// <typeparam name="OutType"></typeparam>
        /// <param name="p_objInput"></param>
        /// <returns></returns>
        static public OutType ToConvertEnum<OutType>(object p_objInput)
        {
            return (OutType)Enum.Parse(typeof(OutType), p_objInput.ToString());
        }

        /// <summary>
        /// 类型转换
        /// </summary>
        /// <typeparam name="InType">转换前的数据类型</typeparam>
        /// <typeparam name="OutType">转换后的数据类型</typeparam>
        /// <param name="p_objInput">要转换的值</param>
        /// <param name="p_isThrowException">转不成功时，是否抛出异常</param>
        /// <returns></returns>
        static public OutType ToConvert<InType, OutType>(InType p_objInput, bool p_isThrowException)
        {
            OutType ret = default(OutType);
            if (!p_isThrowException)
            {
                try
                {
                    ret = ToConvert<InType, OutType>(p_objInput);
                }
                catch { }
            }
            else
            {
                return ToConvert<InType, OutType>(p_objInput);
            }

            return ret;
        }

        /// <summary>
        /// 对整数取反
        /// </summary>
        /// <returns></returns>
        static public int ToNotInt(int p_value)
        {
            return (int.MaxValue - p_value) - int.MaxValue;
        }

        /// <summary>
        /// 将阿拉伯数字转成中文数字
        /// 例如：1 一，2 二，3 三，4 四...
        /// </summary>
        /// <returns></returns>
        static public string NumToCHN(string p_strNum)
        {
            return p_strNum.Replace("0", "零").Replace("1", "一").Replace("2", "二").Replace("3", "三").Replace("4", "四")
                .Replace("5", "五").Replace("6", "六").Replace("7", "七").Replace("8", "八").Replace("9", "九");
        }

        /// <summary>
        /// 实现四舍五入
        /// 例如：1位有效小数
        /// math.round(1.55)    1.5
        /// math.round(1.551)    1.6
        /// </summary>
        /// <param name="dblValue"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static double Round(double dblValue, int p)
        {
            double dblTmp = Math.Round(dblValue, p);
            if (dblTmp != dblValue)//表示，有舍入或进位操作
            {
                string strTmp = dblValue.ToString() + "1";
                return Math.Round(TypeConvert.ToConvert<string, double>(strTmp, false), p);
            }

            return dblTmp;
        }
    }
}
