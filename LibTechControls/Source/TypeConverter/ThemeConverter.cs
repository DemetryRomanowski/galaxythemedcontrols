using System;
using System.ComponentModel;
using System.Globalization;
using LibGalaxyControls.Source.Interfaces;

namespace LibGalaxyControls.Source.TypeConverter
{
    public class ThemeConverter : System.ComponentModel.TypeConverter
    {
        public override Boolean CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return typeof(String) == destinationType;
        }

        public override Object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, Object value, Type destinationType)
        {
            if (typeof(String) == destinationType)
            {
                if (value is ITheme theme)
                    return theme.Name; 
            }

            return "(None)";
        }
    }
}
