namespace InheritanceApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    class Animal<T>
    {
        protected virtual void Run(string a) { } 
        public string Eat()
        {
            return "Eating";
        }
    }

    class Dog : Animal<String>
    {
        public string Bark()
        {
            Console.WriteLine("barking");
           return  this.Eat();
        }

        protected override void Run(string a) { }
    }
}

