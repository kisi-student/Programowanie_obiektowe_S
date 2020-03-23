using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Library : IItemManagement, ILibrariansManagement
    {
        private string adres;
        private List<Catalog> catalogs = new List<Catalog>();
        private List<Librarian> librarians = new List<Librarian>();

        public string Adres { get => adres; set => adres = value; }

        public Library()
        {
            adres = ("--");
        }

        public Library(string adres_)
        {
            adres = adres_;
        }

        public void AddLibrarian(Librarian l)
        {
            librarians.Add(l);
        }

        public void ShowLibrarians()
        {
            Console.WriteLine("Bibliotekarze biblioteki przy " + adres);
            foreach (Librarian l in librarians)
            {
                l.Details();
            }
            Console.WriteLine("-----------");
        }
        
        public void AddCatalog(Catalog c)
        {
            catalogs.Add(c);
        }

        public void AddItem(Item i, string theme_)
        {
            foreach (Catalog c in catalogs)
            {
                if (c.Theme == theme_)
                {
                    c.AddItem(i);
                }
            }
        }

        public void FindItemByPhrase(string phrase)
        {
            Console.WriteLine("Wyniki wyszukiwania frazy " + phrase);
            foreach (Catalog c in catalogs)
            {
                c.FindItemByPhrase(phrase);
            }
            Console.WriteLine("\r\n");
        }

        public void FindItemByNumber(int number)
        {
            Console.WriteLine("Wyniki wyszukiwania numeru " + number);
            foreach (Catalog c in catalogs)
            {
                c.FindItemByNumber(number);
            }
            Console.WriteLine("\r\n");
        }

        public void ShowAll()
        {   
            int k = 1;
            foreach (Catalog c in catalogs)
            {
                
                Console.WriteLine("\tCatalog nr: " + k);
                int j = 1;
                
                foreach (Item i in c.Item)
                {   
                    Console.WriteLine("Item nr: " + j);
                    i.Details();
                    j++;
                }
                Console.WriteLine("\r\n");
                k++;
            }
        }

        public void ShowAllLibrarians()
        {
            Console.WriteLine("\tBibliotekarze");
            int j = 1;
            foreach (Librarian l in librarians)
            {
                Console.WriteLine("Librarian nr: " + j);
                l.Details();
                j++;
            }
            Console.WriteLine("\r\n");
        }

        public void FindLibrarian(string s)
        {
            Console.WriteLine("Wyniki wyszukiwania bibliotekarza " + s);
            foreach (Librarian l in librarians)
            {
                if (l.Name == s | l.Surname == s)
                {
                    l.Details();
                }
            }
            Console.WriteLine("\r\n");
        }

        public override string ToString()
        {
            return $"Library Details | Adres: {adres}";
        }

        public void Details()
        {
            Console.WriteLine(this);
            Console.WriteLine("###  BIBLIOTEKARZE  ###");
            foreach (Librarian l in librarians)
            {
                l.Details();
            }
            Console.WriteLine("###  KATALOGI  ###");
            foreach (Catalog c in catalogs)
            {
                c.Details();
            }
        }

    }    
}
