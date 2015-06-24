using System;
using System.Management.Automation;
using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration.Automation
{
    public class GetUser : IMsolCmdlet
    {
        private const string _CommandText = "Get-MsolUser";

        public string CommandText
        {
            get { return _CommandText; }
        }

        private Guid objectId;
        private bool? returnDeletedUsers;
        private string userPrincipalName;
        private UserSearchDefinition userSearchDefinition;
        private SwitchParameter all;
        private int maxResults;

        [DataMember]
        public Guid ObjectId
        {
            get
            {
                return this.objectId;
            }
            set
            {
                this.objectId = value;
            }
        }

        [DataMember]
        public SwitchParameter ReturnDeletedUsers
        {
            get
            {
                if (this.returnDeletedUsers.HasValue)
                    return (SwitchParameter)this.returnDeletedUsers.Value;
                else
                    return (SwitchParameter)false;
            }
            set
            {
                this.returnDeletedUsers = new bool?((bool)value);
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                this.userSearchDefinition.ReturnDeletedUsers = new bool?((bool)value);
            }
        }

        [DataMember]
        public string UserPrincipalName
        {
            get
            {
                return this.userPrincipalName;
            }
            set
            {
                this.userPrincipalName = value;
            }
        }

        public UserSearchDefinition UserSearchDefinition
        {
            get
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                return this.userSearchDefinition;
            }
            set
            {
                this.userSearchDefinition = value;
            }
        }

        [DataMember]
        public string City
        {
            get
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                return this.userSearchDefinition.City;
            }
            set
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                this.userSearchDefinition.City = value;
            }
        }

        [DataMember]
        public string Country
        {
            get
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                return this.userSearchDefinition.Country;
            }
            set
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                this.userSearchDefinition.Country = value;
            }
        }

        [DataMember]
        public string Department
        {
            get
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                return this.userSearchDefinition.Department;
            }
            set
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                this.userSearchDefinition.Department = value;
            }
        }

        [DataMember]
        public string DomainName
        {
            get
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                return this.userSearchDefinition.DomainName;
            }
            set
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                this.userSearchDefinition.DomainName = value;
            }
        }

        [DataMember]
        public UserEnabledFilter? EnabledFilter
        {
            get
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                return this.userSearchDefinition.EnabledFilter;
            }
            set
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                this.userSearchDefinition.EnabledFilter = value;
            }
        }

        [DataMember]
        public string State
        {
            get
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                return this.userSearchDefinition.State;
            }
            set
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                this.userSearchDefinition.State = value;
            }
        }

        [DataMember]
        public SwitchParameter Synchronized
        {
            get
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                if (this.userSearchDefinition.Synchronized.HasValue)
                    return (SwitchParameter)this.userSearchDefinition.Synchronized.Value;
                else
                    return (SwitchParameter)false;
            }
            set
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                this.userSearchDefinition.Synchronized = new bool?((bool)value);
            }
        }

        [DataMember]
        public string Title
        {
            get
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                return this.userSearchDefinition.Title;
            }
            set
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                this.userSearchDefinition.Title = value;
            }
        }

        [DataMember]
        public SwitchParameter HasErrorsOnly
        {
            get
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                if (this.userSearchDefinition.HasErrorsOnly.HasValue)
                    return (SwitchParameter)this.userSearchDefinition.HasErrorsOnly.Value;
                else
                    return (SwitchParameter)false;
            }
            set
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                this.userSearchDefinition.HasErrorsOnly = new bool?((bool)value);
            }
        }

        [DataMember]
        public SwitchParameter LicenseReconciliationNeededOnly
        {
            get
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                if (this.userSearchDefinition.LicenseReconciliationNeededOnly.HasValue)
                    return (SwitchParameter)this.userSearchDefinition.LicenseReconciliationNeededOnly.Value;
                else
                    return (SwitchParameter)false;
            }
            set
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                this.userSearchDefinition.LicenseReconciliationNeededOnly = new bool?((bool)value);
            }
        }

        [DataMember]
        public SwitchParameter UnlicensedUsersOnly
        {
            get
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                if (this.userSearchDefinition.UnlicensedUsersOnly.HasValue)
                    return (SwitchParameter)this.userSearchDefinition.UnlicensedUsersOnly.Value;
                else
                    return (SwitchParameter)false;
            }
            set
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                this.userSearchDefinition.UnlicensedUsersOnly = new bool?((bool)value);
            }
        }

        [DataMember]
        public string UsageLocation
        {
            get
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                return this.userSearchDefinition.UsageLocation;
            }
            set
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                this.userSearchDefinition.UsageLocation = value;
            }
        }

        [DataMember]
        public string SearchString
        {
            get
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                return this.userSearchDefinition.SearchString;
            }
            set
            {
                if (this.userSearchDefinition == null)
                    this.userSearchDefinition = new UserSearchDefinition();
                this.userSearchDefinition.SearchString = value;
            }
        }

        [DataMember]
        public int MaxResults
        {
            get
            {
                return this.maxResults;
            }
            set
            {
                this.maxResults = value;
            }
        }

        [DataMember]
        public SwitchParameter All
        {
            get
            {
                return this.all;
            }
            set
            {
                this.all = value;
            }
        }

    }
}
