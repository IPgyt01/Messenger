using System;
using System.Windows;
using JetBrains.Annotations;
using Messenger.Core;
using Messenger.Database.Models;

namespace Messenger.Desktop
{
    [IoC, UsedImplicitly]
    public partial class MainWindow
    {
        private User _user = new User(); // временно
        
        public MainWindow()
        {
            InitializeComponent();

            frame.NavigationService.Navigate(new Uri("Pages/PageNoDialog.xaml", UriKind.Relative));
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            frame.Source = null;
            frame.Navigate(new Uri("Pages/Dialog.xaml", UriKind.Relative));
        }

        // private void FindFriend(object sender, MouseButtonEventArgs e)
        // {
        //     var possibleFriends = _userHelper.FindUser(UserSearchField.Text.Trim());
        // }
    }
}