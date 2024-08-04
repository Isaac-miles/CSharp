using System;
namespace QuizeApp
{
	public class Quize
	{
		private Questions[] questions;

		public Quize(Questions[] questions)
		{
			this.questions = questions;
		}

		public void DisplayQuestion(Questions question)
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("QUESTION ?");
			Console.ResetColor();
			Console.WriteLine(question.QuestionText);
			for (int i = 0; i < question.Answers.Length; i++)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write(" ");
				Console.Write(i + 1);
				Console.ResetColor();
				Console.WriteLine($". {question.Answers[i]}");
			}
		}

		private int GetUserChoice()
		{
			Console.WriteLine("Your answer (number): ");
			string userInput = Console.ReadLine();
			int choice = 0;

			while(!int.TryParse(userInput, out choice) || choice < 1 || choice > 4)
			{
				Console.WriteLine("Invalid choice, please enter a number that states your answer choice within the given options");
			}

			return choice;
		}
	}
}

