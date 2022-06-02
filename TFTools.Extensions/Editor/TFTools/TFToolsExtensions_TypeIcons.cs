using System.Collections.Generic;

using UnityEngine;

using TFTools.Extensions;

namespace TFToolsEditor
{
    public static partial class TFToolsExtensions
    {
        const string k_TypesIconsPath = "Icons/Types";
        static Dictionary<string, Texture2D> m_TypesIcons = new ();

        #region Getter / Setter

        public static Dictionary<string, Texture2D> TypesIcons
        {
            get
            {
                if (m_TypesIcons == null || m_TypesIcons.Count == 0)
                {
                    m_TypesIcons = new ();

                    Object [] assets = LoadEditorResourcesFolder (k_TypesIconsPath, true);

                    foreach (Object obj in assets)
                    {
                        if (obj == null)
                            continue;

                        if (obj as Texture2D == null)
                            continue;

                        string name = obj.name.Split ('_').Last ().Split ('.') [0];

                        m_TypesIcons.Add (name, obj as Texture2D);
                    }
                }

                return m_TypesIcons;
            }
        }

        #endregion
    }
}