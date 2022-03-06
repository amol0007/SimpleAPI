using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void ReturnsMyName()
        {
            var value = controller.Get(1);
            Assert.Equal("Amol",value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
