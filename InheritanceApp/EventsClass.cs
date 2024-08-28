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
                    RaiseTemperatureAlarmEvent("Turn on the Heater Temp is above room temperature");
                }
            }
        }

        //the alerm event
        protected void RaiseTemperatureAlarmEvent(string message)
        {
            TemperatureMonitoreEvent.Invoke(message);
        }

    }

    //subscribers to our temp monitor
    public class TemperatureAlert
    {
        public void OnTemperatureChange(string message)
        {
            Console.WriteLine("Alert: "+ message);
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

            //temp monitor example
            TemMonitor monitorTemperature = new TemMonitor();
            TemperatureAlert alertTemperture = new TemperatureAlert();
        }
    }

}

