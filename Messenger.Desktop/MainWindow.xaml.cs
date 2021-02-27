using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using Messenger.Database;
using Messenger.Database.Models;
using Messenger.WebApi;
using System.Linq;

namespace Messenger.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public ObservableCollection<Chat> _listBox { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            // эти две строчки просто для теста, что все будет работать без ошибок, удалите, когда будете делать
            //var db = new DatabaseContext();
            var api = new Api();
            frame.NavigationService.Navigate(new Uri("Pages/PageNoDialog.xaml", UriKind.Relative));
            _listBox = new ObservableCollection<Chat>
            {
                new Chat{Id = "2", History = new List<Message>{new Message{Content = "Дратути))0)"}}},
                new Chat{Id = "1"},
                new Chat{Id = "3"},
            };
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            frame.Source = null;
            frame.Navigate(new Uri("Pages/Dialog.xaml", UriKind.Relative));
        }
    }
}