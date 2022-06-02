using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Texture2D
    {
        public static Texture2D Rotate (this Texture2D _texture,
                                         float _angle,
                                         bool _searchOutside = false)
        {
            _angle = -_angle - 90f;
            Texture2D rotImage = new Texture2D (_texture.width, _texture.height);
            int x, y;
            float x1, y1, x2, y2;

            float x0 = RotateX (_angle, -_texture.width / 2.0f, -_texture.height / 2.0f) + _texture.width / 2.0f;
            float y0 = RotateY (_angle, -_texture.width / 2.0f, -_texture.height / 2.0f) + _texture.height / 2.0f;

            float dx_x = RotateX (_angle, 1.0f, 0.0f);
            float dx_y = RotateY (_angle, 1.0f, 0.0f);
            float dy_x = RotateX (_angle, 0.0f, 1.0f);
            float dy_y = RotateY (_angle, 0.0f, 1.0f);

            x1 = x0;
            y1 = y0;

            for (x = 0; x < _texture.width; x++)
            {
                x2 = x1;
                y2 = y1;

                for (y = 0; y < _texture.height; y++)
                {
                    x2 += dx_x;
                    y2 += dx_y;
                    rotImage.SetPixel ((int) Mathf.Floor (x),
                                        (int) Mathf.Floor (y),
                                        GetPixel (_texture, x2, y2, _searchOutside));
                }

                x1 += dy_x;
                y1 += dy_y;
            }

            rotImage.Apply ();
            return rotImage;
        }

        static Color GetPixel (Texture2D _texture, float _x, float _y, bool _searchOutside)
        {
            Color pix;
            int x1 = (int) Mathf.Floor (_x);
            int y1 = (int) Mathf.Floor (_y);

            if (!_searchOutside && (x1 > _texture.width || x1 < 0 || y1 > _texture.height || y1 < 0))
                pix = Color.clear;
            else
                pix = _texture.GetPixel (x1, y1);

            return pix;
        }

        static float RotateX (float _angle, float _x, float _y)
        {
            float cos = Mathf.Cos (_angle / 180.0f * Mathf.PI);
            float sin = Mathf.Sin (_angle / 180.0f * Mathf.PI);
            return (_x * cos + _y * (-sin));
        }

        static float RotateY (float _angle, float _x, float _y)
        {
            float cos = Mathf.Cos (_angle / 180.0f * Mathf.PI);
            float sin = Mathf.Sin (_angle / 180.0f * Mathf.PI);
            return (_x * sin + _y * cos);
        }
    }
}