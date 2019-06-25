package WinForm.prodef;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

/**
 * Created by Administrator on 2016/12/16.
 */
@JsonIgnoreProperties(ignoreUnknown = true)
public class Actdef {
    public String getTask_id() {
        return task_id;
    }

    public void setTask_id(String task_id) {
        this.task_id = task_id;
    }

    public String getTask_name() {
        return task_name;
    }

    public void setTask_name(String task_name) {
        this.task_name = task_name;
    }

    private String task_id;
    private String task_name;

    @Override
    public String toString() {
        return task_name;
    }
}
