using Core.UserInput;
using NUnit.Framework;
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
            var input = _textReaderInputGetter.GetInput(stringReader);

            // Assert
            Assert.IsTrue(string.IsNullOrEmpty(input));
        }
    }
}
