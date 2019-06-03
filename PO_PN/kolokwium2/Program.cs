using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var d = new DateTime(2000, 12, 12);
            Console.WriteLine(d < DateTime.Now);
            Console.ReadKey();*/

            var admin = new Admin(300);
            admin.Clients.Add(new Client("Jan", "Kowalski"));
            admin.Clients.Add(new Client("Marta", "Nowak"));
            admin.Clients.Add(new Client("Ola", "Janik"));

            admin.Add(1, new SiteHosting("Strona abc", "abc.test"));
            admin.Add(2, new SiteHosting("Strona marta", "marta.test"));
            admin.Add(3, new SiteHosting("Strona abc123", "abc123.test"));
            admin.Add(1, "Strona abc", new SQLServer("MsSql", 100, 1, 200, "user123", "pas123"));
            admin.Add(1, "Strona abc", new WebServer("PHP", 20, 1, 100, @"\abc_test\"));
            admin.Add(2, "Strona marta", new WebServer("PHP", 20, 1, 100, @"\marta_test\"));
            admin.Add(3, "Strona abc123", new WebServer("PHP", 20, 1, 100, @"\abc123_test\"));


            admin.Add(2, "Strona marta", new SQLServer("MsSql", 30, 1, 200, "user123", "pas123"));
            admin.Add(2, "Sssstrona marta", new SQLServer("MsSql", 30, 1, 20, "user123", "pas123"));
            admin.Add(2, "Strona marta", new SQLServer("MsSql", 30, 1, 20, "user123", "pas123"));


            admin.Print();
            admin.PrintBill(1);

            Console.ReadKey();

        }
    }
}
