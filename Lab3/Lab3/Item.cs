using System;

namespace Lab3
{
    /// <summary>
    ///  Pozycja
    /// </summary>
    public abstract class Item
    {
        public string Title { get; protected set; }
        public int Id { get; protected set; }
        public string Publisher { get; protected set; }
        public DateTime DateOfIssue { get; protected set; }

        public Item()
        {
            Title = "NONE";
            Id = 0;
            Publisher = "NONE";
            DateOfIssue = default(DateTime);
        }

        public Item(string title, int id, string publisher, DateTime dateOfIssue)
        {
            Title = title;
            Id = id;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;
        }

        public override string ToString()
        {
            return $"ITEM : || ID: {Id}, Title {Title}, Publisher {Publisher}, Date of Issue: {DateOfIssue}";
        }

        public virtual void MoreDetails()
        {
            Console.Write("sdsds");

            // instuctions
        }

        public abstract void Details();
    }
}
