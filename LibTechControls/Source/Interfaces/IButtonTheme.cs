using System;
using System.ComponentModel;
using System.Drawing;
using LibGalaxyControls.Source.TypeConverter;

using Size = LibGalaxyControls.Source.Json.SimpleObjects.Size;

namespace LibGalaxyControls.Source.Interfaces
{
    [TypeConverter(typeof(ThemeConverter))]
    public interface IButtonTheme : ITheme
    {
        Color BackColor { get; set; }
        Color ForeColor { get; set; }
        Color BorderColor { get; set; }
        Color MouseDownColor { get; set; }
        Color MouseOverColor { get; set; }
        String FontName { get; set; }
        Int32 FontSize { get; set; }
        Boolean UseResourceForImage { get; set; }
        String ImagePath { get; set; }
        String TextAlignment { get; set; }
        String ButtonName { get; set; }
        String ButtonText { get; set; }
        Size Size { get; set; }
    }

}
