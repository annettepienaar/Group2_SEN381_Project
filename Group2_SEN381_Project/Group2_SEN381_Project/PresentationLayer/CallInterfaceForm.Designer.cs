
namespace Group2_SEN381_Project
{
    partial class CallInterfaceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.lblProblemDesc = new System.Windows.Forms.Label();
            this.lblUrgencyLevel = new System.Windows.Forms.Label();
            this.rtxtProblemDesc = new System.Windows.Forms.RichTextBox();
            this.cboxUrgencyLevel = new System.Windows.Forms.ComboBox();
            this.lblProblemArea = new System.Windows.Forms.Label();
            this.cboxProblemArea = new System.Windows.Forms.ComboBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCallEnd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvAllTickets = new System.Windows.Forms.DataGridView();
            this.dgvAllCalls = new System.Windows.Forms.DataGridView();
            this.pBoxCustomerFound = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCustomerFound)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClientID
            // 
            this.txtClientID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtClientID.Location = new System.Drawing.Point(170, 35);
            this.txtClientID.Multiline = true;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(309, 25);
            this.txtClientID.TabIndex = 1;
            this.txtClientID.WordWrap = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(136)))), ((int)(((byte)(132)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(514, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.FlatAppearance.BorderSize = 0;
            this.btnCreateClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCreateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClient.ForeColor = System.Drawing.Color.Teal;
            this.btnCreateClient.Location = new System.Drawing.Point(389, 66);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(86, 23);
            this.btnCreateClient.TabIndex = 4;
            this.btnCreateClient.Text = "Create Client?";
            this.btnCreateClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // lblProblemDesc
            // 
            this.lblProblemDesc.AutoSize = true;
            this.lblProblemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemDesc.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProblemDesc.Location = new System.Drawing.Point(165, 119);
            this.lblProblemDesc.Name = "lblProblemDesc";
            this.lblProblemDesc.Size = new System.Drawing.Size(143, 18);
            this.lblProblemDesc.TabIndex = 5;
            this.lblProblemDesc.Text = "Problem Description";
            // 
            // lblUrgencyLevel
            // 
            this.lblUrgencyLevel.AutoSize = true;
            this.lblUrgencyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrgencyLevel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUrgencyLevel.Location = new System.Drawing.Point(511, 236);
            this.lblUrgencyLevel.Name = "lblUrgencyLevel";
            this.lblUrgencyLevel.Size = new System.Drawing.Size(101, 18);
            this.lblUrgencyLevel.TabIndex = 6;
            this.lblUrgencyLevel.Text = "Urgency Level";
            // 
            // rtxtProblemDesc
            // 
            this.rtxtProblemDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtProblemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtProblemDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtxtProblemDesc.Location = new System.Drawing.Point(170, 140);
            this.rtxtProblemDesc.MaxLength = 150;
            this.rtxtProblemDesc.Name = "rtxtProblemDesc";
            this.rtxtProblemDesc.Size = new System.Drawing.Size(713, 89);
            this.rtxtProblemDesc.TabIndex = 8;
            this.rtxtProblemDesc.Text = "";
            // 
            // cboxUrgencyLevel
            // 
            this.cboxUrgencyLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxUrgencyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxUrgencyLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboxUrgencyLevel.FormattingEnabled = true;
            this.cboxUrgencyLevel.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cboxUrgencyLevel.Location = new System.Drawing.Point(514, 257);
            this.cboxUrgencyLevel.Name = "cboxUrgencyLevel";
            this.cboxUrgencyLevel.Size = new System.Drawing.Size(340, 26);
            this.cboxUrgencyLevel.TabIndex = 9;
            // 
            // lblProblemArea
            // 
            this.lblProblemArea.AutoSize = true;
            this.lblProblemArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemArea.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblProblemArea.Location = new System.Drawing.Point(167, 236);
            this.lblProblemArea.Name = "lblProblemArea";
            this.lblProblemArea.Size = new System.Drawing.Size(98, 18);
            this.lblProblemArea.TabIndex = 10;
            this.lblProblemArea.Text = "Problem Area";
            // 
            // cboxProblemArea
            // 
            this.cboxProblemArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxProblemArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProblemArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboxProblemArea.FormattingEnabled = true;
            this.cboxProblemArea.Items.AddRange(new object[] {
            "Service",
            "Electrician",
            "Installation",
            "Mechanic"});
            this.cboxProblemArea.Location = new System.Drawing.Point(170, 257);
            this.cboxProblemArea.Name = "cboxProblemArea";
            this.cboxProblemArea.Size = new System.Drawing.Size(281, 26);
            this.cboxProblemArea.TabIndex = 11;
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(220)))), ((int)(((byte)(76)))));
            this.btnStartStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartStop.FlatAppearance.BorderSize = 0;
            this.btnStartStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(200)))), ((int)(((byte)(76)))));
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.ForeColor = System.Drawing.Color.White;
            this.btnStartStop.Location = new System.Drawing.Point(0, 0);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(154, 69);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "START CALL";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lblStartTime
            // 
            this.lblStartTime.BackColor = System.Drawing.Color.White;
            this.lblStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStartTime.Location = new System.Drawing.Point(10, 30);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(112, 20);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.BackColor = System.Drawing.Color.White;
            this.lblDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDuration.Location = new System.Drawing.Point(9, 84);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(113, 20);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnStartStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 570);
            this.panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(136)))), ((int)(((byte)(132)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::Group2_SEN381_Project.Properties.Resources.Refresh_White_16;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnClear.Location = new System.Drawing.Point(12, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 25);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "REFRESH";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblCallEnd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblStartTime);
            this.panel2.Controls.Add(this.lblDuration);
            this.panel2.Location = new System.Drawing.Point(12, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 170);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Call End";
            // 
            // lblCallEnd
            // 
            this.lblCallEnd.BackColor = System.Drawing.Color.White;
            this.lblCallEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCallEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCallEnd.Location = new System.Drawing.Point(9, 136);
            this.lblCallEnd.Name = "lblCallEnd";
            this.lblCallEnd.Size = new System.Drawing.Size(113, 20);
            this.lblCallEnd.TabIndex = 11;
            this.lblCallEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Call Duration";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Call Start";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dgvAllTickets);
            this.panel3.Controls.Add(this.dgvAllCalls);
            this.panel3.Controls.Add(this.pBoxCustomerFound);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblProblemArea);
            this.panel3.Controls.Add(this.cboxProblemArea);
            this.panel3.Controls.Add(this.cboxUrgencyLevel);
            this.panel3.Controls.Add(this.rtxtProblemDesc);
            this.panel3.Controls.Add(this.lblUrgencyLevel);
            this.panel3.Controls.Add(this.lblProblemDesc);
            this.panel3.Controls.Add(this.btnCreateClient);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtClientID);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 570);
            this.panel3.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(167, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ticket Log";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(167, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Call Log";
            // 
            // dgvAllTickets
            // 
            this.dgvAllTickets.AllowUserToAddRows = false;
            this.dgvAllTickets.AllowUserToDeleteRows = false;
            this.dgvAllTickets.AllowUserToResizeColumns = false;
            this.dgvAllTickets.AllowUserToResizeRows = false;
            this.dgvAllTickets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllTickets.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllTickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllTickets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvAllTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllTickets.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvAllTickets.EnableHeadersVisualStyles = false;
            this.dgvAllTickets.GridColor = System.Drawing.Color.White;
            this.dgvAllTickets.Location = new System.Drawing.Point(170, 462);
            this.dgvAllTickets.Name = "dgvAllTickets";
            this.dgvAllTickets.ReadOnly = true;
            this.dgvAllTickets.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllTickets.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvAllTickets.RowTemplate.Height = 25;
            this.dgvAllTickets.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvAllTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllTickets.Size = new System.Drawing.Size(713, 100);
            this.dgvAllTickets.TabIndex = 16;
            // 
            // dgvAllCalls
            // 
            this.dgvAllCalls.AllowUserToAddRows = false;
            this.dgvAllCalls.AllowUserToDeleteRows = false;
            this.dgvAllCalls.AllowUserToResizeColumns = false;
            this.dgvAllCalls.AllowUserToResizeRows = false;
            this.dgvAllCalls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllCalls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllCalls.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllCalls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllCalls.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllCalls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvAllCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllCalls.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvAllCalls.EnableHeadersVisualStyles = false;
            this.dgvAllCalls.GridColor = System.Drawing.Color.White;
            this.dgvAllCalls.Location = new System.Drawing.Point(170, 338);
            this.dgvAllCalls.Name = "dgvAllCalls";
            this.dgvAllCalls.ReadOnly = true;
            this.dgvAllCalls.RowHeadersVisible = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.NullValue = " ";
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllCalls.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvAllCalls.RowTemplate.Height = 25;
            this.dgvAllCalls.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvAllCalls.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllCalls.Size = new System.Drawing.Size(713, 100);
            this.dgvAllCalls.TabIndex = 15;
            this.dgvAllCalls.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllCalls_CellContentClick);
            // 
            // pBoxCustomerFound
            // 
            this.pBoxCustomerFound.BackColor = System.Drawing.Color.White;
            this.pBoxCustomerFound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pBoxCustomerFound.Image = global::Group2_SEN381_Project.Properties.Resources.circle_16;
            this.pBoxCustomerFound.Location = new System.Drawing.Point(478, 35);
            this.pBoxCustomerFound.Name = "pBoxCustomerFound";
            this.pBoxCustomerFound.Size = new System.Drawing.Size(30, 25);
            this.pBoxCustomerFound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBoxCustomerFound.TabIndex = 14;
            this.pBoxCustomerFound.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(167, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Customer Identification Number";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(158, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 552);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CallInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 594);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CallInterfaceForm";
            this.Text = "CallInterfaceForm";
            this.Load += new System.EventHandler(this.CallInterfaceForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CallInterfaceForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCustomerFound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.Label lblProblemDesc;
        private System.Windows.Forms.Label lblUrgencyLevel;
        private System.Windows.Forms.RichTextBox rtxtProblemDesc;
        private System.Windows.Forms.ComboBox cboxUrgencyLevel;
        private System.Windows.Forms.Label lblProblemArea;
        private System.Windows.Forms.ComboBox cboxProblemArea;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCallEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pBoxCustomerFound;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvAllCalls;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvAllTickets;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}