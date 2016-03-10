using Core.MultiplicationTable;
using NUnit.Framework;

namespace Core.UnitTests.MultiplicationTable
{
	[TestFixture]
	public class TableRowCreatorTests
	{
		private TableRowCreator _tableRowCreator;

		[SetUp]
		public void SetUp()
		{
			_tableRowCreator = new TableRowCreator();
		}

		[Test]
		public void FirstRowShouldBeTheHeaderRow()
		{
			// Arrange
			var primeNumber = 2;
			var primes = new int[1] { primeNumber };

			// Act
			var row = _tableRowCreator.CreateHeaderRow(primes);

			// Assert
			Assert.AreEqual("|   | " + primeNumber + " |", row);
		}

		[Test]
		public void FirstRowShouldContainAllFoundPrimeNumbers()
		{
			// Arrange
			var primes = new int[3] { 2, 3, 5 };

			// Act
			var row = _tableRowCreator.CreateHeaderRow(primes);

			// Assert
			Assert.AreEqual("|   | " + primes[0] + " | "
				+ primes[1] + " | "
				+ primes[2] + " |",
				row);
		}

		[TestCase(0)]
		[TestCase(1)]
		[TestCase(2)]
		public void RowsOtherThanTheFirstRowShouldStartWithTheCorrespondingPrimeNumber(int indexOfPrime)
		{
			// Arrange
			var primes = new int[3] { 2, 3, 5 };

			// Act
			var row = _tableRowCreator.CreateRow(primes, primes[indexOfPrime]);

			// Assert
			Assert.IsTrue(row.StartsWith("| " + primes[indexOfPrime] + " |"));
		}

		[TestCase(0)]
		[TestCase(1)]
		[TestCase(2)]
		public void RowsOtherThanTheFirstRowShouldContainMultiplicationResults(int indexOfPrime)
		{
			// Arrange
			var primes = new int[3] { 2, 3, 5 };

			// Act
			var row = _tableRowCreator.CreateRow(primes, primes[indexOfPrime]);

			// Assert
			Assert.AreEqual("| " + primes[indexOfPrime] + " | "
				+ primes[0] * primes[indexOfPrime] + " | "
				+ primes[1] * primes[indexOfPrime] + " | "
				+ primes[2] * primes[indexOfPrime] + " |",
				row);
		}
	}
}
