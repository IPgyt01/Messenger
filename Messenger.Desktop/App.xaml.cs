using System.Windows;
using JetBrains.Annotations;
using MaterialDesignThemes.Wpf;
using StructureMap;
using Messenger.Core;
using Messenger.WebApi.Helpers;

namespace Messenger.Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    [IoC, UsedImplicitly]
    public partial class App
    {
        private readonly IUserHelper _userHelper;
        private readonly IChatHelper _chatHelper;
        
        protected override void OnStartup(StartupEventArgs e)
        {
            var window = new MainWindow();
            window.ShowDialog();
        }

        public App(IUserHelper userHelper, IChatHelper chatHelper)
        {
            _userHelper = userHelper;
            _chatHelper = chatHelper;
        }
    }
}