using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium
{
    public class WebServer : Service
    {
        public WebServer(string name, float price, int quantit, int trafficLimit, string dirPath):base(name, price, quantit)
        {
            TrafficLimit = trafficLimit;
            DirPath = dirPath;
        }

        public int TrafficLimit { get; set; }
        public string DirPath { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" limit zapytan na minute:{TrafficLimit}  dir:{DirPath}";
        }
    }
}