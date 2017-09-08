using System;
using System.Drawing;

namespace LibGalaxyControls.Source.StaticConverters
{
    public static class ColorConverter
    {
        public static Color GetColor(this String colorString)
        {
            return ColorTranslator.FromHtml(colorString);
        }
    }
}
