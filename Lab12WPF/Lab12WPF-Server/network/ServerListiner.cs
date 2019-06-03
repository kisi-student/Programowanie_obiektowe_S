using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Lab12WPF.model;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Serialization;

namespace Lab12WPF.network
{
    public class ServerListiner : IServerListiner
    {
        protected Socket socket;
        public const int Port = 9999;

        public event ReciveSocketHandler ReciveConnection;

        public ServerListiner()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Any, Port));
        }

        public void Listen()
        {
            socket.Listen(30);
            Task.Run(() =>
            {
                try
                {
                    while (socket != null && socket.IsBound)
                        ReciveConnection(new ClientConnection(socket.Accept()));
                }
                catch { }
            });
            
        }

        public void Dispose()
        {
            socket.Close();
            socket = null;
        }


    }
}
