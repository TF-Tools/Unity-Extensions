using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Vector2
    {
        #region Clamp

        /// <summary>
        /// Clamp all the coordinates of the vector between min and max.
        /// </summary>
        public static Vector2 ClampAll (this Vector2 v, float _min, float _max)
        {
            return v.ClampX (_min, _max).ClampY (_min, _max);
        }

        /// <summary>
        /// Clamp the x coordinates of the vector between min and max.
        /// </summary>
        public static Vector2 ClampX (this Vector2 v, float _min, float _max)
        {
            return v.WithX(Mathf.Clamp (v.x, _min, _max));
        }

        /// <summary>
        /// Clamp the y coordinates of the vector between min and max.
        /// </summary>
        public static Vector2 ClampY (this Vector2 v, float _min, float _max)
        {
            return v.WithY(Mathf.Clamp (v.y, _min, _max));
        }

        #endregion

        #region Min & Max

        /// <summary>
        /// Prevent all x and y components to be lower than min.
        /// </summary>
        public static Vector2 MinAll (this Vector2 v, float _min)
        {
            return v.MinX(_min).MinY(_min);
        }

        /// <summary>
        /// Prevent the x component to be lower than min.
        /// </summary>
        public static Vector2 MinX (this Vector2 v, float _min)
        {
            return v.WithX(Mathf.Max (v.x, _min));
        }

        /// <summary>
        /// Prevent the y component to be lower than min.
        /// </summary>
        public static Vector2 MinY (this Vector2 v, float _min)
        {
            return v.WithY(Mathf.Max (v.y, _min));
        }

        /// <summary>
        /// Prevent all x and y components to be higher than max.
        /// </summary>
        public static Vector2 MaxAll (this Vector2 v, float _max)
        {
            return v.MaxX (_max).MaxY (_max);
        }

        /// <summary>
        /// Prevent the x component to be higher than max.
        /// </summary>
        public static Vector2 MaxX (this Vector2 v, float _max)
        {
            return v.WithX(Mathf.Min (v.x, _max));
        }

        /// <summary>
        /// Prevent the y component to be higher than max.
        /// </summary>
        public static Vector2 MaxY (this Vector2 v, float _max)
        {
            return v.WithY(Mathf.Min (v.x, _max));
        }

        #endregion

        #region Absolute

        /// <summary>
        /// Set the absolute value of each components of the Vector.
        /// </summary>
        public static Vector2 AbsAll (this Vector2 v)
        {
            return v.AbsX ().AbsY ();
        }

        /// <summary>
        /// Set the absolute value of each components of the Vector.
        /// </summary>
        public static Vector2 AbsX (this Vector2 v)
        {
            return v.WithX(Mathf.Abs (v.x));
        }

        /// <summary>
        /// Set the absolute value of each components of the Vector.
        /// </summary>
        public static Vector2 AbsY (this Vector2 v)
        {
            return v.WithY(Mathf.Abs (v.y));
        }

        #endregion
    }
}