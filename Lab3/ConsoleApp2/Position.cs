using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Position
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationDate { get; set; }
        
        public Position()
        {
            Title = "Unknown";
            Id = 0;
            Publisher = "Unkonwn";
            PublicationDate = new DateTime();
        }

        public Position(string _title, int _id, string _publisher, DateTime _publicationDate)
        {
            Title = _title;
            Id = _id;
            Publisher = _publisher;
            PublicationDate = _publicationDate;
        }


        public override string ToString()
        {
            return $"ID:{Id}, Title:{Title}, Publisher:{Publisher}, Publication Date:{PublicationDate}\n";
        }

        public abstract void WriteInfo();

    }
}
