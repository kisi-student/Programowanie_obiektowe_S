using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
	class Program
	{


		static void Main(string[] args)
		{
			Person p1 = new Person("Adam", "Smith", 53);
			Person p2 = new Person("Milton", "Friedman", 7);
			Person p3 = new Person("Fryderyk", "Bastiat", 18);
			Person p4 = new Person("Ludwig", "von Mises", 10);
			MyList<Person> myList = new MyList<Person>();
			myList.Insert(0,p1);
			myList.Add(p2);
			myList.Insert(2,p3);
			myList.Insert(1, p4);
			Console.WriteLine("Test 1:");
			Console.WriteLine(String.Join("\r\n", myList));
			Console.WriteLine("Test 2:");
			Console.WriteLine(String.Join("\r\n",myList.Where(e => e.Age >= 18).ToList()));
			myList.Remove(p1);
			myList.RemoveAt(0);
			Console.WriteLine("Test 3:");
			Console.WriteLine(String.Join("\r\n", myList));

			IEnumerable<Person> myDuplexList = new MyDuplexList<Person>();
			((MyDuplexList<Person>)	myDuplexList).Insert(0, p1);
			((MyDuplexList<Person>)	myDuplexList).Add(p2);
			((MyDuplexList<Person>)	myDuplexList).Insert(2, p3);
			((MyDuplexList<Person>)	myDuplexList).Insert(1, p4);
			Console.WriteLine("Test 4:");
			foreach(Person p in myDuplexList)//integracja z petla foreach
				Console.WriteLine(p);
			Console.WriteLine("Test 5- od tylu:");

			MyDuplexBackwardList<Person> bw = new MyDuplexBackwardList<Person>();
			foreach (Person p in myDuplexList)//integracja z foreach
				bw.Add(p);
			foreach (Person p in bw)//integracja z petla foreach, iteracja od tylu listy myDuplexList
				Console.WriteLine(p);
			Console.WriteLine("Test 6:");
			Console.WriteLine(String.Join("\r\n", myDuplexList.Where(e => e.Age >= 18).ToList()));
			((MyDuplexList<Person>) myDuplexList).Remove(p1);
			((MyDuplexList<Person>) myDuplexList).RemoveAt(0);
			Console.WriteLine("Test 7:");
			Console.WriteLine(String.Join("\r\n", myDuplexList));

			Console.WriteLine("\r\nPraca domowa:");
			MyTree<Person> myTree = new MyTree<Person>();
			Person p5 = new Person("Hans-Hermann", "Hoppe", 71);
			
			TreeNode<Person> boss = new TreeNode<Person>();
			boss.Value = p1;//Adam Smith is the boss
			boss.AddChild(p2);//Friedman worker
			boss.AddChild(p3);//Bastiat worker
			boss.AddChild(p4).AddChild(p5);//Mises worker and Hoppe subworker
			myTree.Root = boss;

			List<Person> company = myTree.ToList();
			foreach (Person p in company)
				Console.WriteLine(p);

			Console.ReadKey();
		}

	}
}
