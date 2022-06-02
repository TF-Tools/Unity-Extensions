using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Vector3
    {
        #region Clamp

        /// <summary>
        /// Clamp all the coordinates of the vector between min and max.
        /// </summary>
        public static Vector3 ClampAll (this Vector3 v, float _min, float _max)
        {
            return v.ClampX (_min, _max).ClampY (_min, _max).ClampZ (_min, _max);
        }

        /// <summary>
        /// Clamp the x coordinates of the vector between min and max.
        /// </summary>
        public static Vector3 ClampX (this Vector3 v, float _min, float _max)
        {
            return v.WithX (Mathf.Clamp (v.x, _min, _max));
        }

        /// <summary>
        /// Clamp the y coordinates of the vector between min and max.
        /// </summary>
        public static Vector3 ClampY (this Vector3 v, float min, float max)
        {
            return v.WithY (Mathf.Clamp (v.y, min, max));
        }

        /// <summary>
        /// Clamp the z coordinates of the vector between min and max.
        /// </summary>
        public static Vector3 ClampZ (this Vector3 v, float min, float max)
        {
            return v.WithZ (Mathf.Clamp (v.z, min, max));
        }

        #endregion

        #region Min & Max

        /// <summary>
        /// Prevent all x, y and z components to be lower than min.
        /// </summary>
        public static Vector3 MinAll (this Vector3 v, float min)
        {
            return v.MinX (min).MinY (min).MinZ (min);
        }

        /// <summary>
        /// Prevent the x component to be lower than min.
        /// </summary>
        public static Vector3 MinX (this Vector3 v, float min)
        {
            return v.WithX (Mathf.Max (v.x, min));
        }

        /// <summary>
        /// Prevent the y component to be lower than min.
        /// </summary>
        public static Vector3 MinY (this Vector3 v, float min)
        {
            return v.WithY (Mathf.Max (v.y, min));
        }

        /// <summary>
        /// Prevent the z component to be lower than min.
        /// </summary>
        public static Vector3 MinZ (this Vector3 v, float min)
        {
            return v.WithZ (Mathf.Max (v.z, min));
        }

        /// <summary>
        /// Prevent all x, y and z components to be higher than max.
        /// </summary>
        public static Vector3 MaxAll (this Vector3 v, float max)
        {
            return v.MaxX (max).MaxY (max).MaxZ (max);
        }

        /// <summary>
        /// Prevent the x component to be higher than max.
        /// </summary>
        public static Vector3 MaxX (this Vector3 v, float max)
        {
            return v.WithX (Mathf.Min (v.x, max));
        }

        /// <summary>
        /// Prevent the y component to be higher than max.
        /// </summary>
        public static Vector3 MaxY (this Vector3 v, float max)
        {
            return v.WithY (Mathf.Min (v.y, max));
        }

        /// <summary>
        /// Prevent the z component to be higher than max.
        /// </summary>
        public static Vector3 MaxZ (this Vector3 v, float max)
        {
            return v.WithZ (Mathf.Min (v.z, max));
        }

        #endregion
    }
}