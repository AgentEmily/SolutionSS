using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Design;

namespace ExControls
{
    [LookupBindingProperties("DataSource", "DataMember", "ValueMember", "LookupMember")]
    public partial class ListBoxEntry : BaseEntry
    {
        public ListBoxEntry()
        {
            InitializeComponent();
            SetHostedControl(entryListBox);
        }

        #region Entry List Properties
        [DisplayName("ListBox")]
        [Category("ListBoxEntry")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("ListBox Control")]
        public ListBox ListBoxControl
        {
            get { return entryListBox; }
        }

        [Category("ListBoxEntry")]
        [AttributeProvider(typeof(IListSource))]
        public object DataSource
        {
            get { return entryListBox.DataSource; }

            set { entryListBox.DataSource = value; }
        }

        [Category("ListBoxEntry")]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string DataMember
        {
            get { return entryListBox.DisplayMember; }

            set { entryListBox.DisplayMember = value; }
        }

        [Category("ListBoxEntry")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get { return entryListBox.ValueMember; }

            set { entryListBox.ValueMember = value; }
        }

        [Category("ListBoxEntry")]
        [DesignerSerializationVisibility(0)]
        [Browsable(false)]
        [Bindable(true)]
        [DefaultValue("")]
        public string LookupMember
        {
            get 
            {
                if (entryListBox.SelectedValue != null)
                {
                    return entryListBox.SelectedValue.ToString();
                }
                else
                {
                    return "";
                }
            }
            set { entryListBox.SelectedValue = value; }
        }
        #endregion

        new internal int TitleWidth
        {
            get{ return base.TitleWidth; }
            set{ base.TitleWidth = value; }
        }
    }
}
