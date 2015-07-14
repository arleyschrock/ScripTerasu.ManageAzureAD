using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration.Automation
{
    [DataContract]
    public class GetDomain : IMsolCmdlet
    {
        private const string _CommandText = "Get-MsolDomain";

        public string CommandText
        {
            get { return _CommandText; }
        }

        private string domainName;
        private DomainSearchFilter searchFilter;

        [DataMember]
        public string DomainName
        {
            get
            {
                return this.domainName;
            }
            set
            {
                this.domainName = value;
            }
        }

        public DomainSearchFilter SearchFilter
        {
            get
            {
                if (this.searchFilter == null)
                    this.searchFilter = new DomainSearchFilter();
                return this.searchFilter;
            }
            set
            {
                this.searchFilter = value;
            }
        }

        [DataMember]
        public DomainStatus? Status
        {
            get
            {
                if (this.searchFilter == null)
                    this.searchFilter = new DomainSearchFilter();
                return this.searchFilter.Status;
            }
            set
            {
                if (this.searchFilter == null)
                    this.searchFilter = new DomainSearchFilter();
                this.searchFilter.Status = value;
            }
        }

        [DataMember]
        public DomainAuthenticationType? Authentication
        {
            get
            {
                if (this.searchFilter == null)
                    this.searchFilter = new DomainSearchFilter();
                return this.searchFilter.Authentication;
            }
            set
            {
                if (this.searchFilter == null)
                    this.searchFilter = new DomainSearchFilter();
                this.searchFilter.Authentication = value;
            }
        }

        [DataMember]
        public DomainCapabilities? Capability
        {
            get
            {
                if (this.searchFilter == null)
                    this.searchFilter = new DomainSearchFilter();
                return this.searchFilter.Capability;
            }
            set
            {
                if (this.searchFilter == null)
                    this.searchFilter = new DomainSearchFilter();
                this.searchFilter.Capability = value;
            }
        }

    }

}
