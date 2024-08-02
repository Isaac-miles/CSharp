namespace ClassApp;

class Program
{
    static void Main(string[] args)
    {
        Customer mike = new Customer();
        Console.WriteLine("Enter username");

        mike.Name = Console.ReadLine();

        Console.WriteLine(mike.Name);

        mike.SetDetails("miles", "miles@gmial", "Isaac");
        Console.WriteLine(mike.Name);
        
    }
}

