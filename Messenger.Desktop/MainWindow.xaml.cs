using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using MaterialDesignThemes.Wpf;
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
        // мне кажется лучше всего переименовать их в хелперы
        private readonly UserHelper _userHelper = new UserHelper();
        private readonly ChatHelper _chatHelper = new ChatHelper();
        private User _user = new User(); 
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

        private void FindFriend(object sender, MouseButtonEventArgs e)
        {
            var possibleFriends = _userHelper.FindUser(UserSearchField.Text.Trim());
        }
    }
}