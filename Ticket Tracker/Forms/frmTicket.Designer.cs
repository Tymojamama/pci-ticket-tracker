namespace TicketTracker.Presentation.Forms
{
    partial class frmTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.pnlBodySummary = new System.Windows.Forms.Panel();
            this.lblDateCompleted = new System.Windows.Forms.Label();
            this.txtDateCompleted = new System.Windows.Forms.RichTextBox();
            this.cmMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCurrentTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTargetDate = new System.Windows.Forms.Label();
            this.txtTargetDate = new System.Windows.Forms.RichTextBox();
            this.lblDateAssigned = new System.Windows.Forms.Label();
            this.txtDateAssigned = new System.Windows.Forms.RichTextBox();
            this.cboRequestedBy = new System.Windows.Forms.ComboBox();
            this.lblRequestedBy = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboPriorityLevel = new System.Windows.Forms.ComboBox();
            this.cboOwner = new System.Windows.Forms.ComboBox();
            this.btnSendEmailUpdate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblPriorityLevel = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.RichTextBox();
            this.tabScope = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.lblEstimate = new System.Windows.Forms.Label();
            this.txtCompleted = new System.Windows.Forms.RichTextBox();
            this.txtEstimate = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeliverables = new System.Windows.Forms.RichTextBox();
            this.lblDeliverables = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.RichTextBox();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.tabTicketTimes = new System.Windows.Forms.TabPage();
            this.pnlBodyTicketTimes = new System.Windows.Forms.Panel();
            this.lblTicketTimeViews = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTicketTimes = new System.Windows.Forms.DataGridView();
            this.TicketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriorityLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAssigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerIdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTasks = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboTasks = new System.Windows.Forms.ComboBox();
            this.lblTaskViews = new System.Windows.Forms.Label();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPriority = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPriorityOverride = new System.Windows.Forms.RichTextBox();
            this.lblPriorityTotalScore = new System.Windows.Forms.Label();
            this.lblPriorityOverride = new System.Windows.Forms.Label();
            this.txtPriorityCompliance = new System.Windows.Forms.RichTextBox();
            this.lblPriorityCompliance = new System.Windows.Forms.Label();
            this.txtPriorityCompetition = new System.Windows.Forms.RichTextBox();
            this.lblPriorityCompetition = new System.Windows.Forms.Label();
            this.txtPriorityService = new System.Windows.Forms.RichTextBox();
            this.lblPriorityService = new System.Windows.Forms.Label();
            this.txtPriorityEfficiency = new System.Windows.Forms.RichTextBox();
            this.lblPriorityEfficiency = new System.Windows.Forms.Label();
            this.txtPriorityTeamGoals = new System.Windows.Forms.RichTextBox();
            this.lblPriorityTeamGoals = new System.Windows.Forms.Label();
            this.txtPriorityFirmGoals = new System.Windows.Forms.RichTextBox();
            this.lblPriorityFirmGoals = new System.Windows.Forms.Label();
            this.pnlFormHeader = new System.Windows.Forms.Panel();
            this.lblFormMinimize = new System.Windows.Forms.Label();
            this.lblFormClose = new System.Windows.Forms.Label();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblScope = new System.Windows.Forms.Label();
            this.lblTasks = new System.Windows.Forms.Label();
            this.lblTicketTimes = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFormStatus = new System.Windows.Forms.Label();
            this.niMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.tabMain.SuspendLayout();
            this.tabTickets.SuspendLayout();
            this.pnlBodySummary.SuspendLayout();
            this.cmMain.SuspendLayout();
            this.tabScope.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabTicketTimes.SuspendLayout();
            this.pnlBodyTicketTimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketTimes)).BeginInit();
            this.tabTasks.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.tabPriority.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlFormHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMain.Controls.Add(this.tabTickets);
            this.tabMain.Controls.Add(this.tabScope);
            this.tabMain.Controls.Add(this.tabTicketTimes);
            this.tabMain.Controls.Add(this.tabTasks);
            this.tabMain.Controls.Add(this.tabPriority);
            this.tabMain.Location = new System.Drawing.Point(-4, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(689, 396);
            this.tabMain.TabIndex = 0;
            // 
            // tabTickets
            // 
            this.tabTickets.BackColor = System.Drawing.Color.Gainsboro;
            this.tabTickets.Controls.Add(this.pnlBodySummary);
            this.tabTickets.Location = new System.Drawing.Point(4, 25);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTickets.Size = new System.Drawing.Size(681, 367);
            this.tabTickets.TabIndex = 0;
            this.tabTickets.Text = "tabTickets";
            // 
            // pnlBodySummary
            // 
            this.pnlBodySummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBodySummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBodySummary.Controls.Add(this.lblDateCompleted);
            this.pnlBodySummary.Controls.Add(this.txtDateCompleted);
            this.pnlBodySummary.Controls.Add(this.lblTargetDate);
            this.pnlBodySummary.Controls.Add(this.txtTargetDate);
            this.pnlBodySummary.Controls.Add(this.lblDateAssigned);
            this.pnlBodySummary.Controls.Add(this.txtDateAssigned);
            this.pnlBodySummary.Controls.Add(this.cboRequestedBy);
            this.pnlBodySummary.Controls.Add(this.lblRequestedBy);
            this.pnlBodySummary.Controls.Add(this.cboStatus);
            this.pnlBodySummary.Controls.Add(this.cboType);
            this.pnlBodySummary.Controls.Add(this.cboPriorityLevel);
            this.pnlBodySummary.Controls.Add(this.cboOwner);
            this.pnlBodySummary.Controls.Add(this.btnSendEmailUpdate);
            this.pnlBodySummary.Controls.Add(this.btnSubmit);
            this.pnlBodySummary.Controls.Add(this.lblStatus);
            this.pnlBodySummary.Controls.Add(this.label2);
            this.pnlBodySummary.Controls.Add(this.txtDescription);
            this.pnlBodySummary.Controls.Add(this.lblPriorityLevel);
            this.pnlBodySummary.Controls.Add(this.lblOwner);
            this.pnlBodySummary.Controls.Add(this.lblDescription);
            this.pnlBodySummary.Controls.Add(this.lblSubject);
            this.pnlBodySummary.Controls.Add(this.txtSubject);
            this.pnlBodySummary.Location = new System.Drawing.Point(0, 0);
            this.pnlBodySummary.Name = "pnlBodySummary";
            this.pnlBodySummary.Size = new System.Drawing.Size(681, 367);
            this.pnlBodySummary.TabIndex = 0;
            // 
            // lblDateCompleted
            // 
            this.lblDateCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateCompleted.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDateCompleted.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCompleted.Location = new System.Drawing.Point(7, 239);
            this.lblDateCompleted.Name = "lblDateCompleted";
            this.lblDateCompleted.Size = new System.Drawing.Size(97, 20);
            this.lblDateCompleted.TabIndex = 34;
            this.lblDateCompleted.Text = "Date Completed";
            this.lblDateCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDateCompleted
            // 
            this.txtDateCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateCompleted.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDateCompleted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateCompleted.ContextMenuStrip = this.cmMain;
            this.txtDateCompleted.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateCompleted.Location = new System.Drawing.Point(110, 239);
            this.txtDateCompleted.Multiline = false;
            this.txtDateCompleted.Name = "txtDateCompleted";
            this.txtDateCompleted.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtDateCompleted.Size = new System.Drawing.Size(558, 20);
            this.txtDateCompleted.TabIndex = 6;
            this.txtDateCompleted.Text = "";
            this.txtDateCompleted.WordWrap = false;
            // 
            // cmMain
            // 
            this.cmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCurrentTimeToolStripMenuItem});
            this.cmMain.Name = "cmMain";
            this.cmMain.Size = new System.Drawing.Size(170, 26);
            // 
            // addCurrentTimeToolStripMenuItem
            // 
            this.addCurrentTimeToolStripMenuItem.Name = "addCurrentTimeToolStripMenuItem";
            this.addCurrentTimeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addCurrentTimeToolStripMenuItem.Text = "Add Current Time";
            this.addCurrentTimeToolStripMenuItem.Click += new System.EventHandler(this.addCurrentTimeToolStripMenuItem_Click);
            // 
            // lblTargetDate
            // 
            this.lblTargetDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTargetDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTargetDate.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetDate.Location = new System.Drawing.Point(7, 213);
            this.lblTargetDate.Name = "lblTargetDate";
            this.lblTargetDate.Size = new System.Drawing.Size(97, 20);
            this.lblTargetDate.TabIndex = 32;
            this.lblTargetDate.Text = "Target Date";
            this.lblTargetDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTargetDate
            // 
            this.txtTargetDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTargetDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTargetDate.ContextMenuStrip = this.cmMain;
            this.txtTargetDate.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetDate.Location = new System.Drawing.Point(110, 213);
            this.txtTargetDate.Multiline = false;
            this.txtTargetDate.Name = "txtTargetDate";
            this.txtTargetDate.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtTargetDate.Size = new System.Drawing.Size(558, 20);
            this.txtTargetDate.TabIndex = 5;
            this.txtTargetDate.Text = "";
            this.txtTargetDate.WordWrap = false;
            // 
            // lblDateAssigned
            // 
            this.lblDateAssigned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateAssigned.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDateAssigned.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAssigned.Location = new System.Drawing.Point(7, 187);
            this.lblDateAssigned.Name = "lblDateAssigned";
            this.lblDateAssigned.Size = new System.Drawing.Size(97, 20);
            this.lblDateAssigned.TabIndex = 30;
            this.lblDateAssigned.Text = "Date Assigned";
            this.lblDateAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDateAssigned
            // 
            this.txtDateAssigned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateAssigned.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDateAssigned.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateAssigned.ContextMenuStrip = this.cmMain;
            this.txtDateAssigned.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateAssigned.Location = new System.Drawing.Point(110, 187);
            this.txtDateAssigned.Multiline = false;
            this.txtDateAssigned.Name = "txtDateAssigned";
            this.txtDateAssigned.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtDateAssigned.Size = new System.Drawing.Size(558, 20);
            this.txtDateAssigned.TabIndex = 4;
            this.txtDateAssigned.Text = "";
            this.txtDateAssigned.WordWrap = false;
            // 
            // cboRequestedBy
            // 
            this.cboRequestedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRequestedBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboRequestedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRequestedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRequestedBy.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRequestedBy.FormattingEnabled = true;
            this.cboRequestedBy.Location = new System.Drawing.Point(110, 292);
            this.cboRequestedBy.Name = "cboRequestedBy";
            this.cboRequestedBy.Size = new System.Drawing.Size(558, 22);
            this.cboRequestedBy.TabIndex = 8;
            // 
            // lblRequestedBy
            // 
            this.lblRequestedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRequestedBy.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRequestedBy.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestedBy.Location = new System.Drawing.Point(7, 292);
            this.lblRequestedBy.Name = "lblRequestedBy";
            this.lblRequestedBy.Size = new System.Drawing.Size(97, 21);
            this.lblRequestedBy.TabIndex = 27;
            this.lblRequestedBy.Text = "Requested By";
            this.lblRequestedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(110, 159);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(558, 22);
            this.cboStatus.TabIndex = 3;
            // 
            // cboPriorityLevel
            // 
            this.cboPriorityLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPriorityLevel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboPriorityLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPriorityLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPriorityLevel.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPriorityLevel.FormattingEnabled = true;
            this.cboPriorityLevel.Location = new System.Drawing.Point(110, 131);
            this.cboPriorityLevel.Name = "cboPriorityLevel";
            this.cboPriorityLevel.Size = new System.Drawing.Size(558, 22);
            this.cboPriorityLevel.TabIndex = 2;
            // 
            // cboOwner
            // 
            this.cboOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOwner.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOwner.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOwner.FormattingEnabled = true;
            this.cboOwner.Location = new System.Drawing.Point(110, 265);
            this.cboOwner.Name = "cboOwner";
            this.cboOwner.Size = new System.Drawing.Size(558, 22);
            this.cboOwner.TabIndex = 7;
            // 
            // btnSendEmailUpdate
            // 
            this.btnSendEmailUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendEmailUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSendEmailUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmailUpdate.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmailUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnSendEmailUpdate.Location = new System.Drawing.Point(484, 320);
            this.btnSendEmailUpdate.Name = "btnSendEmailUpdate";
            this.btnSendEmailUpdate.Size = new System.Drawing.Size(89, 40);
            this.btnSendEmailUpdate.TabIndex = 9;
            this.btnSendEmailUpdate.Text = "Send Email Update";
            this.btnSendEmailUpdate.UseVisualStyleBackColor = false;
            this.btnSendEmailUpdate.Click += new System.EventHandler(this.btnSendEmailUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.Location = new System.Drawing.Point(579, 320);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 40);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(7, 159);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(97, 21);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.AutoWordSelection = true;
            this.txtDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(110, 32);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(558, 65);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Text = "";
            // 
            // lblPriorityLevel
            // 
            this.lblPriorityLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPriorityLevel.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPriorityLevel.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityLevel.Location = new System.Drawing.Point(7, 131);
            this.lblPriorityLevel.Name = "lblPriorityLevel";
            this.lblPriorityLevel.Size = new System.Drawing.Size(97, 21);
            this.lblPriorityLevel.TabIndex = 23;
            this.lblPriorityLevel.Text = "Priority";
            this.lblPriorityLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOwner
            // 
            this.lblOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOwner.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOwner.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(7, 265);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(97, 21);
            this.lblOwner.TabIndex = 23;
            this.lblOwner.Text = "Owner";
            this.lblOwner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDescription.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(7, 32);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(97, 20);
            this.lblDescription.TabIndex = 23;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubject
            // 
            this.lblSubject.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSubject.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(7, 6);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(97, 20);
            this.lblSubject.TabIndex = 21;
            this.lblSubject.Text = "Subject";
            this.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubject.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(110, 6);
            this.txtSubject.Multiline = false;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtSubject.Size = new System.Drawing.Size(558, 20);
            this.txtSubject.TabIndex = 0;
            this.txtSubject.Text = "";
            this.txtSubject.WordWrap = false;
            // 
            // tabScope
            // 
            this.tabScope.Controls.Add(this.panel3);
            this.tabScope.Location = new System.Drawing.Point(4, 25);
            this.tabScope.Name = "tabScope";
            this.tabScope.Padding = new System.Windows.Forms.Padding(3);
            this.tabScope.Size = new System.Drawing.Size(681, 367);
            this.tabScope.TabIndex = 3;
            this.tabScope.Text = "tabScope";
            this.tabScope.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblCompleted);
            this.panel3.Controls.Add(this.lblEstimate);
            this.panel3.Controls.Add(this.txtCompleted);
            this.panel3.Controls.Add(this.txtEstimate);
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtDeliverables);
            this.panel3.Controls.Add(this.lblDeliverables);
            this.panel3.Controls.Add(this.txtPurpose);
            this.panel3.Controls.Add(this.lblPurpose);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 367);
            this.panel3.TabIndex = 1;
            // 
            // lblCompleted
            // 
            this.lblCompleted.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCompleted.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.Location = new System.Drawing.Point(7, 329);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(97, 20);
            this.lblCompleted.TabIndex = 39;
            this.lblCompleted.Text = "Completed";
            this.lblCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstimate
            // 
            this.lblEstimate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEstimate.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimate.Location = new System.Drawing.Point(7, 303);
            this.lblEstimate.Name = "lblEstimate";
            this.lblEstimate.Size = new System.Drawing.Size(97, 20);
            this.lblEstimate.TabIndex = 40;
            this.lblEstimate.Text = "Estimate";
            this.lblEstimate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCompleted
            // 
            this.txtCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompleted.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCompleted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompleted.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompleted.Location = new System.Drawing.Point(110, 329);
            this.txtCompleted.Multiline = false;
            this.txtCompleted.Name = "txtCompleted";
            this.txtCompleted.ReadOnly = true;
            this.txtCompleted.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtCompleted.Size = new System.Drawing.Size(558, 20);
            this.txtCompleted.TabIndex = 4;
            this.txtCompleted.Text = "";
            this.txtCompleted.WordWrap = false;
            // 
            // txtEstimate
            // 
            this.txtEstimate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstimate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEstimate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstimate.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstimate.Location = new System.Drawing.Point(110, 303);
            this.txtEstimate.Multiline = false;
            this.txtEstimate.Name = "txtEstimate";
            this.txtEstimate.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtEstimate.Size = new System.Drawing.Size(558, 20);
            this.txtEstimate.TabIndex = 3;
            this.txtEstimate.Text = "";
            this.txtEstimate.WordWrap = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(110, 204);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(558, 93);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Deliverables";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDeliverables
            // 
            this.txtDeliverables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeliverables.AutoWordSelection = true;
            this.txtDeliverables.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDeliverables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeliverables.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliverables.Location = new System.Drawing.Point(110, 105);
            this.txtDeliverables.Name = "txtDeliverables";
            this.txtDeliverables.Size = new System.Drawing.Size(558, 93);
            this.txtDeliverables.TabIndex = 1;
            this.txtDeliverables.Text = "";
            // 
            // lblDeliverables
            // 
            this.lblDeliverables.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDeliverables.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliverables.Location = new System.Drawing.Point(7, 105);
            this.lblDeliverables.Name = "lblDeliverables";
            this.lblDeliverables.Size = new System.Drawing.Size(97, 20);
            this.lblDeliverables.TabIndex = 25;
            this.lblDeliverables.Text = "Deliverables";
            this.lblDeliverables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPurpose
            // 
            this.txtPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPurpose.AutoWordSelection = true;
            this.txtPurpose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPurpose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPurpose.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurpose.Location = new System.Drawing.Point(110, 6);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(558, 93);
            this.txtPurpose.TabIndex = 0;
            this.txtPurpose.Text = "";
            // 
            // lblPurpose
            // 
            this.lblPurpose.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPurpose.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurpose.Location = new System.Drawing.Point(7, 6);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(97, 20);
            this.lblPurpose.TabIndex = 23;
            this.lblPurpose.Text = "Purpose";
            this.lblPurpose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabTicketTimes
            // 
            this.tabTicketTimes.Controls.Add(this.pnlBodyTicketTimes);
            this.tabTicketTimes.Location = new System.Drawing.Point(4, 25);
            this.tabTicketTimes.Name = "tabTicketTimes";
            this.tabTicketTimes.Padding = new System.Windows.Forms.Padding(3);
            this.tabTicketTimes.Size = new System.Drawing.Size(681, 367);
            this.tabTicketTimes.TabIndex = 1;
            this.tabTicketTimes.Text = "tabTicketTimes";
            this.tabTicketTimes.UseVisualStyleBackColor = true;
            // 
            // pnlBodyTicketTimes
            // 
            this.pnlBodyTicketTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBodyTicketTimes.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlBodyTicketTimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBodyTicketTimes.Controls.Add(this.lblTicketTimeViews);
            this.pnlBodyTicketTimes.Controls.Add(this.btnNew);
            this.pnlBodyTicketTimes.Controls.Add(this.btnEdit);
            this.pnlBodyTicketTimes.Controls.Add(this.btnDelete);
            this.pnlBodyTicketTimes.Controls.Add(this.dgvTicketTimes);
            this.pnlBodyTicketTimes.Location = new System.Drawing.Point(0, 0);
            this.pnlBodyTicketTimes.Name = "pnlBodyTicketTimes";
            this.pnlBodyTicketTimes.Size = new System.Drawing.Size(681, 367);
            this.pnlBodyTicketTimes.TabIndex = 1;
            // 
            // lblTicketTimeViews
            // 
            this.lblTicketTimeViews.AutoSize = true;
            this.lblTicketTimeViews.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketTimeViews.Location = new System.Drawing.Point(11, 7);
            this.lblTicketTimeViews.Name = "lblTicketTimeViews";
            this.lblTicketTimeViews.Size = new System.Drawing.Size(90, 19);
            this.lblTicketTimeViews.TabIndex = 7;
            this.lblTicketTimeViews.Text = "Time Entries";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(452, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(68, 25);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(526, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 25);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(600, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 25);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTicketTimes
            // 
            this.dgvTicketTimes.AllowUserToAddRows = false;
            this.dgvTicketTimes.AllowUserToDeleteRows = false;
            this.dgvTicketTimes.AllowUserToResizeRows = false;
            this.dgvTicketTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTicketTimes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTicketTimes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTicketTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTicketTimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketId,
            this.SubjectValue,
            this.PriorityLevel,
            this.DateAssigned,
            this.TargetDate,
            this.RequestedBy,
            this.OwnerIdName});
            this.dgvTicketTimes.EnableHeadersVisualStyles = false;
            this.dgvTicketTimes.Location = new System.Drawing.Point(10, 34);
            this.dgvTicketTimes.MultiSelect = false;
            this.dgvTicketTimes.Name = "dgvTicketTimes";
            this.dgvTicketTimes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTicketTimes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTicketTimes.RowHeadersVisible = false;
            this.dgvTicketTimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTicketTimes.ShowEditingIcon = false;
            this.dgvTicketTimes.Size = new System.Drawing.Size(658, 325);
            this.dgvTicketTimes.TabIndex = 1;
            this.dgvTicketTimes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicketTimes_CellDoubleClick);
            // 
            // TicketId
            // 
            this.TicketId.HeaderText = "TicketId";
            this.TicketId.Name = "TicketId";
            this.TicketId.ReadOnly = true;
            this.TicketId.Visible = false;
            // 
            // SubjectValue
            // 
            this.SubjectValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectValue.HeaderText = "Subject";
            this.SubjectValue.Name = "SubjectValue";
            this.SubjectValue.ReadOnly = true;
            // 
            // PriorityLevel
            // 
            this.PriorityLevel.HeaderText = "Priority Level";
            this.PriorityLevel.Name = "PriorityLevel";
            this.PriorityLevel.ReadOnly = true;
            // 
            // DateAssigned
            // 
            this.DateAssigned.HeaderText = "Date Assigned";
            this.DateAssigned.Name = "DateAssigned";
            this.DateAssigned.ReadOnly = true;
            // 
            // TargetDate
            // 
            this.TargetDate.HeaderText = "Target Date";
            this.TargetDate.Name = "TargetDate";
            this.TargetDate.ReadOnly = true;
            // 
            // RequestedBy
            // 
            this.RequestedBy.HeaderText = "Requested By";
            this.RequestedBy.Name = "RequestedBy";
            this.RequestedBy.ReadOnly = true;
            // 
            // OwnerIdName
            // 
            this.OwnerIdName.HeaderText = "Owner";
            this.OwnerIdName.Name = "OwnerIdName";
            this.OwnerIdName.ReadOnly = true;
            // 
            // tabTasks
            // 
            this.tabTasks.Controls.Add(this.panel2);
            this.tabTasks.Location = new System.Drawing.Point(4, 25);
            this.tabTasks.Name = "tabTasks";
            this.tabTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabTasks.Size = new System.Drawing.Size(681, 367);
            this.tabTasks.TabIndex = 2;
            this.tabTasks.Text = "tabTasks";
            this.tabTasks.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboTasks);
            this.panel2.Controls.Add(this.lblTaskViews);
            this.panel2.Controls.Add(this.btnNewTask);
            this.panel2.Controls.Add(this.btnEditTask);
            this.panel2.Controls.Add(this.btnDeleteTask);
            this.panel2.Controls.Add(this.dgvTasks);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 367);
            this.panel2.TabIndex = 2;
            // 
            // cboTasks
            // 
            this.cboTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTasks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTasks.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTasks.FormattingEnabled = true;
            this.cboTasks.Items.AddRange(new object[] {
            "In Progress Associated Tasks",
            "Complete Associated Tasks",
            "All Associated Tasks"});
            this.cboTasks.Location = new System.Drawing.Point(70, 5);
            this.cboTasks.Name = "cboTasks";
            this.cboTasks.Size = new System.Drawing.Size(352, 22);
            this.cboTasks.TabIndex = 8;
            this.cboTasks.SelectedIndexChanged += new System.EventHandler(this.cboTasks_SelectedIndexChanged);
            // 
            // lblTaskViews
            // 
            this.lblTaskViews.AutoSize = true;
            this.lblTaskViews.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskViews.Location = new System.Drawing.Point(11, 7);
            this.lblTaskViews.Name = "lblTaskViews";
            this.lblTaskViews.Size = new System.Drawing.Size(44, 19);
            this.lblTaskViews.TabIndex = 7;
            this.lblTaskViews.Text = "Tasks";
            // 
            // btnNewTask
            // 
            this.btnNewTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewTask.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTask.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTask.Location = new System.Drawing.Point(452, 4);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(68, 25);
            this.btnNewTask.TabIndex = 4;
            this.btnNewTask.Text = "New";
            this.btnNewTask.UseVisualStyleBackColor = false;
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditTask.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTask.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTask.Location = new System.Drawing.Point(526, 4);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(68, 25);
            this.btnEditTask.TabIndex = 5;
            this.btnEditTask.Text = "Edit";
            this.btnEditTask.UseVisualStyleBackColor = false;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTask.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTask.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.Location = new System.Drawing.Point(600, 4);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(68, 25);
            this.btnDeleteTask.TabIndex = 6;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.AllowUserToResizeRows = false;
            this.dgvTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gadugi", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvTasks.EnableHeadersVisualStyles = false;
            this.dgvTasks.Location = new System.Drawing.Point(10, 34);
            this.dgvTasks.MultiSelect = false;
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTasks.RowHeadersVisible = false;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTasks.ShowEditingIcon = false;
            this.dgvTasks.Size = new System.Drawing.Size(658, 325);
            this.dgvTasks.TabIndex = 1;
            this.dgvTasks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "TicketId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Priority Level";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Date Assigned";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Target Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Requested By";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Owner";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // tabPriority
            // 
            this.tabPriority.Controls.Add(this.panel4);
            this.tabPriority.Location = new System.Drawing.Point(4, 25);
            this.tabPriority.Name = "tabPriority";
            this.tabPriority.Padding = new System.Windows.Forms.Padding(3);
            this.tabPriority.Size = new System.Drawing.Size(681, 367);
            this.tabPriority.TabIndex = 4;
            this.tabPriority.Text = "tabPriority";
            this.tabPriority.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtPriorityOverride);
            this.panel4.Controls.Add(this.lblPriorityTotalScore);
            this.panel4.Controls.Add(this.lblPriorityOverride);
            this.panel4.Controls.Add(this.txtPriorityCompliance);
            this.panel4.Controls.Add(this.lblPriorityCompliance);
            this.panel4.Controls.Add(this.txtPriorityCompetition);
            this.panel4.Controls.Add(this.lblPriorityCompetition);
            this.panel4.Controls.Add(this.txtPriorityService);
            this.panel4.Controls.Add(this.lblPriorityService);
            this.panel4.Controls.Add(this.txtPriorityEfficiency);
            this.panel4.Controls.Add(this.lblPriorityEfficiency);
            this.panel4.Controls.Add(this.txtPriorityTeamGoals);
            this.panel4.Controls.Add(this.lblPriorityTeamGoals);
            this.panel4.Controls.Add(this.txtPriorityFirmGoals);
            this.panel4.Controls.Add(this.lblPriorityFirmGoals);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(681, 367);
            this.panel4.TabIndex = 2;
            // 
            // txtPriorityOverride
            // 
            this.txtPriorityOverride.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriorityOverride.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPriorityOverride.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriorityOverride.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriorityOverride.Location = new System.Drawing.Point(10, 305);
            this.txtPriorityOverride.Multiline = false;
            this.txtPriorityOverride.Name = "txtPriorityOverride";
            this.txtPriorityOverride.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPriorityOverride.Size = new System.Drawing.Size(658, 20);
            this.txtPriorityOverride.TabIndex = 34;
            this.txtPriorityOverride.Text = "";
            this.txtPriorityOverride.WordWrap = false;
            // 
            // lblPriorityTotalScore
            // 
            this.lblPriorityTotalScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPriorityTotalScore.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityTotalScore.Location = new System.Drawing.Point(5, 336);
            this.lblPriorityTotalScore.Name = "lblPriorityTotalScore";
            this.lblPriorityTotalScore.Size = new System.Drawing.Size(661, 20);
            this.lblPriorityTotalScore.TabIndex = 35;
            this.lblPriorityTotalScore.Text = "Total Score:";
            this.lblPriorityTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPriorityOverride
            // 
            this.lblPriorityOverride.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPriorityOverride.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityOverride.Location = new System.Drawing.Point(7, 282);
            this.lblPriorityOverride.Name = "lblPriorityOverride";
            this.lblPriorityOverride.Size = new System.Drawing.Size(661, 20);
            this.lblPriorityOverride.TabIndex = 35;
            this.lblPriorityOverride.Text = "Score Override";
            this.lblPriorityOverride.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPriorityCompliance
            // 
            this.txtPriorityCompliance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriorityCompliance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPriorityCompliance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriorityCompliance.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriorityCompliance.Location = new System.Drawing.Point(10, 259);
            this.txtPriorityCompliance.Multiline = false;
            this.txtPriorityCompliance.Name = "txtPriorityCompliance";
            this.txtPriorityCompliance.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPriorityCompliance.Size = new System.Drawing.Size(658, 20);
            this.txtPriorityCompliance.TabIndex = 32;
            this.txtPriorityCompliance.Text = "";
            this.txtPriorityCompliance.WordWrap = false;
            // 
            // lblPriorityCompliance
            // 
            this.lblPriorityCompliance.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPriorityCompliance.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityCompliance.Location = new System.Drawing.Point(7, 236);
            this.lblPriorityCompliance.Name = "lblPriorityCompliance";
            this.lblPriorityCompliance.Size = new System.Drawing.Size(661, 20);
            this.lblPriorityCompliance.TabIndex = 33;
            this.lblPriorityCompliance.Text = "This task is compliance critical.";
            this.lblPriorityCompliance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPriorityCompetition
            // 
            this.txtPriorityCompetition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriorityCompetition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPriorityCompetition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriorityCompetition.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriorityCompetition.Location = new System.Drawing.Point(10, 213);
            this.txtPriorityCompetition.Multiline = false;
            this.txtPriorityCompetition.Name = "txtPriorityCompetition";
            this.txtPriorityCompetition.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPriorityCompetition.Size = new System.Drawing.Size(658, 20);
            this.txtPriorityCompetition.TabIndex = 30;
            this.txtPriorityCompetition.Text = "";
            this.txtPriorityCompetition.WordWrap = false;
            // 
            // lblPriorityCompetition
            // 
            this.lblPriorityCompetition.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPriorityCompetition.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityCompetition.Location = new System.Drawing.Point(7, 190);
            this.lblPriorityCompetition.Name = "lblPriorityCompetition";
            this.lblPriorityCompetition.Size = new System.Drawing.Size(661, 20);
            this.lblPriorityCompetition.TabIndex = 31;
            this.lblPriorityCompetition.Text = "This task will provide a sustainable competitive advantage.";
            this.lblPriorityCompetition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPriorityService
            // 
            this.txtPriorityService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriorityService.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPriorityService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriorityService.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriorityService.Location = new System.Drawing.Point(10, 167);
            this.txtPriorityService.Multiline = false;
            this.txtPriorityService.Name = "txtPriorityService";
            this.txtPriorityService.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPriorityService.Size = new System.Drawing.Size(658, 20);
            this.txtPriorityService.TabIndex = 28;
            this.txtPriorityService.Text = "";
            this.txtPriorityService.WordWrap = false;
            // 
            // lblPriorityService
            // 
            this.lblPriorityService.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPriorityService.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityService.Location = new System.Drawing.Point(7, 144);
            this.lblPriorityService.Name = "lblPriorityService";
            this.lblPriorityService.Size = new System.Drawing.Size(661, 20);
            this.lblPriorityService.TabIndex = 29;
            this.lblPriorityService.Text = "This task is crucial to fulfilling a sold service or product.";
            this.lblPriorityService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPriorityEfficiency
            // 
            this.txtPriorityEfficiency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriorityEfficiency.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPriorityEfficiency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriorityEfficiency.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriorityEfficiency.Location = new System.Drawing.Point(10, 121);
            this.txtPriorityEfficiency.Multiline = false;
            this.txtPriorityEfficiency.Name = "txtPriorityEfficiency";
            this.txtPriorityEfficiency.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPriorityEfficiency.Size = new System.Drawing.Size(658, 20);
            this.txtPriorityEfficiency.TabIndex = 26;
            this.txtPriorityEfficiency.Text = "";
            this.txtPriorityEfficiency.WordWrap = false;
            // 
            // lblPriorityEfficiency
            // 
            this.lblPriorityEfficiency.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPriorityEfficiency.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityEfficiency.Location = new System.Drawing.Point(7, 98);
            this.lblPriorityEfficiency.Name = "lblPriorityEfficiency";
            this.lblPriorityEfficiency.Size = new System.Drawing.Size(661, 20);
            this.lblPriorityEfficiency.TabIndex = 27;
            this.lblPriorityEfficiency.Text = "This task will drastically improve efficiency of a highly critical business proce" +
    "ss.";
            this.lblPriorityEfficiency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPriorityTeamGoals
            // 
            this.txtPriorityTeamGoals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriorityTeamGoals.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPriorityTeamGoals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriorityTeamGoals.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriorityTeamGoals.Location = new System.Drawing.Point(10, 75);
            this.txtPriorityTeamGoals.Multiline = false;
            this.txtPriorityTeamGoals.Name = "txtPriorityTeamGoals";
            this.txtPriorityTeamGoals.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPriorityTeamGoals.Size = new System.Drawing.Size(658, 20);
            this.txtPriorityTeamGoals.TabIndex = 24;
            this.txtPriorityTeamGoals.Text = "";
            this.txtPriorityTeamGoals.WordWrap = false;
            // 
            // lblPriorityTeamGoals
            // 
            this.lblPriorityTeamGoals.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPriorityTeamGoals.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityTeamGoals.Location = new System.Drawing.Point(7, 52);
            this.lblPriorityTeamGoals.Name = "lblPriorityTeamGoals";
            this.lblPriorityTeamGoals.Size = new System.Drawing.Size(661, 20);
            this.lblPriorityTeamGoals.TabIndex = 25;
            this.lblPriorityTeamGoals.Text = "This task is critical to the achievement of a given team’s established goals.";
            this.lblPriorityTeamGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPriorityFirmGoals
            // 
            this.txtPriorityFirmGoals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriorityFirmGoals.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPriorityFirmGoals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriorityFirmGoals.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriorityFirmGoals.Location = new System.Drawing.Point(10, 29);
            this.txtPriorityFirmGoals.Multiline = false;
            this.txtPriorityFirmGoals.Name = "txtPriorityFirmGoals";
            this.txtPriorityFirmGoals.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtPriorityFirmGoals.Size = new System.Drawing.Size(658, 20);
            this.txtPriorityFirmGoals.TabIndex = 4;
            this.txtPriorityFirmGoals.Text = "";
            this.txtPriorityFirmGoals.WordWrap = false;
            // 
            // lblPriorityFirmGoals
            // 
            this.lblPriorityFirmGoals.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPriorityFirmGoals.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityFirmGoals.Location = new System.Drawing.Point(7, 6);
            this.lblPriorityFirmGoals.Name = "lblPriorityFirmGoals";
            this.lblPriorityFirmGoals.Size = new System.Drawing.Size(661, 20);
            this.lblPriorityFirmGoals.TabIndex = 23;
            this.lblPriorityFirmGoals.Text = "This task is critical to the achievement of established firm-wide goals.";
            this.lblPriorityFirmGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlFormHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormHeader.Controls.Add(this.lblFormMinimize);
            this.pnlFormHeader.Controls.Add(this.lblFormClose);
            this.pnlFormHeader.Controls.Add(this.lblFormHeader);
            this.pnlFormHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(681, 30);
            this.pnlFormHeader.TabIndex = 1;
            this.pnlFormHeader.DoubleClick += new System.EventHandler(this.pnlFormHeader_DoubleClick);
            // 
            // lblFormMinimize
            // 
            this.lblFormMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormMinimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblFormMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormMinimize.ForeColor = System.Drawing.Color.White;
            this.lblFormMinimize.Location = new System.Drawing.Point(626, 2);
            this.lblFormMinimize.Name = "lblFormMinimize";
            this.lblFormMinimize.Size = new System.Drawing.Size(25, 25);
            this.lblFormMinimize.TabIndex = 0;
            this.lblFormMinimize.Text = "-";
            this.lblFormMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblFormMinimize.Click += new System.EventHandler(this.lblFormMinimize_Click);
            this.lblFormMinimize.MouseEnter += new System.EventHandler(this.labelGray_MouseEnter);
            this.lblFormMinimize.MouseLeave += new System.EventHandler(this.labelGray_MouseLeave);
            // 
            // lblFormClose
            // 
            this.lblFormClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblFormClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormClose.ForeColor = System.Drawing.Color.White;
            this.lblFormClose.Location = new System.Drawing.Point(654, 2);
            this.lblFormClose.Name = "lblFormClose";
            this.lblFormClose.Size = new System.Drawing.Size(25, 25);
            this.lblFormClose.TabIndex = 1;
            this.lblFormClose.Text = "x";
            this.lblFormClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFormClose.Click += new System.EventHandler(this.lblFormClose_Click);
            this.lblFormClose.MouseEnter += new System.EventHandler(this.labelGray_MouseEnter);
            this.lblFormClose.MouseLeave += new System.EventHandler(this.labelGray_MouseLeave);
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.White;
            this.lblFormHeader.Location = new System.Drawing.Point(6, 5);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(104, 19);
            this.lblFormHeader.TabIndex = 1;
            this.lblFormHeader.Text = "Ticket Tracker";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.Color.Silver;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.lblPriority);
            this.pnlMenu.Controls.Add(this.lblScope);
            this.pnlMenu.Controls.Add(this.lblTasks);
            this.pnlMenu.Controls.Add(this.lblTicketTimes);
            this.pnlMenu.Controls.Add(this.lblSummary);
            this.pnlMenu.Location = new System.Drawing.Point(0, 395);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(681, 49);
            this.pnlMenu.TabIndex = 2;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPriority.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(190, 11);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(77, 25);
            this.lblPriority.TabIndex = 1;
            this.lblPriority.Text = "Priority";
            this.lblPriority.Click += new System.EventHandler(this.lblPriority_Click);
            this.lblPriority.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.lblPriority.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            // 
            // lblScope
            // 
            this.lblScope.AutoSize = true;
            this.lblScope.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblScope.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScope.Location = new System.Drawing.Point(116, 11);
            this.lblScope.Name = "lblScope";
            this.lblScope.Size = new System.Drawing.Size(68, 25);
            this.lblScope.TabIndex = 1;
            this.lblScope.Text = "Scope";
            this.lblScope.Click += new System.EventHandler(this.lblScope_Click);
            this.lblScope.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.lblScope.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTasks.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(273, 11);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(62, 25);
            this.lblTasks.TabIndex = 1;
            this.lblTasks.Text = "Tasks";
            this.lblTasks.Click += new System.EventHandler(this.lblTasks_Click);
            this.lblTasks.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.lblTasks.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            // 
            // lblTicketTimes
            // 
            this.lblTicketTimes.AutoSize = true;
            this.lblTicketTimes.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTicketTimes.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketTimes.Location = new System.Drawing.Point(341, 11);
            this.lblTicketTimes.Name = "lblTicketTimes";
            this.lblTicketTimes.Size = new System.Drawing.Size(125, 25);
            this.lblTicketTimes.TabIndex = 1;
            this.lblTicketTimes.Text = "Time Entries";
            this.lblTicketTimes.Click += new System.EventHandler(this.lblTicketTimes_Click);
            this.lblTicketTimes.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.lblTicketTimes.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSummary.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(11, 11);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(99, 25);
            this.lblSummary.TabIndex = 1;
            this.lblSummary.Text = "Summary";
            this.lblSummary.Click += new System.EventHandler(this.lblSummary_Click);
            this.lblSummary.MouseEnter += new System.EventHandler(this.menuItem_MouseEnter);
            this.lblSummary.MouseLeave += new System.EventHandler(this.menuItem_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblFormStatus);
            this.panel1.Location = new System.Drawing.Point(0, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 20);
            this.panel1.TabIndex = 3;
            // 
            // lblFormStatus
            // 
            this.lblFormStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFormStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblFormStatus.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormStatus.ForeColor = System.Drawing.Color.Black;
            this.lblFormStatus.Location = new System.Drawing.Point(5, 0);
            this.lblFormStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormStatus.Name = "lblFormStatus";
            this.lblFormStatus.Size = new System.Drawing.Size(105, 17);
            this.lblFormStatus.TabIndex = 41;
            this.lblFormStatus.Text = "Ready";
            this.lblFormStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // niMain
            // 
            this.niMain.Text = "notifyIcon1";
            this.niMain.Visible = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboType
            // 
            this.cboType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboType.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "",
            "New",
            "Maintenance"});
            this.cboType.Location = new System.Drawing.Point(110, 103);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(558, 22);
            this.cboType.TabIndex = 2;
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlFormHeader);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.tabMain.ResumeLayout(false);
            this.tabTickets.ResumeLayout(false);
            this.pnlBodySummary.ResumeLayout(false);
            this.cmMain.ResumeLayout(false);
            this.tabScope.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabTicketTimes.ResumeLayout(false);
            this.pnlBodyTicketTimes.ResumeLayout(false);
            this.pnlBodyTicketTimes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketTimes)).EndInit();
            this.tabTasks.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.tabPriority.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.Panel pnlBodySummary;
        private System.Windows.Forms.Panel pnlFormHeader;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Label lblFormMinimize;
        private System.Windows.Forms.Label lblFormClose;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.RichTextBox txtSubject;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.ComboBox cboOwner;
        private System.Windows.Forms.ComboBox cboRequestedBy;
        private System.Windows.Forms.Label lblRequestedBy;
        private System.Windows.Forms.Label lblDateCompleted;
        private System.Windows.Forms.RichTextBox txtDateCompleted;
        private System.Windows.Forms.Label lblTargetDate;
        private System.Windows.Forms.RichTextBox txtTargetDate;
        private System.Windows.Forms.Label lblDateAssigned;
        private System.Windows.Forms.RichTextBox txtDateAssigned;
        private System.Windows.Forms.ComboBox cboPriorityLevel;
        private System.Windows.Forms.Label lblPriorityLevel;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSummary;
        public System.Windows.Forms.Label lblFormStatus;
        private System.Windows.Forms.TabPage tabTicketTimes;
        private System.Windows.Forms.Panel pnlBodyTicketTimes;
        private System.Windows.Forms.Label lblTicketTimes;
        public System.Windows.Forms.DataGridView dgvTicketTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriorityLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAssigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerIdName;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTicketTimeViews;
        private System.Windows.Forms.ContextMenuStrip cmMain;
        private System.Windows.Forms.ToolStripMenuItem addCurrentTimeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon niMain;
        private System.Windows.Forms.TabPage tabTasks;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTaskViews;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnDeleteTask;
        public System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox cboTasks;
        private System.Windows.Forms.Button btnSendEmailUpdate;
        private System.Windows.Forms.TabPage tabScope;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox txtPurpose;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblScope;
        private System.Windows.Forms.RichTextBox txtDeliverables;
        private System.Windows.Forms.Label lblDeliverables;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label lblEstimate;
        private System.Windows.Forms.RichTextBox txtCompleted;
        private System.Windows.Forms.RichTextBox txtEstimate;
        private System.Windows.Forms.TabPage tabPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox txtPriorityFirmGoals;
        private System.Windows.Forms.Label lblPriorityFirmGoals;
        private System.Windows.Forms.RichTextBox txtPriorityOverride;
        private System.Windows.Forms.Label lblPriorityTotalScore;
        private System.Windows.Forms.Label lblPriorityOverride;
        private System.Windows.Forms.RichTextBox txtPriorityCompliance;
        private System.Windows.Forms.Label lblPriorityCompliance;
        private System.Windows.Forms.RichTextBox txtPriorityCompetition;
        private System.Windows.Forms.Label lblPriorityCompetition;
        private System.Windows.Forms.RichTextBox txtPriorityService;
        private System.Windows.Forms.Label lblPriorityService;
        private System.Windows.Forms.RichTextBox txtPriorityEfficiency;
        private System.Windows.Forms.Label lblPriorityEfficiency;
        private System.Windows.Forms.RichTextBox txtPriorityTeamGoals;
        private System.Windows.Forms.Label lblPriorityTeamGoals;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label2;
    }
}

