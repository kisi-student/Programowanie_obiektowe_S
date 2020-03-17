using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Catalog : IPositionManagment
    {
         public string TopicSection { get; set; }
         public IList<Position> Positions { get; set; }

         public Catalog() { }

         public Catalog(string _topicSection, IList<Position> _positions)
         {
             TopicSection = _topicSection;
             Positions = _positions;
         }

         public void AddPosition(Position _position)
         {
             Positions.Add(_position);
         }

         public override string ToString()
         {
            var str = "CATALOG: \n";
            str += $"Topic sectiont:{TopicSection} \nPositions: \n";
            foreach (var item in Positions)
                str += item + "\n";
            return str;
        }

         public Position FindPositionById(int id)
         {
             foreach (var item in Positions)
             {
                 if (item.Id == id)
                 {
                     return item;
                 }
             }
             return null;
         }

         public Position FindPositionByTitle(string _title)
         {
             foreach (var item in Positions)
             {
                 if (item.Title == _title)
                 {
                     return item;
                 }
             }
             return null;
         }

         public void WriteAllPositions()
         {
             var str = "Catalog positions: \n";
             foreach (var item in Positions)
             {
                 str += item + "\n";
             }
             Console.WriteLine(str);
         } 
    }
}
