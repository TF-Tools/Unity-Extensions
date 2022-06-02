using UnityEngine;

namespace TFTools.Extensions
{
    public static partial class Extensions_Color
    {
        #region Blend Modes

        /// <summary>
        /// Blend the two specified Colors together via the given blend BlendMode.
        /// </summary>
        public static Color Blend (this Color _bottomColor, Color _upperColor, ColorBlendMode _blendMode)
        {
            switch (_blendMode)
            {
                // Aplha Supported
                case (ColorBlendMode.Normal):
                    return Color.Lerp (_bottomColor, _upperColor, _upperColor.a).WithAlpha (_upperColor.a + _bottomColor.a);


                // FIXME / TODO : Support Alpha
                case (ColorBlendMode.Darken):
                    return new Color (
                        Mathf.Min (_bottomColor.r, _upperColor.r),
                        Mathf.Min (_bottomColor.g, _upperColor.g),
                        Mathf.Min (_bottomColor.b, _upperColor.b),
                        1f);


                // TODO : Support Apha
                case (ColorBlendMode.Multiply):
                    if (_upperColor.a > 0)
                        return (_bottomColor * _upperColor);
                    else
                        return _bottomColor;


                // TODO : Support Alpha
                case (ColorBlendMode.ColorBurn):
                    return Color.Lerp (_bottomColor, new Color (
                        1f - (1f - _bottomColor.r) / _upperColor.r,
                        1f - (1f - _bottomColor.g) / _upperColor.g,
                        1f - (1f - _bottomColor.b) / _upperColor.b,
                        1f), _upperColor.a);


                // TODO : Support ALpha
                case (ColorBlendMode.LinearBurn):
                    return Color.Lerp (_bottomColor, (_bottomColor + _upperColor - Color.white).WithAlpha (1f), _upperColor.a);


                // FIXME / TODO : Support Alpha
                case (ColorBlendMode.Lighten):
                    return new Color (
                        Mathf.Max (_bottomColor.r, _upperColor.r),
                        Mathf.Max (_bottomColor.g, _upperColor.g),
                        Mathf.Max (_bottomColor.b, _upperColor.b),
                        1f);


                // TODO : Support Apha
                case (ColorBlendMode.Screen):
                    return new Color (
                        1f - (1f - _bottomColor.r) * (1f - _upperColor.r),
                        1f - (1f - _bottomColor.g) * (1f - _upperColor.g),
                        1f - (1f - _bottomColor.b) * (1f - _upperColor.b),
                        1f);


                // TODO : Support Apha
                case (ColorBlendMode.ColorDodge):
                    return new Color (
                        _bottomColor.r / (1f - _upperColor.r),
                        _bottomColor.g / (1f - _upperColor.g),
                        _bottomColor.b / (1f - _upperColor.b),
                        1f);


                // TODO : Support Apha
                case (ColorBlendMode.LinearDodge):
                    return (_bottomColor + _upperColor).WithAlpha (1f);


                // TODO : Support Alpha
                case (ColorBlendMode.Overlay):
                    return new Color (
                        GetOverlayValue (_bottomColor.r, _upperColor.r),
                        GetOverlayValue (_bottomColor.g, _upperColor.g),
                        GetOverlayValue (_bottomColor.b, _upperColor.b),
                        1f);


                // TODO : Support Alpha
                case (ColorBlendMode.SoftLightPs):
                    return new Color (
                        GetSoftLightPsValue (_bottomColor.r, _upperColor.r),
                        GetSoftLightPsValue (_bottomColor.g, _upperColor.g),
                        GetSoftLightPsValue (_bottomColor.b, _upperColor.b),
                        1f);


                // TODO : Support Alpha
                case (ColorBlendMode.HardLight):
                    return _upperColor.Blend (_bottomColor, ColorBlendMode.Overlay);


                // FIXME / TODO : Support Alpha
                case (ColorBlendMode.VividLight):
                    return new Color (
                        GetVividLightValue (_bottomColor.r, _upperColor.r),
                        GetVividLightValue (_bottomColor.g, _upperColor.g),
                        GetVividLightValue (_bottomColor.b, _upperColor.b),
                        1f);


                // TODO : Support Alpha
                case (ColorBlendMode.LinearLight):
                    return new Color (
                        GetLinearLightValue (_bottomColor.r, _upperColor.r),
                        GetLinearLightValue (_bottomColor.g, _upperColor.g),
                        GetLinearLightValue (_bottomColor.b, _upperColor.b),
                        1f);


                // TODO : Support Alpha
                case (ColorBlendMode.PinLight):
                    return new Color (
                        GetPinLightValue (_bottomColor.r, _upperColor.r),
                        GetPinLightValue (_bottomColor.g, _upperColor.g),
                        GetPinLightValue (_bottomColor.b, _upperColor.b),
                        1f);


                // FIXME / TODO : Support Alpha
                case (ColorBlendMode.HardMix):
                    return new Color (
                        GetHardMixValue (_bottomColor.r, _upperColor.r),
                        GetHardMixValue (_bottomColor.g, _upperColor.g),
                        GetHardMixValue (_bottomColor.b, _upperColor.b),
                        1f);


                // TODO : Support Alpha
                case (ColorBlendMode.Difference):
                    return new Color (
                        Mathf.Abs (_bottomColor.r - _upperColor.r),
                        Mathf.Abs (_bottomColor.g - _upperColor.g),
                        Mathf.Abs (_bottomColor.b - _upperColor.b),
                        1f);


                // TODO : Support Alpha
                case (ColorBlendMode.Exclusion):
                    return new Color (
                        0.5f - 2f * (_bottomColor.r - 0.5f) * (_upperColor.r - 0.5f),
                        0.5f - 2f * (_bottomColor.g - 0.5f) * (_upperColor.g - 0.5f),
                        0.5f - 2f * (_bottomColor.b - 0.5f) * (_upperColor.b - 0.5f),
                        1f);


                // TODO : Support Alpha
                case (ColorBlendMode.Substract):
                    return (_bottomColor - _upperColor).WithAlpha (1f);


                // TODO : Support Alpha
                case (ColorBlendMode.Divide):
                    return new Color (
                        _bottomColor.r / _upperColor.r,
                        _bottomColor.g / _upperColor.g,
                        _bottomColor.b / _upperColor.b,
                        1f);


                // TODO : Support Alpha
                case (ColorBlendMode.Hue):
                    return GetHSLHUEValue (_bottomColor, _upperColor);


                // TODO : Support Alpha
                case (ColorBlendMode.Saturation):
                    return GetHSLSaturationValue (_bottomColor, _upperColor);


                // TODO : Support Alpha
                case (ColorBlendMode.Color):
                    return GetHSLColorValue (_bottomColor, _upperColor);


                // TODO : Support Alpha
                case (ColorBlendMode.Luminosity):
                    return GetHSLLuminosityValue (_bottomColor, _upperColor);
            }

            return Color.white;
        }

        #region Blend Utilities

        /// <summary>
        /// Get the Overlay value of the two given chanels.
        /// </summary>
        static float GetOverlayValue (float _bottom, float _upper)
        {
            if (_bottom > 0.5f)
                return 1f - (1f - 2f * (_bottom - 0.5f)) * (1f - _upper);
            else
                return 2f * _bottom * _upper;
        }

        /// <summary>
        /// Get the Soft Light value of the two given chanels.
        /// </summary>
        static float GetSoftLightPsValue (float _bottom, float _upper)
        {
            if (_upper < 0.5f)
                return 2f * _bottom * _upper + _bottom * _bottom * (1f - 2f * _upper);
            else
                return 2f * _bottom * (1f - _upper) + Mathf.Sqrt (_bottom) * (2f * _upper - 1f);
        }

        /// <summary>
        /// Get the Vivid Light value of the two given chanels.
        /// </summary>
        static float GetVividLightValue (float _bottom, float _upper)
        {
            if (_upper > 0.5f)
                return 1f - (1f - _bottom) / (2f * (_upper - 0.5f));
            else
                return _bottom / (1f - 2f * _upper);
        }

        /// <summary>
        /// Get the Linear Light value of the two given chanels.
        /// </summary>
        static float GetLinearLightValue (float _bottom, float _upper)
        {
            if (_upper > 0.5f)
                return _bottom + 2f * (_upper - 0.5f);
            else
                return _bottom + 2f * _upper - 1f;
        }

        /// <summary>
        /// Get the Pin Light value of the two given chanels.
        /// </summary>
        static float GetPinLightValue (float _bottom, float _upper)
        {
            if (_upper > 0.5f)
                return Mathf.Max (_bottom, 2f * (_upper - 0.5f));
            else
                return Mathf.Min (_bottom, 2f * _upper);
        }

        /// <summary>
        /// Get the Hard Mix value of the two given chanels.
        /// </summary>
        static float GetHardMixValue (float _bottom, float _upper)
        {
            return Mathf.Clamp01 (Mathf.RoundToInt (GetLinearLightValue (_bottom, _upper)));
        }

        static Color GetHSLHUEValue (Color _bottom, Color _upper)
        {
            HSLColor bottomHSV = new HSLColor (_bottom);
            HSLColor upperHSV = new HSLColor (_upper);

            HSLColor result = new HSLColor ();

            result.hue = upperHSV.hue;
            result.saturation = bottomHSV.saturation;
            result.luminosity = bottomHSV.luminosity;

            return result.ToRGB ();
        }

        static Color GetHSLSaturationValue (Color _bottom, Color _upper)
        {
            HSLColor bottomHSV = new HSLColor (_bottom);
            HSLColor upperHSV = new HSLColor (_upper);

            HSLColor result = new HSLColor ();

            result.hue = bottomHSV.hue;
            result.saturation = upperHSV.saturation;
            result.luminosity = bottomHSV.luminosity;

            return result.ToRGB ();
        }

        static Color GetHSLColorValue (Color _bottom, Color _upper)
        {
            HSLColor bottomHSV = new HSLColor (_bottom);
            HSLColor upperHSV = new HSLColor (_upper);

            HSLColor result = new HSLColor ();

            result.hue = upperHSV.hue;
            result.saturation = upperHSV.saturation;
            result.luminosity = bottomHSV.luminosity;

            return result.ToRGB ();
        }

        static Color GetHSLLuminosityValue (Color _bottom, Color _upper)
        {
            HSLColor bottomHSV = new HSLColor (_bottom);
            HSLColor upperHSV = new HSLColor (_upper);

            HSLColor result = new HSLColor ();

            result.hue = bottomHSV.hue;
            result.saturation = bottomHSV.saturation;
            result.luminosity = upperHSV.luminosity;

            return result.ToRGB ();
        }

        #endregion

        #endregion

        /// <summary>
        /// Return the grayscale value of the color via the given grayscale mode.
        /// </summary>
        public static float ToGrayscale (this Color _color, Grayscalemode _grayscaleMode = Grayscalemode.Average)
        {
            switch (_grayscaleMode)
            {
                case (Grayscalemode.Average):
                    return (_color.r + _color.g + _color.b) / 3f;
                case (Grayscalemode.Lightness):
                    return (Mathf.Max (_color.r, _color.g, _color.b) + Mathf.Min (_color.r, _color.g, _color.b)) / 2f;
                case (Grayscalemode.Luminosity):
                    return (0.21f * _color.r) + (0.72f * _color.g) + (0.07f * _color.b);
            }

            return 0f;
        }
    }
}