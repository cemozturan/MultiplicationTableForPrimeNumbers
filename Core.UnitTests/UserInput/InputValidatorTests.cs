using Core.UserInput;
using NUnit.Framework;

namespace Core.UnitTests.UserInput
{
    [TestFixture]
    public class InputValidatorTests
    {
        private InputValidator _inputValidator;

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
	}
}
