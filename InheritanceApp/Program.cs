using System;
namespace InheritanceApp
{
	public class Program
	{
		 static void Main(string[] args)
		{
			//File.AppendAllText("log.txt", "miles" + "\n");
			//Console.ReadLine();

			StructClass str = new StructClass(2,6);
			str.Display();

			StructClass p1;
			p1.x = 2;
			p1.y = 5;

		}
		
	}
}

