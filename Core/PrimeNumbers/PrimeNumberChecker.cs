namespace Core.PrimeNumbers
{
	public class PrimeNumberChecker
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
				for (var i = 2; i < number; i++)
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
