package WinForm.prodef;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

import java.util.List;

/**
 * Created by Administrator on 2016/12/16.
 */
@JsonIgnoreProperties(ignoreUnknown = true)
public class ActdefData {
    private String id;
    private String url;
    private String name;
    private String processKey;

    public List<Actdef> getListTaskInfor() {
        return listTaskInfor;
    }

    public void setListTaskInfor(List<Actdef> listTaskInfor) {
        this.listTaskInfor = listTaskInfor;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getUrl() {
        return url;
    }

    public void setUrl(String url) {
        this.url = url;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getProcessKey() {
        return processKey;
    }

    public void setProcessKey(String processKey) {
        this.processKey = processKey;
    }

    private List<Actdef> listTaskInfor;


}
