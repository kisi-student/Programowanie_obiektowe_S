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
using Lab8Wpf.network;
using Lab8Wpf.db;

namespace Lab8Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MessageWindow : Window
    {
        private List<db.Client> Clients = new List<db.Client>();
        private db.Client SelectedClient { get; set; }
        
        private network.ServerSocket Server;
        public db.ClientInfo Info { get; set; }

        

        public MessageWindow()
        {
            Info = new db.ClientInfo() { Login = "@test", FullName = "TestUser" };

            var client = new db.Client() { FullName = "Pat", Login = "pnnn" };
            client.Messages.Add(new db.Message() { From = client, Text = "Test" });
            Clients.Add(client);


            InitializeComponent();

            lvClients.ItemsSource = Clients;

            Server = new network.ServerSocket();
            Server.Listen();
            Server.ReciveSocket += Server_ReciveClientSockt;
        }

        private void Server_ReciveClientSockt(network.IClientSocket socket)
        {
            socket.ReciveData += Socket_ReciveData;
            socket.SendData(new DataContainer() { type = DataType.ClientInfo, Data = Info });
        }

        private void Socket_ReciveData(network.DataContainer data, network.IClientSocket source)
        {
            var client = Clients.SingleOrDefault(c => c.Socket == source);
            if (client == null)
                Clients.Add(client = new Client() { Socket = source });
            switch (data.type)
            {
                case DataType.ClientInfo:
                    var tmp = (Client)data.Data;
                    client.Login = tmp.Login;
                    client.FullName = tmp.FullName;
                    lvClients.Items.Refresh();
                    break;
                case DataType.Message:
                    client.Messages.Add((Message)data.Data);
                    lvClients.Items.Refresh();
                    lvMessages.Items.Refresh();
                    break;

            }
        }

        private void b_remove_Click(object sender, RoutedEventArgs e)
        {
            /*if(dg.SelectedItem is db.Invoice st)
            {
                using (var db = new db.InvoiceDbContext())
                {
                    db.Invoices.Remove(db.Invoices.Single(i=>i.Id == st.Id));
                    db.SaveChanges();
                    dg.ItemsSource = db.Invoices.ToList();
                }
            }
            dg.Items.Refresh();*/
        }

        private void b_send_Click(object sender, RoutedEventArgs e)
        {
            SelectedClient.Socket.SendData(
                new DataContainer() {
                    type = DataType.Message,
                    Data = new Message() {
                        Date = DateTime.Now,
                        FromLogin = Info.Login,
                        ToLogin = SelectedClient.Login,
                        Text = tbMessageEdit.Text
                    } }
                );
            tbMessageEdit.Text = "";
        }

        private void b_connect_Click(object sender, RoutedEventArgs e)
        {
            var tmp = new ClientSocket(tbHost.Text);
            tmp.SendData(new DataContainer()
            {
                type = DataType.ClientInfo,
                Data = Info
            });
        }

        private void lvClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedClient = e.AddedItems.Count > 0 ? ((db.Client)e.AddedItems[0]) : null;
            lvMessages.ItemsSource = SelectedClient!= null ? SelectedClient.Messages : null;
        }

    }
}
