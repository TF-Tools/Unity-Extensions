using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Color
    {
        /// <summary>
        /// Return the colors with a specified alpha.
        /// </summary>
        public static Color WithAlpha (this Color _color, float _alpha)
        {
            return new Color (_color.r, _color.g, _color.b, _alpha);
        }
    }
}