using UnityEngine;

using UnityEditor;

using TFTools.Extensions;

namespace TFToolsEditor.Extensions
{
    [CustomPropertyDrawer (typeof (MinMax))]
    [CustomPropertyDrawer (typeof (MinMaxInt))]
    public class Drawer_MinMax : PropertyDrawer
    {
        public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty (position, label, property);

            position = EditorGUI.PrefixLabel (position, label);
            position.width /= 2f;

            float cachedLabelWidth = EditorGUIUtility.labelWidth;
            EditorGUIUtility.labelWidth = 30f;

            SerializedProperty minProperty = property.FindPropertyRelative ("m_Min");
            SerializedProperty maxProperty = property.FindPropertyRelative ("m_Max");

            EditorGUI.PropertyField (position, minProperty, new GUIContent ("Min"));
            position.x += position.width;
            EditorGUI.PropertyField (position, maxProperty, new GUIContent ("Max"));

            EditorGUIUtility.labelWidth = cachedLabelWidth;

            EditorGUI.EndProperty ();
        }
    }
}