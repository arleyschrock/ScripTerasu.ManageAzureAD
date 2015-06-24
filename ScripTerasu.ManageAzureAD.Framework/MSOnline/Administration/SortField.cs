using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    [DataContract]
    public enum SortField
    {
        [EnumMember]
        DisplayName,
        [EnumMember]
        UserPrincipalName,
        [EnumMember]
        None,
    }
}
