using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Vector4
    {
        #region Clamp

        /// <summary>
        /// Clamp all the coordinates of the vector between min and max.
        /// </summary>
        public static Vector4 ClampAll (this Vector4 v, float _min, float _max)
        {
            return v.ClampX (_min, _max).ClampY (_min, _max).ClampZ (_min, _max).ClampW (_min, _max);
        }

        /// <summary>
        /// Clamp the x coordinates of the vector between min and max.
        /// </summary>
        public static Vector4 ClampX (this Vector4 v, float _min, float _max)
        {
            return v.WithX (Mathf.Clamp (v.x, _min, _max));
        }

        /// <summary>
        /// Clamp the y coordinates of the vector between min and max.
        /// </summary>
        public static Vector4 ClampY (this Vector4 v, float _min, float _max)
        {
            return v.WithY (Mathf.Clamp (v.y, _min, _max));
        }

        /// <summary>
        /// Clamp the z coordinates of the vector between min and max.
        /// </summary>
        public static Vector4 ClampZ (this Vector4 v, float _min, float _max)
        {
            return v.WithZ (Mathf.Clamp (v.z, _min, _max));
        }

        /// <summary>
        /// Clamp the w coordinates of the vector between min and max.
        /// </summary>
        public static Vector4 ClampW (this Vector4 v, float _min, float _max)
        {
            return v.WithW (Mathf.Clamp (v.w, _min, _max));
        }

        #endregion

        #region Min & Max

        /// <summary>
        /// Prevent all x, y, z and w components to be lower than min.
        /// </summary>
        public static Vector4 MinAll (this Vector4 v, float _min)
        {
            return v.MinX (_min).MinY (_min).MinZ (_min).MinW (_min);
        }

        /// <summary>
        /// Prevent the x component to be lower than min.
        /// </summary>
        public static Vector4 MinX (this Vector4 v, float _min)
        {
            return v.WithX (Mathf.Max (v.x, _min));
        }

        /// <summary>
        /// Prevent the y component to be lower than min.
        /// </summary>
        public static Vector4 MinY (this Vector4 v, float _min)
        {
            return v.WithY (Mathf.Max (v.y, _min));
        }

        /// <summary>
        /// Prevent the z component to be lower than min.
        /// </summary>
        public static Vector4 MinZ (this Vector4 v, float min)
        {
            return v.WithZ (Mathf.Max (v.z, min));
        }

        /// <summary>
        /// Prevent the w component to be lower than min.
        /// </summary>
        public static Vector4 MinW (this Vector4 v, float min)
        {
            return v.WithW (Mathf.Max (v.w, min));
        }

        /// <summary>
        /// Prevent all x, y, z and w components to be higher than max.
        /// </summary>
        public static Vector4 MaxAll (this Vector4 v, float _max)
        {
            return v.MaxX (_max).MaxY (_max).MaxZ (_max).MaxW (_max);
        }

        /// <summary>
        /// Prevent the x component to be higher than max.
        /// </summary>
        public static Vector4 MaxX (this Vector4 v, float _max)
        {
            return v.MaxX (Mathf.Min (v.x, _max));
        }

        /// <summary>
        /// Prevent the y component to be higher than max.
        /// </summary>
        public static Vector4 MaxY (this Vector4 v, float _max)
        {
            return v.WithY (Mathf.Min (v.y, _max));
        }

        /// <summary>
        /// Prevent the z component to be higher than max.
        /// </summary>
        public static Vector4 MaxZ (this Vector4 v, float _max)
        {
            return v.WithY (Mathf.Min (v.z, _max));
        }

        /// <summary>
        /// Prevent the w component to be higher than max.
        /// </summary>
        public static Vector4 MaxW (this Vector4 v, float _max)
        {
            return v.WithW (Mathf.Min (v.w, _max));
        }

        #endregion
    }
}