using Klasser_4_Okt;
using System.ComponentModel;
using static NameList;

internal static class Program
{
    static void Main()
    {
        Person person = new();
        person.FirstName = "Marcus";
        Console.WriteLine(person.FirstName);
        person.LastName = "Cole";
        Console.WriteLine(person.LastName);
        person.Print();

        NameListWTF nameList = new();
        nameList.AddPeople(new Person() { FirstName = "Hallå", LastName = "Okeej"});
        nameList.AddPeople(new Person() { FirstName = "Abc", LastName = "123" });
        nameList.AddPeople(new Person() { FirstName = "Marcus", LastName ="Cole"});
        nameList.AddPeople(new Person() { FirstName = "John", LastName ="Sherridan"});
        nameList.AddPeople(new Person() { FirstName = "Kosh" });
        nameList.AddPeople(new Person() { FirstName = "Londo", LastName ="Molari"});
        nameList.AddPeople(new Person() { FirstName = "Susan", LastName ="Ivanova"});
        nameList.AddPeople(new Person() { FirstName = "Michael", LastName ="Garibaldi"});
        nameList.AddPeople(new Person() { FirstName = "Vir", LastName ="”Cotto"});
        nameList.AddPeople(new Person() { FirstName = "Lennier" });
        nameList.AddPeople(new Person() { FirstName = "Delenn" });
        nameList.SortByLastName();
        nameList.Print();

    }
}
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void Print()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
}

class NameList
{
    public class NameListWTF
    {
        private List<Person> people = new List<Person>();

        public void AddPeople(Person lista)
        {
            people.Add(lista);
        }

        public void AddPeople(string firstName, string lastName)
        {
            people.Add(new Person() { FirstName = firstName, LastName = lastName });
        }

        public void SortByFirstName()
        {
            people = people.OrderBy(p => p.FirstName).ToList();
        }

        public void SortByLastName()
        {
            people = people.OrderBy(p => p.LastName).ToList();
        }

        public void Print()
        {
            foreach (Person person in people)
            {
                person.Print(); // anropar person-klassens egen print metod
            }
        }
    }
}