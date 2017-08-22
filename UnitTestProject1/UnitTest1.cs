using DataIntegrationHub.Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketTracker.Business.Workflows;
using TicketTracker.Business.Entities;
using TicketTracker.Business.Components;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        List<Ticket> Tickets = new List<Ticket>();

        [TestMethod]
        public void TestMethod1()
        {
            Ticket blah = new Ticket(new Guid("6697882E-DC5A-41DA-908A-68198DF5375C"));
            Tickets.Add(blah);

            foreach (Ticket Ticket in Tickets)
            {
                User _requestedBy = new User(Ticket.RequestedBy);
                User _owner = new User(Ticket.OwnerId);
                StringMap _priorityLevel = new StringMap(Ticket.PriorityLevelId);

                string ticketTimeSummary = null;

                decimal _durationMinutes = 0;
                foreach (TicketTime _ticketTime in TicketTime.AssociatedTicketTimes(Ticket))
                {
                    _durationMinutes += _ticketTime.DurationMinutes;

                    ticketTimeSummary = ticketTimeSummary +
                        @"  <tr>
                            <td>" + _ticketTime.SubjectValue + @"</td>
                            <td>" + _ticketTime.StartTime.ToString("MMM d hh:mm tt") + @"</td>
                            <td>" + _ticketTime.DurationMinutes.ToString("N2") + @"</td>
                        </tr>";
                }

                string ticketTaskSummary = null;
                foreach (DataRow dataRow in TicketTracker.Business.Entities.Task.GetAllAssociatedFromTicket(Ticket.TicketId).Rows)
                {
                    Guid taskId = new Guid(dataRow["TaskId"].ToString());
                    TicketTracker.Business.Entities.Task task = new TicketTracker.Business.Entities.Task(taskId);

                    if (task.CreatedOn <= DateTime.Now.AddDays(-7))
                    {
                        continue;
                    }

                    StringMap stringMap = new StringMap(task.StatusId);

                    ticketTaskSummary = ticketTaskSummary +
                        @"  <tr>
                            <td>" + stringMap.StringValue + @"</td>
                            <td>" + task.SubjectValue + @"</td>
                            <td>" + task.CreatedOn.ToString("MMM d hh:mm tt") + @"</td>
                        </tr>";
                }

                TimeSpan _timeSpan = TimeSpan.FromMinutes((double)_durationMinutes);

                string _mailSubject = "An open ticket has been marked completed: " + Ticket.SubjectValue;

                string _mailBody = UnitTestProject1.Resources.WeeklyEmail;

                _mailBody = _mailBody.Replace("{lblFirstName}", _requestedBy.FirstName);
                _mailBody = _mailBody.Replace("{lblTicketSubject}", Ticket.SubjectValue);
                _mailBody = _mailBody.Replace("{lblTicketHours}", _timeSpan.Hours.ToString());
                _mailBody = _mailBody.Replace("{lblTicketMinutes}", _timeSpan.Minutes.ToString());
                _mailBody = _mailBody.Replace("{lblTicketOwner}", _owner.FirstName);
                _mailBody = _mailBody.Replace("{trTicketSummary}", ticketTimeSummary);
                _mailBody = _mailBody.Replace("{trTaskSummary}", ticketTaskSummary);

                try
                {
                    EmailSender _emailSender = new EmailSender();
                    _emailSender.Subject = _mailSubject;
                    _emailSender.Body = _mailBody;
                    _emailSender.ToRecipients.Add(_requestedBy.EmailAddress);
                    //_emailSender.Send();
                }
                catch (Exception _excpetion)
                {
                    Console.WriteLine(_excpetion.Message);
                }
            }
        }

        [TestMethod]
        public void SendEmail()
        {
            EmailSender _emailSender = new EmailSender();
            _emailSender.Subject = "test";
            _emailSender.Body = "test";
            _emailSender.Send();
        }
    }
}
