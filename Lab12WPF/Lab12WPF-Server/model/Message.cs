using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab12WPF.model
{
    [Serializable]
    //[DataContract]
    public class Message : Packet
    {
        public uint TargetNumber { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
