using System;

namespace Core.UserInput
{
	public class InputValidator
	{
		public bool IsInputValid(string input)
		{
			int value;
			return Int32.TryParse(input, out value)
				&& value > 0;
		}
    }
}
