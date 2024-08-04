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
	}
}

