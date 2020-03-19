using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Library: IPositionManagament, ILibrarianManagement
    {
        public string Address { get; set; }
        private List<Librarian> Librarians = new List<Librarian>();
        private List<Catalogue> Catalogues = new List<Catalogue>();

        public Library()
        {
            Address = null;
        }
        public Library(string address)
        {
            Address = address;
        }

        public void AddLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }
        public void LibrariansInfo()
        {
            foreach(Librarian element in Librarians)
            {
                element.Info();
            }
        }

        public void AddCatalogue(Catalogue catalogue)
        {
            Catalogues.Add(catalogue);
        }
        public void AddPosition(Position position, string section)
        {
            foreach(Catalogue element in Catalogues)
            {
                if (element.Section == section)
                    element.AddPosition(position);
            }
        }

        public Position FindPositionById(int id)
        {
            foreach(Catalogue catalogue in Catalogues)
            {
                foreach (Position position in catalogue.Positions)
                {
                    if (position.Id == id)
                        return position;
                }
            }
            return null;
        }
        public Position FindPositionByTitle(string title)
        {
            foreach(Catalogue catalogue in Catalogues)
            {
                foreach (Position position in catalogue.Positions)
                {
                    if (position.Title == title)
                        return position;
                }
            }
            return null;
        }
        public Position FindPositionByPublisher(string publisher)
        {
            foreach(Catalogue catalogue in Catalogues)
            {
                foreach (Position position in catalogue.Positions)
                {
                    if (position.Publisher == publisher)
                        return position;
                }
            }
            return null;
        }
        public Position FindPositionByPublishYear(int publishYear)
        {
            foreach(Catalogue catalogue in Catalogues)
            {
                foreach (Position position in catalogue.Positions)
                {
                    if (position.PublishYear == publishYear)
                        return position;
                }
            }
            return null;
        }

        public void InfoAll()
        {
            foreach (Catalogue element in Catalogues)
                element.InfoAll();
        }
    }
}
