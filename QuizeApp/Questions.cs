using System;
namespace QuizeApp
{
	public class Questions
	{
        public string QuestionText { get; set; }
		public string[] Answers { get; set; }
		public int CorrectAnswerIndex { get; set; }

        public Questions(string questionText, string[] answers, int correctAnswerIndex)
		{
			QuestionText = questionText;
			Answers = answers;
			CorrectAnswerIndex = correctAnswerIndex;
		}

		public bool IsCorrctAnswer(int choice)
		{
			return CorrectAnswerIndex == choice;
		}
	}
}

