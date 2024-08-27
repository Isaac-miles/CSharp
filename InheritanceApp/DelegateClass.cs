using System;
namespace InheritanceApp
{

    public delegate int Comparison<T>(T x, T y);

    public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}
	}

    public class SortMan
    {
        public void SortPersons(Person[] persons, Comparison<Person> comperer)
        {
            for (int i = 0; i < persons.Length - 1; i++)
            {
                for (int j = i +1; j < persons.Length; j++)
                {
                    if (comperer(persons[i], persons[j]) > 0)
                    {
                        var temp = persons[i];
                        persons[i] = persons[j];
                        persons[j] = temp;

                    }
                }
            }
        }
    }

    public class DelegateClass
	{
		static void Main(string[] args)
		{
            Person[] persons =
            {
                new Person("Mile",20),
                new Person("Zico", 25),
                new Person("Isaa", 26),
                //new Person {Name ="Joy", Age=19}
            };

            SortMan sortM = new SortMan();
            sortM.SortPersons(persons, CompareByAge);

            foreach(var person in persons)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }
		}

        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        static int CompareByName(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}

