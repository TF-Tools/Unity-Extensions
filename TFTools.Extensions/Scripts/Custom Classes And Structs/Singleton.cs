namespace TFTools.Extensions
{
    public class Singleton<T> where T : new()
    {
        protected static T m_Instance;

        #region Getter / Setter

        public static T Instance
        {
            get
            {
                if (m_Instance == null)
                    m_Instance = new T ();

                return m_Instance;
            }
        }

        #endregion
    }
}