using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public class ServiceStatus : IExtensibleDataObject
    {
        private ExtensionDataObject extensionDataField;
        private ProvisioningStatus ProvisioningStatusField;
        private ServicePlan ServicePlanField;

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
        public ProvisioningStatus ProvisioningStatus
        {
            get
            {
                return this.ProvisioningStatusField;
            }
            set
            {
                this.ProvisioningStatusField = value;
            }
        }

        [DataMember]
        public ServicePlan ServicePlan
        {
            get
            {
                return this.ServicePlanField;
            }
            set
            {
                this.ServicePlanField = value;
            }
        }
    }
}
