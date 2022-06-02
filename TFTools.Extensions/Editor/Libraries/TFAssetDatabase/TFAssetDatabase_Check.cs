using UnityEngine;

using UnityEditor;

namespace TFToolsEditor.Extensions
{
    public static partial class TFAssetDatabase
    {
        /// <summary>
        /// Doeses the asset exist in the project database?
        /// </summary>
        public static bool DoesAssetExist (string _path)
        {
            return (AssetDatabase.LoadAssetAtPath (_path, typeof (Object)) != null);
        }

        /// <summary>
        /// Get an available name for a new asset.
        /// ( increment if needed )
        /// </summary>
        public static string GetAvailableAssetName (string _path, string _fileExtension)
        {
            string objPath = _path;

            if (!_fileExtension.Contains ("."))
                _fileExtension.Insert (0, ".");

            if (DoesAssetExist (objPath + _fileExtension))
            {
                int counter = 1;
                objPath += counter.ToString ();

                while (DoesAssetExist (objPath + _fileExtension))
                {
                    objPath = objPath.Remove (objPath.Length - counter.ToString ().Length);
                    counter++;
                    objPath += counter.ToString ();
                }
            }

            return objPath;
        }
    }
}