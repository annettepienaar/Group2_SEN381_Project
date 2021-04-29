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
				ServicePackageHandler.UpdateSP(selectedSP.SPID, txtSPName.Text, txtSPType.Text, txtSPPriority.Text, txtEPName.Text, txtEPModel.Text, txtEPSerialnum.Text, txtReleaseDate.Text, txtReleaseDate.Text);
				spList = ServicePackageHandler.GetAllSP();
				lbServicePackages.DataSource = spList;
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
                txtSPID.Text = selectedSP.SPID;
				txtSPName.Text = selectedSP.SPName;
				txtSPType.Text = selectedSP.SPType;
				txtSPPriority.Text = selectedSP.SPPriority;
				txtEPName.Text = selectedSP.EPName;
				txtEPModel.Text = selectedSP.EPModel;
				txtEPSerialnum.Text = selectedSP.EPSerialnum;
                txtReleaseDate.Text = selectedSP.SPReleaseDate;
                txtCloseDate.Text = selectedSP.SPCloseDate;
            }
        }


    }
}
