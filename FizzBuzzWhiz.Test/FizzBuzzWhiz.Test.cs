using NUnit.Framework;

namespace FizzBuzzWhiz.Test
{
    [TestFixture]
    class FizzBuzzWhizTest
    {

        [Test]
        public void Three_should_output_fizz()
        {
            var output = FizzBuzzWhiz.GetFizzBuzzWhiz(3);
            Assert.That(output, Is.EqualTo("fizz"));
        }

    }
}
