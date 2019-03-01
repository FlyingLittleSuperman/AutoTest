using System;

namespace SeleniumConfig.CreateAction
{
    public class CreateActionCommon
    {
        public static String  GetXmlPath(String prodefKey,String childProdefId)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory + @"\XML\Prodef_" + prodefKey +"_"+childProdefId+ ".xml";
            return path;
        }
    }
}
