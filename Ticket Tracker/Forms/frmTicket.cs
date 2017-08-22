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
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TicketTracker.Presentation.Forms
{
    public partial class frmTicket : Form, IMessageFilter
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private HashSet<Control> _controlsToMove = new HashSet<Control>();

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN &&
                 _controlsToMove.Contains(Control.FromHandle(m.HWnd)))
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }

        public Ticket CurrentTicket { get; private set; }

        public Form ParentForm;

        private bool _isClosed = false;

        public frmTicket()
        {
            frmSplash _frmSplash = new frmSplash();

            this.Enabled = false;
            this.FormClosed += frmTicket_FormClosed;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

            InitializeComponent();

            if (Database.Succeeded())
            {
                this.Enabled = true;
            }
            else
            {
                MessageBox.Show("A connection to the database could not be established.");
                return;
            }

            InitializeControlsToMove();

            CurrentTicket = new Ticket();

            LoadComboBoxes();
            dgvTicketTimesLoad();

            if (CurrentTicket.StatusId != null)
            {
                StringMap _stringMap = new StringMap((Guid)CurrentTicket.StatusId);
                cboStatus.Text = _stringMap.StringValue;
            }

            _frmSplash.Close();
            this.Show();
        }

        public frmTicket(Ticket _ticket)
        {
            frmSplash _frmSplash = new frmSplash();

            this.Enabled = false;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

            InitializeComponent();

            if (Database.Succeeded())
            {
                this.Enabled = true;
            }
            else
            {
                MessageBox.Show("A connection to the database could not be established.");
                return;
            }

            InitializeControlsToMove();

            CurrentTicket = _ticket;

            LoadComboBoxes();
            dgvTicketTimesLoad();
            SetControlsToTicketValues();

            _frmSplash.Close();
            this.Show();

            this.FormClosed += frmTicket_FormClosed;
        }

        /// <summary>
        /// Add controls to move the form
        /// </summary>
        private void InitializeControlsToMove()
        {
            Application.AddMessageFilter(this);
            _controlsToMove.Add(this.lblFormHeader);
            _controlsToMove.Add(this.pnlFormHeader);
            _controlsToMove.Add(this.pnlBodySummary);
            _controlsToMove.Add(this.pnlBodyTicketTimes);
        }

        /// <summary>
        /// Sets certain controls in the form to values of the CurrentTicket.
        /// </summary>
        private void SetControlsToTicketValues()
        {
            txtSubject.Text = CurrentTicket.SubjectValue;
            txtDescription.Text = CurrentTicket.DescriptionValue;
            cboType.Text = CurrentTicket.Type;

            if (CurrentTicket.EstimatedHours != null)
            {
                txtEstimate.Text = CurrentTicket.EstimatedHours.ToString();
            }

            if (CurrentTicket.CompletedHours != null)
            {
                txtCompleted.Text = CurrentTicket.CompletedHours.ToString();
            }

            if (CurrentTicket.PriorityLevelId != null)
            {
                StringMap _stringMap = new StringMap((Guid)CurrentTicket.PriorityLevelId);
                cboPriorityLevel.Text = _stringMap.StringValue;
            }

            if (CurrentTicket.StatusId != null)
            {
                StringMap _stringMap = new StringMap((Guid)CurrentTicket.StatusId);
                cboStatus.Text = _stringMap.StringValue;
            }

            if (CurrentTicket.DateAssigned != null)
            {
                txtDateAssigned.Text = ((DateTime)CurrentTicket.DateAssigned).ToString("MM/dd/yyyy hh:mm tt");
            }

            if (CurrentTicket.TargetDate != null)
            {
                txtTargetDate.Text = ((DateTime)CurrentTicket.TargetDate).ToString("MM/dd/yyyy hh:mm tt");
            }

            if (CurrentTicket.DateCompleted != null)
            {
                txtDateCompleted.Text = ((DateTime)CurrentTicket.DateCompleted).ToString("MM/dd/yyyy hh:mm tt");
            }

            if (CurrentTicket.OwnerId != null)
            {
                User _owner = new User((Guid)CurrentTicket.OwnerId);
                cboOwner.Text = _owner.FullName;
            }

            if (CurrentTicket.RequestedBy != null)
            {
                User _requestedBy = new User((Guid)CurrentTicket.RequestedBy);
                cboRequestedBy.Text = _requestedBy.FullName;
            }

            this.SetControlsForPriorityTab();
        }

        private void SetControlsForPriorityTab()
        {
            var priorityScore = 0m;
            if (CurrentTicket.PriorityCompetition != null)
            {
                txtPriorityCompetition.Text = ((decimal)CurrentTicket.PriorityCompetition).ToString("#.##");
                priorityScore += (decimal)CurrentTicket.PriorityCompetition;
            }

            if (CurrentTicket.PriorityCompliance != null)
            {
                txtPriorityCompliance.Text = ((decimal)CurrentTicket.PriorityCompliance).ToString("#.##");
                priorityScore += (decimal)CurrentTicket.PriorityCompliance;
            }

            if (CurrentTicket.PriorityEfficiency != null)
            {
                txtPriorityEfficiency.Text = ((decimal)CurrentTicket.PriorityEfficiency).ToString("#.##");
                priorityScore += (decimal)CurrentTicket.PriorityEfficiency;
            }

            if (CurrentTicket.PriorityFirmGoals != null)
            {
                txtPriorityFirmGoals.Text = ((decimal)CurrentTicket.PriorityFirmGoals).ToString("#.##");
                priorityScore += (decimal)CurrentTicket.PriorityFirmGoals;
            }

            if (CurrentTicket.PriorityService != null)
            {
                txtPriorityService.Text = ((decimal)CurrentTicket.PriorityService).ToString("#.##");
                priorityScore += (decimal)CurrentTicket.PriorityService;
            }

            if (CurrentTicket.PriorityTeamGoals != null)
            {
                txtPriorityTeamGoals.Text = ((decimal)CurrentTicket.PriorityTeamGoals).ToString("#.##");
                priorityScore += (decimal)CurrentTicket.PriorityTeamGoals;
            }

            priorityScore = priorityScore / 6m;

            if (CurrentTicket.PriorityOverride != null)
            {
                txtPriorityOverride.Text = ((decimal)CurrentTicket.PriorityOverride).ToString("#.##");
                lblPriorityTotalScore.Text = "Total Score: " + ((decimal)CurrentTicket.PriorityOverride).ToString("#.##");
            }
            else
            {
                lblPriorityTotalScore.Text = "Total Score: " + ((decimal)priorityScore).ToString("#.##");
            }
        }

        private void frmTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            _isClosed = true;
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

        public void LoadComboBoxes()
        {
            foreach (User _user in User.AllUsers())
            {
                if (CurrentTicket.ExistingRecord)
                {
                    cboOwner.Items.Add(new Utilities.ListItem(_user.FullName, _user));
                    cboRequestedBy.Items.Add(new Utilities.ListItem(_user.FullName, _user));
                }
                else if (_user.StateCode == 0)
                {
                    cboOwner.Items.Add(new Utilities.ListItem(_user.FullName, _user));
                    cboRequestedBy.Items.Add(new Utilities.ListItem(_user.FullName, _user));
                }
            }

            foreach (StringMap _stringMap in StringMap.AssociatedStringMaps("Ticket", "PriorityLevelId"))
            {
                cboPriorityLevel.Items.Add(new Utilities.ListItem(_stringMap.StringValue, _stringMap));
            }

            foreach (StringMap _stringMap in StringMap.AssociatedStringMaps("Ticket", "StatusId"))
            {
                cboStatus.Items.Add(new Utilities.ListItem(_stringMap.StringValue, _stringMap));
            }

            cboTasks.SelectedIndex = 0;
        }

        public void dgvTicketTimesLoad()
        {
            dgvTicketTimes.Columns.Clear();

            dgvTicketTimes.DataSource = TicketTime.GetAssociatedFromTicket(CurrentTicket);

            if (dgvTicketTimes.DataSource != null)
            {
                dgvTicketTimes.Columns["TicketTimeId"].Visible = false;
                dgvTicketTimes.Columns["TicketId"].Visible = false;
                dgvTicketTimes.Columns["Subject"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTicketTimes.Columns["Start"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvTicketTimes.Columns["End"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvTicketTimes.Columns["Minutes Completed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }
        }

        private void lblFormClose_Click(object sender, EventArgs e)
        {
            frmMain _frmMain = (frmMain)ParentForm;

            _frmMain.dgvTicketsLoad();
            _frmMain.dgvTicketsSelectCell(CurrentTicket.TicketId);

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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            frmMain frmMain;

            CurrentTicket.SubjectValue = txtSubject.Text;
            CurrentTicket.DescriptionValue = txtDescription.Text;
            CurrentTicket.Type = cboType.SelectedItem.ToString();

            if (cboOwner.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an owner of the Ticket. Please correct and try again.", "Attention", MessageBoxButtons.OK);
                return;
            }

            CurrentTicket.OwnerId = ((User)((Utilities.ListItem)cboOwner.SelectedItem).HiddenObject).UserId;

            if (cboRequestedBy.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a requestor of the Ticket. Please correct and try again.", "Attention", MessageBoxButtons.OK);
                return;
            }
            else
            {
                CurrentTicket.RequestedBy = ((User)((Utilities.ListItem)cboRequestedBy.SelectedItem).HiddenObject).UserId;
            }

            if (cboPriorityLevel.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a priority level of the Ticket. Please correct and try again.", "Attention", MessageBoxButtons.OK);
                return;
            }
            else
            {
                CurrentTicket.PriorityLevelId = ((StringMap)((Utilities.ListItem)cboPriorityLevel.SelectedItem).HiddenObject).StringMapId;
            }

            if (cboStatus.SelectedIndex == -1)
            {
                CurrentTicket.StatusId = null;
            }
            else
            {
                StringMap _stringMap = (StringMap)((Utilities.ListItem)cboStatus.SelectedItem).HiddenObject;
                CurrentTicket.StatusId = _stringMap.StringMapId;

                if (_stringMap.StringValue == "Completed" || _stringMap.StringValue == "Abandonded")
                {
                    CurrentTicket.StateCode = 1;
                }
            }

            if (String.IsNullOrWhiteSpace(txtDateAssigned.Text))
            {
                CurrentTicket.DateAssigned = null;
            }
            else
            {
                try
                {
                    CurrentTicket.DateAssigned = DateTime.Parse(txtDateAssigned.Text);
                }
                catch
                {
                    MessageBox.Show("Date assigned field is in an unrecognizable format.");
                    return;
                }
            }

            if (String.IsNullOrWhiteSpace(txtTargetDate.Text))
            {
                CurrentTicket.TargetDate = null;
            }
            else
            {
                try
                {
                    CurrentTicket.TargetDate = DateTime.Parse(txtTargetDate.Text);
                }
                catch
                {
                    MessageBox.Show("Target date field is in an unrecognizable format.");
                    return;
                }
            }

            if (String.IsNullOrWhiteSpace(txtDateCompleted.Text))
            {
                CurrentTicket.DateCompleted = null;
            }
            else
            {
                try
                {
                    CurrentTicket.DateCompleted = DateTime.Parse(txtDateCompleted.Text);
                }
                catch
                {
                    MessageBox.Show("Date completed field is in an unrecognizable format.");
                    return;
                }
            }

            if (String.IsNullOrWhiteSpace(txtEstimate.Text))
            {
                CurrentTicket.EstimatedHours = null;
            }
            else
            {
                try
                {
                    CurrentTicket.EstimatedHours = Decimal.Parse(txtEstimate.Text);
                }
                catch
                {
                    MessageBox.Show("Estimated Hours field is in an unrecognizable format.");
                    return;
                }
            }

            if (String.IsNullOrWhiteSpace(txtPriorityCompetition.Text))
            {
                CurrentTicket.PriorityCompetition = null;
            }
            else
            {
                if (CurrentTicket.PriorityCompetition < 0 || CurrentTicket.PriorityCompetition > 10)
                {
                    MessageBox.Show("Priority competition field is less than 0 or greater than 10.");
                    return;
                }

                try
                {
                    CurrentTicket.PriorityCompetition = Decimal.Parse(txtPriorityCompetition.Text);
                }
                catch
                {
                    MessageBox.Show("Priority competition field is in an unrecognizable format.");
                    return;
                }
            }

            if (String.IsNullOrWhiteSpace(txtPriorityCompliance.Text))
            {
                CurrentTicket.PriorityCompliance = null;
            }
            else
            {
                if (CurrentTicket.PriorityCompliance < 0 || CurrentTicket.PriorityCompliance > 10)
                {
                    MessageBox.Show("Priority compliance field is less than 0 or greater than 10.");
                    return;
                }

                try
                {
                    CurrentTicket.PriorityCompliance = Decimal.Parse(txtPriorityCompliance.Text);
                }
                catch
                {
                    MessageBox.Show("Priority compliance field is in an unrecognizable format.");
                    return;
                }
            }

            if (String.IsNullOrWhiteSpace(txtPriorityEfficiency.Text))
            {
                CurrentTicket.PriorityEfficiency = null;
            }
            else
            {
                if (CurrentTicket.PriorityEfficiency < 0 || CurrentTicket.PriorityEfficiency > 10)
                {
                    MessageBox.Show("Priority efficiency field is less than 0 or greater than 10.");
                    return;
                }

                try
                {
                    CurrentTicket.PriorityEfficiency = Decimal.Parse(txtPriorityEfficiency.Text);
                }
                catch
                {
                    MessageBox.Show("Priority efficiency field is in an unrecognizable format.");
                    return;
                }
            }

            if (String.IsNullOrWhiteSpace(txtPriorityFirmGoals.Text))
            {
                CurrentTicket.PriorityFirmGoals = null;
            }
            else
            {
                if (CurrentTicket.PriorityFirmGoals < 0 || CurrentTicket.PriorityFirmGoals > 10)
                {
                    MessageBox.Show("Priority firm goals field is less than 0 or greater than 10.");
                    return;
                }

                try
                {
                    CurrentTicket.PriorityFirmGoals = Decimal.Parse(txtPriorityFirmGoals.Text);
                }
                catch
                {
                    MessageBox.Show("Priority firm goals field is in an unrecognizable format.");
                    return;
                }
            }

            if (String.IsNullOrWhiteSpace(txtPriorityOverride.Text))
            {
                CurrentTicket.PriorityOverride = null;
            }
            else
            {
                if (CurrentTicket.PriorityOverride < 0 || CurrentTicket.PriorityOverride > 10)
                {
                    MessageBox.Show("Priority override field is less than 0 or greater than 10.");
                    return;
                }

                try
                {
                    CurrentTicket.PriorityOverride = Decimal.Parse(txtPriorityOverride.Text);
                }
                catch
                {
                    MessageBox.Show("Priority override field is in an unrecognizable format.");
                    return;
                }
            }

            if (String.IsNullOrWhiteSpace(txtPriorityService.Text))
            {
                CurrentTicket.PriorityService = null;
            }
            else
            {
                if (CurrentTicket.PriorityService < 0 || CurrentTicket.PriorityService > 10)
                {
                    MessageBox.Show("Priority service field is less than 0 or greater than 10.");
                    return;
                }

                try
                {
                    CurrentTicket.PriorityService = Decimal.Parse(txtPriorityService.Text);
                }
                catch
                {
                    MessageBox.Show("Priority service field is in an unrecognizable format.");
                    return;
                }
            }

            if (String.IsNullOrWhiteSpace(txtPriorityTeamGoals.Text))
            {
                CurrentTicket.PriorityTeamGoals = null;
            }
            else
            {
                if (CurrentTicket.PriorityTeamGoals < 0 || CurrentTicket.PriorityTeamGoals > 10)
                {
                    MessageBox.Show("Priority team goals field is less than 0 or greater than 10.");
                    return;
                }

                try
                {
                    CurrentTicket.PriorityTeamGoals = Decimal.Parse(txtPriorityTeamGoals.Text);
                }
                catch
                {
                    MessageBox.Show("Priority team goals field is in an unrecognizable format.");
                    return;
                }
            }

            frmMain = (frmMain)this.ParentForm;
            CurrentTicket.SaveRecordToDatabase(frmMain.CurrentUser.UserId);

            frmMain.dgvTicketsLoad();
            frmMain.dgvTicketsSelectCell(CurrentTicket.TicketId);

            this.Close();
        }

        private void menuItem_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = System.Drawing.SystemColors.HotTrack;
            label.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void menuItem_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = System.Drawing.SystemColors.ControlText;
            label.BackColor = System.Drawing.Color.Silver;
        }

        private void lblSummary_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 0;
        }

        private void lblTicketTimes_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 2;
        }

        private void lblTasks_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 3;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmTicketTime _frmTicketTime = new frmTicketTime(CurrentTicket);
            _frmTicketTime.ParentForm = this.ParentForm;
            _frmTicketTime.FormClosed += _frmTicketTime_FormClosed;
        }

        private void _frmTicketTime_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvTicketTimesLoad();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTicketTimes.Rows.Count == 0 || dgvTicketTimes.DataSource == null || dgvTicketTimes.CurrentCell == null)
                return;

            int _index = dgvTicketTimes.CurrentCell.RowIndex;
            Guid _ticketTimeId = new Guid(dgvTicketTimes.Rows[_index].Cells["TicketTimeId"].Value.ToString());
            TicketTime _ticketTime = new TicketTime(_ticketTimeId);

            frmTicketTime _frmTicketTime = new frmTicketTime(_ticketTime);
            _frmTicketTime.ParentForm = this.ParentForm;
            _frmTicketTime.FormClosed += _frmTicketTime_FormClosed;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTicketTimes.Rows.Count == 0 || dgvTicketTimes.DataSource == null || dgvTicketTimes.CurrentCell == null)
                return;

            DialogResult _dialogResult = MessageBox.Show("Are you sure you wish to delete the selected time entry? This action cannot be undone.", "Attention!", MessageBoxButtons.YesNoCancel);
            if (_dialogResult != DialogResult.Yes)
                return;

            int _index = dgvTicketTimes.CurrentCell.RowIndex;
            Guid _ticketTimeId = new Guid(dgvTicketTimes.Rows[_index].Cells["TicketTimeId"].Value.ToString());
            TicketTime _ticketTime = new TicketTime(_ticketTimeId);
            _ticketTime.DeleteDatabaseRecord();

            dgvTicketTimesLoad();
            ((frmMain)ParentForm).dgvTicketsLoad();

        }

        private void dgvTicketTimes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTicketTimes.Rows.Count == 0 || dgvTicketTimes.DataSource == null || dgvTicketTimes.CurrentCell == null)
                return;

            int _index = dgvTicketTimes.CurrentCell.RowIndex;
            Guid _ticketTimeId = new Guid(dgvTicketTimes.Rows[_index].Cells["TicketTimeId"].Value.ToString());
            TicketTime _ticketTime = new TicketTime(_ticketTimeId);

            frmTicketTime _frmTicketTime = new frmTicketTime(_ticketTime);
            _frmTicketTime.ParentForm = this.ParentForm;
            _frmTicketTime.FormClosed += _frmTicketTime_FormClosed;
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            frmTask frmTask = new frmTask(CurrentTicket);
            frmTask.ParentForm = this.ParentForm;
            frmTask.FormClosed += frmTask_FormClosed;
        }

        /// <summary>
        /// Reloads dgvTasks on frmTask close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// Checks if this form is closed before loading dgvTasks to prevent null object reference
        /// </remarks>
        private void frmTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_isClosed)
            {
                dgvTasksLoad();
            }
        }

        private void dgvTasksLoad()
        {
            dgvTasks.Columns.Clear();

            if (cboTasks.Text == "In Progress Associated Tasks")
            {
                dgvTasks.DataSource = Task.GetInProgressAssociatedFromTicket(CurrentTicket.TicketId);
            }
            else if (cboTasks.Text == "Complete Associated Tasks")
            {
                dgvTasks.DataSource = Task.GetCompleteAssociatedFromTicket(CurrentTicket.TicketId);
            }
            else if (cboTasks.Text == "All Associated Tasks")
            {
                dgvTasks.DataSource = Task.GetAllAssociatedFromTicket(CurrentTicket.TicketId);
            }

            if (dgvTasks.DataSource == null)
            {
                return;
            }

            dgvTasks.Columns["TaskId"].Visible = false;
            dgvTasks.Columns["Due"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvTasks.Columns["Created"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvTasks.Columns["Subject"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvTasks.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvTasks.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.Rows.Count == 0 || dgvTasks.DataSource == null || dgvTasks.CurrentCell == null)
                return;

            int index = dgvTasks.CurrentCell.RowIndex;
            Guid taskId = new Guid(dgvTasks.Rows[index].Cells["TaskId"].Value.ToString());
            Task task = new Task(taskId);

            frmTask frmTask = new frmTask(task);
            frmTask.ParentForm = this.ParentForm;
            frmTask.FormClosed += frmTask_FormClosed;
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.Rows.Count == 0 || dgvTasks.DataSource == null || dgvTasks.CurrentCell == null)
                return;

            DialogResult _dialogResult = MessageBox.Show("Are you sure you wish to delete the selected task? This action cannot be undone.", "Attention!", MessageBoxButtons.YesNoCancel);
            if (_dialogResult != DialogResult.Yes)
                return;

            int index = dgvTasks.CurrentCell.RowIndex;
            Guid taskId = new Guid(dgvTasks.Rows[index].Cells["TaskId"].Value.ToString());
            Task task = new Task(taskId);
            task.DeleteDatabaseRecord();

            dgvTasksLoad();
        }

        private void dgvTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTasks.Rows.Count == 0 || dgvTasks.DataSource == null || dgvTasks.CurrentCell == null)
                return;

            int index = dgvTasks.CurrentCell.RowIndex;
            Guid taskId = new Guid(dgvTasks.Rows[index].Cells["TaskId"].Value.ToString());
            Task task = new Task(taskId);

            frmTask frmTask = new frmTask(task);
            frmTask.ParentForm = this.ParentForm;
            frmTask.FormClosed += frmTask_FormClosed;
        }

        private void cboTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTasksLoad();
        }

        private void pnlFormHeader_DoubleClick(object sender, EventArgs e)
        {
            MaximizeForm();
        }

        private void btnSendEmailUpdate_Click(object sender, EventArgs e)
        {
            Guid createdBy = ((frmMain)ParentForm).CurrentUser.UserId;

            TicketEmails ticketEmails = new TicketEmails(CurrentTicket);
            ticketEmails.EmailSender.EmailSuccessfullySent += ticketEmails_EmailSuccesfullySent;
            ticketEmails.EmailSender.EmailFailedToSend += ticketEmails_EmailFailedToSend;
            ticketEmails.SendWeeklyUpdate(createdBy);

            btnSendEmailUpdate.Text = "Sending...";
            btnSendEmailUpdate.Enabled = false;
        }

        private void ticketEmails_EmailSuccesfullySent(object sender, EventArgs e)
        {
            btnSendEmailUpdate.Text = "Sent!";
        }

        private void ticketEmails_EmailFailedToSend(object sender, EventArgs e)
        {
            btnSendEmailUpdate.Text = "Send Failed!";
        }

        private void lblScope_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPriority_Click(object sender, EventArgs e)
        {
            tabMain.SelectedIndex = 4;
        }
    }
}
