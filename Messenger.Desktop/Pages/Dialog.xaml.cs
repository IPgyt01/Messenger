using System.Windows.Controls;
using System.Windows.Input;

namespace Messenger.Desktop
{
    public partial class Dialog : Page
    {
        public Dialog()
        {
            InitializeComponent();
        }

        private void UIElement_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            TextBox.Text = "its work";
        }
        
        private void UIElement_OnMouseUp2(object sender, MouseButtonEventArgs e)
        {
            TextBox.Text = "";
        }
    }
}