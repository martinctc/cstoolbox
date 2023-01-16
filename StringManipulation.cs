using System;

namespace cstoolbox
{
    public class StringManipulation
    {
        public void Concatenate(string text1, string text2)
        {
            Console.WriteLine(text1, text2);
        }

        // See https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-6-0
        public bool StartsWithUpper(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            char ch = text[0];
            return char.IsUpper(ch);
        }

        public string ReplaceSpaceWithUnderscore(string text)
        {
            string newtext;
            newtext = text.Replace(" ", "_");
            return newtext;
        }

    }    
}