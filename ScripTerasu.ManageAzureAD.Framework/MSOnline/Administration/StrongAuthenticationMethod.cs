using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public class StrongAuthenticationMethod : IExtensibleDataObject
    {
        private ExtensionDataObject extensionDataField;
        private bool IsDefaultField;
        private string MethodTypeField;

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
        public bool IsDefault
        {
            get
            {
                return this.IsDefaultField;
            }
            set
            {
                this.IsDefaultField = value;
            }
        }

        [DataMember]
        public string MethodType
        {
            get
            {
                return this.MethodTypeField;
            }
            set
            {
                this.MethodTypeField = value;
            }
        }
    }
}
