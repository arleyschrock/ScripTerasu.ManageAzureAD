using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    [DataContract]
    public enum UserEnabledFilter
    {
        [EnumMember]
        All,
        [EnumMember]
        EnabledOnly,
        [EnumMember]
        DisabledOnly,
    }
}
