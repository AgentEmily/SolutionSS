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
    public partial class LabelEntry : BaseEntry
    {
        public LabelEntry()
        {
            InitializeComponent();

            SetHostedControl(entryLabel);
        }

        #region label properties
        [DisplayName("Label")]
        [Category("LabelEntry")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("Label Control")]
        public Label LabelControl
        {
            get { return entryLabel; }
        }

        [DisplayName("Text")]
        [Bindable(true)]
        [Category("LabelEntry")]
        [Description("Entry Text")]
        public string EntryText
        {
            get { return entryLabel.Text; }
            set { entryLabel.Text = value; }

        }
        #endregion


        #region Entry Label Properties
        //[DisplayName("Font"), Bindable(true), Category("Entry Label")
        //, Description("Font")]
        //public Font EntryFont
        //{
        //    get
        //    {
        //        return entryLabel.Font;
        //    }
        //    set
        //    {
        //        entryLabel.Font = value;
        //    }
        //}
        //[DisplayName("Fore Color"), Bindable(true), Category("Entry Label")
        //, Description("Fore Color")]
        //public Color EntryForeColor
        //{
        //    get
        //    {
        //        return entryLabel.ForeColor;
        //    }
        //    set
        //    {
        //        entryLabel.ForeColor = value;
        //    }
        //}
        //[DisplayName("Back Color"), Bindable(true), Category("Entry Label")
        //, Description("Background Color")]
        //public Color EntryBackColor
        //{
        //    get
        //    {
        //        return entryLabel.BackColor;
        //    }
        //    set
        //    {
        //        entryLabel.BackColor = value;
        //        entryPanel.BackColor = value;
        //    }
        //}
        #endregion
    }
}
