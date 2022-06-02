using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Quaternion
    {
        #region Get Axis

        public static Vector3 GetForwardVector (this Quaternion q)
        {
            return q * Vector3.forward;
        }

        public static Vector3 GetRightVector (this Quaternion q)
        {
            return q * Vector3.right;
        }

        public static Vector3 GetUpVector (this Quaternion q)
        {
            return q * Vector3.up;
        }

        #endregion
    }
}