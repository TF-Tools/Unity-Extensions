using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Vector2Int
    {
        #region Clamp

        /// <summary>
        /// Clamp all the coordinates of the vector between min and max.
        /// </summary>
        public static Vector2Int ClampAll (this Vector2Int v, int _min, int _max)
        {
            return v.ClampX (_min, _max).ClampY (_min, _max);
        }

        /// <summary>
        /// Clamp the x coordinates of the vector between min and max.
        /// </summary>
        public static Vector2Int ClampX (this Vector2Int v, int _min, int _max)
        {
            return v.WithX(Mathf.Clamp (v.x, _min, _max));
        }

        /// <summary>
        /// Clamp the y coordinates of the vector between min and max.
        /// </summary>
        public static Vector2Int ClampY (this Vector2Int v, int _min, int _max)
        {
            return v.WithY(Mathf.Clamp (v.y, _min, _max));
        }

        #endregion

        #region Min & Max

        /// <summary>
        /// Prevent all x and y components to be lower than min.
        /// </summary>
        public static Vector2Int MinAll (this Vector2Int v, int _min)
        {
            return v.MinX (_min).MinY (_min);
        }

        /// <summary>
        /// Prevent the x component to be lower than min.
        /// </summary>
        public static Vector2Int MinX (this Vector2Int v, int _min)
        {
            return v.WithX(Mathf.Max (v.x, _min));
        }

        /// <summary>
        /// Prevent the y component to be lower than min.
        /// </summary>
        public static Vector2Int MinY (this Vector2Int v, int _min)
        {
            return v.WithY(Mathf.Max (v.y, _min));
        }

        /// <summary>
        /// Prevent all x and y components to be higher than max.
        /// </summary>
        public static Vector2Int MaxAll (this Vector2Int v, int _max)
        {
            return v.MaxX (_max).MaxY (_max);
        }

        /// <summary>
        /// Prevent the x component to be higher than max.
        /// </summary>
        public static Vector2Int MaxX (this Vector2Int v, int _max)
        {
            return v.WithX(Mathf.Min (v.x, _max));
        }

        /// <summary>
        /// Prevent the y component to be higher than max.
        /// </summary>
        public static Vector2Int MaxY (this Vector2Int v, int _max)
        {
            return v.WithY(Mathf.Min (v.x, _max));
        }

        #endregion

        #region Absolute

        /// <summary>
        /// Set the absolute value of each components of the Vector.
        /// </summary>
        public static Vector2Int AbsAll (this Vector2Int v)
        {
            return v.AbsX ().AbsY ();
        }

        /// <summary>
        /// Set the absolute value of each components of the Vector.
        /// </summary>
        public static Vector2Int AbsX (this Vector2Int v)
        {
            return v.WithX(Mathf.Abs (v.x));
        }

        /// <summary>
        /// Set the absolute value of each components of the Vector.
        /// </summary>
        public static Vector2Int AbsY (this Vector2Int v)
        {
            return v.WithY(Mathf.Abs (v.y));
        }

        #endregion
    }
}