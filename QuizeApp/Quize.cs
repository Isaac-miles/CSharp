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
		}
	}
}

