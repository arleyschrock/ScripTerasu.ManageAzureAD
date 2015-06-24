using FluentValidation;
using FluentValidation.Results;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using ScripTerasu.ManageAzureAD.Framework;
using ScripTerasu.ManageAzureAD.Framework.MSOnline;
using ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration.Automation;
using ScripTerasu.ManageAzureAD.Helpers;
using ScripTerasu.ManageAzureAD.Model;
using ScripTerasu.ManageAzureAD.Properties;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Windows;
using System.Windows.Input;

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
        private readonly CredentialItem _CredentialItem;

        #region Fields
        private const string KeyVector = "iQVu2tdc5fOnDwNQKmebLVhV5MpY5cKH";

        /// <summary>
        /// The <see cref="Remember" /> property's name.
        /// </summary>
        public const string RememberPropertyName = "Remember";

        private bool _RememberProperty = false;

        /// <summary>
        /// The <see cref="Argument" /> property's name.
        /// </summary>
        public const string ArgumentPropertyName = "Argument";

        private string _argumentProperty;

        /// <summary>
        /// The <see cref="CheckMe" /> property's name.
        /// </summary>
        public const string CheckMePropertyName = "CheckMe";

        private bool _CheckMeProperty = false;

        private RelayCommand _cancelCommand;

        private RelayCommand _loginCommand;

        #endregion

        #region Properties
        /// <summary>
        /// Sets and gets the UserPrincipalName property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string UserPrincipalName
        {
            get
            {
                return _CredentialItem.UserName;
            }

            set
            {
                if (_CredentialItem.UserName == value)
                {
                    return;
                }

                _CredentialItem.UserName = value;
                RaisePropertyChanged(() => UserPrincipalName);
            }
        }

        /// <summary>
        /// Sets and gets the UserPassword property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string UserPassword
        {
            get
            {
                return _CredentialItem.Password;
            }

            set
            {
                if (_CredentialItem.Password == value)
                {
                    return;
                }

                _CredentialItem.Password = value;
                RaisePropertyChanged(() => UserPassword);
            }
        }

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

        /// <summary>
        /// Gets the LoginCommand.
        /// </summary>
        public RelayCommand LoginCommand
        {
            get
            {
                return _loginCommand ?? (_loginCommand = new RelayCommand(
                    ExecuteLoginCommand,
                    CanExecuteLoginCommand));
            }
        }

        private void ExecuteLoginCommand()
        {
            if (!LoginCommand.CanExecute(null))
            {
                return;
            }
            // Verifique las credenciales del usuario están vacías o no.
            if (!string.IsNullOrEmpty(this.UserPrincipalName) && !string.IsNullOrEmpty(this.UserPassword))
            {
                // Asignar nombre de usuario y clave para variable.
                UserCredential.UserName = UserPrincipalName;
                UserCredential.Password = StringExtensions.ToSecureString(UserPassword);

                SavePropertiesSettings();

                MsolCmdletWrapper.Instance.Connect();

                if (MsolCmdletWrapper.Instance.IsConnect)
                {
                    Messenger.Default.Send(true);
                }
                else
                {
                    UserPassword = string.Empty;
                    MessageBox.Show(Messages.BadMemberNameOrPassword);
                }
            }
        }

        private bool CanExecuteLoginCommand()
        {
            return _CredentialItem.IsValid;
        }

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
        #endregion

        /// <summary>
        /// Initializes a new instance of the LoginViewModel class.
        /// </summary>
        public LoginViewModel(ValidatorFactory validator)
        {
            _CredentialItem = new CredentialItem();

            Remember = Properties.Settings.Default.UserCredentialRemember;

            UserPrincipalName = Properties.Settings.Default.UserCredentialUserName;

            string pass = Properties.Settings.Default.UserCredentialUserNamePassword;
            if (!string.IsNullOrEmpty(pass))
            {
                byte[] passwordBytes = Encoding.ASCII.GetBytes(KeyVector);
                UserPassword = AES.Decrypt(pass, passwordBytes);
            }

            _CredentialItem.Validator = validator.GetValidator<CredentialItem>();
        }

        private void SavePropertiesSettings()
        {
            Properties.Settings.Default.UserCredentialRemember = Remember;
            Properties.Settings.Default.UserCredentialUserName = string.Empty;
            Properties.Settings.Default.UserCredentialUserNamePassword = string.Empty;

            if (Remember)
            {
                Properties.Settings.Default.UserCredentialUserName = UserPrincipalName;

                if (!string.IsNullOrEmpty(UserPassword))
                {
                    byte[] passwordBytes = Encoding.ASCII.GetBytes(KeyVector);
                    Properties.Settings.Default.UserCredentialUserNamePassword = AES.Encrypt(UserPassword, passwordBytes);
                }
            }
            Properties.Settings.Default.Save();
        }
    }
}