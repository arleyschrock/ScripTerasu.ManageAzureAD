using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public class AccountSkuIdentifier
    {
        private ExtensionDataObject extensionDataField;
        private string AccountNameField;
        private string SkuPartNumberField;

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
        public string AccountName
        {
            get
            {
                return this.AccountNameField;
            }
            set
            {
                this.AccountNameField = value;
            }
        }

        [DataMember]
        public string SkuPartNumber
        {
            get
            {
                return this.SkuPartNumberField;
            }
            set
            {
                this.SkuPartNumberField = value;
            }
        }
    }
}
