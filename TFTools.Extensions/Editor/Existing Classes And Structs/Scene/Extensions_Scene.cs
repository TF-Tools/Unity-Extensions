using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEditor;

namespace TFToolsEditor.Extensions
{
    public static class Extensions_Scene
    {
        /// <summary>
        /// Gets the scene as an asset file.
        /// </summary>
        public static Object GetAsset (this Scene _scene)
        {
            return AssetDatabase.LoadAssetAtPath<Object> (_scene.path);
        }
    }
}