﻿using NUnit.Framework;

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
			var rows = _tableRowCreator.CreateRows(primes);

			// Assert
			Assert.AreEqual("|   | " + primeNumber + " |", rows[0]);
		}
	}
}