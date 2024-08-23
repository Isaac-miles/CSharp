using System;
namespace InheritanceApp
{
	public class Program
	{
		 static void Main(string[] args)
		{
			File.AppendAllText("log.txt", "miles" + "\n");
			Console.ReadLine();
		}
		
	}
}

