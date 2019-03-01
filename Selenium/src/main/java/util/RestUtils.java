package util;

import org.apache.commons.codec.binary.Base64;
import org.apache.commons.io.IOUtils;
import org.apache.http.HttpEntity;
import org.apache.http.HttpHeaders;
import org.apache.http.auth.AuthScope;
import org.apache.http.auth.UsernamePasswordCredentials;
import org.apache.http.client.CredentialsProvider;
import org.apache.http.client.methods.*;
import org.apache.http.entity.StringEntity;
import org.apache.http.impl.client.BasicCredentialsProvider;
import org.apache.http.impl.client.CloseableHttpClient;
import org.apache.http.impl.client.HttpClientBuilder;
import org.apache.http.message.BasicHeader;
import org.apache.http.protocol.HTTP;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.LinkedList;


/**
 * @Description REST服务调用工具类
 * @Author zhangp
 * @Date 2015年3月31日
 * @RevisionHistory <table border='1' cellspacing='0' cellpadding='0'>
 * <tr>
 * <td width='80px'><b>修改日期</b></td>
 * <td width='60px'><b>修改者</b></td>
 * <td><b>修改内容</b></td>
 * </tr>
 * <tr>
 * <td></td>
 * <td></td>
 * <td></td>
 * </tr>
 * </table>
 */
public class RestUtils {
    /**
     * GET请求
     *
     * @param serviceUrl
     * @param username
     * @param password
     * @return response code & response body
     */
    public static String get1(String serviceUrl, String username,
                              String password) {
        HttpURLConnection connect = null;
        try {
            // 实例一个URL资源
            URL url = new URL(serviceUrl);
            // 实例一个HTTP CONNECT
            connect = (HttpURLConnection) url
                    .openConnection();
            connect.setRequestMethod("GET");
            String encoded = new String(Base64.encodeBase64(new String(username
                    + ":" + password).getBytes()));
            connect.setRequestProperty("Authorization", "Basic " + encoded);
            connect.connect();
            int code = connect.getResponseCode();

            // 将返回的值存入到String中
            BufferedReader brd = new BufferedReader(new InputStreamReader(
                    connect.getInputStream()));
            StringBuilder sb = new StringBuilder();
            String line;

            while ((line = brd.readLine()) != null) {
                sb.append(line);
            }
            brd.close();

            return code + "♀" + sb.toString();
        } catch (Exception e) {
            return "999" + "♀" + e.getLocalizedMessage();
        } finally {
            if (connect != null) {
                connect.disconnect();
            }
        }
    }

    /***
     * GET请求
     *
     * @param serviceUrl
     *            服务地址
     * @param username
     *            用户名
     * @param password
     *            密码
     * @return
     * @throws IOException
     */
    public static String get(String serviceUrl, String username, String password) {
        HttpGet request = null;
        try {
            request = new HttpGet(serviceUrl);
            request.addHeader(new BasicHeader(HttpHeaders.CONTENT_TYPE,
                    "application/json"));
            request.addHeader(new BasicHeader(HttpHeaders.ACCEPT_CHARSET, "utf-8"));

            String result = executeRequest(request, username, password);
            return result;
        } catch (Exception e) {
            return "ERROR" + "♀"
                    + e.getLocalizedMessage();
        } finally {
            if (request != null) {
                request.releaseConnection();
            }
        }

    }

    /***
     * POST请求
     *
     * @param serviceUrl
     *            服务地址
     * @param username
     *            用户名
     * @param password
     *            密码
     * @param json
     *            json字符串,例如: "{ \"username\":\"zhangsan\" }" ;其中属性名必须带双引号
     * @return
     * @throws IOException
     */
    public static String post(String serviceUrl, String username,
                              String password, String json) {
        HttpPost request = null;
        try {
            request = new HttpPost(serviceUrl);
            request.addHeader(new BasicHeader(HttpHeaders.CONTENT_TYPE,
                    "application/json"));
            request.addHeader(new BasicHeader(HttpHeaders.ACCEPT_CHARSET, "utf-8"));

            @SuppressWarnings("deprecation")
            StringEntity entity = new StringEntity(json, HTTP.UTF_8);
            request.setEntity(entity);

            String result = executeRequest(request, username, password);
            return result;
        } catch (Exception e) {
            return "ERROR" + "♀"
                    + e.getLocalizedMessage();
        } finally {
            if (request != null) {
                request.releaseConnection();
            }
        }

    }

    /***
     * PUT请求
     *
     * @param serviceUrl
     *            服务地址
     * @param username
     *            用户名
     * @param password
     *            密码
     * @param json
     *            json字符串,例如: "{ \"username\":\"zhangsan\" }" ;其中属性名必须带双引号
     * @return
     * @throws IOException
     */
    public static String put(String serviceUrl, String username,
                             String password, String json) {
        HttpPut request = null;
        try {
            request = new HttpPut(serviceUrl);
            request.addHeader(new BasicHeader(HttpHeaders.CONTENT_TYPE,
                    "application/json"));
            request.addHeader(new BasicHeader(HttpHeaders.ACCEPT_CHARSET, "utf-8"));

            @SuppressWarnings("deprecation")
            StringEntity entity = new StringEntity(json, HTTP.UTF_8);
            request.setEntity(entity);

            String result = executeRequest(request, username, password);
            return result;
        } catch (Exception e) {
            return "ERROR" + "♀"
                    + e.getLocalizedMessage();
        } finally {
            if (request != null) {
                request.releaseConnection();
            }
        }

    }

    /***
     * DELETE请求
     *
     * @param serviceUrl
     *            服务地址
     * @param username
     *            用户名
     * @param password
     *            密码
     * @remark 因delete是javascript中的关键字，故通过dwr调用时不能使用此关键字，所以该方法命名为del
     * @return
     * @throws IOException
     */
    public static String del(String serviceUrl, String username,
                             String password) {
        HttpDelete request = null;
        try {
            request = new HttpDelete(serviceUrl);
            request.addHeader(new BasicHeader(HttpHeaders.CONTENT_TYPE,
                    "application/json"));
            request.addHeader(new BasicHeader(HttpHeaders.ACCEPT_CHARSET, "utf-8"));

            String result = executeRequest(request, username, password);
            return result;
        } catch (Exception e) {
            return "ERROR" + "♀"
                    + e.getLocalizedMessage();
        } finally {
            if (request != null) {
                request.releaseConnection();
            }
        }

    }

    /**
     * 执行请求体的通用方法
     *
     * @param request
     * @param username
     * @param password
     * @return
     */
    public static String executeRequest(HttpUriRequest request,
                                        String username, String password) {
        CloseableHttpClient client = null;
        CloseableHttpResponse response = null;
        try {
            LinkedList<CloseableHttpResponse> httpResponses = new LinkedList<CloseableHttpResponse>();
            CredentialsProvider provider = new BasicCredentialsProvider();
            UsernamePasswordCredentials credentials = new UsernamePasswordCredentials(
                    username, password);
            provider.setCredentials(AuthScope.ANY, credentials);
            client = HttpClientBuilder.create()
                    .setDefaultCredentialsProvider(provider).build();

            response = client.execute(request);
            int statusCode = response.getStatusLine().getStatusCode();
            httpResponses.add(response);

            InputStream inputStream = null;
            String output = "";
            HttpEntity entity = response.getEntity();
            if (entity != null && entity.getContent() != null) {
                inputStream = response.getEntity().getContent();
                output = IOUtils.toString(inputStream, "UTF-8");
                inputStream.close();
            }

            return statusCode + "♀" + output;
        } catch (Exception e) {
            e.printStackTrace();
            return "ERROR" + "♀"
                    + e.getLocalizedMessage();
        } finally {
            if (response != null) {
                try {
                    response.close();
                } catch (IOException e) {
                    e.printStackTrace();
                }
            }
            if (client != null) {
                try {
                    client.close();
                } catch (IOException e) {
                    e.printStackTrace();
                }
            }
        }

    }

}
