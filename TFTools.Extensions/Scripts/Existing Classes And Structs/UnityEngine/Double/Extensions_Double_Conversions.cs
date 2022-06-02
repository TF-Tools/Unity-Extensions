using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Double
    {
        /// <summary>
        /// Convert the given double to an int value
        /// </summary>
        public static double ToInt (this double d)
        {
            return (int) d;
        }

        /// <summary>
        /// Convert the given double to a float value
        /// </summary>
        public static double ToFloat (this double d)
        {
            return (float) d;
        }

        #region To Vector

        /// <summary>
        /// Return a new Vector2 with x = d and y = d
        /// </summary>
        public static Vector2 ToVector2 (this double d)
        {
            return new Vector2 ((float) d, (float) d);
        }

        /// <summary>
        /// Return a new Vector3 with x = d, y = d and z = d
        /// </summary>
        public static Vector3 ToVector3 (this double d)
        {
            return new Vector3 ((float) d, (float) d, (float) d);
        }

        /// <summary>
        /// Return a new Vector4 with x = d, y = d, z = d and w = d
        /// </summary>
        public static Vector4 ToVector4 (this double d)
        {
            return new Vector4 ((float) d, (float) d, (float) d, (float) d);
        }

        #endregion
    }
}