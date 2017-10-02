using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using LibGalaxyControls.CustomControls.Fields;
using LibGalaxyControls.Source.Objects.Interfaces;

namespace LibGalaxyControls.Source.Objects.DesignerEditor
{
    public class TextBoxThemeSelector : UITypeEditor
    {
        private IWindowsFormsEditorService wf_editorService;

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override Object EditValue(ITypeDescriptorContext context, IServiceProvider provider, Object value)
        {
            if (provider != null)
                wf_editorService = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            else
                return value;

            // use a list box
            ListBox lb = new ListBox
            {
                SelectionMode = SelectionMode.One
            };

            lb.SelectedValueChanged += OnListBoxSelectedValueChanged;

            // use the IBenchmark.Name property for list box display
            lb.DisplayMember = "Name";

            if (context != null)
            {
                GalaxyTextBox button = (GalaxyTextBox)context.Instance;
                foreach (ITextBoxTheme th in button.ColorThemes)
                {
                    Int32 index = lb.Items.Add(th);

                    if (th.Equals(value))
                        lb.SelectedIndex = index;
                }
            }

            wf_editorService.DropDownControl(lb);

            return lb.SelectedItem ?? value;
        }

        private void OnListBoxSelectedValueChanged(Object sender, EventArgs e)
        {
            // close the drop down as soon as something is clicked
            wf_editorService.CloseDropDown();
        }
    }
}
