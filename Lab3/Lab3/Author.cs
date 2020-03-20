using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Author : Person
    {
        //  public string Name { get; set; } sa zbedne
        //   public string Surname { get; set; }

        public string Nationality { get; set; }
  
        public Author()
        {
            Nationality = "none";
        }

        public Author(string name, string surname, string nationality) 
                : base(name, surname)
        {
           Nationality = nationality;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"{Nationality}");
        }
    }
}
