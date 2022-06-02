using System;

namespace TFTools.Extensions
{
    public static partial class Extensions_String
    {
        /// <summary>
        /// Spaces the words separated by upper characters.
        /// </summary>
        public static string SpaceWords (this string s)
        {
            string output = "";

            foreach (char c in s)
            {
                if (Char.IsUpper (c))
                    output += " ";

                output += c;
            }

            if (output[..1] == " ")
                output = output[1..];

            return output;
        }

        public static string [] Split (this string s, char _separator)
        {
            return s.Split (new char [] { _separator });
        }

        public static string [] Split (this string s, string _separator, StringSplitOptions _options)
        {
            return s.Split (new string [] { _separator }, _options);
        }
    }
}