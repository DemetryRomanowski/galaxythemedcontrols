using System;
using System.Collections.Generic;
using LibGalaxyControls.Source.Json.SimpleObjects;

namespace LibGalaxyControls.Source.Json.ThemeObjects
{
    
    public class RadioButtonThemes
    {
        private List<JsonRadioButtonTheme> Themes { get; set; }
    }

    public class JsonRadioButtonTheme
    {
        public String Name { get; set; }
        public String BackColor { get; set; }
        public String ForeColor { get; set; }
        public String BorderColor { get; set; }
        public String MouseDownColor { get; set; }
        public String MouseOverColor { get; set; }
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
