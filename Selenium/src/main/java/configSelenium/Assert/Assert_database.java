package configSelenium.Assert;

import util.DataBase;

import java.sql.*;

/**
 * @author wangyan
 * @date 2019-02-22  下午 04:11
 */
public class Assert_database {
    static Connection ct = null;
    static PreparedStatement stmt=null;

    public static Connection getConnection(){
        try {
            if(ct!=null&&!ct.isClosed()) {
                return ct;
            }
            Class.forName(DataBase.JdbcDriver);
//            Class.forName("oracle.jdbc.driver.OracleDriver");
            ct=DriverManager.getConnection(DataBase.JdbcUrl,DataBase.JdbcUseName,DataBase.JdbcPassWord);
//            ct=DriverManager.getConnection("jdbc:oracle:thin:@192.168.2.119:1521:testbdc","bdcdj","bdcdj119");

            if(ct==null) {
                throw new Exception("获取连接失败！");
            }
        } catch (SQLException e) {
            e.printStackTrace();
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        } catch (Exception e) {
            e.printStackTrace();
        }

        return ct;
    }

    public static ResultSet  getResult(String var) {
        ResultSet rs = null;


        try {
             getConnection();
             System.out.println("查询语句："+var);

            stmt=ct.prepareCall(var);
            rs=stmt.executeQuery();

        } catch (Exception e) {
            e.printStackTrace();
        } finally {

            try {

//                stmt.close();
            } catch (Exception er) {
                er.printStackTrace();
            }
            try {
//                ct.close();

            } catch (Exception er) {
                er.printStackTrace();
            }
        }

        return rs;
    }

    public static void getClose(){
        System.out.println("要关闭了");
        if(stmt!=null){
            try {
                stmt.close();
            } catch (Exception e) {
                e.printStackTrace();
            }

        }
        if(ct!=null) {
            try {
                ct.close();
            } catch (Exception e) {
                e.printStackTrace();
            }

        }
    }

    public static void main(String[] args) throws SQLException {
//        ResultSet rs=null;
//        String result="";
//
//        rs=getResult("select qlrmc from slsq where ywh='20190223-0001931'");
//        if(rs.next()){
//            result=rs.getString(1);
//            System.out.println("result:"+result);
//        }
//        getClose();


//        ResultSet rs = null;
//        PreparedStatement stmt=null;
//        Connection ct = null;
//        try {
////            Class.forName(DataBase.JdbcDriver);
////            Connection ct=DataBase.connection;
//            Class.forName("oracle.jdbc.driver.OracleDriver");
//            ct= DriverManager.getConnection("jdbc:oracle:thin:@192.168.2.119:1521:testbdc","bdcdj","bdcdj119");
//            System.out.println("成功了");
//            stmt=ct.prepareCall("select qlrmc from slsq where ywh='20190223-0001931'");
//            rs=stmt.executeQuery();
//
//            ResultSetMetaData rsmd=rs.getMetaData();
////            int columns=rsmd.getColumnCount();  //获取结果集的列数
//            if(rs.next()) {
//                System.out.println("null:"+rs.getString(1));
//            }
//
//
//        } catch (Exception e) {
//            e.printStackTrace();
//        } finally {
//
//            try {
//
//                stmt.close();
//            } catch (Exception er) {
//                er.printStackTrace();
//            }
//            try {
//                ct.close();
//
//            } catch (Exception er) {
//                er.printStackTrace();
//            }
//
//
//        }
    }
}
