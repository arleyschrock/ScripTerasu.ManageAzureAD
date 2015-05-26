using ScripTerasu.ManageAzureAD.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace ScripTerasu.ManageAzureAD
{
    /// <summary>
    /// Description for ManageMsolUserView.
    /// </summary>
    public partial class ManageUsersView : Window
    {
        /// <summary>
        /// Initializes a new instance of the ManageMsolUserView class.
        /// </summary>
        public ManageUsersView()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }
    }
}