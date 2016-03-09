using Core.UserInput;
using NUnit.Framework;

namespace Core.UnitTests.UserInput
{
    [TestFixture]
    public class InputValidatorTests
    {
        private InputValidator _inputValidator;
		private const string MinimumInputForIntegerOverflow = "2147483648";

		[SetUp]
		public void SetUp()
		{
			_inputValidator = new InputValidator();
		}

		[TestCase("")]
		[TestCase("someText")]
		[TestCase("2.7")]
		[TestCase("4/2")]
		public void NonIntegerInputShouldFail(string userInput)
		{
			// Arrange
			// Act
			var isValid = _inputValidator.IsInputValid(userInput);

			// Assert
			Assert.IsFalse(isValid);
		}

		[TestCase("-1")]
		[TestCase("0")]
		public void NonPositiveIntegerInputShouldFail(string userInput)
		{
			// Arrange
			// Act
			var isValid = _inputValidator.IsInputValid(userInput);

			// Assert
			Assert.IsFalse(isValid);
		}

		[TestCase("1")]
		[TestCase("01")] // This is controversial, but I'll accept it as valid input.
		[TestCase("1234567")]
		[TestCase("2147483647")] // Maximum integer value
		public void PositiveIntegersShouldPass(string userInput)
		{
			// Arrange
			// Act
			var isValid = _inputValidator.IsInputValid(userInput);

			// Assert
			Assert.IsTrue(isValid);
		}
		
		[Test]
		public void IntegerOverflowShouldCauseAFail()
		{
			// Arrange
			// Act
			var isValid = _inputValidator.IsInputValid(MinimumInputForIntegerOverflow);

			// Assert
			Assert.IsFalse(isValid);
		}
	}
}
