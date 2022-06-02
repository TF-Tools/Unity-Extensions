using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Rect
    {
        public static Vector2 [] GetCorners (this Rect r)
        {
            Vector2 [] corners = new Vector2 [4];

            corners [0] = r.position + new Vector2 (0, 1);
            corners [1] = new Vector2 (r.position.x + r.width, r.position.y + 1);
            corners [2] = new Vector2 (r.position.x + r.width, r.position.y + r.height);
            corners [3] = new Vector2 (r.position.x, r.position.y + r.height);

            return corners;
        }

        public static Rect BottomRect (this Rect r)
        {
            r.y += r.height;
            r.height = 0f;

            return r;
        }

        public static Rect Percentage (this Rect r, float _x, float _y, float _width, float _height)
        {
            return new Rect (
                r.x + r.width * _x,
                r.y + r.height * _y,
                r.width * _width,
                r.height * _height
            );
        }
    }
}