using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public enum DomainVerificationMethod
    {
        [EnumMember]
        None,
        [EnumMember]
        DnsRecord,
        [EnumMember]
        Email,
    }
}
