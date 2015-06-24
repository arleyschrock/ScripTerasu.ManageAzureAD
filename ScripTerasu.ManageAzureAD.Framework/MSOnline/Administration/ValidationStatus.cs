using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public enum ValidationStatus
    {
        [EnumMember]
        NotAvailable,
        [EnumMember]
        Healthy,
        [EnumMember]
        Error,
    }
}
