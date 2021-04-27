﻿
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
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtCloseDate = new System.Windows.Forms.TextBox();
			this.txtReleaseDate = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblCloseDate = new System.Windows.Forms.Label();
			this.lblReleaseDate = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblHeading = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(130, 490);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(136, 27);
			this.btnCreate.TabIndex = 35;
			this.btnCreate.Text = "Create Service Package";
			this.btnCreate.UseVisualStyleBackColor = true;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(51, 277);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(313, 193);
			this.txtDescription.TabIndex = 34;
			// 
			// txtCloseDate
			// 
			this.txtCloseDate.Location = new System.Drawing.Point(236, 191);
			this.txtCloseDate.Name = "txtCloseDate";
			this.txtCloseDate.Size = new System.Drawing.Size(128, 20);
			this.txtCloseDate.TabIndex = 33;
			// 
			// txtReleaseDate
			// 
			this.txtReleaseDate.Location = new System.Drawing.Point(236, 147);
			this.txtReleaseDate.Name = "txtReleaseDate";
			this.txtReleaseDate.Size = new System.Drawing.Size(128, 20);
			this.txtReleaseDate.TabIndex = 32;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(236, 103);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(128, 20);
			this.txtName.TabIndex = 31;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescription.Location = new System.Drawing.Point(47, 235);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(93, 20);
			this.lblDescription.TabIndex = 30;
			this.lblDescription.Text = "Description:";
			// 
			// lblCloseDate
			// 
			this.lblCloseDate.AutoSize = true;
			this.lblCloseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCloseDate.Location = new System.Drawing.Point(47, 191);
			this.lblCloseDate.Name = "lblCloseDate";
			this.lblCloseDate.Size = new System.Drawing.Size(92, 20);
			this.lblCloseDate.TabIndex = 29;
			this.lblCloseDate.Text = "Close Date:";
			// 
			// lblReleaseDate
			// 
			this.lblReleaseDate.AutoSize = true;
			this.lblReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReleaseDate.Location = new System.Drawing.Point(47, 145);
			this.lblReleaseDate.Name = "lblReleaseDate";
			this.lblReleaseDate.Size = new System.Drawing.Size(111, 20);
			this.lblReleaseDate.TabIndex = 28;
			this.lblReleaseDate.Text = "Release Date:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(47, 103);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(80, 20);
			this.lblName.TabIndex = 27;
			this.lblName.Text = "SP Name:";
			// 
			// lblHeading
			// 
			this.lblHeading.AutoSize = true;
			this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeading.Location = new System.Drawing.Point(12, 9);
			this.lblHeading.Name = "lblHeading";
			this.lblHeading.Size = new System.Drawing.Size(380, 37);
			this.lblHeading.TabIndex = 26;
			this.lblHeading.Text = "Create Service Package";
			// 
			// CreateServicePackageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 535);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtCloseDate);
			this.Controls.Add(this.txtReleaseDate);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblCloseDate);
			this.Controls.Add(this.lblReleaseDate);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblHeading);
			this.Name = "CreateServicePackageForm";
			this.Text = "CreateServicePackageForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtCloseDate;
		private System.Windows.Forms.TextBox txtReleaseDate;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblCloseDate;
		private System.Windows.Forms.Label lblReleaseDate;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblHeading;
	}
}