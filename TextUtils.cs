using System;
using System.Linq;

namespace TextUtilsLibrary
{
    public static class TextUtils
    {
        public static bool IsPalindrome(string text)
        {
            string cleanedText = new string(text.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            return cleanedText.SequenceEqual(cleanedText.Reverse());
        }

        public static int CountSentences(string text)
        {
            char[] sentenceEndings = { '.', '!', '?' };
            return text.Split(sentenceEndings, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string ReverseString(string text)
        {
            return new string(text.Reverse().ToArray());
        }
    }
}
