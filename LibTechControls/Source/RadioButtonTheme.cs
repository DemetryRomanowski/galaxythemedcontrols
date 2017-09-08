
using System;
using System.Collections.Generic;
using System.Drawing;
using LibGalaxyControls.Source.Interfaces;
using Size = LibGalaxyControls.Source.Json.SimpleObjects.Size;

namespace LibGalaxyControls.Source
{
    public class RadioButtonTheme : Theme, IRadioButtonTheme
    {

        public RadioButtonTheme()
        {
            
        }

        internal override List<IButtonTheme> GetAllThemes()
        {
            throw new System.NotImplementedException();
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
