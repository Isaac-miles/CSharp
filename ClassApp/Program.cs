namespace ClassApp;

class Program
{
    static void Main(string[] args)
    {
        Customer mike = new Customer();
        Console.WriteLine("Enter username");

        mike.Name = Console.ReadLine();

        Console.WriteLine(mike.Name);

        mike.SetCustomerDetails("miles", "miles@gmial", "Isaac");
        Console.WriteLine(mike.Name);

        mike.getCustomerDetails();

        Customer Joy = new Customer("Joy", "iko@gmail.com", "Josiah");
        Joy.getCustomerDetails();
    }
}

