using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public enum DomainAuthenticationType
    {
        [EnumMember]
        Managed,
        [EnumMember]
        Federated,
    }
}
