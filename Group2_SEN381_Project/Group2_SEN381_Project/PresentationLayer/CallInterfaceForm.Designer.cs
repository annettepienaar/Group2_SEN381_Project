
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
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblClientFound = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(164, 24);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(155, 20);
            this.txtClientID.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(329, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblClientFound
            // 
            this.lblClientFound.AutoSize = true;
            this.lblClientFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientFound.Location = new System.Drawing.Point(175, 77);
            this.lblClientFound.Name = "lblClientFound";
            this.lblClientFound.Size = new System.Drawing.Size(213, 20);
            this.lblClientFound.TabIndex = 3;
            this.lblClientFound.Text = "Message if client is found";
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClient.Location = new System.Drawing.Point(164, 123);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(240, 34);
            this.btnCreateClient.TabIndex = 4;
            this.btnCreateClient.Text = "Create Client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            // 
            // lblProblemDesc
            // 
            this.lblProblemDesc.AutoSize = true;
            this.lblProblemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemDesc.Location = new System.Drawing.Point(160, 201);
            this.lblProblemDesc.Name = "lblProblemDesc";
            this.lblProblemDesc.Size = new System.Drawing.Size(170, 20);
            this.lblProblemDesc.TabIndex = 5;
            this.lblProblemDesc.Text = "Problem Description";
            // 
            // lblUrgencyLevel
            // 
            this.lblUrgencyLevel.AutoSize = true;
            this.lblUrgencyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrgencyLevel.Location = new System.Drawing.Point(508, 201);
            this.lblUrgencyLevel.Name = "lblUrgencyLevel";
            this.lblUrgencyLevel.Size = new System.Drawing.Size(122, 20);
            this.lblUrgencyLevel.TabIndex = 6;
            this.lblUrgencyLevel.Text = "Urgency Level";
            // 
            // rtxtProblemDesc
            // 
            this.rtxtProblemDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtProblemDesc.Location = new System.Drawing.Point(164, 228);
            this.rtxtProblemDesc.Name = "rtxtProblemDesc";
            this.rtxtProblemDesc.Size = new System.Drawing.Size(613, 167);
            this.rtxtProblemDesc.TabIndex = 8;
            this.rtxtProblemDesc.Text = "";
            this.rtxtProblemDesc.TextChanged += new System.EventHandler(this.rtxtProblemDesc_TextChanged);
            // 
            // cboxUrgencyLevel
            // 
            this.cboxUrgencyLevel.FormattingEnabled = true;
            this.cboxUrgencyLevel.Location = new System.Drawing.Point(636, 203);
            this.cboxUrgencyLevel.Name = "cboxUrgencyLevel";
            this.cboxUrgencyLevel.Size = new System.Drawing.Size(141, 21);
            this.cboxUrgencyLevel.TabIndex = 9;
            // 
            // lblProblemArea
            // 
            this.lblProblemArea.AutoSize = true;
            this.lblProblemArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemArea.Location = new System.Drawing.Point(160, 411);
            this.lblProblemArea.Name = "lblProblemArea";
            this.lblProblemArea.Size = new System.Drawing.Size(117, 20);
            this.lblProblemArea.TabIndex = 10;
            this.lblProblemArea.Text = "Problem Area";
            // 
            // cboxProblemArea
            // 
            this.cboxProblemArea.FormattingEnabled = true;
            this.cboxProblemArea.Location = new System.Drawing.Point(283, 410);
            this.cboxProblemArea.Name = "cboxProblemArea";
            this.cboxProblemArea.Size = new System.Drawing.Size(141, 21);
            this.cboxProblemArea.TabIndex = 11;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(0, 0);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(154, 69);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start / Stop Call";
            this.btnStartStop.UseVisualStyleBackColor = true;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.BackColor = System.Drawing.Color.White;
            this.lblStartTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStartTime.Location = new System.Drawing.Point(20, 33);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(76, 18);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "Start Time";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(19, 75);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(78, 20);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnStartStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 555);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblStartTime);
            this.panel2.Controls.Add(this.lblDuration);
            this.panel2.Location = new System.Drawing.Point(14, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 170);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Start Time";
            // 
            // CallInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(908, 555);
            this.Controls.Add(this.cboxProblemArea);
            this.Controls.Add(this.lblProblemArea);
            this.Controls.Add(this.cboxUrgencyLevel);
            this.Controls.Add(this.rtxtProblemDesc);
            this.Controls.Add(this.lblUrgencyLevel);
            this.Controls.Add(this.lblProblemDesc);
            this.Controls.Add(this.btnCreateClient);
            this.Controls.Add(this.lblClientFound);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.panel1);
            this.Name = "CallInterfaceForm";
            this.Text = "CallInterfaceForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblClientFound;
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
    }
}