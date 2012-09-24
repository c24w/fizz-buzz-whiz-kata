using NUnit.Framework;

namespace FizzBuzzWhiz
{
    [TestFixture]
    internal class FizzBuzzWhiz
    {
        private static string GetFizzBuzzWhiz(int i)
        {
            return GetFizz(i)
                   + GetBuzz(i)
                   + GetWhiz(i);
        }

        private static string GetWhiz(int i)
        {
            return IfDivisibleReturnString(i, 10, "whiz");
        }


        private static string GetBuzz(int i)
        {
            return IfDivisibleReturnString(i, 5, "buzz");
        }

        private static string GetFizz(int i)
        {
            return IfDivisibleReturnString(i, 3, "fizz");
        }

        private static string IfDivisibleReturnString(int dividend, int divisor, string s)
        {
            if (dividend%divisor == 0)
                return s;
            return "";
        }

        [Test]
        public void Fifteen_should_output_fizzbuzz()
        {
            string output = GetFizzBuzzWhiz(15);
            Assert.That(output, Is.EqualTo("fizzbuzz"));
        }

        [Test]
        public void Fifty_should_output_buzzwhiz()
        {
            string output = GetFizzBuzzWhiz(50);
            Assert.That(output, Is.EqualTo("buzzwhiz"));
        }

        [Test]
        public void Five_should_output_buzz()
        {
            string output = GetFizzBuzzWhiz(5);
            Assert.That(output, Is.EqualTo("buzz"));
        }

        [Test]
        public void Six_should_output_fizz()
        {
            string output = GetFizzBuzzWhiz(6);
            Assert.That(output, Is.EqualTo("fizz"));
        }

        [Test]
        public void Ten_should_output_buzzwhiz()
        {
            string output = GetFizzBuzzWhiz(10);
            Assert.That(output, Is.EqualTo("buzzwhiz"));
        }

        [Test]
        public void Thirty_should_output_fizzbuzzwhiz()
        {
            string output = GetFizzBuzzWhiz(30);
            Assert.That(output, Is.EqualTo("fizzbuzzwhiz"));
        }

        [Test]
        public void Three_should_output_fizz()
        {
            string output = GetFizzBuzzWhiz(3);
            Assert.That(output, Is.EqualTo("fizz"));
        }
    }
}