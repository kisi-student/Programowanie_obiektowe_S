using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Magazine: Position
    {
        public int No { get; set; }

        public Magazine()
        {
            Title = null;
            Id = 0;
            Publisher = null;
            PublishYear = 0;
            No = 0;
        }
        public Magazine(string title, int id, string publisher, int publishYear, int no)
        {
            Title = title;
            Id = id;
            Publisher = publisher;
            PublishYear = publishYear;
            No = no;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Numer: {No}";
        }
        public override void Info()
        {
            Console.WriteLine(this);
        }
    }
}
