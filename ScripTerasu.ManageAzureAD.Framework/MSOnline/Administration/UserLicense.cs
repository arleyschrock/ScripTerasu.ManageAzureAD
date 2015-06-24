using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public class UserLicense : IExtensibleDataObject
    {
        private ExtensionDataObject extensionDataField;
        private AccountSkuIdentifier AccountSkuField;
        private string AccountSkuIdField;
        private List<ServiceStatus> ServiceStatusField;

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
        public AccountSkuIdentifier AccountSku
        {
            get
            {
                return this.AccountSkuField;
            }
            set
            {
                this.AccountSkuField = value;
            }
        }

        [DataMember]
        public string AccountSkuId
        {
            get
            {
                return this.AccountSkuIdField;
            }
            set
            {
                this.AccountSkuIdField = value;
            }
        }

        [DataMember]
        public List<ServiceStatus> ServiceStatus
        {
            get
            {
                return this.ServiceStatusField;
            }
            set
            {
                this.ServiceStatusField = value;
            }
        }
    }
}
