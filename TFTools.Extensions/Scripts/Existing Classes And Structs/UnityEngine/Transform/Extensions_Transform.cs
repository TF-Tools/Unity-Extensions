using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Transform
    {
        /// <summary>
        /// Reset the transform.
        /// </summary>
        public static void Reset (this Transform t, Space space = Space.World)
        {
            t.ResetPosition (space);
            t.ResetRotation (space);
            t.ResetScale ();
        }

        #region Position

        #region Set

        /// <summary>
        /// Sets X position of the transform.
        /// </summary>
        public static void SetPositionX (this Transform t, float xValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.position = new Vector3 (xValue, t.position.y, t.position.z);
                    break;
                case Space.Self:
                    t.localPosition = new Vector3 (xValue, t.localPosition.y, t.localPosition.z);
                    break;
            }
        }

        /// <summary>
        /// Sets Y position of the transform.
        /// </summary>
        public static void SetPositionY (this Transform t, float yValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.position = new Vector3 (t.position.x, yValue, t.position.z);
                    break;
                case Space.Self:
                    t.localPosition = new Vector3 (t.localPosition.x, yValue, t.localPosition.z);
                    break;
            }
        }

        /// <summary>
        /// Sets Z position of the transform.
        /// </summary>
        public static void SetPositionZ (this Transform t, float zValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.position = new Vector3 (t.position.x, t.position.y, zValue);
                    break;
                case Space.Self:
                    t.localPosition = new Vector3 (t.localPosition.x, t.localPosition.y, zValue);
                    break;
            }
        }

        #endregion

        #region Incr

        /// <summary>
        /// Incr X position of the transform by xValue.
        /// </summary>
        public static void IncrPositionX (this Transform t, float xValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.position += new Vector3 (xValue, 0f, 0f);
                    break;
                case Space.Self:
                    t.localPosition += new Vector3 (xValue, 0f, 0f);
                    break;
            }
        }

        /// <summary>
        /// Incr Y position of the transform by yValue.
        /// </summary>
        public static void IncrPositionY (this Transform t, float yValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.position += new Vector3 (0f, yValue, 0f);
                    break;
                case Space.Self:
                    t.localPosition += new Vector3 (0f, yValue, 0f);
                    break;
            }
        }

        /// <summary>
        /// Incr Z position of the transform by zValue.
        /// </summary>
        public static void IncrPositionZ (this Transform t, float zValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.position += new Vector3 (0f, 0f, zValue);
                    break;
                case Space.Self:
                    t.localPosition += new Vector3 (0f, 0f, zValue);
                    break;
            }
        }

        #endregion

        #region Lerp

        /// <summary>
        /// Linearly interpolate the position of the Transform between its current position and a given position.
        /// </summary>
        public static void LerpPosition (this Transform t, Vector3 value, float time, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.position = Vector3.Lerp (t.position, value, time);
                    break;
                case Space.Self:
                    t.localPosition = Vector3.Lerp (t.localPosition, value, time);
                    break;
            }
        }

        /// <summary>
        /// Linearly interpolate the x position of the Transform between its current value and a given value.
        /// </summary>
        public static void LerpPositionX (this Transform t, float xValue, float time, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.position = t.position.WithX (Mathf.Lerp (t.position.x, xValue, time));
                    break;
                case Space.Self:
                    t.localPosition = t.localPosition.WithX (Mathf.Lerp (t.localPosition.x, xValue, time));
                    break;
            }
        }

        /// <summary>
        /// Linearly interpolate the y position of the Transform between its current value and a given value.
        /// </summary>
        public static void LerpPositionY (this Transform t, float yValue, float time, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.position = t.position.WithY (Mathf.Lerp (t.position.y, yValue, time));
                    break;
                case Space.Self:
                    t.localPosition = t.localPosition.WithY (Mathf.Lerp (t.localPosition.y, yValue, time));
                    break;
            }
        }

        /// <summary>
        /// Linearly interpolate the z position of the Transform between its current value and a given value.
        /// </summary>
        public static void LerpPositionZ (this Transform t, float zValue, float time, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.position = t.position.WithZ (Mathf.Lerp (t.position.z, zValue, time));
                    break;
                case Space.Self:
                    t.localPosition = t.localPosition.WithZ (Mathf.Lerp (t.localPosition.z, zValue, time));
                    break;
            }
        }

        #endregion

        /// <summary>
        /// Reset the transform's position to Vector3.zero.
        /// </summary>
        public static void ResetPosition (this Transform t, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.position = Vector3.zero;
                    break;
                case Space.Self:
                    t.localPosition = Vector3.zero;
                    break;
            }
        }

        #endregion

        #region Rotation

        #region Set

        #region Euler

        /// <summary>
        /// Sets X rotation (in eulerAngles) of the transform.
        /// </summary>
        public static void SetEulerX (this Transform t, float xValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.eulerAngles = new Vector3 (xValue, t.eulerAngles.y, t.eulerAngles.z);
                    break;
                case Space.Self:
                    t.localEulerAngles = new Vector3 (xValue, t.localEulerAngles.y, t.localEulerAngles.z);
                    break;
            }
        }

        /// <summary>
        /// Sets Y rotation (in eulerAngles) of the transform.
        /// </summary>
        public static void SetEulerY (this Transform t, float yValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.eulerAngles = new Vector3 (t.eulerAngles.x, yValue, t.eulerAngles.z);
                    break;
                case Space.Self:
                    t.localEulerAngles = new Vector3 (t.localEulerAngles.x, yValue, t.localEulerAngles.z);
                    break;
            }
        }

        /// <summary>
        /// Sets Z rotation (in eulerAngles) of the transform.
        /// </summary>
        public static void SetEulerZ (this Transform t, float zValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.eulerAngles = new Vector3 (t.eulerAngles.x, t.eulerAngles.y, zValue);
                    break;
                case Space.Self:
                    t.localEulerAngles = new Vector3 (t.localEulerAngles.x, t.localEulerAngles.y, zValue);
                    break;
            }
        }

        #endregion

        #region Quaternion

        /// <summary>
        /// Sets X value of the quaternion rotation of the transform.
        /// </summary>
        public static void SetRotationX (this Transform t, float xValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.rotation = new Quaternion (xValue, t.rotation.y, t.rotation.z, t.rotation.w);
                    break;
                case Space.Self:
                    t.localRotation = new Quaternion (xValue, t.localRotation.y, t.localRotation.z, t.localRotation.w);
                    break;
            }
        }

        /// <summary>
        /// Sets Y value of the quaternion rotation of the transform.
        /// </summary>
        public static void SetRotationY (this Transform t, float yValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.rotation = new Quaternion (t.rotation.x, yValue, t.rotation.z, t.rotation.w);
                    break;
                case Space.Self:
                    t.localRotation = new Quaternion (t.localRotation.x, yValue, t.localRotation.z, t.localRotation.w);
                    break;
            }
        }

        /// <summary>
        /// Sets Z value of the quaternion rotation of the transform.
        /// </summary>
        public static void SetRotationZ (this Transform t, float zValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.rotation = new Quaternion (t.rotation.x, t.rotation.y, zValue, t.rotation.w);
                    break;
                case Space.Self:
                    t.localRotation = new Quaternion (t.localRotation.x, t.localRotation.y, zValue, t.localRotation.w);
                    break;
            }
        }

        /// <summary>
        /// Sets W value of the quaternion rotation of the transform.
        /// </summary>
        public static void SetRotationW (this Transform t, float wValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.rotation = new Quaternion (t.rotation.x, t.rotation.y, t.rotation.z, wValue);
                    break;
                case Space.Self:
                    t.localRotation = new Quaternion (t.localRotation.x, t.localRotation.y, t.localRotation.z, wValue);
                    break;
            }
        }

        #endregion

        #endregion

        #region Incr

        #region Euler

        /// <summary>
        /// Incr X rotation (in EulerAngles) of the transform by xValue.
        /// </summary>
        public static void IncrEulerX (this Transform t, float xValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.eulerAngles += new Vector3 (xValue, 0f, 0f);
                    break;
                case Space.Self:
                    t.localEulerAngles += new Vector3 (xValue, 0f, 0f);
                    break;
            }
        }

        /// <summary>
        /// Incr Y rotation (in EulerAngles) of the transform by yValue.
        /// </summary>
        public static void IncrEulerY (this Transform t, float yValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.eulerAngles += new Vector3 (0f, yValue, 0f);
                    break;
                case Space.Self:
                    t.localEulerAngles += new Vector3 (0f, yValue, 0f);
                    break;
            }
        }

        /// <summary>
        /// Incr Z rotation (in EulerAngles) of the transform by zValue.
        /// </summary>
        public static void IncrEulerZ (this Transform t, float zValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.eulerAngles += new Vector3 (0f, 0f, zValue);
                    break;
                case Space.Self:
                    t.localEulerAngles += new Vector3 (0f, 0f, zValue);
                    break;
            }
        }

        #endregion

        #region Quaternion

        /// <summary>
        /// Incr X rotation (in Quaternion) of the transform by xValue.
        /// </summary>
        public static void IncrRotationX (this Transform t, float xValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.rotation = t.rotation.IncrementX (xValue);
                    break;
                case Space.Self:
                    t.localRotation = t.localRotation.IncrementX (xValue);
                    break;
            }
        }

        /// <summary>
        /// Incr Y rotation (in Quaternion) of the transform by yValue.
        /// </summary>
        public static void IncrRotationY (this Transform t, float yValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.rotation = t.rotation.IncrementY (yValue);
                    break;
                case Space.Self:
                    t.localRotation = t.localRotation.IncrementY (yValue);
                    break;
            }
        }

        /// <summary>
        /// Incr Z rotation (in Quaternion) of the transform by zValue.
        /// </summary>
        public static void IncrRotationZ (this Transform t, float zValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.rotation = t.rotation.IncrementZ (zValue);
                    break;
                case Space.Self:
                    t.localRotation = t.localRotation.IncrementZ (zValue);
                    break;
            }
        }

        /// <summary>
        /// Incr Z rotation (in Quaternion) of the transform by zValue.
        /// </summary>
        public static void IncrRotationW (this Transform t, float wValue, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.rotation = t.rotation.IncrementW (wValue);
                    break;
                case Space.Self:
                    t.localRotation = t.localRotation.IncrementW (wValue);
                    break;
            }
        }

        #endregion

        #endregion

        #region Lerp

        #region Euler

        /// <summary>
        /// Linearly interpolate the rotation of the Transform between its current rotation and a given rotation.
        /// </summary>
        public static void LerpEuler (this Transform t, Vector3 value, float time, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.eulerAngles = Vector3.Lerp (t.eulerAngles, value, time);
                    break;
                case Space.Self:
                    t.localEulerAngles = Vector3.Lerp (t.localEulerAngles, value, time);
                    break;
            }
        }

        /// <summary>
        /// Linearly interpolate the X rotation of the Transform between its current value and a given value.
        /// </summary>
        public static void LerpEulerX (this Transform t, float xValue, float time, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.eulerAngles = t.eulerAngles.WithX (Mathf.Lerp (t.eulerAngles.x, xValue, time));
                    break;
                case Space.Self:
                    t.localEulerAngles = t.localEulerAngles.WithX (Mathf.Lerp (t.localEulerAngles.x, xValue, time));
                    break;
            }
        }

        /// <summary>
        /// Linearly interpolate the Y rotation of the Transform between its current value and a given value.
        /// </summary>
        public static void LerpEulerY (this Transform t, float yValue, float time, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.eulerAngles = t.eulerAngles.WithY (Mathf.Lerp (t.eulerAngles.y, yValue, time));
                    break;
                case Space.Self:
                    t.localEulerAngles = t.localEulerAngles.WithY (Mathf.Lerp (t.localEulerAngles.y, yValue, time));
                    break;
            }
        }

        /// <summary>
        /// Linearly interpolate the Z rotation of the Transform between its current value and a given value.
        /// </summary>
        public static void LerpEulerZ (this Transform t, float zValue, float time, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.eulerAngles = t.eulerAngles.WithZ (Mathf.Lerp (t.eulerAngles.z, zValue, time));
                    break;
                case Space.Self:
                    t.localEulerAngles = t.localEulerAngles.WithZ (Mathf.Lerp (t.localEulerAngles.z, zValue, time));
                    break;
            }
        }

        #endregion

        #region Quaternion

        /// <summary>
        /// Linearly interpolate the rotation of the Transform between its current rotation and a given rotation.
        /// </summary>
        public static void LerpRotation (this Transform t, Quaternion value, float time, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.rotation = Quaternion.Lerp (t.rotation, value, time);
                    break;
                case Space.Self:
                    t.localRotation = Quaternion.Lerp (t.localRotation, value, time);
                    break;
            }
        }

        /// <summary>
        /// Linearly interpolate the X rotation of the Transform between its current value and a given value.
        /// </summary>
        public static void LerpRotationX (this Transform t, float xValue, float time, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.rotation = t.rotation.WithX (Mathf.Lerp (t.rotation.x, xValue, time));
                    break;
                case Space.Self:
                    t.localRotation = t.localRotation.WithX (Mathf.Lerp (t.localRotation.x, xValue, time));
                    break;
            }
        }

        /// <summary>
        /// Linearly interpolate the Y rotation of the Transform between its current value and a given value.
        /// </summary>
        public static void LerpRotationY (this Transform t, float yValue, float time, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.rotation = t.rotation.WithY (Mathf.Lerp (t.rotation.y, yValue, time));
                    break;
                case Space.Self:
                    t.localRotation = t.localRotation.WithY (Mathf.Lerp (t.localRotation.y, yValue, time));
                    break;
            }
        }

        /// <summary>
        /// Linearly interpolate the Z rotation of the Transform between its current value and a given value.
        /// </summary>
        public static void LerpRotationZ (this Transform t, float zValue, float time, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.rotation = t.rotation.WithZ (Mathf.Lerp (t.rotation.z, zValue, time));
                    break;
                case Space.Self:
                    t.localRotation = t.localRotation.WithZ (Mathf.Lerp (t.localRotation.z, zValue, time));
                    break;
            }
        }

        /// <summary>
        /// Linearly interpolate the Z rotation of the Transform between its current value and a given value.
        /// </summary>
        public static void LerpRotationW (this Transform t, float wValue, float time, Space space = Space.World)
        {
            switch (space)
            {
                case Space.World:
                    t.rotation = t.rotation.WithW (Mathf.Lerp (t.rotation.w, wValue, time));
                    break;
                case Space.Self:
                    t.localRotation = t.localRotation.WithW (Mathf.Lerp (t.localRotation.w, wValue, time));
                    break;
            }
        }

        #endregion

        #endregion

        /// <summary>
        /// Reset the transform's rotation to Vector3.zero.
        /// </summary>
        public static void ResetRotation (this Transform t, Space space = Space.Self)
        {
            switch (space)
            {
                case Space.World:
                    t.rotation = Quaternion.identity;
                    break;
                case Space.Self:
                    t.localRotation = Quaternion.identity;
                    break;
            }
        }

        #endregion

        #region Scale

        #region Set

        /// <summary>
        /// Sets X value of the scale of the transform.
        /// </summary>
        public static void SetScaleX (this Transform t, float xValue)
        {
            t.localScale = new Vector3 (xValue, t.localScale.y, t.localScale.z);
        }

        /// <summary>
        /// Sets Y value of the scale of the transform.
        /// </summary>
        public static void SetScaleY (this Transform t, float yValue)
        {
            t.localScale = new Vector3 (t.localScale.x, yValue, t.localScale.z);
        }

        /// <summary>
        /// Sets Z value of the scale of the transform.
        /// </summary>
        public static void SetScaleZ (this Transform t, float zValue)
        {
            t.localScale = new Vector3 (t.localScale.x, t.localScale.y, zValue);
        }

        #endregion

        #region Incr

        /// <summary>
        /// Incr X value of the scale of the transform by xValue.
        /// </summary>
        public static void IncrScaleX (this Transform t, float xValue)
        {
            t.localScale += new Vector3 (xValue, 0f, 0f);
        }

        /// <summary>
        /// Incr Y value of the scale of the transform by yValue.
        /// </summary>
        public static void IncrScaleY (this Transform t, float yValue)
        {
            t.localScale += new Vector3 (0f, yValue, 0f);
        }

        /// <summary>
        /// Incr Z value of the scale of the transform by zValue.
        /// </summary>
        public static void IncrScaleZ (this Transform t, float zValue)
        {
            t.localScale += new Vector3 (0f, 0f, zValue);
        }

        #endregion

        #region Lerp

        /// <summary>
        /// Linearly interpolate the scale of the Transform between its current scale and a given scale.
        /// </summary>
        public static void LerpScale (this Transform t, Vector3 value, float time)
        {
            t.localScale = Vector3.Lerp (t.localScale, value, time);
        }

        /// <summary>
        /// Linearly interpolate the X scale of the Transform between its current value and a given value.
        /// </summary>
        public static void LerpScaleX (this Transform t, float xValue, float time)
        {
            t.localScale = t.localScale.WithX (Mathf.Lerp (t.eulerAngles.x, xValue, time));
        }

        /// <summary>
        /// Linearly interpolate the Y scale of the Transform between its current value and a given value.
        /// </summary>
        public static void LerpScaleY (this Transform t, float yValue, float time)
        {
            t.localScale = t.localScale.WithY (Mathf.Lerp (t.eulerAngles.y, yValue, time));
        }

        /// <summary>
        /// Linearly interpolate the Z scale of the Transform between its current value and a given value.
        /// </summary>
        public static void LerpScaleZ (this Transform t, float zValue, float time)
        {
            t.localScale = t.localScale.WithZ (Mathf.Lerp (t.eulerAngles.z, zValue, time));
        }

        #endregion

        /// <summary>
        /// Reset the transform's scale to Vector3.one.
        /// </summary>
        public static void ResetScale (this Transform t)
        {
            t.localScale = Vector3.one;
        }

        #endregion

        #region Parents

        /// <summary>
        /// Gets the number of parents the transform has.
        /// </summary>
        public static int ParentCount (this Transform t)
        {
            Transform parent = t;
            int i = 0;
            while (parent.parent != null)
            {
                parent = parent.parent;
                i++;
            }
            return i++;
        }

        /// <summary>
        /// Gets the parent of the object at a certain index.
        /// </summary>
        public static Transform GetParent (this Transform t, int indiceFromObject)
        {
            if (indiceFromObject > ParentCount (t))
                return null;

            Transform parent = t;

            for (int i = 0; i < indiceFromObject; i++)
                parent = parent.parent;

            return parent;
        }

        #endregion
    }
}