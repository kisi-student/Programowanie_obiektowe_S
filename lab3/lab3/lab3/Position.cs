using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    abstract class Position 
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public string Publishing { get; set; }
        public int PublicationDate { get; set; }

        public Position()
        { }
        public Position(string _title, int _id, string _publishing, int _publicationDate)
        {
            Title = _title;
            Id = _id;
            Publishing = _publishing;
            PublicationDate = _publicationDate;
        }
        public abstract void WriteInfo();
        
    }
}
