using UnityEngine;

using UnityEditor;

using TFTools.Extensions;

namespace TFToolsEditor.Extensions
{
    [CustomPropertyDrawer (typeof (Percentage))]
    public class Drawer_Percentage : PropertyDrawer
    {
        const float k_PercentageLabelWidth = 15f;
        const float k_PercentageLabelSpacing = 5f;

        public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.propertyType == SerializedPropertyType.Float)
            {
                EditorGUI.BeginProperty (position, label, property);

                position.width -= k_PercentageLabelWidth + k_PercentageLabelSpacing;
                property.floatValue = Mathf.Clamp01 (EditorGUI.FloatField (position, label, property.floatValue * 100f) / 100f);

                Rect percentagePosition = position;
                percentagePosition.x += percentagePosition.width + k_PercentageLabelSpacing;
                percentagePosition.width = k_PercentageLabelWidth;
                EditorGUI.LabelField (percentagePosition, "%");

                EditorGUI.EndProperty ();
            }
            else
                EditorGUI.LabelField (position, label.text, "Use Percentage with float.");
        }
    }
}