using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public class AlternativeSecurityId
    {
        private ExtensionDataObject extensionDataField;
        private string IdentityProviderField;
        private byte[] KeyField;
        private int TypeField;

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
        public string IdentityProvider
        {
            get
            {
                return this.IdentityProviderField;
            }
            set
            {
                this.IdentityProviderField = value;
            }
        }

        [DataMember]
        public byte[] Key
        {
            get
            {
                return this.KeyField;
            }
            set
            {
                this.KeyField = value;
            }
        }

        [DataMember]
        public int Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
}
