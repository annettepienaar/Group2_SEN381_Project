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
			if (txtName.Text == "" || txtReleaseDate.Text == "" || txtCloseDate.Text == "" || txtDescription.Text == "")
			{
				MessageBox.Show("Please ensure you provide all the required information.");
			}
			else
			{
				//TO DO: Implement new ID-requirements
				ServicePackageHandler.AddSP(new ServicePackage("2021FA0008", txtName.Text, txtDescription.Text, txtReleaseDate.Text, txtCloseDate.Text));
			}
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

		}

		private void txtDescription_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblDescription_Click(object sender, EventArgs e)
		{

		}
	}
}
