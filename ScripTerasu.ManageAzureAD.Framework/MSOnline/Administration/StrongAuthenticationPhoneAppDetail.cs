using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    public class StrongAuthenticationPhoneAppDetail : IExtensibleDataObject
    {
        private ExtensionDataObject extensionDataField;
        private StrongAuthenticationPhoneAppAuthType AuthenticationTypeField;
        private string DeviceNameField;
        private string DeviceTagField;
        private string DeviceTokenField;
        private StrongAuthenticationPhoneAppNotificationType NotificationTypeField;
        private string OathSecretKeyField;
        private int OathTokenTimeDriftField;
        private string PhoneAppVersionField;

        public ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [DataMember]
        public StrongAuthenticationPhoneAppAuthType AuthenticationType
        {
            get
            {
                return this.AuthenticationTypeField;
            }
            set
            {
                this.AuthenticationTypeField = value;
            }
        }

        [DataMember]
        public string DeviceName
        {
            get
            {
                return this.DeviceNameField;
            }
            set
            {
                this.DeviceNameField = value;
            }
        }

        [DataMember]
        public string DeviceTag
        {
            get
            {
                return this.DeviceTagField;
            }
            set
            {
                this.DeviceTagField = value;
            }
        }

        [DataMember]
        public string DeviceToken
        {
            get
            {
                return this.DeviceTokenField;
            }
            set
            {
                this.DeviceTokenField = value;
            }
        }

        [DataMember]
        public StrongAuthenticationPhoneAppNotificationType NotificationType
        {
            get
            {
                return this.NotificationTypeField;
            }
            set
            {
                this.NotificationTypeField = value;
            }
        }

        [DataMember]
        public string OathSecretKey
        {
            get
            {
                return this.OathSecretKeyField;
            }
            set
            {
                this.OathSecretKeyField = value;
            }
        }

        [DataMember]
        public int OathTokenTimeDrift
        {
            get
            {
                return this.OathTokenTimeDriftField;
            }
            set
            {
                this.OathTokenTimeDriftField = value;
            }
        }

        [DataMember]
        public string PhoneAppVersion
        {
            get
            {
                return this.PhoneAppVersionField;
            }
            set
            {
                this.PhoneAppVersionField = value;
            }
        }
    }
}
