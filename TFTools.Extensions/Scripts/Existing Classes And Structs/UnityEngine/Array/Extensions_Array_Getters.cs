namespace TFTools.Extensions
{
    public static partial class Extensions_Array
    {
        public static int LastIndex<T> (this T [] _array)
        {
            return _array.Length - 1;
        }

        public static T Last<T> (this T [] _array)
        {
            return _array [_array.LastIndex ()];
        }
    }
}