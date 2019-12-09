using System;
using System.Globalization;

namespace TitleCaseChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words seperated by a space: ");
            string input = Console.ReadLine();

            // This line is needed for some reason to make all this work:
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            string convertedinput = textInfo.ToTitleCase(input);

            // Line to get rid off whitespace:
            convertedinput = string.Join("", convertedinput.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

            Console.WriteLine(convertedinput);
        }
    }
}
