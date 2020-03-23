using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Catalog : IItemManagement
    {
        private string theme;
        private List<Item> item = new List<Item>();

        public string Theme { get => theme; set => theme = value; }
        internal List<Item> Item { get => item; set => item = value; }

        public Catalog()
        {
            theme = ("--");
        }

        public Catalog(string theme_)
        {
            theme = theme_;
        }

        public void AddItem(Item i)
        {
            item.Add(i);
        }

        public override string ToString()
        {
            return $"Catalog Details | Theme: {theme}";
        }

        public void FindItemByPhrase(string phrase)
        {
           
            foreach (Item i in item)
            {
                if (phrase == i.Title | phrase == i.PublishingHouse)
                {
                    i.Details();
                    
                }
            }
            //Console.WriteLine("\r\n");
        }

        public void FindItemByNumber(int number)
        {
            
            foreach (Item i in item)
            {
                if (number == i.Id | number == i.ReleaseYear)
                {
                    i.Details();
                    
                }
            }
            //Console.WriteLine("\r\n");
        }

        public void ShowAll()
        {
            int j = 1;
            foreach (Item i in item)
            {
                //Console.WriteLine(i); //tak nie robić bo wyświetla to co zwraca To String tylko
                Console.WriteLine("Item nr: " + j);
                j++;
                i.Details();
            }
        }

        public void Details()
        {
            Console.WriteLine(this);
            Console.WriteLine("-----------");
            int j = 1;
            foreach (Item i in item)
            {
                
                //Console.WriteLine(i); //tak nie robić bo wyświetla to co zwraca To String tylko
                Console.WriteLine("Item nr: " + j);
                j++;
                i.Details();
            }
            
            Console.WriteLine("#############");
        }
    }
}
