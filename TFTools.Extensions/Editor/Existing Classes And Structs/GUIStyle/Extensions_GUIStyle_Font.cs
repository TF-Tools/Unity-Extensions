using UnityEngine;

namespace TFToolsEditor.Extensions
{
    public static partial class Extensions_GUIStyle
    {
        #region WithFont

        /// <summary>
        /// Return a new GUIStyle with the given font parameters.
        /// </summary>
        public static GUIStyle WithFont (this GUIStyle _style, int _fontSize)
        {
            return _style.WithFont (_fontSize, _style.normal.textColor, _style.fontStyle);
        }

        /// <summary>
        /// Return a new GUIStyle with the given font parameters.
        /// </summary>
        public static GUIStyle WithFont (this GUIStyle _style, Color _fontColor)
        {
            return _style.WithFont (_style.fontSize, _fontColor, _style.fontStyle);
        }

        /// <summary>
        /// Return a new GUIStyle with the given font parameters.
        /// </summary>
        public static GUIStyle WithFont (this GUIStyle _style, FontStyle _fontStyle)
        {
            return _style.WithFont (_style.fontSize, _style.normal.textColor, _fontStyle);
        }

        /// <summary>
        /// Return a new GUIStyle with the given font parameters.
        /// </summary>
        public static GUIStyle WithFont (this GUIStyle _style, int _fontSize, Color _fontColor)
        {
            return _style.WithFont (_fontSize, _fontColor, FontStyle.Normal);
        }

        /// <summary>
        /// Return a new GUIStyle with the given font parameters.
        /// </summary>
        public static GUIStyle WithFont (this GUIStyle _style, int _fontSize, FontStyle _fontStyle)
        {
            return _style.WithFont (_fontSize, _style.normal.textColor, _fontStyle);
        }

        /// <summary>
        /// Return a new GUIStyle with the given font parameters.
        /// </summary>
        public static GUIStyle WithFont (this GUIStyle _style, Color _fontColor, FontStyle _fontStyle)
        {
            return _style.WithFont (17, _fontColor, _fontStyle);
        }

        /// <summary>
        /// Return a new GUIStyle with the given font parameters.
        /// </summary>
        public static GUIStyle WithFont (this GUIStyle _style,
                                          int _fontSize,
                                          Color _fontColor,
                                          FontStyle _fontStyle)
        {
            GUIStyle newStyle = new (_style)
            {
                fontSize = _fontSize,
                fontStyle = _fontStyle
            };

            #region Color

            newStyle.normal.textColor = _fontColor;
            newStyle.onNormal.textColor = _fontColor;
            newStyle.hover.textColor = _fontColor;
            newStyle.onHover.textColor = _fontColor;
            newStyle.focused.textColor = _fontColor;
            newStyle.onFocused.textColor = _fontColor;
            newStyle.active.textColor = _fontColor;
            newStyle.onActive.textColor = _fontColor;

            #endregion

            return newStyle;
        }

        #endregion
    }
}