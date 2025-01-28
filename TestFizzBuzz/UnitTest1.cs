using FizzBuzzProjet;
using Xunit;
using System.Collections.Generic;

namespace TestFizzBuzz



{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsFizzForMultiplesOf3()
        {
            var rules = new List<IFizzBuzzRule> { new FizzRule() };
            var processor = new FizzBuzzProcessor(rules);

            string result = processor.Process(3);

            Assert.Equal("Fizz", result);
        }
        //
        [Fact]
        public void ReturnsBuzzForMultiplesOf5()
        {
            var rules = new List<IFizzBuzzRule> { new BuzzRule() };
            var processor = new FizzBuzzProcessor(rules);

            string result = processor.Process(5);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void ReturnsFizzBuzzForMultiplesOf3And5()
        {
            var rules = new List<IFizzBuzzRule> { new FizzBuzzRule() };
            var processor = new FizzBuzzProcessor(rules);

            string result = processor.Process(15);

            Assert.Equal("FizzBuzz", result);
        }
        [Fact]
        public void ReturnsNumberItselNotMultiplesOf3And5()
        {
            var rules = new List<IFizzBuzzRule> { new DefaultRule() };
            var processor = new FizzBuzzProcessor(rules);

            string result = processor.Process(11);

            Assert.Equal("11", result);
        }

    }
}