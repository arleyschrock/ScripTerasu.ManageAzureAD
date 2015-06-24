using System;
using System.Runtime.Serialization;
using System.Xml;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public class ValidationError
    {
        private ExtensionDataObject extensionDataField;
        private XmlElement ErrorDetailField;
        private bool ResolvedField;
        private string ServiceInstanceField;
        private DateTime TimestampField;

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
        public XmlElement ErrorDetail
        {
            get
            {
                return this.ErrorDetailField;
            }
            set
            {
                this.ErrorDetailField = value;
            }
        }

        [DataMember]
        public bool Resolved
        {
            get
            {
                return this.ResolvedField;
            }
            set
            {
                this.ResolvedField = value;
            }
        }

        [DataMember]
        public string ServiceInstance
        {
            get
            {
                return this.ServiceInstanceField;
            }
            set
            {
                this.ServiceInstanceField = value;
            }
        }

        [DataMember]
        public DateTime Timestamp
        {
            get
            {
                return this.TimestampField;
            }
            set
            {
                this.TimestampField = value;
            }
        }
    }
}
