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
			return true;
		}
	}
}
