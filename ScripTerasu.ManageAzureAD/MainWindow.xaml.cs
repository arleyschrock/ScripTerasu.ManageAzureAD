using System.Windows;
using ScripTerasu.ManageAzureAD.ViewModel;
using ScripTerasu.ManageAzureAD.View;

namespace ScripTerasu.ManageAzureAD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
            
            LoginView LoginView = new LoginView();
            if ((bool)LoginView.ShowDialog())
            {

            }
            else
            {

            }
        }
    }
}