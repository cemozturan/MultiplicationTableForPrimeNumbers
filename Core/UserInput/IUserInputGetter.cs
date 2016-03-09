using System.IO;

namespace Core.UserInput
{
    public interface IUserInputGetter
    {
        string GetInput(TextReader textReader);
    }
}
