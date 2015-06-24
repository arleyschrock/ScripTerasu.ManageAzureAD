using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    [DataContract]
    [KnownType(typeof(RoleMemberSearchDefinition))]
    [KnownType(typeof(GroupMemberSearchDefinition))]
    [KnownType(typeof(ServicePrincipalSearchDefinition))]
    [KnownType(typeof(PartnerContractSearchDefinition))]
    [KnownType(typeof(ContactSearchDefinition))]
    [KnownType(typeof(GroupSearchDefinition))]
    [KnownType(typeof(UserSearchDefinition))]
    [KnownType(typeof(UserSearchByStrongAuthenticationDefinition))]
    public class SearchDefinition : IExtensibleDataObject
    {
        private ExtensionDataObject extensionDataField;
        private int PageSizeField;
        private string SearchStringField;
        private SortDirection SortDirectionField;
        private SortField SortFieldField;

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
        public int PageSize
        {
            get
            {
                return this.PageSizeField;
            }
            set
            {
                this.PageSizeField = value;
            }
        }

        [DataMember]
        public string SearchString
        {
            get
            {
                return this.SearchStringField;
            }
            set
            {
                this.SearchStringField = value;
            }
        }

        [DataMember]
        public SortDirection SortDirection
        {
            get
            {
                return this.SortDirectionField;
            }
            set
            {
                this.SortDirectionField = value;
            }
        }

        [DataMember]
        public SortField SortField
        {
            get
            {
                return this.SortFieldField;
            }
            set
            {
                this.SortFieldField = value;
            }
        }
    }
}
