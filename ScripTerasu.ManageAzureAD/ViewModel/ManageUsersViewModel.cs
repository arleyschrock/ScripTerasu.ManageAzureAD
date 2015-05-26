using GalaSoft.MvvmLight;
using Microsoft.Online.Administration;
using ScripTerasu.ManageAzureAD.Framework;
using ScripTerasu.ManageAzureAD.Framework.MSOnline;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;

namespace ScripTerasu.ManageAzureAD.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ManageUsersViewModel : ViewModelBase
    {
        #region Properties

        /// <summary>
        /// The <see cref="ListMSolUser" /> property's name.
        /// </summary>
        public const string ListMSolUserPropertyName = "ListMSolUser";

        private ObservableCollection<User> _ListMSolUser = new ObservableCollection<User>();

        /// <summary>
        /// Sets and gets the ListMSolUser property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ObservableCollection<User> ListMSolUser
        {
            get
            {
                return _ListMSolUser;
            }

            set
            {
                if (_ListMSolUser == value)
                {
                    return;
                }

                _ListMSolUser = value;
                RaisePropertyChanged(ListMSolUserPropertyName);
            }
        }

        #endregion


        /// <summary>
        /// Initializes a new instance of the ManageMsolUserModel class.
        /// </summary>
        public ManageUsersViewModel()
        {
            List<IMsolCmdlet> collCmdlets = new List<IMsolCmdlet>();
            collCmdlets.Add(new GetMsolUser() { All = true });

            Collection<PSObject> coll = Executor.Instance.ExcutePowershellCommandsMSOnline(collCmdlets);

            foreach (PSObject item in coll)
            {
                ListMSolUser.Add((User)item.BaseObject);
            }
        }
    }
}