using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using WindowsService1;

namespace SmartShoppingBackEnd
{
    partial class ServiceAutoMailing : ServiceBase
    {
        public ServiceAutoMailing()
        {
            InitializeComponent();
            this.AutoLog = false;

            if (!System.Diagnostics.EventLog.SourceExists("MySource"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "MySource", "MyNewLog");
            }
            eventLog1.Source = "MySource";
            eventLog1.Log = "MyNewLog";
        }
         int count;//這次要寄信總數
         protected void SendMail()
         {
             //clear data in the list
             this.insideEmailListTableAdapter1.DeleteQuery();

             int setDateBefore = 7;

             using (SmartShoppingEntities SSE = new SmartShoppingEntities())
             {

                 DateTime deliverydate = DateTime.Today.AddDays(setDateBefore);

                 var q = from o in SSE.Orders
                         where o.ArrivalDate == deliverydate
                         select o;//所有今天該提醒的單
                 count = q.Count();
                 foreach (var item in q)
                 {


                     int memberid = (int)item.Member_ID;


                     string getEmail = (from m in SSE.Members
                                        where m.Member_ID == item.Member_ID
                                        select m.Email).FirstOrDefault();//每一張單抓到該提醒的會員的email

                     string memberName = (from m in SSE.Members
                                          where m.Member_ID == item.Member_ID
                                          select m.MemberName).FirstOrDefault();

                     var getProductName = from o in SSE.OrderDetails
                                          where o.Order_ID == item.Order_ID
                                          select o;//抓到所有商品名稱 數量
                     foreach (var od in getProductName)
                     {
                         string productName = od.Product.ProductName;//每次抓到一個商品
                         int quantity = (int)od.Quantity;//抓到一個數量
                         //寫到資料庫
                         this.insideEmailListTableAdapter1.InsertQuery(memberid, memberName, getEmail, productName, deliverydate, quantity, false);


                     }

                 }

                 //每次讀15封 mark 已發
                 var getlist = from inE in SSE.InsideEmailLists
                               where inE.Sent == false
                               group inE by inE.Member_ID into g
                               select g;

                 foreach (var group in getlist)
                 {

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

                     SmtpClient mail = new SmtpClient();
                     mail.Host = "smtp.gmail.com";
                     mail.EnableSsl = true;
                     mail.UseDefaultCredentials = false;
                     NetworkCredential loginInfo = new NetworkCredential("yinghua0111", "emily75111");
                     mail.Credentials = loginInfo;

                     MailMessage mms = new MailMessage();
                     mms.From = new MailAddress("yinghua0111@gmail.com", "SmartShopping Crew");
                     mms.To.Add(new MailAddress(email, name));
                     mms.Subject = "SmartShopping發貨通知";
                     mms.IsBodyHtml = true;

                     StringBuilder str = new StringBuilder();
                     str.Append("親愛的");
                     ////從資料庫讀名字 email  商品 
                     str.Append(name);
                     str.Append(":<br><br>");
                     str.Append("我們將於");
                     str.Append(deliverydate.ToShortDateString() + "<br>");
                     str.Append("寄送以下貨物給您" + ":<br><br>");
                     str.Append("<ul>");
                     for (int j = 0; j < Products.Count; j++)
                     {
                         str.Append("<li>" + Products[j] + "   數量: " + Quantitys[j] + "</li>");
                     }

                     str.Append("</ul>");
                     str.Append("<a href='http://google.com'>詳細資料</a>");
                     str.Append("<br><br>");
                     //str.Append(this.textBoxNotes.Text);

                     //string strFilePath = @"C:\Logo.gif";

                     //System.Net.Mail.Attachment attachment1 =
                     //   new System.Net.Mail.Attachment(workingDirectory);
                     //attachment1.Name = System.IO.Path.GetFileName(workingDirectory);
                     ////attachment1.NameEncoding = Encoding.GetEncoding(myMailEncoding);
                     ////attachment1.TransferEncoding = System.Net.Mime.TransferEncoding.Base64;

                     //// 設定該附件為一個內嵌附件(Inline Attachment)
                     //attachment1.ContentDisposition.Inline = true;
                     //attachment1.ContentDisposition.DispositionType =
                     //   System.Net.Mime.DispositionTypeNames.Inline;

                     //mms.Attachments.Add(attachment1);



                     mms.Body = str.ToString();



                     try
                     {
                         mail.Send(mms);
                     }
                     catch (SmtpFailedRecipientsException ex)
                     {
                         //針對發送失敗的使用者紀錄
                         for (int i = 0; i <= ex.InnerExceptions.Length; i++)
                         {
                             SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;
                             if (status == SmtpStatusCode.MailboxBusy || status == SmtpStatusCode.MailboxUnavailable)
                             {
                                 Console.WriteLine("信箱忙碌中");
                             }
                             else
                             {
                                 Console.WriteLine("無法傳送至該信箱因{0} ", ex.InnerExceptions[i].FailedRecipient);
                             }
                         }
                         //IsCircle = true;
                         //IsSuccess = false;
                     }
                     catch (Exception ex)
                     {
                         Console.WriteLine("Exception caught in RetryIfBusy(): {0}", ex.ToString());
                         //IsCircle = true;
                         //IsSuccess = false;
                     }
                     finally
                     {
                         //每發送失敗
                         //if (IsCircle)
                         //    intCount += 1;
                         //if (intCount >= intBadMailCount)
                         //    IsCircle = false;
                     }



                 }
             }
         }
        System.Timers.Timer objTimer = new System.Timers.Timer();
        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
            eventLog1.WriteEntry("In OnStart");
            eventLog1.WriteEntry("Monitoring the System", EventLogEntryType.Information, eventId++);
            //設定每一天執行一次
            //objTimer.Interval = 86400000;
            
            objTimer.Interval = 10000;
            objTimer.Enabled = true;
            eventLog1.WriteEntry("In timer");
            objTimer.Elapsed += new ElapsedEventHandler(chkProcess);
           Console.ReadLine();
            //因需要長時間觸發，所以要設定GC避免回收資源
            GC.KeepAlive(objTimer);
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("In onStop.");
            // TODO: Add code here to perform any tear-down necessary to stop your service.
            // 在此加入停止服務所需執行的終止程式碼。
            // 清掉計時器
            objTimer.Enabled = false;
            objTimer.Close();
            objTimer.Dispose();
            objTimer = null;
        }
        int eventId = 1;
        protected void chkProcess(object source, ElapsedEventArgs e)
        {
            eventLog1.WriteEntry("Monitoring the System", EventLogEntryType.Information, eventId++);

            DateTime dtNow = DateTime.Now;
            //依照時間點進行工作
            //7點send mail
            //if (dtNow.Hour == 7)
            //{
            //    SendMail();
            //}
            SendMail();

        }



    }
}
