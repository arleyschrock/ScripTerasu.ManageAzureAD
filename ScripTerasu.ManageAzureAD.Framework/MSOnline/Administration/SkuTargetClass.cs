using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public enum SkuTargetClass
    {
        [EnumMember]
        NotAvailable,
        [EnumMember]
        User,
        [EnumMember]
        Tenant,
    }
}