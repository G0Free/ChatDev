using ChatDev.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ChatDev.Client
{
    public class MainWindowViewModel : ObservableRecipient
    {
        public RestCollection<Message> Messages { get; set; }
        private string messageFromTextBox;
        public string MessageFromTextBox
        {
            get { return messageFromTextBox; }
            set
            {
                if (value != null)
                {
                    messageFromTextBox = value.ToString();
                    OnPropertyChanged();
                    
                }
            }
        }


        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }

        public MainWindowViewModel()
        {
            if (!IsInDesignMode)
            {
                Messages = new RestCollection<Message>("http://localhost:53910/", "actor", "hub");
                CreateMessageCommand = new RelayCommand(() =>
                {
                    Messages.Add(new Message()
                    {
                        SenderName = "Pista",
                        Content = MessageFromTextBox,
                        Date = DateTime.Now
                    }) ; 
                });
            }
        }

        public ICommand CreateMessageCommand { get; set; }

    }
}
