using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ExControls
{
    [System.ComponentModel.DefaultBindingProperty("EntryLinkText")]

    public partial class LinkLabelEntry : BaseEntry
    {
        public LinkLabelEntry()
        {
            InitializeComponent();
            maximumHeight = 32;
            SetHostedControl(entryLinkLabel);
        }

        #region linklabel properties

        [DisplayName("LinkLabel")]
        [Category("LinkLabelEntry")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("link label control")]
        public LinkLabel LinkLabelControl
        {
            get { return entryLinkLabel; }
        }

        [DisplayName("LinkText")]
        [Bindable(true)]
        [Category("LinkLabelEntry")]
        [Description("Entry Link Text")]
        public string EntryLinkText
        {
            get { return entryLinkLabel.Text; }
            set { entryLinkLabel.Text = value; }

        }
        #endregion
    }
}
