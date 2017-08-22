namespace TicketTracker.Presentation.Forms
{
    partial class frmTask
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.pnlFormBody = new System.Windows.Forms.Panel();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCreatedOn = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtTicket = new System.Windows.Forms.RichTextBox();
            this.txtCreatedOn = new System.Windows.Forms.RichTextBox();
            this.txtDueDate = new System.Windows.Forms.RichTextBox();
            this.txtSubject = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlFormHeader = new System.Windows.Forms.Panel();
            this.lblFormMinimize = new System.Windows.Forms.Label();
            this.lblFormClose = new System.Windows.Forms.Label();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.lblCompletedOn = new System.Windows.Forms.Label();
            this.txtCompletedOn = new System.Windows.Forms.RichTextBox();
            this.tabMain.SuspendLayout();
            this.tabTickets.SuspendLayout();
            this.pnlFormBody.SuspendLayout();
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
            this.tabMain.Size = new System.Drawing.Size(572, 417);
            this.tabMain.TabIndex = 0;
            // 
            // tabTickets
            // 
            this.tabTickets.BackColor = System.Drawing.Color.Gainsboro;
            this.tabTickets.Controls.Add(this.pnlFormBody);
            this.tabTickets.Location = new System.Drawing.Point(4, 25);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTickets.Size = new System.Drawing.Size(564, 388);
            this.tabTickets.TabIndex = 0;
            this.tabTickets.Text = "tabTickets";
            // 
            // pnlFormBody
            // 
            this.pnlFormBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormBody.Controls.Add(this.lblCompletedOn);
            this.pnlFormBody.Controls.Add(this.txtCompletedOn);
            this.pnlFormBody.Controls.Add(this.cboStatus);
            this.pnlFormBody.Controls.Add(this.lblDescription);
            this.pnlFormBody.Controls.Add(this.lblTicket);
            this.pnlFormBody.Controls.Add(this.lblStatus);
            this.pnlFormBody.Controls.Add(this.lblCreatedOn);
            this.pnlFormBody.Controls.Add(this.lblDueDate);
            this.pnlFormBody.Controls.Add(this.lblSubject);
            this.pnlFormBody.Controls.Add(this.txtDescription);
            this.pnlFormBody.Controls.Add(this.txtTicket);
            this.pnlFormBody.Controls.Add(this.txtCreatedOn);
            this.pnlFormBody.Controls.Add(this.txtDueDate);
            this.pnlFormBody.Controls.Add(this.txtSubject);
            this.pnlFormBody.Controls.Add(this.btnSubmit);
            this.pnlFormBody.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBody.Name = "pnlFormBody";
            this.pnlFormBody.Size = new System.Drawing.Size(564, 388);
            this.pnlFormBody.TabIndex = 0;
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(100, 61);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(451, 22);
            this.cboStatus.TabIndex = 2;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDescription.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(11, 167);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 21);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTicket
            // 
            this.lblTicket.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTicket.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(11, 8);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(83, 20);
            this.lblTicket.TabIndex = 19;
            this.lblTicket.Text = "Ticket";
            this.lblTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(11, 61);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 20);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreatedOn
            // 
            this.lblCreatedOn.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCreatedOn.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedOn.Location = new System.Drawing.Point(11, 141);
            this.lblCreatedOn.Name = "lblCreatedOn";
            this.lblCreatedOn.Size = new System.Drawing.Size(83, 20);
            this.lblCreatedOn.TabIndex = 19;
            this.lblCreatedOn.Text = "Created On";
            this.lblCreatedOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDueDate
            // 
            this.lblDueDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDueDate.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(11, 89);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(83, 20);
            this.lblDueDate.TabIndex = 19;
            this.lblDueDate.Text = "Due Date";
            this.lblDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubject
            // 
            this.lblSubject.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSubject.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(11, 34);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(83, 20);
            this.lblSubject.TabIndex = 19;
            this.lblSubject.Text = "Subject";
            this.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsTab = true;
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.AutoWordSelection = true;
            this.txtDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(100, 167);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(451, 167);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "";
            // 
            // txtTicket
            // 
            this.txtTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTicket.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTicket.Enabled = false;
            this.txtTicket.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket.ForeColor = System.Drawing.Color.Black;
            this.txtTicket.Location = new System.Drawing.Point(100, 8);
            this.txtTicket.Multiline = false;
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.ReadOnly = true;
            this.txtTicket.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtTicket.Size = new System.Drawing.Size(451, 20);
            this.txtTicket.TabIndex = 0;
            this.txtTicket.Text = "";
            this.txtTicket.WordWrap = false;
            // 
            // txtCreatedOn
            // 
            this.txtCreatedOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreatedOn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCreatedOn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreatedOn.Enabled = false;
            this.txtCreatedOn.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatedOn.Location = new System.Drawing.Point(100, 141);
            this.txtCreatedOn.Multiline = false;
            this.txtCreatedOn.Name = "txtCreatedOn";
            this.txtCreatedOn.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtCreatedOn.Size = new System.Drawing.Size(451, 20);
            this.txtCreatedOn.TabIndex = 1;
            this.txtCreatedOn.Text = "";
            this.txtCreatedOn.WordWrap = false;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDueDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDueDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDueDate.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueDate.Location = new System.Drawing.Point(100, 89);
            this.txtDueDate.Multiline = false;
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtDueDate.Size = new System.Drawing.Size(451, 20);
            this.txtDueDate.TabIndex = 3;
            this.txtDueDate.Text = "";
            this.txtDueDate.WordWrap = false;
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubject.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(100, 34);
            this.txtSubject.Multiline = false;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtSubject.Size = new System.Drawing.Size(451, 20);
            this.txtSubject.TabIndex = 1;
            this.txtSubject.Text = "";
            this.txtSubject.WordWrap = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.Location = new System.Drawing.Point(-1, 347);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(564, 40);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.pnlFormHeader.Size = new System.Drawing.Size(564, 30);
            this.pnlFormHeader.TabIndex = 1;
            this.pnlFormHeader.DoubleClick += new System.EventHandler(this.pnlFormHeader_DoubleClick);
            // 
            // lblFormMinimize
            // 
            this.lblFormMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormMinimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblFormMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormMinimize.ForeColor = System.Drawing.Color.White;
            this.lblFormMinimize.Location = new System.Drawing.Point(506, 2);
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
            this.lblFormClose.Location = new System.Drawing.Point(534, 2);
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
            // lblCompletedOn
            // 
            this.lblCompletedOn.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCompletedOn.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedOn.Location = new System.Drawing.Point(11, 115);
            this.lblCompletedOn.Name = "lblCompletedOn";
            this.lblCompletedOn.Size = new System.Drawing.Size(83, 20);
            this.lblCompletedOn.TabIndex = 21;
            this.lblCompletedOn.Text = "Completed On";
            this.lblCompletedOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCompletedOn
            // 
            this.txtCompletedOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompletedOn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCompletedOn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompletedOn.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompletedOn.Location = new System.Drawing.Point(100, 115);
            this.txtCompletedOn.Multiline = false;
            this.txtCompletedOn.Name = "txtCompletedOn";
            this.txtCompletedOn.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtCompletedOn.Size = new System.Drawing.Size(451, 20);
            this.txtCompletedOn.TabIndex = 20;
            this.txtCompletedOn.Text = "";
            this.txtCompletedOn.WordWrap = false;
            // 
            // frmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 417);
            this.Controls.Add(this.pnlFormHeader);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task";
            this.tabMain.ResumeLayout(false);
            this.tabTickets.ResumeLayout(false);
            this.pnlFormBody.ResumeLayout(false);
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.Panel pnlFormBody;
        private System.Windows.Forms.Panel pnlFormHeader;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Label lblFormMinimize;
        private System.Windows.Forms.Label lblFormClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.RichTextBox txtSubject;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.RichTextBox txtTicket;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblCreatedOn;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.RichTextBox txtCreatedOn;
        private System.Windows.Forms.RichTextBox txtDueDate;
        private System.Windows.Forms.Label lblCompletedOn;
        private System.Windows.Forms.RichTextBox txtCompletedOn;
    }
}

