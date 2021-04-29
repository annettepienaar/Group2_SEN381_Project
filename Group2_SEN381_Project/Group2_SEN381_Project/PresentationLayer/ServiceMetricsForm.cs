using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group2_SEN381_Project.BusinessLogicLayer;
using Group2_SEN381_Project.DataAccessLayer;

namespace Group2_SEN381_Project.PresentationLayer
{
	public partial class ServiceMetricsForm : Form
	{
		List<ServicePackage> spList;

		public ServiceMetricsForm(SatisfactionEmployee satisfactionEmployee)
		{
			InitializeComponent();
			spList = ServicePackageHandler.GetAllSP();
			lbServicePackages.DataSource = spList;
		}

		private void btnAddServicePackage_Click(object sender, EventArgs e)
		{
			CreateServicePackageForm newForm = new CreateServicePackageForm();
			newForm.Show();
		}

		private void btnUpdatePackage_Click(object sender, EventArgs e)
		{
			int index = lbServicePackages.SelectedIndex;
			if (index == -1)
			{
				MessageBox.Show("Service Package not found.");
			}
			else
			{
				ServicePackage selectedSP = spList[index];
				ServicePackageHandler.UpdateSP(selectedSP.SPID, selectedSP.SPName, txtDescription.Text, txtReleaseDate.Text, txtReleaseDate.Text);
				spList = ServicePackageHandler.GetAllSP();
			}

		}

		private void lbServicePackages_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = lbServicePackages.SelectedIndex;
			if (index == -1)
			{
				MessageBox.Show("Service Package not found.");
			}
			else
			{
				ServicePackage selectedSP = spList[index];
				lblPackageName.Text = selectedSP.SPName;
				txtReleaseDate.Text = selectedSP.SPReleaseDate;
				txtCloseDate.Text = selectedSP.SPCloseDate;
				txtDescription.Text = selectedSP.SPDesc;
			}

			// TO DO:
			// Display Service Package subcriber-count
			// Display Performance metrics
		}

	}
}
