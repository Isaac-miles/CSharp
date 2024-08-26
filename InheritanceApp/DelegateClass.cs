using System;
namespace InheritanceApp
{
	public class DelegateClass
	{
		public delegate string Notify(string message);

		public DelegateClass()
		{
			//instantiation
			Notify notifyDelegate = ShowMessage;

			//invocation
			notifyDelegate("Hello Delegating thr task");

		}

		static string ShowMessage(string message)
		{
			Console.WriteLine(message);
			return message;
		}
	}
}

