using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public enum DomainStatus
    {
        [EnumMember]
        Unverified,
        [EnumMember]
        Verified,
        [EnumMember]
        PendingDeletion,
    }
}
