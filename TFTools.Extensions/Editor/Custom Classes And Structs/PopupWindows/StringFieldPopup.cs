using System;

using UnityEngine;

using UnityEditor;

namespace TFToolsEditor.Extensions
{
    public class StringFieldPopup : EditorWindow
    {
        #region Properties

        string m_FieldValue = "";
        string m_Label = "";
        string m_Button = "";

        public event Action<string> onClickButton;

        #endregion

        #region Functions

        public static void GetStringFieldWindow (Action<string> _callback,
                                                    string _labelText = "Entry",
                                                    string _windowName = "Confirm Window",
                                                    string _buttonText = "Confirm",
                                                    string _defaultValue = "")
        {
            GetStringFieldWindow (_callback, new Vector2 (250f, 40f), _labelText, _windowName, _buttonText, _defaultValue);
        }

        public static void GetStringFieldWindow (Action<string> _callback,
                                                    Vector2 _windowSize,
                                                    string _labelText = "Entry",
                                                    string _windowName = "Confirm Window",
                                                    string _buttonText = "Confirm",
                                                    string _defaultValue = "")
        {
            StringFieldPopup wnd = EditorWindow.GetWindow<StringFieldPopup> (true, _windowName);
            wnd.minSize = _windowSize;
            wnd.maxSize = wnd.minSize;
            wnd.m_Label = _labelText;
            wnd.m_Button = _buttonText;
            wnd.m_FieldValue = _defaultValue;
            wnd.onClickButton += _callback;
        }

        void OnGUI ()
        {
            EditorGUILayout.BeginHorizontal ();
            EditorGUILayout.LabelField (m_Label, GUILayout.Width (65));
            m_FieldValue = EditorGUILayout.TextField (m_FieldValue);
            EditorGUILayout.EndHorizontal ();

            if (GUILayout.Button (m_Button))
            {
                if (onClickButton != null)
                    onClickButton (m_FieldValue);
                Close ();
            }
        }

        #endregion
    }
}