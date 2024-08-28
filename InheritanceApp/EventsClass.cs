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

    class EventPublisher
    {
        public event Notify OnNotify;

        public void RaiseEvent(string message)
        {
            OnNotify.Invoke(message);
        }
    }

    public class EventsClass
	{
        static void Main(string[] args)
        {
            EventPublisher publiser = new EventPublisher();
            EventSubscribe subscribe = new EventSubscribe();
        }
    }

}

