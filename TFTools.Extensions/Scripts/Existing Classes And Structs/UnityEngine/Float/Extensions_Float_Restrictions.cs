using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Float
    {
        /// <summary>
        /// Clamp the the value between a minimun and maximum value.
        /// </summary>
        public static float Clamp (this float f, float _min, float _max)
        {
            return Mathf.Clamp (f, _min, _max);
        }

        /// <summary>
        /// Prevent the value to be lower than min.
        /// </summary>
        public static float Min (this float f, float _min)
        {
            return Mathf.Max (f, _min);
        }

        /// <summary>
        /// Prevent the value to be higher than max.
        /// </summary>
        public static float Max (this float f, float _max)
        {
            return Mathf.Min (f, _max);
        }

        /// <summary>
        /// Force the value to be higher than 0
        /// </summary>
        public static float ZeroIfLess (this float f)
        {
            return f.Min (0f);
        }

        /// <summary>
        /// Force the value to be lesser than 0
        /// </summary>
        public static float ZeroIfMore (this float f)
        {
            return f.Max (0f);
        }

    }
}