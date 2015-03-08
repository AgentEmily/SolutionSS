using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ExControls
{
    [System.ComponentModel.DefaultBindingProperty("EntryTodayDate")]
    public partial class MonthCalendarEntry : BaseEntry
    {
        public MonthCalendarEntry()
        {
            InitializeComponent();
            maximumHeight = 216;
            maximumWidth = 202;
            SetHostedControl(entryMonthCalendar);
        }


        #region month calendar properties

        [DisplayName("MonthCalendar")]
        [Category("MonthCalrndarEntry")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Description("Month Calendar Control")]
        public MonthCalendar MonthCalendarControl
        {
            get { return entryMonthCalendar; }
        }

        [DisplayName("Value")]
        [Bindable(true)]
        [Category("MonthCalrndarEntry")]
        [Description("Today Date Value")]
        public DateTime EntryTodayDate
        {
            get { return entryMonthCalendar.SelectionStart; }
            set 
            {
                entryMonthCalendar.SetDate(value);
            }

        }
        #endregion

        new internal int TitleWidth
        {
            get { return base.TitleWidth; }
            set { base.TitleWidth = value; }
        }
    }
}
