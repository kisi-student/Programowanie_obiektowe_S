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
    public class Find : Packet
    {
        [DataMember]
        public uint TargetNumber { get; set; }
    }
}
