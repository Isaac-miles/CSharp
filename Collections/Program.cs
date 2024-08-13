namespace Collections;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 2, 4, 6, 9, 11, 12 };

        numbers.Any(x => x > 10);
    }
}

