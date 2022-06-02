using System.IO;

using UnityEditor;

namespace TFToolsEditor.Extensions
{
    public static partial class TFAssetDatabase
    {
        /// <summary>
        /// Create an asset file with the given extension.
        /// </summary>
        public static void CreateEmptyFile (string _folderPath, string _fileName, string _fileExtension)
        {
            CreateEmptyFile (Path.Combine (_folderPath + "/" + _fileName), _fileExtension);
        }

        /// <summary>
        /// Create an asset file with the given extension.
        /// </summary>
        public static void CreateEmptyFile (string _filePath, string _fileExtension)
        {
            if (!_fileExtension.Contains ("."))
                _fileExtension.Insert (0, ".");

            string path = GetAvailableAssetName (_filePath, _fileExtension);
            path += _fileExtension;

            FileStream fileStream = File.Create (path);

            fileStream.Close ();

            AssetDatabase.Refresh ();
        }
    }
}