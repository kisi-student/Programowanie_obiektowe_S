using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class HandBaller: Player
    {
        public HandBaller(string name,string surname, DateTime birthday,string position,string club):
            base(name,surname,birthday,position,club)
        {

        }

        public override void Shoot()
        {
            base.Shoot();
            Console.WriteLine("Handballer shoot a goal !!!");
        }

    }
}
