using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using Messenger.Database;
using Messenger.Database.Models;
using Messenger.WebApi;
using Messenger.WebApi.Controllers;

namespace Messenger.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private User _user;
        
        public MainWindow()
        {
            InitializeComponent();
            // эти две строчки просто для теста, что все будет работать без ошибок, удалите, когда будете делать
            //var db = new DatabaseContext();
            var api = new Api();
            frame.NavigationService.Navigate(new Uri("Pages/PageNoDialog.xaml", UriKind.Relative));
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            frame.Source = null;
            frame.Navigate(new Uri("Pages/Dialog.xaml", UriKind.Relative));
        }
    }
}