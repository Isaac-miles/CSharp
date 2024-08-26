using System;
namespace InheritanceApp
{
	public class DelegateClass
	{
		public delegate void Notify(string message);

		public DelegateClass()
		{
			//instantiation
			Notify notifyDelegate = ShowMessage;

			//invocation


		}

		static void ShowMessage(string message)
		{
			Console.WriteLine(message);
		}
	}
}

