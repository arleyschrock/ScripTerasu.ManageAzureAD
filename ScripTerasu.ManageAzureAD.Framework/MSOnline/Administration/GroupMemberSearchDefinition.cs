using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    [DataContract]
    public class GroupMemberSearchDefinition : SearchDefinition
    {
        private Guid GroupObjectIdField;
        private List<string> IncludedPropertiesField;
        private List<string> MemberObjectTypesField;

        [DataMember]
        public Guid GroupObjectId
        {
            get
            {
                return this.GroupObjectIdField;
            }
            set
            {
                this.GroupObjectIdField = value;
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
    }
}
