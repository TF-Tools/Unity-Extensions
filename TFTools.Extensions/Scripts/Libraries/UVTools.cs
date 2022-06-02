using System.Collections.Generic;

using UnityEngine;

namespace TFTools.Extensions
{
    public static class UVTools
    {
        public static void DrawUvs (Mesh _mesh, Texture2D _targetTexture, Color _color, int _uvChannel = 0)
        {
            List<Vector2> uvs = new ();
            _mesh.GetUVs (_uvChannel, uvs);

            if (uvs.Count == 0)
            {
                _targetTexture = new Texture2D (1, 1);
                return;
            }

            int [] tris = _mesh.triangles;

            float ratio = (_targetTexture.width - 1).ZeroIfLess ();
            for (int i = 0; i < tris.Length; i += 3)
            {
                Vector2Int p1 = new Vector2Int (
                                    (int) (uvs [tris [i]].x * ratio),
                                    (int) (-uvs [tris [i]].y * ratio)
                                );

                Vector2Int p2 = new Vector2Int (
                                    (int) (uvs [tris [i + 1]].x * ratio),
                                    (int) (-uvs [tris [i + 1]].y * ratio)
                                );

                Vector2Int p3 = new Vector2Int (
                                    (int) (uvs [tris [i + 2]].x * ratio),
                                    (int) (-uvs [tris [i + 2]].y * ratio)
                                );

                p1 = p1.AbsAll ();
                p2 = p2.AbsAll ();
                p3 = p3.AbsAll ();

                _targetTexture.DrawLine (p1, p2, _color);
                _targetTexture.DrawLine (p2, p3, _color);
                _targetTexture.DrawLine (p3, p1, _color);
            }
        }
    }
}