using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Vector2
    {
        #region With

        /// <summary>
        /// Set the x coordonate of the vector.
        /// </summary>
        public static Vector2 WithX (this Vector2 v, float _xValue)
        {
            v.x = _xValue;
            return v;
        }

        /// <summary>
        /// Set the y coordonate of the vector.
        /// </summary>
        public static Vector2 WithY (this Vector2 v, float _yValue)
        {
            v.y = _yValue;
            return v;
        }

        #endregion

        #region Incr

        /// <summary>
        /// Incr the x coordonate of the vector.
        /// </summary>
        public static Vector2 IncrementX (this Vector2 v, float _xIncr)
        {
            return v.WithX(v.x + _xIncr);
        }

        /// <summary>
        /// Incr the y coordonate of the vector.
        /// </summary>
        public static Vector2 IncrementY (this Vector2 v, float _yIncr)
        {
            return v.WithY (v.y + _yIncr);
        }

        #endregion
    }
}