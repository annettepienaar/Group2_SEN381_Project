
namespace Group2_SEN381_Project.PresentationLayer
{
    partial class ClientManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvClientTickets = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServicePackage = new System.Windows.Forms.Label();
            this.cboxClientServicePackage = new System.Windows.Forms.ComboBox();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.txtClientBusinessName = new System.Windows.Forms.TextBox();
            this.txtClientSurname = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAddressTitle = new System.Windows.Forms.Label();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.lblBusinessNameTitle = new System.Windows.Forms.Label();
            this.lblSurnameTitle = new System.Windows.Forms.Label();
            this.pnlTicketDisplay = new System.Windows.Forms.Panel();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.btnReloadTickets = new System.Windows.Forms.Button();
            this.lblAssignedTickets = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.lblIDTitle = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientTickets)).BeginInit();
            this.pnlTicketDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.dgvClientTickets);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblServicePackage);
            this.panel1.Controls.Add(this.cboxClientServicePackage);
            this.panel1.Controls.Add(this.txtClientPhone);
            this.panel1.Controls.Add(this.txtClientAddress);
            this.panel1.Controls.Add(this.txtClientBusinessName);
            this.panel1.Controls.Add(this.txtClientSurname);
            this.panel1.Controls.Add(this.txtClientName);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblAddressTitle);
            this.panel1.Controls.Add(this.lblPhoneTitle);
            this.panel1.Controls.Add(this.lblBusinessNameTitle);
            this.panel1.Controls.Add(this.lblSurnameTitle);
            this.panel1.Controls.Add(this.pnlTicketDisplay);
            this.panel1.Controls.Add(this.lblNameTitle);
            this.panel1.Controls.Add(this.lblIDTitle);
            this.panel1.Controls.Add(this.lblClientID);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 570);
            this.panel1.TabIndex = 25;
            // 
            // dgvClientTickets
            // 
            this.dgvClientTickets.AllowUserToAddRows = false;
            this.dgvClientTickets.AllowUserToDeleteRows = false;
            this.dgvClientTickets.AllowUserToResizeColumns = false;
            this.dgvClientTickets.AllowUserToResizeRows = false;
            this.dgvClientTickets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientTickets.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientTickets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientTickets.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientTickets.EnableHeadersVisualStyles = false;
            this.dgvClientTickets.GridColor = System.Drawing.Color.White;
            this.dgvClientTickets.Location = new System.Drawing.Point(195, 398);
            this.dgvClientTickets.Name = "dgvClientTickets";
            this.dgvClientTickets.ReadOnly = true;
            this.dgvClientTickets.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.NullValue = " ";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientTickets.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClientTickets.RowTemplate.Height = 25;
            this.dgvClientTickets.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvClientTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientTickets.Size = new System.Drawing.Size(685, 162);
            this.dgvClientTickets.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(196, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Submitted Tickets";
            // 
            // lblServicePackage
            // 
            this.lblServicePackage.AutoSize = true;
            this.lblServicePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicePackage.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblServicePackage.Location = new System.Drawing.Point(196, 296);
            this.lblServicePackage.Name = "lblServicePackage";
            this.lblServicePackage.Size = new System.Drawing.Size(175, 18);
            this.lblServicePackage.TabIndex = 32;
            this.lblServicePackage.Text = "Chosen Service Package";
            // 
            // cboxClientServicePackage
            // 
            this.cboxClientServicePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxClientServicePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxClientServicePackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboxClientServicePackage.FormattingEnabled = true;
            this.cboxClientServicePackage.Location = new System.Drawing.Point(195, 317);
            this.cboxClientServicePackage.Name = "cboxClientServicePackage";
            this.cboxClientServicePackage.Size = new System.Drawing.Size(300, 26);
            this.cboxClientServicePackage.TabIndex = 31;
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientPhone.Location = new System.Drawing.Point(195, 219);
            this.txtClientPhone.Multiline = true;
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(300, 25);
            this.txtClientPhone.TabIndex = 30;
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientAddress.Location = new System.Drawing.Point(580, 161);
            this.txtClientAddress.Multiline = true;
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.Size = new System.Drawing.Size(300, 83);
            this.txtClientAddress.TabIndex = 29;
            // 
            // txtClientBusinessName
            // 
            this.txtClientBusinessName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientBusinessName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientBusinessName.Location = new System.Drawing.Point(195, 161);
            this.txtClientBusinessName.Multiline = true;
            this.txtClientBusinessName.Name = "txtClientBusinessName";
            this.txtClientBusinessName.Size = new System.Drawing.Size(300, 25);
            this.txtClientBusinessName.TabIndex = 28;
            // 
            // txtClientSurname
            // 
            this.txtClientSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientSurname.Location = new System.Drawing.Point(580, 83);
            this.txtClientSurname.Multiline = true;
            this.txtClientSurname.Name = "txtClientSurname";
            this.txtClientSurname.Size = new System.Drawing.Size(300, 25);
            this.txtClientSurname.TabIndex = 27;
            // 
            // txtClientName
            // 
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientName.Location = new System.Drawing.Point(195, 83);
            this.txtClientName.Multiline = true;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(300, 25);
            this.txtClientName.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(580, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(300, 25);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "UPDATE CLIENT";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(171, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 562);
            this.label4.TabIndex = 24;
            this.label4.Text = "label4";
            // 
            // lblAddressTitle
            // 
            this.lblAddressTitle.AutoSize = true;
            this.lblAddressTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAddressTitle.Location = new System.Drawing.Point(577, 140);
            this.lblAddressTitle.Name = "lblAddressTitle";
            this.lblAddressTitle.Size = new System.Drawing.Size(62, 18);
            this.lblAddressTitle.TabIndex = 11;
            this.lblAddressTitle.Text = "Address";
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPhoneTitle.Location = new System.Drawing.Point(196, 198);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(51, 18);
            this.lblPhoneTitle.TabIndex = 10;
            this.lblPhoneTitle.Text = "Phone";
            // 
            // lblBusinessNameTitle
            // 
            this.lblBusinessNameTitle.AutoSize = true;
            this.lblBusinessNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessNameTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBusinessNameTitle.Location = new System.Drawing.Point(196, 140);
            this.lblBusinessNameTitle.Name = "lblBusinessNameTitle";
            this.lblBusinessNameTitle.Size = new System.Drawing.Size(113, 18);
            this.lblBusinessNameTitle.TabIndex = 8;
            this.lblBusinessNameTitle.Text = "Business Name";
            // 
            // lblSurnameTitle
            // 
            this.lblSurnameTitle.AutoSize = true;
            this.lblSurnameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSurnameTitle.Location = new System.Drawing.Point(578, 60);
            this.lblSurnameTitle.Name = "lblSurnameTitle";
            this.lblSurnameTitle.Size = new System.Drawing.Size(68, 18);
            this.lblSurnameTitle.TabIndex = 5;
            this.lblSurnameTitle.Text = "Surname";
            // 
            // pnlTicketDisplay
            // 
            this.pnlTicketDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlTicketDisplay.Controls.Add(this.lbClients);
            this.pnlTicketDisplay.Controls.Add(this.btnReloadTickets);
            this.pnlTicketDisplay.Controls.Add(this.lblAssignedTickets);
            this.pnlTicketDisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTicketDisplay.Location = new System.Drawing.Point(0, 0);
            this.pnlTicketDisplay.Name = "pnlTicketDisplay";
            this.pnlTicketDisplay.Size = new System.Drawing.Size(165, 570);
            this.pnlTicketDisplay.TabIndex = 11;
            // 
            // lbClients
            // 
            this.lbClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbClients.FormattingEnabled = true;
            this.lbClients.Location = new System.Drawing.Point(9, 57);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(153, 472);
            this.lbClients.TabIndex = 1;
            this.lbClients.SelectedIndexChanged += new System.EventHandler(this.lbClients_SelectedIndexChanged);
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
            this.btnReloadTickets.Location = new System.Drawing.Point(9, 535);
            this.btnReloadTickets.Name = "btnReloadTickets";
            this.btnReloadTickets.Size = new System.Drawing.Size(153, 25);
            this.btnReloadTickets.TabIndex = 23;
            this.btnReloadTickets.Text = "REFRESH";
            this.btnReloadTickets.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReloadTickets.UseVisualStyleBackColor = false;
            this.btnReloadTickets.Click += new System.EventHandler(this.btnReloadTickets_Click);
            // 
            // lblAssignedTickets
            // 
            this.lblAssignedTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAssignedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedTickets.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAssignedTickets.Location = new System.Drawing.Point(0, 0);
            this.lblAssignedTickets.Name = "lblAssignedTickets";
            this.lblAssignedTickets.Size = new System.Drawing.Size(165, 58);
            this.lblAssignedTickets.TabIndex = 0;
            this.lblAssignedTickets.Text = "Client";
            this.lblAssignedTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNameTitle.Location = new System.Drawing.Point(196, 60);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(48, 18);
            this.lblNameTitle.TabIndex = 4;
            this.lblNameTitle.Text = "Name";
            // 
            // lblIDTitle
            // 
            this.lblIDTitle.AutoSize = true;
            this.lblIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIDTitle.Location = new System.Drawing.Point(196, 11);
            this.lblIDTitle.Name = "lblIDTitle";
            this.lblIDTitle.Size = new System.Drawing.Size(22, 18);
            this.lblIDTitle.TabIndex = 2;
            this.lblIDTitle.Text = "ID";
            // 
            // lblClientID
            // 
            this.lblClientID.BackColor = System.Drawing.Color.White;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClientID.Location = new System.Drawing.Point(195, 33);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(300, 25);
            this.lblClientID.TabIndex = 3;
            // 
            // ClientManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(924, 594);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientManagementForm";
            this.Text = "ClientManagementForm";
            this.Load += new System.EventHandler(this.ClientManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientTickets)).EndInit();
            this.pnlTicketDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAddressTitle;
        private System.Windows.Forms.Label lblPhoneTitle;
        private System.Windows.Forms.Label lblBusinessNameTitle;
        private System.Windows.Forms.Label lblSurnameTitle;
        private System.Windows.Forms.Label lblNameTitle;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblIDTitle;
        private System.Windows.Forms.Panel pnlTicketDisplay;
        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.Button btnReloadTickets;
        private System.Windows.Forms.Label lblAssignedTickets;
        private System.Windows.Forms.Label lblServicePackage;
        private System.Windows.Forms.ComboBox cboxClientServicePackage;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.TextBox txtClientAddress;
        private System.Windows.Forms.TextBox txtClientBusinessName;
        private System.Windows.Forms.TextBox txtClientSurname;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientTickets;
    }
}