using System;
using System.Drawing;
using Size = LibGalaxyControls.Source.Json.SimpleObjects.Size;

namespace LibGalaxyControls.Source.Objects.Interfaces
{
    public interface ITextBoxTheme : ITheme
    {
        Color BackColor { get; set; }
        Color ForeColor { get; set; }
        String PlaceHolder { get; set; }
        String FontName { get; set; }
        Int32 FontSize { get; set; }
        Size Size { get; set; }
    }
}
