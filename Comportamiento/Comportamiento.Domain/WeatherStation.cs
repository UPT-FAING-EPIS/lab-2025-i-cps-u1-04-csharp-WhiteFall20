using System.Collections.Generic;

namespace Comportamiento.Domain
{
    public class WeatherStation : ISubject
    {
        private readonly List<IObserver> _observers = new();
        private float _temperature;

        public void SetTemperature(float temperature)
        {
            _temperature = temperature;
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }
    }
}