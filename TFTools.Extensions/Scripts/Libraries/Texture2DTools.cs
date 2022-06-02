using UnityEngine;

namespace TFTools.Extensions
{
    public static class Texture2DTools
    {
        static Texture2D m_BlackTexture;

        public static Texture2D CreateColorTexture (int _width, int _height, Color _color)
        {
            Texture2D texture = new Texture2D (_width, _height);
            Color [] pixels = new Color [_width * _height];

            for (int i = 0; i < pixels.Length; i++)
                pixels [i] = _color;

            texture.SetPixels (pixels);

            return texture;
        }

        public static Texture2D CopyTexture (Texture2D _source, Vector2 _copySize)
        {
            int sizeX = (int) _copySize.x;
            int sizeY = (int) _copySize.y;

            Texture2D output = new Texture2D (sizeX, sizeY);

            for (int x = 0; x < sizeX; x++)
                for (int y = 0; x < sizeY; y++)
                {
                    int texX = (int) ((((float) x) / sizeX) * _source.width);
                    int texY = (int) ((((float) y) / sizeY) * _source.height);
                    output.SetPixel (x, y, _source.GetPixel (texX, texY));
                }

            output.Apply ();

            return output;
        }

        #region Getter / Setter

        public static Texture2D BlackTexture
        {
            get
            {
                if (m_BlackTexture == null)
                    m_BlackTexture = CreateColorTexture (1, 1, Color.black);

                return m_BlackTexture;
            }
        }

        #endregion
    }
}