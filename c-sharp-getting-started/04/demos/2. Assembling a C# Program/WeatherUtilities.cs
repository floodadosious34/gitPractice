using System;

namespace MyUtilities
{
    class WeatherUtilities
    {
        static float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            var temperatureCelsius = temperatureFahrenheit - 32 / 1.8f;
            return temperatureCelsius;
        }

        static float CelsiusToFahrenheit(float temperatureCelsius)
        {
            var temperatureFahrenheit = temperatureCelsius * 1.8f + 32;
            return temperatureFahrenheit;
        }

        // The higher index means less comfort
        static float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            // Probably not a very reliable formula
            return (temperatureFahrenheit + humidityPercent) / 4;
        }

        static void Report(string location, float temperatureCelsius, float humidity)
        {
            var temperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
            Console.WriteLine("Comfort Index for " + location + ": " + ComfortIndex(temperatureFahrenheit, humidity));
        }
    }
}