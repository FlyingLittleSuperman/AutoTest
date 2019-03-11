package Test;

import org.testng.annotations.AfterSuite;
import util.Path;

import javax.activation.DataHandler;
import javax.activation.DataSource;
import javax.activation.FileDataSource;
import javax.mail.*;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeBodyPart;
import javax.mail.internet.MimeMessage;
import javax.mail.internet.MimeMultipart;
import java.util.Properties;

/**
 * @author wangyan
 * @date 2019-03-11  上午 11:02
 */
public class SendEmail {


    public static void sendEmail(String receiveAdd) {

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
            message.setSubject("测试发送邮件");

            // 创建一个MimeBodyPart的对象，以便添加内容
            BodyPart messageBodyPart1 = new MimeBodyPart();

            // 设置邮件正文内容
            messageBodyPart1.setText("以下是测试结果");

            // 创建另外一个MimeBodyPart对象，以便添加其他内容
            MimeBodyPart messageBodyPart2 = new MimeBodyPart();

            // 设置邮件中附件文件的路径
//            String filename = ".\\test-output\\emailable-report.html";
            String filename =Path.reportPath()+ "\\emailable-report.html";

            // 创建一个datasource对象，并传递文件
            DataSource source = new FileDataSource(filename);

            // 设置handler
            messageBodyPart2.setDataHandler(new DataHandler(source));

            // 加载文件
            messageBodyPart2.setFileName(filename);

            // 创建一个MimeMultipart类的实例对象
            Multipart multipart = new MimeMultipart();

            // 添加正文1内容
            multipart.addBodyPart(messageBodyPart1);

            // 添加正文2内容
            multipart.addBodyPart(messageBodyPart2);

            // 设置内容
            message.setContent(multipart);
            System.out.println("98");

            // 最终发送邮件
            Transport.send(message);

            System.out.println("=====邮件已经发送=====");


        }catch(MessagingException er){
            throw new RuntimeException(er);
        }


    }

}
