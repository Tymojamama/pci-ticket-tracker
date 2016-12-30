using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Mail;

namespace TicketTracker.Service
{
    public class EmailSender
    {
        public MailAddress From;
        public MailAddress To;
        public string Subject;
        public string Body;

        private SmtpClient Client = new SmtpClient("smtp.gmail.com");

        public EmailSender()
        {
            Client.Port = 587;
            Client.Credentials = new System.Net.NetworkCredential("", "");
            Client.EnableSsl = true;
        }

        public void Send()
        {
            MailMessage _mailMessage = new MailMessage(From.Address, To.Address, Subject, Body);
            Client.SendMailAsync(_mailMessage);
        }
    }
}
