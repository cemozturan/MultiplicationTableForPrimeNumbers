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
			return true;
		}
	}
}
