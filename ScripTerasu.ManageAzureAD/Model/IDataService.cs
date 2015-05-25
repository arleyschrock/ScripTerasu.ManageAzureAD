using System;

namespace ScripTerasu.ManageAzureAD.Model
{
    public interface IDataService
    {
        void GetData(Action<DataItem, Exception> callback);
    }
}
