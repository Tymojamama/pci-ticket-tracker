using TicketTracker.Business.Entities;
using DataIntegrationHub.Business.Entities;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;

namespace TicketTracker.Business.Workflows.Email
{
    /// <summary>
    /// Represents an object responsible for sending emails regarding a selected <see cref="Ticket"/>.
    /// </summary>
    public class TicketEmails
    {
        public Guid CreatedBy { get; private set; }

        /// <summary>
        /// Represents an object that sends emails via pre-configured SMTP.
        /// </summary>
        public EmailSender EmailSender { get; private set; }

        /// <summary>
        /// Represents the selected ticket for which all emails will be sent.
        /// </summary>
        public Ticket CurrentTicket { get; private set; }

        /// <summary>
        /// Creates an instance of the <see cref="TicketEmails"/> class using the specified <see cref="Ticket"/>.
        /// </summary>
        /// <param name="_ticket">Used to create emails and get related data.</param>
        public TicketEmails(Ticket _ticket)
        {
            CurrentTicket = _ticket;
            EmailSender = new EmailSender();
        }

        /// <summary>
        /// Represents HTML string of table rows of all ticket times entered against ticket.
        /// </summary>
        /// <param name="totalDurationMinutes">Outs the calculated total duration to complete ticket.</param>
        /// <returns>Returns HTML string of table rows of all ticket times entered against ticket.</returns>
        private string getTicketTimeHtmlTableRows(out decimal totalDurationMinutes)
        {
            string ticketSummary = null;

            totalDurationMinutes = 0;
            foreach (TicketTime ticketTime in TicketTime.AssociatedTicketTimes(CurrentTicket))
            {
                totalDurationMinutes += ticketTime.DurationMinutes;

                ticketSummary = ticketSummary +
                    @"  <tr>
                            <td>" + ticketTime.SubjectValue + @"</td>
                            <td>" + ticketTime.StartTime.ToString("MMM d hh:mm tt") + @"</td>
                            <td>" + ticketTime.DurationMinutes.ToString("N2") + @"</td>
                        </tr>";
            }

            return ticketSummary;
        }

        /// <summary>
        /// Creates and sends email for ticket that has been completed using the <see cref="EmailSender"/> class.
        /// </summary>
        public void SendTicketCompleteNotification()
        {
            User requester = new User(CurrentTicket.RequestedBy);
            User owner = new User(CurrentTicket.OwnerId);
            StringMap priorityLevel = new StringMap(CurrentTicket.PriorityLevelId);

            decimal durationMinutes = 0;
            string ticketSummary = getTicketTimeHtmlTableRows(out durationMinutes);
            TimeSpan timeSpan = TimeSpan.FromMinutes((double)durationMinutes);

            EmailSender = new EmailSender();
            EmailSender.ToRecipients.Add(requester.EmailAddress);

            EmailSender.Subject = "An open ticket has been marked completed: " + CurrentTicket.SubjectValue;

            EmailSender.Body = Properties.Resources.TicketComplete;
            EmailSender.Body = EmailSender.Body.Replace("{txtStyle}", Properties.Resources.Style);
            EmailSender.Body = EmailSender.Body.Replace("{lblFirstName}", requester.FirstName);
            EmailSender.Body = EmailSender.Body.Replace("{lblTicketSubject}", CurrentTicket.SubjectValue);
            EmailSender.Body = EmailSender.Body.Replace("{lblTicketHours}", timeSpan.Hours.ToString());
            EmailSender.Body = EmailSender.Body.Replace("{lblTicketMinutes}", timeSpan.Minutes.ToString());
            EmailSender.Body = EmailSender.Body.Replace("{lblTicketOwner}", owner.FirstName);
            EmailSender.Body = EmailSender.Body.Replace("{txtRegarding}", CurrentTicket.TicketId.ToString());
            EmailSender.Body = EmailSender.Body.Replace("{trSummary}", ticketSummary);

            EmailSender.Send();
        }

        /// <summary>
        /// Creates and sends email for ticket that has changed its priority level using the <see cref="EmailSender"/> class.
        /// </summary>
        public void SendTicketPriorityChangedNotification()
        {
            User requester = new User(CurrentTicket.RequestedBy);
            User lastModifiedBy = new User(CurrentTicket.ModifiedBy);
            User owner = new User(CurrentTicket.OwnerId);
            StringMap priorityLevel = new StringMap(CurrentTicket.PriorityLevelId);

            decimal durationMinutes = 0;
            string ticketSummary = getTicketTimeHtmlTableRows(out durationMinutes);
            TimeSpan timeSpan = TimeSpan.FromMinutes((double)durationMinutes);

            EmailSender = new EmailSender();
            EmailSender.ToRecipients.Add(requester.EmailAddress);

            EmailSender.Subject = "The priority level of an open ticket has changed.";

            EmailSender.Body = Properties.Resources.TicketPriorityChanged;
            EmailSender.Body = EmailSender.Body.Replace("{txtStyle}", Properties.Resources.Style);
            EmailSender.Body = EmailSender.Body.Replace("{lblFirstName}", requester.FirstName);
            EmailSender.Body = EmailSender.Body.Replace("{lblTicketSubject}", CurrentTicket.SubjectValue);
            EmailSender.Body = EmailSender.Body.Replace("{lblTicketHours}", timeSpan.Hours.ToString());
            EmailSender.Body = EmailSender.Body.Replace("{lblTicketMinutes}", timeSpan.Minutes.ToString());
            EmailSender.Body = EmailSender.Body.Replace("{lblPriorityLevel}", priorityLevel.StringValue);
            EmailSender.Body = EmailSender.Body.Replace("{lblModifiedBy}", lastModifiedBy.FirstName);
            EmailSender.Body = EmailSender.Body.Replace("{lblOwnerIdName}", owner.FullName);

            EmailSender.Send();
        }

        /// <summary>
        /// Creates and sends email for ticket that has changed its target date using the <see cref="EmailSender"/> class.
        /// </summary>
        public void SendTicketTargetDateChangedNotification()
        {
            User requester = new User(CurrentTicket.RequestedBy);
            User lastModifiedBy = new User(CurrentTicket.ModifiedBy);
            User owner = new User(CurrentTicket.OwnerId);
            StringMap priorityLevel = new StringMap(CurrentTicket.PriorityLevelId);

            decimal durationMinutes = 0;
            string ticketSummary = getTicketTimeHtmlTableRows(out durationMinutes);
            TimeSpan timeSpan = TimeSpan.FromMinutes((double)durationMinutes);

            EmailSender = new EmailSender();
            EmailSender.ToRecipients.Add(requester.EmailAddress);

            EmailSender.Subject = "The target date of an open ticket has changed.";

            EmailSender.Body = Properties.Resources.TicketTargetChanged;
            EmailSender.Body = EmailSender.Body.Replace("{txtStyle}", Properties.Resources.Style);
            EmailSender.Body = EmailSender.Body.Replace("{lblFirstName}", requester.FirstName);
            EmailSender.Body = EmailSender.Body.Replace("{lblTicketSubject}", CurrentTicket.SubjectValue);
            EmailSender.Body = EmailSender.Body.Replace("{lblTicketHours}", timeSpan.Hours.ToString());
            EmailSender.Body = EmailSender.Body.Replace("{lblTicketMinutes}", timeSpan.Minutes.ToString());
            EmailSender.Body = EmailSender.Body.Replace("{lblModifiedBy}", lastModifiedBy.FirstName);
            EmailSender.Body = EmailSender.Body.Replace("{lblOwnerIdName}", owner.FullName);

            if (CurrentTicket.TargetDate != null)
            {
                EmailSender.Body = EmailSender.Body.Replace("{lblTargetDate}", ((DateTime)CurrentTicket.TargetDate).ToString("MMMM dd, yyyy"));
            }
            else
            {
                EmailSender.Body = EmailSender.Body.Replace("{lblTargetDate}", "undetermined");
            }

            EmailSender.Send();
        }

        /// <summary>
        /// Creates and sends email for ticket that has been created using the <see cref="EmailSender"/> class.
        /// </summary>
        public void SendTicketReceiptNotification()
        {
            User requester = new User(CurrentTicket.RequestedBy);
            User owner = new User(CurrentTicket.OwnerId);
            StringMap priorityLevel = new StringMap(CurrentTicket.PriorityLevelId);

            EmailSender = new EmailSender();
            EmailSender.ToRecipients.Add(requester.EmailAddress);

            EmailSender.Subject = "A new IT ticket has been created for you.";

            EmailSender.Body = Properties.Resources.TicketReceipt;
            EmailSender.Body = EmailSender.Body.Replace("{txtStyle}", Properties.Resources.Style);
            EmailSender.Body = EmailSender.Body.Replace("{lblFirstName}", requester.FirstName);
            EmailSender.Body = EmailSender.Body.Replace("{lblTicketSubject}", CurrentTicket.SubjectValue);
            EmailSender.Body = EmailSender.Body.Replace("{lblOwnerIdName}", owner.FullName);
            EmailSender.Body = EmailSender.Body.Replace("{lblPriorityLevel}", priorityLevel.StringValue);

            if (CurrentTicket.TargetDate != null)
            {
                EmailSender.Body = EmailSender.Body.Replace("{lblTargetDate}", ((DateTime)CurrentTicket.TargetDate).ToString("MMMM dd, yyyy"));
            }
            else
            {
                EmailSender.Body = EmailSender.Body.Replace("{lblTargetDate}", "undetermined");
            }

            EmailSender.Send();
        }

        /// <summary>
        /// Creates and sends email for a weekly ticket update using the <see cref="EmailSender"/> class.
        /// </summary>
        public void SendWeeklyUpdate(Guid createdBy)
        {
            CreatedBy = createdBy;

            User requestedBy = new User(CurrentTicket.RequestedBy);
            User owner = new User(CurrentTicket.OwnerId);
            StringMap priorityLevel = new StringMap(CurrentTicket.PriorityLevelId);

            List<TicketTime> ticketTimesEnteredInPastWeek = CurrentTicket.TicketTimesInPastWeek();
            List<Task> tasksCompletedInPastWeek = CurrentTicket.TasksCompletedInPastWeek();
            List<Task> tasksCreatedInPastWeek = CurrentTicket.TasksCreatedInPastWeek();

            string ticketTimeSummary = null;
            foreach (TicketTime ticketTime in ticketTimesEnteredInPastWeek)
            {
                ticketTimeSummary = ticketTimeSummary +
                    @"  <tr>
                        <td>" + ticketTime.SubjectValue + @"</td>
                        <td>" + ticketTime.StartTime.ToString("MMM d h:mm tt") + @"</td>
                        <td>" + ticketTime.DurationMinutes.ToString("N2") + @"</td>
                    </tr>";
            }

            string ticketTaskCompletedSummary = null;
            foreach (Task task in tasksCompletedInPastWeek)
            {
                StringMap stringMap = new StringMap(task.StatusId);
                ticketTaskCompletedSummary = ticketTaskCompletedSummary +
                    @"  <tr>
                        <td>" + stringMap.StringValue + @"</td>
                        <td>" + task.SubjectValue + @"</td>
                        <td>" + ((DateTime)task.CompletedOn).ToString("MMM d h:mm tt") + @"</td>
                    </tr>";
            }

            string ticketTaskCreatedSummary = null;
            foreach (Task task in tasksCreatedInPastWeek)
            {
                StringMap stringMap = new StringMap(task.StatusId);
                ticketTaskCreatedSummary = ticketTaskCreatedSummary +
                    @"  <tr>
                        <td>" + stringMap.StringValue + @"</td>
                        <td>" + task.SubjectValue + @"</td>
                        <td>" + ((DateTime)task.CreatedOn).ToString("MMM d h:mm tt") + @"</td>
                    </tr>";
            }

            EmailSender.ToRecipients.Add(requestedBy.EmailAddress);

            EmailSender.Subject = "Your weekly summary for the following ticket: " + CurrentTicket.SubjectValue;

            EmailSender.Body = Properties.Resources.WeeklyEmail;
            EmailSender.Body = EmailSender.Body.Replace("{lblFirstName}", requestedBy.FirstName);
            EmailSender.Body = EmailSender.Body.Replace("{lblTicketSubject}", CurrentTicket.SubjectValue);
            EmailSender.Body = EmailSender.Body.Replace("{lblTicketHours}", Math.Floor(CurrentTicket.Duration().TotalHours).ToString());
            EmailSender.Body = EmailSender.Body.Replace("{lblTicketMinutes}", CurrentTicket.Duration().Minutes.ToString());
            EmailSender.Body = EmailSender.Body.Replace("{lblTicketOwner}", owner.FirstName);
            EmailSender.Body = EmailSender.Body.Replace("{trTicketSummary}", ticketTimeSummary);
            EmailSender.Body = EmailSender.Body.Replace("{trTaskCompleteSummary}", ticketTaskCompletedSummary);
            EmailSender.Body = EmailSender.Body.Replace("{trTaskCreatedSummary}", ticketTaskCreatedSummary);

            if (tasksCompletedInPastWeek.Count == 0)
            {
                EmailSender.Body = EmailSender.Body.Replace("<div id=\"recent-tasks-completed\">", "<div id=\"recent-tasks-completed\" style=\"display: none;\">");
                EmailSender.Body = EmailSender.Body.Replace("<table class=\"task-table-completed\">", "<table class=\"task-table-completed\" style=\"display: none;\">");
            }

            if (tasksCreatedInPastWeek.Count == 0)
            {
                EmailSender.Body = EmailSender.Body.Replace("<div id=\"recent-tasks-created\">", "<div id=\"recent-tasks-created\" style=\"display: none;\">");
                EmailSender.Body = EmailSender.Body.Replace("<table class=\"task-table-created\">", "<table class=\"task-table-created\" style=\"display: none;\">");
            }

            if (tasksCreatedInPastWeek.Count == 0 && tasksCompletedInPastWeek.Count == 0)
            {
                EmailSender.Body = EmailSender.Body.Replace("<p id=\"no-tasks\" style=\"display: none;\">", "<p id=\"no-tasks\">");
            }

            if (ticketTimesEnteredInPastWeek.Count == 0)
            {
                EmailSender.Body = EmailSender.Body.Replace("<div id=\"recent-time-entries\">", "<div id=\"recent-time-entries\" style=\"display: none;\">");
                EmailSender.Body = EmailSender.Body.Replace("<table class=\"time-table\">", "<table class=\"time-table\" style=\"display: none;\">");
            }

            if (ticketTimesEnteredInPastWeek.Count == 0)
            {
                EmailSender.Body = EmailSender.Body.Replace("<p id=\"no-time-entries\" style=\"display: none;\">", "<p id=\"no-time-entries\">");
            }

            EmailSender.EmailSuccessfullySent += EmailSender_EmailSuccesfullySent;

            EmailSender.Send();

        }

        private void EmailSender_EmailSuccesfullySent(object sender, EventArgs e)
        {
            WeeklyEmailSend weeklyEmailSend = new WeeklyEmailSend();
            weeklyEmailSend.TicketId = CurrentTicket.TicketId;
            weeklyEmailSend.Subject = EmailSender.Subject;
            weeklyEmailSend.BodyHtml = EmailSender.Body;
            weeklyEmailSend.ToRecipients = EmailSender.ToRecipients.ToString();
            weeklyEmailSend.ToRecipients = String.Join(";", EmailSender.ToRecipients.ToArray());
            weeklyEmailSend.SaveRecordToDatabase(CreatedBy);
        }
    }
}
