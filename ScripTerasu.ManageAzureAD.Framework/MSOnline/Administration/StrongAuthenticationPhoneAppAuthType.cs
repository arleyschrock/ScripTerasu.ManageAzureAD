using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public enum StrongAuthenticationPhoneAppAuthType
    {
        [EnumMember]
        Notification = 1,
        [EnumMember]
        OTP = 2,
    }
}
