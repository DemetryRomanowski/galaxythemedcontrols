using System;
using System.Collections.Generic;
using LibGalaxyControls.Source.Json.SimpleObjects;

namespace LibGalaxyControls.Source.Json.ThemeObjects
{
   
    public class TextBoxThemes
    {
        public List<JsonTextBoxTheme> Themes { get; set; }
    }

    public class JsonTextBoxTheme
    {
        public String Name { get; set; }
        public String BackColor { get; set; }
        public String ForeColor { get; set; }
        public String PlaceHolder { get; set; }
        public String FontName { get; set; }
        public Int32 FontSize { get; set; }
        public Size Size { get; set; }
    }
}
