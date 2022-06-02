using System.Collections.Generic;

using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_GameObject
    {
        /// <summary>
        /// Performs a GetComponent on an array of gameobjects and returns all the found components.
        /// </summary>
        public static T [] GetComponents<T> (this GameObject [] _gameobjects) where T : Component
        {
            List<T> output = new List<T> ();

            foreach (GameObject g in _gameobjects)
            {
                T component = g.GetComponent<T> ();

                if (component != null && !output.Contains (component))
                    output.Add (component);
            }

            return output.ToArray ();
        }
    }
}