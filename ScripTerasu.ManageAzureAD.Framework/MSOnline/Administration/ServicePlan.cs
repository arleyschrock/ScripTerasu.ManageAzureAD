using System;
using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public class ServicePlan : IExtensibleDataObject
    {
        private ExtensionDataObject extensionDataField;
        private string ServiceNameField;
        private Guid? ServicePlanIdField;
        private string ServiceTypeField;
        private SkuTargetClass TargetClassField;

        public ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [DataMember]
        public string ServiceName
        {
            get
            {
                return this.ServiceNameField;
            }
            set
            {
                this.ServiceNameField = value;
            }
        }

        [DataMember]
        public Guid? ServicePlanId
        {
            get
            {
                return this.ServicePlanIdField;
            }
            set
            {
                this.ServicePlanIdField = value;
            }
        }

        [DataMember]
        public string ServiceType
        {
            get
            {
                return this.ServiceTypeField;
            }
            set
            {
                this.ServiceTypeField = value;
            }
        }

        [DataMember]
        public SkuTargetClass TargetClass
        {
            get
            {
                return this.TargetClassField;
            }
            set
            {
                this.TargetClassField = value;
            }
        }
    }
}
