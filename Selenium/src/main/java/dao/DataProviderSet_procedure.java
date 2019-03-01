package dao;

import oracle.jdbc.internal.OracleTypes;
import util.DataBase;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
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


    public static String  call(String callname){
        try{

            Class.forName(DataBase.JdbcDriver);

            ct=DataBase.connection;
            statement=ct.prepareCall("{call "+callname+"(?,?)}");
            statement.registerOutParameter(1, OracleTypes.VARCHAR);
            statement.registerOutParameter(2, OracleTypes.VARCHAR);
            statement.execute();
            String result =statement.getString(1);
            result_bdcdyh=result;
//            String result1=statement.getString(2);
            System.out.println("result1："+result);

        }catch (Exception er){
            er.getStackTrace();
        }finally {

            try{

                statement.close();
            }catch(Exception er){
                er.printStackTrace();
            }
            try{
                ct.close();

            }catch(Exception er){
                er.printStackTrace();
            }
        }
        return result_bdcdyh;

    }
}
