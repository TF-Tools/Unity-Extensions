namespace TFTools.Extensions
{
    public class Saved<T>
    {
        T m_Current;
        T m_Old;

        #region Operators

        public static implicit operator T (Saved<T> _data)
        {
            return _data.m_Current;
        }

        #endregion

        #region Getter / Setter

        public T Current
        {
            get => m_Current;
            set
            {
                m_Old = m_Current;
                m_Current = value;
            }
        }

        public T Old
        {
            get => m_Old;
        }

        #endregion
    }
}