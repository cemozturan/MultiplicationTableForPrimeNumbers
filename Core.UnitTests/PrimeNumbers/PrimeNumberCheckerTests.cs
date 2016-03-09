using Core.PrimeNumbers;
using NUnit.Framework;

namespace Core.UnitTests.PrimeNumbers
{
	[TestFixture]
	public class PrimeNumberCheckerTests
	{
		private PrimeNumberChecker _primeNumberChecker;

		[SetUp]
		public void SetUp()
		{
			_primeNumberChecker = new PrimeNumberChecker();
		}

		[TestCase(1)]
		[TestCase(0)]
		[TestCase(-1)]
		public void NumbersSmallerThan2ShouldFail(int number)
		{
			// Arrange
			// Act
			var isPrime = _primeNumberChecker.IsNumberPrime(number);

			// Assert
			Assert.IsFalse(isPrime);
		}
	}
}
