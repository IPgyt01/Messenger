using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Messenger.Desktop.Pages
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            //GridMenu.Children.Clear(); Вот здесь вместо GridMenu должно быть поле из MainWindow

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "Friends":
                    usc = new UserControl();//изменить на страницу с друзьями
                    GridMenu.Children.Add(usc);
                    break;
                case "Groups":
                    usc = new UserControl(); //изменить на страницу с группами 
                    GridMenu.Children.Add(usc);
                    break;
                case "Settings":
                    usc = new UserControl(); //изменить на страницу с настройками
                    GridMenu.Children.Add(usc);
                    break;
                case "Help":
                    usc = new UserControl(); //ну вы поняли
                    GridMenu.Children.Add(usc);
                    break;
                case "ChangeTheme":
                    usc = new UserControl();
                    GridMenu.Children.Add(usc);
                    break;
                default:
                    break;
            }
        }
    }
}
