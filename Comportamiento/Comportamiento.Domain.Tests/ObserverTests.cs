using NUnit.Framework;
using Comportamiento.Domain;

namespace Comportamiento.Domain.Tests
{
    public class ObserverTests
    {
        [Test]
        public void Observer_ShouldReceiveUpdatedTemperature()
        {
            var weatherStation = new WeatherStation();
            var display = new TemperatureDisplay();

            weatherStation.RegisterObserver(display);

            weatherStation.SetTemperature(28.5f);

            Assert.AreEqual(28.5f, display.LastTemperature);
        }

        [Test]
        public void RemovedObserver_ShouldNotReceiveUpdates()
        {
            var weatherStation = new WeatherStation();
            var display = new TemperatureDisplay();

            weatherStation.RegisterObserver(display);
            weatherStation.RemoveObserver(display);

            weatherStation.SetTemperature(22.3f);

            Assert.AreEqual(0, display.LastTemperature); // valor por defecto de float
        }
    }
}