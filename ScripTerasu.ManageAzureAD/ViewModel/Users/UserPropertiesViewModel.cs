using GalaSoft.MvvmLight;
using ScripTerasu.ManageAzureAD.Framework.MSOnline.Administration;
using ScripTerasu.ManageAzureAD.Model;

namespace ScripTerasu.ManageAzureAD.ViewModel.Users
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class UserPropertiesViewModel : ViewModelBase
    {
        public UserItem _UserItem;

        #region Properties

        /// <summary>
        /// Sets and gets the FirstName property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public string FirstName
        {
            get
            {
                return _UserItem.FirstName;
            }

            set
            {
                if (_UserItem.FirstName == value)
                {
                    return;
                }

                var oldValue = _UserItem.FirstName;
                _UserItem.FirstName = value;
                RaisePropertyChanged(() => FirstName, oldValue, value, true);
            }
        }

        /// <summary>
        /// Sets and gets the LastName property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public string LastName
        {
            get
            {
                return _UserItem.LastName;
            }

            set
            {
                if (_UserItem.LastName == value)
                {
                    return;
                }

                var oldValue = _UserItem.LastName;
                _UserItem.LastName = value;
                RaisePropertyChanged(() => LastName, oldValue, value, true);
            }
        }

        /// <summary>
        /// Sets and gets the DisplayName property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public string DisplayName
        {
            get
            {
                return _UserItem.DisplayName;
            }

            set
            {
                if (_UserItem.DisplayName == value)
                {
                    return;
                }

                var oldValue = _UserItem.DisplayName;
                _UserItem.DisplayName = value;
                RaisePropertyChanged(() => DisplayName, oldValue, value, true);
            }
        }

        /// <summary>
        /// Sets and gets the UserPrincipalName property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public string UserPrincipalName
        {
            get
            {
                return _UserItem.UserPrincipalName;
            }

            set
            {
                if (_UserItem.UserPrincipalName == value)
                {
                    return;
                }

                var oldValue = _UserItem.UserPrincipalName;
                _UserItem.UserPrincipalName = value;
                RaisePropertyChanged(() => UserPrincipalName, oldValue, value, true);
            }
        }

        /// <summary>
        /// Sets and gets the Title property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public string Title
        {
            get
            {
                return _UserItem.Title;
            }

            set
            {
                if (_UserItem.Title == value)
                {
                    return;
                }

                var oldValue = _UserItem.Title;
                _UserItem.Title = value;
                RaisePropertyChanged(() => Title, oldValue, value, true);
            }
        }

        /// <summary>
        /// Sets and gets the Department property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public string Department
        {
            get
            {
                return _UserItem.Department;
            }

            set
            {
                if (_UserItem.Department == value)
                {
                    return;
                }

                var oldValue = _UserItem.Department;
                _UserItem.Department = value;
                RaisePropertyChanged(() => Department, oldValue, value, true);
            }
        }

        /// <summary>
        /// Sets and gets the Office property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public string Office
        {
            get
            {
                return _UserItem.Office;
            }

            set
            {
                if (_UserItem.Office == value)
                {
                    return;
                }

                var oldValue = _UserItem.Office;
                _UserItem.Office = value;
                RaisePropertyChanged(() => Office, oldValue, value, true);
            }
        }

        /// <summary>
        /// Sets and gets the PhoneNumber property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _UserItem.PhoneNumber;
            }

            set
            {
                if (_UserItem.PhoneNumber == value)
                {
                    return;
                }

                var oldValue = _UserItem.PhoneNumber;
                _UserItem.PhoneNumber = value;
                RaisePropertyChanged(() => PhoneNumber, oldValue, value, true);
            }
        }

        /// <summary>
        /// Sets and gets the MobilePhone property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public string MobilePhone
        {
            get
            {
                return _UserItem.MobilePhone;
            }

            set
            {
                if (_UserItem.MobilePhone == value)
                {
                    return;
                }

                var oldValue = _UserItem.MobilePhone;
                _UserItem.MobilePhone = value;
                RaisePropertyChanged(() => MobilePhone, oldValue, value, true);
            }
        }

        /// <summary>
        /// Sets and gets the Fax property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public string Fax
        {
            get
            {
                return _UserItem.Fax;
            }

            set
            {
                if (_UserItem.Fax == value)
                {
                    return;
                }

                var oldValue = _UserItem.Fax;
                _UserItem.Fax = value;
                RaisePropertyChanged(() => Fax, oldValue, value, true);
            }
        }

        /// <summary>
        /// Sets and gets the StreetAddress property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public string StreetAddress
        {
            get
            {
                return _UserItem.StreetAddress;
            }

            set
            {
                if (_UserItem.StreetAddress == value)
                {
                    return;
                }

                var oldValue = _UserItem.StreetAddress;
                _UserItem.StreetAddress = value;
                RaisePropertyChanged(() => StreetAddress, oldValue, value, true);
            }
        }
        
        /// <summary>
        /// Sets and gets the PostalCode property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public string PostalCode
        {
            get
            {
                return _UserItem.PostalCode;
            }

            set
            {
                if (_UserItem.PostalCode == value)
                {
                    return;
                }

                var oldValue = _UserItem.PostalCode;
                _UserItem.PostalCode = value;
                RaisePropertyChanged(() => PostalCode, oldValue, value, true);
            }
        }

        /// <summary>
        /// Sets and gets the City property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public string City
        {
            get
            {
                return _UserItem.City;
            }

            set
            {
                if (_UserItem.City == value)
                {
                    return;
                }

                var oldValue = _UserItem.City;
                _UserItem.City = value;
                RaisePropertyChanged(() => City, oldValue, value, true);
            }
        }

        /// <summary>
        /// Sets and gets the State property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public string State
        {
            get
            {
                return _UserItem.State;
            }

            set
            {
                if (_UserItem.State == value)
                {
                    return;
                }

                var oldValue = _UserItem.State;
                _UserItem.State = value;
                RaisePropertyChanged(() => State, oldValue, value, true);
            }
        }

        /// <summary>
        /// Sets and gets the Country property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public string Country
        {
            get
            {
                return _UserItem.Country;
            }

            set
            {
                if (_UserItem.Country == value)
                {
                    return;
                }

                var oldValue = _UserItem.Country;
                _UserItem.Country = value;
                RaisePropertyChanged(() => Country, oldValue, value, true);
            }
        }

        #endregion

        /// <summary>
        /// Initializes a new instance of the UserPropertiesViewModel class.
        /// </summary>
        public UserPropertiesViewModel(ValidatorFactory validator)
        {
            MessengerInstance.Register<User>(this, _UserItem, userItem => UserItemSomeAction(userItem));
            //_UserItem = new UserItem();
        
            //_UserItem.Validator = validator.GetValidator<UserValidator>();
        
        }

        private void UserItemSomeAction(User userItem)
        {
            if (userItem == null)
                _UserItem = new UserItem();
            else
                _UserItem = (UserItem)userItem;
        }

    }
}