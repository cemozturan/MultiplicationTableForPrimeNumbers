using System;

namespace Core.PrimeNumbers
{
	public class PrimeNumbersGetter
	{
		private readonly IPrimeNumberChecker _primeNumberChecker;

		public PrimeNumbersGetter(IPrimeNumberChecker primeNumberChecker)
		{
			_primeNumberChecker = primeNumberChecker;
		}

		public int[] GetFirstNPrimeNumbers(int numberOfPrimesRequired)
		{
			if (numberOfPrimesRequired < 1)
			{
				throw new ArgumentException(string.Format(
					"{0} is an invalid input. The number of primes asked for must be a positive integer.",
					numberOfPrimesRequired));
			}

			var primeNumbers = new int[numberOfPrimesRequired];
			var numberOfPrimesFound = 0;
			var nextNumber = 2;

			while (numberOfPrimesFound < numberOfPrimesRequired)
			{
				if (_primeNumberChecker.IsNumberPrime(nextNumber))
				{
					primeNumbers[numberOfPrimesFound] = nextNumber;
					numberOfPrimesFound++;
				}
				nextNumber++;
			}

			return primeNumbers;
		}
	}
}
