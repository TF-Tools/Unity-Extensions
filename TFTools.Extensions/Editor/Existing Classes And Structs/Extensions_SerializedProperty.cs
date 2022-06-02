using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace TFToolsEditor.Extensions
{
    public static class Extensions_SerializedProperty
    {
        #region Get Property Attributes

        /// <summary>
        /// Gets all the Property Attributes of the property.
        /// </summary>
        public static object [] GetPropertyAttributes (this SerializedProperty property)
        {
            return property.GetPropertyAttributes<PropertyAttribute> ();
        }

        /// <summary>
        /// Gets all the specified type Property Attributes of the property.
        /// </summary>
        public static object [] GetPropertyAttributes<T> (this SerializedProperty property) where T : System.Attribute
        {
            if (property.serializedObject.targetObject == null)
                return null;

            BindingFlags bindingFlags =
                BindingFlags.GetField |
                BindingFlags.GetProperty |
                BindingFlags.IgnoreCase |
                BindingFlags.Instance |
                BindingFlags.NonPublic |
                BindingFlags.Public;

            System.Type type;

            string path = property.propertyPath;

            if (path.Contains ("."))
            {
                path = path.Remove (property.propertyPath.LastIndexOf ('.'));
                type = property.serializedObject.FindProperty (path).GetType ();
            }
            else
                type = property.serializedObject.targetObject.GetType ();

            FieldInfo info = type.GetField (property.name, bindingFlags);

            if (info == null)
                return null;

            return info.GetCustomAttributes (typeof (T), true);
        }

        /// <summary>
        /// Is the specified Property Attribute applied to the property?
        /// </summary>
        public static bool ContainsPropertyAttribute<T> (this SerializedProperty property) where T : System.Attribute
        {
            object [] attributes = property.GetPropertyAttributes<T> ();

            if (attributes != null)
                return attributes.Length > 0;

            return false;
        }

        /// <summary>
        /// Get the first specified type Property Attribute applied to the property.
        /// </summary>
        public static T GetAttribute<T> (this SerializedProperty property) where T : System.Attribute
        {
            object [] attributes = property.GetPropertyAttributes<T> ();

            if (attributes != null && attributes.Length > 0)
            {
                return attributes [0] as T;
            }

            return null;
        }

        #endregion
    }
}