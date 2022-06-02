using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Vector3
    {
        #region With

        /// <summary>
        /// Set the x coordonate of the vector.
        /// </summary>
        public static Vector3 WithX (this Vector3 v, float _xValue)
        {
            v.x = _xValue;
            return v;
        }

        /// <summary>
        /// Set the y coordonate of the vector.
        /// </summary>
        public static Vector3 WithY (this Vector3 v, float _yValue)
        {
            v.y = _yValue;
            return v;
        }

        /// <summary>
        /// Set the z coordonate of the vector.
        /// </summary>
        public static Vector3 WithZ (this Vector3 v, float _zValue)
        {
            v.z = _zValue;
            return v;
        }

        #endregion

        #region Incr

        /// <summary>
        /// Incr the x coordonate of the vector.
        /// </summary>
        public static Vector3 IncrementX (this Vector3 v, float _xIncr)
        {
            return v.WithX(v.x + _xIncr);
        }

        /// <summary>
        /// Incr the y coordonate of the vector.
        /// </summary>
        public static Vector3 IncrementY (this Vector3 v, float _yIncr)
        {
            return v.WithY (v.y + _yIncr);
        }

        /// <summary>
        /// Incr the z coordonate of the vector.
        /// </summary>
        public static Vector3 IncrementZ (this Vector3 v, float _zIncr)
        {
            return v.WithZ(v.z + _zIncr);
        }

        #endregion
    }
}