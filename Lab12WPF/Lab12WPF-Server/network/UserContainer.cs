using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab12WPF.model;
using Lab12WPF.network;
using Newtonsoft.Json;

namespace Lab12WPF.network
{ 
    public class UserContainer : User
    {
        public IClientConnection Connection { get; set; }      
    }
}
