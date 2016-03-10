using Core.MultiplicationTable;
using Core.PrimeNumbers;
using Core.UserInput;
using System;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputGetter = new TextReaderInputGetter();
			var inputValidator = new InputValidator();
			var primeNumbersGetter = new PrimeNumbersGetter(new PrimeNumberChecker());
			var tableRowCreator = new TableRowCreator();

			Console.WriteLine("Please enter the number of primes you want to include in the multiplication table:");

			var numberOfPrimes = inputGetter.GetInput(Console.In);
			while (!inputValidator.IsInputValid(numberOfPrimes))
			{
				Console.WriteLine(string.Format(
					"{0} is not a positive integer or it is too large. Please enter a number again:"
					, numberOfPrimes));
				numberOfPrimes = inputGetter.GetInput(Console.In);
			}

			var primeNumbers = primeNumbersGetter.GetFirstNPrimeNumbers(Int32.Parse(numberOfPrimes));
			var row = tableRowCreator.CreateHeaderRow(primeNumbers);
			Console.WriteLine(row);

			for (var i = 0; i < primeNumbers.Length; i++)
			{
				row = tableRowCreator.CreateRow(primeNumbers, primeNumbers[i]);
				Console.WriteLine(row);
			}

			Console.WriteLine();
			Console.WriteLine("Press ANY key to exit.");
            Console.ReadKey();
        }
    }
}
