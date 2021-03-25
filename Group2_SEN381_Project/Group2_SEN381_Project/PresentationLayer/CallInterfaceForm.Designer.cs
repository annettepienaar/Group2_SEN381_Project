
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblClientFound = new System.Windows.Forms.Label();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.lblProblemDesc = new System.Windows.Forms.Label();
            this.lblUrgencyLevel = new System.Windows.Forms.Label();
            this.rtxtProblemDesc = new System.Windows.Forms.RichTextBox();
            this.cboxUrgencyLevel = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDuration);
            this.panel1.Controls.Add(this.lblStartTime);
            this.panel1.Controls.Add(this.btnStartStop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(11, 11);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(120, 49);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start / Stop Call";
            this.btnStartStop.UseVisualStyleBackColor = true;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(23, 87);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(92, 20);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "Start Time";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(30, 136);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(78, 20);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblProblemDesc.Location = new System.Drawing.Point(160, 195);
            this.lblProblemDesc.Name = "lblProblemDesc";
            this.lblProblemDesc.Size = new System.Drawing.Size(170, 20);
            this.lblProblemDesc.TabIndex = 5;
            this.lblProblemDesc.Text = "Problem Description";
            // 
            // lblUrgencyLevel
            // 
            this.lblUrgencyLevel.AutoSize = true;
            this.lblUrgencyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrgencyLevel.Location = new System.Drawing.Point(578, 195);
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
            this.rtxtProblemDesc.Size = new System.Drawing.Size(350, 210);
            this.rtxtProblemDesc.TabIndex = 8;
            this.rtxtProblemDesc.Text = "";
            this.rtxtProblemDesc.TextChanged += new System.EventHandler(this.rtxtProblemDesc_TextChanged);
            // 
            // cboxUrgencyLevel
            // 
            this.cboxUrgencyLevel.FormattingEnabled = true;
            this.cboxUrgencyLevel.Location = new System.Drawing.Point(582, 227);
            this.cboxUrgencyLevel.Name = "cboxUrgencyLevel";
            this.cboxUrgencyLevel.Size = new System.Drawing.Size(121, 21);
            this.cboxUrgencyLevel.TabIndex = 9;
            // 
            // CallInterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblClientFound;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.Label lblProblemDesc;
        private System.Windows.Forms.Label lblUrgencyLevel;
        private System.Windows.Forms.RichTextBox rtxtProblemDesc;
        private System.Windows.Forms.ComboBox cboxUrgencyLevel;
    }
}