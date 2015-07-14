using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration;
using ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration.Automation;
using ScripTerasu.ManageAzureAD.Helpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Management.Automation;
using System.Windows.Input;
using Frame = ScripTerasu.ManageAzureAD.Framework;
using Msol = ScripTerasu.ManageAzureAD.Framework.MSOnline;

namespace ScripTerasu.ManageAzureAD.ViewModel.Users
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class NewUserViewModel : ViewModelBase, IDataErrorInfo
    {
        #region Fields
        private bool IsAutoDisplayName = true;

        readonly Model.Automation.NewUser _newUser;

        /// <summary>
        /// The <see cref="UserName" /> property's name.
        /// </summary>
        public const string UserNamePropertyName = "UserName";

        private string _UserName;


        /// <summary>
        /// The <see cref="DomainSource" /> property's name.
        /// </summary>
        public const string DomainSourcePropertyName = "DomainSource";
        private ObservableCollection<string> _DomainSource = new ObservableCollection<string>();

        /// <summary>
        /// The <see cref="DomainSelected" /> property's name.
        /// </summary>
        public const string DomainSelectedPropertyName = "DomainSelected";
        private string _DomainSelected;

        #endregion

        //#region NewUser Properties
        ///// <summary>
        ///// Sets and gets the UserPrincipalName property.
        ///// Changes to that property's value raise the PropertyChanged event. 
        ///// </summary>
        //public string UserPrincipalName
        //{
        //    get
        //    {
        //        return _newUser.UserPrincipalName;
        //    }

        //    set
        //    {
        //        if (_newUser.UserPrincipalName == value)
        //        {
        //            return;
        //        }

        //        _newUser.UserPrincipalName = value;
        //        RaisePropertyChanged(() => UserPrincipalName);
        //    }
        //}

        ///// <summary>
        ///// Sets and gets the DisplayName property.
        ///// Changes to that property's value raise the PropertyChanged event. 
        ///// </summary>
        //public string DisplayName
        //{
        //    get
        //    {
        //        return _newUser.DisplayName;
        //    }

        //    set
        //    {
        //        if (_newUser.DisplayName == value)
        //        {
        //            return;
        //        }

        //        _newUser.DisplayName = value;
        //        RaisePropertyChanged(() => DisplayName);
        //    }
        //}


        ///// <summary>
        ///// Sets and gets the FirstName property.
        ///// Changes to that property's value raise the PropertyChanged event. 
        ///// </summary>
        //public string FirstName
        //{
        //    get
        //    {
        //        return _newUser.FirstName;
        //    }

        //    set
        //    {
        //        if (_newUser.FirstName == value)
        //        {
        //            return;
        //        }

        //        _newUser.FirstName = value;
        //        RaisePropertyChanged(() => FirstName);
        //        ChangeDisplayName();
        //    }
        //}

        ///// <summary>
        ///// Sets and gets the ForceChangePassword property.
        ///// Changes to that property's value raise the PropertyChanged event. 
        ///// </summary>
        //public bool? ForceChangePassword
        //{
        //    get
        //    {
        //        return _newUser.ForceChangePassword;
        //    }

        //    set
        //    {
        //        if (_newUser.ForceChangePassword == value)
        //        {
        //            return;
        //        }

        //        _newUser.ForceChangePassword = value;
        //        RaisePropertyChanged(() => ForceChangePassword);
        //    }
        //}

        ///// <summary>
        ///// Sets and gets the LastName property.
        ///// Changes to that property's value raise the PropertyChanged event. 
        ///// </summary>
        //public string LastName
        //{
        //    get
        //    {
        //        return _newUser.LastName;
        //    }

        //    set
        //    {
        //        if (_newUser.LastName == value)
        //        {
        //            return;
        //        }

        //        _newUser.LastName = value;
        //        RaisePropertyChanged(() => LastName);
        //        ChangeDisplayName();
        //    }
        //}

        //#endregion

        #region Properties
        
        /// <summary>
        /// Sets and gets the UserName property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string UserName
        {
            get
            {
                return _UserName;
            }

            set
            {
                if (_UserName == value)
                {
                    return;
                }

                _UserName = value;
                RaisePropertyChanged(() => UserName);
                ChangeUserPrincipalName();
            }
        }

        /// <summary>
        /// Sets and gets the DomainSource property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ObservableCollection<string> DomainSource
        {
            get
            {
                return _DomainSource;
            }

            set
            {
                if (_DomainSource == value)
                {
                    return;
                }

                _DomainSource = value;
                RaisePropertyChanged(() => DomainSource);
            }
        }

        /// <summary>
        /// Sets and gets the DomainSelected property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string DomainSelected
        {
            get
            {
                return _DomainSelected;
            }

            set
            {
                if (_DomainSelected == value)
                {
                    return;
                }

                _DomainSelected = value;
                RaisePropertyChanged(() => DomainSelected);
                ChangeUserPrincipalName();
            }
        }
        #endregion

        #region Command

        private RelayCommand _CreateCommand;

        /// <summary>
        /// Gets the MyCommand.
        /// </summary>
        public RelayCommand CreateCommand
        {
            get
            {
                return _CreateCommand
                    ?? (_CreateCommand = new RelayCommand(ExecuteCreateCommand, CanExecuteCreateCommand));
            }
        }

        private void ExecuteCreateCommand()
        {
            List<IMsolCmdlet> collCmdlets = new List<IMsolCmdlet>();
            //Framework.MSOnline.NewMsolUser newMsolUser = new
            //    Framework.MSOnline.NewMsolUser()
            //    {
            //        FirstName = this.FirstName,
            //        LastName = this.LastName,
            //        DisplayName = this.DisplayName,
            //        UserPrincipalName = this.UserPrincipalName,
            //    };
            //collCmdlets.Add(newMsolUser);

            //Collection<PSObject> coll = Executor.Instance.ExcutePowershellCommandsMSOnline(collCmdlets);
        }

        private bool CanExecuteCreateCommand()
        {
            return _newUser.IsValid;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the NewUserViewModel class.
        /// </summary>
        public NewUserViewModel()
        {
            _newUser = Model.Automation.NewUser.CreateNewUser();
            //_newUser.ForceChangePassword = true;
            FillDomainSource();
        }

        #endregion // Constructor

        #region Private Helpers

        private void ChangeUserPrincipalName()
        {
            //UserPrincipalName = string.Format("{0}@{1}", UserName, DomainSelected);
        }

        private void ChangeDisplayName()
        {
            if (IsAutoDisplayName)
            {
                //DisplayName = string.Format("{0} {1}", FirstName, LastName);
                //if (!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
                //{
                //    IsAutoDisplayName = false;
                //}
            }
        }

        public void FillDomainSource()
        {
            //List<IMsolCmdlet> collCmdlets = new List.IMsolCmdlet>();

            //collCmdlets.Add(new Msol.GetMsolDomain() { Status = "Verified" });

            //Collection<PSObject> coll = Frame.Executor.Instance.ExcutePowershellCommandsMSOnline(collCmdlets);

            //List<Domain> collDomain = new List<Domain>();

            //if (coll != null)
            //{
            //    foreach (PSObject item in coll)
            //    {
            //        collDomain.Add((Domain)item.BaseObject);
            //    }
            //}
            //if (collDomain != null)
            //{
            //    foreach (Domain item in collDomain)
            //    {
            //        if (!item.Capabilities.Equals(DomainCapabilities.None))
            //        {
            //            DomainSource.Add(item.Name);
            //        }
            //    }
            //}
            //DomainSelected = collDomain.Find(d => d.IsDefault.HasValue.Equals(true)).Name.ToString();
        }

        #endregion

        #region IDataErrorInfo Members

        string IDataErrorInfo.Error
        {
            get { return (_newUser as IDataErrorInfo).Error; }
        }

        string IDataErrorInfo.this[string propertyName]
        {
            get
            {
                string error = null;

                //if (propertyName == "CustomerType")
                //{
                //    // The IsCompany property of the Customer class 
                //    // is Boolean, so it has no concept of being in
                //    // an "unselected" state.  The CustomerViewModel
                //    // class handles this mapping and validation.
                //    error = this.ValidateCustomerType();
                //}
                //else
                //{
                    error = (_newUser as IDataErrorInfo)[propertyName];
                //}

                // Dirty the commands registered with CommandManager,
                // such as our Save command, so that they are queried
                // to see if they can execute now.
                CommandManager.InvalidateRequerySuggested();

                return error;
            }
        }

        //string ValidateCustomerType()
        //{
        //    if (this.CustomerType == Strings.CustomerViewModel_CustomerTypeOption_Company ||
        //       this.CustomerType == Strings.CustomerViewModel_CustomerTypeOption_Person)
        //        return null;

        //    return Strings.CustomerViewModel_Error_MissingCustomerType;
        //}

        #endregion // IDataErrorInfo Members
    }
}