using SmartShoppingBackEnd.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartShoppingBackEnd
{
    public partial class frmPictureLoad : Form
    {
        public frmPictureLoad()
        {
            InitializeComponent();
            
        }

        private int PictureBoxID = 0;
        private int TextID = 0;

        private void btnPictureLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.gif)|*.gif|(*.bmp)|*.bmp|(*.png)|*.png";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("未載入圖檔！");
                return;
            }
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("未輸入抬頭文字...！");
                return;
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("未輸入簡介文字...！");
                return;
            }
            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("未輸入詳細描述...！");
                return;
            }
            if (PictureBoxID == 0)
            {
                MessageBox.Show("您還未選取存放的位置，例如：圖一、圖二或圖三...！");
                return;
            }
            byte[] bytes;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                bytes = ms.GetBuffer();
            }
            string strTitleB = textBox1.Text.Trim();
            string strTitleM = textBox2.Text.Trim();
            string strTitleS = textBox3.Text.Trim();
            using (SqlConnection Conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
            {
                string lvsSQL = "UPDATE AdSlider SET Picture = @Picture, Title_B = @Title_B, Title_M = @Title_M, Title_S = @Title_S WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(lvsSQL, Conn))
                {
                    cmd.Parameters.AddWithValue("@Picture", bytes);
                    cmd.Parameters.AddWithValue("@Title_B", strTitleB);
                    cmd.Parameters.AddWithValue("@Title_M", strTitleM);
                    cmd.Parameters.AddWithValue("@Title_S", strTitleS);
                    cmd.Parameters.AddWithValue("@ID", PictureBoxID);
                    Conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadfirstAd();         
        }

        private void loadfirstAd()
        {
            PictureBoxID = 1;
            using (SqlConnection Conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
            {
                string lvsSQL = "SELECT Picture, Title_B, Title_M, Title_S From AdSlider WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(lvsSQL, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", PictureBoxID);
                    Conn.Open();
                    SqlDataReader Dr = cmd.ExecuteReader();
                    if (Dr.Read())
                    {
                        if (Dr["Picture"] != DBNull.Value)
                        {
                            byte[] bytes = (byte[])Dr["Picture"];
                            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes))
                            {
                                this.pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            this.pictureBox1.Image = null;
                        }
                        this.textBox1.Text = Dr["Title_B"].ToString();
                        this.textBox2.Text = Dr["Title_M"].ToString();
                        this.textBox3.Text = Dr["Title_S"].ToString();
                    }
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureBoxID = 2;
            using (SqlConnection Conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
            {
                string lvsSQL = "SELECT Picture, Title_B, Title_M, Title_S From AdSlider WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(lvsSQL, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", PictureBoxID);
                    Conn.Open();
                    SqlDataReader Dr = cmd.ExecuteReader();
                    if (Dr.Read())
                    {
                        if (Dr["Picture"] != DBNull.Value)
                        {
                            byte[] bytes = (byte[])Dr["Picture"];
                            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes))
                            {
                                this.pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            this.pictureBox1.Image = null;
                        }
                        this.textBox1.Text = Dr["Title_B"].ToString();
                        this.textBox2.Text = Dr["Title_M"].ToString();
                        this.textBox3.Text = Dr["Title_S"].ToString();
                    }
                }
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureBoxID = 3;
            using (SqlConnection Conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
            {
                string lvsSQL = "SELECT Picture, Title_B, Title_M, Title_S From AdSlider WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(lvsSQL, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", PictureBoxID);
                    Conn.Open();
                    SqlDataReader Dr = cmd.ExecuteReader();
                    if (Dr.Read())
                    {
                        if (Dr["Picture"] != DBNull.Value)
                        {
                            byte[] bytes = (byte[])Dr["Picture"];
                            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes))
                            {
                                this.pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            this.pictureBox1.Image = null;
                        }
                        this.textBox1.Text = Dr["Title_B"].ToString();
                        this.textBox2.Text = Dr["Title_M"].ToString();
                        this.textBox3.Text = Dr["Title_S"].ToString();
                    }
                }
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TextID = 1;
            using (SqlConnection Conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
            {
                string lvsSQL = "SELECT TagLine FROM AdTicker WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(lvsSQL, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", TextID);
                    Conn.Open();
                    SqlDataReader Dr = cmd.ExecuteReader();
                    if (Dr.Read())
                    {
                        this.textBox4.Text = Dr["TagLine"].ToString();
                    }
                }
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TextID = 2;
            using (SqlConnection Conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
            {
                string lvsSQL = "SELECT TagLine FROM AdTicker WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(lvsSQL, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", TextID);
                    Conn.Open();
                    SqlDataReader Dr = cmd.ExecuteReader();
                    if (Dr.Read())
                    {
                        this.textBox4.Text = Dr["TagLine"].ToString();
                    }
                }
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TextID = 3;
            using (SqlConnection Conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
            {
                string lvsSQL = "SELECT TagLine FROM AdTicker WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(lvsSQL, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", TextID);
                    Conn.Open();
                    SqlDataReader Dr = cmd.ExecuteReader();
                    if (Dr.Read())
                    {
                        this.textBox4.Text = Dr["TagLine"].ToString();
                    }
                }
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TextID = 4;
            using (SqlConnection Conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
            {
                string lvsSQL = "SELECT TagLine FROM AdTicker WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(lvsSQL, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", TextID);
                    Conn.Open();
                    SqlDataReader Dr = cmd.ExecuteReader();
                    if (Dr.Read())
                    {
                        this.textBox4.Text = Dr["TagLine"].ToString();
                    }
                }
            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TextID = 5;
            using (SqlConnection Conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
            {
                string lvsSQL = "SELECT TagLine FROM AdTicker WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(lvsSQL, Conn))
                {
                    cmd.Parameters.AddWithValue("@ID", TextID);
                    Conn.Open();
                    SqlDataReader Dr = cmd.ExecuteReader();
                    if (Dr.Read())
                    {
                        this.textBox4.Text = Dr["TagLine"].ToString();
                    }
                }
            }
        }

        private void btnTxtSave_Click(object sender, EventArgs e)
        {
            if (TextID == 0)
            {
                MessageBox.Show("您還未選取存放的位置，例如：文字一、文字二、文字三、文字四或文字五...！");
                return;
            }
            if (this.textBox4.Text.Trim() == "")
            {
                MessageBox.Show("您還未輸入廣告文字...！");
                return;
            }
            string strTagLine = this.textBox4.Text.Trim();
            using (SqlConnection Conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
            {
                string lvsSQL = "UPDATE AdTicker SET TagLine = @TagLine WHERE ID = @ID";
                using (SqlCommand cmd = new SqlCommand(lvsSQL, Conn))
                {
                    cmd.Parameters.AddWithValue("@TagLine", strTagLine);
                    cmd.Parameters.AddWithValue("@ID", TextID);
                    Conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void frmPictureLoad_Load(object sender, EventArgs e)
        {
            loadfirstAd();
        }
    }
}
