using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    abstract class Item
    {
        private string title;
        private int id;
        private string publishingHouse;
        private int releaseYear;

        public string Title { get => title; set => title = value; }
        public int Id { get => id; set => id = value; }
        public string PublishingHouse { get => publishingHouse; set => publishingHouse = value; }
        public int ReleaseYear { get => releaseYear; set => releaseYear = value; }

        public Item()
        {
            title = ("--");
            id = 0;
            publishingHouse = ("--");
            releaseYear = 0;
        }

        public Item(string title_, int id_, string publishingHouse_, int releaseYear_)
        {
            title = title_;
            id = id_;
            publishingHouse = publishingHouse_;
            releaseYear = releaseYear_;
        }

        public override string ToString()
        {
            return $"Item Details | Title: {title}, ID: {id}, Publishing House: {publishingHouse}, Release Year: {releaseYear}";
        }

        public abstract void Details();
    }
}
