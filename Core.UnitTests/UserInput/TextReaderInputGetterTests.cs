using Core.UserInput;
using NUnit.Framework;
using System;
using System.IO;

namespace Core.UnitTests.UserInput
{
    [TestFixture]
    public class TextReaderInputGetterTests
    {
        private IUserInputGetter _textReaderInputGetter;

        [SetUp]
        public void SetUp()
        {
            _textReaderInputGetter = new TextReaderInputGetter();
        }

        [Test]
        public void EmptyStringShouldBeRead()
        {
            // Arrange
            var stringReader = new StringReader(string.Empty);
            
            // Act
            var inputRead = _textReaderInputGetter.GetInput(stringReader);

            // Assert
            Assert.IsTrue(string.IsNullOrEmpty(inputRead));
        }

        [TestCase("some string with no line breaks")]
        [TestCase("NoWhiteSpaceAndSomeNumbersShouldBeRead123456")]
        public void StringsWithNoLineBreakShouldBeRead(string userInput)
        {
            // Arrange
            var stringReader = new StringReader(userInput);

            // Act
            var inputRead = _textReaderInputGetter.GetInput(stringReader);

            // Assert
            Assert.AreEqual(userInput, inputRead);
        }

        [Test]
        public void StringsShouldBeReadUntilTheFirstLineBreak()
        {
            // Arrange
            var expectedValue = "This should be read";
            var userInput = expectedValue
                + Environment.NewLine
                + "and this should not be read"
                + Environment.NewLine
                + "as well as this.";
            var stringReader = new StringReader(userInput);

            // Act
            var inputRead = _textReaderInputGetter.GetInput(stringReader);

            // Assert
            Assert.AreEqual(expectedValue, inputRead);
        }
    }
}
