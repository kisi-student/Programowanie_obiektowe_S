using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Net;
using System.Net.Sockets;
using Lab12WPF.network;
using Lab12WPF.model;
using System.Windows.Threading;

namespace Lab12WPF
{
    public delegate void SendMessageHandler(Message message);


    public struct DataContiner
    {
        public Message Message { get; set; }
        public UserInfo Source { get; set; }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MessageWindow : Window
    {
        private UserInfo TargetUser { get; set; }
        private UserInfo ClientUser { get; set; }

        public event SendMessageHandler SendMessage;

        public MessageWindow(UserInfo tagetUser, UserInfo clientUser)
        {
            TargetUser = tagetUser;
            ClientUser = clientUser;

            InitializeComponent();
            DataContext = this;
        }

        public void ReciveMessage(Message message)
        {
            var data = new DataContiner()
            {
                Message = message,
                Source = message.SourceNumber == ClientUser.SourceNumber ? ClientUser : TargetUser
            };
            Dispatcher.Invoke(() =>
            {
                lvMessages.Items.Add(data);
                lvMessages.ScrollIntoView(data);
            });
        }

        private void b_send_Click(object sender, RoutedEventArgs e)
        {
            var data = new Message()
            {
                Date = DateTime.Now,
                Text = tbMessageEdit.Text,
                SourceNumber = ClientUser.SourceNumber,
                TargetNumber = TargetUser.SourceNumber
            };
            SendMessage(data);
            ReciveMessage(data);
            tbMessageEdit.Text = "";
        }
    }
}
