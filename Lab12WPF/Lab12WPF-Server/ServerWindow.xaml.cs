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
using Lab12WPF.db;

namespace Lab12WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ServerWindow : Window
    {
        private UserRepository Repo = new UserRepository();
        private ServerListiner Server;
        
        public ServerWindow()
        {
            InitializeComponent();
            try
            {
                Server = new ServerListiner();
                Server.ReciveConnection += Server_ReciveConnection;
                Server.Listen();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Server_ReciveConnection(IClientConnection connection)
        {
            connection.Disconnect += Connection_Disconnect;
            connection.ReciveData += Connection_ReciveData;
        }

        private void Connection_Disconnect(IClientConnection connection)
        {
            var user = Repo.Get(connection);
            Repo.Remove(connection);
            Dispatcher.Invoke(() => lvUsers.Items.Remove(user));
        }

        private void Connection_ReciveData(Packet data, IClientConnection source)
        {
            var user = Repo.Get(source);
            if (user == null)
            {
                user = Repo.Insert(source);
                // db
                user.Number = data.SourceNumber;
                Dispatcher.Invoke(() => lvUsers.Items.Add(user));
            }
            data.SourceNumber = user.Number;

            // log
            Dispatcher.Invoke(() =>
            {
                lvMessages.Items.Add(Newtonsoft.Json.JsonConvert.SerializeObject(data));
                if (lvMessages.Items.Count > 10)
                    lvMessages.Items.RemoveAt(0);
            });

            // dane usera
            if (data is UserInfo info)
            {
                user.Info = info;
                //user.Number = info.SourceNumber;
                Dispatcher.Invoke(() => lvUsers.Items.Refresh());
            }
            else if (data is Message message)
            {
                var target = Repo.Get(message.TargetNumber);
                if (target != null) // send
                    target.Connection.SendData(message);
                else // add to db
                { }                
            }

            if (data is Find f)
            {
                var r = Repo.Get(f.TargetNumber);
                if(r != null)
                    user.Connection.SendData(r.Info);
            }
        }
    }
}
