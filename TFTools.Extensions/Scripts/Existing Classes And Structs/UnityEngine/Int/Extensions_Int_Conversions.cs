using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Int
    {
        #region To Vector

        /// <summary>
        /// Return a new Vector2 with the given value in each components.
        /// </summary>
        public static Vector2 ToVector2 (this int i)
        {
            return new Vector2 (i, i);
        }

        /// <summary>
        /// Return a new Vector3 with the given value in each components.
        /// </summary>
        public static Vector3 ToVector3 (this int i)
        {
            return new Vector3 (i, i, i);
        }

        /// <summary>
        /// Return a new Vector4 with the given value in each components.
        /// </summary>
        public static Vector4 ToVector4 (this int i)
        {
            return new Vector4 (i, i, i, i);
        }

        #endregion

        /// <summary>
        /// Return a bool which is true if i == 1.
        /// </summary>
        public static bool ToBoolean (this int i)
        {
            return System.Convert.ToBoolean (i);
        }
    }
}