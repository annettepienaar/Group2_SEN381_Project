
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAssignTicket = new System.Windows.Forms.Button();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblProblemArea = new System.Windows.Forms.Label();
            this.lblClientIDTitle = new System.Windows.Forms.Label();
            this.lblProblemAreaTitle = new System.Windows.Forms.Label();
            this.lblTicketState = new System.Windows.Forms.Label();
            this.lblTicketStateTitle = new System.Windows.Forms.Label();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblOpenDateTitle = new System.Windows.Forms.Label();
            this.lblLevelTitle = new System.Windows.Forms.Label();
            this.lblTicketID = new System.Windows.Forms.Label();
            this.lblIDTitle = new System.Windows.Forms.Label();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.lblTicketTitle = new System.Windows.Forms.Label();
            this.lblSpecializationTitle = new System.Windows.Forms.Label();
            this.lblTechnitionTitle = new System.Windows.Forms.Label();
            this.pnlTicketDisplay = new System.Windows.Forms.Panel();
            this.lbUnassignedTickets = new System.Windows.Forms.ListBox();
            this.lblUnassignedTickets = new System.Windows.Forms.Label();
            this.btnReloadTickets = new System.Windows.Forms.Button();
            this.cbTechnition = new System.Windows.Forms.ComboBox();
            this.gbClientDetails = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescriptionTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlTicketDisplay.SuspendLayout();
            this.gbClientDetails.SuspendLayout();
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
            this.panel1.Controls.Add(this.lblSpecialization);
            this.panel1.Controls.Add(this.gbClientDetails);
            this.panel1.Controls.Add(this.txtTickets);
            this.panel1.Controls.Add(this.lblTicketTitle);
            this.panel1.Controls.Add(this.lblSpecializationTitle);
            this.panel1.Controls.Add(this.lblTechnitionTitle);
            this.panel1.Controls.Add(this.pnlTicketDisplay);
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 531);
            this.panel1.TabIndex = 25;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(9, 497);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 25);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(155, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 523);
            this.label4.TabIndex = 24;
            this.label4.Text = "label4";
            // 
            // btnAssignTicket
            // 
            this.btnAssignTicket.BackColor = System.Drawing.Color.Teal;
            this.btnAssignTicket.FlatAppearance.BorderSize = 0;
            this.btnAssignTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignTicket.ForeColor = System.Drawing.Color.White;
            this.btnAssignTicket.Location = new System.Drawing.Point(9, 466);
            this.btnAssignTicket.Name = "btnAssignTicket";
            this.btnAssignTicket.Size = new System.Drawing.Size(135, 25);
            this.btnAssignTicket.TabIndex = 22;
            this.btnAssignTicket.Text = "ASSIGN";
            this.btnAssignTicket.UseVisualStyleBackColor = false;
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.BackColor = System.Drawing.Color.White;
            this.lblSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSpecialization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSpecialization.Location = new System.Drawing.Point(552, 31);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(300, 25);
            this.lblSpecialization.TabIndex = 21;
            // 
            // lblClientID
            // 
            this.lblClientID.BackColor = System.Drawing.Color.White;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientID.Location = new System.Drawing.Point(378, 136);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(290, 25);
            this.lblClientID.TabIndex = 13;
            // 
            // lblProblemArea
            // 
            this.lblProblemArea.BackColor = System.Drawing.Color.White;
            this.lblProblemArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProblemArea.Location = new System.Drawing.Point(378, 87);
            this.lblProblemArea.Name = "lblProblemArea";
            this.lblProblemArea.Size = new System.Drawing.Size(290, 25);
            this.lblProblemArea.TabIndex = 12;
            // 
            // lblClientIDTitle
            // 
            this.lblClientIDTitle.AutoSize = true;
            this.lblClientIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientIDTitle.Location = new System.Drawing.Point(379, 118);
            this.lblClientIDTitle.Name = "lblClientIDTitle";
            this.lblClientIDTitle.Size = new System.Drawing.Size(62, 18);
            this.lblClientIDTitle.TabIndex = 11;
            this.lblClientIDTitle.Text = "Address";
            // 
            // lblProblemAreaTitle
            // 
            this.lblProblemAreaTitle.AutoSize = true;
            this.lblProblemAreaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemAreaTitle.Location = new System.Drawing.Point(379, 65);
            this.lblProblemAreaTitle.Name = "lblProblemAreaTitle";
            this.lblProblemAreaTitle.Size = new System.Drawing.Size(98, 18);
            this.lblProblemAreaTitle.TabIndex = 10;
            this.lblProblemAreaTitle.Text = "Problem Area";
            // 
            // lblTicketState
            // 
            this.lblTicketState.BackColor = System.Drawing.Color.White;
            this.lblTicketState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTicketState.Location = new System.Drawing.Point(378, 38);
            this.lblTicketState.Name = "lblTicketState";
            this.lblTicketState.Size = new System.Drawing.Size(290, 25);
            this.lblTicketState.TabIndex = 9;
            // 
            // lblTicketStateTitle
            // 
            this.lblTicketStateTitle.AutoSize = true;
            this.lblTicketStateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketStateTitle.Location = new System.Drawing.Point(379, 16);
            this.lblTicketStateTitle.Name = "lblTicketStateTitle";
            this.lblTicketStateTitle.Size = new System.Drawing.Size(42, 18);
            this.lblTicketStateTitle.TabIndex = 8;
            this.lblTicketStateTitle.Text = "State";
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.BackColor = System.Drawing.Color.White;
            this.lblOpenDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOpenDate.Location = new System.Drawing.Point(14, 136);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(290, 25);
            this.lblOpenDate.TabIndex = 7;
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.Color.White;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLevel.Location = new System.Drawing.Point(14, 87);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(290, 25);
            this.lblLevel.TabIndex = 6;
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
            // lblTicketID
            // 
            this.lblTicketID.BackColor = System.Drawing.Color.White;
            this.lblTicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTicketID.Location = new System.Drawing.Point(14, 38);
            this.lblTicketID.Name = "lblTicketID";
            this.lblTicketID.Size = new System.Drawing.Size(290, 25);
            this.lblTicketID.TabIndex = 3;
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
            this.txtTickets.Size = new System.Drawing.Size(682, 143);
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
            this.lblSpecializationTitle.Location = new System.Drawing.Point(553, 8);
            this.lblSpecializationTitle.Name = "lblSpecializationTitle";
            this.lblSpecializationTitle.Size = new System.Drawing.Size(50, 18);
            this.lblSpecializationTitle.TabIndex = 13;
            this.lblSpecializationTitle.Text = "Status";
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
            this.pnlTicketDisplay.Controls.Add(this.btnUpdate);
            this.pnlTicketDisplay.Controls.Add(this.lbUnassignedTickets);
            this.pnlTicketDisplay.Controls.Add(this.btnReloadTickets);
            this.pnlTicketDisplay.Controls.Add(this.btnAssignTicket);
            this.pnlTicketDisplay.Controls.Add(this.lblUnassignedTickets);
            this.pnlTicketDisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTicketDisplay.Location = new System.Drawing.Point(0, 0);
            this.pnlTicketDisplay.Name = "pnlTicketDisplay";
            this.pnlTicketDisplay.Size = new System.Drawing.Size(151, 531);
            this.pnlTicketDisplay.TabIndex = 11;
            // 
            // lbUnassignedTickets
            // 
            this.lbUnassignedTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbUnassignedTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUnassignedTickets.FormattingEnabled = true;
            this.lbUnassignedTickets.Location = new System.Drawing.Point(9, 57);
            this.lbUnassignedTickets.Name = "lbUnassignedTickets";
            this.lbUnassignedTickets.Size = new System.Drawing.Size(135, 368);
            this.lbUnassignedTickets.TabIndex = 1;
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
            this.btnReloadTickets.Location = new System.Drawing.Point(9, 435);
            this.btnReloadTickets.Name = "btnReloadTickets";
            this.btnReloadTickets.Size = new System.Drawing.Size(135, 25);
            this.btnReloadTickets.TabIndex = 23;
            this.btnReloadTickets.Text = "REFRESH";
            this.btnReloadTickets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReloadTickets.UseVisualStyleBackColor = false;
            // 
            // cbTechnition
            // 
            this.cbTechnition.FormattingEnabled = true;
            this.cbTechnition.Location = new System.Drawing.Point(171, 31);
            this.cbTechnition.Name = "cbTechnition";
            this.cbTechnition.Size = new System.Drawing.Size(300, 21);
            this.cbTechnition.TabIndex = 25;
            this.cbTechnition.Text = "id, name and surname";
            // 
            // gbClientDetails
            // 
            this.gbClientDetails.Controls.Add(this.txtDescription);
            this.gbClientDetails.Controls.Add(this.lblClientID);
            this.gbClientDetails.Controls.Add(this.lblProblemArea);
            this.gbClientDetails.Controls.Add(this.lblDescriptionTitle);
            this.gbClientDetails.Controls.Add(this.lblClientIDTitle);
            this.gbClientDetails.Controls.Add(this.lblProblemAreaTitle);
            this.gbClientDetails.Controls.Add(this.lblTicketState);
            this.gbClientDetails.Controls.Add(this.lblTicketStateTitle);
            this.gbClientDetails.Controls.Add(this.lblOpenDate);
            this.gbClientDetails.Controls.Add(this.lblLevel);
            this.gbClientDetails.Controls.Add(this.lblOpenDateTitle);
            this.gbClientDetails.Controls.Add(this.lblLevelTitle);
            this.gbClientDetails.Controls.Add(this.lblTicketID);
            this.gbClientDetails.Controls.Add(this.lblIDTitle);
            this.gbClientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.gbClientDetails.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gbClientDetails.Location = new System.Drawing.Point(173, 227);
            this.gbClientDetails.Name = "gbClientDetails";
            this.gbClientDetails.Size = new System.Drawing.Size(681, 295);
            this.gbClientDetails.TabIndex = 20;
            this.gbClientDetails.TabStop = false;
            this.gbClientDetails.Text = "Ticket Information";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(18, 189);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(654, 100);
            this.txtDescription.TabIndex = 21;
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
            // TicketManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(908, 555);
            this.Controls.Add(this.panel1);
            this.Name = "TicketManagementForm";
            this.Text = "TicketManagementForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTicketDisplay.ResumeLayout(false);
            this.gbClientDetails.ResumeLayout(false);
            this.gbClientDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAssignTicket;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblProblemArea;
        private System.Windows.Forms.Label lblClientIDTitle;
        private System.Windows.Forms.Label lblProblemAreaTitle;
        private System.Windows.Forms.Label lblTicketState;
        private System.Windows.Forms.Label lblTicketStateTitle;
        private System.Windows.Forms.Label lblOpenDate;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblOpenDateTitle;
        private System.Windows.Forms.Label lblLevelTitle;
        private System.Windows.Forms.Label lblTicketID;
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
        private System.Windows.Forms.GroupBox gbClientDetails;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescriptionTitle;
    }
}