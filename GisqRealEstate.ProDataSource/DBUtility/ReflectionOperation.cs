using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace GisqRealEstate.ProDataSource
{
    [Serializable]
    public class ReflectionOperation : ISerializable
    {
        //private bool m_isAllowToNoPublic = false;
        //public bool IsAllowToNoPublic
        //{
        //    get { return m_isAllowToNoPublic; }
        //    set {
        //        m_isAllowToNoPublic = value;
        //        if (m_isAllowToNoPublic)
        //        {
        //            m_bfNoPluic = BindingFlags.NonPublic|BindingFlags.Instance;
        //        }
        //    }
        //}
        /// <summary>
        /// 当找不到对应属性与方法时，是否抛出异常
        /// </summary>
        public bool IsThrowException = true;

        /// <summary>
        /// 是否是对静态方法或属性进行操作
        /// </summary>
        public bool IsStaticReflection
        {
            set
            {
                if (value)
                {
                    m_bfNoPluic = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static;
                }
            }
        }

        private BindingFlags m_bfNoPluic = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance;
        public BindingFlags FindFlags
        {
            get { return m_bfNoPluic; }
            set { m_bfNoPluic = value; }
        }

        private Type m_type = null;
        private object m_object = null;
        private object[] m_createInstanceParams = null;


        /// <summary>
        /// 将从指定对象中取它的属性，或调用相应方法，即不新建实例 
        /// </summary>
        /// <param name="p_obj">外面实例化了的对象，且这个对象上的属性值可能有所改变</param>
        public ReflectionOperation(object p_obj)
        {
            m_object = p_obj;
            m_type = m_object.GetType();
        }

        /// <summary>
        /// 用反射把实例的成员变量值改变后，但不用反射把基类装厢后成员变量的值又还原到原来状态
        /// 即用反射改变成员的值只在反射调用有效，但用非反射再调时，就没有感觉是被反射改变过的一样
        /// 就是反射改变属性的值不太好用，注意：改变有时无效，只有在用反射改变，且取时也用反射取
        /// </summary>
        /// <param name="p_type">动态创建的实例类型，传的是接口的话，这类型是它的最终子类的类型</param>
        public ReflectionOperation(Type p_type, object[] p_createInstanceParams)
        {
            m_type = p_type;
            m_createInstanceParams = p_createInstanceParams;

            m_object = m_type.InvokeMember(null,
                BindingFlags.DeclaredOnly |
                BindingFlags.Public | BindingFlags.NonPublic |
                BindingFlags.Instance | BindingFlags.CreateInstance, null, null, p_createInstanceParams);
        }

        public ReflectionOperation(Type p_type)
        {
            m_type = p_type;
            IsStaticReflection = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_assembly">编译出的DLL名</param>
        /// <param name="p_strClsName">命名空间.类名</param>
        /// <param name="p_createInstanceParams">初始化函数的参数</param>
        public ReflectionOperation(Assembly p_assembly, string p_strClsName, object[] p_createInstanceParams)
        {
            try
            {
                m_type = p_assembly.GetType(p_strClsName);
                m_createInstanceParams = p_createInstanceParams;

                m_object = m_type.InvokeMember(null,
                    BindingFlags.DeclaredOnly |
                    BindingFlags.Public | BindingFlags.NonPublic |
                    BindingFlags.Instance | BindingFlags.CreateInstance, null, null, p_createInstanceParams);
            }
            catch (Exception x)
            {
                throw new Exception(x.Message + "," + p_strClsName);
            }
        }

        /// <summary>
        /// 二参只用传其一则可
        /// </summary>
        /// <param name="p_strAssemblyFilePath">dll绝对路径</param>
        /// <param name="p_strAssemblyName">命名空间,会找调用时dll的同路径下的文件</param>
        /// <returns></returns>
        static public Assembly GetAssembly(string p_strAssemblyFilePath, string p_strAssemblyName)
        {
            Assembly assembly = null;
            if (!string.IsNullOrEmpty(p_strAssemblyFilePath))
            {
                assembly = Assembly.LoadFrom(p_strAssemblyFilePath);
            }
            else if (!string.IsNullOrEmpty(p_strAssemblyName))
            {
                assembly = Assembly.Load(p_strAssemblyName);
            }
            else
            {
                assembly = typeof(ReflectionOperation).Assembly;
            }

            return assembly;
        }

        /// <summary>
        /// 创建并返回实例
        /// </summary>
        public object Instance
        {
            get
            {
                return Activator.CreateInstance(m_type, m_createInstanceParams);
            }
        }

        /// <summary>
        /// 设置　属性/成员变量的值
        /// </summary>
        /// <param name="p_attriName">属性/成员变量名</param>
        /// <param name="p_params">值</param>
        public void SetFiledValue(string p_attriName, object[] p_params)
        {
            try
            {
                m_type.InvokeMember(p_attriName, m_bfNoPluic | BindingFlags.SetProperty, null, m_object, p_params);
                return;
            }
            catch
            {
            }

            try
            {
                m_type.InvokeMember(p_attriName, m_bfNoPluic | BindingFlags.SetField, null, m_object, p_params);
            }
            catch (Exception ex)
            {
                if (IsThrowException)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// 获取　属性/成员变量的值
        /// </summary>
        /// <param name="p_fieldName">属性/成员变量名</param>
        /// <returns></returns>
        public object GetFiledValue(string p_fieldName)
        {
            try
            {
                return m_type.InvokeMember(p_fieldName, m_bfNoPluic | BindingFlags.GetProperty, null, m_object, null);
            }
            catch
            { }
            try
            {
                return m_type.InvokeMember(p_fieldName, m_bfNoPluic | BindingFlags.GetField, null, m_object, null);
            }
            catch (Exception ex)
            {
                if (IsThrowException)
                {
                    throw ex;
                }
            }
            return null;
        }

        /// <summary>
        /// 取值:针对对象里面的对象的属性,例如 page.hdQlrMc.Text     
        /// </summary>
        /// <param name="p_fieldName"></param>
        /// <returns></returns>
        public object GetFiledValueRecursion(string p_fieldName)
        {
            ReflectionOperation ro = null;
            GetRecursionInfo(p_fieldName, out ro, out p_fieldName);
            return ro.GetFiledValue(p_fieldName);
        }

        /// <summary>
        /// 解析,递归调用
        /// </summary>
        /// <param name="p_strRecursionInvoke">递归调用字符串,例如:page.hdQlrMc.Text </param>
        /// <param name="o_objRo">定位到最后一层对象:hdQlrMc</param>
        /// <param name="o_strLastInvokeField">最后的属性名称或方法名:Text,getValue(...)</param>
        /// <returns></returns>
        public bool GetRecursionInfo(string p_strRecursionInvoke, out ReflectionOperation o_objRo, out string o_strLastInvokeField)
        {
            string[] arrObjs = p_strRecursionInvoke.Split(new char[] { '.' });
            o_objRo = this;
            if (arrObjs.Length > 1)
            {
                for (int i = 0; i < arrObjs.Length - 1; ++i)
                {
                    o_objRo = new ReflectionOperation(o_objRo.GetFiledValue(arrObjs[i]));
                }
            }
            o_strLastInvokeField = arrObjs[arrObjs.Length - 1];

            return true;
        }

        /// <summary>
        /// 赋值:针对对象里面的对象的属性,例如 page.hdQlrMc.Text     
        /// </summary>
        /// <param name="p_fieldName"></param>
        /// <returns></returns>
        public void SetFiledValueRecursion(string p_fieldName, object[] p_params)
        {
            ReflectionOperation ro = null;
            GetRecursionInfo(p_fieldName, out ro, out p_fieldName);
            ro.SetFiledValue(p_fieldName, p_params);
        }

        /// <summary>
        /// 获取 类/方法/变量 的限定Attribute的相应元素值
        /// 例如:   [TEST("test","value"),TEST("1","value")]
        ///         int itest = 0;
        ///         则得到两个Attribute实例
        /// </summary>
        /// <param name="p_obj"></param>
        /// <param name="p_attriName"></param>
        /// <param name="isInherit">是否从继承的基类中找所有属性</param>
        /// <returns></returns>
        public object[] GetClassAttributes(Type tpCls, bool isInherit)
        {
            return tpCls.GetCustomAttributes(isInherit);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tpCls"></param>
        /// <param name="tpAttribute">从这个类的所有属性中找指定类型的属性</param>
        /// <param name="isInherit">是否从继承的基类中找所有属性</param>
        /// <returns></returns>
        public object[] GetClassAttributes(Type tpCls, Type tpAttribute, bool isInherit)
        {
            return tpCls.GetCustomAttributes(tpAttribute, isInherit);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tpCls"></param>
        /// <param name="strMethodName">public的方法名</param>
        /// <param name="isInherit">是否从继承的基类中找这个方法的所有属性</param>
        /// <returns></returns>
        public object[] GetMethodAttributes(Type tpCls, string strMethodName, bool isInherit)
        {
            return tpCls.GetMethod(strMethodName).GetCustomAttributes(isInherit);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tpCls"></param>
        /// <param name="strMethodName"></param>
        /// <param name="tpAttribute">从这个方法的所有属性中找指定类型的属性</param>
        /// <param name="isInherit">是否从继承的基类中找这个方法的所有属性</param>
        /// <returns></returns>
        public object[] GetMethodAttributes(Type tpCls, string strMethodName, Type tpAttribute, bool isInherit)
        {
            return tpCls.GetMethod(strMethodName).GetCustomAttributes(tpAttribute, isInherit);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tpCls"></param>
        /// <param name="strFiledName">public的成员变量名</param>
        /// <param name="isInherit">是否从继承的基类中找这个变量的所有属性</param>        
        /// <returns></returns>
        public object[] GetFieldAttributes(Type tpCls, string strFiledName, bool isInherit)
        {
            return tpCls.GetField(strFiledName).GetCustomAttributes(isInherit);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tpCls"></param>
        /// <param name="strFiledName"></param>
        /// <param name="tpAttribute">从这个变量的所有属性中找指定类型的属性</param>
        /// <param name="isInherit">是否从继承的基类中找这个变量的所有属性</param>
        /// <returns></returns>
        public object[] GetFieldAttributes(Type tpCls, string strFiledName, Type tpAttribute, bool isInherit)
        {
            return tpCls.GetField(strFiledName).GetCustomAttributes(isInherit);
        }

        /// <summary>
        /// 通过 Attribute实例去取它内的相应属性的值
        /// </summary>
        /// <param name="p_attri"></param>
        /// <param name="p_attriName"></param>
        /// <returns></returns>
        public object GetAttributeValue(Attribute p_attri, string p_attriName)
        {
            object objTmp = this.m_object;
            Type tpTmp = this.m_type;
            this.m_object = p_attri;

            this.m_type = p_attri.GetType();
            object objRet = this.GetFiledValue(p_attriName);

            this.m_object = objTmp;
            this.m_type = tpTmp;

            return objRet;
        }

        /// <summary>
        /// 调用方法
        /// </summary>
        /// <param name="p_methodName">方法名</param>
        /// <param name="p_params">参数集</param>
        /// <returns></returns>
        public object InvokeMethod(string p_methodName, object[] p_params)
        {
            try
            {
                return m_type.InvokeMember(p_methodName, m_bfNoPluic | BindingFlags.InvokeMethod, null, m_object, p_params);
            }
            catch (Exception ex)
            {
                if (IsThrowException)
                {
                    throw ex;
                }
            }

            return null;
        }

        public object InvokeMethodRecursion(string p_methodName, object[] p_params)
        {
            ReflectionOperation ro = null;
            GetRecursionInfo(p_methodName, out ro, out p_methodName);
            return ro.InvokeMethod(p_methodName, p_params);
        }


        /// <summary>
        /// 公式解释,将公式中的变量对应成实际值
        /// </summary>
        /// <param name="p_strFormula">公式,含要解析的变量</param>
        /// <param name="p_objResolveParams">公式中用到变量所在的类对象</param>
        /// <returns></returns>
        public static string ResolveFormula(string p_strFormula, object p_objResolveParams)
        {
            ReflectionOperation objReflectOp = new ReflectionOperation(p_objResolveParams);

            Regex rx = new Regex("\\{.*?\\}");
            Match match = rx.Match(p_strFormula);
            while (match.Success)
            {
                string strBindVarName = match.Groups[0].Value.Replace("{", "").Replace("}", "");
                string strVarValue = objReflectOp.GetFiledValue(strBindVarName).ToString();

                p_strFormula = p_strFormula.Replace(match.Groups[0].Value, strVarValue);

                match = match.NextMatch();
            }

            return p_strFormula;
        }


        /// <summary>
        /// 将  dll集序集名->名空间+类名->方法名
        /// 解析出来
        /// </summary>
        /// <param name="p_strHandler"></param>
        /// <param name="o_strAssemblyName"></param>
        /// <param name="o_strClassName"></param>
        /// <param name="o_strMethodName"></param>
        /// <returns></returns>
        public static bool ResolveReflectInvoke(string p_strHandler, out string o_strAssemblyName, out string o_strClassName, out string o_strMethodName)
        {
            bool blRet = false;

            o_strAssemblyName = null;
            o_strClassName = null;
            o_strMethodName = null;

            p_strHandler = p_strHandler.Replace("\n", "").Replace("\r", "");
            p_strHandler = p_strHandler.Trim();

            Regex rx = new Regex(".*->");
            Match match = rx.Match(p_strHandler);

            string strAssemblyAndClass = null;
            int iBegin = p_strHandler.LastIndexOf("->");
            if (iBegin == -1)
            {
                throw new Exception(p_strHandler + ",格式不正确,应以 -> 分隔.");
            }
            o_strMethodName = p_strHandler.Substring(iBegin + 2);
            if (match.Success)
            {
                strAssemblyAndClass = match.Groups[0].Value;
                strAssemblyAndClass = strAssemblyAndClass.Remove(strAssemblyAndClass.Length - 2, 2);

                rx = new Regex(".*->");
                match = rx.Match(strAssemblyAndClass);
                if (match.Success)
                {
                    o_strAssemblyName = match.Groups[0].Value.Replace("->", "");
                    o_strClassName = strAssemblyAndClass.Substring(strAssemblyAndClass.IndexOf("->") + 2);
                    blRet = true;
                }
                else
                {
                    throw new Exception(p_strHandler + ",命名空间与类间分离出错.");
                }
            }
            else
            {
                throw new Exception(p_strHandler + ",格式不正确,应以 -> 分隔.");
            }

            return blRet;
        }

        #region ISerializable 成员

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("IsThrowException", IsThrowException);
            info.AddValue("m_bfNoPluic", m_bfNoPluic);
            info.AddValue("m_type", m_type);
            info.AddValue("m_object", m_object);
            info.AddValue("m_createInstanceParams", m_createInstanceParams);
        }
        private ReflectionOperation(SerializationInfo info, StreamingContext context)
        {
            //IsThrowException = TypeConvert.ToConvert<object, bool>(info.GetValue("IsThrowException", typeof(bool)), false);
            //m_bfNoPluic = TypeConvert.ToConvertEnum<BindingFlags>(TypeConvert.ToConvert<object, string>(info.GetValue("m_bfNoPluic", typeof(BindingFlags)), false));
            //m_type = TypeConvert.ToConvert<object, Type>(info.GetValue("m_type", typeof(Type)), false);
            //m_object = info.GetValue("m_object", typeof(object));
            //m_createInstanceParams = TypeConvert.ToConvert<object, object[]>(info.GetValue("m_createInstanceParams", typeof(object[])), false);
        }

        #endregion
    }
}
