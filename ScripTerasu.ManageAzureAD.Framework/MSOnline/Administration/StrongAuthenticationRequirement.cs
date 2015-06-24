using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public class StrongAuthenticationRequirement : IExtensibleDataObject
    {
        private ExtensionDataObject extensionDataField;
        private string RelyingPartyField;
        private string StateField;

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
        public string RelyingParty
        {
            get
            {
                return this.RelyingPartyField;
            }
            set
            {
                this.RelyingPartyField = value;
            }
        }

        [DataMember]
        public string State
        {
            get
            {
                return this.StateField;
            }
            set
            {
                this.StateField = value;
            }
        }
    }
}
