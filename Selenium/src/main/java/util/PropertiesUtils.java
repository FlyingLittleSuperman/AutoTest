package util;

import java.io.InputStream;
import java.util.Properties;

/**
 * Created by Administrator on 2016/12/15.
 */
public class PropertiesUtils {

    public static String getM_RestUserName() {
        return m_RestUserName;
    }

    public static String getM_RestPassWord() {
        return m_RestPassWord;
    }

    public static String getM_PackageRestUrlPath() {
        return m_PackageRestUrlPath;
    }

    private static String m_PackageRestUrlPath = null;
    private static String m_RestUserName = null;
    private static String m_RestPassWord = null;

    public static String getM_ActdefRestUrlPath() {
        return m_ActdefRestUrlPath;
    }

    private static String m_ActdefRestUrlPath = null;

    public static String getM_ProdefRestUrlPath() {
        return m_ProdefRestUrlPath;
    }

    private static String m_ProdefRestUrlPath = null;

    static {
        loads();
    }

    synchronized static public void loads() {
        if (m_PackageRestUrlPath == null || m_RestUserName == null
                || m_RestPassWord == null || m_ProdefRestUrlPath == null || m_ActdefRestUrlPath == null) {
            InputStream is = PropertiesUtils.class.getResourceAsStream("/config.properties");
            Properties urlProperties = new Properties();
            try {
                urlProperties.load(is);

                m_PackageRestUrlPath = urlProperties.getProperty("plarform.package.url").toString();
                m_RestUserName = urlProperties.getProperty("platform.username").toString();
                m_RestPassWord = urlProperties.getProperty("paltform.password").toString();
                m_ProdefRestUrlPath = urlProperties.getProperty("platform.prodef.url").toString();
                m_ActdefRestUrlPath = urlProperties.getProperty("paltform.actdef.url").toString();

            } catch (Exception e) {
                System.err.println("不能读取属性文件. " + "请确保url.properties在CLASSPATH指定的路径中");
            }
        }

    }
}
