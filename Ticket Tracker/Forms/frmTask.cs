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
using System.Windows.Forms;

namespace TicketTracker.Presentation.Forms
{
    public partial class frmTask : Form, IMessageFilter
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
        public Task CurrentTask;

        private Stopwatch stopWatch = new Stopwatch();
        private bool isUnsaved = false;

        private bool isFormLoading = false;

        public frmTask(Ticket _ticket)
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

            CurrentTask = new Task();
            CurrentTask.TicketId = ParentTicket.TicketId;

            LoadStatusCbo();
            SelectItemStatusCbo(CurrentTask.StatusId);

            this.Show();
        }

        public frmTask(Task task)
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
            
            CurrentTask = task;

            ParentTicket = new Ticket(CurrentTask.TicketId);

            isFormLoading = true;

            LoadStatusCbo();
            SetTextFieldsToInstance();

            isFormLoading = false;

            this.Show();
        }

        /// <summary>
        /// Sets text boxes' text attributes to their related Task attribute value. Must be executed
        /// after all controls have been loaded (i.e. after status ComboBox items have been added).
        /// </summary>
        private void SetTextFieldsToInstance()
        {
            SelectItemStatusCbo(CurrentTask.StatusId);
            txtTicket.Text = ParentTicket.SubjectValue;
            txtSubject.Text = CurrentTask.SubjectValue;
            txtDescription.Text = CurrentTask.DescriptionValue;

            if (CurrentTask.CreatedOn != DateTime.MinValue)
            {
                txtCreatedOn.Text = CurrentTask.CreatedOn.ToString("MMMM d, yyyy h:mm tt");
            }
            else
            {
                txtCreatedOn.Text = null;
            }

            if (CurrentTask.DueOn != null)
            {
                txtDueDate.Text = ((DateTime)CurrentTask.DueOn).ToString("MM/dd/yyyy");
            }
            else
            {
                txtDueDate.Text = null;
            }

            if (CurrentTask.CompletedOn != null)
            {
                txtCompletedOn.Text = ((DateTime)CurrentTask.CompletedOn).ToString("MMMM d, yyyy h:mm tt");
            }
            else
            {
                txtCompletedOn.Text = null;
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

        private void LoadStatusCbo()
        {
            cboStatus.Items.Clear();
            foreach (StringMap stringMap in StringMap.AssociatedStringMaps("Task", "StatusId"))
            {
                cboStatus.Items.Add(new Utilities.ListItem(stringMap.StringValue, stringMap));
            }
        }

        private void SelectItemStatusCbo(Guid stringMapId)
        {
            foreach (Utilities.ListItem listItem in cboStatus.Items)
            {
                StringMap stringMap = (StringMap)listItem.HiddenObject;
                if (stringMapId == stringMap.StringMapId)
                {
                    cboStatus.SelectedItem = listItem;
                    return;
                }
            }
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
            frmMain frmMain = (frmMain)ParentForm;

            if (String.IsNullOrWhiteSpace(txtSubject.Text))
            {
                MessageBox.Show("Subject field cannot be blank. Please correct and try again.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a status for this task. Please correct and try again.", "Error", MessageBoxButtons.OK);
                return;
            }

            if (String.IsNullOrWhiteSpace(txtDueDate.Text))
            {
                CurrentTask.DueOn = null;
            }
            else
            {
                try
                {
                    CurrentTask.DueOn = DateTime.Parse(txtDueDate.Text);
                }
                catch
                {
                    MessageBox.Show("The due date field is not in a recognized date format (Ex: MM/DD/YYYY). Please correct and try again.", "Error", MessageBoxButtons.OK);
                    return;
                }
            }

            if (String.IsNullOrWhiteSpace(txtCompletedOn.Text))
            {
                CurrentTask.CompletedOn = null;
            }
            else
            {
                try
                {
                    CurrentTask.CompletedOn = DateTime.Parse(txtCompletedOn.Text);
                }
                catch
                {
                    MessageBox.Show("The completed date field is not in a recognized date format (Ex: MM/DD/YYYY). Please correct and try again.", "Error", MessageBoxButtons.OK);
                    return;
                }
            }

            CurrentTask.SubjectValue = txtSubject.Text;
            CurrentTask.DescriptionValue = txtDescription.Text;
            StringMap stringMap = (StringMap)((Utilities.ListItem)cboStatus.SelectedItem).HiddenObject;
            CurrentTask.StatusId = stringMap.StringMapId;

            CurrentTask.SaveRecordToDatabase(frmMain.CurrentUser.UserId);

            frmMain.dgvTicketsLoad();
            frmMain.dgvTicketsSelectCell(ParentTicket.TicketId);

            isUnsaved = false;

            this.Close();
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

        private void pnlFormHeader_DoubleClick(object sender, EventArgs e)
        {
            MaximizeForm();
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoading == true)
            {
                return;
            }

            StringMap stringMap = (StringMap)((Utilities.ListItem)cboStatus.SelectedItem).HiddenObject;
            if (stringMap.StringMapId == new Guid("C80F31C5-86A8-4C0C-87C6-037E77CE1ACC"))
            {
                CurrentTask.CompleteTask();
                txtCompletedOn.Text = ((DateTime)CurrentTask.CompletedOn).ToString("MMMM d, yyyy h:mm tt");
            }
            else
            {
                CurrentTask.CompletedOn = null;
                CurrentTask.StateCode = 0;
                CurrentTask.StatusId = stringMap.StringMapId;
                txtCompletedOn.Text = null;
            }
        }
    }
}
