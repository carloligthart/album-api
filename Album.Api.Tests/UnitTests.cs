using System;
using Xunit;
using Album_Api.Services;
using System.Net;

namespace Album.Api.Tests
{
 public class UnitTests
    {
        private readonly GreetingService greetingService = new GreetingService();

        [Fact]
        public void Greet_NamePassedAsInput_ReturnsHelloName()
        {
            string result = greetingService.Greet("John Doe");
            Console.WriteLine(result);

            Assert.Equal("Hello John Doe from " + Dns.GetHostName(), result);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData(" ")]
        public void Greet_InvallidNamesPassedAsInput_ReturnsHelloWorld(string input)
        {
            string result = greetingService.Greet(input);
            Console.WriteLine(result);

            Assert.Equal("Hello World", result);  
        }
    }
}
