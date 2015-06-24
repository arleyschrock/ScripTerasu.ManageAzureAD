using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    //[DataContract(Name = "User")]
    [DataContract(Name = "User", Namespace = "http://schemas.datacontract.org/2004/07/Microsoft.Online.Administration")]
    [KnownType(typeof(UserExtended))]
    public class User : IExtensibleDataObject
    {
        private ExtensionDataObject extensionDataField;
        private List<string> AlternateEmailAddressesField;
        private List<string> AlternateMobilePhonesField;
        private List<AlternativeSecurityId> AlternativeSecurityIdsField;
        private bool? BlockCredentialField;
        private string CityField;
        private int? CloudExchangeRecipientDisplayTypeField;
        private string CountryField;
        private string DepartmentField;
        private string DisplayNameField;
        private List<ValidationError> ErrorsField;
        private string FaxField;
        private string FirstNameField;
        private string ImmutableIdField;
        private bool? IsBlackberryUserField;
        private bool? IsLicensedField;
        private DateTime? LastDirSyncTimeField;
        private string LastNameField;
        private DateTime? LastPasswordChangeTimestampField;
        private bool? LicenseReconciliationNeededField;
        private List<UserLicense> LicensesField;
        private string LiveIdField;
        private string MobilePhoneField;
        private Guid? ObjectIdField;
        private string OfficeField;
        private ProvisioningStatus OverallProvisioningStatusField;
        private bool? PasswordNeverExpiresField;
        private bool? PasswordResetNotRequiredDuringActivateField;
        private string PhoneNumberField;
        private XmlElement PortalSettingsField;
        private string PostalCodeField;
        private string PreferredLanguageField;
        private List<string> ProxyAddressesField;
        private DateTime? SoftDeletionTimestampField;
        private string StateField;
        private string StreetAddressField;
        private List<StrongAuthenticationMethod> StrongAuthenticationMethodsField;
        private List<StrongAuthenticationPhoneAppDetail> StrongAuthenticationPhoneAppDetailsField;
        private long? StrongAuthenticationProofupTimeField;
        private List<StrongAuthenticationRequirement> StrongAuthenticationRequirementsField;
        private bool? StrongPasswordRequiredField;
        private DateTime? StsRefreshTokensValidFromField;
        private string TitleField;
        private string UsageLocationField;
        private string UserLandingPageIdentifierForO365ShellField;
        private string UserPrincipalNameField;
        private string UserThemeIdentifierForO365ShellField;
        private UserType? UserTypeField;
        private ValidationStatus? ValidationStatusField;

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
        public List<string> AlternateEmailAddresses
        {
            get
            {
                return this.AlternateEmailAddressesField;
            }
            set
            {
                this.AlternateEmailAddressesField = value;
            }
        }

        [DataMember]
        public List<string> AlternateMobilePhones
        {
            get
            {
                return this.AlternateMobilePhonesField;
            }
            set
            {
                this.AlternateMobilePhonesField = value;
            }
        }

        [DataMember]
        public List<AlternativeSecurityId> AlternativeSecurityIds
        {
            get
            {
                return this.AlternativeSecurityIdsField;
            }
            set
            {
                this.AlternativeSecurityIdsField = value;
            }
        }

        [DataMember]
        public bool? BlockCredential
        {
            get
            {
                return this.BlockCredentialField;
            }
            set
            {
                this.BlockCredentialField = value;
            }
        }

        [DataMember]
        public string City
        {
            get
            {
                return this.CityField;
            }
            set
            {
                this.CityField = value;
            }
        }

        [DataMember]
        public int? CloudExchangeRecipientDisplayType
        {
            get
            {
                return this.CloudExchangeRecipientDisplayTypeField;
            }
            set
            {
                this.CloudExchangeRecipientDisplayTypeField = value;
            }
        }

        [DataMember]
        public string Country
        {
            get
            {
                return this.CountryField;
            }
            set
            {
                this.CountryField = value;
            }
        }

        [DataMember]
        public string Department
        {
            get
            {
                return this.DepartmentField;
            }
            set
            {
                this.DepartmentField = value;
            }
        }

        [DataMember]
        public string DisplayName
        {
            get
            {
                return this.DisplayNameField;
            }
            set
            {
                this.DisplayNameField = value;
            }
        }

        [DataMember]
        public List<ValidationError> Errors
        {
            get
            {
                return this.ErrorsField;
            }
            set
            {
                this.ErrorsField = value;
            }
        }

        [DataMember]
        public string Fax
        {
            get
            {
                return this.FaxField;
            }
            set
            {
                this.FaxField = value;
            }
        }

        [DataMember]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }

        [DataMember]
        public string ImmutableId
        {
            get
            {
                return this.ImmutableIdField;
            }
            set
            {
                this.ImmutableIdField = value;
            }
        }

        [DataMember]
        public bool? IsBlackberryUser
        {
            get
            {
                return this.IsBlackberryUserField;
            }
            set
            {
                this.IsBlackberryUserField = value;
            }
        }

        [DataMember]
        public bool? IsLicensed
        {
            get
            {
                return this.IsLicensedField;
            }
            set
            {
                this.IsLicensedField = value;
            }
        }

        [DataMember]
        public DateTime? LastDirSyncTime
        {
            get
            {
                return this.LastDirSyncTimeField;
            }
            set
            {
                this.LastDirSyncTimeField = value;
            }
        }

        [DataMember]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }

        [DataMember]
        public DateTime? LastPasswordChangeTimestamp
        {
            get
            {
                return this.LastPasswordChangeTimestampField;
            }
            set
            {
                this.LastPasswordChangeTimestampField = value;
            }
        }

        [DataMember]
        public bool? LicenseReconciliationNeeded
        {
            get
            {
                return this.LicenseReconciliationNeededField;
            }
            set
            {
                this.LicenseReconciliationNeededField = value;
            }
        }

        [DataMember]
        public List<UserLicense> Licenses
        {
            get
            {
                return this.LicensesField;
            }
            set
            {
                this.LicensesField = value;
            }
        }

        [DataMember]
        public string LiveId
        {
            get
            {
                return this.LiveIdField;
            }
            set
            {
                this.LiveIdField = value;
            }
        }

        [DataMember]
        public string MobilePhone
        {
            get
            {
                return this.MobilePhoneField;
            }
            set
            {
                this.MobilePhoneField = value;
            }
        }

        [DataMember]
        public Guid? ObjectId
        {
            get
            {
                return this.ObjectIdField;
            }
            set
            {
                this.ObjectIdField = value;
            }
        }

        [DataMember]
        public string Office
        {
            get
            {
                return this.OfficeField;
            }
            set
            {
                this.OfficeField = value;
            }
        }

        [DataMember]
        public ProvisioningStatus OverallProvisioningStatus
        {
            get
            {
                return this.OverallProvisioningStatusField;
            }
            set
            {
                this.OverallProvisioningStatusField = value;
            }
        }

        [DataMember]
        public bool? PasswordNeverExpires
        {
            get
            {
                return this.PasswordNeverExpiresField;
            }
            set
            {
                this.PasswordNeverExpiresField = value;
            }
        }

        [DataMember]
        public bool? PasswordResetNotRequiredDuringActivate
        {
            get
            {
                return this.PasswordResetNotRequiredDuringActivateField;
            }
            set
            {
                this.PasswordResetNotRequiredDuringActivateField = value;
            }
        }

        [DataMember]
        public string PhoneNumber
        {
            get
            {
                return this.PhoneNumberField;
            }
            set
            {
                this.PhoneNumberField = value;
            }
        }

        [DataMember]
        public XmlElement PortalSettings
        {
            get
            {
                return this.PortalSettingsField;
            }
            set
            {
                this.PortalSettingsField = value;
            }
        }

        [DataMember]
        public string PostalCode
        {
            get
            {
                return this.PostalCodeField;
            }
            set
            {
                this.PostalCodeField = value;
            }
        }

        [DataMember]
        public string PreferredLanguage
        {
            get
            {
                return this.PreferredLanguageField;
            }
            set
            {
                this.PreferredLanguageField = value;
            }
        }

        [DataMember]
        public List<string> ProxyAddresses
        {
            get
            {
                return this.ProxyAddressesField;
            }
            set
            {
                this.ProxyAddressesField = value;
            }
        }

        [DataMember]
        public DateTime? SoftDeletionTimestamp
        {
            get
            {
                return this.SoftDeletionTimestampField;
            }
            set
            {
                this.SoftDeletionTimestampField = value;
            }
        }

        [DataMember]
        public string State
        {
            get
            {
                return this.StateField;
            }
            set
            {
                this.StateField = value;
            }
        }

        [DataMember]
        public string StreetAddress
        {
            get
            {
                return this.StreetAddressField;
            }
            set
            {
                this.StreetAddressField = value;
            }
        }

        [DataMember]
        public List<StrongAuthenticationMethod> StrongAuthenticationMethods
        {
            get
            {
                return this.StrongAuthenticationMethodsField;
            }
            set
            {
                this.StrongAuthenticationMethodsField = value;
            }
        }

        [DataMember]
        public List<StrongAuthenticationPhoneAppDetail> StrongAuthenticationPhoneAppDetails
        {
            get
            {
                return this.StrongAuthenticationPhoneAppDetailsField;
            }
            set
            {
                this.StrongAuthenticationPhoneAppDetailsField = value;
            }
        }

        [DataMember]
        public long? StrongAuthenticationProofupTime
        {
            get
            {
                return this.StrongAuthenticationProofupTimeField;
            }
            set
            {
                this.StrongAuthenticationProofupTimeField = value;
            }
        }

        [DataMember]
        public List<StrongAuthenticationRequirement> StrongAuthenticationRequirements
        {
            get
            {
                return this.StrongAuthenticationRequirementsField;
            }
            set
            {
                this.StrongAuthenticationRequirementsField = value;
            }
        }

        [DataMember]
        public bool? StrongPasswordRequired
        {
            get
            {
                return this.StrongPasswordRequiredField;
            }
            set
            {
                this.StrongPasswordRequiredField = value;
            }
        }

        [DataMember]
        public DateTime? StsRefreshTokensValidFrom
        {
            get
            {
                return this.StsRefreshTokensValidFromField;
            }
            set
            {
                this.StsRefreshTokensValidFromField = value;
            }
        }

        [DataMember]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }

        [DataMember]
        public string UsageLocation
        {
            get
            {
                return this.UsageLocationField;
            }
            set
            {
                this.UsageLocationField = value;
            }
        }

        [DataMember]
        public string UserLandingPageIdentifierForO365Shell
        {
            get
            {
                return this.UserLandingPageIdentifierForO365ShellField;
            }
            set
            {
                this.UserLandingPageIdentifierForO365ShellField = value;
            }
        }

        [DataMember]
        public string UserPrincipalName
        {
            get
            {
                return this.UserPrincipalNameField;
            }
            set
            {
                this.UserPrincipalNameField = value;
            }
        }

        [DataMember]
        public string UserThemeIdentifierForO365Shell
        {
            get
            {
                return this.UserThemeIdentifierForO365ShellField;
            }
            set
            {
                this.UserThemeIdentifierForO365ShellField = value;
            }
        }

        [DataMember]
        public UserType? UserType
        {
            get
            {
                return this.UserTypeField;
            }
            set
            {
                this.UserTypeField = value;
            }
        }

        [DataMember]
        public ValidationStatus? ValidationStatus
        {
            get
            {
                return this.ValidationStatusField;
            }
            set
            {
                this.ValidationStatusField = value;
            }
        }
    }
}
