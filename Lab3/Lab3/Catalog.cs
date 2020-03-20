using System;
using System.Collections.Generic;

using Lab3.Interfaces;

namespace Lab3
{
    public class Catalog : IEntryManagement 
    {
        public string SectionTheme { get; set; }
        private List<Entry> _entries = new List<Entry>();

        public Catalog()
        {
            SectionTheme = "none";
        }

        public Catalog(string sectionTheme)
        {
            SectionTheme = sectionTheme;
        }

        public void AddEntry(Entry entry)
        {
            if(entry == null)
            {
                throw new ArgumentNullException(nameof(entry));
            }
            _entries.Add(entry);
        }

        public Entry FindEntryByTitle(string title)
        {
            foreach (var entry in _entries)
            {
                if (entry.GetTitle() == title)
                {
                    return entry;
                }
            }
            return null;
        }

        public Entry FindEntryById(uint id)
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
