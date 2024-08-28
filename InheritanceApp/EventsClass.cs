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
    public delegate void TemperatureChangeDelegate(string message); //remodified below to use eventHandler

    public class TemperatureChangeEventArgs : EventArgs
    {
        public int Temperature { get; }
        public TemperatureChangeEventArgs(int temp)
        {
            Temperature = temp;
        }
    }


    public class TemMonitor
    {
        //public event TemperatureChangeDelegate OnTemperatureMonitoreEvent;

        public event EventHandler<TemperatureChangeEventArgs> OnTemperatureMonitoreEvent;

        private int _temp;
        public int Temperature { get => _temp;

            set
            {
                if(_temp != value)
                {
                    _temp = value;
                    //Raise an alerm event

                    RaiseTemperatureAlarmEvent(new TemperatureChangeEventArgs(_temp));
                }
            }
        }

        //the alerm event
        protected void RaiseTemperatureAlarmEvent(TemperatureChangeEventArgs e)
        {
            OnTemperatureMonitoreEvent?.Invoke(this,e);
        }

    }

    //subscribers to our temp monitor
    public class TemperatureAlert
    {
        public void OnTemperatureChange(object sender, TemperatureChangeEventArgs e)
        {
            Console.WriteLine($"Alert: the temperature is {+e.Temperature} and sender is {sender} ");
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

            //multiDelegate or initiate subscriptions
            monitorTemperature.OnTemperatureMonitoreEvent += alertTemperture.OnTemperatureChange;

            monitorTemperature.Temperature = 20;
            Console.WriteLine("Enter your room temperature");
            monitorTemperature.Temperature = int.Parse(Console.ReadLine());
        }
    }

}

