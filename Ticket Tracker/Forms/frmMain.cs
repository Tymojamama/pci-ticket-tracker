using DataIntegrationHub.Business.Entities;
using TicketTracker.Business.Entities;
using TicketTracker.Business.Components;
using TicketTracker.Business.Workflows.Email;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketTracker.Presentation.Forms
{
    public partial class frmMain : Form, IMessageFilter
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private HashSet<Control> controlsToMove = new HashSet<Control>();

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN &&
                 controlsToMove.Contains(Control.FromHandle(m.HWnd)))
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }

        public User CurrentUser;

        /// <summary>
        /// Represents the total number of emails that are queued to send.
        /// </summary>
        /// <remarks>
        /// This is used to identify when a list of emails have all completed sending.
        /// </remarks>
        private int _totalEmailsToSend = 0;

        public frmMain()
        {
            this.Enabled = false;

            InitializeComponent();

            if (Database.Succeeded())
                this.Enabled = true;
            else
                return;

            //Set maximum size
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

            //Add controls to move the form
            Application.AddMessageFilter(this);
            controlsToMove.Add(this.lblFormHeader);
            controlsToMove.Add(this.pnlFormHeader);
            controlsToMove.Add(this.pnlFormBody);

            cboViews.SelectedIndex = 0;

            string _userName = Environment.UserDomainName + "\\" + Environment.UserName;
            CurrentUser = new User(_userName);
        }

        private void MaximizeForm()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

            // We have to refresh ComboBoxes because they don't draw well after performing this function.
            foreach (ComboBox comboBox in GetAll(this, typeof(ComboBox)))
            {
                comboBox.Refresh();
            }
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void btnOpenTicketTime_Click(object sender, EventArgs e)
        {
            if (dgvTickets.Rows.Count == 0 || dgvTickets.DataSource == null || dgvTickets.CurrentCell == null)
                return;

            int _index = dgvTickets.CurrentCell.RowIndex;
            Guid _ticketId = new Guid(dgvTickets.Rows[_index].Cells["TicketId"].Value.ToString());
            Ticket _ticket = new Ticket(_ticketId);

            frmTicketTime _frmTicketTime = new frmTicketTime(_ticket);
            _frmTicketTime.ParentForm = this;
        }

        private void lblFormClose_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                DialogResult _dialogResult = MessageBox.Show("Are you sure you wish to exit? Any unsaved work will be permanently lost.", "Attention", MessageBoxButtons.YesNoCancel);
                if (_dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void lblFormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelGray_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = System.Drawing.Color.Black;
            label.BackColor = System.Drawing.Color.DarkGray;
        }

        private void labelGray_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = System.Drawing.Color.White;
            label.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }

        private void cboViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTicketsLoad();
        }

        public void dgvTicketsLoad()
        {
            dgvTickets.Columns.Clear();

            if (cboViews.SelectedIndex == 0)
            {
                dgvTickets.DataSource = Ticket.GetInProgress();
            }
            else if (cboViews.SelectedIndex == 1)
            {
                dgvTickets.DataSource = Ticket.GetActive();
            }
            else if (cboViews.SelectedIndex == 2)
            {
                dgvTickets.DataSource = Ticket.GetInactive();
            }

            if (dgvTickets.DataSource != null)
            {
                dgvTickets.Columns["TicketId"].Visible = false;
                dgvTickets.Columns["Subject"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTickets.Columns["Hours Completed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }

            calculateCapacity();
        }

        public void dgvTicketsSelectCell(Guid _guid)
        {
            foreach (DataGridViewRow _dataRow in this.dgvTickets.Rows)
            {
                if (new Guid(_dataRow.Cells["TicketId"].Value.ToString()) == _guid)
                {
                    this.dgvTickets.CurrentCell = this.dgvTickets.Rows[_dataRow.Index].Cells["Subject"];
                    break;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmTicket _frmTicket = new frmTicket();
            _frmTicket.ParentForm = this;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTickets.Rows.Count == 0 || dgvTickets.DataSource == null || dgvTickets.CurrentCell == null)
                return;

            int _index = dgvTickets.CurrentCell.RowIndex;
            Guid _ticketId = new Guid(dgvTickets.Rows[_index].Cells["TicketId"].Value.ToString());
            Ticket _ticket = new Ticket(_ticketId);

            frmTicket _frmTicket = new frmTicket(_ticket);
            _frmTicket.ParentForm = this;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTickets.Rows.Count == 0 || dgvTickets.DataSource == null || dgvTickets.CurrentCell == null)
                return;

            int _index = dgvTickets.CurrentCell.RowIndex;
            Guid _ticketId = new Guid(dgvTickets.Rows[_index].Cells["TicketId"].Value.ToString());
            Ticket _ticket = new Ticket(_ticketId);

            DialogResult _dialogResult = MessageBox.Show("Are you sure you wish to delete the selected ticket " + _ticket.SubjectValue + "?", "Attention", MessageBoxButtons.YesNoCancel);
            if (_dialogResult == DialogResult.Yes)
            {
                _ticket.DeleteDatabaseRecord();
                dgvTicketsLoad();
            }
        }

        private void dgvTickets_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTickets.Rows.Count == 0 || dgvTickets.DataSource == null || dgvTickets.CurrentCell == null)
                return;

            int _index = dgvTickets.CurrentCell.RowIndex;
            string subjectValue = dgvTickets.Rows[_index].Cells["Subject"].Value.ToString();

            lblSelectedTicket.Text = subjectValue;
        }

        private void dgvTickets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTickets.Rows.Count == 0 || dgvTickets.DataSource == null || dgvTickets.CurrentCell == null)
                return;

            int _index = dgvTickets.CurrentCell.RowIndex;
            Guid _ticketId = new Guid(dgvTickets.Rows[_index].Cells["TicketId"].Value.ToString());
            Ticket _ticket = new Ticket(_ticketId);

            frmTicket _frmTicket = new frmTicket(_ticket);
            _frmTicket.ParentForm = this;
        }

        private void recordTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTickets.Rows.Count == 0 || dgvTickets.DataSource == null || dgvTickets.CurrentCell == null)
                return;

            int _index = dgvTickets.CurrentCell.RowIndex;
            Guid _ticketId = new Guid(dgvTickets.Rows[_index].Cells["TicketId"].Value.ToString());
            Ticket _ticket = new Ticket(_ticketId);

            frmTicketTime _frmTicketTime = new frmTicketTime(_ticket);
            _frmTicketTime.ParentForm = this;
            _frmTicketTime.btnTimerGo.PerformClick();

        }

        private void dgvTickets_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                dgvTickets.ContextMenuStrip = cmMain;

                DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                if (!c.Selected)
                {
                    c.DataGridView.ClearSelection();
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                }
            }
            else
            {
                dgvTickets.ContextMenuStrip = null;
            }
        }

        private void openTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTickets.Rows.Count == 0 || dgvTickets.DataSource == null || dgvTickets.CurrentCell == null)
                return;

            int _index = dgvTickets.CurrentCell.RowIndex;
            Guid _ticketId = new Guid(dgvTickets.Rows[_index].Cells["TicketId"].Value.ToString());
            Ticket _ticket = new Ticket(_ticketId);

            frmTicket _frmTicket = new frmTicket(_ticket);
            _frmTicket.ParentForm = this;
        }

        private void completeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTickets.Rows.Count == 0 || dgvTickets.DataSource == null || dgvTickets.CurrentCell == null)
                return;

            int index = dgvTickets.CurrentCell.RowIndex;
            Guid ticketId = new Guid(dgvTickets.Rows[index].Cells["TicketId"].Value.ToString());
            Ticket ticket = new Ticket(ticketId);
            ticket.SetDatabaseRecordCompleted(CurrentUser.UserId);

            dgvTicketsLoad();
            dgvTicketsSelectCell(ticket.TicketId);
        }

        private void inProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTickets.Rows.Count == 0 || dgvTickets.DataSource == null || dgvTickets.CurrentCell == null)
                return;

            int _index = dgvTickets.CurrentCell.RowIndex;
            Guid _ticketId = new Guid(dgvTickets.Rows[_index].Cells["TicketId"].Value.ToString());
            Ticket _ticket = new Ticket(_ticketId);
            _ticket.SetDatabaseRecordInProgress(CurrentUser.UserId);

            dgvTicketsLoad();
            dgvTicketsSelectCell(_ticket.TicketId);
        }

        private void abandondedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTickets.Rows.Count == 0 || dgvTickets.DataSource == null || dgvTickets.CurrentCell == null)
                return;

            int _index = dgvTickets.CurrentCell.RowIndex;
            Guid _ticketId = new Guid(dgvTickets.Rows[_index].Cells["TicketId"].Value.ToString());
            Ticket _ticket = new Ticket(_ticketId);
            _ticket.SetDatabaseRecordAbandonded(CurrentUser.UserId);

            dgvTicketsLoad();
            dgvTicketsSelectCell(_ticket.TicketId);
        }

        public void Notify(string _message, ToolTipIcon _icon)
        {
            niMain.Icon = SystemIcons.Application;
            niMain.BalloonTipIcon = _icon;
            niMain.BalloonTipText = _message;
            niMain.ShowBalloonTip(1000);
        }

        private void pnlFormHeader_DoubleClick(object sender, EventArgs e)
        {
            MaximizeForm();
        }

        private void btnSendWeeklyEmail_Click(object sender, EventArgs e)
        {
            btnSendWeeklyEmail.Text = "Sending...";
            btnSendWeeklyEmail.Enabled = false;

            SendAllWeeklyEmails();
        }

        /// <summary>
        /// Sends weekly update emails to the requestors of all tickets that have not received an email in
        /// the past week and have not been created in the past week.
        /// </summary>
        private void SendAllWeeklyEmails()
        {
            List<TicketEmails> ticketEmailsToSend = new List<TicketEmails>();

            Guid createdBy = CurrentUser.UserId;

            foreach (Ticket ticket in Ticket.InProgressTickets())
            {
                if (ticket.CreatedInPastWeek() == false && ticket.HasReceivedWeeklyEmailInPastWeek() == false)
                {
                    TicketEmails ticketEmails = new TicketEmails(ticket);
                    ticketEmails.EmailSender.EmailSuccessfullySent += ticketEmails_EmailSuccesfullySent;
                    ticketEmails.EmailSender.EmailFailedToSend += ticketEmails_EmailFailedToSend;

                    ticketEmailsToSend.Add(ticketEmails);
                }
            }

            if (ticketEmailsToSend.Count == 0)
            {
                btnSendWeeklyEmail.Text = "Email All";
                MessageBox.Show("No emails were sent!", "Email Send Complete", MessageBoxButtons.OK);
                btnSendWeeklyEmail.Enabled = true;
            }
            else
            {
                btnSendWeeklyEmail.Text = "Sent 0!";
                btnSendWeeklyEmail.Enabled = false;

                _totalEmailsToSend = ticketEmailsToSend.Count;

                foreach (TicketEmails ticketEmails in ticketEmailsToSend)
                {
                    ticketEmails.SendWeeklyUpdate(createdBy);
                }
            }
        }

        private void ticketEmails_EmailSuccesfullySent(object sender, EventArgs e)
        {
            string integer = btnSendWeeklyEmail.Text.Replace("Sent ", "").Replace("!", "");
            int currentCount = Int32.Parse(integer);
            currentCount++;

            if (currentCount == _totalEmailsToSend)
            {
                btnSendWeeklyEmail.Text = "Email All";
                MessageBox.Show(currentCount.ToString() + " emails were sent!", "Email Send Complete", MessageBoxButtons.OK);
                btnSendWeeklyEmail.Enabled = true;
            }
            else
            {
                btnSendWeeklyEmail.Text = "Sent " + currentCount.ToString() + "!";
                btnSendWeeklyEmail.Enabled = false;
            }
        }

        private void ticketEmails_EmailFailedToSend(object sender, EventArgs e)
        {
            //btnSendWeeklyEmail.Text = "Failed!";
            //btnSendWeeklyEmail.Enabled = false;
        }

        private void calculateCapacity()
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            backgroundWorker.RunWorkerAsync();
        }

        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblCapacity.Text = "Weeks to complete tasks: " + e.Result.ToString();
        }

        void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Ticket> ActiveTickets = Ticket.ActiveTickets();

            decimal estimatedHours;
            if (ActiveTickets.Sum(t => t.EstimatedHours) == null)
            {
                estimatedHours = 0;
            }
            else
            {
                estimatedHours = (decimal)ActiveTickets.Sum(t => t.EstimatedHours);
            }

            decimal completedHours;
            if (ActiveTickets.Sum(t => t.CompletedHours) == null)
            {
                completedHours = 0;
            }
            else
            {
                completedHours = (decimal)ActiveTickets.Sum(t => t.CompletedHours);
            }

            int taskCount = ActiveTickets.Count;

            decimal weeksToComplete = Decimal.Round((estimatedHours - completedHours) / 30.6m, 2);

            e.Result = weeksToComplete;
        }
    }
}
