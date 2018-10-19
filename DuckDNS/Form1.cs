using DuckDNS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace DuckDNS
{
    public partial class Form1 : Form
    {
        private DDns ddns = new DDns();
        private int intervalMS;
        private bool allowshowdisplay = false;
        private bool canClose = false;
        private Icon icoTray = Resources.tray;
        private Icon icoTrayC = Resources.tray_checking;
        private int EmailSentNo = 0;

        public Form1()
        {
            InitializeComponent();
            notifyIcon.Icon = Icon;
            //Top = Screen.PrimaryScreen.WorkingArea.Bottom - (Height + 200);
            //Left = Screen.PrimaryScreen.WorkingArea.Right - (Width + 25);
            ddns.Load();
            tbDomain.Text = ddns.Domain;
            tbToken.Text = ddns.Token;
            cbInterval.Text = ddns.Interval;
            tbSmtp.Text = ddns.Smtp;
            tbPort.Text = ddns.Port;
            cbEnableSsl.Checked = ddns.IsEnableSsl;
            tbUsername.Text = ddns.Username;
            tbPassword.Text = ddns.Password;
            tbFrom.Text = ddns.EmailFrom;
            tbTo.Text = ddns.EmailTo;
            tbMaxEmail.Text = ddns.MaxEmail;
            cbSavePass.Checked = ddns.SavePassword;
            cbUpdateNotification.Checked = ddns.IsIpUpdateNotify;


            ParseInterval();
            RefreshTimer();
            notifyIcon.Icon = icoTray;
            allowshowdisplay = tbDomain.Text.Length == 0 || tbToken.Text.Length == 0 || tbSmtp.Text.Length == 0 || tbUsername.Text.Length == 0 || tbPassword.Text.Length == 0 || tbFrom.Text.Length == 0 || tbTo.Text.Length == 0 || tbMaxEmail.Text.Length == 0;
            if (!allowshowdisplay)
                UpdateDNS();
        }

        protected override void SetVisibleCore(bool value)
        {

            if (!allowshowdisplay)
            {
                allowshowdisplay = true;
                if (!IsHandleCreated && value)
                    CreateHandle();
            }
            else
                base.SetVisibleCore(value);
        }

        private void UpdateDNS()
        {
            try
            {
                string updateResult = "";
                string emailError = "";
                DuckDnsResponse response = null;

                notifyIcon.Icon = icoTrayC;
                bool update = ddns.Update(out updateResult, out response);
                lblInfo.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + $": DuckDns Update: " + (update ? "OK" : "FAILED");
                EmailWrap(update, updateResult, out emailError, response);
                if (!update)
                {
                    Show();
                }
            }
            finally
            {
                notifyIcon.Icon = icoTray;
            }
        }

        private void EmailWrap(bool isUpdate, string updateResult, out string emailError, DuckDnsResponse response)
        {
            emailError = "";
            int maxEmail = -1;
            int.TryParse(tbMaxEmail.Text, out maxEmail);
            var emailInfo = "";


            if (isUpdate && response != null && response.IsUpdated)
            {
                var isSent = Email("DuckDNS updater - IP Updated", updateResult, out emailError);
                if (!isSent)
                    emailInfo = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +
                                    $": email sent error: {emailError}";
                else
                    emailInfo = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +
                                    $": email sent: IP Updated - {response.Ip}";
            }

            if (!isUpdate)
            {
                if (maxEmail <= EmailSentNo && maxEmail != -1)
                {
                    emailInfo = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + $": Max ({EmailSentNo}) emails reached";
                }
                else
                {
                    var isSent = Email("DuckDNS updater - Error", updateResult, out emailError);
                    EmailSentNo++;
                    emailInfo = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + $": email sent ({EmailSentNo}/{maxEmail})";
                    if (!isSent)
                        emailInfo = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +
                                        $": email sent error: {emailError}";
                }
            }
            
            lblInfo2.Text = emailInfo;
        }

        private bool Email(string subject, string updateResult, out string error)
        {
            error = "";
            try
            {
                int port;
                MailMessage mail = new MailMessage(tbFrom.Text, tbTo.Text);
                SmtpClient client = new SmtpClient();
                int.TryParse(tbPort.Text, out port);
                client.Port = port;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.EnableSsl = cbEnableSsl.Checked;
                client.Host = tbSmtp.Text;
                client.Credentials = new NetworkCredential(tbUsername.Text, tbPassword.Text);
                mail.Subject = subject;
                mail.Body = $"Domain: {tbDomain.Text} \r\n" +
                            $"{updateResult}";
                client.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            
        }      

        private void ParseInterval()
        {
            string istr = cbInterval.Text.ToLower();
            int iint=0;
            bool error=false;

            if (istr.Length==0 || !int.TryParse(istr.Substring(0, istr.Length - 1), out iint))
                error = true;
            else
            {
                switch (istr[istr.Length - 1])
                {
                    case 's':
                        intervalMS = iint * 1000;
                        break;
                    case 'm':
                        intervalMS = iint * 60000;
                        break;
                    case 'h':
                        intervalMS = iint * 3600000;
                        break;
                    case 'd':
                        intervalMS = iint * 86400000;
                        break;
                    default:
                        error = true;
                        break;
                }
            }
            cbInterval.BackColor = error ? Color.LightPink : SystemColors.Window;
        }

        private void RefreshTimer()
        {
            timer.Enabled = false;
            timer.Interval = intervalMS;
            timer.Enabled = true;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            ddns.Domain = tbDomain.Text;
            ddns.Token = tbToken.Text;
            ddns.Interval = cbInterval.Text;
            ddns.Smtp = tbSmtp.Text;
            ddns.Port = tbPort.Text;
            ddns.IsEnableSsl = cbEnableSsl.Checked;
            ddns.Username = tbUsername.Text;
            ddns.Password = tbPassword.Text;
            ddns.EmailFrom = tbFrom.Text;
            ddns.EmailTo = tbTo.Text;
            ddns.IsIpUpdateNotify = cbUpdateNotification.Checked;
            ddns.SavePassword = cbSavePass.Checked;
            ddns.MaxEmail = tbMaxEmail.Text;
            ddns.Save();
            Hide();
            UpdateDNS();
            RefreshTimer();
        }

        private void cbInterval_TextChanged(object sender, EventArgs e)
        {
            ParseInterval();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !canClose)
            {
                e.Cancel = true;
                Hide();
                // Reset values (discard)
                tbDomain.Text = ddns.Domain;
                tbToken.Text = ddns.Token;
                cbInterval.Text = ddns.Interval;

                tbSmtp.Text = ddns.Smtp;
                tbPort.Text = ddns.Port;
                cbEnableSsl.Checked = ddns.IsEnableSsl;
                tbUsername.Text = ddns.Username;
                tbPassword.Text = ddns.Password;
                tbFrom.Text = ddns.EmailFrom;
                tbTo.Text = ddns.EmailTo;
                tbMaxEmail.Text = ddns.MaxEmail;
                cbSavePass.Checked = ddns.SavePassword;
                cbUpdateNotification.Checked = ddns.IsIpUpdateNotify;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UpdateDNS();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canClose = true;
            Close();
        }

        private void updateNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDNS();
        }

        private void installStartupShortcutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string linkPath = Windows.GetStartupPath() + Path.DirectorySeparatorChar + "DuckDNS.lnk";
            WShellLink.CreateLink(linkPath,"Duck DNS Updater",Assembly.GetExecutingAssembly().Location);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FAbout.Execute();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            icoTray.Dispose();
            icoTrayC.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var error = "";
            var isSent = Email("Test email from C# DuckDns Auto Updater", "This is test body", out error);
            if (isSent)
            {
                lblInfo2.Text = "Email sent successfully";
            }
            else
            {
                lblInfo2.Text = $"Email sent error: {error}";
            }
        }


        public class DuckDnsResponse
        {
            public string ResponseStatus { get; set; }
            public string Ip { get; set; }
            public string UpdateStatus { get; set; }

            public bool IsUpdated
            {
                get
                {
                    if (UpdateStatus == "NOCHANGE")
                        return false;
                    return true;
                }
            }
        }
    }
}
