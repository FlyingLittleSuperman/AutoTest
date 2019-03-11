package dao;

import org.apache.poi.hssf.usermodel.HSSFWorkbook;
import org.apache.poi.ss.usermodel.*;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;
import org.testng.annotations.DataProvider;
import java.io.IOException;
import java.io.InputStream;
import java.util.ArrayList;

import java.util.List;

/**
 * @author wangyan
 * @date 2019-02-20  下午 04:55
 */
public class DataProviderSet_xlsx {

    @DataProvider(name="mapDataProvider")
    public static Object[][] words() throws IOException
    {

        return mapDataProvider("D:\\work_space\\js_de\\debug\\Selenium\\src\\main\\resources", "testdata.xlsx", "test");

    }

    public static Object[][] mapDataProvider(String filePath,String fileName,String sheetName) throws IOException {
//        fileName="testdata";
//        sheetName="test";
//        File file=new File(filePath+"\\"+fileName);
//        FileInputStream input=new FileInputStream(file);
        Workbook workbook=null;
        String fileExtensionName=fileName.substring(fileName.indexOf("."));

        InputStream in=null;
        DataFormatter dataFormatter=new DataFormatter();

            in = DataProviderSet_xlsx.class.getClassLoader().getResourceAsStream(fileName);
            if (fileExtensionName.equalsIgnoreCase(".xlsx")) {
                workbook = new XSSFWorkbook(in);
            } else if (fileExtensionName.equalsIgnoreCase(".xls")) {
                workbook = new HSSFWorkbook(in);
            }

            //获取sheet
            Sheet sheet = workbook.getSheet(sheetName);
            //获取总行数
            int row = sheet.getLastRowNum() - sheet.getFirstRowNum();
            List<Object[]> records = new ArrayList<Object[]>();

            for (int i = 1; i < row + 1; i++) {
                Row rowValue = sheet.getRow(i);
                String[] files = new String[rowValue.getLastCellNum()];
                List<Cell> cells=null;

                for (int j = 0; j < rowValue.getLastCellNum(); j++) {

                    files[j]=dataFormatter.formatCellValue(rowValue.getCell(j));



                }
                records.add(files);

            }

            Object[][] results = new Object[records.size()][];
            for (int i = 0; i < records.size(); i++) {

                results[i] = records.get(i);

            }
            return results;


    }
}
