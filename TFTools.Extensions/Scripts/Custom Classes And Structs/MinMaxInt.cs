using UnityEngine;

namespace TFTools.Extensions
{
    [System.Serializable]
    public struct MinMaxInt
    {
        [SerializeField] int m_Min, m_Max;

        [SerializeField] bool m_HasLastRandom;
        [SerializeField] int m_LastRandom;

        #region Constructors

        /// <summary>
        /// Constructs a new MinMax with given min and max.
        /// </summary>
        public MinMaxInt (int _min, int _max)
        {
            m_Min = _min;
            m_Max = _max;
            m_HasLastRandom = false;
            m_LastRandom = 0;
        }

        /// <summary>
        /// Constructs a new MinMax similar to the given MinMax.
        /// </summary>
        public MinMaxInt (MinMaxInt _minMax)
        {
            m_Min = _minMax.Min;
            m_Max = _minMax.Max;
            m_HasLastRandom = _minMax.HasLastRandom;
            m_LastRandom = _minMax.LastRandom;
        }

        #endregion

        /// <summary>
        /// Returns a random int between [Min, Max (exclusive)]
        /// </summary>
        /// <returns></returns>
        public int GetRandom ()
        {
            m_HasLastRandom = true;
            m_LastRandom = Random.Range (m_Min, m_Max);
            return m_LastRandom;
        }

        #region Getter / Setter

        /// <summary>
        /// Min limit of the MinMax.
        /// </summary>
        public int Min
        {
            get => m_Min;
            set
            {
                if (value > m_Max)
                    m_Min = m_Max;
                else
                    m_Min = value;
            }
        }

        /// <summary>
        /// Max limit of the MinMax.
        /// </summary>
        public int Max
        {
            get => m_Max;
            set
            {
                if (value < m_Min)
                    m_Max = m_Min;
                else
                    m_Max = value;
            }
        }

        /// <summary>
        /// The range of the MinMax.
        /// </summary>
        public int Range
        {
            get => Mathf.Abs (this.m_Max - this.m_Min);
        }

        /// <summary>
        /// Does the MinMax have already a lasrRandom?
        /// </summary>
        public bool HasLastRandom
        {
            get => m_HasLastRandom;
        }

        /// <summary>
        /// The lastRandom of the MinMax.
        /// </summary>
        public int LastRandom
        {
            get => m_LastRandom;
        }

        #endregion
    }
}