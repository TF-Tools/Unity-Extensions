using UnityEngine;

namespace TFTools.Extensions
{
    public struct HSLColor
    {
        [SerializeField] public float hue;
        [SerializeField] public float saturation;
        [SerializeField] public float luminosity;

        #region Constructors

        public HSLColor (Color _color)
        {
            float r = _color.r / 255f;
            float g = _color.g / 255f;
            float b = _color.b / 255f;

            float cMax = Mathf.Max (r, g, b);
            float cMin = Mathf.Min (r, g, b);

            float delta = cMax - cMin;

            #region Hue

            if (delta == 0)
                hue = 0;
            else
            {
                if (cMax == r)
                    hue = 60f * (((g - b) / delta) % 6f);
                if (cMax == g)
                    hue = 60f * (((b - r) / delta) + 2f);
                else
                    hue = 60f * (((r - g) / delta) + 4f);
            }

            #endregion

            #region Luminosity

            luminosity = (cMax + cMin) / 2f;

            #endregion

            #region Saturation

            if (delta == 0f)
                saturation = 0f;
            else
                saturation = delta / (1f - Mathf.Abs ((2f * luminosity) - 1f));

            #endregion
        }

        #endregion

        public Color ToRGB ()
        {
            double dc = (2 * luminosity) - 1;
            dc = (double) Mathf.Abs ((float) dc);
            dc = (1 - dc) * saturation;
            float c = (float) dc;

            double dx = ((hue / 60) % 2) - 1;
            dx = (double) Mathf.Abs ((float) dx);
            dx = c * (1 - dx);
            float x = (float) dx;

            double dm = luminosity - (c / 2);
            float m = (float) dm;

            Color result;
            if (0f <= hue && hue < 60f)
                result = new Color (c, x, 0f);
            else if (60f <= hue && hue < 120f)
                result = new Color (x, c, 0f);
            else if (120f <= hue && hue < 180f)
                result = new Color (0f, c, x);
            else if (180f <= hue && hue < 240f)
                result = new Color (0f, x, c);
            else if (240f <= hue && hue < 300f)
                result = new Color (x, 0f, c);
            else
                result = new Color (c, 0f, x);

            result = new Color ((result.r + m) * 255f,
                                (result.g + m) * 255f,
                                (result.b + m) * 255f,
                                 1f
            );

            return result;
        }
    }
}