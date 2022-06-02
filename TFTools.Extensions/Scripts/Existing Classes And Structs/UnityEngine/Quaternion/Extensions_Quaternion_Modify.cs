using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Quaternion
    {
        #region With

        /// <summary>
        /// Set the x coordonate of the quaternion.
        /// </summary>
        public static Quaternion WithX (this Quaternion q, float _xValue)
        {
            return new Quaternion (_xValue, q.y, q.z, q.w);
        }

        /// <summary>
        /// Set the y coordonate of the quaternion.
        /// </summary>
        public static Quaternion WithY (this Quaternion q, float _yValue)
        {
            return new Quaternion (q.x, _yValue, q.z, q.w);
        }

        /// <summary>
        /// Set the z coordonate of the quaternion.
        /// </summary>
        public static Quaternion WithZ (this Quaternion q, float _zValue)
        {
            return new Quaternion (q.x, q.y, _zValue, q.w);
        }

        /// <summary>
        /// Set the w coordonate of the quaternion.
        /// </summary>
        public static Quaternion WithW (this Quaternion q, float _wValue)
        {
            return new Quaternion (q.x, q.y, q.z, _wValue);
        }

        #endregion

        #region Incr

        /// <summary>
        /// Adds two quaternion.
        /// </summary>
        public static Quaternion Increment (this Quaternion q, Quaternion _value)
        {
            return new Quaternion (q.x + _value.x, q.y + _value.y, q.z + _value.z, q.w + _value.w);
        }

        /// <summary>
        /// Incr Y value of the Quaternion by yValue.
        /// </summary>
        public static Quaternion IncrementX (this Quaternion q, float _xValue)
        {
            return new Quaternion (q.x + _xValue, q.y, q.z, q.w);
        }

        /// <summary>
        /// Incr Y value of the Quaternion by yValue.
        /// </summary>
        public static Quaternion IncrementY (this Quaternion q, float _yValue)
        {
            return new Quaternion (q.x, q.y + _yValue, q.z, q.w);
        }

        /// <summary>
        /// Incr Y value of the Quaternion by yValue.
        /// </summary>
        public static Quaternion IncrementZ (this Quaternion q, float _zValue)
        {
            return new Quaternion (q.x, q.y, q.z + _zValue, q.w);
        }

        /// <summary>
        /// Incr Y value of the Quaternion by yValue.
        /// </summary>
        public static Quaternion IncrementW (this Quaternion q, float _wValue)
        {
            return new Quaternion (q.x, q.y, q.z, q.w + _wValue);
        }

        #endregion
    }
}