
namespace Group2_SEN381_Project.PresentationLayer
{
	partial class CreateServicePackageForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateServicePackageForm));
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblCloseDate = new System.Windows.Forms.Label();
			this.lblReleaseDate = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblHeading = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtEpSerial = new System.Windows.Forms.TextBox();
			this.lblEpSerial = new System.Windows.Forms.Label();
			this.txtEpModel = new System.Windows.Forms.TextBox();
			this.lblEpModel = new System.Windows.Forms.Label();
			this.txtEpName = new System.Windows.Forms.TextBox();
			this.lblEpName = new System.Windows.Forms.Label();
			this.cbPriority = new System.Windows.Forms.ComboBox();
			this.lblPriority = new System.Windows.Forms.Label();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.lblType = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.pnlMenuBar = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dpReleaseDate = new System.Windows.Forms.DateTimePicker();
			this.dpCloseDate = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			this.pnlMenuBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.Teal;
			this.btnCreate.FlatAppearance.BorderSize = 0;
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.ForeColor = System.Drawing.Color.White;
			this.btnCreate.Location = new System.Drawing.Point(173, 340);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(223, 35);
			this.btnCreate.TabIndex = 35;
			this.btnCreate.Text = "SUBMIT";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
			// 
			// txtName
			// 
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(34, 120);
			this.txtName.Multiline = true;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(223, 25);
			this.txtName.TabIndex = 31;
			this.txtName.WordWrap = false;
			// 
			// lblCloseDate
			// 
			this.lblCloseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCloseDate.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblCloseDate.Location = new System.Drawing.Point(316, 250);
			this.lblCloseDate.Name = "lblCloseDate";
			this.lblCloseDate.Size = new System.Drawing.Size(92, 20);
			this.lblCloseDate.TabIndex = 29;
			this.lblCloseDate.Text = "Close Date";
			// 
			// lblReleaseDate
			// 
			this.lblReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReleaseDate.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblReleaseDate.Location = new System.Drawing.Point(31, 250);
			this.lblReleaseDate.Name = "lblReleaseDate";
			this.lblReleaseDate.Size = new System.Drawing.Size(111, 20);
			this.lblReleaseDate.TabIndex = 28;
			this.lblReleaseDate.Text = "Release Date";
			// 
			// lblName
			// 
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblName.Location = new System.Drawing.Point(31, 97);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(168, 20);
			this.lblName.TabIndex = 27;
			this.lblName.Text = "Service Package Name";
			// 
			// lblHeading
			// 
			this.lblHeading.BackColor = System.Drawing.Color.White;
			this.lblHeading.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeading.Location = new System.Drawing.Point(0, 0);
			this.lblHeading.Name = "lblHeading";
			this.lblHeading.Size = new System.Drawing.Size(574, 84);
			this.lblHeading.TabIndex = 26;
			this.lblHeading.Text = "Create Service Package";
			this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel1.Controls.Add(this.dpCloseDate);
			this.panel1.Controls.Add(this.dpReleaseDate);
			this.panel1.Controls.Add(this.txtEpSerial);
			this.panel1.Controls.Add(this.lblEpSerial);
			this.panel1.Controls.Add(this.txtEpModel);
			this.panel1.Controls.Add(this.lblEpModel);
			this.panel1.Controls.Add(this.txtEpName);
			this.panel1.Controls.Add(this.lblEpName);
			this.panel1.Controls.Add(this.cbPriority);
			this.panel1.Controls.Add(this.lblPriority);
			this.panel1.Controls.Add(this.cbType);
			this.panel1.Controls.Add(this.lblType);
			this.panel1.Controls.Add(this.btnCreate);
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Controls.Add(this.lblCloseDate);
			this.panel1.Controls.Add(this.lblReleaseDate);
			this.panel1.Controls.Add(this.lblName);
			this.panel1.Controls.Add(this.lblHeading);
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(12, 47);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(574, 402);
			this.panel1.TabIndex = 36;
			// 
			// txtEpSerial
			// 
			this.txtEpSerial.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEpSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEpSerial.Location = new System.Drawing.Point(319, 222);
			this.txtEpSerial.Multiline = true;
			this.txtEpSerial.Name = "txtEpSerial";
			this.txtEpSerial.Size = new System.Drawing.Size(223, 25);
			this.txtEpSerial.TabIndex = 46;
			this.txtEpSerial.WordWrap = false;
			// 
			// lblEpSerial
			// 
			this.lblEpSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEpSerial.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEpSerial.Location = new System.Drawing.Point(316, 199);
			this.lblEpSerial.Name = "lblEpSerial";
			this.lblEpSerial.Size = new System.Drawing.Size(183, 20);
			this.lblEpSerial.TabIndex = 45;
			this.lblEpSerial.Text = "Equipment Serial Number";
			// 
			// txtEpModel
			// 
			this.txtEpModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEpModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEpModel.Location = new System.Drawing.Point(319, 171);
			this.txtEpModel.Multiline = true;
			this.txtEpModel.Name = "txtEpModel";
			this.txtEpModel.Size = new System.Drawing.Size(223, 25);
			this.txtEpModel.TabIndex = 44;
			this.txtEpModel.WordWrap = false;
			// 
			// lblEpModel
			// 
			this.lblEpModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEpModel.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEpModel.Location = new System.Drawing.Point(316, 148);
			this.lblEpModel.Name = "lblEpModel";
			this.lblEpModel.Size = new System.Drawing.Size(168, 20);
			this.lblEpModel.TabIndex = 43;
			this.lblEpModel.Text = "Equipment Model";
			// 
			// txtEpName
			// 
			this.txtEpName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEpName.Location = new System.Drawing.Point(319, 120);
			this.txtEpName.Multiline = true;
			this.txtEpName.Name = "txtEpName";
			this.txtEpName.Size = new System.Drawing.Size(223, 25);
			this.txtEpName.TabIndex = 42;
			this.txtEpName.WordWrap = false;
			// 
			// lblEpName
			// 
			this.lblEpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEpName.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEpName.Location = new System.Drawing.Point(316, 97);
			this.lblEpName.Name = "lblEpName";
			this.lblEpName.Size = new System.Drawing.Size(168, 20);
			this.lblEpName.TabIndex = 41;
			this.lblEpName.Text = "Equipment Name";
			// 
			// cbPriority
			// 
			this.cbPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPriority.FormattingEnabled = true;
			this.cbPriority.Items.AddRange(new object[] {
            "Copper",
            "Silver",
            "Gold",
            "Platinum"});
			this.cbPriority.Location = new System.Drawing.Point(34, 222);
			this.cbPriority.Name = "cbPriority";
			this.cbPriority.Size = new System.Drawing.Size(223, 26);
			this.cbPriority.TabIndex = 40;
			// 
			// lblPriority
			// 
			this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPriority.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblPriority.Location = new System.Drawing.Point(31, 199);
			this.lblPriority.Name = "lblPriority";
			this.lblPriority.Size = new System.Drawing.Size(183, 20);
			this.lblPriority.TabIndex = 39;
			this.lblPriority.Text = "Service Package Priority";
			// 
			// cbType
			// 
			this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbType.FormattingEnabled = true;
			this.cbType.Items.AddRange(new object[] {
            "Warrenty",
            "Annual Servicing",
            "Bulk Buy"});
			this.cbType.Location = new System.Drawing.Point(34, 171);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(223, 26);
			this.cbType.TabIndex = 38;
			// 
			// lblType
			// 
			this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblType.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblType.Location = new System.Drawing.Point(31, 148);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(168, 20);
			this.lblType.TabIndex = 36;
			this.lblType.Text = "Service Package Type";
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.White;
			this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
			this.btnExit.Location = new System.Drawing.Point(565, 0);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(40, 35);
			this.btnExit.TabIndex = 18;
			this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// pnlMenuBar
			// 
			this.pnlMenuBar.BackColor = System.Drawing.Color.White;
			this.pnlMenuBar.Controls.Add(this.pictureBox1);
			this.pnlMenuBar.Controls.Add(this.btnExit);
			this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlMenuBar.Location = new System.Drawing.Point(0, 0);
			this.pnlMenuBar.Name = "pnlMenuBar";
			this.pnlMenuBar.Size = new System.Drawing.Size(605, 35);
			this.pnlMenuBar.TabIndex = 37;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(134, 35);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// dpReleaseDate
			// 
			this.dpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dpReleaseDate.Location = new System.Drawing.Point(34, 273);
			this.dpReleaseDate.Name = "dpReleaseDate";
			this.dpReleaseDate.Size = new System.Drawing.Size(133, 24);
			this.dpReleaseDate.TabIndex = 47;
			// 
			// dpCloseDate
			// 
			this.dpCloseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dpCloseDate.Location = new System.Drawing.Point(319, 273);
			this.dpCloseDate.Name = "dpCloseDate";
			this.dpCloseDate.Size = new System.Drawing.Size(133, 24);
			this.dpCloseDate.TabIndex = 48;
			// 
			// CreateServicePackageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(605, 460);
			this.Controls.Add(this.pnlMenuBar);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CreateServicePackageForm";
			this.Text = "CreateServicePackageForm";
			this.Load += new System.EventHandler(this.CreateServicePackageForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnlMenuBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblCloseDate;
		private System.Windows.Forms.Label lblReleaseDate;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox cbPriority;
		private System.Windows.Forms.Label lblPriority;
		private System.Windows.Forms.ComboBox cbType;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.TextBox txtEpSerial;
		private System.Windows.Forms.Label lblEpSerial;
		private System.Windows.Forms.TextBox txtEpModel;
		private System.Windows.Forms.Label lblEpModel;
		private System.Windows.Forms.TextBox txtEpName;
		private System.Windows.Forms.Label lblEpName;
		private System.Windows.Forms.DateTimePicker dpReleaseDate;
		private System.Windows.Forms.DateTimePicker dpCloseDate;
	}
}