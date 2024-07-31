using CSharp01;

namespace Fundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
            Seasons seasons = Seasons.Rainy;
            Arrays.Run();

            switch (seasons)
            {
                case Seasons.Rainy:
                    Console.WriteLine("Its Raining Season already");
                    break;
                case Seasons.Hamattan:
                    Console.WriteLine("Na Hamatan Jare");
                    break;
                default:
                    Console.WriteLine("No Match found try again.");
                    break;
            }
        }
    }
}