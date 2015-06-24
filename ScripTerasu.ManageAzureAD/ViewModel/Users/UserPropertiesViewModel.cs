using GalaSoft.MvvmLight;
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
        private UserItem _UserItem;

        /// <summary>
        /// Initializes a new instance of the UserPropertiesViewModel class.
        /// </summary>
        public UserPropertiesViewModel(ValidatorFactory validator)
        {
            _UserItem = new UserItem();

            _UserItem.Validator = validator.GetValidator<UserItem>();

        }
    }
}