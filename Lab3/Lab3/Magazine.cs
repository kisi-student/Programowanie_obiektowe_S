using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Magazine : Item
    {
        private int number;

        public int Number { get => number; set => number = value; }

        public Magazine():
            base()
        {
            number = 0;
        }

        public Magazine(string title_, int id_, string publishingHouse_, int releaseYear_, int number_) :
            base(title_, id_, publishingHouse_, releaseYear_)
        {
            number = number_;
        }

        public override string ToString()
        {
            return base.ToString() + $"\r\nMagazine Details | Number: {number}";
        }

        public override void Details()
        {
            Console.WriteLine(this);
            Console.WriteLine("-----------");
            //throw new NotImplementedException();
        }
    }
}
