using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using LibGalaxyControls.Source.Json.ThemeObjects;
using LibGalaxyControls.Source.Objects.BaseObject;
using LibGalaxyControls.Source.Objects.Interfaces;
using Size = LibGalaxyControls.Source.Json.SimpleObjects.Size;

namespace LibGalaxyControls.Source.Objects
{
    [Serializable]
    public class RadioButtonTheme : Theme, IRadioButtonTheme
    {

        public static RadioButtonTheme RadioButtonThemeSingleton { get; set; } = new RadioButtonTheme();

        /// <summary>
        /// Default ctor
        /// </summary>
        public RadioButtonTheme() { }

        public RadioButtonTheme(JsonRadioButtonTheme converted)
        {
            
        }

        /// <inheritdoc />
        /// <summary>
        /// Return all the radio button themes
        /// </summary>
        /// <returns></returns>
        internal override List<ITheme> GetAllThemes()
        {
            return AvailableJsonRadioButtonThemes.Select(availableJsonColorTheme => (ITheme)new RadioButtonTheme(availableJsonColorTheme)).ToList();
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
    }
}
