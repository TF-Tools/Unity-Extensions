using UnityEditor;

namespace TFToolsEditor.Extensions
{
    public static class Extensions_AssetPostprocessor
    {
        const string k_key = "hasBeenProcessed";

        public static bool HasBeenProcessed (this AssetImporter importer)
        {
            return importer.userData.Contains (k_key);
        }

        public static void SetHasBeenProcessed (this AssetImporter importer, bool value)
        {
            if (value && !importer.HasBeenProcessed ())
                importer.userData += k_key;
            else if (!value && importer.HasBeenProcessed ())
                importer.userData.Replace (k_key, string.Empty);
        }
    }
}