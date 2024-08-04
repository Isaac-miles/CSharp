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

		public void StartQuize()
		{
			Console.WriteLine("Welcome to you quize");
			int questionNumber = 1; //to display question numbers

			foreach(Questions question in questions)
			{
				Console.WriteLine($"Question {questionNumber + 1}");
				DisplayQuestion(question);
				int userChoice = GetUserChoice();

				if (question.IsCorrctAnswer(userChoice))
				{
				Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Corrcet!!!");
					Console.ResetColor();

				}
				else
				{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Failed!!!");
                    Console.ResetColor();
					Console.WriteLine($"The correct answer is {questions[question.CorrectAnswerIndex]}");
                }
            }
		}

		public void DisplayQuestion(Questions question)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
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
				userInput = Console.ReadLine();
			}

			return choice-1; //adjust based on the indexing answers are displayed
		}
	}
}

