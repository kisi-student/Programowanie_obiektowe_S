using System;

namespace Lab3
{
    public abstract class Entry
    {
        protected uint? _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _publicationDate;

        public Entry()
        {
            _id = null;
            _title = "none";
            _publisher = "none";
            _publicationDate = new DateTime();
        }

        public Entry(uint id, string title, string publisher, DateTime publicationDate)
        {
            if(string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(publisher))
            {
                throw new Exception("Could not instantiate Entry object. Ivalid contruction params.");
            }

            _id = id;
            _title = title;
            _publisher = publisher;
            _publicationDate = publicationDate;
        }

        public abstract void PrintInfo();

        public uint? GetId() { return _id; }
        public string GetTitle() { return _title; }
        public string GetPublisher() { return _publisher; }
        public DateTime GetPublicationDate() { return _publicationDate; }
    }
}
