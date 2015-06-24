using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using ScripTerasu.ManageAzureAD.Framework;
using ScripTerasu.ManageAzureAD.Framework.MSOnline;
using ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration;
using ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration.Automation;
using ScripTerasu.ManageAzureAD.Helpers;
using ScripTerasu.ManageAzureAD.View.Users;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization;

namespace ScripTerasu.ManageAzureAD.ViewModel.Users
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

        #region Commmand
        private RelayCommand _NewCommand;

        /// <summary>
        /// Gets the MyCommand.
        /// </summary>
        public RelayCommand NewCommand
        {
            get
            {
                return _NewCommand
                    ?? (_NewCommand = new RelayCommand(ExecuteNewCommand));
            }
        }

        private void ExecuteNewCommand()
        {
            NewUserView newUser = new NewUserView();
            newUser.ShowDialog();
        }


        private RelayCommand _PropertiesCommand;

        /// <summary>
        /// Gets the PropertiesCommand.
        /// </summary>
        public RelayCommand PropertiesCommand
        {
            get
            {
                return _PropertiesCommand ?? (_PropertiesCommand = new RelayCommand(
                    ExecutePropertiesCommand,
                    CanExecutePropertiesCommand));
            }
        }

        private void ExecutePropertiesCommand()
        {
            if (!PropertiesCommand.CanExecute(null))
            {
                return;
            }
            
        }

        private bool CanExecutePropertiesCommand()
        {
            if (UserSelected != null)
                return true;
            else
                return false;
        }

        #endregion

        /// <summary>
        /// Initializes a new instance of the ManageMsolUserModel class.
        /// </summary>
        public ManageUsersViewModel()
        {

            IMsolCmdlet msolCmdlet = new GetUser() { All = true };
            
            PipelineReader<object> errors;
            ICollection<PSObject> result;

            result = MsolCmdletWrapper.Instance.PipelineInvoke(msolCmdlet, out errors);

            if (result != null)
            {
                foreach (PSObject item in result)
                {
                    User user = TypeExtension.ToObject<User>(item.BaseObject);
                    ListUser.Add(user);
                }
            }
        }
    }
}