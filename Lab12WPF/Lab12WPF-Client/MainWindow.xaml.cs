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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<uint, User> Users = new Dictionary<uint, User>();
        private Dictionary<uint, MessageWindow> TargetWindows = new Dictionary<uint, MessageWindow>();

        public ClientConnection Connection { get; set; }
        public UserInfo ClientInfo { get; set; }


        public MainWindow()
        {
            ClientInfo = new UserInfo() { SourceNumber = 431123, FullName = "Jan Kowalski" };

            InitializeComponent();

            DataContext = this;
            //lvUsers.ItemsSource = Users;
        }


        private void Connection_Disconnect(IClientConnection socket)
        {
            if (Connection != socket)
                return;
            Dispatcher.Invoke(() =>
            {
                MessageBox.Show("User disconnet");
                Connection = null;
                tbStatus.Text = "Offline";
            });
        }


        private void Connection_ReciveData(Packet data, IClientConnection source)
        {
            if (Connection != source)
                return;
            if (!Users.TryGetValue(data.SourceNumber, out User user))
            {
                user = new User() { Number = data.SourceNumber, Info = new UserInfo() { SourceNumber = data.SourceNumber } };
                Users.Add(data.SourceNumber, user);
                Dispatcher.Invoke(() => lvUsers.Items.Add(user));
            }

            if (data is UserInfo info)
            {
                user.Info = info;
                //Dispatcher.Invoke(() => lvUsers.Items.Add(user));
            }
            if (data is Message message)
            {
                Dispatcher.Invoke(() => ShowWindow(user).ReciveMessage(message));
            }
            Dispatcher.Invoke(() => lvUsers.Items.Refresh());
        }


        private void b_connect_Click(object sender, RoutedEventArgs e)
        {
            if (Connection != null)
                Connection.Dispose();

            //try
            {
                Connection = new ClientConnection(tbHost.Text);
                Connection.ReciveData += Connection_ReciveData;
                Connection.Disconnect += Connection_Disconnect;
                Connection.SendData(ClientInfo);
                tbStatus.Text = "Online";
            }
            //catch (Exception ex)
            {
                //    MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void lvClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
                ShowWindow((User)e.AddedItems[0]);
        }

        private MessageWindow ShowWindow(User user)
        {
            MessageWindow window;
            if (TargetWindows.TryGetValue(user.Number, out window))
            {
                window.Activate();
            }
            else
            {
                window = new MessageWindow(user.Info, ClientInfo);
                TargetWindows[user.Number] = window;
                window.SendMessage += Window_SendMessage;
                window.Show();
            }
            return window;
        }

        private void Window_SendMessage(Message message)
        {            
            Connection?.SendData(message);
        }

        private void b_add_user_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Connection?.SendData(new Find(){
                    SourceNumber = ClientInfo.SourceNumber,
                    TargetNumber = uint.Parse(tbUserLogin.Text)
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
