using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Int
    {
        /// <summary>
        /// Force the value to be higher than 0.
        /// </summary>
        public static int ZeroIfLess (this int i)
        {
            return i.Min (0);
        }

        /// <summary>
        /// Force the value to be lower than 0.
        /// </summary>
        public static int ZeroIfMore (this int i)
        {
            return i.Max (0);
        }

        /// <summary>
        /// Clamp the the value between a minimun and maximum value.
        /// </summary>
        public static int Clamp (this int i, int _min, int _max)
        {
            return Mathf.Clamp (i, _min, _max);
        }

        /// <summary>
        /// Prevent the value to be lower than min.
        /// </summary>
        public static int Min (this int i, int _min)
        {
            return Mathf.Max (i, _min);
        }

        /// <summary>
        /// Prevent the value to be higher than max.
        /// </summary>
        public static int Max (this int i, int _max)
        {
            return Mathf.Min (i, _max);
        }
    }
}