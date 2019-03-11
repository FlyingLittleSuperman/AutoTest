package Test;


import configSelenium.ConfigSeleniumStart;
import org.apache.commons.io.FileUtils;
import org.apache.poi.xssf.usermodel.XSSFCell;
import org.apache.poi.xssf.usermodel.XSSFRow;
import org.apache.poi.xssf.usermodel.XSSFSheet;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;
import org.testng.Reporter;
import org.testng.annotations.*;

import static org.assertj.core.api.Assertions.assertThat;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

/**
 * @author wangyan
 * @date 2019-03-07  下午 01:25
 */
@Listeners({org.uncommons.reportng.HTMLReporter.class,org.uncommons.reportng.JUnitXMLReporter.class})
public class DataProviderSet_Assert {
    public static String path="./Assertdata.xlsx";

    @Test(dataProvider = "AssertData")
    public void star(String var1,String var2,String var3){
        assertThat(var1).isEqualTo(var2);
        Reporter.log(var3);

    }


    @DataProvider(name = "AssertData")
    public static Object[][] getData()throws IOException{
        File file=new File(path);
        FileInputStream inputStream=new FileInputStream(file);
        XSSFWorkbook workbook=new XSSFWorkbook(inputStream);
        XSSFSheet sheet=workbook.getSheet("Sheet1");
        int rowCount=sheet.getLastRowNum()-sheet.getFirstRowNum();
        List<Object[]> records=new ArrayList<Object[]>();

        for(int i=0;i<rowCount+1;i++){

            XSSFRow row=sheet.getRow(i);
            String fields[]=new String[row.getLastCellNum()];
            for(int j=0;j<row.getLastCellNum();j++){
                fields[j]=row.getCell(j).getStringCellValue();

            }
            records.add(fields);
        }

        Object[][] results=new Object[records.size()][];
        for(int i=0;i<records.size();i++){
            results[i]=records.get(i);
        }

        return results;

    }

    @BeforeSuite
    public static  void insetToExcel() {

        //定义表头
        String[] title = {"实际结果", "预期结果", "描述"};
//
//        //定义实际结果集
//        List<String> actuallist = new ArrayList<>();
//        List<String> exceptlist = new ArrayList<>();
//        List<String> description = new ArrayList<>();
//
//        actuallist.add("大王");
//        actuallist.add("12");
//        actuallist.add("89sasd");
//
//        exceptlist.add("小王");
//        exceptlist.add("12");
//        exceptlist.add("423asd");
//
//        description.add("判断是否相等");
//        description.add("case2");
//        description.add("case3");

        //创建excel工作簿
        XSSFWorkbook workbook = new XSSFWorkbook();
        //创建工作表sheet
        XSSFSheet sheet = workbook.createSheet("Sheet1");
        //创建第一行
        XSSFRow row = sheet.createRow(0);
        XSSFCell cell = null;

        //插入第一行的表头
//        for (int i = 0; i < title.length; i++) {
//            cell = row.createCell(i);
//            cell.setCellValue(title[i]);
//
////        }

        for (int i = 0; i < ConfigSeleniumStart.actuallist.size(); i++) {
            XSSFRow nrow = sheet.createRow(i);
            XSSFCell ncell = nrow.createCell(0);
            ncell.setCellValue(ConfigSeleniumStart.actuallist.get(i));
            ncell=nrow.createCell(1);
            ncell.setCellValue(ConfigSeleniumStart.exceptlist.get(i));
            ncell=nrow.createCell(2);
            ncell.setCellValue(ConfigSeleniumStart.descriptionlist.get(i));

        }
        //创建excel文件

        File file=new File(path);
//        D:\work_space\js_de\debug\Selenium\src\main\resources

        try {
            System.out.println("文件路径:"+file.getCanonicalPath());
            file.createNewFile();
            //将excel写入
            FileOutputStream stream= FileUtils.openOutputStream(file);
            workbook.write(stream);
            stream.close();
        } catch (IOException e) {
            e.printStackTrace();
        }

    }

//    @AfterTest
    public static void deleteExcel(){
        File file=new File(path);
        if(!file.exists()){
            System.out.println("删除文件失败"+path+"不存在！");

        }else {

            file.delete();
            System.out.println("删除成功！");
        }
    }
//    @AfterSuite
//    SendEmail
//    public static void sendemail(){
//
//    }
}
