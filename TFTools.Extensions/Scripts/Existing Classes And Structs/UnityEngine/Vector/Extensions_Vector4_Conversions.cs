using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Vector4
    {
        #region To Vector3

        /// <summary>
        /// Return a Vector3 where x = x, y = y and z = z.
        /// </summary>
        public static Vector3 XYZ (this Vector4 v)
        {
            return new Vector3 (v.x, v.y, v.z);
        }

        /// <summary>
        /// Return a Vector3 where x = y, y = z and z = w.
        /// </summary>
        public static Vector3 YZW (this Vector4 v)
        {
            return new Vector3 (v.y, v.z, v.w);
        }

        /// <summary>
        /// Return a Vector3 where x = x, y = y and z = w.
        /// </summary>
        public static Vector3 XYW (this Vector4 v)
        {
            return new Vector3 (v.x, v.y, v.w);
        }

        /// <summary>
        /// Return a Vector3 where x = x, y = z and z = w.
        /// </summary>
        public static Vector3 XZW (this Vector4 v)
        {
            return new Vector3 (v.x, v.z, v.w);
        }

        #endregion

        #region To Vector2

        /// <summary>
        /// Return a Vector2 where x = x and y = y.
        /// </summary>
        public static Vector2 XY (this Vector4 v)
        {
            return new Vector2 (v.x, v.y);
        }

        /// <summary>
        /// Return a Vector2 where x = y and y = z.
        /// </summary>
        public static Vector2 YZ (this Vector4 v)
        {
            return new Vector2 (v.y, v.z);
        }

        /// <summary>
        /// Return a Vector2 where x = x and y = z.
        /// </summary>
        public static Vector2 XZ (this Vector4 v)
        {
            return new Vector2 (v.x, v.z);
        }

        /// <summary>
        /// Return a Vector2 where x = x and y = w.
        /// </summary>
        public static Vector2 XW (this Vector4 v)
        {
            return new Vector2 (v.x, v.w);
        }

        /// <summary>
        /// Return a Vector2 where x = y and y = w.
        /// </summary>
        public static Vector2 YW (this Vector4 v)
        {
            return new Vector2 (v.y, v.w);
        }

        /// <summary>
        /// Return a Vector2 where x = z and y = w.
        /// </summary>
        public static Vector2 ZW (this Vector4 v)
        {
            return new Vector2 (v.z, v.w);
        }

        #endregion
    }
}