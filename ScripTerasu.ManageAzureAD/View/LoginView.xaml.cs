﻿using ScripTerasu.ManageAzureAD.ViewModel;
using System.Windows;

namespace ScripTerasu.ManageAzureAD.View
{
    /// <summary>
    /// Description for LoginView.
    /// </summary>
    public partial class LoginView : Window
    {
        /// <summary>
        /// Initializes a new instance of the LoginView class.
        /// </summary>
        public LoginView()
        {
            InitializeComponent();
            //Closing += (s, e) => ViewModelLocator.Cleanup();
        }
    }
}