using Core.UserInput;
using NUnit.Framework;

namespace Core.UnitTests.UserInput
{
    [TestFixture]
    class TextReaderInputGetterTests
    {
        private IUserInputGetter _textReaderInputGetter;

        [SetUp]
        public void SetUp()
        {
            _textReaderInputGetter = new TextReaderInputGetter();
        }
    }
}
