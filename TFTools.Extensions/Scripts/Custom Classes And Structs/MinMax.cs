using UnityEngine;

namespace TFTools.Extensions
{
    [System.Serializable]
    public struct MinMax
    {
        [SerializeField] float m_Min;
        [SerializeField] float m_Max;

        [SerializeField] public bool hasLastRandom { get; private set; }
        [SerializeField] public float lastRandom { get; private set; }

        #region Constructors

        /// <summary>
        /// Constructs a new MinMax with given min and max.
        /// </summary>
        public MinMax (float _min, float _max)
        {
            m_Min = _min;
            m_Max = _max;
            hasLastRandom = false;
            lastRandom = 0f;
        }

        /// <summary>
        /// Constructs a new MinMax similar to the given MinMax.
        /// </summary>
        public MinMax (MinMax minMax)
        {
            m_Min = minMax.Min;
            m_Max = minMax.Max;
            hasLastRandom = minMax.hasLastRandom;
            lastRandom = minMax.lastRandom;
        }

        #endregion

        public float GetRandom ()
        {
            hasLastRandom = true;
            lastRandom = Random.Range (m_Min, m_Max);
            return lastRandom;
        }

        #region Getter / Setter

        /// <summary>
        /// Min limit of the MinMax.
        /// </summary>
        public float Min
        {
            get => m_Min;
            set
            {
                m_Min = value.Max (m_Max);
            }
        }

        /// <summary>
        /// Max limit of the MinMax.
        /// </summary>
        public float Max
        {
            get => m_Max;
            set
            {
                m_Max = value.Min (m_Min);
            }
        }

        /// <summary>
        /// The range of the MinMax.
        /// </summary>
        public float Range
        {
            get => Mathf.Abs (this.m_Max - this.m_Min);
        }

        #endregion
    }
}