using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium
{
    public class SQLServer : Service
    {
        public SQLServer(string name, float price, int quantit, int sizeLimit, string user, string password) : base(name, price, quantit)
        {
            SizeLimit = sizeLimit;
            User = user;
            Password = password;
        }

        public int SizeLimit { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" limit:{SizeLimit}MB user:'{User}' pass:'{Password}'";
        }
    }
}