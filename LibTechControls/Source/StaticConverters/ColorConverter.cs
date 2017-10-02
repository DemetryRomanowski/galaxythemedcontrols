using System;
using System.Drawing;

namespace LibGalaxyControls.Source.StaticConverters
{
    public static class ColorConverter
    {
        /// <summary>
        /// Static extension helper method to convert html string to Win32 Color
        /// </summary>
        /// <param name="colorString">The color string to convert</param>
        /// <returns></returns>
        public static Color GetColor(this String colorString)
        {
            return ColorTranslator.FromHtml(colorString);
        }
    }
}
