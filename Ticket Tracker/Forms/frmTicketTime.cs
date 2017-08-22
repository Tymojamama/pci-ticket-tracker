using TicketTracker.Business.Entities;
using TicketTracker.Business.Components;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketTracker.Presentation.Forms
{
    public partial class frmTicketTime : Form, IMessageFilter
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

        public Form ParentForm;

        public Ticket ParentTicket;
        public TicketTime CurrentTicketTime;

        private Stopwatch stopWatch = new Stopwatch();
        private bool isUnsaved = false;

        public frmTicketTime(Ticket _ticket)
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

            ParentTicket = _ticket;
            txtTicket.Text = ParentTicket.SubjectValue;

            CurrentTicketTime = new TicketTime();
            CurrentTicketTime.TicketId = ParentTicket.TicketId;

            this.Show();
        }

        public frmTicketTime(TicketTime _ticketTime)
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

            CurrentTicketTime = _ticketTime;

            ParentTicket = new Ticket(CurrentTicketTime.TicketId);
            txtTicket.Text = ParentTicket.SubjectValue;

            txtSubject.Text = CurrentTicketTime.SubjectValue;
            txtDescription.Text = CurrentTicketTime.DescriptionValue;
            txtStartTime.Text = CurrentTicketTime.StartTime.ToString("MM/dd/yyyy hh:mm tt");
            txtEndTime.Text = CurrentTicketTime.EndTime.ToString("MM/dd/yyyy hh:mm tt");
            TimeSpan _timeSpan = TimeSpan.FromMinutes((double)CurrentTicketTime.DurationMinutes);
            txtDuration.Text = Convert.ToString(String.Format("{0:00}:{1:00}:{2:00}", _timeSpan.Hours, _timeSpan.Minutes, _timeSpan.Seconds));

            this.Show();
        }

        private void DockFormLowerRight()
        {
            Screen _screen = Screen.FromControl(this);

            if(this.Left == _screen.WorkingArea.Right - this.Width && this.Top == _screen.WorkingArea.Bottom - this.Height)
            {
                this.CenterToScreen();
            }
            else
            {
                this.Left = _screen.WorkingArea.Right - this.Width;
                this.Top = _screen.WorkingArea.Bottom - this.Height;
            }
        }

        private void lblFormClose_Click(object sender, EventArgs e)
        {
            if (isUnsaved)
            {
                DialogResult _dialogResult = MessageBox.Show("Are you sure you wish to exit without saving?", "Attention", MessageBoxButtons.YesNoCancel);
                if (_dialogResult != DialogResult.Yes)
                    return;
            }

            stopWatch.Stop();
            this.Close();
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

        private void btnTimerGo_Click(object sender, EventArgs e)
        {
            isUnsaved = true;

            TimeSpan timeSpan = stopWatch.Elapsed + TimeSpan.FromMinutes((double)CurrentTicketTime.DurationMinutes);

            if (btnTimerGo.Text == "Start")
            {
                txtSubject.Select();

                stopWatch.Start();
                btnTimerGo.Text = "Stop";

                if (String.IsNullOrWhiteSpace(txtStartTime.Text))
                {
                    txtStartTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
                }

                txtEndTime.Text = null;

                while (timeSpan.Hours < 10 && stopWatch.IsRunning == true)
                {
                    timeSpan = stopWatch.Elapsed + TimeSpan.FromMinutes((double)CurrentTicketTime.DurationMinutes);

                    txtDuration.Text = Convert.ToString(String.Format("{0:00}:{1:00}:{2:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds));
                    Application.DoEvents();
                }
            }
            else if (btnTimerGo.Text == "Stop")
            {
                stopWatch.Stop();
                btnTimerGo.Text = "Start";

                //Set End Time text value
                txtEndTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");

                // Format and display the TimeSpan value.
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
                txtDuration.Text = elapsedTime;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnTimerGo.Text == "Stop")
            {
                btnTimerGo.PerformClick();
            }

            frmMain frmMain = (frmMain)ParentForm;

            CurrentTicketTime.SubjectValue = txtSubject.Text;
            CurrentTicketTime.DescriptionValue = txtDescription.Text;

            if (String.IsNullOrWhiteSpace(txtStartTime.Text))
            {
                MessageBox.Show("Start time field cannot be blank. Please correct and try again.", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                try
                {
                    CurrentTicketTime.StartTime = DateTime.Parse(txtStartTime.Text);
                }
                catch
                {
                    MessageBox.Show("Start time field is not in a recognizable format. Please correct and try again.", "Error", MessageBoxButtons.OK);
                    return;
                }
            }

            if (String.IsNullOrWhiteSpace(txtEndTime.Text))
            {
                MessageBox.Show("End time field cannot be blank. Please correct and try again.", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                try
                {
                    CurrentTicketTime.EndTime = DateTime.Parse(txtEndTime.Text);
                }
                catch
                {
                    MessageBox.Show("End time field is not in a recognizable format. Please correct and try again.", "Error", MessageBoxButtons.OK);
                    return;
                }
            }

            if (String.IsNullOrWhiteSpace(txtDuration.Text))
            {
                MessageBox.Show("Duration field cannot be blank. Please correct and try again.", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                try
                {
                    TimeSpan duration = TimeSpan.Parse(txtDuration.Text);
                    CurrentTicketTime.DurationMinutes = (decimal)duration.TotalMinutes;
                }
                catch
                {
                    MessageBox.Show("Duration field is not in a recognizable format. Please correct and try again.", "Error", MessageBoxButtons.OK);
                    return;
                }
            }

            CurrentTicketTime.SaveRecordToDatabase(frmMain.CurrentUser.UserId);

            frmMain.dgvTicketsLoad();
            frmMain.dgvTicketsSelectCell(ParentTicket.TicketId);

            isUnsaved = false;

            this.Close();
        }

        private void btnTimerReset_Click(object sender, EventArgs e)
        {
            DialogResult _dialogResult = MessageBox.Show("Are you sure you wish to reset the entered time?", "Attention", MessageBoxButtons.YesNoCancel);

            if (_dialogResult != DialogResult.Yes)
                return;

            stopWatch.Reset();
            btnTimerGo.Text = "Start";
            CurrentTicketTime.DurationMinutes = 0;
            txtDuration.Text = null;
            txtStartTime.Text = null;
            txtEndTime.Text = null;
        }

        private void addCurrentTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem _toolStripMenuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip _contextMenuStrip = (ContextMenuStrip)_toolStripMenuItem.Owner;
            
            if (_contextMenuStrip.SourceControl is RichTextBox)
            {
                RichTextBox _richTextBox = (RichTextBox)_contextMenuStrip.SourceControl;
                _richTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            }
        }

        private void pnlFormHeader_DoubleClick(object sender, EventArgs e)
        {
            DockFormLowerRight();
        }

        private void calculateDurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime startTime;
            DateTime endTime;

            try
            {
                startTime = DateTime.Parse(txtStartTime.Text);
                endTime = DateTime.Parse(txtEndTime.Text);
            }
            catch
            {
                MessageBox.Show("Start Time or End Time field was not in a recognizable datetime format. Please correct and try again.", "Attention", MessageBoxButtons.OK);
                return;
            }

            TimeSpan timeSpan = endTime - startTime;
            txtDuration.Text = String.Format("{0:00}:{1:00}:{2:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            CurrentTicketTime.DurationMinutes = (decimal)timeSpan.TotalMinutes;
            stopWatch.Reset();
        }
    }
}
