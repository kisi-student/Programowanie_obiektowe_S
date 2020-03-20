using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Entry
    {
   
        protected uint? _id;
        protected string _title;
        protected string _publishingHouse;
        protected DateTime _year; //typ wartosciowy
        public uint? GetId() { return _id; }
        public string GetTitle() { return _title; }
        public string GetPublisher() { return _publishingHouse; }
        public DateTime GetPublicationDate() { return _year; }

        public Entry() 
        {
            _id = null;
            _title = "none";
            _publishingHouse = "none";
            _year = new DateTime();
        }

        public Entry( uint id,string title, string publishingHoude, DateTime year)
        {
            _id = id;
            _title = title;
            _publishingHouse = publishingHoude;
            _year = year;
        }

        public abstract void PrintInfo();

    }
}
