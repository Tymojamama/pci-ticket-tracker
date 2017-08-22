using TicketTracker.Data;
using TicketTracker.Service;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketTracker.Reports
{
    public partial class UserReport : System.Web.UI.Page
    {
        public User SelectedUser;
        public Ticket SelectedTicket;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Request.QueryString["UserId"]) || String.IsNullOrWhiteSpace(Request.QueryString["TicketId"]))
                return;

            try
            {
                Guid _userId = new Guid(Request.QueryString["UserId"]);
                SelectedUser = new User(_userId);
                lblFirstName.Text = SelectedUser.FirstName;

                Guid _ticketId = new Guid(Request.QueryString["TicketId"]);
                SelectedTicket = new Ticket(_ticketId);
                lblTicketSubject.Text = SelectedTicket.SubjectValue;
                lblPriorityLevel.Text = (new StringMap(SelectedTicket.PriorityLevelId)).StringValue;

                if (SelectedTicket.TargetDate != null)
                    lblTargetDate.Text = ((DateTime)SelectedTicket.TargetDate).ToString("MMMM dd, yyyy");
            }
            catch
            {
                return;
            }
        }
    }
}