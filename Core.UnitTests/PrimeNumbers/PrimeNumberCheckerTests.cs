using Core.PrimeNumbers;
using NUnit.Framework;

namespace Core.UnitTests.PrimeNumbers
{
	[TestFixture]
	public class PrimeNumberCheckerTests
	{
		private IPrimeNumberChecker _primeNumberChecker;

		private static int[] NonPrimeOddNumbers = { 9, 15, 33, 121, 169 };
		private static int[] PrimeOddNumbers = { 3, 5, 7, 311, 571 };

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

		[Test]
		public void TwoShouldPass()
		{
			// Arrange
			// Act
			var isPrime = _primeNumberChecker.IsNumberPrime(2);

			// Assert
			Assert.IsTrue(isPrime);
		}

		[TestCase(4)]
		[TestCase(1000)]
		public void EvenNumbersOtherThan2ShouldFail(int number)
		{
			// Arrange
			// Act
			var isPrime = _primeNumberChecker.IsNumberPrime(number);

			// Assert
			Assert.IsFalse(isPrime);
		}

		[TestCaseSource("NonPrimeOddNumbers")]
		public void NonPrimeOddNumbersShouldFail(int number)
		{
			// Arrange
			// Act
			var isPrime = _primeNumberChecker.IsNumberPrime(number);

			// Assert
			Assert.IsFalse(isPrime);
		}

		[TestCaseSource("PrimeOddNumbers")]
		public void PrimeOddNumbersShouldPass(int number)
		{
			// Arrange
			// Act
			var isPrime = _primeNumberChecker.IsNumberPrime(number);

			// Assert
			Assert.IsTrue(isPrime);
		}
	}
}
