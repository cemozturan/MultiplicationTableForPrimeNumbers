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

		public int[] GetFirstNPrimeNumbers(int numberOfPrimes)
		{
			if (numberOfPrimes < 1)
			{
				throw new ArgumentException(string.Format(
					"{0} is an invalid input. The number of primes asked for must be a positive integer.",
					numberOfPrimes));
			}

			if (numberOfPrimes == 1)
			{
				return new int[] { 2 };
			}

			return null;
		}
	}
}
