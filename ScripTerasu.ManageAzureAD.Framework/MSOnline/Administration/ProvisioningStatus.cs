using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public enum ProvisioningStatus
    {
        [EnumMember]
        None,
        [EnumMember]
        Success,
        [EnumMember]
        Error,
        [EnumMember]
        PendingInput,
        [EnumMember]
        Disabled,
    }
}
