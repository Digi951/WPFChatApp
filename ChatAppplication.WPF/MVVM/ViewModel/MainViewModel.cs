using ChatAppplication.WPF.Core;
using ChatAppplication.WPF.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAppplication.WPF.MVVM.ViewModel;
internal class MainViewModel : ObservableObject
{
    public ObservableCollection<MessageModel> Messages { get; set; }
    public ObservableCollection<ContactModel> Contacts { get; set; }

    /* Commands */
    public RelayCommand SendCommand { get; set; }

    private ContactModel _selectedContact;

    public ContactModel SelectedContact
    {
        get { return _selectedContact; }
        set 
        { 
            _selectedContact = value; 
            OnPropertyChanged();
        }
    }


    private String _mesage;

    public String Message
    {
        get { return _mesage; }
        set 
        { 
            _mesage = value; 
            OnPropertyChanged();
        }
    }


    public MainViewModel()
    {
        Messages = new ObservableCollection<MessageModel>();
        Contacts = new ObservableCollection<ContactModel>();

        SendCommand = new RelayCommand(o =>
        {
            Messages.Add(new MessageModel
            {
                Message = Message,
                FirstMessage = false
            });

            Message = String.Empty;
        });

        Messages.Add(new MessageModel
        {
            Username = "Axel Schweiß",
            UsernameColor = "#409aff",
            ImageSource = "https://i.imgur.com/yMWvLXd.png",
            Message = "Test",
            Time = DateTime.Now,
            IsNativeOrigin = false,
            FirstMessage = true
        });

        for (int i = 0; i < 4; i++)
        {
            Messages.Add(new MessageModel
            {
                Username = "Frank Furt",
                UsernameColor = "#409aff",
                ImageSource = "https://i.imgur.com/yMWvLXd.png",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = false
            });
        }

        for (int i = 0; i < 5; i++)
        {
            Contacts.Add(new ContactModel
            {
                Username = $"Axel Schweiß {i}",
                ImageSource = "https://i.imgur.com/i2szTsp.png",
                Messages = Messages
            });
        }
    }
}
