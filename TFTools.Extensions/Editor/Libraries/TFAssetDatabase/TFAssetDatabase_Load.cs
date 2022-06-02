using System.IO;
using System.Collections.Generic;

using UnityEngine;

using UnityEditor;

using TFTools.Extensions;

namespace TFToolsEditor.Extensions
{
    public static partial class TFAssetDatabase
    {
        /// <summary>
        /// Loads all the assets in a given folder.
        /// </summary>
        public static Object [] LoadAllAssetsInFolder (string _folderPath, bool _isRecursive = false)
        {
            List<Object> assets = new ();
            string [] paths = Directory.GetFiles (_folderPath);

            if (_isRecursive)
                foreach (string subFolder in Directory.GetDirectories (_folderPath))
                    assets.Add (LoadAllAssetsInFolder (subFolder, true));

            foreach (string path in paths)
                assets.Add (AssetDatabase.LoadAssetAtPath<Object> (path));

            return assets.ToArray ();
        }
    }
}