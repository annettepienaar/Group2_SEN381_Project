using Group2_SEN381_Project.BusinessLogicLayer;
using Group2_SEN381_Project.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_SEN381_Project.PresentationLayer
{
	public partial class CreateServicePackageForm : Form
	{
		public CreateServicePackageForm()
		{
			InitializeComponent();
		}

		private void lblName_Click(object sender, EventArgs e)
		{

		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			
		}

        private void btnExit_Click(object sender, EventArgs e)
        {
			this.Close();
        }

		private void CreateServicePackageForm_Load(object sender, EventArgs e)
		{

		}

		private void btnCreate_Click_1(object sender, EventArgs e)
		{
			string spName = txtName.Text,
			spReleaseDate = dpReleaseDate.Text,
			spCloseDate = dpCloseDate.Text,
			epName = txtEpName.Text,
			epModel = txtEpModel.Text,
			epSerial = txtEpSerial.Text;

			if ( spName == "" || cbType.SelectedIndex == -1 || cbPriority.SelectedIndex == -1 || epName == "" || epModel == "" || epSerial == "")
			{
				MessageBox.Show("Please ensure all required information is entered.");
			}
			else
			{
				ServicePackageHandler.CreateSP(spName, cbType.SelectedItem.ToString(), cbPriority.SelectedItem.ToString(), epName, epModel, epSerial, spReleaseDate, spCloseDate);
				MessageBox.Show("Service Package added successfully.");

				txtName.Text = "";
				cbType.SelectedIndex = -1;
				cbPriority.SelectedIndex = -1;
				txtEpName.Text = "";
				txtEpModel.Text = "";
				txtEpSerial.Text = "";
			}
		}

		#region Form Move Functions
		//Code to make the form movable, detects when the mouse button is pressed and move to its location
		private bool mouseDown;
		private Point lastLocation;
		private void MenuBar_MouseDown(object sender, MouseEventArgs e)
        {
			mouseDown = true;
			lastLocation = e.Location;
		}

        private void MenuBar_MouseMove(object sender, MouseEventArgs e)
        {
			if (mouseDown)
			{
				this.Location = new Point(
				(this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

				this.Update();
			}
		}

        private void MenuBar_MouseUp(object sender, MouseEventArgs e)
        {
			mouseDown = false;
		}
        #endregion

    }
}
