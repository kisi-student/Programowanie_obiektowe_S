using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab12WPF.network;
using Newtonsoft.Json;

namespace Lab12WPF.model
{ 
    public class User
    {
        public uint Number { get; set; }
        public UserInfo Info { get; set; }
        public ICollection<Message> Messages { get; set; }


        //static uint Num = 0;

        public User() {
        //    Number = ++Num;
            Messages = new List<Message>();
        }        
    }
}
