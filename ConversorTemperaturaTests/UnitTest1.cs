using Xunit;
using ConversorTemperatura;

namespace ConversorTemperaturaTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(32, 0)]
        [InlineData(212, 100)]
        [InlineData(98.6, 37)]
        public void TesteConversaoParaCelsius(double fahrenheit, double esperado)
        {
            double resultado = Program.ConverterParaCelsius(fahrenheit);
            Assert.Equal(esperado, resultado, 2); 
        }
    }
}
