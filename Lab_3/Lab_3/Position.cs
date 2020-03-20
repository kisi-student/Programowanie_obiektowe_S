using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public abstract class Position
    {
        protected string _title;

        protected uint? _id;

        protected string _publisher;

        protected DateTime _publicationYear;

        public Position()
        {
            _title = "none";
            _id = null;
            _publisher = "none";
            _publicationYear = new DateTime();
            
        }

        public Position(string title,uint id,string publisher,DateTime publicationYear)
        {
            if(string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(publisher))
            {
                throw new Exception("Could not create position. Please enter correct inforamtions");
            }
            _title = title;
            _id = id;
            _publisher = publisher;
            _publicationYear = publicationYear;
        }

        public abstract void PrintInfo();
        
        public uint? GetId() { return _id; }
        public string GetTitle() { return _title; }
        public string GetPublisher() { return _publisher; }
        public DateTime GetPublicationYear() { return _publicationYear; }
    }
}
