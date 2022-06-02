using UnityEngine;

namespace TFToolsEditor.Extensions
{
    public static partial class Extensions_GUIStyle
    {
        /// <summary>
        /// Return a new GUIStyle with the given alignement parameters.
        /// </summary>
        public static GUIStyle WithAlignment (this GUIStyle _style, TextAnchor _textAnchor)
        {
            GUIStyle newStyle = new (_style)
            {
                alignment = _textAnchor
            };

            return newStyle;
        }

        /// <summary>
        /// Return a new GUIStyle with the rich text option set as defined.
        /// </summary>
        public static GUIStyle WithRichText (this GUIStyle _style, bool _state)
        {
            GUIStyle newStyle = new (_style)
            {
                richText = _state
            };

            return newStyle;
        }
    }
}