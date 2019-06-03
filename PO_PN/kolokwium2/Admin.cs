using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium
{
    public class Admin
    {
        public Admin(int sizeLimit)
        {
            LimitLeft = GlobalSizeLimit = sizeLimit;
            Clients = new List<Client>();
        }

        public int GlobalSizeLimit { get; set; }
        public List<Client> Clients { get; set; }

        protected int LimitLeft { get; set; }

        public void Print()
        {
            Clients.ForEach(c =>
            {
                Console.WriteLine("\n" + c);
                c.Sites.ForEach(s =>
                {
                    Console.WriteLine($"\t{s}");
                    s.Services.ForEach(ser => Console.WriteLine($"\t\t{ser}"));
                });
            });
        }

        public void PrintBill(int id)
        {
            try
            {
                var client = Clients.Single(c => c.Id == id);
                Console.WriteLine("\n" + client);
                client.BillPrint();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nie ma takiego zasobu!");
            }

        }


        public void Add(int id, string siteName, Service service)
        {
            if (service is SQLServer)
            {
                if (((SQLServer)service).SizeLimit > LimitLeft)
                {
                    Console.WriteLine($"Brak miejsca! zostało:{LimitLeft}");
                    return;
                }
                LimitLeft -= ((SQLServer)service).SizeLimit;
            }

            try
            {
                Clients.Single(c => c.Id == id)
                    .Sites.Single(s => s.Name == siteName)
                    .Services.Add(service);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nie ma takiego zasobu!");
            }
        }

        public void Add(int id, SiteHosting hosting)
        {
            try
            {
                Clients.Single(c => c.Id == id)
                .Sites.Add(hosting);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nie ma takiego zasobu!");
            }
        }
    }
}