using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ExControls
{
    internal struct ControlMargins
    {
        public int left;
        public int right;
        public int top;
        public int bottom;
    }

    public partial class BaseEntry : UserControl
    {
        private Color normalBackColor1 = Color.FromArgb(105, 175, 224);
        private Color normalBackColor2 = Color.FromArgb(214, 232, 255);
        
        private Color hoverBackColor1 = Color.FromArgb(255,158,94);
        private Color hoverBackColor2 = Color.FromArgb(255, 243, 214);

        private Color activeBackColor1 = Color.FromArgb(223, 224, 4);
        private Color activeBackColor2 = Color.FromArgb(255, 250, 200);

        private Color disabledBackColor1 = Color.FromArgb(64,64,64);
        private Color disabledBackColor2 = Color.FromArgb(200, 200, 200);

        private Color backColor1;
        private Color backColor2;

        private bool mouseIn = false;

        private bool activeEntry = false;

        private Control hostedControl;
        private AnchorStyles hostedControlAnchor;
        private ControlMargins hostedControlMargins = new ControlMargins();

        protected int maximumWidth = 0;
        protected int maximumHeight = 0;

        static BaseEntry activeEntryControl;

        public BaseEntry()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.EnableNotifyMessage, true);
            backColor1 = normalBackColor1;
            backColor2 = normalBackColor2;

        }
        ~BaseEntry()
        {
            if (activeEntryControl == this)
            {
                activeEntryControl = null;
            }
        }

        #region Entry Title Properties
        [DisplayName("Text"), Bindable(true), Category("Entry Title"), DefaultValue("Title")
        , Description("The title Text")]
        public string TitleText
        {
            get
            {
                return titleLabel.Text;
            }
            set
            {
                titleLabel.Text = value;
            }
        }

        [DisplayName("Font"), Category("Entry Title")
        , Description("The Title Font")]
        public Font TitleFont
        {
            get
            {
                return titleLabel.Font;
            }
            set
            {
                titleLabel.Font = value;
            }

        }
        
        [DisplayName("Fore Color"), Category("Entry Title")
        , Description("The Title Fore Color")]
        public Color TitleForeColor
        {
            get
            {
                return titleLabel.ForeColor;
            }
            set
            {
                titleLabel.ForeColor = value;
            }
        }
        
        [DisplayName("Width"), Category("Entry Title")
        , Description("The Title Width")]
        public int TitleWidth
        {
            get
            {
                return titleLabel.Width;
            }
            set
            {
                int offset = value - titleLabel.Width;
                titleLabel.Width += offset;
                entryPanel.Left += offset;
                entryPanel.Width -= offset;
            }
        }
        
        [DisplayName("Image"), Category("Entry Title")
        , Description("The Title Image")]
        public Image TitleImage
        {
            get
            {
                return titleLabel.Image;
            }
            set
            {
                titleLabel.Image = value;
            }
        }

        [DisplayName("Image Align"), Category("Entry Title")
        , Description("The Title Image Alignment")]
        public ContentAlignment TitleImageAlign
        {
            get
            {
                return titleLabel.ImageAlign;
            }
            set
            {
                titleLabel.ImageAlign = value;
            }
        }

        [DisplayName("Image Index"), Category("Entry Title")
        , Description("The Title Image Index in the selected image list")]
        public int TitleImageIndex
        {
            get
            {
                return titleLabel.ImageIndex;
            }
            set
            {
                titleLabel.ImageIndex = value;
            }
        }
        
        [DisplayName("Image List"), Category("Entry Title")
        , Description("The Title Image list")]
        public ImageList TitleImageList
        {
            get
            {
                return titleLabel.ImageList;
            }
            set
            {
                titleLabel.ImageList = value;
            }
        }
        
        [DisplayName("Text Align"), Category("Entry Title")
        , Description("The Title Text alignment")]
        public ContentAlignment TitleTextAlign
        {
            get
            {
                return titleLabel.TextAlign;
            }
            set
            {
                titleLabel.TextAlign = value;
            }
        }
        
        [DisplayName("Right To Left"), Category("Entry Title")
        , Description("Right to left orientation")]
        public RightToLeft TitleRightToLeft
        {
            get
            {
                return titleLabel.RightToLeft;
            }
            set
            {
                titleLabel.RightToLeft = value;
            }
        }
        #endregion

        #region Appearance Properties
        [DisplayName("Normal Color 1"), Category("Appearance")
        , Description("Normal Gradient Color 1")]
        public Color NormalBackColor1
        {
            get
            {
                return normalBackColor1;
            }
            set
            {
                if (!value.IsEmpty)
                {
                    normalBackColor1 = value;
                }
                else
                {
                    normalBackColor1 = Color.FromArgb(105, 175, 224);
                }
                backColor1 = normalBackColor1;
            }
        }
        [DisplayName("Normal Color 2"), Category("Appearance")
        , Description("Normal Gradient Color 2")]
        public Color NormalBackColor2
        {
            get
            {
                return normalBackColor2;
            }
            set
            {
                if (!value.IsEmpty)
                {
                    normalBackColor2 = value;
                }
                else
                {
                    normalBackColor2 = Color.FromArgb(214, 232, 255);
                }
                backColor2 = normalBackColor2;
            }
        }

        [DisplayName("Hover Color 1"), Category("Appearance")
        , Description("Hover Gradient Color 1")]
        public Color HoverBackColor1
        {
            get
            {
                return hoverBackColor1;
            }
            set
            {
                if (!value.IsEmpty)
                {
                    hoverBackColor1 = value;
                }
                else
                {
                    hoverBackColor1 = Color.FromArgb(255, 158, 94);
                }
            }
        }
        [DisplayName("Hover Color 2"), Category("Appearance")
        , Description("Hover Gradient Color 2")]
        public Color HoverBackColor2
        {
            get
            {
                return hoverBackColor2;
            }
            set
            {
                if (!value.IsEmpty)
                {
                    hoverBackColor2 = value;
                }
                else
                {
                    hoverBackColor2 = Color.FromArgb(255, 243, 214);
                }
            }
        }

        [DisplayName("Active Color 1"), Category("Appearance")
        , Description("Active Gradient Color 1")]
        public Color ActiveBackColor1
        {
            get
            {
                return activeBackColor1;
            }
            set
            {
                if (!value.IsEmpty)
                {
                    activeBackColor1 = value;
                }
                else
                {
                    activeBackColor1 = Color.FromArgb(223, 224, 4);
                }
            }
        }
        [DisplayName("Active Color 2"), Category("Appearance")
        , Description("Active Gradient Color 2")]
        public Color ActiveBackColor2
        {
            get
            {
                return activeBackColor2;
            }
            set
            {
                if (!value.IsEmpty)
                {
                    activeBackColor2 = value;
                }
                else
                {
                    activeBackColor2 = Color.FromArgb(255, 250, 200);
                }
            }
        }        
        [DisplayName("Disabled Color 1"), Category("Appearance")
       , Description("Disabled Gradient Color 1")]
        public Color DisabledBackColor1
        {
            get
            {
                return disabledBackColor1;
            }
            set
            {
                if (!value.IsEmpty)
                {
                    disabledBackColor1 = value;
                }
                else
                {
                    disabledBackColor1 = Color.FromArgb(64,64,64);
                }
            }
        }
        [DisplayName("Disabled Color 2"), Category("Appearance")
        , Description("Disabled Gradient Color 2")]
        public Color DisabledBackColor2
        {
            get
            {
                return disabledBackColor2;
            }
            set
            {
                if (!value.IsEmpty)
                {
                    disabledBackColor2 = value;
                }
                else
                {
                    disabledBackColor2 = Color.FromArgb(200, 200, 200);
                }
            }
        }
        #endregion

        #region Functions
        
        public virtual void ActivateEntry(bool makeActive)
        {
            if (activeEntryControl != null && activeEntryControl != this && makeActive == true)
            {
                activeEntryControl.ActivateEntry(false);
            }

            if (activeEntry != makeActive)
            {
                activeEntry = makeActive;
                if (makeActive)
                {
                    if (this.Enabled)
                    {
                        backColor1 = activeBackColor1;
                        backColor2 = activeBackColor2;

                        activeEntryControl = this;
                    }
                }
                else
                {
                    activeEntryControl = null;
                    if (!this.Enabled)
                    {
                        backColor1 = disabledBackColor1;
                        backColor2 = disabledBackColor2;
                    }
                    else if (mouseIn)
                    {
                        backColor1 = hoverBackColor1;
                        backColor2 = hoverBackColor2;
                    }
                    else
                    {
                        backColor1 = normalBackColor1;
                        backColor2 = normalBackColor2;
                    }
                }
                Invalidate();
            }
        }

        protected void SetHostedControl(Control ctrl)
        {
            if (ctrl != null)
            {
                hostedControl = ctrl;
                hostedControlAnchor = ctrl.Anchor;

                hostedControlMargins.left = ctrl.Location.X;
                hostedControlMargins.top = ctrl.Location.Y;
                hostedControlMargins.right = Math.Abs(entryPanel.Width - ctrl.Width);
                hostedControlMargins.bottom = Math.Abs(entryPanel.Height - ctrl.Height);

                hostedControl.Resize += new EventHandler(hostedControl_Resize);
                hostedControl.Move += new EventHandler(hostedControl_Move);
                hostedControl.DockChanged += new EventHandler(hostedControl_DockChanged);
                hostedControl.MouseLeave += new EventHandler(BaseEntry_MouseLeave);
                hostedControl.MouseMove += new MouseEventHandler(BaseEntry_MouseMove);
                hostedControl.Enter += new EventHandler(hostedControl_Enter);
                hostedControl.Leave += new EventHandler(hostedControl_Leave);
                hostedControl.MouseDown += new MouseEventHandler(BaseEntry_MouseDown);
                hostedControl.MouseClick += new MouseEventHandler(BaseEntry_MouseClick);
                hostedControl.MouseDoubleClick += new MouseEventHandler(BaseEntry_MouseDoubleClick);
                hostedControl.BackColorChanged += new EventHandler(hostedControl_BackColorChanged);

            }
        }


        private void LayoutHostedControl()
        {
            if (hostedControl != null)
            {
                hostedControl.Left = hostedControlMargins.left;
                hostedControl.Top = hostedControlMargins.top;
                hostedControl.Width = entryPanel.Width - hostedControlMargins.right;
                hostedControl.Height = entryPanel.Height - hostedControlMargins.bottom;
            }
        }
        #endregion

        #region events
        private void BaseEntry_Paint(object sender, PaintEventArgs e)
        {
            //if (this.BackgroundImage == null)
            //{
            //    Rectangle rect = new Rectangle(0, 0, Width, Height);
            //    LinearGradientBrush b = new LinearGradientBrush(rect, backColor1, backColor2, 90);
            //    GraphicsPath path = Helper.GetRoundRectPath(rect, 8);
            //    e.Graphics.FillPath(b, path);
            //}
            //else
            //{
            //    base.OnPaint(e);
            //}
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.BackgroundImage == null)
            {
                Rectangle rect = new Rectangle(0, 0, Width, Height);
                LinearGradientBrush b = new LinearGradientBrush(rect, backColor1, backColor2, 90);
                GraphicsPath path = Helper.GetRoundRectPath(rect, 8);
                e.Graphics.FillPath(b, path);
            }
            else
            {
                base.OnPaint(e);
            }
        }

        private void BaseEntry_Resize(object sender, EventArgs e)
        {
            if (maximumHeight != 0 && this.Height != maximumHeight)
            {
                this.Height = maximumHeight;
            }

            if (maximumWidth != 0 && this.Width != maximumWidth)
            {
                this.Width = maximumWidth;
            }
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            GraphicsPath path = Helper.GetRoundRectPath(rect, 8);
            this.Region = new Region(path);
        }

        private void BaseEntry_EnabledChanged(object sender, EventArgs e)
        {
            if (!this.Enabled)
            {
                backColor1 = disabledBackColor1;
                backColor2 = disabledBackColor2;
            }
            else if (activeEntry)
            {
                backColor1 = activeBackColor1;
                backColor2 = activeBackColor2;
            }
            else if (mouseIn)
            {
                backColor1 = hoverBackColor1;
                backColor2 = hoverBackColor2;
            }
            else
            {
                backColor1 = normalBackColor1;
                backColor2 = normalBackColor2;
            }
            Invalidate();
        }
        private void BaseEntry_MouseEnter(object sender, EventArgs e)
        {

        }

        private void BaseEntry_MouseLeave(object sender, EventArgs e)
        {
            Point pt = PointToClient(MousePosition);
            Rectangle rect = this.ClientRectangle;
            if (!rect.Contains(pt))
            {
                if (!activeEntry)
                {
                    backColor1 = normalBackColor1;
                    backColor2 = normalBackColor2;
                    Invalidate();
                }
                refreshTimer.Enabled = false;
                mouseIn = false;
            }
        }

        private void BaseEntry_ControlAdded(object sender, ControlEventArgs e)
        {
        }

        private void BaseEntry_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseIn && !activeEntry)
            {
                mouseIn = true;
                backColor1 = hoverBackColor1;
                backColor2 = hoverBackColor2;
                refreshTimer.Enabled = true;
                Invalidate();
            }
        }

        void hostedControl_DockChanged(object sender, EventArgs e)
        {
            hostedControl.Dock = DockStyle.None;
            LayoutHostedControl();
        }

        void hostedControl_Move(object sender, EventArgs e)
        {
            LayoutHostedControl();
        }

        void hostedControl_Resize(object sender, EventArgs e)
        {
            LayoutHostedControl();

        }

        private void entryPanel_Resize(object sender, EventArgs e)
        {
            LayoutHostedControl();

        }

        private void entryPanel_Move(object sender, EventArgs e)
        {
            LayoutHostedControl();

        }
        private void BaseEntry_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ActivateEntry(true);
            if (hostedControl != null)
            {
                hostedControl.Focus();
            }
        }

        private void BaseEntry_MouseClick(object sender, MouseEventArgs e)
        {
            ActivateEntry(true);
            if (hostedControl != null)
            {
                hostedControl.Focus();
            }
        }

        private void BaseEntry_MouseDown(object sender, MouseEventArgs e)
        {
            ActivateEntry(true);
            if (hostedControl != null)
            {
                hostedControl.Focus();
            }
        }

        private void hostedControl_Leave(object sender, EventArgs e)
        {
            ActivateEntry(false);
        }

        private void hostedControl_Enter(object sender, EventArgs e)
        {
            ActivateEntry(true);
        }
        
        private void hostedControl_BackColorChanged(object sender, EventArgs e)
        {
            entryPanel.BackColor = hostedControl.BackColor;
        }
        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            BaseEntry_MouseLeave(sender, e);
        }
        #endregion
    }
}
