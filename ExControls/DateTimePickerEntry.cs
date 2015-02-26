using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ExControls
{
    [System.ComponentModel.DefaultBindingProperty("EntryDateTime")]
    public partial class DateTimePickerEntry : BaseEntry
    {
        public DateTimePickerEntry()
        {
            InitializeComponent();
            maximumHeight = 32;

            SetHostedControl(entryDateTimePicker);
        }

        #region date time pciker properties
        [DisplayName("DateTimePicker")]
        [Category("DateTimePickerEntry")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("Date Time Picker Control")]
        public DateTimePicker DateTimePickerControl
        {
            get { return entryDateTimePicker; }
        }

        [DisplayName("Value")]
        [Bindable(true)]
        [Category("DateTimePickerEntry")]
        [Description("Entry Date Time")]
        public DateTime EntryDateTime
        {
            get { return entryDateTimePicker.Value; }
            set { entryDateTimePicker.Value = value; }
        }
        #endregion

    }
}
