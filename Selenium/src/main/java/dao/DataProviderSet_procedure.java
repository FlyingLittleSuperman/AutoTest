package dao;

import oracle.jdbc.OracleTypes;
import util.DataBase;

import java.sql.*;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * @author wangyan
 * @date 2019-02-21  上午 11:02
 * 调用数据库的存储过程
 */
public class DataProviderSet_procedure {
    private static CallableStatement statement;
    private static Connection ct;
    private static String result_bdcdyh;

    public static void main(String[] args){

        System.out.println(call("selenium_pro_tudidy")
        );
    }



    public static String  call(String callname){
        try{

            Class.forName(DataBase.JdbcDriver);
            ct=DataBase.connection;
//            Class.forName("oracle.jdbc.driver.OracleDriver");
//            ct=DriverManager.getConnection("jdbc:oracle:thin:@192.168.2.119:1521:testbdc","bdcdj","bdcdj119");
            String result = null;

            if(callname.contains("creat")){
                statement=ct.prepareCall("{call "+callname+"(?,?)}");
                statement.registerOutParameter(1, OracleTypes.VARCHAR);
                statement.registerOutParameter(2, OracleTypes.VARCHAR);
                statement.execute();
                result =statement.getString(1);
            }else{
                statement=ct.prepareCall("{call "+callname+"(?)}");
                statement.registerOutParameter(1, OracleTypes.VARCHAR);
                statement.execute();
                result =statement.getString(1);
            }
            result_bdcdyh=result;



        }
        catch (SQLException e){
            e.printStackTrace();

        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }
//        finally {
//
//            try{
//
//                statement.close();
//            }catch(Exception er){
//                er.printStackTrace();
//            }
//            try{
//                ct.close();
//
//            }catch(Exception er){
//                er.printStackTrace();
//            }
//        }
        return result_bdcdyh;

    }

}
