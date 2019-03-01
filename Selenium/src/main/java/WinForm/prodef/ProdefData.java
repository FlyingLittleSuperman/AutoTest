package WinForm.prodef;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

import java.util.List;

/**
 * Created by Administrator on 2016/12/16.
 */
@JsonIgnoreProperties(ignoreUnknown = true)
public class ProdefData {
    public List<Prodef> getData() {
        return data;
    }

    public void setData(List<Prodef> data) {
        this.data = data;
    }

    public List<Prodef> data;

}
