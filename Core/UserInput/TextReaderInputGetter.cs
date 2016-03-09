using System.IO;

namespace Core.UserInput
{
    public class TextReaderInputGetter : IUserInputGetter
    {
        public string GetInput(TextReader textReader)
        {
            return textReader.ReadLine();
        }
    }
}
