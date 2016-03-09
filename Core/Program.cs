using Core.UserInput;
using System;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputGetter = new TextReaderInputGetter();
            var numberOfPrimes = inputGetter.GetInput(Console.In);

            Console.WriteLine("Press ANY key to exit.");
            Console.ReadKey();
        }
    }
}
