using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration
{
    [DataContract]
    public enum SortDirection
    {
        [EnumMember]
        Ascending,
        [EnumMember]
        Descending,
    }
}
