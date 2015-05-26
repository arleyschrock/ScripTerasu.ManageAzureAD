using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using ScripTerasu.ManageAzureAD.Helpers;
using ScripTerasu.ManageAzureAD.ViewModel;
using System.Windows;

namespace ScripTerasu.ManageAzureAD
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ViewModelLocator.CreateLoginWindow(new OpenWindowMessage() { Type = WindowType.kModal});
            Messenger.Default.Register<bool>(this, OnLaunchResultLogin);
        }

        public void OnLaunchResultLogin(bool result)
        {
            if (result)
            {
                ManageUsersView manageUsers = new ManageUsersView();
                // Create Main Window View Model
                ManageUsersViewModel viewModel = new ManageUsersViewModel();

                // Associate DataContext
                manageUsers.DataContext = viewModel;
                Application.Current.MainWindow = manageUsers;

                //LoginView reportW = Application.Current.Windows.OfType<LoginView>().SingleOrDefault();

                foreach (Window item in Application.Current.Windows)
	            {
                    try
                    {
                        LoginView loginView = (LoginView)item;
                        loginView.Close();
                    }
                    catch { }
	            } 
                
                manageUsers.Show();
            }else{
                MessageBox.Show("Credenciales Incorrectas");
            }
        }
    }
}
