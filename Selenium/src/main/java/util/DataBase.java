package util;

import configSelenium.Entity.CommonConfig;
import configSelenium.StaticValue;

import java.io.InputStream;
import java.sql.*;
import java.util.Properties;

/**
 * Created by Administrator on 2016/12/29.
 */
public class DataBase {

    public static Connection connection = null;
    public static String JdbcDriver = null;
    public static String JdbcUrl = null;
    public static String JdbcUseName = null;
    public static String JdbcPassWord = null;

    static {
        try {

            if (connection == null) {

                Object obj = CacheUtils.get(StaticValue.CommonConfigCacheName, StaticValue.InitParameterKeyName);
                if (obj == null) {
                    throw new RuntimeException("获取通用配置参数失败！");
                }

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

        } catch (Exception er) {
            LoggerUtils.error(er);
        }
    }

    /**
     * 批量执行sql语句
     *
     * @param sql
     */
    public static void ExecuteSql(String sql) throws Exception {
        Statement statement = null;
        ResultSet rs = null;
        try {

            connection.setAutoCommit(false);
            StringBuilder sbSql = new StringBuilder();
            sbSql.append("begin\r\n");
            sbSql.append(sql);
            sbSql.append("end;\r\n");
            statement = connection.createStatement();
            statement.execute(sbSql.toString());
            System.out.println("执行SQL语句成功！" + sbSql.toString());
            connection.commit();

        } catch (Exception er) {
            er.printStackTrace();
            connection.rollback();
            throw er;
        } finally {
            CloseStatement(statement, rs);
        }
    }

    public static void Insert() {
        PreparedStatement preparedStatement = null;
        ResultSet rs = null;
        try {
            String sql = "insert into fdcq(bsm) values(seq_bsm.nextval)";
            preparedStatement = connection.prepareStatement(sql, Statement.RETURN_GENERATED_KEYS);
            preparedStatement.executeUpdate();
            rs = preparedStatement.getGeneratedKeys();

            Object retId = null;
            if (rs.next())
                retId = rs.getObject(1);
            else
                throw new Exception("insert or generate keys failed..");
            System.out.println(retId);

        } catch (Exception er) {

        } finally {
            CloseStatement(preparedStatement, rs);
        }
    }

    public static Long GetNewID(String seqName) {
        Statement statement = null;
        ResultSet rs = null;
        Long seqValue = 0L;
        try {
            statement = connection.createStatement();
            String sql = "select " + seqName + ".nextval seqvalue from dual";
            rs = statement.executeQuery(sql);

            while (rs.next()) {
                seqValue = rs.getLong("seqvalue");
            }
        } catch (Exception er) {

            er.printStackTrace();
        } finally {
            CloseStatement(statement, rs);
            return seqValue;
        }
    }


    public static void CloseStatement(Statement statement, ResultSet rs) {
        try {
            if (statement != null) {
                statement.close();
                statement = null;
            }

            if (rs != null) {
                rs.close();
                rs = null;
            }
        } catch (Exception er) {
            er.printStackTrace();
        }

    }

}
