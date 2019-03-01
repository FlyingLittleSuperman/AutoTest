using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumConfig.ProInfo.Entity
{
    public class ProdefEntity
    {
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

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        public string Version1
        {
            get { return version; }
            set { version = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string DeploymentId
        {
            get { return deploymentId; }
            set { deploymentId = value; }
        }

        public string DeploymentUrl
        {
            get { return deploymentUrl; }
            set { deploymentUrl = value; }
        }

        public string Resource
        {
            get { return resource; }
            set { resource = value; }
        }

        public string DiagramResource
        {
            get { return diagramResource; }
            set { diagramResource = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public bool GraphicalNotationDefined
        {
            get { return graphicalNotationDefined; }
            set { graphicalNotationDefined = value; }
        }
    }
}
