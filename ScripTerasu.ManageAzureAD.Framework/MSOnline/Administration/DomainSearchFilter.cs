using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    [DataContract(Name = "DomainSearchFilter")]
    public class DomainSearchFilter : IExtensibleDataObject
    {
        private ExtensionDataObject extensionDataField;
        private DomainAuthenticationType? AuthenticationField;
        private DomainCapabilities? CapabilityField;
        private DomainStatus? StatusField;

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
        public DomainAuthenticationType? Authentication
        {
            get
            {
                return this.AuthenticationField;
            }
            set
            {
                this.AuthenticationField = value;
            }
        }

        [DataMember]
        public DomainCapabilities? Capability
        {
            get
            {
                return this.CapabilityField;
            }
            set
            {
                this.CapabilityField = value;
            }
        }

        [DataMember]
        public DomainStatus? Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                this.StatusField = value;
            }
        }
    }
}
