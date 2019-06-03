using Lab12WPF.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12WPF.network
{
    public delegate void ReciveDataHandler(Packet data, IClientConnection source);
    public delegate void DisconnectHandler(IClientConnection source);

    public interface IClientConnection : IDisposable
    {
        void SendData<T>(T data) where T:Packet;
        event ReciveDataHandler ReciveData;
        event DisconnectHandler Disconnect;
    }
}
