using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Rect
    {
        public static Rect Reduce (this Rect r, float _size)
        {
            r.x += _size;
            r.width -= _size * 2f;
            r.height -= _size * 2f;
            r.y += _size;

            return r;
        }

        #region With

        #region Pos

        public static Rect WithPos (this Rect r, Vector2 _position)
        {
            return r.WithPos (_position.x, _position.y);
        }

        public static Rect WithPos (this Rect r, float _xPosition, float _yPosition)
        {
            r.x = _xPosition;
            r.y = _yPosition;

            return r;
        }

        #endregion

        #region Height

        public static Rect WithHeight (this Rect r, float _height)
        {
            r.height = _height;

            return r;
        }

        #endregion

        #endregion

        #region Incr

        #region Pos

        public static Rect IncrPos (this Rect r, Vector2 _position)
        {
            return r.IncrPos (_position.x, _position.y);
        }

        public static Rect IncrPos (this Rect r, float _xPosition, float _yPosition)
        {
            r.x += _xPosition;
            r.y += _yPosition;

            return r;
        }

        #endregion

        #endregion
    }
}