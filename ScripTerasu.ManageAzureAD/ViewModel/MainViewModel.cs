using GalaSoft.MvvmLight;
using ScripTerasu.ManageAzureAD.Model;
using ScripTerasu.ManageAzureAD.View;
using System.Collections.ObjectModel;

namespace ScripTerasu.ManageAzureAD.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        #region Properties
        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "WelcomeTitle";

        private string _welcomeTitle = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }

            set
            {
                if (_welcomeTitle == value)
                {
                    return;
                }

                _welcomeTitle = value;
                RaisePropertyChanged(WelcomeTitlePropertyName);
            }
        }


        /// <summary>
        /// The <see cref="ItemsTabs" /> property's name.
        /// </summary>
        public const string ItemsTabsPropertyName = "ItemsTabs";

        private ObservableCollection<ItemViewModel>  _ItemsTabs = new ObservableCollection<ItemViewModel>();

        /// <summary>
        /// Sets and gets the ItemsTabs property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ObservableCollection<ItemViewModel>  ItemsTabs
        {
            get
            {
                return _ItemsTabs;
            }

            //set
            //{
            //    if (_ItemsTabs == value)
            //    {
            //        return;
            //    }

            //    _ItemsTabs = value;
            //    RaisePropertyChanged(ItemsTabsPropertyName);
            //}
        }
        #endregion

        #region Fields
        private readonly IDataService _dataService;

        #endregion

        #region Constructor
        
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
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

                    WelcomeTitle = item.Title;
                });
            
            LoginView loginView = new LoginView();
            if ((bool)loginView.ShowDialog())
            {

            }
            else
            {

            }
            Initialize();
            
        }

        private void Initialize()
        {
            ItemsTabs.Add(new ItemViewModel("Tab 1"));
            ItemsTabs.Add(new ItemViewModel("Tab 2"));
        }

        #endregion

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}