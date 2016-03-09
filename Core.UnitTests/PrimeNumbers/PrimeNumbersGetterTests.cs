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
	}
}
