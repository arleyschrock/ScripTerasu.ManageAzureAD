using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public enum UserType
    {
        [EnumMember]
        Other,
        [EnumMember]
        Member,
        [EnumMember]
        Guest,
        [EnumMember]
        Viral,
    }
}
