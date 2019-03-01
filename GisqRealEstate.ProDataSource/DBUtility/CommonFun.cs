using System;
using System.IO;
using System.Xml;
using System.Text;
using System.Data;
using System.Net;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using GisqRealEstate.ProDataSource.DBUtility;

namespace GisqRealEstate.ProDataSource
{
	/// <summary>
	/// 公用类
	/// </summary>
    public class CommonFun
    {
        /// <summary>
        /// DataTable 转换为 Object[]，用于EXT控件绑定
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <returns></returns>
        public static Object[] DataTableToObject(System.Data.DataTable dt)
        {
            int iRows = dt.Rows.Count;
            int iCols = dt.Columns.Count;
            Object[] objList = new Object[iRows];
            for (int i = 0; i < iRows; i++)
            {
                Object[] objItem = new Object[iCols];

                for (int j = 0; j < iCols; j++)
                {
                    objItem[j] = dt.Rows[i][j].ToString();
                }
                objList[i] = objItem;
            }
            return objList;
        }

        public static List<object> DataTableToList(System.Data.DataTable dt)
        {
            int iRows = dt.Rows.Count;
            int iCols = dt.Columns.Count;
            List<object> objList = new List<object>();
            for (int i = 0; i < iRows; i++)
            {
                Object[] objItem = new Object[iCols];
                for (int j = 0; j < iCols; j++)
                {
                    objItem[j] = dt.Rows[i][j].ToString();
                }
                objList.Add(objItem);
            }

            return objList;
        }
        //*************************************************************************************************
        /// <summary>
        /// DataTable 转化为 Json
        /// </summary>
        public static string DataTableToJson( System.Data.DataTable dt )
        {

            String  json = SerializeObject(dt);
            return json;
            //if( dt == null )
            //{
            //    return "";
            //}

            //StringBuilder jsonString = new StringBuilder();

            //string temp = "";
            //string value = "";

            ////jsonString.Append( "{\"" + dt.TableName.ToLower() + "\":[" );
            //jsonString.Append( "[" );

            //foreach( DataRow dr in dt.Rows )
            //{
            //    temp = "";

            //    jsonString.Append( "{" );

            //    foreach( DataColumn dc in dt.Columns )
            //    {
            //        value = dr[dc].ToString();

            //        if( value.Length < 1 )
            //        {
            //            value = " ";
            //        }

            //        temp += "\"" + dc.ColumnName.ToLower() + "\":\"" + value + "\",";
            //    }

            //    temp = temp.TrimEnd( ',' );

            //    jsonString.Append( temp + "}," );
            //}

            //temp = jsonString.ToString();
            //temp = temp.TrimEnd( ',' );

            ////return temp + "]}";
            //temp = temp.Replace("\r\n", "").Replace("\r","").Replace("\n","") ;

            //return temp + "]";

        }

        public static string SerializeObject(DataTable dt)
        {

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            javaScriptSerializer.MaxJsonLength = Int32.MaxValue; //取得最大数值
            ArrayList arrayList = new ArrayList();
            foreach (DataRow dataRow in dt.Rows)
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>();  //实例化一个参数集合
                foreach (DataColumn dataColumn in dt.Columns)
                {
                    dictionary.Add(dataColumn.ColumnName, dataRow[dataColumn.ColumnName].ToStr());
                }
                arrayList.Add(dictionary); //ArrayList集合中添加键值
            }

            return javaScriptSerializer.Serialize(arrayList);  //返回一个json字符串
        }

        /// <summary>
        /// DataTable 转化为 Json,zcc,20090522,截取json，用于分页
        /// </summary>
        public static string DataTableToJson(System.Data.DataTable dt,string strRoot,int intStart,int intLimit,int intCount)
        {
            if (dt == null)
            {
                return "";
            }

            StringBuilder jsonString = new StringBuilder();

            string temp = "";
            string value = "";

            //jsonString.Append( "{\"" + dt.TableName.ToLower() + "\":[" );
            jsonString.Append("{'" + strRoot + "':[");
            //jsonString.Append("[");

            //foreach (DataRow dr in dt.Rows)
            if (intLimit > dt.Rows.Count) intLimit = dt.Rows.Count;
            for (int i = intStart; i < intLimit; i++)
            {
                temp = "";

                jsonString.Append("{");

                foreach (DataColumn dc in dt.Columns)
                {
                    value = dt.Rows[i][dc].ToString();

                    if (value.Length < 1)
                    {
                        value = " ";
                    }

                    temp += "\"" + dc.ColumnName.ToUpper() + "\":\"" + value + "\",";
                }

                temp = temp.TrimEnd(',');

                jsonString.Append(temp + "},");
            }

            temp = jsonString.ToString();
            temp = temp.TrimEnd(',');

            //return temp + "]}";
            temp = temp.Replace("\r\n", "");
            temp = temp + "],'totalCount':" + intCount + "}";
            return temp;

        }
		//****************************************************************************************************
		/// <summary>
		///   不带名称的纯二维Json数组
		/// </summary>
		/// <param name="dt"></param>
		/// <returns></returns>
        public static string DtToJson(System.Data.DataTable dt)
		{
			if( dt == null )
			{
				return "";
			}
			StringBuilder jsonString = new StringBuilder();

			string temp = "";
			string value = "";
			jsonString.Append( "[" );
			foreach( DataRow dr in dt.Rows )
			{
				temp = "";

				jsonString.Append( "[" );

				foreach( DataColumn dc in dt.Columns )
				{
					value = dr[dc].ToString();

					if( value.Length < 1 )
					{
						value = " ";
					}

					temp += "\""  + value + "\",";
				}

				temp = temp.TrimEnd( ',' );

				jsonString.Append( temp + "]," );
			}

			temp = jsonString.ToString();
			temp = temp.TrimEnd( ',' );
			
			return temp + "]";
		}
        //****************************************************************************************************
        /// <summary>
        /// Hashtable 转化为 Json
        /// </summary>
        public static string HashtableToJson( Hashtable ht, string name )
        {
            if( ht == null || ht.Count < 1 )
            {
                return "";
            }

            StringBuilder jsonString = new StringBuilder();

            jsonString.Append( "{\"" + name.ToLower() + "\":[" );

            foreach( string key in ht.Keys )
            {
                jsonString.Append( "{\"value\":\"" + key + "\",\"text\":\"" + ht[key].ToString() + "\"}," );
            }

            return jsonString.ToString().TrimEnd( ',' ) + "]}";
        }
        //****************************************************************************************************

        /// <summary>
        /// 用反射的方式获取DLL的当前物理路径
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetDllPath(Object obj)
        {
            //   Get   the   DLL   file   Path  
            string DLLPathWithDLLName = System.Reflection.Assembly.GetAssembly( obj.GetType()).CodeBase.Substring(8);

            //截取掉DLL的文件名，得到DLL当前的路径  
            int Length = DLLPathWithDLLName.LastIndexOf("/");
            string DLLPath = DLLPathWithDLLName.Substring(0, Length);
            return DLLPath;
        }

        /// </summary>
        /// <param name="DateTime1">第一个日期和时间</param>
        /// <param name="DateTime2">第二个日期和时间</param>
        /// <returns></returns>
        public static string DateDiff(DateTime DateTime1, DateTime DateTime2)
        {
            string dateDiff = null;
            try
            {
                TimeSpan ts1 = new TimeSpan(DateTime1.Ticks);
                TimeSpan ts2 = new TimeSpan(DateTime2.Ticks);
                TimeSpan ts = ts1.Subtract(ts2).Duration();
                if (ts.Days > 0)
                {
                    dateDiff += ts.Days.ToString() + "天";
                }
                if (ts.Hours > 0)
                {
                    dateDiff += ts.Hours.ToString() + "小时";
                }
                if (ts.Minutes > 0)
                {
                    dateDiff += ts.Minutes.ToString() + "分钟";
                }
                if (ts.Seconds > 0)
                {
                    dateDiff += ts.Seconds.ToString() + "秒";
                }
            }
            catch
            {

            }
            return dateDiff;
        }

        /// <summary>
        /// 解决数据库SQL语句中IN里面字段数量大于1000的问题
        /// </summary>
        /// <param name="sqlParam">IN里面的参数数组，用逗号隔开，如'a','b','c'</param>
        /// <param name="columnName">字段名称</param>
        /// <returns>select t.* from TEST t where t.A in (59,60) or t.A in (61,62)</returns>
        public static string GetSqlIn(string sqlParam, string columnName)
        {
            string[] strArray = sqlParam.Split(',');
            string strTemp = "";//t.A in (59,60) or t.A in (61,62) 返回的结果
            if ((strArray.Length == 0 || strArray.Length == 1) && sqlParam != "")//如果只有一个元素或者为空，返回本身字符串
            {
                strTemp = columnName + " = " + sqlParam;
            }
            if (strArray.Length > 1)
            {
                for (int i = 0; i < strArray.Length; i++)
                {
                    if (i == 0)//第一个元素
                    {
                        strTemp += columnName + " in " + " (" + strArray[i];
                    }
                    else if (i % 1000 == 0 && i != strArray.Length - 1)//1000的倍数并且不是数组的最后一个元素
                    {
                        strTemp += ") or " + columnName + " in (" + strArray[i];
                    }
                    else if (i == strArray.Length - 1)//最后一个元素
                    {
                        strTemp += "," + strArray[i] + ")";
                    }
                    else//不是第一个元素，不是1000的倍数，不是最后一个元素
                    {
                        strTemp += "," + strArray[i];
                    }
                }
            }
            if (strTemp == "")
            {
                strTemp = " 1 = 0 ";//删除时防止全部删除
            }
            return strTemp;
        }

        /// <summary>
        /// 解决服务器端返回中文字符的乱码问题，在客户端javascript中要使用unescape方法
        /// </summary>
        /// <param name="s">要返回的字符</param>
        /// <returns>Escape编码后的字符</returns>
        public static string Escape(string s)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            byte[] ba = System.Text.Encoding.Unicode.GetBytes(s);
            for (int i = 0; i < ba.Length; i += 2)
            {
                if (ba[i + 1] == 0)
                {
                    //数字,大小写字母,以及"+-*/._"不变
                    if (
                          (ba[i] >= 48 && ba[i] <= 57)
                        || (ba[i] >= 64 && ba[i] <= 90)
                        || (ba[i] >= 97 && ba[i] <= 122)
                        || (ba[i] == 42 || ba[i] == 43 || ba[i] == 45 || ba[i] == 46 || ba[i] == 47 || ba[i] == 95)
                        )//保持不变
                    {
                        sb.Append(Encoding.Unicode.GetString(ba, i, 2));
                    }
                    else//%xx形式
                    {
                        sb.Append("%");
                        sb.Append(ba[i].ToString("X2"));
                    }
                }
                else
                {
                    sb.Append("%u");
                    sb.Append(ba[i + 1].ToString("X2"));
                    sb.Append(ba[i].ToString("X2"));
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 组合两个日期之间的条件查询语句
        /// </summary>
        /// <param name="strField">查询字段名称</param>
        /// <param name="strBeginDate">开始日期</param>
        /// <param name="strEndDate">结束日期</param>
        /// <returns>返回脚本</returns>
        public static string BetweenDateSql(string strField, string strBeginDate, string strEndDate)
        {
            string strSql = "";

            try
            {
                if (GisqLandProDataSourceFactory.databaseType == DataSourceType.DB_Oracle)
                {
                    strSql = " and " + strField + " >= to_date('" + strBeginDate + "','YYYY-MM-DD')"
                        + " and " + strField + "< to_date('" + strEndDate + "','YYYY-MM-DD')";                    
                }
                else
                {                   
                    strSql = " and " + strField + " BETWEEN CAST('" + strBeginDate + "' AS DATETIME) "
                        + " AND  CAST('" + strEndDate + "' AS DATETIME)";   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strSql;
        }

        /// <summary>
        /// 组合两个日期之间的条件查询语句
        /// </summary>
        /// <param name="strField">查询字段名称</param>
        /// <param name="strBeginDate">开始日期</param>
        /// <param name="strEndDate">结束日期</param>
        /// <param name="blnIsLastEqual">是否是:小于等于的形式,默认情况下是:小于不等于</param>
        /// <returns>返回脚本</returns>
        public static string BetweenDateSql(string strField, string strBeginDate, string strEndDate,bool blnIsLastEqual)
        {
            string strSql = "";

            try
            {
                if (blnIsLastEqual && !string.IsNullOrEmpty(strEndDate))
                {
                    try
                    {
                        strEndDate = (Convert.ToDateTime(strEndDate).AddDays(1)).ToString("yyyy-MM-dd");
                    }
                    catch { }
                }

                if (GisqLandProDataSourceFactory.databaseType == DataSourceType.DB_Oracle)
                {
                    ///modify by wangzm(2009-9-30)
                    //strSql = " and " + strField + " >= to_date('" + strBeginDate + "','YYYY-MM-DD')"
                    //    + " and " + strField + "< to_date('" + strEndDate + "','YYYY-MM-DD')";
                    if (!string.IsNullOrEmpty(strBeginDate))
                    {
                        strSql += " and " + strField + " >= to_date('" + strBeginDate + "','YYYY-MM-DD') ";
                    }
                    if (!string.IsNullOrEmpty(strEndDate))
                    {
                        strSql += " and " + strField + "< to_date('" + strEndDate + "','YYYY-MM-DD') ";
                    }
                    ///end modify
                }
                else
                {
                    ///modify by wangzm(2009-9-30)
                    //strSql = " and " + strField + " BETWEEN CAST('" + strBeginDate + "' AS DATETIME) "
                    //    + " AND  CAST('" + strEndDate + "' AS DATETIME)";
                    if (!string.IsNullOrEmpty(strBeginDate))
                    {
                        strSql += " and " + strField + " >= '" + strBeginDate + "' ";
                    }
                    if (!string.IsNullOrEmpty(strEndDate))
                    {
                        strSql += " and " + strField + " < '" + strEndDate + "' ";
                    }
                    ///end modify
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strSql;
        }

        /// <summary>
        /// 组合两个日期之间的条件查询语句
        /// </summary>
        /// <param name="strField">查询字段名称</param>
        /// <param name="strBeginDate">开始日期</param>
        /// <param name="strEndDate">结束日期</param>
        /// <returns>返回脚本</returns>
        public static string BetweenDateSql(string strField, string strBeginDate, string strEndDate, bool blnIsLastEqual, bool isHaveAndInBegin, bool isForDataTable)
        {
            string strSql = "";

            try
            {
                if (blnIsLastEqual && !string.IsNullOrEmpty(strEndDate))
                {
                    try
                    {
                        strEndDate = (Convert.ToDateTime(strEndDate).AddDays(1)).ToString("yyyy-MM-dd");
                    }
                    catch { }
                }


                if (isForDataTable)
                {
                    if (!string.IsNullOrEmpty(strBeginDate))
                    {
                        strSql += " and " + strField + " >= #" + strBeginDate + "#";
                    }
                    if (!string.IsNullOrEmpty(strEndDate))
                    {
                        strSql += " and " + strField + "< #" + strEndDate + "#";
                    }
                }
                else
                {
                    strSql = BetweenDateSql(strField, strBeginDate, strEndDate,blnIsLastEqual);
                }
                if (!isHaveAndInBegin)
                {
                    int iAndBegin = strSql.IndexOf("and");
                    if (iAndBegin == 0 || iAndBegin == 1)
                    {
                        strSql = strSql.Substring(iAndBegin + 3);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strSql;
        }

        public static string NotEqualDateSql(string strField, string strDate)
        {
            string strSql = "";

            try
            {
                if (GisqLandProDataSourceFactory.databaseType == DataSourceType.DB_Oracle)
                {
                    if (!string.IsNullOrEmpty(strDate))
                    {
                        strSql += " and " + strField + " <> to_date('" + strDate + "','YYYY-MM-DD') ";
                    }                  
                }
                else
                {
                    if (!string.IsNullOrEmpty(strDate))
                    {
                        strSql += " and " + strField + " <> '" + strDate + "' ";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strSql;
        }
        public static string EqualDateSql(string strField, string strDate, bool isHaveAndInBegin)
        {
            return BetweenDateSql(strField, strDate, strDate, true, isHaveAndInBegin, false);
        }

        /// <summary>
        /// 日期格式化为 YYYY-MM-DD
        /// </summary>
        /// <param name="strField">需要格式化的字段</param>
        /// <returns>返回sql语句</returns>
        public static string FormatDateSql(string strField)
        {
            string strSql = "";

            try
            {
                if (GisqLandProDataSourceFactory.databaseType == DataSourceType.DB_Oracle)
                {
                    strSql = " to_char(" + strField + ",'YYYY-MM-DD') ";
                }
                else
                {
                    strSql = " CONVERT(varchar, " + strField + ", 23) ";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strSql;
        }

        /// <summary>
        /// 对于数据库不同，对日期进行格式转换（返回带有时间的日期格式）
        /// </summary>
        /// <param name="strValue">要格式化的日期字符串</param>
        /// <returns>返回日期格式sql字符串(返回长日期格式)</returns>
        public static string InsertDateSql(string strValue)
        {
            return InsertDateSql(strValue,true);
        }

        /// <summary>
        /// 对于数据库不同，对日期进行格式转换（是否带有时间的日期）
        /// </summary>
        /// <param name="strValue">要格式化的日期字符串</param>
        /// <param name="blnShortDate">是否是带有时间的日期格式</param>
        /// <returns>返回日期格式sql字符串</returns>
        public static string InsertDateSql(string strValue, bool blnHasTime)
        {
            if (GisqLandProDataSourceFactory.databaseType == DataSourceType.DB_Oracle)
            {
                if (blnHasTime)
                    strValue = " to_date('" + strValue + "','YYYY-MM-DD HH24:MI:SS') ";
                else
                    strValue = " to_date('" + strValue + "','YYYY-MM-DD') ";
            }
            else
            {
                if (blnHasTime)
                    strValue = " '" + strValue + "' ";
                else
                    strValue = " CONVERT(varchar, '" + strValue + "', 23) ";
            }

            return strValue;
        }

        /// <summary>
        /// 针对带列名的json串转换成DataTable
        /// </summary>
        /// <param name="p_strJson"></param>
        /// <returns></returns>
        static public DataTable JsonToDataTable(String p_strJson)
        {
            if (String.IsNullOrEmpty(p_strJson))
            {
                return null;
            }

            DataTable dtRet = new DataTable();
            ///由于.*不含回车与换行,所以当出现这样字符时,会有错误,要特别注意啊.....
            //String strRxOneRow = "[\\[,]\\{\"(.|\\s)*?\"\\}[\\],]";
            string strRxOneRow = @"\{.*?\}";
            Regex rx = new Regex(strRxOneRow);
            int iNextRowBeginIndex = 0;
            Match match = null;
            //bool isFirstMatch = true;

            do
            {
                match = rx.Match(p_strJson, iNextRowBeginIndex);
                if (match.Success)
                {
                    //isFirstMatch = false;
                    String strOneRow = match.Groups[0].Value;
                    try
                    {
                        AddOneDataRow(ref dtRet, strOneRow);
                    }
                    catch { throw new Exception("生成的行不对"); }

                    ///由于上面一行把两行之间的 , 号配到了,所以下次要把上面一次的逗号含在内,故要减1
                    iNextRowBeginIndex = match.Index + strOneRow.Length - 1;
                }
                //else
                //{
                //    if (isFirstMatch)
                //    {
                //        ///只存在一行的时候
                //        AddOneDataRow(ref dtRet, p_strJson);
                //    }
                //}
            } while (match.Success);

            return dtRet;
        }

        /// <summary>
        /// 列值不能含 ","  ":"  [{"   ,{"  "},  "}]
        /// </summary>
        /// <param name="r_dt"></param>
        /// <param name="strOneRow">表中一行的json字符串</param>
        private static void AddOneDataRow(ref DataTable r_dt, string strOneRow)
        {
            if (String.IsNullOrEmpty(strOneRow))
            {
                return;
            }
            //去头," 号不要去掉,后面统一去
            //String strRxHead = "[\\[,]\\{(\")?";
            string strRxHead = "\\{\"?";
            Regex rx = new Regex(strRxHead);
            strOneRow = rx.Replace(strOneRow, "");

            //去尾
            //String strRxLast = "(\")?\\}[\\],]";
            string strRxLast = "\"?\\}";
            rx = new Regex(strRxLast);
            strOneRow = rx.Replace(strOneRow, "");

            Boolean isFirstAddRow = true;
            if (r_dt.Rows.Count > 0)
            {
                isFirstAddRow = false;
            }

            ///正常情况下为     "a":"b","c":"d"
            ///为了防止出现     
            ///                 ",":",","c":"d"     "/,":"/,","c":"d"
            ///                 ":":":","c":"d"     "/:":"/:","c":"d"
            ///                 "a":333,"b":44      
            #region Exception1
            rx = new Regex(":\",\"");
            strOneRow = rx.Replace(strOneRow, ":\"/,\"");
            rx = new Regex("\",\":");
            strOneRow = rx.Replace(strOneRow, "\"/,\":");
            rx = new Regex(":\":\"");
            strOneRow = rx.Replace(strOneRow, ":\"/:\"");
            rx = new Regex("\":\":");
            strOneRow = rx.Replace(strOneRow, "\"/:\":");
            rx = new Regex(":[^\"]");

            Match match = null;
            int iBegin = 0;
            do
            {
                match = rx.Match(strOneRow, iBegin);
                if (match.Success)
                {
                    strOneRow = strOneRow.Insert(match.Index + 1, "\"");
                    iBegin = match.Index + match.Length;
                }
                else
                {
                    break;
                }
            }
            while (iBegin < strOneRow.Length);

            rx = new Regex("[^\"],");
            iBegin = 0;
            do
            {
                match = rx.Match(strOneRow, iBegin);
                if (match.Success)
                {
                    strOneRow = strOneRow.Insert(match.Index + 1, "\"");
                    iBegin = match.Index + match.Length;
                }
                else
                {
                    break;
                }
            }
            while (iBegin < strOneRow.Length);
            #endregion

            DataRow dr = null;
            ArrayList strCols = ToSplitStringByString(strOneRow, "\",\"");
            for (int i = 0; i < strCols.Count; ++i)
            {
                ArrayList strOneCol = ToSplitStringByString(strCols[i].ToString(), "\":\"");
                //去掉列名,与值的最前与最后的 " 号
                if (String.IsNullOrEmpty(strOneCol[0].ToString()))
                {
                    continue;
                }

                #region Exception1
                if (strOneCol.Count > 1)
                {
                    if (strOneCol[0].ToString().Equals("/,") || strOneCol[0].ToString().Equals("/:"))
                    {
                        strOneCol[0] = strOneCol[0].ToString().Remove(0, 1);
                    }
                    if (strOneCol[1].ToString().Equals("/,") || strOneCol[1].ToString().Equals("/:"))
                    {
                        strOneCol[1] = strOneCol[1].ToString().Remove(0, 1);
                    }
                }
                #endregion

                if (strOneCol.Count == 2)
                {
                    ///认为列名,最后的 ,最前的 " 号也被split掉了
                    if (isFirstAddRow)
                    {
                        ///如果不是第一行,则不用添加列,认为前面行把列已经定好了
                        try
                        {
                            ///不管这列存在与否,都先认为它不存在
                            r_dt.Columns.Add(strOneCol[0].ToString().ToUpper());
                        }
                        catch { }
                    }
                    if (i == 0)
                    {
                        ///每一个列,用新建一行,但后面的列,还是在第一个列添加进去的行中加列,所以要用下面的else
                        dr = r_dt.NewRow();
                    }
                    else
                    {
                        dr = r_dt.Rows[r_dt.Rows.Count - 1];
                    }
                    dr[strOneCol[0].ToString()] = strOneCol[1];
                    if (i == 0)
                    {
                        r_dt.Rows.Add(dr);
                    }
                }
            }
        }

        /// <summary>
        /// 把长字符串,以小字符串进行分开,长字符串格式为content&&content&&......&&
        /// 小字符串为&&,最后必须以&&结尾(这是格式).9 7
        /// </summary>
        /// <param name="p_strContent">待折分的长字符串</param>
        /// <param name="p_strSubString">用作分隔符的字符串</param>
        /// <returns></returns>
        private static ArrayList ToSplitStringByString(string p_strContent, string p_strSubString)
        {
            ArrayList al = new ArrayList();
            int iBegin = 0, iEnd = 0;
            if (string.IsNullOrEmpty(p_strContent))
            {
                return al;
            }
            if (p_strContent.LastIndexOf(p_strSubString) != (p_strContent.Length - p_strSubString.Length))
            {
                p_strContent += p_strSubString;
            }
            iEnd = p_strContent.IndexOf(p_strSubString);

            while (iBegin < p_strContent.Length && iEnd > 0 && iEnd != (p_strContent.Length - p_strContent.Length))
            {
                string str = p_strContent.Substring(iBegin, iEnd - iBegin);
                al.Add(str);
                iBegin = iEnd + p_strSubString.Length;
                iEnd = p_strContent.IndexOf(p_strSubString, iBegin);
            }
            return al;
        }

        #region HTTP请求
        public static string RequestGet(string TheURL)
        {
            Uri uri = new Uri(TheURL);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

            string page;
            try
            {
                request.KeepAlive = false;
                request.ProtocolVersion = HttpVersion.Version10;

                request.Method = "GET";

                request.ContentType = "application/x-www-form-urlencoded";

                request.Proxy = WebRequest.GetSystemWebProxy();
                //allow auto redirects from redirect headers
                request.AllowAutoRedirect = true;

                //maximum of 10 auto redirects
                request.MaximumAutomaticRedirections = 10;

                //30 second timeout for request
                request.Timeout = (int)new TimeSpan(0, 0, 60).TotalMilliseconds;

                //give the crawler a name.
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";
                //request.UserAgent="Mozilla/3.0 (compatible; My Browser/1.0)";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(responseStream, System.Text.Encoding.Default);
                page = readStream.ReadToEnd();
            }
            catch (Exception ee)
            {
                page = "Fail message : " + ee.Message;
            }
            return page;

        }
        #endregion

        #region
        //获得关键子 
        public static bool CheckKey(string Content)
        {
            int n = -1;
            string str = "'|&quot|and|exec|insert|select|delete|update|count|*|%|chr|mid|master|truncate|char|declare|''|--|;|；|or";
            String[] Array = str.Split('|');
            foreach (string item in Array)
            {
                int index = Content.IndexOf(item);
                if (index != -1)
                {
                    n = index;
                    break;
                }

            }
            if (n > -1)
            {
                return true;//存在非法字符
            }
            else
            {
                return false;
            }
        } 

        #endregion

        /// <summary>
        /// 将xml加载到DataSet
        /// </summary>
        /// <param name="strXml">xml字符串</param>
        /// <returns></returns>
        public static DataSet XmlToDataSet(string strXml)
        {
            StringReader stringReader = null;
            XmlTextReader xmlReader = null;
            try
            {
                DataSet ds = new DataSet();
                stringReader = new StringReader(strXml);
                xmlReader = new XmlTextReader(stringReader);
                ds.ReadXml(xmlReader);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (stringReader != null) stringReader.Close();
                if (xmlReader != null) xmlReader.Close();
            }
        }

        /// <summary>
        /// 将xml加载到DataSet
        /// </summary>
        /// <param name="xmlDoc">xml文档</param>
        /// <returns></returns>
        public static DataSet XmlToDataSet(XmlDocument xmlDoc)
        {
            return XmlToDataSet(xmlDoc.InnerXml);
        }

       
    }
}
