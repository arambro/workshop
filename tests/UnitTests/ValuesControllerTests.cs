using System;
using System.Linq;
using MyApp.Controllers;
using Xunit;

namespace UnitTests
{
    public class ValuesControllerTests
    {
        private readonly ValuesController controller;

        public ValuesControllerTests()
        {
            this.controller = new ValuesController();
        }

        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestGet()
        {
            //Given
            
            //When
            var values = this.controller.Get();

            //Then
            Assert.True(values.Value.Count() == 2);
        }
    }
}
