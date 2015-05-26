using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using ScripTerasu.ManageAzureAD.Helpers;
using ScripTerasu.ManageAzureAD.Model;
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


        /// <summary>
        /// The <see cref="Result" /> property's name.
        /// </summary>
        public const string ResultPropertyName = "Result";

        private string _resultProperty;

        /// <summary>
        /// Sets and gets the Result property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Result
        {
            get
            {
                return _resultProperty;
            }

            set
            {
                if (_resultProperty == value)
                {
                    return;
                }

                _resultProperty = value;
                RaisePropertyChanged(() => Result);
            }
        }

        /// <summary>
        /// The <see cref="Visible" /> property's name.
        /// </summary>
        public const string VisiblePropertyName = "Visible";

        private System.Windows.Visibility _VisibleProperty = System.Windows.Visibility.Hidden;

        /// <summary>
        /// Sets and gets the SomeString property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public System.Windows.Visibility Visible
        {
            get
            {
                return _VisibleProperty;
            }

            set
            {
                if (_VisibleProperty == value)
                {
                    return;
                }

                _VisibleProperty = value;
                RaisePropertyChanged(() => Visible);
            }
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