namespace Comportamiento.Domain
{
    public class TemperatureDisplay : IObserver
    {
        public float LastTemperature { get; private set; }

        public void Update(float temperature)
        {
            LastTemperature = temperature;
            Console.WriteLine($"Pantalla actualizada: Temperatura actual es {temperature}°C");
        }
    }
}