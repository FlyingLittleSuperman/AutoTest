package Test;


import Test.Assert.Assert_database;
import configSelenium.ConfigSeleniumStart;
import org.apache.commons.io.FileUtils;
import org.apache.poi.xssf.usermodel.XSSFCell;
import org.apache.poi.xssf.usermodel.XSSFRow;
import org.apache.poi.xssf.usermodel.XSSFSheet;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;
import org.testng.Reporter;
import org.testng.annotations.*;


import static configSelenium.ConfigSeleniumStart.actuallist;
import static org.assertj.core.api.Assertions.assertThat;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

/**
 * @author wangyan
 * @date 2019-03-07  下午 01:25
 */
@Listeners({org.uncommons.reportng.HTMLReporter.class,org.uncommons.reportng.JUnitXMLReporter.class,emailMessage.class})
public class DataProviderSet_Assert {
    public static String path="./Assertdata.xlsx";



    @Test(dataProvider = "AssertData")
    public void star(String var1,String var2,String var3){
        Reporter.log("");
        assertThat(var1.substring(5)).isEqualTo(var2.substring(5)).as(var3);

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



    @BeforeTest
    public static  void insetToExcel() {


        //定义表头
        String[] title = {"实际结果", "预期结果", "描述"};


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

        for (int i = 0; i < actuallist.size(); i++) {
            XSSFRow nrow = sheet.createRow(i);
            XSSFCell ncell = nrow.createCell(0);
            ncell.setCellValue(actuallist.get(i));
            ncell=nrow.createCell(1);
            ncell.setCellValue(ConfigSeleniumStart.exceptlist.get(i));
            ncell=nrow.createCell(2);
            ncell.setCellValue(ConfigSeleniumStart.descriptionlist.get(i));


        }
        //创建excel文件

        File file=new File(path);

        try {

            file.createNewFile();
            //将excel写入
            FileOutputStream stream= FileUtils.openOutputStream(file);
            workbook.write(stream);
            stream.close();
        } catch (IOException e) {
            e.printStackTrace();
        }

    }

    @AfterSuite
    public static void deleteExcel(){
        //关闭数据库
        Assert_database.getClose();
        File file=new File(path);
        if(!file.exists()){
            System.out.println("删除文件失败"+path+"不存在！");

        }else {

            file.delete();

        }
    }
//    @AfterSuite
//    public void clearLog(){
//       logs.clear();
//    }


//    @AfterMethod(alwaysRun = true)
//    public void afterMethod(ITestResult result) throws Exception {
//            catchExceptions(result);
//    }
//
//    public  void catchExceptions(ITestResult result) {
//        System.out.println("result" + result);
//        String methodName = result.getName();
//        System.out.println(methodName);
//
//            for(String path: ConfigSeleniumStart.eshootpath){
//                System.out.println("截图插入报告");
//                String html="<img src=\""+path+"\"  hight=\"200\" width=\"200\" onclick=\"javascript:window.open(this.src);\"/>";
//                Reporter.log(html);
//
//
//        }
//    }


//
//    /**
//     * 将\字符替换为\
//     * *@param 待替换char
//     * @return 替换之后的char
//     */
//    private String escapeChar(char character)
//    {
//        switch (character)
//        {
//            case '\\': return "\\\\";
//            default: return String.valueOf(character);
//        }
//    }

}
