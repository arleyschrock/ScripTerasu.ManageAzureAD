using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    [DataContract]
    public class RoleMemberSearchDefinition : SearchDefinition
    {
        private List<string> IncludedPropertiesField;
        private List<string> MemberObjectTypesField;
        private Guid RoleObjectIdField;

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

        [DataMember]
        public List<string> MemberObjectTypes
        {
            get
            {
                return this.MemberObjectTypesField;
            }
            set
            {
                this.MemberObjectTypesField = value;
            }
        }

        [DataMember]
        public Guid RoleObjectId
        {
            get
            {
                return this.RoleObjectIdField;
            }
            set
            {
                this.RoleObjectIdField = value;
            }
        }
    }
}
