using System;
namespace InheritanceApp
{
    public delegate void Notify(string message);

    public class EventSubscribe
    {
        public void OnEventRaised(string message)
        {
            Console.WriteLine("Event raised: "+ message);
        }
    }
  

    public class EventsClass
	{
        public event Notify OnNotify;

        public void RaiseEvent(string message)
        {
            OnNotify.Invoke(message);
        }

	}
}

