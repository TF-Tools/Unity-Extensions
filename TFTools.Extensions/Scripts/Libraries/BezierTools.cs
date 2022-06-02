using System.Collections.Generic;

using UnityEngine;

namespace TFTools.Extensions
{
    public static class BezierTools
    {
        public static Vector3 GetPoint (Vector3 _p0, Vector3 _p1, Vector3 _p2, Vector3 _p3, float _t)
        {
            _t = Mathf.Clamp01 (_t);
            float oneMinusT = 1f - _t;
            return
            oneMinusT * oneMinusT * oneMinusT * _p0 +
            3f * oneMinusT * oneMinusT * _t * _p1 +
            3f * oneMinusT * _t * _t * _p2 +
            _t * _t * _t * _p3;
        }

        public static Vector3 GetFirstDerivative (Vector3 _p0, Vector3 _p1, Vector3 _p2, Vector3 _p3, float _t)
        {
            _t = Mathf.Clamp01 (_t);
            float oneMinusT = 1f - _t;
            return
            3f * oneMinusT * oneMinusT * (_p1 - _p0) +
            6f * oneMinusT * _t * (_p2 - _p1) +
            3f * _t * _t * (_p3 - _p2);
        }
    }
}