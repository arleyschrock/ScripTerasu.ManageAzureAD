using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public enum StrongAuthenticationPhoneAppNotificationType
    {
        [EnumMember]
        Unspecified,
        [EnumMember]
        Invalid,
        [EnumMember]
        APNS,
        [EnumMember]
        C2DM,
        [EnumMember]
        GCM,
        [EnumMember]
        MPNS,
        [EnumMember]
        BPS,
    }
}
