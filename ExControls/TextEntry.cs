using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ExControls
{
    [System.ComponentModel.DefaultBindingProperty("EntryText")]
    public partial class TextEntry : BaseEntry
    {
        public TextEntry()
        {
            InitializeComponent();
            SetHostedControl(entryTextBox);
        }

        #region textbox properties
        
        [DisplayName("TextBox")]
        [Category("TextEntry")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("Text Box Control")]
        public TextBox TextBoxControl
        {
            get { return entryTextBox; }
        }

        [DisplayName("Text")]
        [Bindable(true)]
        [Category("TextEntry")]
        [Description("Entry Label Text")]
        public string EntryText
        {
            get { return entryTextBox.Text; }
            set { entryTextBox.Text = value; }

        }
        #endregion


        #region events handlers

        #endregion
    }
}
