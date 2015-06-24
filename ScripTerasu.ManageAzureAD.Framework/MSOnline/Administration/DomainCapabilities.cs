using System;
using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    [Flags]
    public enum DomainCapabilities
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Email = 1,
        [EnumMember]
        Sharepoint = 2,
        [EnumMember]
        OfficeCommunicationsOnline = 4,
        [EnumMember]
        SharepointDefault = 8,
        [EnumMember]
        FullRedelegation = 16,
        [EnumMember]
        SharePointPublic = 128,
        [EnumMember]
        OrgIdAuthentication = 256,
        [EnumMember]
        Yammer = 512,
        [EnumMember]
        All = Yammer | OrgIdAuthentication | SharePointPublic | FullRedelegation | SharepointDefault | OfficeCommunicationsOnline | Sharepoint | Email,
    }
}
