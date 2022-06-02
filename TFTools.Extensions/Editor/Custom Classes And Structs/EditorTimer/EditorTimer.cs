using UnityEditor;

namespace TFToolsEditor.Extensions
{
    public class EditorTimer
    {
        bool m_IsRunning;
        public float speed;

        public float currentTime { get; private set; }
        public double lastFrameEditorTime { get; private set; }

        public EditorTimer ()
        {
            speed = 1f;
            EditorApplication.update += Update;
        }

        public void Update ()
        {
            if (isRunning)
            {
                double timeSinceStartup = EditorApplication.timeSinceStartup;
                double deltaTime = timeSinceStartup - lastFrameEditorTime;
                lastFrameEditorTime = timeSinceStartup;
                currentTime += (float) deltaTime * speed;
            }
        }

        #region Getter / Setter

        public bool isRunning
        {
            get => m_IsRunning;
            set
            {
                if (value && !m_IsRunning)
                    lastFrameEditorTime = EditorApplication.timeSinceStartup;

                m_IsRunning = value;
            }
        }

        #endregion
    }
}