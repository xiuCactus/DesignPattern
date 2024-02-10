using System;
using System.Collections.Generic;

namespace observer
{
    public class WeatherData : ISubject
    {
        private float temperature;
        private float humidity; 
        private List<IObserver> observers;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer); 
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer); 
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers) 
            {
                observer.Update(temperature, humidity); 
            }
        }
        public void SetMeasurements(float temperature, float humidity)
        {
            Console.WriteLine("New weather information is available");
            this.temperature = temperature;
            this.humidity = humidity; 
            NotifyObservers();
        }
    }
}