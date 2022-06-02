using System;

namespace TFTools.Extensions
{
    public static partial class Extensions_Bool
    {
        /// <summary>
        /// Convert the given bool into an int which value is 1 if true and 0 if false.
        /// </summary>
        public static int ToInt (this bool _b)
        {
            return Convert.ToInt32 (_b);
        }
    }
}