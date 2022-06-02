using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Vector3
    {
        #region To Vector2

        /// <summary>
        /// Return a Vector2 where x = y and y = z.
        /// </summary>
        public static Vector2 YZ (this Vector3 v)
        {
            return new Vector2 (v.y, v.z);
        }

        /// <summary>
        /// Return a Vector2 where x = x and y = z.
        /// </summary>
        public static Vector2 XZ (this Vector3 v)
        {
            return new Vector2 (v.x, v.z);
        }

        #endregion
    }
}