using System;

namespace ConversorTemperatura
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Digite a temperatura em Fahrenheit: ");
            string? entrada = Console.ReadLine();

            if (double.TryParse(entrada, out double fahrenheit))
            {
                double celsius = ConverterParaCelsius(fahrenheit);
                Console.WriteLine($"Temperatura em Celsius: {celsius:F2} °C");
            }
            else
            {
                Console.WriteLine("Temperatura inválida, tente novamente.");
            }
        }

        public static double ConverterParaCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }
    }
}
