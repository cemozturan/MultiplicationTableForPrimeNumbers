using System;

namespace Core.PrimeNumbers
{
	public interface IPrimeNumberChecker
	{
		bool IsNumberPrime(int number);
	}

	public class PrimeNumberChecker : IPrimeNumberChecker
	{
		public bool IsNumberPrime(int number)
		{
			if (number < 2)
			{
				return false;
			}
			else if (number == 2)
			{
				return true;
			}
			else if (number % 2 == 0)
			{
				return false;
			}
			else
			{
				var sqrt = Math.Sqrt(number);
				for (var i = 3; i <= sqrt; i += 2)
				{
					if (number % i == 0)
					{
						return false;
					}
				}
			}
			return true;
		}
	}
}
