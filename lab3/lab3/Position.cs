using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    abstract class Position
    {
        protected string title;
        public string Title { get; set; }

        protected int id;
        public int Id { get; set; }

        protected string publisher;
        public string Publisher { get; set; }

        protected int publishYear;
        public int PublishYear { get; set; }

        public Position()
        {
            title = null;
            id = 0;
            publisher = null;
            publishYear = 0;
        }
        public Position(string title, int id, string publisher, int publishYear)
        {
            Title = title;
            Id = id;
            Publisher = publisher;
            PublishYear = publishYear;
        }
        public override string ToString()
        {
            return $"ID: {Id}\tTytul: {Title}, Wydawca: {Publisher}, Rok wydania: {PublishYear}";
        }
        public abstract void Info();
    }
}
