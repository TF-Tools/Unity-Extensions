using UnityEngine;

namespace TFTools.Extensions
{
    public static class Extensions_Vector4_Modify
    {
        #region With

        /// <summary>
        /// Set the x coordonate of the vector.
        /// </summary>
        public static Vector4 WithX (this Vector4 v, float xValue)
        {
            v.x = xValue;
            return v;
        }

        /// <summary>
        /// Set the y coordonate of the vector.
        /// </summary>
        public static Vector4 WithY (this Vector4 v, float yValue)
        {
            v.y = yValue;
            return v;
        }

        /// <summary>
        /// Set the z coordonate of the vector.
        /// </summary>
        public static Vector4 WithZ (this Vector4 v, float zValue)
        {
            v.z = zValue;
            return v;
        }

        /// <summary>
        /// Set the w coordonate of the vector.
        /// </summary>
        public static Vector4 WithW (this Vector4 v, float wValue)
        {
            v.w = wValue;
            return v;
        }

        #endregion

        #region Incr

        /// <summary>
        /// Incr the x coordonate of the vector.
        /// </summary>
        public static Vector4 IncrementX (this Vector4 v, float _xIncr)
        {
            return v.WithX (v.x + _xIncr);
        }

        /// <summary>
        /// Incr the y coordonate of the vector.
        /// </summary>
        public static Vector4 IncrementY (this Vector4 v, float _yIncr)
        {
            return v.WithY (v.y + _yIncr);
        }

        /// <summary>
        /// Incr the z coordonate of the vector.
        /// </summary>
        public static Vector4 IncrementZ (this Vector4 v, float _zIncr)
        {
            return v.WithZ (v.z + _zIncr);
        }

        /// <summary>
        /// Incr the z coordonate of the vector.
        /// </summary>
        public static Vector4 IncrementW (this Vector4 v, float _wIncr)
        {
            return v.WithW (v.w + _wIncr);
        }

        #endregion
    }
}