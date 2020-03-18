using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
     class Catalog
    {
        public string ThematicDepartment { get; set; }
        public IList<Position> position = new List<Position>();
        public Catalog()
        { }    
        
        public Catalog(string _thematicDepartment, IList<Position> _position)
        {
            ThematicDepartment = _thematicDepartment;
            position = _position;
            
        }
        public Position FindPositionByTitle(string title)
        {
            for (int i = 0; i < position.Count; i++)
            {
                Position p = position[i];
                if (title == p.Title)
                    return p;
            }
            return null;
        }
        public Position FindPositionById(int id)
        {
                    
            for(int i=0; i<position.Count;i++)
            {
                Position p = position[i];
                if (id == p.Id)
                    return p;
            }
            return null;
            }
        public Position FindPositionByPublishing(string publishing)
        {
            for(int i=0; i<position.Count; i++)
            {
                Position p = position[i];
                if (publishing == p.Publishing)
                    return p;
            }
            return null;
        }
        public Position FindPositionByPublicationDate(int publicationDate)
        {
            for (int i = 0; i < position.Count; i++)
            {
                Position p = position[i];
                if (publicationDate == p.PublicationDate)
                    return p;
            }
            return null;
        }
        public void WriteAllPositions()
        {
            string str = "Catalog positions: \n";
            for (int i=0; i<position.Count; i++)
            {
                Position p = position[i];
                str += p.Publishing + " " + p.Title + "\n";
            }
            Console.WriteLine(str);
        }

        public void AddPosition(Position _position)
        {
            position.Add(_position);
        }
    }
}
