using System;
using System.Windows.Forms;

namespace LibGalaxyControls.CustomControls.Forms
{
    public class GalaxyForm : Form 
    {
        public GalaxyForm()
            : base()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.DoubleBuffered = true; 
        }
    }
}
