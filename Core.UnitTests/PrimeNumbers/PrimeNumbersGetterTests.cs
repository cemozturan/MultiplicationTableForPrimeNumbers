using Core.PrimeNumbers;
using Moq;
using NUnit.Framework;
using System;

namespace Core.UnitTests.PrimeNumbers
{
	[TestFixture]
	public class PrimeNumbersGetterTests
	{
		private PrimeNumbersGetter _primeNumbersGetter;
		private Mock<IPrimeNumberChecker> _mockPrimeNumberChecker;

		[SetUp]
		public void SetUp()
		{
			_mockPrimeNumberChecker = new Mock<IPrimeNumberChecker>(MockBehavior.Strict); 
			_primeNumbersGetter = new PrimeNumbersGetter(_mockPrimeNumberChecker.Object);
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
