using GalaSoft.MvvmLight;

namespace ScripTerasu.ManageAzureAD.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ItemViewModel : ViewModelBase
    {
        /// <summary>
        /// The <see cref="Name" /> property's name.
        /// </summary>
        public const string NamePropertyName = "Name";

        private string _Name;

        /// <summary>
        /// Sets and gets the Name property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                if (_Name == value)
                {
                    return;
                }

                _Name = value;
                RaisePropertyChanged(NamePropertyName);
            }
        }


        public string TabName { get; private set; }
        /// <summary>
        /// Initializes a new instance of the ItemViewModel class.
        /// </summary>
        public ItemViewModel(string tabName)
        {
            TabName = tabName;
        }
    }
}