using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using LibGalaxyControls.Source.Objects;
using LibGalaxyControls.Source.Objects.DesignerEditor;
using LibGalaxyControls.Source.Objects.Interfaces;

using static LibGalaxyControls.Source.Objects.RadioButtonTheme;

namespace LibGalaxyControls.CustomControls.Buttons
{
    [ToolboxItem(true), Category("TechGalaxy Controls"), ToolboxBitmap(typeof(RadioButton))]
    public class GalaxyRadioButton : RadioButton
    {
        #region PrivateMembers
        private IRadioButtonTheme b_RadioButtonTheme;
        #endregion

        #region DesignerProperties
        /// <summary>
        /// New designer property to modify the color theme from the themes.json
        /// </summary>
        [Category("Appearance")]
        [Description("The color to use from the themes.json file")]
        [Editor(typeof(RadioButtonThemeSelector), typeof(UITypeEditor))]
        [Browsable(true)]
        [MergableProperty(true)]
        public IRadioButtonTheme ButtonTheme
        {
            get => b_RadioButtonTheme;
            set
            {
                b_RadioButtonTheme = value;
                ThemeChanged(b_RadioButtonTheme);
            }
        }

        [Browsable(false)]
        public List<IRadioButtonTheme> ColorThemes { get; private set; } = new List<IRadioButtonTheme>();
        #endregion

        #region PublicMemebers

        public override Color BackColor { get; set; }

        #endregion

        #region Constructors

        public GalaxyRadioButton()
            : base()
        {
            foreach (ITheme colorTheme in RadioButtonThemeSingleton.GetAllThemes())
            {
                RadioButtonTheme theme = (RadioButtonTheme)colorTheme;

                this.ColorThemes.Add(theme);
            }

            ThemeChanged(RadioButtonThemeSingleton.GetAllThemes()[0]);

            this.FlatStyle = FlatStyle.Flat;
        }

        #endregion

        #region HelperMethods

        private void ThemeChanged(ITheme theme)
        {
                
        }
        
        #endregion

    }
}
