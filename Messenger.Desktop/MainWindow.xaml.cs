using Messenger.Database;
using Messenger.WebApi;

namespace Messenger.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            // эти две строчки просто для теста, что все будет работать без ошибок, удалите, когда будете делать
            //var db = new DatabaseContext();
            var api = new Api();
        }
    }
}