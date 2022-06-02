using System;

using UnityEditor;

namespace TFToolsEditor.Extensions
{
    [InitializeOnLoad]
    public class EditorEvents
    {
        public static Action onStartCompiling;
        public static Action onEndCompiling;
        static bool compiled;

        public static Action onStartPlaying;
        public static Action onEndPlaying;
        static bool playing;

        static EditorEvents ()
        {
            EditorApplication.update += Update;
        }

        static void Update ()
        {
            #region Compilation

            if (compiled && EditorApplication.isCompiling)
            {
                // Start Compilation
                if (onStartCompiling != null)
                    onStartCompiling ();
                compiled = false;
            }

            if (!compiled && !EditorApplication.isCompiling)
            {
                // End Compilation
                if (onEndCompiling != null)
                    onEndCompiling ();
                compiled = true;
            }

            #endregion

            #region Play Mode

            if (playing && EditorApplication.isPlaying)
            {
                // Start Playing
                if (onStartPlaying != null)
                    onStartPlaying ();
                playing = false;
            }

            if (!playing && !EditorApplication.isPlaying)
            {
                // End Playing
                if (onEndPlaying != null)
                    onEndPlaying ();
                playing = true;
            }

            #endregion
        }
    }
}