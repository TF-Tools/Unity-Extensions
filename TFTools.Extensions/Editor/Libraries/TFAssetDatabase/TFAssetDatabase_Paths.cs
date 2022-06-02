using System.IO;
using System.Linq;
using System.Collections.Generic;

using UnityEngine;

using UnityEditor;

using TFTools.Extensions;

namespace TFToolsEditor.Extensions
{
    public static partial class TFAssetDatabase
    {
        public static string [] GetAssetPaths (string _folderPath, bool _recursive = false, bool _ignoreMeta = true)
        {
            List<string> paths = new ();

            foreach (string filePath in Directory.GetFiles (_folderPath))
                if (!_ignoreMeta || !filePath.Contains (".meta"))
                    paths.Add (filePath.Replace ('\\', '/'));

            if (_recursive)
            {
                string [] subFolders = AssetDatabase.GetSubFolders (_folderPath);
                foreach (string subFolder in subFolders)
                    paths.Add (GetAssetPaths (subFolder, _recursive, _ignoreMeta));
            }

            return paths.ToArray ();
        }

        public static string [] GetAllAssetsPaths (Object [] _objects)
        {
            List<string> paths = new ();

            foreach (Object obj in Selection.objects)
            {
                if (!obj)
                    continue;

                string path = AssetDatabase.GetAssetPath (obj);

                if (!string.IsNullOrEmpty (path))
                    paths.Add (path);
            }

            return paths.ToArray ();
        }

        public static string [] GetSubPaths (string _folderPath, bool _isRecursive = false, bool _ignoreMeta = true)
        {
            List<string> paths = new List<string> ();

            if (_isRecursive)
            {
                string [] subfolders = AssetDatabase.GetSubFolders (_folderPath);

                foreach (string folder in subfolders)
                {
                    paths.Add (folder);
                    paths.Add (GetSubPaths (folder, _isRecursive, _ignoreMeta));
                }
            }

            foreach (string filePath in Directory.GetFiles (_folderPath))
                if (!_ignoreMeta || !filePath.Contains (".meta"))
                    paths.Add (filePath.Replace ('\\', '/'));

            return paths.ToArray ();
        }

        public static Dictionary<string, int> SortAndIndent (string [] _paths)
        {
            List<string> pathsList = _paths.ToList ();
            pathsList.Sort ();
            Dictionary<string, int> pathDictionary = new Dictionary<string, int> ();

            for (int i = 0; i < pathsList.Count; i++)
            {
                string [] split = pathsList [i].Split ('/');
                string buildedPath = "Assets";

                for (int j = 1; j < split.Length; j++)
                {
                    buildedPath += "/" + split [j];

                    if (!pathDictionary.ContainsKey (buildedPath))
                        pathDictionary.Add (buildedPath, j);
                }
            }

            return pathDictionary;
        }
    }
}