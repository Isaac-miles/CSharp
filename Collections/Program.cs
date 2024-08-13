namespace Collections;
class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }

    public Employee(string name, int age, int salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 2, 4, 6, 9, 11, 12 };

        Console.WriteLine(numbers.Any(x => x > 10));

        Dictionary<int, string> employees = new Dictionary<int, string>();
        employees.Add(2, "miles");
        employees.Add(0, "doe");

        foreach(KeyValuePair<int, string> employee in employees)
        {
            Console.WriteLine("emID: {0} emName: {1} ",employee.Key,employee.Value);
        }

    }
}

