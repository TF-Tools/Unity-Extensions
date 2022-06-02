using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Vector2Int
    {
        #region With

        /// <summary>
        /// Set the x coordonate of the vector.
        /// </summary>
        public static Vector2Int WithX (this Vector2Int v, int _xValue)
        {
            v.x = _xValue;
            return v;
        }

        /// <summary>
        /// Set the y coordonate of the vector.
        /// </summary>
        public static Vector2Int WithY (this Vector2Int v, int _yValue)
        {
            v.y = _yValue;
            return v;
        }

        #endregion

        #region Incr

        /// <summary>
        /// Incr the x coordonate of the vector.
        /// </summary>
        public static Vector2Int IncrementX (this Vector2Int v, int _xIncr)
        {
            return v.WithX(v.x + _xIncr);
        }

        /// <summary>
        /// Incr the y coordonate of the vector.
        /// </summary>
        public static Vector2Int IncrementY (this Vector2Int v, int _yIncr)
        {
            return v.WithY(v.y + _yIncr);
        }

        #endregion
    }
}