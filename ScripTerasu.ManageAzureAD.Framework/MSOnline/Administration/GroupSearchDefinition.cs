using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{

    [DataContract]
    public class GroupSearchDefinition : SearchDefinition
    {
        private GroupType? GroupTypeField;
        private bool? HasErrorsOnlyField;
        private List<string> IncludedPropertiesField;
        private bool? IsAgentRoleField;
        private Guid? UserObjectIdField;
        private string UserPrincipalNameField;

        [DataMember]
        public GroupType? GroupType
        {
            get
            {
                return this.GroupTypeField;
            }
            set
            {
                this.GroupTypeField = value;
            }
        }

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

        [DataMember]
        public bool? IsAgentRole
        {
            get
            {
                return this.IsAgentRoleField;
            }
            set
            {
                this.IsAgentRoleField = value;
            }
        }

        [DataMember]
        public Guid? UserObjectId
        {
            get
            {
                return this.UserObjectIdField;
            }
            set
            {
                this.UserObjectIdField = value;
            }
        }

        [DataMember]
        public string UserPrincipalName
        {
            get
            {
                return this.UserPrincipalNameField;
            }
            set
            {
                this.UserPrincipalNameField = value;
            }
        }
    }
}
