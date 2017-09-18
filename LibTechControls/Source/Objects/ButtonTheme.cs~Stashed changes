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
    public class ButtonTheme : Theme, IButtonTheme
    {
        public static ButtonTheme ButtonThemeSingleton { get; set; } = new ButtonTheme();

        /// <summary>
        /// Default ctor
        /// </summary>
        public ButtonTheme() { }

        /// <summary>
        /// Override ctor
        /// Used when passing in JsonButtonTheme objects after deserialization
        /// </summary>
        /// <param name="converted">The json color theme object</param>
        public ButtonTheme(JsonButtonTheme converted)
        {
            this.Name = converted.Name;
            this.BackColor = converted.BackColor.GetColor();
            this.ForeColor = converted.ForeColor.GetColor();
            this.BorderColor = converted.BorderColor.GetColor();
            this.MouseDownColor = converted.MouseDownColor.GetColor();
            this.MouseOverColor = converted.MouseOverColor.GetColor();
            this.FontName = converted.FontName;
            this.FontSize = converted.FontSize;
            this.UseResourceForImage = converted.UseResourceForImage;
            this.ImagePath = converted.ImagePath;
            this.TextAlignment = converted.TextAlignment;
            this.ButtonName = converted.ButtonName;
            this.ButtonText = converted.ButtonText;
            this.Size = converted.Size;

            ButtonThemeSingleton = this;
        }

        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
        public Color BorderColor { get; set; }
        public Color MouseDownColor { get; set; }
        public Color MouseOverColor { get; set; }
        public String FontName { get; set; }
        public Int32 FontSize { get; set; }
        public Boolean UseResourceForImage { get; set; }
        public String ImagePath { get; set; }
        public String TextAlignment { get; set; }
        public String ButtonName { get; set; }
        public String ButtonText { get; set; }
        public Size Size { get; set; }

        internal override List<IButtonTheme> GetAllThemes()
        {
            return AvailableJsonColorThemes.Select(availableJsonColorTheme => (IButtonTheme)new ButtonTheme(availableJsonColorTheme)).ToList();
        }
    }
}
