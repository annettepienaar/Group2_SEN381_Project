
namespace Group2_SEN381_Project.PresentationLayer
{
    partial class TicketManagementForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTechnition = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpecialization = new System.Windows.Forms.Label();
            this.gbTicketInformation = new System.Windows.Forms.GroupBox();
            this.cbProblemArea = new System.Windows.Forms.ComboBox();
            this.cbTicketLevel = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.Label();
            this.lblDescriptionTitle = new System.Windows.Forms.Label();
            this.lblClientIDTitle = new System.Windows.Forms.Label();
            this.lblProblemAreaTitle = new System.Windows.Forms.Label();
            this.txtTicketState = new System.Windows.Forms.Label();
            this.lblTicketStateTitle = new System.Windows.Forms.Label();
            this.txtOpenDate = new System.Windows.Forms.Label();
            this.lblOpenDateTitle = new System.Windows.Forms.Label();
            this.lblLevelTitle = new System.Windows.Forms.Label();
            this.txtTicketID = new System.Windows.Forms.Label();
            this.lblIDTitle = new System.Windows.Forms.Label();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.lblTicketTitle = new System.Windows.Forms.Label();
            this.lblSpecializationTitle = new System.Windows.Forms.Label();
            this.lblTechnitionTitle = new System.Windows.Forms.Label();
            this.pnlTicketDisplay = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbUnassignedTickets = new System.Windows.Forms.ListBox();
            this.btnReloadTickets = new System.Windows.Forms.Button();
            this.btnAssignTicket = new System.Windows.Forms.Button();
            this.lblUnassignedTickets = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbTicketInformation.SuspendLayout();
            this.pnlTicketDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.cbTechnition);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSpecialization);
            this.panel1.Controls.Add(this.gbTicketInformation);
            this.panel1.Controls.Add(this.txtTickets);
            this.panel1.Controls.Add(this.lblTicketTitle);
            this.panel1.Controls.Add(this.lblSpecializationTitle);
            this.panel1.Controls.Add(this.lblTechnitionTitle);
            this.panel1.Controls.Add(this.pnlTicketDisplay);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 570);
            this.panel1.TabIndex = 25;
            // 
            // cbTechnition
            // 
            this.cbTechnition.FormattingEnabled = true;
            this.cbTechnition.Location = new System.Drawing.Point(171, 31);
            this.cbTechnition.Name = "cbTechnition";
            this.cbTechnition.Size = new System.Drawing.Size(300, 21);
            this.cbTechnition.TabIndex = 25;
            this.cbTechnition.SelectedIndexChanged += new System.EventHandler(this.cbTechnition_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(155, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 562);
            this.label4.TabIndex = 24;
            this.label4.Text = "label4";
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.BackColor = System.Drawing.Color.White;
            this.txtSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSpecialization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSpecialization.Location = new System.Drawing.Point(578, 31);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.Size = new System.Drawing.Size(300, 25);
            this.txtSpecialization.TabIndex = 21;
            // 
            // gbTicketInformation
            // 
            this.gbTicketInformation.Controls.Add(this.txtClientPhone);
            this.gbTicketInformation.Controls.Add(this.lblPhoneTitle);
            this.gbTicketInformation.Controls.Add(this.txtClientName);
            this.gbTicketInformation.Controls.Add(this.lblNameTitle);
            this.gbTicketInformation.Controls.Add(this.cbProblemArea);
            this.gbTicketInformation.Controls.Add(this.cbTicketLevel);
            this.gbTicketInformation.Controls.Add(this.txtDescription);
            this.gbTicketInformation.Controls.Add(this.txtClientID);
            this.gbTicketInformation.Controls.Add(this.lblDescriptionTitle);
            this.gbTicketInformation.Controls.Add(this.lblClientIDTitle);
            this.gbTicketInformation.Controls.Add(this.lblProblemAreaTitle);
            this.gbTicketInformation.Controls.Add(this.txtTicketState);
            this.gbTicketInformation.Controls.Add(this.lblTicketStateTitle);
            this.gbTicketInformation.Controls.Add(this.txtOpenDate);
            this.gbTicketInformation.Controls.Add(this.lblOpenDateTitle);
            this.gbTicketInformation.Controls.Add(this.lblLevelTitle);
            this.gbTicketInformation.Controls.Add(this.txtTicketID);
            this.gbTicketInformation.Controls.Add(this.lblIDTitle);
            this.gbTicketInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.gbTicketInformation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gbTicketInformation.Location = new System.Drawing.Point(173, 184);
            this.gbTicketInformation.Name = "gbTicketInformation";
            this.gbTicketInformation.Size = new System.Drawing.Size(705, 371);
            this.gbTicketInformation.TabIndex = 20;
            this.gbTicketInformation.TabStop = false;
            this.gbTicketInformation.Text = "Ticket Information";
            // 
            // cbProblemArea
            // 
            this.cbProblemArea.FormattingEnabled = true;
            this.cbProblemArea.Items.AddRange(new object[] {
            "Service",
            "Electrician",
            "Installation",
            "Mechanic"});
            this.cbProblemArea.Location = new System.Drawing.Point(405, 85);
            this.cbProblemArea.Name = "cbProblemArea";
            this.cbProblemArea.Size = new System.Drawing.Size(290, 26);
            this.cbProblemArea.TabIndex = 23;
            // 
            // cbTicketLevel
            // 
            this.cbTicketLevel.FormattingEnabled = true;
            this.cbTicketLevel.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cbTicketLevel.Location = new System.Drawing.Point(14, 85);
            this.cbTicketLevel.Name = "cbTicketLevel";
            this.cbTicketLevel.Size = new System.Drawing.Size(290, 26);
            this.cbTicketLevel.TabIndex = 22;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(18, 189);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(677, 100);
            this.txtDescription.TabIndex = 21;
            // 
            // txtClientID
            // 
            this.txtClientID.BackColor = System.Drawing.Color.White;
            this.txtClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientID.Location = new System.Drawing.Point(405, 136);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(290, 25);
            this.txtClientID.TabIndex = 13;
            // 
            // lblDescriptionTitle
            // 
            this.lblDescriptionTitle.AutoSize = true;
            this.lblDescriptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDescriptionTitle.Location = new System.Drawing.Point(15, 168);
            this.lblDescriptionTitle.Name = "lblDescriptionTitle";
            this.lblDescriptionTitle.Size = new System.Drawing.Size(83, 18);
            this.lblDescriptionTitle.TabIndex = 20;
            this.lblDescriptionTitle.Text = "Description";
            // 
            // lblClientIDTitle
            // 
            this.lblClientIDTitle.AutoSize = true;
            this.lblClientIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientIDTitle.Location = new System.Drawing.Point(399, 118);
            this.lblClientIDTitle.Name = "lblClientIDTitle";
            this.lblClientIDTitle.Size = new System.Drawing.Size(62, 18);
            this.lblClientIDTitle.TabIndex = 11;
            this.lblClientIDTitle.Text = "Address";
            // 
            // lblProblemAreaTitle
            // 
            this.lblProblemAreaTitle.AutoSize = true;
            this.lblProblemAreaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemAreaTitle.Location = new System.Drawing.Point(399, 65);
            this.lblProblemAreaTitle.Name = "lblProblemAreaTitle";
            this.lblProblemAreaTitle.Size = new System.Drawing.Size(98, 18);
            this.lblProblemAreaTitle.TabIndex = 10;
            this.lblProblemAreaTitle.Text = "Problem Area";
            // 
            // txtTicketState
            // 
            this.txtTicketState.BackColor = System.Drawing.Color.White;
            this.txtTicketState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTicketState.Location = new System.Drawing.Point(405, 38);
            this.txtTicketState.Name = "txtTicketState";
            this.txtTicketState.Size = new System.Drawing.Size(290, 25);
            this.txtTicketState.TabIndex = 9;
            // 
            // lblTicketStateTitle
            // 
            this.lblTicketStateTitle.AutoSize = true;
            this.lblTicketStateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketStateTitle.Location = new System.Drawing.Point(399, 16);
            this.lblTicketStateTitle.Name = "lblTicketStateTitle";
            this.lblTicketStateTitle.Size = new System.Drawing.Size(42, 18);
            this.lblTicketStateTitle.TabIndex = 8;
            this.lblTicketStateTitle.Text = "State";
            // 
            // txtOpenDate
            // 
            this.txtOpenDate.BackColor = System.Drawing.Color.White;
            this.txtOpenDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpenDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOpenDate.Location = new System.Drawing.Point(14, 136);
            this.txtOpenDate.Name = "txtOpenDate";
            this.txtOpenDate.Size = new System.Drawing.Size(290, 25);
            this.txtOpenDate.TabIndex = 7;
            // 
            // lblOpenDateTitle
            // 
            this.lblOpenDateTitle.AutoSize = true;
            this.lblOpenDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDateTitle.Location = new System.Drawing.Point(15, 118);
            this.lblOpenDateTitle.Name = "lblOpenDateTitle";
            this.lblOpenDateTitle.Size = new System.Drawing.Size(79, 18);
            this.lblOpenDateTitle.TabIndex = 5;
            this.lblOpenDateTitle.Text = "Open Date";
            // 
            // lblLevelTitle
            // 
            this.lblLevelTitle.AutoSize = true;
            this.lblLevelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelTitle.Location = new System.Drawing.Point(15, 65);
            this.lblLevelTitle.Name = "lblLevelTitle";
            this.lblLevelTitle.Size = new System.Drawing.Size(42, 18);
            this.lblLevelTitle.TabIndex = 4;
            this.lblLevelTitle.Text = "Level";
            // 
            // txtTicketID
            // 
            this.txtTicketID.BackColor = System.Drawing.Color.White;
            this.txtTicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTicketID.Location = new System.Drawing.Point(14, 38);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(290, 25);
            this.txtTicketID.TabIndex = 3;
            // 
            // lblIDTitle
            // 
            this.lblIDTitle.AutoSize = true;
            this.lblIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTitle.Location = new System.Drawing.Point(15, 16);
            this.lblIDTitle.Name = "lblIDTitle";
            this.lblIDTitle.Size = new System.Drawing.Size(22, 18);
            this.lblIDTitle.TabIndex = 2;
            this.lblIDTitle.Text = "ID";
            // 
            // txtTickets
            // 
            this.txtTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTickets.Location = new System.Drawing.Point(172, 78);
            this.txtTickets.Multiline = true;
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.ReadOnly = true;
            this.txtTickets.Size = new System.Drawing.Size(706, 100);
            this.txtTickets.TabIndex = 19;
            // 
            // lblTicketTitle
            // 
            this.lblTicketTitle.AutoSize = true;
            this.lblTicketTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTicketTitle.Location = new System.Drawing.Point(169, 57);
            this.lblTicketTitle.Name = "lblTicketTitle";
            this.lblTicketTitle.Size = new System.Drawing.Size(56, 18);
            this.lblTicketTitle.TabIndex = 15;
            this.lblTicketTitle.Text = "Tickets";
            // 
            // lblSpecializationTitle
            // 
            this.lblSpecializationTitle.AutoSize = true;
            this.lblSpecializationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecializationTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSpecializationTitle.Location = new System.Drawing.Point(579, 8);
            this.lblSpecializationTitle.Name = "lblSpecializationTitle";
            this.lblSpecializationTitle.Size = new System.Drawing.Size(99, 18);
            this.lblSpecializationTitle.TabIndex = 13;
            this.lblSpecializationTitle.Text = "Specialization";
            // 
            // lblTechnitionTitle
            // 
            this.lblTechnitionTitle.AutoSize = true;
            this.lblTechnitionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnitionTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTechnitionTitle.Location = new System.Drawing.Point(168, 8);
            this.lblTechnitionTitle.Name = "lblTechnitionTitle";
            this.lblTechnitionTitle.Size = new System.Drawing.Size(76, 18);
            this.lblTechnitionTitle.TabIndex = 12;
            this.lblTechnitionTitle.Text = "Technition";
            // 
            // pnlTicketDisplay
            // 
            this.pnlTicketDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlTicketDisplay.Controls.Add(this.btnStartStop);
            this.pnlTicketDisplay.Controls.Add(this.btnUpdate);
            this.pnlTicketDisplay.Controls.Add(this.lbUnassignedTickets);
            this.pnlTicketDisplay.Controls.Add(this.btnReloadTickets);
            this.pnlTicketDisplay.Controls.Add(this.btnAssignTicket);
            this.pnlTicketDisplay.Controls.Add(this.lblUnassignedTickets);
            this.pnlTicketDisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTicketDisplay.Location = new System.Drawing.Point(0, 0);
            this.pnlTicketDisplay.Name = "pnlTicketDisplay";
            this.pnlTicketDisplay.Size = new System.Drawing.Size(151, 570);
            this.pnlTicketDisplay.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::Group2_SEN381_Project.Properties.Resources.Upload_16;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(9, 467);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 25);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbUnassignedTickets
            // 
            this.lbUnassignedTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbUnassignedTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUnassignedTickets.FormattingEnabled = true;
            this.lbUnassignedTickets.Location = new System.Drawing.Point(9, 57);
            this.lbUnassignedTickets.Name = "lbUnassignedTickets";
            this.lbUnassignedTickets.Size = new System.Drawing.Size(135, 342);
            this.lbUnassignedTickets.TabIndex = 1;
            this.lbUnassignedTickets.SelectedIndexChanged += new System.EventHandler(this.lbUnassignedTickets_SelectedIndexChanged);
            // 
            // btnReloadTickets
            // 
            this.btnReloadTickets.BackColor = System.Drawing.Color.Teal;
            this.btnReloadTickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReloadTickets.FlatAppearance.BorderSize = 0;
            this.btnReloadTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReloadTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadTickets.ForeColor = System.Drawing.Color.White;
            this.btnReloadTickets.Image = global::Group2_SEN381_Project.Properties.Resources.Refresh_White_16;
            this.btnReloadTickets.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnReloadTickets.Location = new System.Drawing.Point(9, 405);
            this.btnReloadTickets.Name = "btnReloadTickets";
            this.btnReloadTickets.Size = new System.Drawing.Size(135, 25);
            this.btnReloadTickets.TabIndex = 23;
            this.btnReloadTickets.Text = "REFRESH";
            this.btnReloadTickets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReloadTickets.UseVisualStyleBackColor = false;
            this.btnReloadTickets.Click += new System.EventHandler(this.btnReloadTickets_Click);
            // 
            // btnAssignTicket
            // 
            this.btnAssignTicket.BackColor = System.Drawing.Color.Teal;
            this.btnAssignTicket.FlatAppearance.BorderSize = 0;
            this.btnAssignTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignTicket.ForeColor = System.Drawing.Color.White;
            this.btnAssignTicket.Image = global::Group2_SEN381_Project.Properties.Resources.Arrow_16;
            this.btnAssignTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAssignTicket.Location = new System.Drawing.Point(9, 436);
            this.btnAssignTicket.Name = "btnAssignTicket";
            this.btnAssignTicket.Size = new System.Drawing.Size(135, 25);
            this.btnAssignTicket.TabIndex = 22;
            this.btnAssignTicket.Text = "ASSIGN";
            this.btnAssignTicket.UseVisualStyleBackColor = false;
            this.btnAssignTicket.Click += new System.EventHandler(this.btnAssignTicket_Click);
            // 
            // lblUnassignedTickets
            // 
            this.lblUnassignedTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUnassignedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnassignedTickets.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUnassignedTickets.Location = new System.Drawing.Point(0, 0);
            this.lblUnassignedTickets.Name = "lblUnassignedTickets";
            this.lblUnassignedTickets.Size = new System.Drawing.Size(151, 58);
            this.lblUnassignedTickets.TabIndex = 0;
            this.lblUnassignedTickets.Text = "Unassigned Tickets";
            this.lblUnassignedTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClientName
            // 
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientName.Location = new System.Drawing.Point(18, 327);
            this.txtClientName.Multiline = true;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.ReadOnly = true;
            this.txtClientName.Size = new System.Drawing.Size(286, 25);
            this.txtClientName.TabIndex = 28;
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNameTitle.Location = new System.Drawing.Point(15, 304);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(89, 18);
            this.lblNameTitle.TabIndex = 27;
            this.lblNameTitle.Text = "Client Name";
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientPhone.Location = new System.Drawing.Point(409, 327);
            this.txtClientPhone.Multiline = true;
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.ReadOnly = true;
            this.txtClientPhone.Size = new System.Drawing.Size(286, 25);
            this.txtClientPhone.TabIndex = 32;
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPhoneTitle.Location = new System.Drawing.Point(410, 306);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(149, 18);
            this.lblPhoneTitle.TabIndex = 31;
            this.lblPhoneTitle.Text = "Client Phone Number";
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(220)))), ((int)(((byte)(76)))));
            this.btnStartStop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartStop.FlatAppearance.BorderSize = 0;
            this.btnStartStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(200)))), ((int)(((byte)(76)))));
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.ForeColor = System.Drawing.Color.White;
            this.btnStartStop.Location = new System.Drawing.Point(0, 501);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(151, 69);
            this.btnStartStop.TabIndex = 26;
            this.btnStartStop.Text = "START CALL";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // TicketManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(924, 594);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketManagementForm";
            this.Text = "TicketManagementForm";
            this.Load += new System.EventHandler(this.TicketManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbTicketInformation.ResumeLayout(false);
            this.gbTicketInformation.PerformLayout();
            this.pnlTicketDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAssignTicket;
        private System.Windows.Forms.Label txtSpecialization;
        private System.Windows.Forms.Label txtClientID;
        private System.Windows.Forms.Label lblClientIDTitle;
        private System.Windows.Forms.Label lblProblemAreaTitle;
        private System.Windows.Forms.Label txtTicketState;
        private System.Windows.Forms.Label lblTicketStateTitle;
        private System.Windows.Forms.Label txtOpenDate;
        private System.Windows.Forms.Label lblOpenDateTitle;
        private System.Windows.Forms.Label lblLevelTitle;
        private System.Windows.Forms.Label txtTicketID;
        private System.Windows.Forms.Label lblIDTitle;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.Label lblTicketTitle;
        private System.Windows.Forms.Label lblSpecializationTitle;
        private System.Windows.Forms.Label lblTechnitionTitle;
        private System.Windows.Forms.Panel pnlTicketDisplay;
        private System.Windows.Forms.ListBox lbUnassignedTickets;
        private System.Windows.Forms.Button btnReloadTickets;
        private System.Windows.Forms.Label lblUnassignedTickets;
        private System.Windows.Forms.ComboBox cbTechnition;
        private System.Windows.Forms.GroupBox gbTicketInformation;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescriptionTitle;
        private System.Windows.Forms.ComboBox cbProblemArea;
        private System.Windows.Forms.ComboBox cbTicketLevel;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.Label lblPhoneTitle;
        private System.Windows.Forms.Button btnStartStop;
    }
}