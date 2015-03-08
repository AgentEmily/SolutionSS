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
    public partial class ComboBoxEntry : BaseEntry
    {
        public ComboBoxEntry()
        {
            InitializeComponent();

            maximumHeight = 32;

            SetHostedControl(entryComboBox);
        }

        #region Entry ComoboBox Properties
        [DisplayName("ComboBox")]
        [Category("ComboBoxEntry")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("ComboBox Control")]
        public ComboBox ComboBoxControl
        {
            get { return entryComboBox; }
        }
        [Category("ComboBoxEntry")]
        [AttributeProvider(typeof(IListSource))]
        public object DataSource
        {
            get { return entryComboBox.DataSource; }
            
            set { entryComboBox.DataSource = value; }
        }

        [Category("ComboBoxEntry")]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string DataMember
        {
            get { return entryComboBox.DisplayMember; }
            
            set { entryComboBox.DisplayMember = value; }
        }
        
        [Category("ComboBoxEntry")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get { return entryComboBox.ValueMember; }
            
            set { entryComboBox.ValueMember = value; }
        }
        [Category("ComboBoxEntry")]
        [DesignerSerializationVisibility(0)]
        [Browsable(false)]
        [Bindable(true)]
        [DefaultValue("")]
         public string LookupMember
        {
            get 
            {
                if (entryComboBox.SelectedValue != null)
                {
                    return entryComboBox.SelectedValue.ToString();
                }
                else
                {
                    return "";
                }
            }
            
            set { entryComboBox.SelectedValue = value; }
        }
        #endregion

        #region events

        #endregion
    }
}
