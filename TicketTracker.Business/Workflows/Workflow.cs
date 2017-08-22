using PensionConsultants.Data;
using TicketTracker.Business.Entities;
using TicketTracker.Business.Workflows.Email;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTracker.Business.Workflows
{
    public class Workflow
    {
        public readonly object Object;
        private readonly WorkflowTypes WorkflowType;

        private enum WorkflowTypes
        {
            Ticket,
            TicketTime
        }

        public Workflow(Ticket _ticket)
        {
            Object = _ticket;
            WorkflowType = WorkflowTypes.Ticket;
        }

        public Workflow(TicketTime _ticketTime)
        {
            Object = _ticketTime;
            WorkflowType = WorkflowTypes.TicketTime;
        }

        public void RunWorkflow()
        {
            switch (WorkflowType)
            {
                case WorkflowTypes.Ticket :
                    // Setup objects
                    Ticket _ticket = (Ticket)Object;
                    TicketEmails _ticketEmails = new TicketEmails(_ticket);

                    if (_ticket.InstantiatedTicket != null)
                    {
                        if (_ticket.StateCode == 1 & _ticket.InstantiatedTicket.StateCode == 1)
                            break;
                    }

                    // New ticket created
                    if (_ticket.InstantiatedTicket == null && _ticket.ExistingRecord == true)
                    {
                        _ticketEmails.SendTicketReceiptNotification();
                    }
                    // Priority changed
                    else if (_ticket.InstantiatedTicket.PriorityLevelId != _ticket.PriorityLevelId && _ticket.StateCode == 0)
                    {
                        _ticketEmails.SendTicketPriorityChangedNotification();
                    }
                    // Target date changed
                    else if (_ticket.InstantiatedTicket.TargetDate != _ticket.TargetDate && _ticket.StateCode == 0)
                    {
                        _ticketEmails.SendTicketTargetDateChangedNotification();
                    }
                    // Status set to completed
                    else if (_ticket.InstantiatedTicket.StatusId != _ticket.StatusId && _ticket.StatusId == new Guid("9704C561-B65B-4073-9939-202E9CCD6A87"))
                    {
                        _ticketEmails.SendTicketCompleteNotification();
                    }

                    break;

                case WorkflowTypes.TicketTime:
                    // Setup objects
                    TicketTime _ticketTime = (TicketTime)Object;
                    TicketTimeEmails _ticketTimeEmails = new TicketTimeEmails(_ticketTime);

                    break;
            }
        }
    }
}
