using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab12WPF.model
{
    [Serializable]
    //[DataContract]
    public class UserInfo : Packet
    {

        public enum StatusType
        {
            OnLine,
            Hide,
            OffLine
        }

        [DataMember]
        public StatusType Status { get; set; }
        [DataMember]
        public string FullName { get; set; }
    }
}
