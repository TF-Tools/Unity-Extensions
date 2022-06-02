using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Camera
    {
        /// <summary>
        /// Gets the focused point of the Camera.
        /// </summary>
        public static Vector3 GetFocusedPoint (this Camera _camera, float _maxFocusedDistance = 1000f)
        {
            RaycastHit hit;
            Ray ray = new Ray (_camera.transform.position, _camera.transform.forward);
            Physics.Raycast (ray, out hit, _maxFocusedDistance);

            if (hit.transform != null)
                return hit.point;
            else
                return Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width / 2, Screen.height / 2, _maxFocusedDistance));
        }
    }
}