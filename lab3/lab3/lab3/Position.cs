using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public abstract class Position 
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public string Publisher { get; set; }
        public int PublicationDate { get; set; }

        public Position()
        {
            Title = "unknown";
            Id = 0;
            Publisher = "unknown";
            PublicationDate = 0;
        }
        public Position(string _title, int _id, string _publisher, int _publicationDate)
        {
            Title = _title;
            Id = _id;
            Publisher = _publisher;
            PublicationDate = _publicationDate;
        }
        public override string ToString()
        {
            return $"ID:{Id}\nTitle:{Title}\nPublisher:{Publisher}\nPublication Date:{PublicationDate}\n";
        }
        public abstract void WriteInfo();

        
        
    }
}
