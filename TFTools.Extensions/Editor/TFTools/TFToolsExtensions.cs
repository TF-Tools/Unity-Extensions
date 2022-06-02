using UnityEngine;
using UnityEditor;
using System.IO;

using TFToolsEditor.Extensions;

namespace TFToolsEditor
{
    public static partial class TFToolsExtensions
    {
        const string k_Location = "Assets/Packages/com.tftools.extensions";
        const string k_Resources = "_Resources";

        /// <summary>
        /// Load an asset at the specified custom path.
        /// </summary>
        public static T Load<T> (string _path) where T : Object
        {
            return AssetDatabase.LoadAssetAtPath<T> (Path.Combine (k_Location, _path));
        }

        /// <summary>
        /// Load an asset at the specified custom path.
        /// </summary>
        public static Object [] LoadFolder (string _path, bool _isRecursive = false)
        {
            return TFAssetDatabase.LoadAllAssetsInFolder (Path.Combine (k_Location, _path), _isRecursive);
        }

        /// <summary>
        /// Load an asset at the specified custom path.
        /// </summary>
        public static T LoadEditorResource<T> (string _path) where T : Object
        {
            return Load<T> (Path.Combine (k_Resources, "Editor", _path));
        }

        /// <summary>
        /// Load an asset at the specified custom path.
        /// </summary>
        public static Object [] LoadEditorResourcesFolder (string _path, bool _isRecursive = false)
        {
            return LoadFolder (Path.Combine (k_Resources, "Editor", _path), _isRecursive);
        }
    }
}