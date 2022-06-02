using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Array
    {
        public static T [] Cast<T> (this Object [] _array) where T : Object
        {
            T [] output = new T [_array.Length];

            for (int i = 0; i < _array.Length; i++)
                output [i] = _array [i] as T;

            return output;
        }
    }
}