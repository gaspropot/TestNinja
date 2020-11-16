using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzBuzzTests
    {
        //private FizzBuzz _fizzBuzz;

        //[SetUp]
        //public void SetUp()
        //{
        //    _fizzBuzz = new FizzBuzz();
        //}

        [Test]
        public void FizzBuzz_NumberIsNotDivisibleByThreeOrFive_ReturnsTheNumber()
        {
            var result = FizzBuzz.GetOutput(2);

            Assert.That(result, Is.EqualTo("2"));
        }

        [Test]
        public void FizzBuzz_NumberIsDivisibleByBothThreeAndFive_ReturnsFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void FizzBuzz_NumberIsDivisibleOnlyByThree_ReturnsFizz()
        {
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void FizzBuzz_NumberIsDivisibleOnlyByFive_ReturnsBuzz()
        {
            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

    }
}
