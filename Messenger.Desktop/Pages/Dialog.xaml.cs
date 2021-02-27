using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Messenger.Database.Models;

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