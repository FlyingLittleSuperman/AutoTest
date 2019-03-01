package WinForm.prodef;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

/**
 * Created by Administrator on 2016/12/16.
 */
@JsonIgnoreProperties(ignoreUnknown = true)
public class Prodef {
    private String id;
    private String key; //ProdefKey,用于创建流程的时候用
    private String version; //版本号
    private String name; //名称
    private String description;//描述
    private String deploymentId;
    private String deploymentUrl;
    private String resource;
    private String diagramResource;
    private String category;//父节点名称
    private Boolean graphicalNotationDefined;

    public Boolean getSuspended() {
        return suspended;
    }

    public void setSuspended(Boolean suspended) {
        this.suspended = suspended;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getKey() {
        return key;
    }

    public void setKey(String key) {
        this.key = key;
    }

    public String getVersion() {
        return version;
    }

    public void setVersion(String version) {
        this.version = version;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getDeploymentId() {
        return deploymentId;
    }

    public void setDeploymentId(String deploymentId) {
        this.deploymentId = deploymentId;
    }

    public String getDeploymentUrl() {
        return deploymentUrl;
    }

    public void setDeploymentUrl(String deploymentUrl) {
        this.deploymentUrl = deploymentUrl;
    }

    public String getResource() {
        return resource;
    }

    public void setResource(String resource) {
        this.resource = resource;
    }

    public String getDiagramResource() {
        return diagramResource;
    }

    public void setDiagramResource(String diagramResource) {
        this.diagramResource = diagramResource;
    }

    public String getCategory() {
        return category;
    }

    public void setCategory(String category) {
        this.category = category;
    }

    public Boolean getGraphicalNotationDefined() {
        return graphicalNotationDefined;
    }

    public void setGraphicalNotationDefined(Boolean graphicalNotationDefined) {
        this.graphicalNotationDefined = graphicalNotationDefined;
    }

    private Boolean suspended;

    public String toString() {
        return name;
    }

}
