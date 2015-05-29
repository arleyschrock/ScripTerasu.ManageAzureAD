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
        /// The <see cref="ListUser" /> property's name.
        /// </summary>
        public const string ListMSolUserPropertyName = "ListMSolUser";

        private ObservableCollection<User> _ListUser = new ObservableCollection<User>();

        /// <summary>
        /// Sets and gets the ListMSolUser property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ObservableCollection<User> ListUser
        {
            get
            {
                return _ListUser;
            }

            set
            {
                if (_ListUser == value)
                {
                    return;
                }

                _ListUser = value;
                RaisePropertyChanged(ListMSolUserPropertyName);
            }
        }

        /// <summary>
        /// The <see cref="UserSelected" /> property's name.
        /// </summary>
        public const string UserSelectedPropertyName = "UserSelected";

        private User _UserSelected;

        /// <summary>
        /// Sets and gets the UserSelected property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public User UserSelected
        {
            get
            {
                return _UserSelected;
            }

            set
            {
                if (_UserSelected == value)
                {
                    return;
                }

                _UserSelected = value;
                RaisePropertyChanged(() => UserSelected);
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

            if (coll != null)
            {

                foreach (PSObject item in coll)
                {
                    ListUser.Add((User)item.BaseObject);
                }
            }
        }
    }
}