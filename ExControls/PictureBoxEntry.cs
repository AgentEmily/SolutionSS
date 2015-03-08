using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ExControls
{
    [System.ComponentModel.DefaultBindingProperty("EntryImage")]
    public partial class PictureBoxEntry : BaseEntry
    {
        public PictureBoxEntry()
        {
            InitializeComponent();
            SetHostedControl(entryPictureBox);
        }

        #region picture box properties

        [DisplayName("PictureBox")]
        [Category("PictureBoxEntry")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("PictureBox Control")]
        public PictureBox PictureBoxControl
        {
            get { return entryPictureBox; }
        }

        [DisplayName("Image")]
        [Bindable(true)]
        [Category("PictureBoxEntry")]
        [Description("Picture Box Image")]
        public Image EntryImage
        {
            get { return entryPictureBox.Image; }
            set { entryPictureBox.Image = value; }

        }
        #endregion

        new internal int TitleWidth
        {
            get { return base.TitleWidth; }
            set { base.TitleWidth = value; }
        }
    }
}
