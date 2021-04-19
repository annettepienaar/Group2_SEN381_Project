
namespace Group2_SEN381_Project.PresentationLayer
{
	partial class ServiceCreationInterface
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblSPNameTitle = new System.Windows.Forms.Label();
			this.lblReleaseDateTitle = new System.Windows.Forms.Label();
			this.lblCloseDateTitle = new System.Windows.Forms.Label();
			this.lblDescriptionTitle = new System.Windows.Forms.Label();
			this.txtSPName = new System.Windows.Forms.TextBox();
			this.txtReleaseDate = new System.Windows.Forms.TextBox();
			this.txtCloseDate = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(380, 37);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Create Service Package";
			// 
			// lblSPNameTitle
			// 
			this.lblSPNameTitle.AutoSize = true;
			this.lblSPNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSPNameTitle.Location = new System.Drawing.Point(39, 79);
			this.lblSPNameTitle.Name = "lblSPNameTitle";
			this.lblSPNameTitle.Size = new System.Drawing.Size(80, 20);
			this.lblSPNameTitle.TabIndex = 1;
			this.lblSPNameTitle.Text = "SP Name:";
			// 
			// lblReleaseDateTitle
			// 
			this.lblReleaseDateTitle.AutoSize = true;
			this.lblReleaseDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReleaseDateTitle.Location = new System.Drawing.Point(39, 115);
			this.lblReleaseDateTitle.Name = "lblReleaseDateTitle";
			this.lblReleaseDateTitle.Size = new System.Drawing.Size(111, 20);
			this.lblReleaseDateTitle.TabIndex = 2;
			this.lblReleaseDateTitle.Text = "Release Date:";
			// 
			// lblCloseDateTitle
			// 
			this.lblCloseDateTitle.AutoSize = true;
			this.lblCloseDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCloseDateTitle.Location = new System.Drawing.Point(39, 156);
			this.lblCloseDateTitle.Name = "lblCloseDateTitle";
			this.lblCloseDateTitle.Size = new System.Drawing.Size(92, 20);
			this.lblCloseDateTitle.TabIndex = 3;
			this.lblCloseDateTitle.Text = "Close Date:";
			// 
			// lblDescriptionTitle
			// 
			this.lblDescriptionTitle.AutoSize = true;
			this.lblDescriptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDescriptionTitle.Location = new System.Drawing.Point(39, 193);
			this.lblDescriptionTitle.Name = "lblDescriptionTitle";
			this.lblDescriptionTitle.Size = new System.Drawing.Size(89, 20);
			this.lblDescriptionTitle.TabIndex = 4;
			this.lblDescriptionTitle.Text = "Description";
			// 
			// txtSPName
			// 
			this.txtSPName.Location = new System.Drawing.Point(186, 83);
			this.txtSPName.Name = "txtSPName";
			this.txtSPName.Size = new System.Drawing.Size(152, 20);
			this.txtSPName.TabIndex = 5;
			// 
			// txtReleaseDate
			// 
			this.txtReleaseDate.Location = new System.Drawing.Point(186, 119);
			this.txtReleaseDate.Name = "txtReleaseDate";
			this.txtReleaseDate.Size = new System.Drawing.Size(152, 20);
			this.txtReleaseDate.TabIndex = 6;
			this.txtReleaseDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtCloseDate
			// 
			this.txtCloseDate.Location = new System.Drawing.Point(186, 158);
			this.txtCloseDate.Name = "txtCloseDate";
			this.txtCloseDate.Size = new System.Drawing.Size(152, 20);
			this.txtCloseDate.TabIndex = 7;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(43, 229);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(295, 173);
			this.txtDescription.TabIndex = 8;
			// 
			// ServiceCreationInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 435);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtCloseDate);
			this.Controls.Add(this.txtReleaseDate);
			this.Controls.Add(this.txtSPName);
			this.Controls.Add(this.lblDescriptionTitle);
			this.Controls.Add(this.lblCloseDateTitle);
			this.Controls.Add(this.lblReleaseDateTitle);
			this.Controls.Add(this.lblSPNameTitle);
			this.Controls.Add(this.lblTitle);
			this.Name = "ServiceCreationInterface";
			this.Text = "ServiceCreationInterface";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblSPNameTitle;
		private System.Windows.Forms.Label lblReleaseDateTitle;
		private System.Windows.Forms.Label lblCloseDateTitle;
		private System.Windows.Forms.Label lblDescriptionTitle;
		private System.Windows.Forms.TextBox txtSPName;
		private System.Windows.Forms.TextBox txtReleaseDate;
		private System.Windows.Forms.TextBox txtCloseDate;
		private System.Windows.Forms.TextBox txtDescription;
	}
}