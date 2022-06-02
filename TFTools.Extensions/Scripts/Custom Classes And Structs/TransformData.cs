using UnityEngine;

namespace TFTools.Extensions
{
    [System.Serializable]
    public class TransformData
    {
        [SerializeField] public string name;
        [SerializeField] Vector3 position;
        [SerializeField] Quaternion rotation;
        [SerializeField] Vector3 scale;

        [SerializeField] Transform parent;

        #region Constructors

        public TransformData (Transform _source)
        {
            Record (_source);
        }

        #endregion

        public void Record (Transform _source)
        {
            name = _source.name;

            position = _source.position;
            rotation = _source.rotation;
            scale = _source.localScale;

            parent = _source.parent;
        }

        public void ApplyTo (Transform _target, bool _alsoApplyParent = false)
        {
            _target.position = position;
            _target.rotation = rotation;
            _target.localScale = scale;

            if (_alsoApplyParent)
                _target.parent.SetParent (parent);
        }

        #region Getter / Setter

        public Vector3 Forward
        {
            get => rotation.GetForwardVector ();
        }

        public Vector3 Right
        {
            get => rotation.GetRightVector ();
        }

        public Vector3 Up
        {
            get => rotation.GetUpVector ();
        }

        #endregion
    }
}