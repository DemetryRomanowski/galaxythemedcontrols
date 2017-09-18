using System;
using System.Collections.Generic;
using LibGalaxyControls.Source.Objects.BaseObject;
using LibGalaxyControls.Source.Objects.Interfaces;

namespace LibGalaxyControls.Source.Objects
{
    [Serializable]
    public class TextBoxTheme : Theme, ITextFieldTheme
    {
        internal override List<IButtonTheme> GetAllThemes()
        {
            throw new NotImplementedException();
        }
    }
}
