using System;
using System.ComponentModel;
using System.Globalization;
using LibGalaxyControls.Source.Objects.Interfaces;

namespace LibGalaxyControls.Source.TypeConverters
{
    public class ThemeConverter : System.ComponentModel.TypeConverter
    {
        /// <summary>
        /// Check if the type requested can be converted to type
        /// </summary>
        /// <param name="context">The context</param>
        /// <param name="destinationType">The type to check against</param>
        /// <returns></returns>
        public override Boolean CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return typeof(String) == destinationType;
        }

        /// <summary>
        /// To convert the object to the display string
        /// </summary>
        /// <param name="context">Descriptor Context</param>
        /// <param name="culture">Culture info</param>
        /// <param name="value">The object to convert</param>
        /// <param name="destinationType">The destination type</param>
        /// <returns></returns>
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
