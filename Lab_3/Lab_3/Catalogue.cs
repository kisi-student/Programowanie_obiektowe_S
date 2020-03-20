using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class Catalogue : IPositionManagement
    {
        public string SectionTheme { get; set; }

        private List<Position> _positions = new List<Position>();

        public Catalogue()
        {
            SectionTheme = "none";
        }

        public Catalogue(string sectionTheme)
        {
            SectionTheme = sectionTheme;
        }

        public void AddPosition(Position position)
        {
            if(position == null)
            {
                throw new Exception("Could not add null elemnet to List");
            }
            _positions.Add(position);
        }

        public Position FindPositionByTitle(string title)
        {
            foreach(var position in _positions)
            {
                if (position.GetTitle() == title)
                {
                    return position;
                }

            }
            return null;
        }

        public Position FindPositionById(uint id)
        {
            foreach (var position in _positions)
            {
                if (position.GetId() == id)
                {
                    return position;
                }
            }
            return null;
        }

        public void PrintAllPositions()
        {
            foreach (var position in _positions)
            {
                position.PrintInfo();
            }
        }
    }
}
