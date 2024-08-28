using System;
namespace InheritanceApp
{
    public delegate void Notify(string message);

    class EventPublisher
    {
        public event Notify OnNotify;

        public void RaiseEvent(string message)
        {
            OnNotify?.Invoke(message);
        }
    }

    public class EventSubscribe
    {
        public void OnEventRaised(string message)
        {
            Console.WriteLine("Event raised: "+ message);
        }
    }

    //TemMonitor
    public delegate void TemperatureChangeDelegate(string message);

    public class TemMonitor
    {
        public event TemperatureChangeDelegate TemperatureMonitoreEvent;

        private int _temp;
        public int Temperature { get => _temp;

            set
            {
                _temp = value;
                if(_temp > 30)
                {
                    //Raise an alerm event
                }
            }
        }

        //the alerm event
        protected void RaiseTemperatureAlarmEvent(string message)
        {
            TemperatureMonitoreEvent.Invoke(message);
        }

    }



    public class EventsClass
	{
        static void Main(string[] args)
        {
            EventPublisher publiser = new EventPublisher();
            EventSubscribe subscriber = new EventSubscribe();
            publiser.OnNotify += subscriber.OnEventRaised;

            publiser.RaiseEvent("Test");
        }
    }

}

