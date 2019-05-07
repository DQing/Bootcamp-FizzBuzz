namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Calculate(int num)
        {
            if (num % 15 == 0)
            {
                return "FizzBuzz";
            }

            if (num % 3 == 0)
            {
                return "Fizz";
            }

            return num % 5 == 0 ? "Buzz" : num.ToString();
        }
    }
}