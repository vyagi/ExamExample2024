using System;
using Utilities;

namespace StringUtilitiesTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var someString = "maRcIn jaGIeła Junior";
            Console.WriteLine(StringUtilities.ToWords(someString));
            Console.WriteLine(StringUtilities.ToSentence(someString));
            Console.WriteLine(StringUtilities.ToCamelCase(someString));
            Console.WriteLine(someString.ToCamelCase());

        }
    }
}
