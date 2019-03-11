package configSelenium.Entity;

import java.io.Serializable;

/**
 * Created by Administrator on 2016/12/21.
 */
public class CommonConfig implements Serializable {
    private String ChromeDriverUrl; //ChromeDriver地址
    private String PhatomJSDriverUrl; //PhatomJSDriver地址
    private String LoginUrl;//系统登陆地址
    private String LoginUserName;//系统登陆用户
    private String YJName;//移交人名称
    private String ReceiveEmailAdd;//邮件接收人地址
    private String LoginPassWord; //系统登陆密码
    private String FirstPageIframe; //首页iframe名称
    private String CreateProIframe;//新建办件iframe名称
    private String WorkFlowFrameIframe;//办件环节iframe名称

    public String getServiceIP() {
        return ServiceIP;
    }

    public void setServiceIP(String serviceIP) {
        ServiceIP = serviceIP;
    }

    private String ServiceIP;//服务访问IP

    public String getDataCategory() {
        return DataCategory;
    }

    public void setDataCategory(String dataCategory) {
        DataCategory = dataCategory;
    }

    public String getWorkFlowFrameIframe() {
        return WorkFlowFrameIframe;
    }

    public void setWorkFlowFrameIframe(String workFlowFrameIframe) {
        WorkFlowFrameIframe = workFlowFrameIframe;
    }

    public String getCreateProIframe() {
        return CreateProIframe;
    }

    public void setCreateProIframe(String createProIframe) {
        CreateProIframe = createProIframe;
    }

    public String getFirstPageIframe() {
        return FirstPageIframe;
    }

    public void setFirstPageIframe(String firstPageIframe) {
        FirstPageIframe = firstPageIframe;
    }

    public String getLoginPassWord() {
        return LoginPassWord;
    }

    public void setLoginPassWord(String loginPassWord) {
        LoginPassWord = loginPassWord;
    }

    public String getLoginUserName() {
        return LoginUserName;
    }

    public void setLoginUserName(String loginUserName) {
        LoginUserName = loginUserName;
    }

    public String getLoginUrl() {
        return LoginUrl.replace("{IP}",ServiceIP);
    }

    public void setLoginUrl(String loginUrl) {
        LoginUrl = loginUrl;
    }

//    public String getPhatomJSDriverUrl() {
//        return PhatomJSDriverUrl;
//    }
//
//    public void setPhatomJSDriverUrl(String phatomjsDriverUrl) {
//        PhatomJSDriverUrl = phatomjsDriverUrl;
//    }


    public String getChromeDriverUrl() {
        return ChromeDriverUrl;
    }

    public void setChromeDriverUrl(String chromeDriverUrl) {
        ChromeDriverUrl = chromeDriverUrl;
    }

    private String DataCategory;//窗口收件资料


    public String getDbName() {
        return DbName;
    }

    public void setDbName(String dbName) {
        DbName = dbName;
    }

    public String getDbUserName() {
        return DbUserName;
    }

    public void setDbUserName(String dbUserName) {
        DbUserName = dbUserName;
    }

    public String getDbPassWord() {
        return DbPassWord;
    }

    public void setDbPassWord(String dbPassWord) {
        DbPassWord = dbPassWord;
    }

    public void setYJName(String YJName) {
        this.YJName = YJName;
    }

    public String getYJName() {
        return YJName;
    }

    private String DbName;
    private String DbUserName;
    private String DbPassWord;


    public String getReceiveEmailAdd() {
        return ReceiveEmailAdd;
    }

    public void setReceiveEmailAdd(String receiveEmailAdd) {
        ReceiveEmailAdd = receiveEmailAdd;
    }
}
