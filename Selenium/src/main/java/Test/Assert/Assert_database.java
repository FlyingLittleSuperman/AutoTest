package Test.Assert;

import util.DataBase;

import java.sql.*;

/**
 * @author wangyan
 * @date 2019-02-22  下午 04:11
 */
public class Assert_database {
    static Connection ct = null;
    static PreparedStatement stmt=null;

    public static void main(String []args) throws SQLException {
        ResultSet rs =Assert_database.getResult("select t.tdsyqmj,t.mj from djfz_dymx t where ywh='20190613-0001104'");


        if(rs.next()){
            String result = rs.getString(1);
            String result1 = rs.getString(2);
            System.out.println(result+"/"+result1);

        }
    }

    public static Connection getConnection(){
        try {
            if(ct!=null&&!ct.isClosed()) {
                return ct;
            }
//            Class.forName(DataBase.JdbcDriver);
//            ct=DriverManager.getConnection(DataBase.JdbcUrl,DataBase.JdbcUseName,DataBase.JdbcPassWord);
            Class.forName("oracle.jdbc.driver.OracleDriver");
            ct=DriverManager.getConnection("jdbc:oracle:thin:@192.168.2.119:1521:testbdc","bdcdj","bdcdj119");
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
        }


        return rs;
    }


    public static void getClose(){

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

}
