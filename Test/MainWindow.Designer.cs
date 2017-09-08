using LibGalaxyControls.CustomControls.Buttons;
using LibGalaxyControls.CustomControls.Forms;

namespace ThemeEditor
{
    partial class MainWindow : GalaxyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.FieldCmbx = new System.Windows.Forms.ComboBox();
            this.ValueTxb = new System.Windows.Forms.TextBox();
            this.ThemeCmbx = new System.Windows.Forms.ComboBox();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.FieldLabel = new System.Windows.Forms.Label();
            this.ControlCmbx = new System.Windows.Forms.ComboBox();
            this.ControlLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.LiveControlViewPanel = new System.Windows.Forms.Panel();
            this.NewThemeButton = new GalaxyButton();
            this.SaveButton = new GalaxyButton();
            this.LiveJsonViewer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FieldCmbx
            // 
            this.FieldCmbx.FormattingEnabled = true;
            this.FieldCmbx.Location = new System.Drawing.Point(8, 160);
            this.FieldCmbx.Name = "FieldCmbx";
            this.FieldCmbx.Size = new System.Drawing.Size(256, 21);
            this.FieldCmbx.TabIndex = 0;
            // 
            // ValueTxb
            // 
            this.ValueTxb.Location = new System.Drawing.Point(272, 160);
            this.ValueTxb.Name = "ValueTxb";
            this.ValueTxb.Size = new System.Drawing.Size(128, 20);
            this.ValueTxb.TabIndex = 1;
            // 
            // ThemeCmbx
            // 
            this.ThemeCmbx.FormattingEnabled = true;
            this.ThemeCmbx.Location = new System.Drawing.Point(8, 104);
            this.ThemeCmbx.Name = "ThemeCmbx";
            this.ThemeCmbx.Size = new System.Drawing.Size(256, 21);
            this.ThemeCmbx.TabIndex = 2;
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Location = new System.Drawing.Point(8, 80);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(40, 13);
            this.ThemeLabel.TabIndex = 3;
            this.ThemeLabel.Text = "Theme";
            // 
            // FieldLabel
            // 
            this.FieldLabel.AutoSize = true;
            this.FieldLabel.Location = new System.Drawing.Point(8, 136);
            this.FieldLabel.Name = "FieldLabel";
            this.FieldLabel.Size = new System.Drawing.Size(29, 13);
            this.FieldLabel.TabIndex = 4;
            this.FieldLabel.Text = "Field";
            // 
            // ControlCmbx
            // 
            this.ControlCmbx.FormattingEnabled = true;
            this.ControlCmbx.Location = new System.Drawing.Point(8, 32);
            this.ControlCmbx.Name = "ControlCmbx";
            this.ControlCmbx.Size = new System.Drawing.Size(392, 21);
            this.ControlCmbx.TabIndex = 5;
            // 
            // ControlLabel
            // 
            this.ControlLabel.AutoSize = true;
            this.ControlLabel.Location = new System.Drawing.Point(8, 16);
            this.ControlLabel.Name = "ControlLabel";
            this.ControlLabel.Size = new System.Drawing.Size(40, 13);
            this.ControlLabel.TabIndex = 6;
            this.ControlLabel.Text = "Control";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(272, 136);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(34, 13);
            this.ValueLabel.TabIndex = 7;
            this.ValueLabel.Text = "Value";
            // 
            // LiveControlViewPanel
            // 
            this.LiveControlViewPanel.Location = new System.Drawing.Point(408, 8);
            this.LiveControlViewPanel.Name = "LiveControlViewPanel";
            this.LiveControlViewPanel.Size = new System.Drawing.Size(512, 584);
            this.LiveControlViewPanel.TabIndex = 8;
            // 
            // NewThemeButton
            // 
            this.NewThemeButton.ButtonTheme = ((LibGalaxyControls.Source.Interfaces.IButtonTheme)(resources.GetObject("NewThemeButton.ButtonTheme")));
            this.NewThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewThemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.NewThemeButton.Location = new System.Drawing.Point(272, 104);
            this.NewThemeButton.Name = "NewThemeButton";
            this.NewThemeButton.Size = new System.Drawing.Size(128, 24);
            this.NewThemeButton.TabIndex = 9;
            this.NewThemeButton.Text = "Button";
            this.NewThemeButton.UseVisualStyleBackColor = false;
            this.NewThemeButton.Click += new System.EventHandler(this.NewThemeButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SaveButton.ButtonTheme = null;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Arial", 8F);
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SaveButton.Location = new System.Drawing.Point(8, 504);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(392, 80);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LiveJsonViewer
            // 
            this.LiveJsonViewer.Location = new System.Drawing.Point(8, 192);
            this.LiveJsonViewer.Name = "LiveJsonViewer";
            this.LiveJsonViewer.Size = new System.Drawing.Size(392, 304);
            this.LiveJsonViewer.TabIndex = 11;
            this.LiveJsonViewer.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(927, 598);
            this.Controls.Add(this.LiveJsonViewer);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewThemeButton);
            this.Controls.Add(this.LiveControlViewPanel);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.ControlLabel);
            this.Controls.Add(this.ControlCmbx);
            this.Controls.Add(this.FieldLabel);
            this.Controls.Add(this.ThemeLabel);
            this.Controls.Add(this.ThemeCmbx);
            this.Controls.Add(this.ValueTxb);
            this.Controls.Add(this.FieldCmbx);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Themer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FieldCmbx;
        private System.Windows.Forms.TextBox ValueTxb;
        private System.Windows.Forms.ComboBox ThemeCmbx;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.Label FieldLabel;
        private System.Windows.Forms.ComboBox ControlCmbx;
        private System.Windows.Forms.Label ControlLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Panel LiveControlViewPanel;
        private GalaxyButton NewThemeButton;
        private GalaxyButton SaveButton;
        private System.Windows.Forms.RichTextBox LiveJsonViewer;
    }
}

