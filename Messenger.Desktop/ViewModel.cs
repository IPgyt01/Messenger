using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Messenger.Database.Models;
using Messenger.WebApi.Annotations;
using Messenger.WebApi.Controllers;

namespace Messenger.Desktop
{
    public class ViewModel : INotifyPropertyChanged
    {
        private User _user;
        private ObservableCollection<Chat> _chats;

        public ObservableCollection<Chat> Chats
        {
            get => _chats;
            set
            {
                _chats = value;
                OnPropertyChanged(nameof(Chats));
            }
        }
        
        public ViewModel()
        {
            Task.Run(async () => 
                    Chats = (ObservableCollection<Chat>) await new ChatController().GetChats());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}