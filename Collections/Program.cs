namespace Collections;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 2, 4, 6, 9, 11, 12 };

        Console.WriteLine(numbers.Any(x => x > 10));

        Dictionary<int, string> employees = new Dictionary<int, string>();

    }
}

