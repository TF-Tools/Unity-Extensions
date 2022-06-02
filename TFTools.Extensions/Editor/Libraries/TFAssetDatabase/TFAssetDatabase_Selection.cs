using UnityEditor;

namespace TFToolsEditor.Extensions
{
    public static partial class TFAssetDatabase
    {
        /// <summary>
        /// Gets the current context click path in the project window.
        /// </summary>
        public static string CurrentContextPath
        {
            get
            {
                if (Selection.activeObject == null)
                    return "";

                return AssetDatabase.GetAssetPath (Selection.activeObject);
            }
        }
    }
}