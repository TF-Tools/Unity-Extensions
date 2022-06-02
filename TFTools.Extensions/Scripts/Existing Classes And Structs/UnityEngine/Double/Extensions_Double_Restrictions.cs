namespace TFTools.Extensions
{
    public static partial class Extensions_Double
    {
        /// <summary>
        /// Clamp the the value between a minimun and maximum value.
        /// </summary>
        public static double Clamp (this double d, double _min, double _max)
        {
            return d.Min (_min).Max (_max);
        }

        /// <summary>
        /// Prevent the value to be lower than min.
        /// </summary>
        public static double Min (this double d, double _min)
        {
            if (d < _min)
                return _min;
            else
                return d;
        }

        /// <summary>
        /// Prevent the value to be higher than max.
        /// </summary>
        public static double Max (this double d, double _max)
        {
            if (d > _max)
                return _max;
            else
                return d;
        }

        /// <summary>
        /// Force the value to be higher than 0
        /// </summary>
        public static double ZeroIfLess (this double d)
        {
            return d.Min (0);
        }

        /// <summary>
        /// Force the value to be lesser than 0
        /// </summary>
        public static double ZeroIfMore (this double d)
        {
            return d.Max (0);
        }
    }
}