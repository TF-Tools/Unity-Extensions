using System.Collections.Generic;

namespace TFTools.Extensions
{
    public static partial class Extensions_List
    {
        /// <summary>
        /// Add an object to the end of the List<T>.
        /// </summary>
        public static List<T> Add<T> (this List<T> _list, T _element, bool _preventDuplicate)
        {
            if (!_preventDuplicate || !_list.Contains (_element))
                _list.Add (_element);

            return _list;
        }

        /// <summary>
        /// Add the specified list to the baseList.
        /// </summary>
        public static List<T> Add<T> (this List<T> _list, List<T> _listToAdd, bool _preventDuplicate = false)
        {
            foreach (T element in _listToAdd)
                _list.Add (element, _preventDuplicate);

            return _list;
        }

        /// <summary>
        /// Add the specified array to the baseList.
        /// </summary>
        public static List<T> Add<T> (this List<T> _list, T [] _array, bool _preventDuplicate = false)
        {
            foreach (T element in _array)
                _list.Add (element, _preventDuplicate);

            return _list;
        }

        /// <summary>
        /// Move an element in list to a different index.
        /// </summary>
        public static void MoveElement<T> (this List<T> _list, int _oldIndex, ref int _newIndex)
        {
            T element = _list [_oldIndex];

            _list.RemoveAt (_oldIndex);

            _newIndex = _newIndex.Max (_list.Count);
            _list.Insert (_newIndex, element);
        }
    }
}