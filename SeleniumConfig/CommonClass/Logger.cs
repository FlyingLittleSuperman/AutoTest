using log4net;

namespace SeleniumConfig.CommonClass
{
    public class Logger
    {
        private static ILog m_objLog = null;
        public static ILog Log
        {
            get
            {
                if (m_objLog == null)
                {
                    m_objLog = LogManager.Exists("Logger.RollingFile");
                }
                return m_objLog;
            }
        }
    }
}
