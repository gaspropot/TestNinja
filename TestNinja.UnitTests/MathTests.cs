using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnSumOfArguements()
        {
            var math = new Fundamentals.Math();

            var result = math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArguementIsGreater_ReturnTheFirstArguement()
        {
            var math = new Fundamentals.Math();

            var result = math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArguementIsGreater_ReturnTheSecondArguement()
        {
            var math = new Fundamentals.Math();

            var result = math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArguementsAreEqual_ReturnTheSameArguement()
        {
            var math = new Fundamentals.Math();

            var result = math.Max(1, 1);

            Assert.That(result, Is.EqualTo(1));
        }
    }
}
