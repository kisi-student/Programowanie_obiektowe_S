using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium
{
    public class ClientOrder
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public List<Service> Services{get; set;}

        public ClientOrder(string Firstname, string Lastname, int Age)
        {
            this.Firstname = Firstname; this.Lastname = Lastname; this.Age = Age;
        }

        public override string ToString() => $"{Firstname} {Lastname} age: {Age} id: {Id}";
    }
}