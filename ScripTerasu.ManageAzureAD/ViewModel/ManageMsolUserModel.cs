using GalaSoft.MvvmLight;
using ScripTerasu.ManageAzureAD.Model;
using System.Collections.ObjectModel;

namespace ScripTerasu.ManageAzureAD.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ManageMsolUserModel : ViewModelBase
    {

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

        /// <summary>
        /// Initializes a new instance of the ManageMsolUserModel class.
        /// </summary>
        public ManageMsolUserModel()
        {
            ListMSolUser.Add(new User() { MyProperty = "AsDf" });
        }
    }
}