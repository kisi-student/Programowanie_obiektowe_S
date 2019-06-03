using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab12WPF.model
{
    [Serializable]
    //[DataContract]
    public abstract class Packet
    {
        [DataMember]
        public uint SourceNumber { get; set; }
    }
}
