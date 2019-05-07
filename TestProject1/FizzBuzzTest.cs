using Xunit;


namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void should_return_number_when_input_is_1()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();
            var number = fizzBuzz.Calculate(1);

            Assert.Equal("1", number);
        }

        [Fact]
        public void should_return_fizz_when_input_is_times_of_3_and_not_for_5()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            var number = fizzBuzz.Calculate(3);
            Assert.Equal("Fizz", number);

            var number2 = fizzBuzz.Calculate(15);
            Assert.NotEqual("Fizz", number2);
        }

        [Fact]
        public void should_return_fizz_when_input_is_times_of_5_and_not_for_3()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            var number = fizzBuzz.Calculate(5);
            Assert.Equal("Buzz", number);

            var number2 = fizzBuzz.Calculate(15);
            Assert.NotEqual("Buzz", number2);
        }
        [Fact]
        public void should_return_fizz_when_input_is_times_of_5_and_3()
        {
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            var number = fizzBuzz.Calculate(15);
            Assert.Equal("FizzBuzz", number);
        }
    }
}