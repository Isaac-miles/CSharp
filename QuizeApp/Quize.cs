using System;
namespace QuizeApp
{
	public class Quize
	{
		private Questions[] _questions;
		private int _score = 0;

		public Quize(Questions[] questions)
		{
			this._questions = questions;
		}

		public void StartQuize()
		{
			Console.WriteLine("Welcome to your quize");
			Console.WriteLine();
			int questionNumber = 0; //to display question numbers

			foreach(Questions question in _questions)
			{
				Console.WriteLine($"Question {questionNumber + 1}");
				DisplayQuestion(question);
				int userChoice = GetUserChoice();

				if (question.IsCorrctAnswer(userChoice))
				{
				Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Corrcet!!!");
					Console.ResetColor();
					_score++;

				}
				else
				{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Failed!!!");
                    Console.ResetColor();
					Console.WriteLine($"The correct answer is {question.Answers[question.CorrectAnswerIndex]}");
                }
            }

			DisplayResult();
;		}

		private void DisplayResult()
		{
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Your Result is {_score} out of {_questions.Length}");
            Console.ResetColor();

			double percentage = (double)_score / _questions.Length;
			if(percentage >= 0.8)
			{
                Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"Percentage score is {percentage} Good!!");

			}
			else
			{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Percentage score is {percentage} Poor!!");

            }
            Console.ResetColor();
			
        }

        private void DisplayQuestion(Questions question)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
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

