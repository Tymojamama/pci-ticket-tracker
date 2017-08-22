namespace TicketTracker.Presentation.Forms
{
    partial class frmMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.pnlFormBody = new System.Windows.Forms.Panel();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSendWeeklyEmail = new System.Windows.Forms.Button();
            this.btnOpenTicketTime = new System.Windows.Forms.Button();
            this.cboViews = new System.Windows.Forms.ComboBox();
            this.lblSelectedTicket = new System.Windows.Forms.Label();
            this.lblViews = new System.Windows.Forms.Label();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.TicketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriorityLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAssigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerIdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abandondedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFormHeader = new System.Windows.Forms.Panel();
            this.lblFormMinimize = new System.Windows.Forms.Label();
            this.lblFormClose = new System.Windows.Forms.Label();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.niMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabMain.SuspendLayout();
            this.tabTickets.SuspendLayout();
            this.pnlFormBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.cmMain.SuspendLayout();
            this.pnlFormHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMain.Controls.Add(this.tabTickets);
            this.tabMain.Location = new System.Drawing.Point(-4, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1023, 553);
            this.tabMain.TabIndex = 0;
            // 
            // tabTickets
            // 
            this.tabTickets.BackColor = System.Drawing.Color.Gainsboro;
            this.tabTickets.Controls.Add(this.pnlFormBody);
            this.tabTickets.Location = new System.Drawing.Point(4, 25);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTickets.Size = new System.Drawing.Size(1015, 524);
            this.tabTickets.TabIndex = 0;
            this.tabTickets.Text = "tabTickets";
            // 
            // pnlFormBody
            // 
            this.pnlFormBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormBody.Controls.Add(this.lblCapacity);
            this.pnlFormBody.Controls.Add(this.btnNew);
            this.pnlFormBody.Controls.Add(this.btnEdit);
            this.pnlFormBody.Controls.Add(this.btnDelete);
            this.pnlFormBody.Controls.Add(this.btnSendWeeklyEmail);
            this.pnlFormBody.Controls.Add(this.btnOpenTicketTime);
            this.pnlFormBody.Controls.Add(this.cboViews);
            this.pnlFormBody.Controls.Add(this.lblSelectedTicket);
            this.pnlFormBody.Controls.Add(this.lblViews);
            this.pnlFormBody.Controls.Add(this.dgvTickets);
            this.pnlFormBody.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBody.Name = "pnlFormBody";
            this.pnlFormBody.Size = new System.Drawing.Size(1015, 524);
            this.pnlFormBody.TabIndex = 0;
            // 
            // lblCapacity
            // 
            this.lblCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(11, 461);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(184, 16);
            this.lblCapacity.TabIndex = 4;
            this.lblCapacity.Text = "Weeks to complete tasks: 0.00";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(792, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(68, 25);
            this.btnNew.TabIndex = 3;
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
            this.btnEdit.Location = new System.Drawing.Point(866, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 25);
            this.btnEdit.TabIndex = 3;
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
            this.btnDelete.Location = new System.Drawing.Point(940, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 25);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSendWeeklyEmail
            // 
            this.btnSendWeeklyEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendWeeklyEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSendWeeklyEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendWeeklyEmail.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendWeeklyEmail.Location = new System.Drawing.Point(846, 481);
            this.btnSendWeeklyEmail.Name = "btnSendWeeklyEmail";
            this.btnSendWeeklyEmail.Size = new System.Drawing.Size(75, 31);
            this.btnSendWeeklyEmail.TabIndex = 3;
            this.btnSendWeeklyEmail.Text = "Email All";
            this.btnSendWeeklyEmail.UseVisualStyleBackColor = false;
            this.btnSendWeeklyEmail.Click += new System.EventHandler(this.btnSendWeeklyEmail_Click);
            // 
            // btnOpenTicketTime
            // 
            this.btnOpenTicketTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenTicketTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenTicketTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenTicketTime.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTicketTime.Location = new System.Drawing.Point(927, 481);
            this.btnOpenTicketTime.Name = "btnOpenTicketTime";
            this.btnOpenTicketTime.Size = new System.Drawing.Size(75, 31);
            this.btnOpenTicketTime.TabIndex = 3;
            this.btnOpenTicketTime.Text = "+ Time";
            this.btnOpenTicketTime.UseVisualStyleBackColor = false;
            this.btnOpenTicketTime.Click += new System.EventHandler(this.btnOpenTicketTime_Click);
            // 
            // cboViews
            // 
            this.cboViews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboViews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboViews.FormattingEnabled = true;
            this.cboViews.Items.AddRange(new object[] {
            "In Progress Tickets",
            "Active Tickets",
            "Inactive Tickets"});
            this.cboViews.Location = new System.Drawing.Point(64, 9);
            this.cboViews.Name = "cboViews";
            this.cboViews.Size = new System.Drawing.Size(422, 21);
            this.cboViews.TabIndex = 2;
            this.cboViews.SelectedIndexChanged += new System.EventHandler(this.cboViews_SelectedIndexChanged);
            // 
            // lblSelectedTicket
            // 
            this.lblSelectedTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedTicket.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSelectedTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedTicket.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedTicket.Location = new System.Drawing.Point(11, 481);
            this.lblSelectedTicket.Name = "lblSelectedTicket";
            this.lblSelectedTicket.Size = new System.Drawing.Size(676, 31);
            this.lblSelectedTicket.TabIndex = 1;
            this.lblSelectedTicket.Text = "Please select a task";
            this.lblSelectedTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblViews
            // 
            this.lblViews.AutoSize = true;
            this.lblViews.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViews.Location = new System.Drawing.Point(11, 10);
            this.lblViews.Name = "lblViews";
            this.lblViews.Size = new System.Drawing.Size(47, 19);
            this.lblViews.TabIndex = 1;
            this.lblViews.Text = "Views";
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.AllowUserToResizeRows = false;
            this.dgvTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTickets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketId,
            this.SubjectValue,
            this.PriorityLevel,
            this.DateAssigned,
            this.TargetDate,
            this.RequestedBy,
            this.OwnerIdName});
            this.dgvTickets.ContextMenuStrip = this.cmMain;
            this.dgvTickets.EnableHeadersVisualStyles = false;
            this.dgvTickets.Location = new System.Drawing.Point(9, 37);
            this.dgvTickets.MultiSelect = false;
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTickets.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTickets.RowHeadersVisible = false;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTickets.ShowEditingIcon = false;
            this.dgvTickets.Size = new System.Drawing.Size(999, 421);
            this.dgvTickets.TabIndex = 0;
            this.dgvTickets.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellDoubleClick);
            this.dgvTickets.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellEnter);
            this.dgvTickets.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTickets_CellMouseDown);
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
            // cmMain
            // 
            this.cmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTicketToolStripMenuItem,
            this.recordTimeToolStripMenuItem,
            this.markToolStripMenuItem});
            this.cmMain.Name = "cmMain";
            this.cmMain.Size = new System.Drawing.Size(142, 70);
            // 
            // openTicketToolStripMenuItem
            // 
            this.openTicketToolStripMenuItem.Name = "openTicketToolStripMenuItem";
            this.openTicketToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.openTicketToolStripMenuItem.Text = "Open Ticket";
            this.openTicketToolStripMenuItem.Click += new System.EventHandler(this.openTicketToolStripMenuItem_Click);
            // 
            // recordTimeToolStripMenuItem
            // 
            this.recordTimeToolStripMenuItem.Name = "recordTimeToolStripMenuItem";
            this.recordTimeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.recordTimeToolStripMenuItem.Text = "Record Time";
            this.recordTimeToolStripMenuItem.Click += new System.EventHandler(this.recordTimeToolStripMenuItem_Click);
            // 
            // markToolStripMenuItem
            // 
            this.markToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.completeToolStripMenuItem,
            this.inProgressToolStripMenuItem,
            this.abandondedToolStripMenuItem});
            this.markToolStripMenuItem.Name = "markToolStripMenuItem";
            this.markToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.markToolStripMenuItem.Text = "Mark..";
            // 
            // completeToolStripMenuItem
            // 
            this.completeToolStripMenuItem.Name = "completeToolStripMenuItem";
            this.completeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.completeToolStripMenuItem.Text = "Complete";
            this.completeToolStripMenuItem.Click += new System.EventHandler(this.completeToolStripMenuItem_Click);
            // 
            // inProgressToolStripMenuItem
            // 
            this.inProgressToolStripMenuItem.Name = "inProgressToolStripMenuItem";
            this.inProgressToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.inProgressToolStripMenuItem.Text = "In Progress";
            this.inProgressToolStripMenuItem.Click += new System.EventHandler(this.inProgressToolStripMenuItem_Click);
            // 
            // abandondedToolStripMenuItem
            // 
            this.abandondedToolStripMenuItem.Name = "abandondedToolStripMenuItem";
            this.abandondedToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.abandondedToolStripMenuItem.Text = "Abandonded";
            this.abandondedToolStripMenuItem.Click += new System.EventHandler(this.abandondedToolStripMenuItem_Click);
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
            this.pnlFormHeader.Size = new System.Drawing.Size(1015, 30);
            this.pnlFormHeader.TabIndex = 1;
            this.pnlFormHeader.DoubleClick += new System.EventHandler(this.pnlFormHeader_DoubleClick);
            // 
            // lblFormMinimize
            // 
            this.lblFormMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormMinimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblFormMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormMinimize.ForeColor = System.Drawing.Color.White;
            this.lblFormMinimize.Location = new System.Drawing.Point(960, 2);
            this.lblFormMinimize.Name = "lblFormMinimize";
            this.lblFormMinimize.Size = new System.Drawing.Size(25, 25);
            this.lblFormMinimize.TabIndex = 23;
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
            this.lblFormClose.Location = new System.Drawing.Point(988, 2);
            this.lblFormClose.Name = "lblFormClose";
            this.lblFormClose.Size = new System.Drawing.Size(25, 25);
            this.lblFormClose.TabIndex = 24;
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
            // niMain
            // 
            this.niMain.Text = "notifyIcon1";
            this.niMain.Visible = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 553);
            this.Controls.Add(this.pnlFormHeader);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketTracker";
            this.tabMain.ResumeLayout(false);
            this.tabTickets.ResumeLayout(false);
            this.pnlFormBody.ResumeLayout(false);
            this.pnlFormBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.cmMain.ResumeLayout(false);
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.Panel pnlFormBody;
        private System.Windows.Forms.Panel pnlFormHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriorityLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAssigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerIdName;
        private System.Windows.Forms.Label lblViews;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.ComboBox cboViews;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnOpenTicketTime;
        private System.Windows.Forms.Label lblSelectedTicket;
        private System.Windows.Forms.Label lblFormMinimize;
        private System.Windows.Forms.Label lblFormClose;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.ContextMenuStrip cmMain;
        private System.Windows.Forms.ToolStripMenuItem recordTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abandondedToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon niMain;
        private System.Windows.Forms.Button btnSendWeeklyEmail;
        private System.Windows.Forms.Label lblCapacity;
    }
}

