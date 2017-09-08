using System;
using System.Collections.Generic;

namespace LibGalaxyControls.Source.Json.ThemeObjects
{
   
    public class TextFieldThemes
    {
        public List<JsonTextFieldTheme> Themes { get; set; }
    }

    public class JsonTextFieldTheme
    {
        public String Name { get; set; }
        public String BackColor { get; set; }
        public String ForeColor { get; set; }
        public String BorderColor { get; set; }
        public String FontName { get; set; }
        public Int32 FontSize { get; set; }
    }
}
