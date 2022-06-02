using UnityEditor;

namespace TFToolsEditor.Extensions
{
    public class TFAssetPostprocessor : AssetPostprocessor
	{
		/// <summary>
		/// Has the AssetPostProcessor already been processed.
		/// </summary>
		public bool HasAssetBeenProcessed
		{
			get
			{
				return assetImporter.HasBeenProcessed ();
			}
			set
			{
				assetImporter.SetHasBeenProcessed ( value );
			}
		}
	}
}