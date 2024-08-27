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

		


		static string ShowMessage(string message)
		{
			Console.WriteLine(message);
			return message;
		}
	}
}

