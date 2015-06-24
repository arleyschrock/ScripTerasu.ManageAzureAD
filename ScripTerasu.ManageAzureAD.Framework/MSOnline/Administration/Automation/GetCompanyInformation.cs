
namespace ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration.Automation
{
    public class GetCompanyInformation : IMsolCmdlet
    {
        private const string _CommandText = "Get-MsolCompanyInformation";

        public string CommandText
        {
            get { return _CommandText; }
        }
    }
}
