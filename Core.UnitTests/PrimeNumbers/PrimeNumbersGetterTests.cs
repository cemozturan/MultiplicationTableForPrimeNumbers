using Core.PrimeNumbers;
using NUnit.Framework;
using System;

namespace Core.UnitTests.PrimeNumbers
{
	[TestFixture]
	public class PrimeNumbersGetterTests
	{
		private PrimeNumbersGetter _primeNumbersGetter;

		[SetUp]
		public void SetUp()
		{
			_primeNumbersGetter = new PrimeNumbersGetter();
		}

		[TestCase(0)]
		[TestCase(-1)]
		public void NonPositiveIntegersShouldThrowException(int numberOfPrimes)
		{
			Assert.Throws<ArgumentException>(
				() => _primeNumbersGetter.GetFirstNPrimeNumbers(numberOfPrimes));
		}

		[Test]
		public void TheFirstPrimeNumberShouldBe2()
		{
			// Arrange
			// Act
			var primes = _primeNumbersGetter.GetFirstNPrimeNumbers(1);

			// Assert
			Assert.AreEqual(1, primes.Length);
			Assert.AreEqual(2, primes[0]);
		}
	}
}
