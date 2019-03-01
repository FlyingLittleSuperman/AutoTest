package configSelenium.Entity.SQL;

import configSelenium.Entity.CommonConfig;
import configSelenium.StaticValue;
import oracle.jdbc.internal.OracleTypes;
import util.CacheUtils;
import util.LoggerUtils;
import util.PropertiesUtils;

import java.io.InputStream;
import java.io.Serializable;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.Properties;

import static util.DataBase.*;

public class SQLprocedures implements Serializable {


    static {
        if (connection == null) {

            Object obj = CacheUtils.get(StaticValue.CommonConfigCacheName, StaticValue.InitParameterKeyName);
            if (obj == null)
                throw new RuntimeException("获取通用配置参数失败！");

            CommonConfig commonConfig = (CommonConfig) obj;
            InputStream is = PropertiesUtils.class.getResourceAsStream("/config.properties");
            Properties urlProperties = new Properties();
            try {
                urlProperties.load(is);

                JdbcDriver = "oracle.jdbc.driver.OracleDriver";
                JdbcUrl = "jdbc:oracle:thin:@" + commonConfig.getServiceIP() + ":1521:" + commonConfig.getDbName();
                JdbcUseName = commonConfig.getDbUserName();
                JdbcPassWord = commonConfig.getDbPassWord();
                Class.forName(JdbcDriver);
                connection = DriverManager.getConnection(JdbcUrl, JdbcUseName, JdbcPassWord);

            } catch (Exception e) {
                LoggerUtils.error(e);
                e.printStackTrace();
            }

            if (connection == null) {
                throw new RuntimeException("获取数据库连接失败！");
            }
        }

        init();
    }

    public static  void init() {
        System.out.println("oracle jdbc test");
        try {
            Class.forName(JdbcDriver);
            System.out.println("JdbcDriver is ok");

            connection = DriverManager.getConnection(JdbcUrl, JdbcUseName, JdbcPassWord);
            System.out.println("conection is ok");

//            statement = connection.createStatement();
//            // conn.setAutoCommit(false);
//
//            //输入参数
//            in_price="3.0";
//
//            //调用函数
//            stmt = conn.prepareCall( "call P_GET_PRICE(?,?,?,?)");
//            stmt.registerOutParameter(1, java.sql.Types.FLOAT);
//            stmt.registerOutParameter(2, java.sql.Types.CHAR);
//            stmt.registerOutParameter(3, oracle.jdbc.OracleTypes.CURSOR);
//            stmt.setString(4, in_price);
//            stmt.executeUpdate();
//            int retCode = stmt.getInt(1);
//            String retMsg = stmt.getString(2);
//            if (retCode == -1) { //如果出错时，返回错误信息
//                System.out.println("报错！");
//            } else {
//                //取的结果集的方式一：
//                rs = ((OracleCallableStatement)stmt).getCursor(3);
//                //取的结果集的方式二：
//                //  rs = (ResultSet) stmt.getObject(3);
//
//                String ric ;
//                String price ;
//                String updated ;
//                //对结果进行输出
//                while(rs.next()){
//                    ric = rs.getString(1);
//                    price = rs.getString(2);
//                    updated = rs.getString(3);
//
//                    System.out.println("ric:"+ric+";-- price:"+price+"; --"+updated+"; ");
//                }
//            }
//
        }
        catch(Exception e)
        {
            e.printStackTrace();
        }
        finally{
            System.out.println("close ");
        }
        }

}
