using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Texture2D
    {
        public static Vector2 GetSize (this Texture2D _texture)
        {
            if (_texture == null)
                return -Vector2.one;

            return new Vector2 (_texture.width, _texture.height);
        }
    }
}