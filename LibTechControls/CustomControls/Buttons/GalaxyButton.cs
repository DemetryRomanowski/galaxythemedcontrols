using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Resources;
using System.Windows.Forms;
using LibGalaxyControls.Source.Objects;
using LibGalaxyControls.Source.Objects.DesignerEditor;
using LibGalaxyControls.Source.Objects.Interfaces;

namespace LibGalaxyControls.CustomControls.Buttons
{
    [ToolboxItem(true), Category("TechGalaxy Controls"), ToolboxBitmap(typeof(Button))]
    public class GalaxyButton : Button
    {
        #region PrivateMembers
        private IButtonTheme b_ButtonTheme { get; set; }
        #endregion
        
        #region DesignerProperties
        
        /// <summary>
        /// New designer property to modify the color theme from the themes.json
        /// </summary>
        [Category("Appearance")]
        [Description("The color to use from the themes.json file")]
        [Editor(typeof(ButtonThemeSelector), typeof(UITypeEditor))]
        [Browsable(true)]
        [MergableProperty(true)]
        public IButtonTheme ButtonTheme {
            get => b_ButtonTheme;
            set
            {
                b_ButtonTheme = value;
                ThemeChanged(b_ButtonTheme);
            } }

        [Browsable(false)]
        public List<IButtonTheme> ColorThemes { get; private set; } = new List<IButtonTheme>();
        
        #endregion

        #region PublicMembers
        
        /// <inheritdoc />
        /// <summary>
        /// Overriding the back color of the button to modify all other colors accordingly
        /// </summary>
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                this.FlatAppearance.BorderColor = value;

                base.BackColor = value;
            }
        }
        
        #endregion
        
        #region Constructors
        
        /// <inheritdoc />
        /// <summary>
        /// New constructor to apply the flatstyle to the button always
        /// </summary>
        public GalaxyButton()
            : base()
        {
            foreach (IButtonTheme colorTheme in Source.Objects.ButtonTheme.ButtonThemeSingleton.GetAllThemes())
            {
                ButtonTheme theme = (ButtonTheme) colorTheme;

                this.ColorThemes.Add(theme);
            }

            ThemeChanged(Source.Objects.ButtonTheme.ButtonThemeSingleton.GetAllThemes()[0]);

            this.FlatStyle = FlatStyle.Flat;
        }

        #endregion

        #region HelperFunctions
        
        /// <summary>
        /// Callback when a theme is changed
        /// </summary>
        private void ThemeChanged(IButtonTheme newTheme)
        {
            try
            {
                this.BackColor = newTheme.BackColor;
                base.ForeColor = newTheme.ForeColor;
                this.FlatAppearance.BorderColor = newTheme.BorderColor;
                this.FlatAppearance.MouseDownBackColor = newTheme.MouseDownColor;
                this.FlatAppearance.MouseOverBackColor = newTheme.MouseOverColor;

                if (newTheme.TextAlignment != null)
                {
                    switch (newTheme.TextAlignment)
                    {
                        case "TopLeft" : this.TextAlign = ContentAlignment.TopLeft;
                            break;
                        case "TopRight": this.TextAlign = ContentAlignment.TopRight;
                            break;
                        case "Left": this.TextAlign = ContentAlignment.MiddleLeft;
                            break;
                        case "Right": this.TextAlign = ContentAlignment.MiddleRight;
                            break;
                        case "BottomLeft": this.TextAlign = ContentAlignment.BottomLeft;
                            break;
                        case "BottomRight": this.TextAlign = ContentAlignment.BottomRight;
                            break;
                        case "Center": this.TextAlign = ContentAlignment.MiddleCenter;
                            break;
                        case "TopCenter": this.TextAlign = ContentAlignment.TopCenter;
                            break;
                        case "BottomCenter": this.TextAlign = ContentAlignment.BottomCenter;
                            break;
                        default: MessageBox.Show(@"Text align did not match any possible alignments");
                            break;
                    }
                }

                if (newTheme.FontName != null && newTheme.FontSize > 4)
                    this.Font = new Font(newTheme.FontName, newTheme.FontSize, FontStyle.Regular);

                if (newTheme.ImagePath != null)
                {
                    if (newTheme.UseResourceForImage)
                    {
                        try
                        {
                            ResourceManager rm = Resources.ResourceManager;
                            this.Image = (Bitmap) rm.GetObject(newTheme.ImagePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(@"Error with the theme: \n" + ex.StackTrace);
                            this.Image = null;
                        }
                    }
                    else
                    {
                        this.Image = Image.FromFile(newTheme.ImagePath);
                    }
                }

                if (newTheme.ButtonName != null)
                    this.Name = newTheme.ButtonName;

                if (newTheme.ButtonText != null)
                    this.Text = newTheme.ButtonText;

                if (newTheme.Size != null)
                    this.Size = new Size(newTheme.Size.Width, newTheme.Size.Height);
            }
            catch 
            {
                //Unhandled
            }

            this.ColorThemes.Clear();

            foreach (IButtonTheme colorTheme in Source.Objects.ButtonTheme.ButtonThemeSingleton.GetAllThemes())
            {
                ButtonTheme theme = (ButtonTheme)colorTheme;

                this.ColorThemes.Add(theme);
            }
        }

        #endregion

        #region Overrides 
        
        /// <inheritdoc />
        /// <summary>
        /// Override mouse enter to change the border color when mouse enters 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            this.FlatAppearance.BorderColor = this.FlatAppearance.MouseOverBackColor;
        }

        /// <inheritdoc />
        /// <summary>
        /// Override mouse leave to change the border color when mouse leaves
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            this.FlatAppearance.BorderColor = this.BackColor;
        }
        
        #endregion

    }
}
