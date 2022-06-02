using System.Collections.Generic;

using UnityEngine;

using TFTools.Extensions;

namespace TFToolsEditor
{
    public static partial class TFToolsExtensions
    {
        const string k_UtilityTexturesPath = "Icons/Utilities";
        static Dictionary<string, Texture2D> m_UtilityIcons = new ();

        #region Getter / Setter

        public static Dictionary<string, Texture2D> UtilityIcons
        {
            get
            {
                if (m_UtilityIcons == null || m_UtilityIcons.Count == 0)
                {
                    m_UtilityIcons = new ();

                    Object [] assets = LoadEditorResourcesFolder (k_UtilityTexturesPath, true);

                    foreach (Object obj in assets)
                    {
                        if (obj == null)
                            continue;

                        if (obj as Texture2D == null)
                            continue;

                        string name = obj.name.Split ('_').Last ().Split ('.') [0];

                        m_UtilityIcons.Add (name, obj as Texture2D);
                    }
                }


                return m_UtilityIcons;
            }
        }

        #endregion
    }
}