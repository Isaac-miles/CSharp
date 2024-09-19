using System.Globalization;

namespace LINQ;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        OddNumbers(numbers);

    }

    static void OddNumbers(int[] numbers)
    {
        IEnumerable<int> oddnumbers = from number in numbers
                                      where number % 2 != 0
                                      select number;

        Console.WriteLine($"The, Odd Numbers are! {oddnumbers}");
        foreach(int i in oddnumbers)
        {
            Console.WriteLine($"Odd {i}");

        }
    }

    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with Id {1} ", Name, Id);

        }
    }


    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //Foreign Key
        public int UniversityId { get; set; }
        public void Print()
        {
            Console.WriteLine("University {0} with Id {1} ", Name, Id);

        }
    }
}

