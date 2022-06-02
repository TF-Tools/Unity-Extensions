using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Gradient
    {
        public static bool HasAlpha (this Gradient _gradient)
        {
            foreach (GradientAlphaKey alphaKey in _gradient.alphaKeys)
                if (alphaKey.alpha < 1f)
                    return true;

            return false;
        }
    }
}