using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using ScripTerasu.ManageAzureAD.Model;
using ScripTerasu.ManageAzureAD.Framework;
using ScripTerasu.ManageAzureAD.Framework.MSOnline;
using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Security;
using System.Windows;
using System.Collections.ObjectModel;
using ScripTerasu.ManageAzureAD.Helpers;

namespace ScripTerasu.ManageAzureAD.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class LoginViewModel : ViewModelBase
    {
        #region Property
        /// <summary>
        /// The <see cref="UserPrincipalName" /> property's name.
        /// </summary>
        public const string UserPrincipalNamePropertyName = "UserPrincipalName";

        private string _UserPrincipalName;

        /// <summary>
        /// Sets and gets the UserPrincipalName property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string UserPrincipalName
        {
            get
            {
                return _UserPrincipalName;
            }

            set
            {
                if (_UserPrincipalName == value)
                {
                    return;
                }

                _UserPrincipalName = value;
                RaisePropertyChanged(UserPrincipalNamePropertyName);
            }
        }

        /// <summary>
        /// The <see cref="UserPassword" /> property's name.
        /// </summary>
        public const string UserPasswordPropertyName = "UserPassword";

        private string _UserPassword;

        /// <summary>
        /// Sets and gets the UserPassword property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string UserPassword
        {
            get
            {
                return _UserPassword;
            }

            set
            {
                if (_UserPassword == value)
                {
                    return;
                }

                _UserPassword = value;
                RaisePropertyChanged(UserPasswordPropertyName);
            }
        }
        #endregion

        #region Command

        private RelayCommand _cancelCommand;

        /// <summary>
        /// Gets the CancelCommand.
        /// </summary>
        public RelayCommand CancelCommand
        {
            get
            {
                return _cancelCommand
                    ?? (_cancelCommand = new RelayCommand(ExecuteCancelCommand));
            }
        }

        private void ExecuteCancelCommand()
        {
            Application.Current.Shutdown();
        }

        private RelayCommand _loginCommand;

        /// <summary>
        /// Gets the LoginCommand.
        /// </summary>
        public RelayCommand LoginCommand
        {
            get
            {
                return _loginCommand
                    ?? (_loginCommand = new RelayCommand(ExecuteLoginCommand));
            }
        }

        private void ExecuteLoginCommand()
        {
            // Verify user credentials are empty or not.
            if (string.IsNullOrEmpty(this.UserPrincipalName) || string.IsNullOrEmpty(this.UserPassword))
            {
                return;
            }

            // Assign username to variable.
            UserCredential.UserName = UserPrincipalName;
            UserCredential.Password = StringExtensions.ToSecureString(UserPassword);

            // Create Initial Session State for runspace.
            InitialSessionState initialSession = InitialSessionState.CreateDefault();
            initialSession.ImportPSModule(new[] { "MSOnline" });

            List<IMsolCmdlet> collCmdlets = new List<IMsolCmdlet>();
            
            // Create credential object.
            PSCredential credential = new PSCredential(UserCredential.UserName, UserCredential.Password);

            collCmdlets.Add(new ConnectMsolService(){ Credential = credential});
            collCmdlets.Add(new GetMsolUser() { UsageLocation = "CL"});

            Collection<PSObject> coll = Executor.Instance.ExcutePowershellCommands(initialSession, collCmdlets);

        }
        #endregion

        private readonly IDataService _dataService;

        /// <summary>
        /// Initializes a new instance of the LoginViewModel class.
        /// </summary>
        public LoginViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }
                });
        }

    }
}