namespace QuizeApp;

class Program
{
    static void Main(string[] args)
    {
        Questions[] questions = new Questions[]
        {
            new Questions(
                "what is bybit ",
                new string[]{"store", "bitcoin","an exchange app"},
                2)
        };

        Quize myQuize = new Quize(questions);
        myQuize.DisplayQuestion(questions[0]);
    }
}

