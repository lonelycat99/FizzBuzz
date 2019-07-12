using System;
using System.Linq;

namespace FizzBuzz.Con
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal = new FizzBuzzCalculate();
            //#Stage 1
            Enumerable
                .Range(1, 100)
                .Select(it => cal.FindFizzBuzz(it))
                .ToList()
                .ForEach(it => System.Console.WriteLine(it));

            //#Stage 2
            Enumerable
                .Range(1, 100)
                .Select(it => cal.FindFizzBuzzWithDivisibleOrContains3And5(it))
                .ToList()
                .ForEach(it => System.Console.WriteLine(it));
        }
    }
}
