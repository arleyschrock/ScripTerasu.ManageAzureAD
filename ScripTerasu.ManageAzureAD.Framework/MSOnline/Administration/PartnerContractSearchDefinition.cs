using System;
using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    [DataContract]
    public class PartnerContractSearchDefinition : SearchDefinition
    {
        private string DomainNameField;
        private Guid? ManagedTenantIdField;

        [DataMember]
        public string DomainName
        {
            get
            {
                return this.DomainNameField;
            }
            set
            {
                this.DomainNameField = value;
            }
        }

        [DataMember]
        public Guid? ManagedTenantId
        {
            get
            {
                return this.ManagedTenantIdField;
            }
            set
            {
                this.ManagedTenantIdField = value;
            }
        }
    }
}
