package Test;

//import net.sourceforge.tess4j.TessAPI;
import Test.Report.EmailInformation;

import org.testng.annotations.Listeners;
import org.testng.xml.XmlSuite;
import util.Path;

import javax.activation.DataHandler;
import javax.activation.DataSource;
import javax.activation.FileDataSource;
import javax.mail.*;
import javax.mail.internet.*;
import java.io.UnsupportedEncodingException;
import java.util.Properties;



/**
 * @author wangyan
 * @date 2019-03-11  上午 11:02
 */

public class SendEmail {

    public static void getXmlResult(){

    }



    public static void sendEmail(String receiveAdd,String zxName,EmailInformation emailInformation) {

//        List<emailMessage> list=new ArrayList<>();


        // 创建一个Property文件对象
        Properties props=new Properties();

        // 设置邮件服务器的信息，这里设置smtp主机名称
        props.put("mail.smtp.host", "smtp.163.com");

        // 设置socket factory 的端口
        props.put("mail.smtp.socketFactory.port", "465");

        // 设置socket factory
        props.put("mail.smtp.socketFactory.class","javax.net.ssl.SSLSocketFactory");

        // 设置需要身份验证
        props.put("mail.smtp.auth", "true");

        // 设置SMTP的端口，QQ的smtp端口是25
        props.put("mail.smtp.port", "25");

        // 身份验证实现
        Session session = Session.getDefaultInstance(props, new javax.mail.Authenticator() {

            @Override
            protected PasswordAuthentication getPasswordAuthentication() {
                // 第二个参数，就是我QQ开启smtp的授权码
                return new PasswordAuthentication("ATAdministrator@163.com", "atadmin1234");

            }

        });
        try{

            // 创建一个MimeMessage类的实例对象
            Message message = new MimeMessage(session);

            // 设置发件人邮箱地址
            message.setFrom(new InternetAddress("ATAdministrator@163.com"));

            // 设置收件人邮箱地址
            message.setRecipients(Message.RecipientType.TO,InternetAddress.parse(receiveAdd));

            // 设置邮件主题
            message.setSubject("浙江臻善科技股份有限公司-产品支持部-自动化测试报告:"+zxName);

            // 创建一个MimeBodyPart的对象，以便添加内容
            BodyPart messageBodyPart1 = new MimeBodyPart();

            String str="尊敬的用户，以下是测试结果：\n";
            String str1="\n\t执行方案："+zxName;
            String strip="\n\t系统登录地址："+emailInformation.getIpAddress()+"\n\t登录账号："+emailInformation.getName()+"\n\t登录密码："+emailInformation.getPsd();
            String strcount="\n\t总流程数："+emailInformation.getCount()+"\n\t执行完成："+emailInformation.getIsPass()+"\n\t未执行完成："+emailInformation.getIsFail();
            String str2="\n\t未执行完成业务号：";

            String str3="\n\t本地报告查看地址："+Path.reportPath();

            // 设置邮件正文内容
            messageBodyPart1.setText(str+str1+strip+strcount+str2+emailInformation.getFailYwh()+str3);

            // 创建另外一个MimeBodyPart对象，以便添加其他内容
            MimeBodyPart messageBodyPart2 = new MimeBodyPart();

            // 设置邮件中附件文件的路径

            String filename =Path.reportPath()+"\\"+zxName+".html";

            // 创建一个datasource对象，并传递文件
            DataSource source = new FileDataSource(filename);

            // 设置handler
            messageBodyPart2.setDataHandler(new DataHandler(source));

            // 加载文件
            messageBodyPart2.setFileName( MimeUtility.encodeText(filename));

            // 创建一个MimeMultipart类的实例对象
            Multipart multipart = new MimeMultipart();

            // 添加正文1内容
            multipart.addBodyPart(messageBodyPart1);

            // 添加正文2内容
            multipart.addBodyPart(messageBodyPart2);

            // 设置内容
            message.setContent(multipart);


            // 最终发送邮件
            Transport.send(message);

            System.out.println("=====邮件已经发送=====");


        }catch(MessagingException er){
            throw new RuntimeException(er);
        } catch (UnsupportedEncodingException e) {
            e.printStackTrace();
        }


    }

}
