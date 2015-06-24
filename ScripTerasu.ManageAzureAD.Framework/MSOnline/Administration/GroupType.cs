using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    [DataContract]
    public enum GroupType
    {
        [EnumMember]
        DistributionList,
        [EnumMember]
        Security,
        [EnumMember]
        MailEnabledSecurity,
    }
}

