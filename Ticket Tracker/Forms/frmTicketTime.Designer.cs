namespace TicketTracker.Presentation.Forms
{
    partial class frmTicketTime
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.pnlFormBody = new System.Windows.Forms.Panel();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.RichTextBox();
            this.cmsTimeSpan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calculateDurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEndTime = new System.Windows.Forms.RichTextBox();
            this.cmsDateTime = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCurrentTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtStartTime = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtTicket = new System.Windows.Forms.RichTextBox();
            this.txtSubject = new System.Windows.Forms.RichTextBox();
            this.btnTimerReset = new System.Windows.Forms.Button();
            this.btnTimerGo = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlFormHeader = new System.Windows.Forms.Panel();
            this.lblFormMinimize = new System.Windows.Forms.Label();
            this.lblFormClose = new System.Windows.Forms.Label();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabTickets.SuspendLayout();
            this.pnlFormBody.SuspendLayout();
            this.cmsTimeSpan.SuspendLayout();
            this.cmsDateTime.SuspendLayout();
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
            this.tabMain.Size = new System.Drawing.Size(467, 302);
            this.tabMain.TabIndex = 0;
            // 
            // tabTickets
            // 
            this.tabTickets.BackColor = System.Drawing.Color.Gainsboro;
            this.tabTickets.Controls.Add(this.pnlFormBody);
            this.tabTickets.Location = new System.Drawing.Point(4, 25);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTickets.Size = new System.Drawing.Size(459, 273);
            this.tabTickets.TabIndex = 0;
            this.tabTickets.Text = "tabTickets";
            // 
            // pnlFormBody
            // 
            this.pnlFormBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormBody.Controls.Add(this.lblDuration);
            this.pnlFormBody.Controls.Add(this.lblEndTime);
            this.pnlFormBody.Controls.Add(this.lblStartTime);
            this.pnlFormBody.Controls.Add(this.txtDuration);
            this.pnlFormBody.Controls.Add(this.txtEndTime);
            this.pnlFormBody.Controls.Add(this.txtStartTime);
            this.pnlFormBody.Controls.Add(this.lblDescription);
            this.pnlFormBody.Controls.Add(this.lblTicket);
            this.pnlFormBody.Controls.Add(this.lblSubject);
            this.pnlFormBody.Controls.Add(this.txtDescription);
            this.pnlFormBody.Controls.Add(this.txtTicket);
            this.pnlFormBody.Controls.Add(this.txtSubject);
            this.pnlFormBody.Controls.Add(this.btnTimerReset);
            this.pnlFormBody.Controls.Add(this.btnTimerGo);
            this.pnlFormBody.Controls.Add(this.btnSubmit);
            this.pnlFormBody.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBody.Name = "pnlFormBody";
            this.pnlFormBody.Size = new System.Drawing.Size(459, 273);
            this.pnlFormBody.TabIndex = 0;
            // 
            // lblDuration
            // 
            this.lblDuration.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDuration.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.Black;
            this.lblDuration.Location = new System.Drawing.Point(14, 162);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(80, 21);
            this.lblDuration.TabIndex = 23;
            this.lblDuration.Text = "Duration";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEndTime
            // 
            this.lblEndTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEndTime.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.ForeColor = System.Drawing.Color.Black;
            this.lblEndTime.Location = new System.Drawing.Point(14, 135);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(80, 21);
            this.lblEndTime.TabIndex = 24;
            this.lblEndTime.Text = "End";
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStartTime
            // 
            this.lblStartTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStartTime.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.Color.Black;
            this.lblStartTime.Location = new System.Drawing.Point(14, 109);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(80, 20);
            this.lblStartTime.TabIndex = 25;
            this.lblStartTime.Text = "Start";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDuration
            // 
            this.txtDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuration.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuration.ContextMenuStrip = this.cmsTimeSpan;
            this.txtDuration.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(100, 162);
            this.txtDuration.Multiline = false;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtDuration.Size = new System.Drawing.Size(346, 21);
            this.txtDuration.TabIndex = 5;
            this.txtDuration.Text = "";
            this.txtDuration.WordWrap = false;
            // 
            // cmsTimeSpan
            // 
            this.cmsTimeSpan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateDurationToolStripMenuItem});
            this.cmsTimeSpan.Name = "contextMenuStrip1";
            this.cmsTimeSpan.Size = new System.Drawing.Size(173, 26);
            // 
            // calculateDurationToolStripMenuItem
            // 
            this.calculateDurationToolStripMenuItem.Name = "calculateDurationToolStripMenuItem";
            this.calculateDurationToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.calculateDurationToolStripMenuItem.Text = "Calculate Duration";
            this.calculateDurationToolStripMenuItem.Click += new System.EventHandler(this.calculateDurationToolStripMenuItem_Click);
            // 
            // txtEndTime
            // 
            this.txtEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEndTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndTime.ContextMenuStrip = this.cmsDateTime;
            this.txtEndTime.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndTime.Location = new System.Drawing.Point(100, 136);
            this.txtEndTime.Multiline = false;
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtEndTime.Size = new System.Drawing.Size(346, 20);
            this.txtEndTime.TabIndex = 4;
            this.txtEndTime.Text = "";
            this.txtEndTime.WordWrap = false;
            // 
            // cmsDateTime
            // 
            this.cmsDateTime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCurrentTimeToolStripMenuItem});
            this.cmsDateTime.Name = "contextMenuStrip1";
            this.cmsDateTime.Size = new System.Drawing.Size(170, 26);
            // 
            // addCurrentTimeToolStripMenuItem
            // 
            this.addCurrentTimeToolStripMenuItem.Name = "addCurrentTimeToolStripMenuItem";
            this.addCurrentTimeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addCurrentTimeToolStripMenuItem.Text = "Add Current Time";
            this.addCurrentTimeToolStripMenuItem.Click += new System.EventHandler(this.addCurrentTimeToolStripMenuItem_Click);
            // 
            // txtStartTime
            // 
            this.txtStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStartTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartTime.ContextMenuStrip = this.cmsDateTime;
            this.txtStartTime.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartTime.Location = new System.Drawing.Point(100, 109);
            this.txtStartTime.Multiline = false;
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtStartTime.Size = new System.Drawing.Size(346, 20);
            this.txtStartTime.TabIndex = 3;
            this.txtStartTime.Text = "";
            this.txtStartTime.WordWrap = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDescription.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(11, 60);
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
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(100, 61);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(346, 42);
            this.txtDescription.TabIndex = 2;
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
            this.txtTicket.Size = new System.Drawing.Size(346, 20);
            this.txtTicket.TabIndex = 0;
            this.txtTicket.Text = "";
            this.txtTicket.WordWrap = false;
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
            this.txtSubject.Size = new System.Drawing.Size(346, 20);
            this.txtSubject.TabIndex = 1;
            this.txtSubject.Text = "";
            this.txtSubject.WordWrap = false;
            // 
            // btnTimerReset
            // 
            this.btnTimerReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimerReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimerReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimerReset.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerReset.Location = new System.Drawing.Point(229, 190);
            this.btnTimerReset.Name = "btnTimerReset";
            this.btnTimerReset.Size = new System.Drawing.Size(229, 43);
            this.btnTimerReset.TabIndex = 8;
            this.btnTimerReset.Text = "Reset";
            this.btnTimerReset.UseVisualStyleBackColor = false;
            this.btnTimerReset.Click += new System.EventHandler(this.btnTimerReset_Click);
            // 
            // btnTimerGo
            // 
            this.btnTimerGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTimerGo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimerGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimerGo.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerGo.Location = new System.Drawing.Point(-1, 190);
            this.btnTimerGo.Name = "btnTimerGo";
            this.btnTimerGo.Size = new System.Drawing.Size(231, 43);
            this.btnTimerGo.TabIndex = 7;
            this.btnTimerGo.Text = "Start";
            this.btnTimerGo.UseVisualStyleBackColor = false;
            this.btnTimerGo.Click += new System.EventHandler(this.btnTimerGo_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.Location = new System.Drawing.Point(-1, 232);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(459, 40);
            this.btnSubmit.TabIndex = 6;
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
            this.pnlFormHeader.Size = new System.Drawing.Size(459, 30);
            this.pnlFormHeader.TabIndex = 1;
            this.pnlFormHeader.DoubleClick += new System.EventHandler(this.pnlFormHeader_DoubleClick);
            // 
            // lblFormMinimize
            // 
            this.lblFormMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormMinimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblFormMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormMinimize.ForeColor = System.Drawing.Color.White;
            this.lblFormMinimize.Location = new System.Drawing.Point(401, 2);
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
            this.lblFormClose.Location = new System.Drawing.Point(429, 2);
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
            // frmTicketTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 302);
            this.Controls.Add(this.pnlFormHeader);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTicketTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Entry";
            this.tabMain.ResumeLayout(false);
            this.tabTickets.ResumeLayout(false);
            this.pnlFormBody.ResumeLayout(false);
            this.cmsTimeSpan.ResumeLayout(false);
            this.cmsDateTime.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnTimerReset;
        private System.Windows.Forms.Label lblFormMinimize;
        private System.Windows.Forms.Label lblFormClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.RichTextBox txtDuration;
        private System.Windows.Forms.RichTextBox txtEndTime;
        private System.Windows.Forms.RichTextBox txtStartTime;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.RichTextBox txtSubject;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.RichTextBox txtTicket;
        private System.Windows.Forms.ContextMenuStrip cmsDateTime;
        private System.Windows.Forms.ToolStripMenuItem addCurrentTimeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsTimeSpan;
        private System.Windows.Forms.ToolStripMenuItem calculateDurationToolStripMenuItem;
        public System.Windows.Forms.Button btnTimerGo;
    }
}

