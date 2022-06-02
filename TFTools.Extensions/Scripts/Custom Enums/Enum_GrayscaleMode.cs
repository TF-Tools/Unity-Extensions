namespace TFTools.Extensions
{
    [System.Serializable]
    public enum Grayscalemode
    {
        /// <summary>
        /// The average method simply averages the values.
        /// </summary>
        Average,
        /// <summary>
        /// The lightness method averages the most prominent and least prominent colors.
        /// </summary>
        Lightness,
        /// <summary>
        /// The luminosity method averages the values, but it forms a weighted average to account for human perception. We’re more sensitive to green than other colors, so green is weighted most heavily.
        /// </summary>
        Luminosity
    }
}