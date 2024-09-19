namespace LINQ;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


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

}

