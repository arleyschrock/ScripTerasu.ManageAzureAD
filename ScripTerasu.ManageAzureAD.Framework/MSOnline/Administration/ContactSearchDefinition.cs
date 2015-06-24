using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    [DataContract]
    public class ContactSearchDefinition : SearchDefinition
    {
        private bool? HasErrorsOnlyField;
        private List<string> IncludedPropertiesField;

        [DataMember]
        public bool? HasErrorsOnly
        {
            get
            {
                return this.HasErrorsOnlyField;
            }
            set
            {
                this.HasErrorsOnlyField = value;
            }
        }

        [DataMember]
        public List<string> IncludedProperties
        {
            get
            {
                return this.IncludedPropertiesField;
            }
            set
            {
                this.IncludedPropertiesField = value;
            }
        }
    }
}
