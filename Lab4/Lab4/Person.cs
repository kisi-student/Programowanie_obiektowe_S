
namespace Lab4
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        static int _id = 101;

        public Person(string firstName, string lastName, int age)
        {
            Id = _id++;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} age:{Age} id: {Id}";
        }
    }
}
