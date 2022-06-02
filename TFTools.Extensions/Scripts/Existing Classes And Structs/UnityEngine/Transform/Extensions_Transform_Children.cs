using System.Collections.Generic;

using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Transform
    {
        /// <summary>
        /// Gets all the children of the transform.
        /// </summary>
        public static Transform [] GetChildren (this Transform t, bool _recursive = false)
        {
            if (t.childCount == 0)
                return new Transform [0];

            List<Transform> children = new List<Transform> ();

            for (int i = 0; i < t.childCount; i++)
            {
                Transform child = t.GetChild (i);
                children.Add (child);

                if (_recursive)
                    children.Add (child.GetChildren (_recursive));
            }

            return children.ToArray ();
        }

        /// <summary>
        /// The total number of children the transform's hierarchy has.
        /// (including children's children, etc...)
        /// </summary>
        public static int GetRecursiveChildCount (this Transform t)
        {
            int nb = 0;

            for (int i = 0; i < t.childCount; i++)
            {
                nb++;
                nb += GetRecursiveChildCount (t.GetChild (i));
            }

            return nb;
        }

        public static Transform GetFirstChild (this Transform t)
        {
            if (t.childCount == 0)
                return null;

            return t.GetChild (0);
        }

        public static Transform GetLastChild (this Transform t)
        {
            if (t.childCount == 0)
                return null;

            return t.GetChild (t.childCount - 1);
        }
    }
}