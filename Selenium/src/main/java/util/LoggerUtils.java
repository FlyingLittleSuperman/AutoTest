package util;

import configSelenium.StaticValue;
import org.testng.Reporter;

import java.io.PrintWriter;
import java.io.StringWriter;


/**
 * Created by Administrator on 2016/12/26.
 */
public class LoggerUtils {
    private static org.apache.log4j.Logger log = null;

    static {
        try {
            if (log == null) {
                System.setProperty("logPath", StaticValue.ApplicationPath);
                log = org.apache.log4j.Logger.getLogger(LoggerUtils.class);
            }
        } catch (Exception er) {
            er.printStackTrace();
        }
    }


    public static void info(String msg) {
        log.info(msg);
    }

    public static void debug(String msg) {
        log.info(msg);
    }

    public static void error(String msg) {
        log.info(msg);
        Reporter.log(msg);
    }


    /**
     * 记录Exception 详细错误信息
     *
     * @param er
     */
    public static void error(Exception er) {
        StringWriter sw = new StringWriter();
        PrintWriter pw = new PrintWriter(sw);
        er.printStackTrace(pw);
        log.error(sw.toString());
        Reporter.log(sw.toString());
    }

    /**
     * 返回处理错误信息
     *
     * @param er
     * @return
     */
    public static String DealErrorMsg(Exception er) {
        String msg = er.getMessage();
        if (msg == null) {
            msg = er.toString();
        }
        return msg;
    }

}
