using System;

namespace Lab3
{
    public class Magazine : Entry
    {
        public uint IssueNumber { get; set; }

        public Magazine()
        {
            IssueNumber = 0;
        }

        public Magazine(uint id, string title, string publisher, DateTime publicationDate, uint issueNumber)
            : base(id, title, publisher, publicationDate)
        {
            IssueNumber = issueNumber;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Magazine title: {_title} Publisher: {_publisher}\nPublication date: {_publicationDate.ToShortDateString()}" +
                $" Issue: {IssueNumber}");
        }
    }
}
