package Test.Report;

import util.Path;

import java.io.*;
import java.util.ArrayList;
import java.util.List;


public class Copy_ReportFile {


    public static void getCopyFile(String fangan)  {

        List<String> allSpath = new ArrayList<>();
        String source_path = Path.reportPath() + "\\html\\";
        allSpath.add(source_path + "index.html");
        allSpath.add(source_path + "output.html");
        allSpath.add(source_path + "overview.html");
        allSpath.add(source_path + "reportng.css");
        allSpath.add(source_path + "reportng.js");
        allSpath.add(source_path + "suite1_test1_results.html");
        allSpath.add(source_path + "suites.html");

        List<String> allDpath = new ArrayList<>();
        String dest_path = Path.reportPath() + "\\html_" + fangan + "\\";
        allDpath.add(dest_path + "index.html");
        allDpath.add(dest_path + "output.html");
        allDpath.add(dest_path + "overview.html");
        allDpath.add(dest_path + "reportng.css");
        allDpath.add(dest_path + "reportng.js");
        allDpath.add(dest_path + "suite1_test1_results.html");
        allDpath.add(dest_path + "suites.html");

        try {
            for (int i = 0; i < allSpath.size(); i++) {
                File file = new File(allSpath.get(i));
                File file1 = new File(allDpath.get(i));
                if (!file1.exists()) {
                    file1.getParentFile().mkdir();
                    file1.createNewFile();
                }
                copyFile(file, file1);

            }
        }catch (IOException er){
            er.printStackTrace();
        }
    }






    // /f复制文件

    public static void copyFile(File source, File dest)throws IOException{
        FileInputStream input = null;
        FileOutputStream output = null;
        try {
            input = new FileInputStream(source);
            output = new FileOutputStream(dest);
            byte[] buf = new byte[1024];
            int byteRead;
            while ((byteRead = input.read(buf)) > 0) {
                output.write(buf, 0, byteRead);
            }
        } catch (FileNotFoundException e){
            throw e;

        } catch (Exception er) {
            er.printStackTrace();
            throw er;
        } finally {
            if (input !=null){
                input.close();
            }
            if (output !=null){
                output.close();
            }


        }
    }
}
