using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using LibGalaxyControls.Source.Json.ThemeObjects;
using LibGalaxyControls.Source.Objects.BaseObject;
using LibGalaxyControls.Source.Objects.Interfaces;
using LibGalaxyControls.Source.StaticConverters;
using Size = LibGalaxyControls.Source.Json.SimpleObjects.Size;

namespace LibGalaxyControls.Source.Objects
{
    [Serializable]
    public class TextBoxTheme : Theme, ITextBoxTheme
    {
        public static TextBoxTheme TextBoxThemeSingleton { get; set; } = new TextBoxTheme();

        public TextBoxTheme() { }

        public TextBoxTheme(JsonTextBoxTheme converted)
        {
            this.BackColor = converted.BackColor.GetColor();
            this.ForeColor = converted.ForeColor.GetColor();
            this.PlaceHolder = converted.PlaceHolder;
            this.FontName = FontName;
            this.FontSize = FontSize;
            this.Size = Size;
        }

        internal override List<ITheme> GetAllThemes()
        {
            return AvailableJsonTextBoxThemes.Select(availableJsonColorTheme => (ITheme)new TextBoxTheme(availableJsonColorTheme)).ToList();
        }

        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
        public String PlaceHolder { get; set; }
        public String FontName { get; set; }
        public Int32 FontSize { get; set; }
        public Size Size { get; set; }
    }
}
