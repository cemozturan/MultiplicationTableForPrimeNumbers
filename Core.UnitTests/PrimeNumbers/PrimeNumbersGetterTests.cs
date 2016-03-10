using Core.PrimeNumbers;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

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
			_mockPrimeNumberChecker
				.Setup(x => x.IsNumberPrime(2))
				.Returns(true)
				.Verifiable();

			// Act
			var primes = _primeNumbersGetter.GetFirstNPrimeNumbers(1);

			// Assert
			Assert.AreEqual(1, primes.Length);
			Assert.AreEqual(2, primes[0]);
			_mockPrimeNumberChecker
				.Verify(x => x.IsNumberPrime(2), Times.Once);
		}

		[Test]
		public void AnyValidPrimeShouldBeReturned()
		{
			// Arrange
			var validPrimes = new List<int> { 2, 3, 13 };
			_mockPrimeNumberChecker
				.Setup(x => x.IsNumberPrime(It.Is<int>(number => validPrimes.Contains(number))))
				.Returns(true)
				.Verifiable();
			_mockPrimeNumberChecker
				.Setup(x => x.IsNumberPrime(It.Is<int>(number => !validPrimes.Contains(number))))
				.Returns(false)
				.Verifiable();

			// Act
			var primes = _primeNumbersGetter.GetFirstNPrimeNumbers(3);
			
			// Assert
			Assert.IsTrue(validPrimes.All(
				validPrime => primes.Contains(validPrime)));
			_mockPrimeNumberChecker.VerifyAll();
		}
	}
}
