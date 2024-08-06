namespace QuizeApp;

class Program
{
    static void Main(string[] args)
    {
        Questions[] questions = new Questions[]
        {
            new Questions(
                "what is BYBIT ",
                new string[]{"store", "bitcoin","an exchange app"},
                2),
            new Questions(
                "what is PEPE ",
                new string[]{"Investor", "Meme  Coin","an exchange app"},
                1)
        };

        Quize myQuize = new Quize(questions);
        //myQuize.DisplayQuestion(questions[0]);
        myQuize.StartQuize();
    }
}

