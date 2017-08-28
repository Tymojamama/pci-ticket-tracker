using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TicketTracker.Business.Workflows
{
    /// <summary>
    /// Represents an object that sends emails via pre-configured SMTP.
    /// </summary>
    public class EmailSender
    {
        /// <summary>
        /// Represents a plain-text subject header of the email to be sent.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Represents an HTML encoded body of the email to be sent.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Represents a list of email address strings to whom the email will be sent.
        /// </summary>
        public List<string> ToRecipients = new List<string>();

        /// <summary>
        /// Occurs after an email was sent successfully.
        /// </summary>
        public EventHandler EmailSuccessfullySent { get; set; }

        /// <summary>
        /// Occurs after an email failed to send.
        /// </summary>
        public EventHandler EmailFailedToSend { get; set; }

        private SmtpClient _smtpClient;
        private Exception _smtpException;
        private MailMessage _mailMessage;

        /// <summary>
        /// Creates a new instance of the <see cref="EmailSender"/> class.
        /// </summary>
        public EmailSender()
        {
            _smtpClient = new SmtpClient("smtp.office365.com");
            _smtpClient.Credentials = new NetworkCredential("tpoag@pension-consultants.com", "8771212Tdp@", "pension-consultants.com");
            _smtpClient.Port = 587;
            _smtpClient.EnableSsl = true;

            _mailMessage = new MailMessage();
            _mailMessage.From = new MailAddress("tpoag@pension-consultants.com");
            ToRecipients.Add("tpoag@pension-consultants.com");
            _mailMessage.IsBodyHtml = true;
        }

        /// <summary>
        /// Sends the specified email via a <see cref="BackgroundWorker"/> process. <see cref="EmailSuccessfullySent"/>
        /// or <see cref="EmailFailedToSend"/> will be invoked once this process has completed.
        /// </summary>
        public void Send()
        {
            _mailMessage.Subject = Subject;
            _mailMessage.Body = Body;

            foreach (string _emailAddress in ToRecipients)
            {
                _mailMessage.To.Add(_emailAddress);
            }

            BackgroundWorker _backgroundWorker = new BackgroundWorker();

            _backgroundWorker.DoWork += new DoWorkEventHandler(
            delegate(object o, DoWorkEventArgs args)
            {
                try
                {
                    _smtpClient.Send(_mailMessage);
                    _smtpException = null;
                }
                catch (Exception ex)
                {
                    _smtpException = ex;
                }
            });

            _backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            delegate(object o, RunWorkerCompletedEventArgs args)
            {
                if (EmailSuccessfullySent != null && _smtpException == null)
                {
                    EmailSuccessfullySent.Invoke(this, new EventArgs());
                }
                else if (EmailFailedToSend != null && _smtpException != null)
                {
                    EmailFailedToSend.Invoke(this, new EventArgs());
                }
            });

            _backgroundWorker.RunWorkerAsync();
        }
    }
}
