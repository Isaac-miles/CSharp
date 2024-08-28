﻿using System;
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

