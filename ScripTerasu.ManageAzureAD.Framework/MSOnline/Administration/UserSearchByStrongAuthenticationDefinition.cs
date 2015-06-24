using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    [DataContract]
    public class UserSearchByStrongAuthenticationDefinition : SearchDefinition
    {
        private List<string> IncludedPropertiesField;
        private bool RequirementUnsetOnlyField;
        private List<StrongAuthenticationRequirement> RequirementsField;
        private Guid? RoleObjectIdField;

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
        public bool RequirementUnsetOnly
        {
            get
            {
                return this.RequirementUnsetOnlyField;
            }
            set
            {
                this.RequirementUnsetOnlyField = value;
            }
        }

        [DataMember]
        public List<StrongAuthenticationRequirement> Requirements
        {
            get
            {
                return this.RequirementsField;
            }
            set
            {
                this.RequirementsField = value;
            }
        }

        [DataMember]
        public Guid? RoleObjectId
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
