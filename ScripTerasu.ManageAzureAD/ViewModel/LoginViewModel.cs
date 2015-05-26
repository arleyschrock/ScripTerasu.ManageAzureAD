using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using ScripTerasu.ManageAzureAD.Framework;
using ScripTerasu.ManageAzureAD.Framework.MSOnline;
using ScripTerasu.ManageAzureAD.Helpers;
using ScripTerasu.ManageAzureAD.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Windows;

namespace ScripTerasu.ManageAzureAD.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class LoginViewModel : ViewModelBase, ICloseable
    {
        private readonly IDataService _dataService;

        #region Properties
        /// <summary>
        /// The <see cref="UserPrincipalName" /> property's name.
        /// </summary>
        public const string UserPrincipalNamePropertyName = "UserPrincipalName";

        private string _UserPrincipalNameProperty;

        /// <summary>
        /// Sets and gets the UserPrincipalName property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string UserPrincipalName
        {
            get
            {
                return _UserPrincipalNameProperty;
            }

            set
            {
                if (_UserPrincipalNameProperty == value)
                {
                    return;
                }

                _UserPrincipalNameProperty = value;
                RaisePropertyChanged(() => UserPrincipalName);
            }
        }

        /// <summary>
        /// The <see cref="UserPassword" /> property's name.
        /// </summary>
        public const string UserPasswordPropertyName = "UserPassword";

        private string _UserPasswordProperty;

        /// <summary>
        /// Sets and gets the UserPassword property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string UserPassword
        {
            get
            {
                return _UserPasswordProperty;
            }

            set
            {
                if (_UserPasswordProperty == value)
                {
                    return;
                }

                _UserPasswordProperty = value;
                RaisePropertyChanged(() => UserPassword);
            }
        }

        /// <summary>
        /// The <see cref="Remember" /> property's name.
        /// </summary>
        public const string RememberPropertyName = "Remember";

        private bool _RememberProperty = false;

        /// <summary>
        /// Sets and gets the Remember property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public bool Remember
        {
            get
            {
                return _RememberProperty;
            }

            set
            {
                if (_RememberProperty == value)
                {
                    return;
                }

                _RememberProperty = value;
                RaisePropertyChanged(() => Remember);
            }
        }

        /// <summary>
        /// The <see cref="Argument" /> property's name.
        /// </summary>
        public const string ArgumentPropertyName = "Argument";

        private string _argumentProperty;

        /// <summary>
        /// Sets and gets the Argument property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Argument
        {
            get
            {
                return _argumentProperty;
            }

            set
            {
                if (_argumentProperty == value)
                {
                    return;
                }

                _argumentProperty = value;
                RaisePropertyChanged(() => Argument);
            }
        }


        /// <summary>
        /// The <see cref="CheckMe" /> property's name.
        /// </summary>
        public const string CheckMePropertyName = "CheckMe";

        private bool _CheckMeProperty = false;

        /// <summary>
        /// Sets and gets the CheckMe property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public bool CheckMe
        {
            get
            {
                return _CheckMeProperty;
            }

            set
            {
                if (_CheckMeProperty == value)
                {
                    return;
                }

                _CheckMeProperty = value;
                Messenger.Default.Send(_CheckMeProperty ? "Accepted" : "Rejected");
                RaisePropertyChanged(() => CheckMe);
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
            //Messenger.Default.Send(false);
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
                    ?? (_loginCommand = new RelayCommand(
                    () =>
                    {
                        ExecuteLoginCommand();
                    }));
            }
        }

        private void ExecuteLoginCommand()
        {
            // Verifique las credenciales del usuario están vacías o no.
            if (!string.IsNullOrEmpty(this.UserPrincipalName) && !string.IsNullOrEmpty(this.UserPassword))
            {
                // Asignar nombre de usuario y clave para variable.
                UserCredential.UserName = UserPrincipalName;
                UserCredential.Password = StringExtensions.ToSecureString(UserPassword);

                List<IMsolCmdlet> collCmdlets = new List<IMsolCmdlet>();
                collCmdlets.Add(new GetMsolAccountSku());

                Collection<PSObject> coll = Executor.Instance.ExcutePowershellCommandsMSOnline(collCmdlets);

                if (coll != null)
                    Messenger.Default.Send(true);
                else
                    Messenger.Default.Send(false);
            }
            return;
        }
        #endregion

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
            UserPrincipalName = "salmendra@tyschile.cl";
        }

    }
}