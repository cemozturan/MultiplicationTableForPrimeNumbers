using System;


namespace Core.PrimeNumbers
{
	public class PrimeNumbersGetter
	{
		public int[] GetFirstNPrimeNumbers(int numberOfPrimes)
		{
			if (numberOfPrimes < 1)
			{
				throw new ArgumentException(string.Format(
					"{0} is an invalid input. The number of primes asked for must be a positive integer.",
					numberOfPrimes));
			}

			return null;
		}
	}
}
