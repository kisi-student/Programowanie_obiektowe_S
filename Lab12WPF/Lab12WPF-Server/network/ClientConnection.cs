using Lab12WPF.model;
using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;


namespace Lab12WPF.network
{
    public class ClientConnection : IClientConnection
    {
        protected Socket socket;
        protected NetworkStream stream;
        protected BinaryFormatter formater;

        public event ReciveDataHandler ReciveData;
        public event DisconnectHandler Disconnect;

        public ClientConnection(String host)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(host, ServerListiner.Port);
            Init();
        }

        public ClientConnection(Socket socket)
        {
            this.socket = socket;
            Init();
        }

        public void Init()
        {
            stream = new NetworkStream(socket, true);
            formater = new BinaryFormatter();

            Task.Run(() =>
            {
                try
                {
                    while (socket.Connected)
                    {
                        var res = (Packet)formater.Deserialize(stream);
                        ReciveData(res,this);
                    }
                }
                catch (Exception ex) {
                    Debug.WriteLine(ex);
                }
                Disconnect(this);
            });
        }

        public void SendData<T>(T data) where T:Packet
        {
            try
            {
                formater.Serialize(stream, data);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                Disconnect(this);
            }
        }

        public void Dispose()
        {
            stream.Flush();
            stream.Close();
        }

    }
}
