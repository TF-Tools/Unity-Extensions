using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Float
    {
        /// <summary>
        /// Convert the given float into an int value.
        /// </summary>
        public static int ToInt (this float f)
        {
            return (int) f;
        }

        #region To Vector

        /// <summary>
        /// Return a new Vector2 with x = f and y = f
        /// </summary>
        public static Vector2 ToVector2 (this float f)
        {
            return new Vector2 (f, f);
        }

        /// <summary>
        /// Return a new Vector3 with x = f, y = f and z = f
        /// </summary>
        public static Vector3 ToVector3 (this float f)
        {
            return new Vector3 (f, f, f);
        }

        /// <summary>
        /// Return a new Vector4 with x = f, y = f, z = f and w = f
        /// </summary>
        public static Vector4 ToVector4 (this float f)
        {
            return new Vector4 (f, f, f, f);
        }

        #endregion
    }
}