
namespace Group2_SEN381_Project.PresentationLayer
{
	partial class ServiceMetricsInterface
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
			this.pnlTicketDisplay = new System.Windows.Forms.Panel();
			this.lbServicePackages = new System.Windows.Forms.ListBox();
			this.lblServicePackagesTitle = new System.Windows.Forms.Label();
			this.btnAddServicePackage = new System.Windows.Forms.Button();
			this.lblPackageNameTitle = new System.Windows.Forms.Label();
			this.lblPackageName = new System.Windows.Forms.Label();
			this.lblReleaseDateTitle = new System.Windows.Forms.Label();
			this.lblDescripionTitle = new System.Windows.Forms.Label();
			this.txtReleaseDate = new System.Windows.Forms.TextBox();
			this.lblCloseDate = new System.Windows.Forms.TextBox();
			this.lblCloseDateTitle = new System.Windows.Forms.Label();
			this.btnUpdatePackage = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lblSubcriberAmountTitle = new System.Windows.Forms.Label();
			this.lblSubcriberAmount = new System.Windows.Forms.Label();
			this.lblperformanceTitle = new System.Windows.Forms.Label();
			this.lblPerformanceAmount = new System.Windows.Forms.Label();
			this.pnlTicketDisplay.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTicketDisplay
			// 
			this.pnlTicketDisplay.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pnlTicketDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlTicketDisplay.Controls.Add(this.btnAddServicePackage);
			this.pnlTicketDisplay.Controls.Add(this.lbServicePackages);
			this.pnlTicketDisplay.Controls.Add(this.lblServicePackagesTitle);
			this.pnlTicketDisplay.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlTicketDisplay.Location = new System.Drawing.Point(0, 0);
			this.pnlTicketDisplay.Name = "pnlTicketDisplay";
			this.pnlTicketDisplay.Size = new System.Drawing.Size(151, 450);
			this.pnlTicketDisplay.TabIndex = 1;
			// 
			// lbServicePackages
			// 
			this.lbServicePackages.FormattingEnabled = true;
			this.lbServicePackages.Location = new System.Drawing.Point(3, 31);
			this.lbServicePackages.Name = "lbServicePackages";
			this.lbServicePackages.Size = new System.Drawing.Size(143, 368);
			this.lbServicePackages.TabIndex = 1;
			// 
			// lblServicePackagesTitle
			// 
			this.lblServicePackagesTitle.AutoSize = true;
			this.lblServicePackagesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblServicePackagesTitle.Location = new System.Drawing.Point(11, 8);
			this.lblServicePackagesTitle.Name = "lblServicePackagesTitle";
			this.lblServicePackagesTitle.Size = new System.Drawing.Size(129, 20);
			this.lblServicePackagesTitle.TabIndex = 0;
			this.lblServicePackagesTitle.Text = "Assigned Tickets";
			// 
			// btnAddServicePackage
			// 
			this.btnAddServicePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddServicePackage.Location = new System.Drawing.Point(11, 405);
			this.btnAddServicePackage.Name = "btnAddServicePackage";
			this.btnAddServicePackage.Size = new System.Drawing.Size(126, 39);
			this.btnAddServicePackage.TabIndex = 2;
			this.btnAddServicePackage.Text = "Add Package";
			this.btnAddServicePackage.UseVisualStyleBackColor = true;
			this.btnAddServicePackage.Click += new System.EventHandler(this.btnAddServicePackage_Click);
			// 
			// lblPackageNameTitle
			// 
			this.lblPackageNameTitle.AutoSize = true;
			this.lblPackageNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPackageNameTitle.Location = new System.Drawing.Point(188, 19);
			this.lblPackageNameTitle.Name = "lblPackageNameTitle";
			this.lblPackageNameTitle.Size = new System.Drawing.Size(131, 20);
			this.lblPackageNameTitle.TabIndex = 2;
			this.lblPackageNameTitle.Text = "Service Package:";
			// 
			// lblPackageName
			// 
			this.lblPackageName.AutoSize = true;
			this.lblPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPackageName.Location = new System.Drawing.Point(325, 19);
			this.lblPackageName.Name = "lblPackageName";
			this.lblPackageName.Size = new System.Drawing.Size(86, 20);
			this.lblPackageName.TabIndex = 3;
			this.lblPackageName.Text = "PACKAGE";
			// 
			// lblReleaseDateTitle
			// 
			this.lblReleaseDateTitle.AutoSize = true;
			this.lblReleaseDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReleaseDateTitle.Location = new System.Drawing.Point(188, 54);
			this.lblReleaseDateTitle.Name = "lblReleaseDateTitle";
			this.lblReleaseDateTitle.Size = new System.Drawing.Size(111, 20);
			this.lblReleaseDateTitle.TabIndex = 4;
			this.lblReleaseDateTitle.Text = "Release Date:";
			// 
			// lblDescripionTitle
			// 
			this.lblDescripionTitle.AutoSize = true;
			this.lblDescripionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescripionTitle.Location = new System.Drawing.Point(189, 175);
			this.lblDescripionTitle.Name = "lblDescripionTitle";
			this.lblDescripionTitle.Size = new System.Drawing.Size(93, 20);
			this.lblDescripionTitle.TabIndex = 5;
			this.lblDescripionTitle.Text = "Description:";
			this.lblDescripionTitle.Click += new System.EventHandler(this.lblDescripionTitle_Click);
			// 
			// txtReleaseDate
			// 
			this.txtReleaseDate.Location = new System.Drawing.Point(329, 54);
			this.txtReleaseDate.Name = "txtReleaseDate";
			this.txtReleaseDate.Size = new System.Drawing.Size(100, 20);
			this.txtReleaseDate.TabIndex = 6;
			// 
			// lblCloseDate
			// 
			this.lblCloseDate.Location = new System.Drawing.Point(329, 89);
			this.lblCloseDate.Name = "lblCloseDate";
			this.lblCloseDate.Size = new System.Drawing.Size(100, 20);
			this.lblCloseDate.TabIndex = 8;
			// 
			// lblCloseDateTitle
			// 
			this.lblCloseDateTitle.AutoSize = true;
			this.lblCloseDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCloseDateTitle.Location = new System.Drawing.Point(189, 89);
			this.lblCloseDateTitle.Name = "lblCloseDateTitle";
			this.lblCloseDateTitle.Size = new System.Drawing.Size(92, 20);
			this.lblCloseDateTitle.TabIndex = 7;
			this.lblCloseDateTitle.Text = "Close Date:";
			// 
			// btnUpdatePackage
			// 
			this.btnUpdatePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdatePackage.Location = new System.Drawing.Point(259, 126);
			this.btnUpdatePackage.Name = "btnUpdatePackage";
			this.btnUpdatePackage.Size = new System.Drawing.Size(101, 31);
			this.btnUpdatePackage.TabIndex = 9;
			this.btnUpdatePackage.Text = "Update";
			this.btnUpdatePackage.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(192, 198);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(578, 130);
			this.textBox1.TabIndex = 10;
			// 
			// lblSubcriberAmountTitle
			// 
			this.lblSubcriberAmountTitle.AutoSize = true;
			this.lblSubcriberAmountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubcriberAmountTitle.Location = new System.Drawing.Point(193, 354);
			this.lblSubcriberAmountTitle.Name = "lblSubcriberAmountTitle";
			this.lblSubcriberAmountTitle.Size = new System.Drawing.Size(167, 20);
			this.lblSubcriberAmountTitle.TabIndex = 11;
			this.lblSubcriberAmountTitle.Text = "Amount of Subcribers:";
			// 
			// lblSubcriberAmount
			// 
			this.lblSubcriberAmount.AutoSize = true;
			this.lblSubcriberAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubcriberAmount.Location = new System.Drawing.Point(392, 354);
			this.lblSubcriberAmount.Name = "lblSubcriberAmount";
			this.lblSubcriberAmount.Size = new System.Drawing.Size(77, 20);
			this.lblSubcriberAmount.TabIndex = 12;
			this.lblSubcriberAmount.Text = "AMOUNT";
			// 
			// lblperformanceTitle
			// 
			this.lblperformanceTitle.AutoSize = true;
			this.lblperformanceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblperformanceTitle.Location = new System.Drawing.Point(195, 396);
			this.lblperformanceTitle.Name = "lblperformanceTitle";
			this.lblperformanceTitle.Size = new System.Drawing.Size(104, 20);
			this.lblperformanceTitle.TabIndex = 13;
			this.lblperformanceTitle.Text = "Performance:";
			// 
			// lblPerformanceAmount
			// 
			this.lblPerformanceAmount.AutoSize = true;
			this.lblPerformanceAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPerformanceAmount.Location = new System.Drawing.Point(392, 396);
			this.lblPerformanceAmount.Name = "lblPerformanceAmount";
			this.lblPerformanceAmount.Size = new System.Drawing.Size(133, 20);
			this.lblPerformanceAmount.TabIndex = 14;
			this.lblPerformanceAmount.Text = "PERFORMANCE";
			// 
			// ServiceMetricsInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblPerformanceAmount);
			this.Controls.Add(this.lblperformanceTitle);
			this.Controls.Add(this.lblSubcriberAmount);
			this.Controls.Add(this.lblSubcriberAmountTitle);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnUpdatePackage);
			this.Controls.Add(this.lblCloseDate);
			this.Controls.Add(this.lblCloseDateTitle);
			this.Controls.Add(this.txtReleaseDate);
			this.Controls.Add(this.lblDescripionTitle);
			this.Controls.Add(this.lblReleaseDateTitle);
			this.Controls.Add(this.lblPackageName);
			this.Controls.Add(this.lblPackageNameTitle);
			this.Controls.Add(this.pnlTicketDisplay);
			this.Name = "ServiceMetricsInterface";
			this.Text = "Service Metrics Interface";
			this.pnlTicketDisplay.ResumeLayout(false);
			this.pnlTicketDisplay.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlTicketDisplay;
		private System.Windows.Forms.ListBox lbServicePackages;
		private System.Windows.Forms.Label lblServicePackagesTitle;
		private System.Windows.Forms.Button btnAddServicePackage;
		private System.Windows.Forms.Label lblPackageNameTitle;
		private System.Windows.Forms.Label lblPackageName;
		private System.Windows.Forms.Label lblReleaseDateTitle;
		private System.Windows.Forms.Label lblDescripionTitle;
		private System.Windows.Forms.TextBox txtReleaseDate;
		private System.Windows.Forms.TextBox lblCloseDate;
		private System.Windows.Forms.Label lblCloseDateTitle;
		private System.Windows.Forms.Button btnUpdatePackage;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lblSubcriberAmountTitle;
		private System.Windows.Forms.Label lblSubcriberAmount;
		private System.Windows.Forms.Label lblperformanceTitle;
		private System.Windows.Forms.Label lblPerformanceAmount;
	}
}