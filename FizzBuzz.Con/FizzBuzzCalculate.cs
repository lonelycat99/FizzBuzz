namespace FizzBuzz.Con
{
    public class FizzBuzzCalculate
    {
        //#Stage 1
        public string FindFizzBuzz(int number)
        {
            var result = (number % 3 == 0 && number % 5 == 0) ? "FizzBuzz"
                : (number % 3 == 0) ? "Fizz"
                : (number % 5 == 0) ? "Buzz"
                : number.ToString();

            return result;
        }

        //#Stage 2
        public string FindFizzBuzzWithDivisibleOrContains3And5(int number)
        {
            var result = ((isFizz(number)) && (isBuzz(number))) ? "FizzBuzz"
                : (isFizz(number)) ? "Fizz"
                : (isBuzz(number)) ? "Buzz"
                : number.ToString();
                
            return result;
        }

        private static bool isBuzz(int number)
        {
            return number % 5 == 0 || number.ToString().Contains("5");
        }

        private static bool isFizz(int number)
        {
            return number % 3 == 0 || number.ToString().Contains("3");
        }
    }
}