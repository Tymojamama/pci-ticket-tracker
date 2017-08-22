using TicketTracker.Business.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TicketTracker.Business.Workflows.Email
{
    public class TicketTimeEmails
    {
        public EmailSender _emailSender { get; private set; }
        public TicketTime TicketTime { get; private set; }

        public bool ErrorOccurred { get; private set; }
        public string ErrorMessage { get; private set; }

        public TicketTimeEmails(TicketTime _ticketTime)
        {
            TicketTime = _ticketTime;
            _emailSender = new EmailSender();

            ErrorOccurred = false;
            ErrorMessage = null;

            throw new NotImplementedException();
        }
    }
}
