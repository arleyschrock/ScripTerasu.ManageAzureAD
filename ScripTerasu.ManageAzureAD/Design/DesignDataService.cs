 using System;
using ScripTerasu.ManageAzureAD.Model;

namespace ScripTerasu.ManageAzureAD.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data

            var item = new DataItem("Manage Azure AD");
            callback(item, null);
        }
    }
}