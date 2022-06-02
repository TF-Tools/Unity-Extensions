using UnityEngine;

using UnityEditor;

namespace TFToolsEditor.Extensions
{
    public static class TFGUIContents
    {
        #region Methods

        public static GUIContent PlayButton (bool _value)
        {
            if (_value)
                return EditorGUIUtility.IconContent ("PauseButton");
            else
                return EditorGUIUtility.IconContent ("PlayButton");
        }

        public static GUIContent AlphaChannelToggle (bool _value)
        {
            if (_value)
                return EditorGUIUtility.IconContent ("preTextureAlpha");
            else
                return EditorGUIUtility.IconContent ("preTextureRGB");
        }

        #endregion

        #region Getter / Setter

        public static GUIContent SpeedScale
        {
            get
            {
                return EditorGUIUtility.IconContent ("SpeedScale");
            }
        }

        public static GUIContent Checker
        {
            get
            {
                return EditorGUIUtility.IconContent ("CheckerFloor");
            }
        }

        #endregion
    }
}