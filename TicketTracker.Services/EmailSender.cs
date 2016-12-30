using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TicketTracker.Service
{
    public class EmailSender
    {
        public string Subject;
        public string Body;

        public List<string> ToRecipients = new List<string>();

        private SmtpClient _smtpClient;
        private MailMessage _mailMessage;

        public EmailSender()
        {
            _smtpClient = new SmtpClient("smtp.office365.com");
            _smtpClient.Credentials = new NetworkCredential("zallen@pension-consultants.com", "Pensionuser1!", "pension-consultants.com");
            _smtpClient.Port = 587;
            _smtpClient.EnableSsl = true;

            _mailMessage = new MailMessage();
            _mailMessage.From = new MailAddress("zallen@pension-consultants.com");
            ToRecipients.Add("zallen@pension-consultants.com");
            _mailMessage.IsBodyHtml = true;
        }

        public void Send()
        {
            _mailMessage.Subject = Subject;
            _mailMessage.Body = Body;

            foreach (string _emailAddress in ToRecipients)
            {
                _mailMessage.To.Add(_emailAddress);
            }

            _smtpClient.Send(_mailMessage);
        }
    }
}
