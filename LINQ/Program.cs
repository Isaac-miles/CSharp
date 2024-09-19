using System.Globalization;

namespace LINQ;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //OddNumbers(numbers);



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

    class UniversityManager
    {
        public List<Student> Students;
        public List<University> University;

        public UniversityManager()
        {
            var universities = new List<University>();
            var students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "FUL" });
            universities.Add(new University { Id = 2, Name = "UNI" });

            students.Add(new Student { Id = 1, Name = "Mary", Gender = "Female", Age = 20, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Tomi", Gender = "Male", Age = 22, UniversityId = 2});
            students.Add(new Student { Id = 3, Name = "Dave", Gender = "Male", Age = 21, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Austin", Gender = "Male", Age = 24, UniversityId = 1 });
            students.Add(new Student { Id = 5, Name = "Kay", Gender = "Female", Age = 23, UniversityId = 2 });


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
            Console.WriteLine("Student {0} with Id {1}, Gender {2} and Age {3} from Univerity with the Id {4} ",
                Name, Id,Gender,Age, UniversityId);

        }
    }
}

