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

        Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

        employees.Add(0, new Employee("Miles", 25, 20000));

        employees.Add(1, new Employee("Isaac", 26, 2000000));

        foreach(var employee in employees)
        {
            Console.WriteLine("emID: {0} emName: {1} earns {2} ",employee.Key,employee.Value.Name, employee.Value.Salary);
        }

        Dictionary<string, string> mysM = new Dictionary<string, string>()
        {
            ["NA"] = "ZIco",
            //{ "Davis", "Isaac" },

        };

        foreach(var d in mysM)
        {
            Console.WriteLine(d.Value);
        };

        if(mysM.TryGetValue("NA", out string value))
            {
            Console.WriteLine(value);
        }
    }
}

