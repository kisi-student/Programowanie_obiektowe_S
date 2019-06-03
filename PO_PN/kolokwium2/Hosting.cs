using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium
{
    public class SiteHosting
    {
        public SiteHosting(string name, string hostURL)
        {
            Name = name;
            HostURL = hostURL;
            Services = new  List<Service>();
        }

        public string Name { get; set; }
        public string HostURL { get; set; }
        public List<Service> Services { get; set; }

        public override string ToString()
        {
            return $"name:{Name} host:{HostURL}";
        }
    }
}