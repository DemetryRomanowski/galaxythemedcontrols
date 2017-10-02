using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using LibGalaxyControls.Source.Objects;
using LibGalaxyControls.Source.Objects.DesignerEditor;
using LibGalaxyControls.Source.Objects.Interfaces;

using static LibGalaxyControls.Source.Objects.TextBoxTheme;

namespace LibGalaxyControls.CustomControls.Fields
{
    [ToolboxItem(true), Category("TechGalaxy Controls"), ToolboxBitmap(typeof(TextBox))]
    public class GalaxyTextBox : TextBox
    {
        #region PrivateMembers
        private ITextBoxTheme t_TextBoxTheme;
        private String t_PlaceHolder;
        #endregion

        #region PublicMembers
        public new Boolean Focused { get; set; }
        #endregion

        #region Events
        public delegate void FocusedChanged();
        public event FocusedChanged OnFocusedChanged; 
        #endregion

        #region DesignerProperties
        /// <summary>
        /// New designer property to modify the color theme from the themes.json
        /// </summary>
        [Category("Appearance")]
        [Description("The color to use from the themes.json file")]
        [Editor(typeof(TextBoxThemeSelector), typeof(UITypeEditor))]
        [Browsable(true)]
        [MergableProperty(true)]
        public ITextBoxTheme TextBoxTheme
        {
            get => t_TextBoxTheme;
            set
            {
                t_TextBoxTheme = value;
                ThemeChanged(t_TextBoxTheme);
            }
        }

        [Browsable(false)]
        public List<ITextBoxTheme> ColorThemes { get; private set; } = new List<ITextBoxTheme>();

        [Category("Appearance")]
        [Description("The theme to use from the themes.json file")]
        public String PlaceHolder
        {
            get => t_PlaceHolder;
            set
            {
                this.Text = value;
                t_PlaceHolder = value;
            }
        }
        #endregion

        #region Overrides
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            this.Focused = true;
            OnFocusedChanged?.Invoke();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);

            this.Focused = false;
            OnFocusedChanged?.Invoke();
        }
        #endregion

        #region Constructors
        public GalaxyTextBox()
            : base()
        {
            OnFocusedChanged += Text_OnFocusedChanged;

            if (TextBoxThemeSingleton?.GetAllThemes() != null)
            {
            
                foreach (ITheme colorTheme in TextBoxThemeSingleton.GetAllThemes())
                {
                    TextBoxTheme theme = (TextBoxTheme) colorTheme;
            
                    this.ColorThemes.Add(theme);
                }
            
                ThemeChanged(TextBoxThemeSingleton.GetAllThemes()[0]);
            }
        }
        #endregion

        #region HelperMethods
        private void ThemeChanged(ITheme theme)
        {
            TextBoxTheme newTheme = (TextBoxTheme)theme;

            try
            {
                this.BackColor = newTheme.BackColor;
                this.ForeColor = newTheme.ForeColor;

                if(newTheme.FontName != null && newTheme.Size.Height != null)
                this.Font = new Font(newTheme.FontName, (Int32)newTheme.Size.Height);

                if(newTheme.Size.Width != null)
                this.Width = (Int32)newTheme.Size.Width;

                this.BorderStyle = BorderStyle.None;
            }
            catch {/*unhandled*/}

        }
        #endregion

        #region EventHandlers
        private void Text_OnFocusedChanged()
        {
            this.Text = base.Focused ? "" : PlaceHolder;

            Console.WriteLine(base.Focused);
        }
        #endregion
    }
}
