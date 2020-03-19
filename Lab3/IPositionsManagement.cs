using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	interface IPositionsManagement
	{
		Position FindPositionById(int id);
		Position FindPositionByTitle(string title);

		Position FindPositionByPublisher(string publisher);

		Position FindPositionByPublicationDate(int publicationDate);

		void PositionsDetails();

	}
}
