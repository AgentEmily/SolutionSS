using KOTSMSAPI;
using SmartShoppingBackEnd.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;

namespace SmartShoppingBackEnd
{
    public partial class frmAutoMail : Form
    {
        public frmAutoMail()
        {
            InitializeComponent();
        }
        int p;//progress拆解進度0-100
        int count;//這次要寄信總數
        int iSend=0; //目前到第幾封
         DateTime deliverydate;
        bool withAd = false;
        //==簡訊部分==//
        private string GetSMSResult = null;  // 取得經傳送後得到的 Kmsgid 值及內容等
        CancellationTokenSource cts;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                this.backgroundWorker1.RunWorkerAsync();//把他叫起來, 不用類別共用變數的方法, 因為一讀一寫在多執行緒會爭搶, 100是可以傳入參數
                // DoWork();
                this.Cursor = Cursors.WaitCursor;
            }
            else
            {
                MessageBox.Show("請先取消作業");
            }

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.CancelAsync();//workersupportscancellation 屬性要先設TRUE
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }

        private void CreateTable()//把今天要發送的所有通知存進insideEmailList
        {
            this.insideEmailListTableAdapter1.DeleteQuery();
            string date = this.textBox1.Text;
            int setDateBefore;
            if (int.TryParse(date, out setDateBefore))
            {

            }
            else
            {
                MessageBox.Show("提醒時間設置錯誤");

                return;
            }

            using (SmartShoppingEntities SSE = new SmartShoppingEntities())
            {

                deliverydate = DateTime.Today.AddDays(setDateBefore);

                var q = from o in SSE.Orders
                        where o.ArrivalDate == deliverydate
                        select o;//所有今天該提醒的單
                count = q.Count();
                foreach (var item in q)
                {


                    int memberid = (int)item.Member_ID;


                    var member = (from m in SSE.Members
                                  where m.Member_ID == item.Member_ID && m.AdOK==true
                                  select new { getEmail = m.Email, memberName = m.MemberName, memberTel = m.MobilePhone }).FirstOrDefault();//每一張單抓到該提醒的會員的email

                   

                    var getProductName = from o in SSE.OrderDetail
                                         where o.Order_ID == item.Order_ID
                                         select o;//抓到所有商品名稱 數量

                    foreach (var od in getProductName)
                    {
                        string productName = od.Products.ProductName;//每次抓到一個商品
                        int quantity = (int)od.Quantity;//抓到一個數量
                        //寫到資料庫
                        this.insideEmailListTableAdapter1.InsertQuery(memberid, member.memberName, member.getEmail, productName, deliverydate, quantity, false, member.memberTel);
                        //目前都由這動作負責create sending table

                    }

                }
            }
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(e.Argument.ToString());//取得傳入的參數100

            e.Result = iSend;

            //每次讀15封 mark 已發
            using (SmartShoppingEntities SSE = new SmartShoppingEntities())
            {
                var getlist = from inE in SSE.InsideEmailList
                              where inE.Sent == false 
                              group inE by inE.Member_ID into g
                              select g;

                foreach (var group in getlist)
                {
                    if (backgroundWorker1.CancellationPending)//取消按下去的話
                    {
                        e.Cancel = true;
                        break;
                    }

                    string name = "";
                    string email = "";
                   
                    
                    //count = group.Count();//總共要發幾封

                    List<string> Products = new List<string>();
                    List<int> Quantitys = new List<int>();
                    foreach (var send in group)
                    {
                        name = send.MemberName;
                        email = send.Email;
                      
                        Products.Add(send.ProductName);
                        Quantitys.Add((int)send.Quantity);

                    }

                    if (email == null || name == null)
                    {
                        continue;
                    }

                    //開始寄信
                    SmtpClient mail = new SmtpClient();
                    mail.Host = "smtp.gmail.com";
                    mail.EnableSsl = true;
                    mail.UseDefaultCredentials = false;
                    NetworkCredential loginInfo = new NetworkCredential("yinghua0111", "emily75111");
                    mail.Credentials = loginInfo;

                    MailMessage mms = new MailMessage();
                    mms.From = new MailAddress("yinghua0111@gmail.com", "SmartShopping Crew");
                    mms.To.Add(new MailAddress(email, name));
                    mms.Subject = this.textBoxSubject.Text;
                    mms.IsBodyHtml = true;
                    StringBuilder str = new StringBuilder();
                    str.Append(this.textBoxDear.Text);
                    str.Append(name);
                    str.Append(":<br><br>");
                    str.Append(this.textBoxWeWill.Text);
                    str.Append(deliverydate.ToShortDateString() + "<br>");
                    str.Append(this.textBoxSend.Text + ":<br><br>");
                    str.Append("<ul>");
                    for (int j = 0; j < Products.Count; j++)
                    {
                        str.Append("<li>" + Products[j] + "   數量: " + Quantitys[j] + "</li>");
                    }

                    str.Append("</ul>");
                    str.Append("<a href='http://google.com'>詳細資料</a>");
                    str.Append("<br><br>");
                    str.Append(this.textBoxNotes.Text);
                    //把字串存到資料庫給服務用
                    str.Append("<img scr='http://gifcountdown.com/asia-makassar/1424955600/141414/0f0f0f/aaaaaa/fdfdfd/faedad/true/counter.gif'></img>");


                    if (withAd)//有勾隨信附上廣告才會加入HTML字串
                    {
                        str.Append(AdHTML);
                        if (filePath!=string.Empty)
                        {
                            System.Net.Mail.Attachment attachment1 = new System.Net.Mail.Attachment(filePath);
                        attachment1.Name = System.IO.Path.GetFileName(filePath);
                        //attachment1.NameEncoding = Encoding.GetEncoding(myMailEncoding);
                        //attachment1.TransferEncoding = System.Net.Mime.TransferEncoding.Base64;

                        // 設定該附件為一個內嵌附件(Inline Attachment)
                        attachment1.ContentDisposition.Inline = true;
                        attachment1.ContentDisposition.DispositionType =
                           System.Net.Mime.DispositionTypeNames.Inline;

                        mms.Attachments.Add(attachment1);
                        }
                        
                    }

                    //身分問題  圖先寫進資料庫
                    str.Append("<hr/>");
                    str.Append("<p style='text-align:center'><a href='https://localhost:44300/MemberCenter/CancelEmailAd?Confirmed=false'>我不要再收到通知信</a></p>");
                    mms.Body = str.ToString();
                   

                    mail.Send(mms);
                    //設定進度表
                    p = (int)Math.Round(iSend * 1.0 / count * 100);

                    backgroundWorker1.ReportProgress(p);
                    iSend++;

                }
                //撈下15封到沒有


            }
            e.Result = iSend;
        }
               

 

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //this.labelProgress.Text = string.Format("{0}%", e.ProgressPercentage);
            this.progressBar1.Visible = true;
            this.labelSent.Visible = true;
            this.labelTotal.Visible = true;
            this.labelspash.Visible = true;

            this.progressBar1.Value = p;
            this.labelSent.Text = iSend.ToString();//不能設

            this.labelTotal.Text = count.ToString();
            this.Cursor = Cursors.Arrow;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)//結束時判斷是因為真的結束還是因為被取消
            {
                MessageBox.Show("已取消");
            }
            else if (!e.Cancelled&&e.Result.ToString()!="0")
            {
                MessageBox.Show("系統一共成功寄出" + e.Result + "封通知信");//取用執行結果
                

                   this.listBox1.Items.Clear();
                   this.listBox1.Items.Add("上次Email發送時間:");
                   DateTime EmailTime = DateTime.Now;
                   this.listBox1.Items.Add(EmailTime);
                   Settings.Default.EmailTime = EmailTime;
                   this.listBox1.Items.Add("上次簡訊發送時間:");
                   this.listBox1.Items.Add(Settings.Default.MessageTime);
            
            }
          
            //this.labelProgress.Text = "0%";
            this.progressBar1.Value = progressBar1.Minimum;
            this.labelSent.Text = "0";
            this.labelTotal.Text = "0";
            this.Cursor = Cursors.Arrow;
            iSend = 0;
            p = 0;
            this.progressBar1.Visible = false;
            this.labelSent.Visible = false;
            this.labelTotal.Visible = false;
            this.labelspash.Visible = false;
        }

        

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.smartShoppingDataSet);

        }
        //end of email sending
        private void frmAutoMail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartShoppingDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.smartShoppingDataSet.Orders);
           
            this.tabControl1.SelectedIndex = 2;
            CreateTable();
            this.listBox1.Items.Add("上次Email發送時間:");
            this.listBox1.Items.Add(Settings.Default.EmailTime);
            this.listBox1.Items.Add("上次簡訊發送時間:");
            this.listBox1.Items.Add(Settings.Default.MessageTime);
            LoadAdLabel();

        }

        private void LoadAdLabel()
        {
            this.flowLayoutPanel1.Controls.Clear();
            using (SmartShoppingEntities db = new SmartShoppingEntities())
            {
                var q = from p in db.Promotions
                         where p.AdHtml!=null
                        select p;
               
                foreach (var item in q)
                {
                   
                    LinkLabel lb = new LinkLabel();
                    lb.Text = item.PromotionName;

                    Dictionary<int, string> atag = new Dictionary<int, string>();
                    atag.Add(item.Promotion_ID, item.AdHtml);
                    lb.Tag = atag;
                    lb.AutoSize = true;
                    lb.Margin = new Padding(0,0,0,10);
                    //
                    this.flowLayoutPanel1.Controls.Add(lb);
                    
                    lb.Click += lb_Click;
                }
            }
        }
        int AdID;
        void lb_Click(object sender, EventArgs e)
        {
            AdID=((Dictionary<int, string>)((LinkLabel)sender).Tag).Keys.First();
            this.htmlEditorControl1.InnerHtml = ((Dictionary<int, string>)((LinkLabel)sender).Tag)[AdID].ToString();
            this.textBoxTitle.Text = ((LinkLabel)sender).Text;
            NewAd = false;
        }
        string AdHTML = "";
        private void button3_Click(object sender, EventArgs e)
        {
            AdHTML = htmlEditorControl1.InnerHtml;
            //using (EditHtmlForm dialog = new EditHtmlForm())
            //{
            //    dialog.HTML = this.DocumentHtml;
            //    dialog.ReadOnly = true;
            //    dialog.SetCaption(HTML_TITLE_VIEW);
            //    DefineDialogProperties(dialog);
            //    dialog.ShowDialog(this.ParentForm);
            //}
            //寫進資料庫
            using (SmartShoppingEntities db=new SmartShoppingEntities())
            {
                //新增
                if (NewAd)
                {
                    Promotions promotion = new Promotions();
                promotion.AdHtml = AdHTML;
                promotion.PromotionName = this.textBoxTitle.Text;
                db.Entry(promotion).State = EntityState.Added;
                
                }
                else
                {
                    //修改
                    Promotions promotion = db.Promotions.Find(AdID);
                    promotion.AdHtml = AdHTML;
                    promotion.PromotionName = this.textBoxTitle.Text;
                    db.Entry(promotion).State = EntityState.Modified;
                }
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.ToString());
                }
                
                
            }
            LoadAdLabel();
            MessageBox.Show("儲存成功");
        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                withAd = true;
            }
            else
            {
                withAd = false;
            }
        }

        private string filePath = string.Empty;
        
        private void button4_Click(object sender, EventArgs e)
        {
            //跑完存路徑到workindDirectory
            string fileName = string.Empty;
            
            string workingDirectory = string.Empty;

            // define the file dialog
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Select Image";
                dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;
                dialog.CheckFileExists = true;
                if (workingDirectory != String.Empty) dialog.InitialDirectory = workingDirectory;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    
                    fileName = Path.GetFileName(dialog.FileName);
                    filePath = Path.GetFullPath(dialog.FileName);
                    workingDirectory = Path.GetDirectoryName(dialog.FileName);

                    if (fileName != "")
                    {
                        // have a path for a image I can insert
                        this.htmlEditorControl1.InsertImage(filePath);
                    }
                }
            }
            this.htmlEditorControl1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Color color = dialog.Color;
                    this.htmlEditorControl1.BodyBackColor = color;
                }
            }
            this.htmlEditorControl1.Focus();
        }

     //簡訊部分//

        private KeyPressEventArgs VerifyNumber(object sender, KeyPressEventArgs e)  //限定只能輸入數字
        {
            if (e.KeyChar == (Char)48 || e.KeyChar == (Char)49 ||
               e.KeyChar == (Char)50 || e.KeyChar == (Char)51 ||
               e.KeyChar == (Char)52 || e.KeyChar == (Char)53 ||
               e.KeyChar == (Char)54 || e.KeyChar == (Char)55 ||
               e.KeyChar == (Char)56 || e.KeyChar == (Char)57 ||
               e.KeyChar == (Char)13 || e.KeyChar == (Char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            return e;
        }

        private void txtHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyNumber(sender, e);
        }

        private void txtMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyNumber(sender, e);
        }

        private void txtSec_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyNumber(sender, e);
        }

        private void txtVldTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyNumber(sender, e);
        }

        
       

        private async void button6_Click(object sender, EventArgs e)//發送簡訊 click
        {
            cts = new CancellationTokenSource();
            var progress = new Progress<ProgressInfo>();
            try
            {
                progress.ProgressChanged += (o, info) => {
                    this.progressBar2.Visible = true;
                    this.labelMSent.Visible = true;
                    this.labelMTotal.Visible = true;
                    this.labelMslash.Visible = true;
                    this.progressBar2.Value = (int)Math.Round(iSend * 1.0 / count * 100);
                    this.labelMSent.Text = iSend.ToString();

                //label 的變化
                };
                this.labelMTotal.Text = count.ToString();
                var result = await SendMessageAsync(cts.Token, progress);
                MessageBox.Show("系統一共成功送出" + result.ToString() + "封簡訊");

                this.listBox1.Items.Clear();
                this.listBox1.Items.Add("上次簡訊發送時間:");
                DateTime MessageTime = DateTime.Now;
                this.listBox1.Items.Add(MessageTime);
                Settings.Default.MessageTime = MessageTime;
                this.listBox1.Items.Add("上次Email發送時間:");
                this.listBox1.Items.Add(Settings.Default.EmailTime);

                
            }
            catch (OperationCanceledException)
            {

                MessageBox.Show("已取消");
            }
            catch (Exception)
            {

                MessageBox.Show("傳送失敗");
            }

            cts = null;
            iSend = 0;
            this.labelMSent.Text = "";
            this.labelMTotal.Text = "";
            this.progressBar2.Value = progressBar2.Minimum;
            this.progressBar2.Visible = false;
            this.labelMSent.Visible = false;
            this.labelMTotal.Visible = false;
            this.labelMslash.Visible = false;
        }

        private Task<int> SendMessageAsync(CancellationToken ct, IProgress<ProgressInfo> progress)//發送簡訊非同步方法
        {
            var task = Task.Factory.StartNew(() => {

            KOT_SMSAPI mySMS = new KOT_SMSAPI();  //建之一個 KOT_SMSAPI 類別，並命名為 mySMS
            mySMS.username = txtUsername.Text;  //使用者帳號代入 [*必要項目]
            mySMS.password = txtPassword.Text;  //使用者密碼代入 [*必要項目]
            var info = new ProgressInfo();

            using (SmartShoppingEntities SSE = new SmartShoppingEntities())
            {
                var getlist = from inE in SSE.InsideEmailList
                              where inE.Sent == false
                              group inE by inE.Member_ID into g
                              select g;

                foreach (var group in getlist)
                {


                    string name = "";
                    string mobile = "";

                    //count = group.Count();//總共要發幾封

                    List<string> Products = new List<string>();
                    List<int> Quantitys = new List<int>();
                    foreach (var send in group)
                    {
                        name = send.MemberName;
                        mobile = send.Mobile;
                        Products.Add(send.ProductName);
                        Quantitys.Add((int)send.Quantity);
                        
                    }

                    if (mobile == null || name == null)
                    {
                        continue;
                    }

                    //send

                    mySMS.dstaddr = mobile; //把電話代入 (目前限單一電話) [*必要項目]
                    StringBuilder str = new StringBuilder();
                    str.Append(this.textBoxDear.Text);
                    str.Append(name);
                    str.Append(":");
                    str.Append(this.textBoxWeWill.Text);
                    str.Append(deliverydate.ToShortDateString());
                    str.Append(this.textBoxSend.Text + ":");

                    for (int j = 0; j < Products.Count; j++)
                    {
                        str.Append((j + 1) + ". " + Products[j] + "(" + Quantitys[j] + ") ");
                    }


                    str.Append("詳細資訊:http://google.com");

                    str.Append(this.textBoxNotes.Text);
                    mySMS.smbody = str.ToString();  //把簡訊內容代入 [*必要項目]




                    // 設定編碼
                    mySMS.SMSEncode = EncodingbyApp.Big5;  //此若不設定，系統會自動代入預設 Big5 編碼格式


                    //========================================
                    // 呼叫傳送簡訊方法 **上述值分別設定完成後，即可呼叫 SendSMSNow 來傳送簡訊
                    //GetSMSResult = mySMS.SendSMSNow();  //呼叫傳送簡訊方法[即 SendSMSNow()]，並把其結果寫入 GetSMSResult 變數中

                    if (progress!=null)
                    {
                        info.Data = iSend;
                        progress.Report(info);
                    }
                    SpinWait.SpinUntil(() => { ct.ThrowIfCancellationRequested(); return false; }, 10);
                   
                    iSend++;

                }



            }//=====using entity end=====//
            return iSend;
            
            });



            return task;
            


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (cts!=null)
            {
                cts.Cancel();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CreateTable();
            MessageBox.Show("已準備好請發送");
        }

        private void frmAutoMail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }
        bool NewAd = true;
        private void button8_Click(object sender, EventArgs e)
        {
            this.htmlEditorControl1.InnerHtml = "";
            this.textBoxTitle.Text = "";
            NewAd = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.htmlEditorControl1.NavigateToUrl(@"http://google.com");
        }

 

        
    }
}

internal class ProgressInfo
{
    public int Data { get; internal set; }
}