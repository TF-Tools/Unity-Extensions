using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Texture2D
    {
        public static void DrawLine (this Texture2D _texture, Vector2 _p1, Vector2 _p2, Color _col)
        {
            Vector2 t = _p1;
            float frac = 1 / Mathf.Sqrt (Mathf.Pow (_p2.x - _p1.x, 2) + Mathf.Pow (_p2.y - _p1.y, 2));
            float ctr = 0;

            while ((int) t.x != (int) _p2.x || (int) t.y != (int) _p2.y)
            {
                t = Vector2.Lerp (_p1, _p2, ctr);
                ctr += frac;
                _texture.SetPixel ((int) t.x, (int) t.y, _col);
            }
        }

        #region Blend

        #region 2 Textures

        /// <summary>
        /// Blend the specified tex and upperTexture via the given blendMode in a texture with the base texture size.
        /// If size is left to -1, the size will be the first Texture size.
        /// </summary>
        public static Texture2D Blend (this Texture2D _texture, Texture2D _upperTexture, ColorBlendMode _blendMode)
        {
            return _texture.Blend (_upperTexture, _blendMode, new Vector2Int (_texture.width, _texture.height));
        }

        /// <summary>
        /// Blend the specified tex and upperTexture via the given blendMode in a texture with the given size.
        /// </summary>
        public static Texture2D Blend (this Texture2D _texture, Texture2D _upperTexture, ColorBlendMode _blendMode, Vector2Int _size)
        {
            if (_texture == null)
                return new Texture2D (1, 1);

            if (_upperTexture == null)
                return _texture;

            Texture2D output = new Texture2D (_size.x, _size.y);

            for (int x = 0; x < output.width; x++)
                for (int y = 0; y < output.height; y++)
                {
                    int texX = (int) ((((float) x) / output.width) * _texture.width);
                    int texY = (int) ((((float) y) / output.height) * _texture.height);

                    int upperX = (int) ((((float) x) / output.width) * _upperTexture.width);
                    int upperY = (int) ((((float) y) / output.height) * _upperTexture.height);

                    output.SetPixel (x, y, _texture.GetPixel (texX, texY).Blend (_upperTexture.GetPixel (upperX, upperY), _blendMode));
                }

            output.Apply ();

            return output;
        }

        #endregion

        #region Texture + Color

        /// <summary>
        /// Blend the specified tex and color via the given blendMode in a texture with the base texture size.
        /// </summary>
        public static Texture2D Blend (this Texture2D _texture, Color _color, ColorBlendMode _blendMode)
        {
            return _texture.Blend (_color, _blendMode, new Vector2Int (_texture.width, _texture.height));
        }


        /// <summary>
        /// Blend the specified tex and color via the given blendMode in a texture with the given size.
        /// </summary>
        public static Texture2D Blend (this Texture2D _texture, Color _color, ColorBlendMode _blendMode, Vector2Int _size)
        {
            if (_texture == null)
                return new Texture2D (1, 1);

            Texture2D output = new Texture2D (_size.x, _size.y);

            for (int x = 0; x < output.width; x++)
                for (int y = 0; y < output.height; y++)
                {
                    int texX = (int) ((((float) x) / output.width) * _texture.width);
                    int texY = (int) ((((float) y) / output.height) * _texture.height);

                    output.SetPixel (x, y, _texture.GetPixel (texX, texY).Blend (_color, _blendMode));
                }

            output.Apply ();

            return output;
        }

        #endregion

        #endregion
    }
}