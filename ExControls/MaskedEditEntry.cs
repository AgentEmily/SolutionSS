using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ExControls
{
    [System.ComponentModel.DefaultBindingProperty("EntryMaskedText")]
    public partial class MaskedEditEntry : BaseEntry
    {
        public MaskedEditEntry()
        {
            InitializeComponent();


        }

        #region entryMaskedTextBox properties
        
        [DisplayName("MaskedTextBox")]
        [Category("MaskedTextEntry")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("Masked Text Box Control")]
        public MaskedTextBox MaskedTextBoxControl
        {
            get { return entryMaskedTextBox; }
        }

        [DisplayName("Text")]
        [Bindable(true)]
        [Category("MaskedTextEntry")]
        [Description("Entry Label Text")]
        public string EntryMaskedText
        {
            get { return entryMaskedTextBox.Text; }
            set { entryMaskedTextBox.Text = value; }

        }
        #endregion
    }
}
