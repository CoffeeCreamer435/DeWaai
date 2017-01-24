using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace DeWaaiBeheer
{
    class EmailMethod
    {
        public SmtpClient client = new SmtpClient();
        public MailMessage msg = new MailMessage();
        public System.Net.NetworkCredential smptCredits = new System.Net.NetworkCredential("ytbemre0@gmail.com", "programma1");

        public void SendEmail(string sendTo, string sendFrom, string subject, string body)
        {
            try
            {
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.Credentials = smptCredits;
                client.EnableSsl = true;
                MailAddress to = new MailAddress(sendTo);
                MailAddress from = new MailAddress(sendFrom);
                msg.Subject = subject;
                msg.Body = body;
                msg.From = from;
                msg.To.Add(to);
                client.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
