using System;
using Xunit;
using System.Linq;
using LINQextensions;

namespace UnitTest.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange
            string[] cars = { "Alfa Romeo", "Aston Martin", "Audi", "Nissan", "Chevrolet",  "Chrysler", "Dodge", "BMW",
                            "Ferrari",  "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)"};

            // act 

            //assert
            Assert.Equal(cars.FirstOrDefaultMy(), cars.FirstOrDefault());
            Assert.Equal(cars.FirstOrDefaultMy(c => c.Contains("Ж")), cars.FirstOrDefault(c => c.Contains("Ж")));
            Assert.Equal(cars.AnyMy(), cars.Any());
            Assert.Equal(cars.AnyMy(c => c.Contains("Audi")), cars.Any(c => c.Contains("Audi")));
            Assert.Equal(cars.AnyMy(c => c.Contains("33333333333")), cars.Any(c => c.Contains("33333333333")));
            Assert.Equal(cars.AllMy(c => c.Contains("Toyota")), cars.All(c => c.Contains("Toyota")));
            Assert.Equal(cars.AllMy(c => char.IsUpper(c[0])), cars.All(c => char.IsUpper(c[0])));
        }
    }
}
