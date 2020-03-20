using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
   public class Catalog :IEntryManagement
    {
        public string Theme { get; set; }
        public List<Entry> _entries = new List<Entry>(); 

        public Catalog()
        {
            Theme = "none";
        }

        public Catalog(string theme)
        {
            Theme = theme;
        }

        public void AddEntry(Entry entry) 
        {
            _entries.Add(entry);
        }

        public Entry FindByTitle(string title)
        {
            foreach (var entry in _entries)
            {
                if(entry.GetTitle() == title)
                {
                    return entry;
                }
            }
            return null;
        }

        public Entry FindById(int id)
        {
            foreach (var entry in _entries)
            {
                if (entry.GetId() == id)
                {
                    return entry;
                }
            }
            return null;
        }

        public void PrintAllEntries()
        {
            foreach (var entry in _entries)
            {
                entry.PrintInfo();
            }
        }
    }
}
