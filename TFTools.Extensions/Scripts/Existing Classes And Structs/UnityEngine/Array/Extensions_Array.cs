using System;

namespace TFTools.Extensions
{
    public static partial class Extensions_Array
    {
        /// <summary>
        /// Resize the specified array to match the specified newSize.
        /// </summary>
        public static T [] Resize<T> (this T [] _array, int _newSize)
        {
            Array.Resize (ref _array, _newSize);

            return _array;
        }
    }
}